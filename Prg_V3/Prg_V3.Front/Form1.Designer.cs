namespace Prg_V3.Front
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
            this.btComparar = new System.Windows.Forms.Button();
            this.lblsalida = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.btDividir = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btComparar
            // 
            this.btComparar.Font = new System.Drawing.Font("Futura Std Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComparar.Location = new System.Drawing.Point(240, 47);
            this.btComparar.Name = "btComparar";
            this.btComparar.Size = new System.Drawing.Size(75, 23);
            this.btComparar.TabIndex = 0;
            this.btComparar.Text = "Comparar";
            this.btComparar.UseVisualStyleBackColor = true;
            this.btComparar.Click += new System.EventHandler(this.btComparar_Click);
            // 
            // lblsalida
            // 
            this.lblsalida.AutoSize = true;
            this.lblsalida.Font = new System.Drawing.Font("Futura Std Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalida.Location = new System.Drawing.Point(46, 141);
            this.lblsalida.Name = "lblsalida";
            this.lblsalida.Size = new System.Drawing.Size(215, 28);
            this.lblsalida.TabIndex = 1;
            this.lblsalida.Text = "                             ";
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(69, 38);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 20);
            this.txtDato1.TabIndex = 2;
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(69, 85);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 20);
            this.txtDato2.TabIndex = 3;
            // 
            // btDividir
            // 
            this.btDividir.Font = new System.Drawing.Font("Futura Std Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.Location = new System.Drawing.Point(240, 85);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(75, 23);
            this.btDividir.TabIndex = 4;
            this.btDividir.Text = "Dividir";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Futura Std Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(240, 124);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 225);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lblsalida);
            this.Controls.Add(this.btComparar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btComparar;
        private System.Windows.Forms.Label lblsalida;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btCalcular;
    }
}

