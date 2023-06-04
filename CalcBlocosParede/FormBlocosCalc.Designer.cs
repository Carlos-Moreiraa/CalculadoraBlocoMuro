
using System;

namespace CalcBlocosParede
{
    partial class FormBlocosCalc
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
            this.blocoMedio = new System.Windows.Forms.Button();
            this.blocoGrande = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medidaLinhaReta = new System.Windows.Forms.TextBox();
            this.alturaMuro = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blocoMedio
            // 
            this.blocoMedio.Location = new System.Drawing.Point(31, 137);
            this.blocoMedio.Name = "blocoMedio";
            this.blocoMedio.Size = new System.Drawing.Size(75, 23);
            this.blocoMedio.TabIndex = 0;
            this.blocoMedio.Text = "14x19x39";
            this.blocoMedio.UseVisualStyleBackColor = true;
            this.blocoMedio.Click += new System.EventHandler(this.blocoMedio_Click);
            // 
            // blocoGrande
            // 
            this.blocoGrande.Location = new System.Drawing.Point(115, 137);
            this.blocoGrande.Name = "blocoGrande";
            this.blocoGrande.Size = new System.Drawing.Size(75, 23);
            this.blocoGrande.TabIndex = 1;
            this.blocoGrande.Text = "19x19x39";
            this.blocoGrande.UseVisualStyleBackColor = true;
            this.blocoGrande.Click += new System.EventHandler(this.blocoGrande_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a altura do muro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a extenção do muro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione a medida do bloco";
            // 
            // medidaLinhaReta
            // 
            this.medidaLinhaReta.Location = new System.Drawing.Point(31, 81);
            this.medidaLinhaReta.Name = "medidaLinhaReta";
            this.medidaLinhaReta.Size = new System.Drawing.Size(100, 23);
            this.medidaLinhaReta.TabIndex = 5;
            // 
            // alturaMuro
            // 
            this.alturaMuro.Location = new System.Drawing.Point(31, 32);
            this.alturaMuro.Name = "alturaMuro";
            this.alturaMuro.Size = new System.Drawing.Size(100, 23);
            this.alturaMuro.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(31, 193);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(251, 23);
            this.txtResultado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            // 
            // FormBlocosCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.alturaMuro);
            this.Controls.Add(this.medidaLinhaReta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blocoGrande);
            this.Controls.Add(this.blocoMedio);
            this.Name = "FormBlocosCalc";
            this.Text = "Calculadora De Blocos";
            this.Load += new System.EventHandler(this.FormBlocosCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormBlocosCalc_Load(object sender, EventArgs e)
        {
            
        }



        #endregion

        private System.Windows.Forms.Button blocoMedio;
        private System.Windows.Forms.Button blocoGrande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medidaLinhaReta;
        private System.Windows.Forms.TextBox alturaMuro;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
    }
}

