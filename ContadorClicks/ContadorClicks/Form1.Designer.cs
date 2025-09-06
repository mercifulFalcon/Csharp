namespace ContadorClicks
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
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Futura Std Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Navy;
            this.lblContador.Location = new System.Drawing.Point(9, 102);
            this.lblContador.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(152, 80);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSumar.Font = new System.Drawing.Font("Futura Std Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(183, 31);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(152, 60);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "Incremento";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRestar.Font = new System.Drawing.Font("Futura Std Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(183, 200);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(152, 60);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "Decremento";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 300);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblContador);
            this.Font = new System.Drawing.Font("Futura Std Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
    }
}

