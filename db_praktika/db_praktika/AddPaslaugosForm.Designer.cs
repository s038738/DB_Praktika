
namespace db_praktika
{
    partial class AddPaslaugosForm
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
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            this.textBoxKiekis = new System.Windows.Forms.TextBox();
            this.textBoxKaina = new System.Windows.Forms.TextBox();
            this.textBoxTrukme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Location = new System.Drawing.Point(121, 44);
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(100, 20);
            this.textBoxPavadinimas.TabIndex = 0;
            // 
            // textBoxKiekis
            // 
            this.textBoxKiekis.Location = new System.Drawing.Point(121, 131);
            this.textBoxKiekis.Name = "textBoxKiekis";
            this.textBoxKiekis.Size = new System.Drawing.Size(100, 20);
            this.textBoxKiekis.TabIndex = 1;
            // 
            // textBoxKaina
            // 
            this.textBoxKaina.Location = new System.Drawing.Point(121, 87);
            this.textBoxKaina.Name = "textBoxKaina";
            this.textBoxKaina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKaina.TabIndex = 2;
            // 
            // textBoxTrukme
            // 
            this.textBoxTrukme.Location = new System.Drawing.Point(121, 176);
            this.textBoxTrukme.Name = "textBoxTrukme";
            this.textBoxTrukme.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrukme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pavadinimas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiekis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trukmė valandomis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pridėti paslaugą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPaslaugosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTrukme);
            this.Controls.Add(this.textBoxKaina);
            this.Controls.Add(this.textBoxKiekis);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Name = "AddPaslaugosForm";
            this.Text = "AddPaslaugosForm";
            this.Load += new System.EventHandler(this.AddPaslaugosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPavadinimas;
        private System.Windows.Forms.TextBox textBoxKiekis;
        private System.Windows.Forms.TextBox textBoxKaina;
        private System.Windows.Forms.TextBox textBoxTrukme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}