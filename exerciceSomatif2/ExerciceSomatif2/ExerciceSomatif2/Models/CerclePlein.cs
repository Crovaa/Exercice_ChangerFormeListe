using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class CerclePlein : Cercle
    {
        protected override void Dessiner(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(color),15,15,80,80);
        }

        protected override string ObtenirType()
        {
            return "Cercle Plein";
        }
    }
}
