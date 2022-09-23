using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Rectangle : Forme
    {
        public Rectangle() : base(Color.Green)
        {

        }
        protected override void Dessiner(Graphics graphics)
        {
                graphics.DrawRectangle(new Pen(color),15,15,80,80);
        }

        protected override string ObtenirType()
        {
            return "Rectangle";
        }
    }
}
