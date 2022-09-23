using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Controleur
    {
        private List<Forme> formes;
        private int idFormeCourante;
        private Forme formeCourante;

        public Forme FormeCourante { get => formeCourante; }
        public EventHandler<Forme> ChangementFormeCouranteEvent;

        public Controleur()
        {
            formes = new List<Forme>();
            formes.Add(new Cercle());
            formes.Add(new Rectangle());
            formes.Add(new CerclePlein());
            formes.Add(new RectanglePlein());
            idFormeCourante = 0;
            formeCourante = formes[idFormeCourante];
        }

        public void ChangerImageCourante()
        {
            idFormeCourante = (idFormeCourante + 1) % formes.Count;
            formeCourante = formes[idFormeCourante];
            ChangementFormeCouranteEvent?.Invoke(this, formeCourante);
        }
    }
}
