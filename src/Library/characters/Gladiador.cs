using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Gladiador : Character
    {
        public Gladiador(string name)
            : base(name)
        {
            this.Health = 200;
            this.AddItem(new MagicIce());
        }
    }
}