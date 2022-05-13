
namespace db_praktika
{
    partial class MainForm
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
            this.ekskursijos_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ekskursijos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ekskursijos_dataGridView
            // 
            this.ekskursijos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekskursijos_dataGridView.Location = new System.Drawing.Point(12, 39);
            this.ekskursijos_dataGridView.Name = "ekskursijos_dataGridView";
            this.ekskursijos_dataGridView.Size = new System.Drawing.Size(922, 399);
            this.ekskursijos_dataGridView.TabIndex = 1;
            this.ekskursijos_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ekskursijos_dataGridView_CellContentClick);
            this.ekskursijos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ekskursijos_dataGridView_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.ekskursijos_dataGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekskursijos_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ekskursijos_dataGridView;
    }
}

