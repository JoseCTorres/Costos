namespace Costos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ProduccTerminada = new System.Windows.Forms.TextBox();
            this.Proceso = new System.Windows.Forms.TextBox();
            this.Avance = new System.Windows.Forms.TextBox();
            this.Proceso2 = new System.Windows.Forms.TextBox();
            this.Avance2 = new System.Windows.Forms.TextBox();
            this.concepto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(30, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(959, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Produccion terminada";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Proceso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "% Avance";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Produccion equivalente";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Proceso";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "% Avance";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Produccion equivalente";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Produccion Procesada";
            this.Column9.Name = "Column9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProduccTerminada
            // 
            this.ProduccTerminada.Location = new System.Drawing.Point(72, 26);
            this.ProduccTerminada.Name = "ProduccTerminada";
            this.ProduccTerminada.Size = new System.Drawing.Size(143, 23);
            this.ProduccTerminada.TabIndex = 2;
            // 
            // Proceso
            // 
            this.Proceso.Location = new System.Drawing.Point(72, 68);
            this.Proceso.Name = "Proceso";
            this.Proceso.Size = new System.Drawing.Size(100, 23);
            this.Proceso.TabIndex = 3;
            // 
            // Avance
            // 
            this.Avance.Location = new System.Drawing.Point(72, 109);
            this.Avance.Name = "Avance";
            this.Avance.Size = new System.Drawing.Size(100, 23);
            this.Avance.TabIndex = 4;
            // 
            // Proceso2
            // 
            this.Proceso2.Location = new System.Drawing.Point(303, 32);
            this.Proceso2.Name = "Proceso2";
            this.Proceso2.Size = new System.Drawing.Size(100, 23);
            this.Proceso2.TabIndex = 5;
            // 
            // Avance2
            // 
            this.Avance2.Location = new System.Drawing.Point(303, 68);
            this.Avance2.Name = "Avance2";
            this.Avance2.Size = new System.Drawing.Size(100, 23);
            this.Avance2.TabIndex = 6;
            // 
            // concepto
            // 
            this.concepto.Location = new System.Drawing.Point(72, -3);
            this.concepto.Name = "concepto";
            this.concepto.Size = new System.Drawing.Size(100, 23);
            this.concepto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.concepto);
            this.Controls.Add(this.Avance2);
            this.Controls.Add(this.Proceso2);
            this.Controls.Add(this.Avance);
            this.Controls.Add(this.Proceso);
            this.Controls.Add(this.ProduccTerminada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button1;
        private TextBox ProduccTerminada;
        private TextBox Proceso;
        private TextBox Avance;
        private TextBox Proceso2;
        private TextBox Avance2;
        private TextBox concepto;
    }
}