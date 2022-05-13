
namespace db_praktika
{
    partial class GidasMainForm
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
            this.ekskursijos_dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonNewPaslauga = new System.Windows.Forms.Button();
            this.buttonNewEkskursija = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ekskursijos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "gido form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ekskursijos_dataGridView
            // 
            this.ekskursijos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekskursijos_dataGridView.Location = new System.Drawing.Point(12, 39);
            this.ekskursijos_dataGridView.Name = "ekskursijos_dataGridView";
            this.ekskursijos_dataGridView.Size = new System.Drawing.Size(783, 399);
            this.ekskursijos_dataGridView.TabIndex = 2;
            this.ekskursijos_dataGridView.DoubleClick += new System.EventHandler(this.ekskursijos_dataGridView_DoubleClick);
            // 
            // buttonNewPaslauga
            // 
            this.buttonNewPaslauga.Location = new System.Drawing.Point(801, 39);
            this.buttonNewPaslauga.Name = "buttonNewPaslauga";
            this.buttonNewPaslauga.Size = new System.Drawing.Size(138, 23);
            this.buttonNewPaslauga.TabIndex = 3;
            this.buttonNewPaslauga.Text = "Sukurti paslaugą";
            this.buttonNewPaslauga.UseVisualStyleBackColor = true;
            this.buttonNewPaslauga.Click += new System.EventHandler(this.buttonNewPaslauga_Click);
            // 
            // buttonNewEkskursija
            // 
            this.buttonNewEkskursija.Location = new System.Drawing.Point(801, 68);
            this.buttonNewEkskursija.Name = "buttonNewEkskursija";
            this.buttonNewEkskursija.Size = new System.Drawing.Size(138, 23);
            this.buttonNewEkskursija.TabIndex = 4;
            this.buttonNewEkskursija.Text = "Sukurti ekskursiją";
            this.buttonNewEkskursija.UseVisualStyleBackColor = true;
            this.buttonNewEkskursija.Click += new System.EventHandler(this.buttonNewEkskursija_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekskursija + bokštas ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ekskursija + paslaugos ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(801, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Koreguoti savo info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GidasMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNewEkskursija);
            this.Controls.Add(this.buttonNewPaslauga);
            this.Controls.Add(this.ekskursijos_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "GidasMainForm";
            this.Text = "GidasMainForm";
            this.Load += new System.EventHandler(this.GidasMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekskursijos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ekskursijos_dataGridView;
        private System.Windows.Forms.Button buttonNewPaslauga;
        private System.Windows.Forms.Button buttonNewEkskursija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}