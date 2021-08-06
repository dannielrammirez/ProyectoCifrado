
namespace ConsolaCifrado
{
    partial class FormCifrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTextOriginial = new System.Windows.Forms.Label();
            this.textBoxTextOriginial = new System.Windows.Forms.TextBox();
            this.lblPalabraClave = new System.Windows.Forms.Label();
            this.textBoxTextClave = new System.Windows.Forms.TextBox();
            this.textBoxTextoCifrado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.labelErrores = new System.Windows.Forms.Label();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.panelCifrar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.panelCifrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextOriginial
            // 
            this.lblTextOriginial.AutoSize = true;
            this.lblTextOriginial.Location = new System.Drawing.Point(17, 14);
            this.lblTextOriginial.Name = "lblTextOriginial";
            this.lblTextOriginial.Size = new System.Drawing.Size(72, 13);
            this.lblTextOriginial.TabIndex = 0;
            this.lblTextOriginial.Text = "Texto Original";
            // 
            // textBoxTextOriginial
            // 
            this.textBoxTextOriginial.Location = new System.Drawing.Point(20, 31);
            this.textBoxTextOriginial.Name = "textBoxTextOriginial";
            this.textBoxTextOriginial.Size = new System.Drawing.Size(439, 20);
            this.textBoxTextOriginial.TabIndex = 1;
            // 
            // lblPalabraClave
            // 
            this.lblPalabraClave.AutoSize = true;
            this.lblPalabraClave.Location = new System.Drawing.Point(17, 63);
            this.lblPalabraClave.Name = "lblPalabraClave";
            this.lblPalabraClave.Size = new System.Drawing.Size(73, 13);
            this.lblPalabraClave.TabIndex = 3;
            this.lblPalabraClave.Text = "Palabra Clave";
            // 
            // textBoxTextClave
            // 
            this.textBoxTextClave.Location = new System.Drawing.Point(20, 80);
            this.textBoxTextClave.Name = "textBoxTextClave";
            this.textBoxTextClave.Size = new System.Drawing.Size(439, 20);
            this.textBoxTextClave.TabIndex = 4;
            // 
            // textBoxTextoCifrado
            // 
            this.textBoxTextoCifrado.Location = new System.Drawing.Point(20, 367);
            this.textBoxTextoCifrado.Multiline = true;
            this.textBoxTextoCifrado.Name = "textBoxTextoCifrado";
            this.textBoxTextoCifrado.Size = new System.Drawing.Size(439, 66);
            this.textBoxTextoCifrado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 351);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Texto Cifrado";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.Location = new System.Drawing.Point(16, 124);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(439, 37);
            this.btnCifrar.TabIndex = 7;
            this.btnCifrar.Text = "CIFRAR";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            this.btnCifrar.Enter += new System.EventHandler(this.btnCifrar_Click);
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.ForeColor = System.Drawing.Color.Red;
            this.labelErrores.Location = new System.Drawing.Point(20, 108);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(0, 13);
            this.labelErrores.TabIndex = 8;
            // 
            // dgMatriz
            // 
            this.dgMatriz.AllowUserToAddRows = false;
            this.dgMatriz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(20, 186);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.ReadOnly = true;
            this.dgMatriz.RowHeadersVisible = false;
            this.dgMatriz.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgMatriz.RowTemplate.Height = 20;
            this.dgMatriz.Size = new System.Drawing.Size(439, 141);
            this.dgMatriz.TabIndex = 9;
            // 
            // panelCifrar
            // 
            this.panelCifrar.Controls.Add(this.textBoxTextOriginial);
            this.panelCifrar.Controls.Add(this.lblTextOriginial);
            this.panelCifrar.Controls.Add(this.dgMatriz);
            this.panelCifrar.Controls.Add(this.lblPalabraClave);
            this.panelCifrar.Controls.Add(this.labelErrores);
            this.panelCifrar.Controls.Add(this.textBoxTextClave);
            this.panelCifrar.Controls.Add(this.btnCifrar);
            this.panelCifrar.Controls.Add(this.textBoxTextoCifrado);
            this.panelCifrar.Controls.Add(this.lblResultado);
            this.panelCifrar.Location = new System.Drawing.Point(12, 30);
            this.panelCifrar.Name = "panelCifrar";
            this.panelCifrar.Size = new System.Drawing.Size(481, 458);
            this.panelCifrar.TabIndex = 11;
            // 
            // FormCifrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 500);
            this.Controls.Add(this.panelCifrar);
            this.Name = "FormCifrar";
            this.Text = "Gestor de Cifrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.panelCifrar.ResumeLayout(false);
            this.panelCifrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTextOriginial;
        private System.Windows.Forms.TextBox textBoxTextOriginial;
        private System.Windows.Forms.Label lblPalabraClave;
        private System.Windows.Forms.TextBox textBoxTextClave;
        private System.Windows.Forms.TextBox textBoxTextoCifrado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.Panel panelCifrar;
    }
}