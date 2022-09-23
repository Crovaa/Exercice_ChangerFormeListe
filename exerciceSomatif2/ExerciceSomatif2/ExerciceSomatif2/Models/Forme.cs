using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        public Color color;

        public string type;    
        protected abstract void Dessiner(Graphics graphics);
        protected abstract string ObtenirType();

        public Forme(Color color)
        {
            this.color = color;
            type = ObtenirType();
        }

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Dessiner(graphics);
            }
            return bitmap;
        }
    }
}
