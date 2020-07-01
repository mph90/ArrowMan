/* Class for the player character */
namespace ArrowMan
{
    class PlayerObject : GameObject
    {
        public bool movingUp;   // True if the player is pressing W
        public bool movingDown; // True if the player is pressing S

        // Constructor for the player
        public PlayerObject(int x, int y)
        {
            sprite = Properties.Resources.player;

            xPos = x;
            yPos = y;
        }

        // Method that updates player speed and position based on player input
        public override void UpdatePos()
        {
            if (movingUp && !movingDown) // If W is pressed
            {
                ySpeed = -8;
            }
            else if (!movingUp && movingDown) // If S is pressed
            {
                ySpeed = 8;
            }
            else // If both or neither are pressed
            {
                ySpeed = 0;
            }
            xPos += xSpeed;
            yPos += ySpeed;
        }
    }
}
