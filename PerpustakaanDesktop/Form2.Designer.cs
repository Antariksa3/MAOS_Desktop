namespace PerpustakaanDesktop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnLogout = new System.Windows.Forms.Button();
            this.picexit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbuku = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picbuku = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiopinjam = new System.Windows.Forms.RadioButton();
            this.radiokembali = new System.Windows.Forms.RadioButton();
            this.btnbarcode = new System.Windows.Forms.Button();
            this.picbarcode = new System.Windows.Forms.PictureBox();
            this.btninput = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.picbuku2 = new System.Windows.Forms.PictureBox();
            this.picbuku3 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(814, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picexit
            // 
            this.picexit.BackColor = System.Drawing.Color.Transparent;
            this.picexit.Image = ((System.Drawing.Image)(resources.GetObject("picexit.Image")));
            this.picexit.Location = new System.Drawing.Point(938, 12);
            this.picexit.Name = "picexit";
            this.picexit.Size = new System.Drawing.Size(50, 50);
            this.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexit.TabIndex = 2;
            this.picexit.TabStop = false;
            this.picexit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Peminjam";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(82, 116);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(300, 33);
            this.txtid.TabIndex = 4;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Peminjam";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnama.Location = new System.Drawing.Point(82, 179);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(300, 33);
            this.txtnama.TabIndex = 4;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "No HandPhone";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtno.Location = new System.Drawing.Point(82, 248);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(300, 33);
            this.txtno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtalamat.Location = new System.Drawing.Point(82, 318);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(300, 95);
            this.txtalamat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(404, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Buku";
            // 
            // cmbbuku
            // 
            this.cmbbuku.FormattingEnabled = true;
            this.cmbbuku.Items.AddRange(new object[] {
            "Belajar Coding",
            "Saya Bisa Coding",
            "How To Code"});
            this.cmbbuku.Location = new System.Drawing.Point(404, 116);
            this.cmbbuku.Name = "cmbbuku";
            this.cmbbuku.Size = new System.Drawing.Size(250, 28);
            this.cmbbuku.TabIndex = 5;
            this.cmbbuku.SelectedIndexChanged += new System.EventHandler(this.cmbbuku_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(404, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Buku";
            // 
            // picbuku
            // 
            this.picbuku.Image = ((System.Drawing.Image)(resources.GetObject("picbuku.Image")));
            this.picbuku.Location = new System.Drawing.Point(404, 179);
            this.picbuku.Name = "picbuku";
            this.picbuku.Size = new System.Drawing.Size(100, 100);
            this.picbuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbuku.TabIndex = 6;
            this.picbuku.TabStop = false;
            this.picbuku.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(508, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status";
            // 
            // radiopinjam
            // 
            this.radiopinjam.AutoSize = true;
            this.radiopinjam.BackColor = System.Drawing.Color.Transparent;
            this.radiopinjam.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiopinjam.ForeColor = System.Drawing.Color.White;
            this.radiopinjam.Location = new System.Drawing.Point(510, 179);
            this.radiopinjam.Name = "radiopinjam";
            this.radiopinjam.Size = new System.Drawing.Size(109, 27);
            this.radiopinjam.TabIndex = 7;
            this.radiopinjam.TabStop = true;
            this.radiopinjam.Text = "Meminjam";
            this.radiopinjam.UseVisualStyleBackColor = false;
            this.radiopinjam.CheckedChanged += new System.EventHandler(this.radiopinjam_CheckedChanged);
            // 
            // radiokembali
            // 
            this.radiokembali.AutoSize = true;
            this.radiokembali.BackColor = System.Drawing.Color.Transparent;
            this.radiokembali.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiokembali.ForeColor = System.Drawing.Color.White;
            this.radiokembali.Location = new System.Drawing.Point(510, 212);
            this.radiokembali.Name = "radiokembali";
            this.radiokembali.Size = new System.Drawing.Size(150, 27);
            this.radiokembali.TabIndex = 7;
            this.radiokembali.TabStop = true;
            this.radiokembali.Text = "Mengembalikan";
            this.radiokembali.UseVisualStyleBackColor = false;
            this.radiokembali.CheckedChanged += new System.EventHandler(this.radiokembali_CheckedChanged);
            // 
            // btnbarcode
            // 
            this.btnbarcode.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbarcode.Location = new System.Drawing.Point(404, 318);
            this.btnbarcode.Name = "btnbarcode";
            this.btnbarcode.Size = new System.Drawing.Size(94, 29);
            this.btnbarcode.TabIndex = 8;
            this.btnbarcode.Text = "Barcode";
            this.btnbarcode.UseVisualStyleBackColor = true;
            this.btnbarcode.Click += new System.EventHandler(this.btnbarcode_Click);
            // 
            // picbarcode
            // 
            this.picbarcode.BackColor = System.Drawing.Color.White;
            this.picbarcode.Location = new System.Drawing.Point(404, 353);
            this.picbarcode.Name = "picbarcode";
            this.picbarcode.Size = new System.Drawing.Size(256, 60);
            this.picbarcode.TabIndex = 9;
            this.picbarcode.TabStop = false;
            // 
            // btninput
            // 
            this.btninput.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninput.Location = new System.Drawing.Point(720, 317);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(94, 28);
            this.btninput.TabIndex = 8;
            this.btninput.Text = "Input";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(820, 317);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 28);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(720, 353);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 28);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnedit.Location = new System.Drawing.Point(820, 353);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(94, 28);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndisplay.Location = new System.Drawing.Point(720, 390);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(94, 28);
            this.btndisplay.TabIndex = 8;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprint.Location = new System.Drawing.Point(820, 390);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(94, 28);
            this.btnprint.TabIndex = 8;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(852, 129);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(710, 437);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(125, 27);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.Location = new System.Drawing.Point(840, 436);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 28);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // picbuku2
            // 
            this.picbuku2.Image = ((System.Drawing.Image)(resources.GetObject("picbuku2.Image")));
            this.picbuku2.Location = new System.Drawing.Point(404, 179);
            this.picbuku2.Name = "picbuku2";
            this.picbuku2.Size = new System.Drawing.Size(100, 100);
            this.picbuku2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbuku2.TabIndex = 12;
            this.picbuku2.TabStop = false;
            this.picbuku2.Visible = false;
            // 
            // picbuku3
            // 
            this.picbuku3.Image = ((System.Drawing.Image)(resources.GetObject("picbuku3.Image")));
            this.picbuku3.Location = new System.Drawing.Point(404, 179);
            this.picbuku3.Name = "picbuku3";
            this.picbuku3.Size = new System.Drawing.Size(100, 100);
            this.picbuku3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbuku3.TabIndex = 13;
            this.picbuku3.TabStop = false;
            this.picbuku3.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(666, 98);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.picbuku3);
            this.Controls.Add(this.picbuku2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picbarcode);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.btnbarcode);
            this.Controls.Add(this.radiokembali);
            this.Controls.Add(this.radiopinjam);
            this.Controls.Add(this.picbuku);
            this.Controls.Add(this.cmbbuku);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picexit);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuku3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private PictureBox picexit;
        private Label label1;
        private TextBox txtid;
        private Label label2;
        private TextBox txtnama;
        private Label label3;
        private TextBox txtno;
        private Label label4;
        private TextBox txtalamat;
        private Label label5;
        private ComboBox cmbbuku;
        private Label label6;
        private PictureBox picbuku;
        private Label label7;
        private RadioButton radiopinjam;
        private RadioButton radiokembali;
        private Button btnbarcode;
        private PictureBox picbarcode;
        private Button btninput;
        private Button btnclear;
        private Button btndelete;
        private Button btnedit;
        private Button btndisplay;
        private Button btnprint;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private Button btnsearch;
        private PictureBox picbuku2;
        private PictureBox picbuku3;
        private MonthCalendar monthCalendar1;
    }
}