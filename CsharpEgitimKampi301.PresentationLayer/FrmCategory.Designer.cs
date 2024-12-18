namespace CsharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdaktif = new System.Windows.Forms.RadioButton();
            this.rdpasif = new System.Windows.Forms.RadioButton();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnidgetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategory Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 32);
            this.txtId.TabIndex = 1;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.Blue;
            this.btnlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlist.Location = new System.Drawing.Point(76, 232);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(216, 54);
            this.btnlist.TabIndex = 2;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 562);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(172, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(207, 32);
            this.txtname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategory Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategory Durum:";
            // 
            // rdaktif
            // 
            this.rdaktif.AutoSize = true;
            this.rdaktif.Location = new System.Drawing.Point(172, 136);
            this.rdaktif.Name = "rdaktif";
            this.rdaktif.Size = new System.Drawing.Size(74, 28);
            this.rdaktif.TabIndex = 7;
            this.rdaktif.TabStop = true;
            this.rdaktif.Text = "Aktif";
            this.rdaktif.UseVisualStyleBackColor = true;
            // 
            // rdpasif
            // 
            this.rdpasif.AutoSize = true;
            this.rdpasif.Location = new System.Drawing.Point(274, 136);
            this.rdpasif.Name = "rdpasif";
            this.rdpasif.Size = new System.Drawing.Size(73, 28);
            this.rdpasif.TabIndex = 8;
            this.rdpasif.TabStop = true;
            this.rdpasif.Text = "Pasif";
            this.rdpasif.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Blue;
            this.btnekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnekle.Location = new System.Drawing.Point(76, 301);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(216, 54);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Blue;
            this.btnsil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsil.Location = new System.Drawing.Point(76, 374);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(216, 54);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Blue;
            this.btnguncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguncelle.Location = new System.Drawing.Point(76, 445);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(216, 54);
            this.btnguncelle.TabIndex = 11;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnidgetir
            // 
            this.btnidgetir.BackColor = System.Drawing.Color.Blue;
            this.btnidgetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnidgetir.Location = new System.Drawing.Point(76, 518);
            this.btnidgetir.Name = "btnidgetir";
            this.btnidgetir.Size = new System.Drawing.Size(216, 54);
            this.btnidgetir.TabIndex = 12;
            this.btnidgetir.Text = "Id ye Göre Getir";
            this.btnidgetir.UseVisualStyleBackColor = false;
            this.btnidgetir.Click += new System.EventHandler(this.btnidgetir_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 586);
            this.Controls.Add(this.btnidgetir);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.rdpasif);
            this.Controls.Add(this.rdaktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategory Paneli ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdaktif;
        private System.Windows.Forms.RadioButton rdpasif;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnidgetir;
    }
}

