namespace RehberProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxYeni = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.mtextTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxYeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 457);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 431);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBoxYeni
            // 
            this.groupBoxYeni.Controls.Add(this.btnGüncelle);
            this.groupBoxYeni.Controls.Add(this.btnSil);
            this.groupBoxYeni.Controls.Add(this.btnEkle);
            this.groupBoxYeni.Controls.Add(this.label5);
            this.groupBoxYeni.Controls.Add(this.textMAIL);
            this.groupBoxYeni.Controls.Add(this.label4);
            this.groupBoxYeni.Controls.Add(this.textSOYAD);
            this.groupBoxYeni.Controls.Add(this.label3);
            this.groupBoxYeni.Controls.Add(this.textAD);
            this.groupBoxYeni.Controls.Add(this.label2);
            this.groupBoxYeni.Controls.Add(this.textID);
            this.groupBoxYeni.Controls.Add(this.mtextTel);
            this.groupBoxYeni.Controls.Add(this.label1);
            this.groupBoxYeni.Location = new System.Drawing.Point(717, 23);
            this.groupBoxYeni.Name = "groupBoxYeni";
            this.groupBoxYeni.Size = new System.Drawing.Size(377, 457);
            this.groupBoxYeni.TabIndex = 1;
            this.groupBoxYeni.TabStop = false;
            this.groupBoxYeni.Text = "Yeni Kişi";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGüncelle.Location = new System.Drawing.Point(74, 393);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(247, 41);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSil.Location = new System.Drawing.Point(74, 346);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(247, 41);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEkle.Location = new System.Drawing.Point(74, 292);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(247, 41);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MAIL";
            // 
            // textMAIL
            // 
            this.textMAIL.BackColor = System.Drawing.Color.LemonChiffon;
            this.textMAIL.Location = new System.Drawing.Point(146, 249);
            this.textMAIL.Name = "textMAIL";
            this.textMAIL.Size = new System.Drawing.Size(158, 27);
            this.textMAIL.TabIndex = 4;
            this.textMAIL.Text = " @gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFON";
            // 
            // textSOYAD
            // 
            this.textSOYAD.BackColor = System.Drawing.Color.LemonChiffon;
            this.textSOYAD.Location = new System.Drawing.Point(146, 140);
            this.textSOYAD.Name = "textSOYAD";
            this.textSOYAD.Size = new System.Drawing.Size(158, 27);
            this.textSOYAD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD";
            // 
            // textAD
            // 
            this.textAD.BackColor = System.Drawing.Color.LemonChiffon;
            this.textAD.Location = new System.Drawing.Point(146, 87);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(158, 27);
            this.textAD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "AD";
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.LemonChiffon;
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(146, 36);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(158, 27);
            this.textID.TabIndex = 15;
            // 
            // mtextTel
            // 
            this.mtextTel.BackColor = System.Drawing.Color.LemonChiffon;
            this.mtextTel.Location = new System.Drawing.Point(146, 190);
            this.mtextTel.Mask = "(999) 000-0000";
            this.mtextTel.Name = "mtextTel";
            this.mtextTel.Size = new System.Drawing.Size(158, 27);
            this.mtextTel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1147, 519);
            this.Controls.Add(this.groupBoxYeni);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxYeni.ResumeLayout(false);
            this.groupBoxYeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxYeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.MaskedTextBox mtextTel;
    }
}

