
using System;

namespace Pompe_a_essence
{
    partial class insererCarte
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
            this.btInsererCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInsererCarte
            // 
            this.btInsererCarte.Location = new System.Drawing.Point(16, 71);
            this.btInsererCarte.Name = "btInsererCarte";
            this.btInsererCarte.Size = new System.Drawing.Size(154, 40);
            this.btInsererCarte.TabIndex = 6;
            this.btInsererCarte.Text = "Insérer carte";
            this.btInsererCarte.UseVisualStyleBackColor = true;
            this.btInsererCarte.Click += new System.EventHandler(this.btInsererCarte_Click);
            // 
            // insererCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btInsererCarte);
            this.Name = "insererCarte";
            this.Size = new System.Drawing.Size(186, 183);
            this.Load += new System.EventHandler(this.insererCarte_Load);
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Button btInsererCarte;
    }
}
