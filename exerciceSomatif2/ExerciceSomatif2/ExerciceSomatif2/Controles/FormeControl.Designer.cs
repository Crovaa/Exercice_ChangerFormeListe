namespace ExerciceSomatif2.Controles
{
    partial class FormeControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb_Forme = new System.Windows.Forms.PictureBox();
            this.lbl_FormeType = new System.Windows.Forms.Label();
            this.lbl_AffichageTypeForme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Forme)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Forme
            // 
            this.pcb_Forme.Location = new System.Drawing.Point(193, 52);
            this.pcb_Forme.Name = "pcb_Forme";
            this.pcb_Forme.Size = new System.Drawing.Size(351, 265);
            this.pcb_Forme.TabIndex = 0;
            this.pcb_Forme.TabStop = false;
            // 
            // lbl_FormeType
            // 
            this.lbl_FormeType.AutoSize = true;
            this.lbl_FormeType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FormeType.Location = new System.Drawing.Point(127, 19);
            this.lbl_FormeType.Name = "lbl_FormeType";
            this.lbl_FormeType.Size = new System.Drawing.Size(160, 30);
            this.lbl_FormeType.TabIndex = 1;
            this.lbl_FormeType.Text = "Type de Forme :";
            // 
            // lbl_AffichageTypeForme
            // 
            this.lbl_AffichageTypeForme.AutoSize = true;
            this.lbl_AffichageTypeForme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AffichageTypeForme.Location = new System.Drawing.Point(282, 19);
            this.lbl_AffichageTypeForme.Name = "lbl_AffichageTypeForme";
            this.lbl_AffichageTypeForme.Size = new System.Drawing.Size(215, 30);
            this.lbl_AffichageTypeForme.TabIndex = 2;
            this.lbl_AffichageTypeForme.Text = "Affichage Type Forme";
            // 
            // FormeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_AffichageTypeForme);
            this.Controls.Add(this.lbl_FormeType);
            this.Controls.Add(this.pcb_Forme);
            this.Name = "FormeControl";
            this.Size = new System.Drawing.Size(664, 336);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Forme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcb_Forme;
        private Label lbl_FormeType;
        private Label lbl_AffichageTypeForme;
    }
}
