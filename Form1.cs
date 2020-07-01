/* ArrowMan game source code*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArrowMan
{
    public partial class Form1 : Form
    {
        List<GameObject> objects; // List of all GameObjects
        List<EnemyObject> enemyObjects; // List of all EnemyObjects
        PlayerObject playerOne;
        MissileObject arrow;
        Random rnd = new Random(); // Create random values for spawning balloons

        private int x; // Used to store calculated x values for constructor parameters
        private int y; // Used to store calculated y values for contructor parameters
        private int super; // Stores random numbers to determine the type of balloon that spawns
        private int playerPoints; // Total score
        private bool gameOverState; // Determines if the game has ended

        public Form1()
        {
            InitializeComponent();

            // Sets the GameWindow as the parent for all labels so that background transparency works correctly
            ScoreLabel.Parent = GameWindow;
            GameOverLabel.Parent = GameWindow;
            FinalScoreLabel.Parent = GameWindow;

            // Calculate the player starting location based on the size of the screen
            x = GameWindow.Width / 15;
            y = GameWindow.Height / 2 + 64;

            // Spawn the player and add them to the list of GameObjects
            objects = new List<GameObject>();
            playerOne = new PlayerObject(x, y);
            objects.Add(playerOne);

            // Create the list for EnemyObjects
            enemyObjects = new List<EnemyObject>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Set the player object to movingUp
            if (e.KeyCode == Keys.W)
            {
                playerOne.movingUp = true;
            }

            // Set the player object to be movingDown
            if (e.KeyCode == Keys.S)
            {
                playerOne.movingDown = true;
            }

            // Fire an arrow if there is not one in play and at it to the list of game objects
            if (e.KeyCode == Keys.Space && arrow == null)
            {
                x = GameWindow.Width / 15; // x coordinate for arrow spawn
                y = playerOne.yPos + 36; // current y coordinate of player bow
                arrow = new MissileObject(x, y);
                objects.Add(arrow);
            }

            // Restart the application and close the previous instance if the game is over
            if (e.KeyCode == Keys.R && gameOverState == true)
            {
                Application.Restart();
                Environment.Exit(0);
            }

            // Close the application
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            // Set the player object to be not movingUp
            if (e.KeyCode == Keys.W)
            {
                playerOne.movingUp = false;
            }

            // Set the player object to be not movingDown
            if (e.KeyCode == Keys.S)
            {
                playerOne.movingDown = false;
            }
        }

        private void FrameTick_Tick(object sender, EventArgs e)
        {
            // Update position of all GameObjects
            foreach (GameObject n in objects)
            {
                n.UpdatePos();
            }
        
            for (int i = 0; i < enemyObjects.Count; i++) // Loop through all EnemyObjects
            {
                EnemyObject m = enemyObjects[i];

                if (m.xPos < 0) // Check if an EnemyObject has passed the player
                {
                    gameOverState = true;

                    // Stop timers
                    FrameTick.Enabled = false;
                    SpawnTick.Enabled = false;
                    BobTick.Enabled = false;

                    // Remove in game score counter
                    ScoreLabel.Visible = false;

                    // Position Game Over message based on resolution and turn it on
                    GameOverLabel.Left = GameWindow.Width / 2 - GameOverLabel.Width / 2;
                    GameOverLabel.Top = GameWindow.Height / 2 - GameOverLabel.Height / 2 - 32;
                    GameOverLabel.Visible = true;

                    // Position final score relative to Game Over message and turn it on
                    FinalScoreLabel.Text = "You scored: " + playerPoints + " - Press R to restart.";
                    FinalScoreLabel.Left = GameWindow.Width / 2 - FinalScoreLabel.Width / 2;
                    FinalScoreLabel.Top = GameOverLabel.Bottom + 13;
                    FinalScoreLabel.Visible = true;
                }

                if (arrow != null && IsColliding(m) == true) // Check if the an arrow has collided with an EnemyObject
                {
                    // Update the score
                    playerPoints += m.killPoints;
                    ScoreLabel.Text = "Score: " + playerPoints;

                    // Calculate where to put unused objects based on resolution
                    y = GameWindow.Height + 256;

                    // Move the arrow off screen and set to null for garbage collection
                    arrow.SendToTrash(y);
                    arrow = null;

                    // Move the EnemyObject off screen and set to null for garbage collection
                    m.SendToTrash(y);
                    m = null;
                }
            }

            if (arrow != null && arrow.xPos > GameWindow.Width) // Check if an arrow has left the screen
            {
                arrow = null; // Set arrow to null for garbage collection, and to let the player fire a new arrow
            }

            GameWindow.Invalidate(); // Invalidate the picture box to force the graphics to update
        }

        private void SpawnTick_Tick(object sender, EventArgs e)
        {
            x = GameWindow.Width; // Put the balloons to the right of the screen, based on resolution
            y = rnd.Next(64 , GameWindow.Height - 148); // Randomly generate a height for the balloons to spawn based on resolution
            super = rnd.Next(0, 9); // Generate a random number from 0 - 9
            
            // Create a regular balloon and add it to both lists 9/10 times
            if (super > 0) 
            {
                
                Balloon temp = new Balloon(x, y);
                objects.Add(temp);
                enemyObjects.Add(temp);
            }
            // Create a superballoon and add it to both lists 1/10 times
            else
            {
                
                SuperBalloon temp = new SuperBalloon(x, y);
                objects.Add(temp);
                enemyObjects.Add(temp);
            }

            // Reduce time between spawns by a quarter of a second to a minimum of one
            if (SpawnTick.Interval > 1000)
            {
                SpawnTick.Interval -= 250;
            }
        }

        // Change the direction of all enemy objects at a set interval.
        private void BobTick_Tick(object sender, EventArgs e)
        {       
            foreach (EnemyObject m in enemyObjects)
            {
                m.Bob();
            }
        }

        // Draw the graphics on the screen
        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            foreach (GameObject n in objects)
            {
                n.Draw(e.Graphics);
            }
        }
        
        // Method to detect collisons between arrows and other objects
        private bool IsColliding(GameObject a)
        {
            bool colliding = true; // Assume that there is a collision
            
            // Test if the collision is false
            if (arrow.xPosRight < a.xPos)
            {
                colliding = false;
            }
            if (arrow.xPos > a.xPosRight)
            {
                colliding = false;
            }
            if (arrow.yPosBottom < a.yPos)
            {
                colliding = false;
            }
            if (arrow.yPos > a.yPosBottom)
            {
                colliding = false;
            }
            return colliding;
        }
    }
}
