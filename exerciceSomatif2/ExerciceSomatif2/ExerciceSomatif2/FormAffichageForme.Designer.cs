namespace ExerciceSomatif2
{
    partial class FormAffichageForme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ChangerForme = new System.Windows.Forms.Button();
            this.formeControl1 = new ExerciceSomatif2.Controles.FormeControl();
            this.SuspendLayout();
            // 
            // btn_ChangerForme
            // 
            this.btn_ChangerForme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangerForme.Location = new System.Drawing.Point(273, 367);
            this.btn_ChangerForme.Name = "btn_ChangerForme";
            this.btn_ChangerForme.Size = new System.Drawing.Size(205, 54);
            this.btn_ChangerForme.TabIndex = 0;
            this.btn_ChangerForme.Text = "Changer Forme";
            this.btn_ChangerForme.UseVisualStyleBackColor = true;
            this.btn_ChangerForme.Click += new System.EventHandler(this.btn_ChangerForme_Click);
            // 
            // formeControl1
            // 
            this.formeControl1.Forme = null;
            this.formeControl1.Location = new System.Drawing.Point(125, 161);
            this.formeControl1.Name = "formeControl1";
            this.formeControl1.Size = new System.Drawing.Size(435, 160);
            this.formeControl1.TabIndex = 1;
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formeControl1);
            this.Controls.Add(this.btn_ChangerForme);
            this.Name = "FormAffichageForme";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ChangerForme;
        private Controles.FormeControl formeControl1;
    }
}