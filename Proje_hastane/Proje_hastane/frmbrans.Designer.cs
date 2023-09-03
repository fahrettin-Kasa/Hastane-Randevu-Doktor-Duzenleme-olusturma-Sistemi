namespace Proje_hastane
{
    partial class frmbrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbrans));
            this.brnguncelle = new System.Windows.Forms.Button();
            this.brnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // brnguncelle
            // 
            this.brnguncelle.BackColor = System.Drawing.Color.Green;
            this.brnguncelle.Location = new System.Drawing.Point(117, 182);
            this.brnguncelle.Name = "brnguncelle";
            this.brnguncelle.Size = new System.Drawing.Size(160, 41);
            this.brnguncelle.TabIndex = 27;
            this.brnguncelle.Text = "Güncelle";
            this.brnguncelle.UseVisualStyleBackColor = false;
            this.brnguncelle.Click += new System.EventHandler(this.brnguncelle_Click);
            // 
            // brnsil
            // 
            this.brnsil.BackColor = System.Drawing.Color.Red;
            this.brnsil.Location = new System.Drawing.Point(220, 135);
            this.brnsil.Name = "brnsil";
            this.brnsil.Size = new System.Drawing.Size(57, 41);
            this.brnsil.TabIndex = 26;
            this.brnsil.Text = "Sil";
            this.brnsil.UseVisualStyleBackColor = false;
            this.brnsil.Click += new System.EventHandler(this.brnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnekle.Location = new System.Drawing.Point(117, 135);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(60, 41);
            this.btnekle.TabIndex = 25;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 173);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbrans
            // 
            this.txtbrans.Location = new System.Drawing.Point(117, 87);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(160, 31);
            this.txtbrans.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Branş Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Branş İd:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 31);
            this.txtid.TabIndex = 15;
            // 
            // frmbrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(759, 267);
            this.Controls.Add(this.brnguncelle);
            this.Controls.Add(this.brnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmbrans";
            this.Text = "Brans Paneli";
            this.Load += new System.EventHandler(this.frmbrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnguncelle;
        private System.Windows.Forms.Button brnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
    }
}