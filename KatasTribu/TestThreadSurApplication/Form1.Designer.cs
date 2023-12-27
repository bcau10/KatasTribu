using System;

namespace TestThreadSurApplication
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEvolution = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(136, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(225, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEvolution
            // 
            this.labelEvolution.AutoSize = true;
            this.labelEvolution.Location = new System.Drawing.Point(136, 219);
            this.labelEvolution.Name = "labelEvolution";
            this.labelEvolution.Size = new System.Drawing.Size(51, 13);
            this.labelEvolution.TabIndex = 2;
            this.labelEvolution.Text = "Evolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(136, 253);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(46, 13);
            this.labelResultat.TabIndex = 4;
            this.labelResultat.Text = "Resultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEvolution);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEvolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Label label4;
    }
}

