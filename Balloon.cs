/* Class for balloons */
namespace ArrowMan
{
    class Balloon : EnemyObject
    {
        // Constructor for a balloon
        public Balloon(int x, int y)
        {
            killPoints = 5;
            sprite = Properties.Resources.balloon;

            xPos = x;
            xPosRight = x + sprite.Width;
            yPos = y;
            yPosBottom = y + sprite.Height;

            xSpeed = -8;
        }

        // Method which changes the vertical speed of an object when called
        public override void Bob()
        {
            if (ySpeed <= 0)
            {
                ySpeed = 1;
            }
            else
            {
                ySpeed = -1;
            }
        }
    }
}
