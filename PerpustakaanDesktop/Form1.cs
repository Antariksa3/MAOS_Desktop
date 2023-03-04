using System.Data;
using System.Data.SqlClient;

namespace PerpustakaanDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANTARIKSA\SQLEXPRESS;Initial Catalog=Antariksa;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ingin menutup aplikasi ini ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            String username, password;

            username = txtemail.Text;
            password = txtpass.Text;

            try
            {

                String querry = "SELECT * FROM Login WHERE username = '" + txtemail.Text + "' AND password = '" + txtpass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtemail.Text;
                    password = txtpass.Text;
    
                    //
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Clear();
                    txtpass.Clear();

                    //
                    txtemail.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
