﻿namespace FibonacciWinFormTest
{
    partial class FibonacciWinForm
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
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Compute Fibonacci 10
            // 
            this.fibonacciButton.Location = new System.Drawing.Point(55, 47);
            this.fibonacciButton.Name = "Fibonacci Button";
            this.fibonacciButton.Size = new System.Drawing.Size(161, 45);
            this.fibonacciButton.TabIndex = 0;
            this.fibonacciButton.Text = "Compute Fibonacci(10)";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            this.fibonacciButton.Click += new System.EventHandler(this.fibonacciCompute_Click);
            // 
            // FibonacciWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.fibonacciButton);
            this.Name = "FibonacciWinForm";
            this.Text = "Fibonacci 10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fibonacciButton;
    }
}

