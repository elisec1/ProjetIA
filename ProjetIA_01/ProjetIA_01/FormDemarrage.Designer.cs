using System;

namespace ProjetIA_01
{
    partial class FormDemarrage
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
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Location = new System.Drawing.Point(400, 136);
            this.btnDemarrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(135, 119);
            this.btnDemarrer.TabIndex = 5;
            this.btnDemarrer.Text = "Démarrer";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // FormDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.btnDemarrer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDemarrage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDemarrer;
    }
}

