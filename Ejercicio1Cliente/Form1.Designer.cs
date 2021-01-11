namespace Ejercicio1Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHora = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(245, 23);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(75, 23);
            this.btnHora.TabIndex = 0;
            this.btnHora.Text = "Hora";
            this.btnHora.UseVisualStyleBackColor = true;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(245, 52);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 1;
            this.btnFecha.Text = "Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(245, 81);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTodo.TabIndex = 2;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(245, 110);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(14, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 98);
            this.textBox1.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(14, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(61, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Respuesta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 143);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 1 Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInfo;
    }
}

