/* Class for yellow super balloons */
namespace ArrowMan
{
    class SuperBalloon : EnemyObject
    {
        // Constructor for a superballoon
        public SuperBalloon(int x, int y)
        {
            killPoints = 10;
            sprite = Properties.Resources.superballoon;

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
                ySpeed = 4;
            }
            else
            {
                ySpeed = -4;
            }
        }
    }
}
