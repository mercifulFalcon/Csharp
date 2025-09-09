namespace Escalera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Font = new System.Drawing.Font("Futura Std Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(72, 86);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 28);
            this.txtMin.TabIndex = 0;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Futura Std Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(303, 86);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 28);
            this.txtMax.TabIndex = 1;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnContar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContar.Font = new System.Drawing.Font("Futura Std Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(191, 151);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(80, 28);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Escalera";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(165, 216);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(135, 95);
            this.lstResultados.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Std Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(461, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Name = "Form1";
            this.Text = "Escalera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

