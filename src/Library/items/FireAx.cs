namespace RoleplayGame.Items {
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class BowAndArrow : IAttackItem {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int FireAx {
            get {
                return 50;
            }
        }

        public override string ToString () {
            return "FireAx";
        }

    }
}