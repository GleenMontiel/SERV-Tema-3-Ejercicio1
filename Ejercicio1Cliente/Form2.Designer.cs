namespace Ejercicio1Cliente
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtInternetProtocol = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblInternetProtocol = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(157, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(70, 20);
            this.txtPort.TabIndex = 13;
            // 
            // txtInternetProtocol
            // 
            this.txtInternetProtocol.Location = new System.Drawing.Point(12, 32);
            this.txtInternetProtocol.Name = "txtInternetProtocol";
            this.txtInternetProtocol.Size = new System.Drawing.Size(136, 20);
            this.txtInternetProtocol.TabIndex = 12;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(154, 15);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(41, 13);
            this.lblPuerto.TabIndex = 11;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblInternetProtocol
            // 
            this.lblInternetProtocol.AutoSize = true;
            this.lblInternetProtocol.Location = new System.Drawing.Point(9, 15);
            this.lblInternetProtocol.Name = "lblInternetProtocol";
            this.lblInternetProtocol.Size = new System.Drawing.Size(20, 13);
            this.lblInternetProtocol.TabIndex = 10;
            this.lblInternetProtocol.Text = "IP:";
            // 
            // btnConectar
            // 
            this.btnConectar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConectar.Location = new System.Drawing.Point(12, 67);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(215, 23);
            this.btnConectar.TabIndex = 14;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(13, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnConectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(246, 133);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtInternetProtocol);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblInternetProtocol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.TextBox txtInternetProtocol;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblInternetProtocol;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCancelar;
    }
}