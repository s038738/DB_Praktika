
namespace db_praktika
{
    partial class InfoEkskursijaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelVardas = new System.Windows.Forms.Label();
            this.labelPavarde = new System.Windows.Forms.Label();
            this.labelKalbos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSalis = new System.Windows.Forms.Label();
            this.labelMiestas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informacija apie gidą:";
            // 
            // labelVardas
            // 
            this.labelVardas.AutoSize = true;
            this.labelVardas.Location = new System.Drawing.Point(168, 63);
            this.labelVardas.Name = "labelVardas";
            this.labelVardas.Size = new System.Drawing.Size(51, 13);
            this.labelVardas.TabIndex = 6;
            this.labelVardas.Text = "VARDAS";
            // 
            // labelPavarde
            // 
            this.labelPavarde.AutoSize = true;
            this.labelPavarde.Location = new System.Drawing.Point(168, 86);
            this.labelPavarde.Name = "labelPavarde";
            this.labelPavarde.Size = new System.Drawing.Size(58, 13);
            this.labelPavarde.TabIndex = 7;
            this.labelPavarde.Text = "PAVARDE";
            this.labelPavarde.Click += new System.EventHandler(this.labelPavarde_Click);
            // 
            // labelKalbos
            // 
            this.labelKalbos.AutoSize = true;
            this.labelKalbos.Location = new System.Drawing.Point(168, 108);
            this.labelKalbos.Name = "labelKalbos";
            this.labelKalbos.Size = new System.Drawing.Size(76, 13);
            this.labelKalbos.TabIndex = 8;
            this.labelKalbos.Text = "gidas nebilys :)";
            this.labelKalbos.Click += new System.EventHandler(this.labelKalbos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Paslaugos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ekskursija:";
            // 
            // labelSalis
            // 
            this.labelSalis.AutoSize = true;
            this.labelSalis.Location = new System.Drawing.Point(24, 63);
            this.labelSalis.Name = "labelSalis";
            this.labelSalis.Size = new System.Drawing.Size(37, 13);
            this.labelSalis.TabIndex = 12;
            this.labelSalis.Text = "SALIS";
            // 
            // labelMiestas
            // 
            this.labelMiestas.AutoSize = true;
            this.labelMiestas.Location = new System.Drawing.Point(24, 86);
            this.labelMiestas.Name = "labelMiestas";
            this.labelMiestas.Size = new System.Drawing.Size(54, 13);
            this.labelMiestas.TabIndex = 13;
            this.labelMiestas.Text = "MIESTAS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 63);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Aprašymas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "KAINA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "KAINA GALUTINE";
            // 
            // InfoEkskursijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMiestas);
            this.Controls.Add(this.labelSalis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKalbos);
            this.Controls.Add(this.labelPavarde);
            this.Controls.Add(this.labelVardas);
            this.Controls.Add(this.label1);
            this.Name = "InfoEkskursijaForm";
            this.Text = "InfoEkskursijaForm";
            this.Load += new System.EventHandler(this.InfoEkskursijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelVardas;
        public System.Windows.Forms.Label labelPavarde;
        public System.Windows.Forms.Label labelKalbos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelSalis;
        public System.Windows.Forms.Label labelMiestas;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label6;
    }
}