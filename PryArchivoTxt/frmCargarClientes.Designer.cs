namespace PryArchivoTxt
{
    partial class frmCargarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.llCodigo = new System.Windows.Forms.Label();
            this.gpbCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCargaDatos
            // 
            this.gpbCargaDatos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbCargaDatos.Controls.Add(this.btnCargar);
            this.gpbCargaDatos.Controls.Add(this.txtLimite);
            this.gpbCargaDatos.Controls.Add(this.txtNombre);
            this.gpbCargaDatos.Controls.Add(this.txtDeuda);
            this.gpbCargaDatos.Controls.Add(this.txtCodigo);
            this.gpbCargaDatos.Controls.Add(this.lblLimiteCredito);
            this.gpbCargaDatos.Controls.Add(this.lblNombre);
            this.gpbCargaDatos.Controls.Add(this.lblDeuda);
            this.gpbCargaDatos.Controls.Add(this.llCodigo);
            this.gpbCargaDatos.Location = new System.Drawing.Point(52, 40);
            this.gpbCargaDatos.Name = "gpbCargaDatos";
            this.gpbCargaDatos.Size = new System.Drawing.Size(576, 215);
            this.gpbCargaDatos.TabIndex = 0;
            this.gpbCargaDatos.TabStop = false;
            this.gpbCargaDatos.Text = "Carga de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(427, 172);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(402, 119);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(402, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(155, 119);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(155, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(279, 119);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(84, 13);
            this.lblLimiteCredito.TabIndex = 3;
            this.lblLimiteCredito.Text = "Limite de crédito";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(279, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre y Apelldio";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(72, 119);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda";
            // 
            // llCodigo
            // 
            this.llCodigo.AutoSize = true;
            this.llCodigo.Location = new System.Drawing.Point(71, 37);
            this.llCodigo.Name = "llCodigo";
            this.llCodigo.Size = new System.Drawing.Size(40, 13);
            this.llCodigo.TabIndex = 0;
            this.llCodigo.Text = "Código";
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 340);
            this.Controls.Add(this.gpbCargaDatos);
            this.Name = "frmCargarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.gpbCargaDatos.ResumeLayout(false);
            this.gpbCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCargaDatos;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label llCodigo;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCargar;
    }
}