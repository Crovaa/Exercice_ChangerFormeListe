using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Cercle : Forme
    {
        public Cercle() : base(Color.Orange)
        {

        }
        protected override void Dessiner(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(color),15,15,80,80);
        }

        protected override string ObtenirType()
        {
            return "Cercle";
        }
    }
}
