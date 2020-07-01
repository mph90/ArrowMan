/* Class for the missile fired by the player */
namespace ArrowMan
{
    class MissileObject : GameObject
    {
        // Constructor for an arrow
        public MissileObject(int x, int y)
        {
            sprite = Properties.Resources.arrow;

            xPos = x;
            xPosRight = x + sprite.Width;
            yPos = y;
            yPosBottom = y + sprite.Height;

            xSpeed = 32;
        }
    }
}
