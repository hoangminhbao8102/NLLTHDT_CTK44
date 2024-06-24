using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai2
{
    public delegate void BombDetonationHandler(int bombId);

    public class Bomb
    {
        public int BombId { get; set; }
        public Bomb ConnectedBomb { get; set; }

        public event BombDetonationHandler OnDetonate;

        public Bomb(int id)
        {
            BombId = id;
        }

        public void Detonate()
        {
            Console.WriteLine($"Bomb {BombId} has exploded!");
            OnDetonate?.Invoke(BombId);

            if (ConnectedBomb != null)
            {
                ConnectedBomb.Detonate();
            }
        }
    }
}
