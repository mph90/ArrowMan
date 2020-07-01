/* Parent class for all enemy classes */
namespace ArrowMan
{
    class EnemyObject : GameObject
    {
        public int killPoints { get; protected set; }   // Number of points an enemy object is worth

        
        public virtual void Bob() { } // Virtual method allows different types of enemy object to bob differently
    }
}
