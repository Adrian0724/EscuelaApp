namespace Asignatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_CodigoAsignatura = new System.Windows.Forms.TextBox();
            this.tx_NombreAsignatura = new System.Windows.Forms.TextBox();
            this.tx_Creditos = new System.Windows.Forms.TextBox();
            this.tx_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creditos";
            // 
            // tx_CodigoAsignatura
            // 
            this.tx_CodigoAsignatura.Location = new System.Drawing.Point(187, 65);
            this.tx_CodigoAsignatura.Name = "tx_CodigoAsignatura";
            this.tx_CodigoAsignatura.Size = new System.Drawing.Size(173, 22);
            this.tx_CodigoAsignatura.TabIndex = 3;
            // 
            // tx_NombreAsignatura
            // 
            this.tx_NombreAsignatura.Location = new System.Drawing.Point(188, 97);
            this.tx_NombreAsignatura.Name = "tx_NombreAsignatura";
            this.tx_NombreAsignatura.Size = new System.Drawing.Size(172, 22);
            this.tx_NombreAsignatura.TabIndex = 4;
            // 
            // tx_Creditos
            // 
            this.tx_Creditos.Location = new System.Drawing.Point(187, 133);
            this.tx_Creditos.Name = "tx_Creditos";
            this.tx_Creditos.Size = new System.Drawing.Size(173, 22);
            this.tx_Creditos.TabIndex = 5;
            // 
            // tx_aceptar
            // 
            this.tx_aceptar.Location = new System.Drawing.Point(226, 180);
            this.tx_aceptar.Name = "tx_aceptar";
            this.tx_aceptar.Size = new System.Drawing.Size(103, 40);
            this.tx_aceptar.TabIndex = 6;
            this.tx_aceptar.Text = "Aceptar";
            this.tx_aceptar.UseVisualStyleBackColor = true;
            this.tx_aceptar.Click += new System.EventHandler(this.tx_aceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 291);
            this.Controls.Add(this.tx_aceptar);
            this.Controls.Add(this.tx_Creditos);
            this.Controls.Add(this.tx_NombreAsignatura);
            this.Controls.Add(this.tx_CodigoAsignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Asignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_CodigoAsignatura;
        private System.Windows.Forms.TextBox tx_NombreAsignatura;
        private System.Windows.Forms.TextBox tx_Creditos;
        private System.Windows.Forms.Button tx_aceptar;
    }
}

