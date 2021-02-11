
namespace Pompe_a_essence
{
    partial class Vue
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.saisieCode1 = new Pompe_a_essence.saisieCode();
            this.insererCarte = new Pompe_a_essence.insererCarte();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pompe à essence Bienvenue ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saisieCode1
            // 
            this.saisieCode1.Location = new System.Drawing.Point(63, 217);
            this.saisieCode1.Name = "saisieCode1";
            this.saisieCode1.Size = new System.Drawing.Size(255, 273);
            this.saisieCode1.TabIndex = 8;
            // 
            // insererCarte
            // 
            this.insererCarte.Location = new System.Drawing.Point(82, 81);
            this.insererCarte.Name = "insererCarte";
            this.insererCarte.Size = new System.Drawing.Size(186, 183);
            this.insererCarte.TabIndex = 7;
            this.insererCarte.Load += new System.EventHandler(this.insererCarte_Load);
            // 
            // Vue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 366);
            this.Controls.Add(this.saisieCode1);
            this.Controls.Add(this.insererCarte);
            this.Controls.Add(this.label1);
            this.Name = "Vue";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private insererCarte insererCarte;
        private saisieCode saisieCode1;
    }
}

