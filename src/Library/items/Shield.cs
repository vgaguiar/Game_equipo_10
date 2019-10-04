namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Shield : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 40;
            }
        }

        public override string ToString()
        {
            return "Shield";
        }
    }
}