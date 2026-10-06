namespace BlaisePascal.Lesson.Domain
{
    public class Enemy
    {
        //attributo
        private int _health;

        //proprietà
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0) // caso di limite 1
                {
                    _health = 0;
                }
                else if (value > 100) // caso di limite 2
                {
                    _health = 100;
                }
                else //caso di normalità
                {
                    _health = value;
                }
            }
        }

        //costruttore
        public Enemy()
        {

        }

        public void setHealth(int newHealth)
        {
            if (newHealth < 0)
                Health = newHealth;
            else if (newHealth > 100)
                Health = 100;
            else
                Health = newHealth;
        }


        public bool isAlive()
        {
            return Health > 0;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                damage = 0
            setHealth(_health - damage);
        }

    }

}


