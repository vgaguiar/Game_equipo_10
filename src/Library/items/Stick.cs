namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Stick : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }


        public override string ToString()
        {
            return "Stick";
        }
    }
}