namespace EscuelaApp
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreID = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellidoMAT = new System.Windows.Forms.TextBox();
            this.txtApellidoPAT = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtGuardar = new System.Windows.Forms.Button();
            this.txtBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ApellidoPAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ApellidoMAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "NumeroMatricula";
            // 
            // txtNombreID
            // 
            this.txtNombreID.Location = new System.Drawing.Point(140, 49);
            this.txtNombreID.Name = "txtNombreID";
            this.txtNombreID.Size = new System.Drawing.Size(168, 22);
            this.txtNombreID.TabIndex = 6;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(140, 254);
            this.txtMatricula.Multiline = true;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(160, 26);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 211);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtApellidoMAT
            // 
            this.txtApellidoMAT.Location = new System.Drawing.Point(140, 164);
            this.txtApellidoMAT.Name = "txtApellidoMAT";
            this.txtApellidoMAT.Size = new System.Drawing.Size(168, 22);
            this.txtApellidoMAT.TabIndex = 9;
            // 
            // txtApellidoPAT
            // 
            this.txtApellidoPAT.Location = new System.Drawing.Point(140, 126);
            this.txtApellidoPAT.Name = "txtApellidoPAT";
            this.txtApellidoPAT.Size = new System.Drawing.Size(168, 22);
            this.txtApellidoPAT.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // TxtGuardar
            // 
            this.TxtGuardar.Location = new System.Drawing.Point(162, 331);
            this.TxtGuardar.Name = "TxtGuardar";
            this.TxtGuardar.Size = new System.Drawing.Size(103, 40);
            this.TxtGuardar.TabIndex = 12;
            this.TxtGuardar.Text = "Guardar";
            this.TxtGuardar.UseVisualStyleBackColor = true;
            this.TxtGuardar.Click += new System.EventHandler(this.TxtGuardar_Click);
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(309, 331);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(118, 40);
            this.txtBorrar.TabIndex = 13;
            this.txtBorrar.Text = "Borrar";
            this.txtBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.TxtGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellidoPAT);
            this.Controls.Add(this.txtApellidoMAT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNombreID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreID;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellidoMAT;
        private System.Windows.Forms.TextBox txtApellidoPAT;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button TxtGuardar;
        private System.Windows.Forms.Button txtBorrar;
    }
}

