using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class RectanglePlein : Rectangle
    {
        protected override void Dessiner(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(color),15,15,80,80);
        }

        protected override string ObtenirType()
        {
            return "Rectangle Plein";
        }
    }
}
