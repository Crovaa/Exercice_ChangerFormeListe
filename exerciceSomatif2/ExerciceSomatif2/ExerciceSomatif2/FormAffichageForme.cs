using ExerciceSomatif2.Models;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private Controleur controleur;
        public FormAffichageForme()
        {
            InitializeComponent();
            controleur = new Controleur();
            MAJAffichageForme(controleur.FormeCourante);
            Abonnement();
            
        }

        private void Abonnement()
        {
            controleur.ChangementFormeCouranteEvent += Controleur_ChangementFormeCouranteEvent;
        }
        private void Controleur_ChangementFormeCouranteEvent(object? sender, Forme forme)
        {
            MAJAffichageForme(forme);
        }
        private void MAJAffichageForme(Forme forme)
        {
            formeControl1.Forme = controleur.FormeCourante;
        }

        private void btn_ChangerForme_Click(object sender, EventArgs e)
        {
            controleur.ChangerImageCourante();
        }
    }
}