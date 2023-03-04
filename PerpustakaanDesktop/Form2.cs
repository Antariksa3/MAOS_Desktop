using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PerpustakaanDesktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANTARIKSA\SQLEXPRESS;Initial Catalog=Antariksa;Integrated Security=True");
        SqlCommand cmd;
        int isdipinjam = 0;
        int isdikembalikan = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ingin menutup aplikasi ini ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            picbuku.Visible = false;
            picbuku2.Visible = false;
            picbuku3.Visible = false;
            
            if (cmbbuku.Text == "Belajar Coding")
            {

                picbuku.Visible = true;
            }
            else if (cmbbuku.Text == "Saya Bisa Coding")
            {

                picbuku2.Visible = true;
            }
            else if (cmbbuku.Text == "How To Code")
            {

                picbuku3.Visible = true;
            }
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [table_peminjam] (id,nama,nohp,alamat,namabuku,meminjam,mengembalikan,tanggal) values ('" + txtid.Text + "','" + txtnama.Text + "','" + txtno.Text + "','" + txtalamat.Text + "', '" + cmbbuku.Text + "','" + isdipinjam + "', '" + isdikembalikan + "','" + monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy") + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil Disimpan");
            txtid.Text = "";
            txtalamat.Text = "";
            txtnama.Text = "";
            txtno.Text = "";
            picbuku.Visible = false;
            picbuku2.Visible = false;
            picbuku3.Visible = false;
            cmbbuku.Text = "";
            radiokembali.Checked = false;
            radiopinjam.Checked = false;
        }

        private void radiopinjam_CheckedChanged(object sender, EventArgs e)
        {
            isdipinjam = 1;
            isdikembalikan = 0;
        }

        private void radiokembali_CheckedChanged(object sender, EventArgs e)
        {
            isdikembalikan = 1;
            isdipinjam = 0;
        }

        public void displayDataPeminjam()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [table_peminjam]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            displayDataPeminjam();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtalamat.Text = "";
            txtnama.Text = "";
            txtno.Text = "";
            picbuku.Visible = false;
            picbuku2.Visible = false;
            picbuku3.Visible = false;
            cmbbuku.Text = "";
            radiokembali.Checked = false;
            radiopinjam.Checked = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [table_peminjam] set id = '" + txtid.Text + "', nama = '" + txtnama.Text + "' , nohp = '" + txtno.Text + "' , alamat = '" + txtalamat.Text + "' , namabuku = '" + cmbbuku.Text + "' , meminjam = '" + isdipinjam + "', mengembalikan = '" + isdikembalikan + "' , tanggal = '" + monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy") + "' where id = '" + txtid.Text + "' ";
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Data berhasil diedit");
            txtid.Text = "";
            txtalamat.Text = "";
            txtnama.Text = "";
            txtno.Text = "";
            picbuku.Visible = false;
            picbuku2.Visible = false;
            picbuku3.Visible = false;
            cmbbuku.Text = "";
            radiokembali.Checked = false;
            radiopinjam.Checked = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah kamu yakin ingin menghapus data?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [table_peminjam] where id = '" + int.Parse(txtid.Text) + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                txtid.Clear();
                displayDataPeminjam();
                MessageBox.Show("Data berhasil dihapus");
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Peminjam Buku Perpustakaan";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dddd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Antariksa Kusuma Harmawan";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width =
                dataGridView1.Width
                - dataGridView1.Columns[0].Width
                - dataGridView1.Columns[1].Width - 92;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [table_peminjam] where id = '" + int.Parse(txtsearch.Text) + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnbarcode_Click(object sender, EventArgs e)
        {
            picbarcode.Visible = true;
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picbarcode.Image = brCode.Draw(cmbbuku.Text, 40);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
