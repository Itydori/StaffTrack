namespace Personal_takip_1
{
    partial class frmPersoneleGorePrimler
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPersonelID = new TextBox();
            txtPersonelAdSoyad = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(865, 343);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 1;
            label1.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(111, 16);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(89, 26);
            txtPersonelID.TabIndex = 2;
            // 
            // txtPersonelAdSoyad
            // 
            txtPersonelAdSoyad.Location = new Point(361, 16);
            txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            txtPersonelAdSoyad.Size = new Size(236, 26);
            txtPersonelAdSoyad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 19);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 3;
            label2.Text = "Personel Ad Soyad:";
            // 
            // frmPersoneleGorePrimler
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 407);
            Controls.Add(txtPersonelAdSoyad);
            Controls.Add(label2);
            Controls.Add(txtPersonelID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmPersoneleGorePrimler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personele Göre Primler";
            Load += frmPersoneleGorePrimler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public TextBox txtPersonelID;
        public TextBox txtPersonelAdSoyad;
        public DataGridView dataGridView1;
    }
}