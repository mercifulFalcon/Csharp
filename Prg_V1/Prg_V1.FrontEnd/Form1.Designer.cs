namespace Prg_V1.FrontEnd
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaludo.Font = new System.Drawing.Font("Futura Std Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(180, 136);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(143, 24);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Hola Mundo!!!!";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaludo
            // 
            this.btnSaludo.Font = new System.Drawing.Font("Futura Std Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludo.Location = new System.Drawing.Point(416, 47);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(90, 39);
            this.btnSaludo.TabIndex = 1;
            this.btnSaludo.Text = "Saludar";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Futura Std Light", 14F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(51, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 198);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Font = new System.Drawing.Font("Futura Std Light", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hola ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

