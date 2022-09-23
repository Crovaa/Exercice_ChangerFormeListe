using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class FormeControl : UserControl
    {
        private Forme forme;

        public Forme Forme
        {
            get => forme;
            set
            {
                forme = value;
                RafraichirAffichageForme();
            }
        }
        public FormeControl()
        {
            InitializeComponent();
        }

        public void RafraichirAffichageForme()
        {
            if (forme is null)
            {
                lbl_AffichageTypeForme.Text = "";
                pcb_Forme.Image = null;
                return;
            }
            lbl_AffichageTypeForme.Text = forme.type;
            pcb_Forme.Image = forme.Dessiner();
        }
    }
}
