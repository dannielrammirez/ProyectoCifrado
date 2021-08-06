
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTextOriginial = new System.Windows.Forms.Label();
            this.textBoxTextOriginial = new System.Windows.Forms.TextBox();
            this.lblPalabraClave = new System.Windows.Forms.Label();
            this.textBoxTextClave = new System.Windows.Forms.TextBox();
            this.textBoxTextoCifrado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.labelErrores = new System.Windows.Forms.Label();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelCifrar = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Descifrar = new System.Windows.Forms.Panel();
            this.textBox_Cifrado = new System.Windows.Forms.TextBox();
            this.lblTextoCifrado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelCifrar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_Descifrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBoxTextoCifrado.Location = new System.Drawing.Point(20, 346);
            this.textBoxTextoCifrado.Multiline = true;
            this.textBoxTextoCifrado.Name = "textBoxTextoCifrado";
            this.textBoxTextoCifrado.Size = new System.Drawing.Size(439, 66);
            this.textBoxTextoCifrado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 330);
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
            this.dgMatriz.Size = new System.Drawing.Size(439, 118);
            this.dgMatriz.TabIndex = 9;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabPage1);
            this.tabPanel.Controls.Add(this.tabPage2);
            this.tabPanel.Location = new System.Drawing.Point(12, 13);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(504, 496);
            this.tabPanel.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelCifrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cifrar";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.panelCifrar.Location = new System.Drawing.Point(6, 29);
            this.panelCifrar.Name = "panelCifrar";
            this.panelCifrar.Size = new System.Drawing.Size(481, 434);
            this.panelCifrar.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Descifrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descifrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_Descifrar
            // 
            this.panel_Descifrar.Controls.Add(this.textBox_Cifrado);
            this.panel_Descifrar.Controls.Add(this.lblTextoCifrado);
            this.panel_Descifrar.Controls.Add(this.dataGridView1);
            this.panel_Descifrar.Controls.Add(this.label2);
            this.panel_Descifrar.Controls.Add(this.label3);
            this.panel_Descifrar.Controls.Add(this.textBox2);
            this.panel_Descifrar.Controls.Add(this.button1);
            this.panel_Descifrar.Controls.Add(this.textBox3);
            this.panel_Descifrar.Controls.Add(this.label4);
            this.panel_Descifrar.Location = new System.Drawing.Point(6, 29);
            this.panel_Descifrar.Name = "panel_Descifrar";
            this.panel_Descifrar.Size = new System.Drawing.Size(481, 434);
            this.panel_Descifrar.TabIndex = 12;
            // 
            // textBox_Cifrado
            // 
            this.textBox_Cifrado.Location = new System.Drawing.Point(20, 31);
            this.textBox_Cifrado.Name = "textBox_Cifrado";
            this.textBox_Cifrado.Size = new System.Drawing.Size(439, 20);
            this.textBox_Cifrado.TabIndex = 1;
            // 
            // lblTextoCifrado
            // 
            this.lblTextoCifrado.AutoSize = true;
            this.lblTextoCifrado.Location = new System.Drawing.Point(17, 14);
            this.lblTextoCifrado.Name = "lblTextoCifrado";
            this.lblTextoCifrado.Size = new System.Drawing.Size(70, 13);
            this.lblTextoCifrado.TabIndex = 0;
            this.lblTextoCifrado.Text = "Texto Cifrado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(439, 118);
            this.dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palabra Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(439, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "DESCIFRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 346);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(439, 66);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texto Descifrado";
            // 
            // FormCifrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 521);
            this.Controls.Add(this.tabPanel);
            this.Name = "FormCifrar";
            this.Text = "Gestor de Cifrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelCifrar.ResumeLayout(false);
            this.panelCifrar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel_Descifrar.ResumeLayout(false);
            this.panel_Descifrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelCifrar;
        private System.Windows.Forms.Panel panel_Descifrar;
        private System.Windows.Forms.TextBox textBox_Cifrado;
        private System.Windows.Forms.Label lblTextoCifrado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}