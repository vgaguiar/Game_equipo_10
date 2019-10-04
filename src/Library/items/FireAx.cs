namespace RoleplayGame.Items {
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class FireAx : IAttackItem, IDefenseItem {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower {
            get {
                return 50;
            }
        }
        public int DefensePower {
            get {
                return 30;
            }
        }

        public override string ToString () {
            return "FireAx";
        }

    }
}