/* Class for all game objects*/
using System.Drawing;

namespace ArrowMan
{
    class GameObject
    {
        protected Bitmap sprite;    // Graphical image for objects
        public int xPos { get; protected set; } // Horizontal position of an object (left side)
        public int yPos { get; protected set; } // Vertical position of an object (top side)
        public int xPosRight { get; protected set; }    // Horizontal position of an object (right side)
        public int yPosBottom { get; protected set; }   // Vertical position of an object (bottom side)
        protected int xSpeed;   // Horizontal speed of an object
        protected int ySpeed;   // Vertical speed of an object

        // Method to draw an image on the screen
        public void Draw(Graphics g)
        {
            g.DrawImage(sprite, xPos, yPos);
        }

        // Method to update the position of an object based on it's current speed
        public virtual void UpdatePos()
        {
            xPos += xSpeed;
            xPosRight += xSpeed;

            yPos += ySpeed;
            yPosBottom += ySpeed;
        }

        // Method to remove an object from the game area
        public void SendToTrash(int y)
        {
            yPos = y;
            yPosBottom = y;

            xSpeed = 0;
            ySpeed = 0;
        }

    }
}