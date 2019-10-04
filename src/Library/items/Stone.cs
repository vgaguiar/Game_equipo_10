namespace RoleplayGame.Items
{
    public class Stone
    {
        private int power;
        public Stone()
        {
            power=50;
            this.Power=power;
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
    }
}