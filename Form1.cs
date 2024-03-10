using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace ExamWinForms
{
    public partial class Form1 : Form
    {
        const string conString = @"Data Source=DESKTOP-U2DHO8A\MYSERVER;Initial Catalog=exam_winForms;Integrated Security=True;";

        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;

        public Form1()
        {
            InitializeComponent();

            table = new DataTable();
            productView.AllowUserToResizeColumns = false;
            productView.AllowUserToResizeRows = false;

            initData();

            productView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productView.SelectionChanged += ProductView_SelectionChanged;

        }

        private void ProductView_SelectionChanged(object? sender, EventArgs e)
        {
            var row = productView.SelectedRows;
            if (row.Count == 1)
            {
                txtID.Text = row[0].Cells["ID"].Value.ToString();
                txtName.Text = row[0].Cells["Product"].Value.ToString();
                txtCount.Text = row[0].Cells["Count"].Value.ToString();
                txtPrice.Text = row[0].Cells["Price"].Value.ToString();
            }
        }

        private void initData()
        {
            table.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM product", con);
            adapter.Fill(table);
            productView.DataSource = table;
            productView.Columns[0].Name = "ID";
            productView.Columns[1].Name = "Product";
            productView.Columns[2].Name = "Count";
            productView.Columns[3].Name = "Price";


            productView.Columns[0].HeaderText = "ID";
            productView.Columns[1].HeaderText = "Product name";
            productView.Columns[2].HeaderText = "Count";
            productView.Columns[3].HeaderText = "Price";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand($"INSERT INTO product VALUES({Convert.ToInt32(txtID.Text)}," +
                $"'{txtName.Text}'," +
                $"{Convert.ToInt32(txtCount.Text)}," +
                $"{Convert.ToInt32(txtPrice.Text)})", con);
            cmd.ExecuteNonQuery();
            con.Close();

            initData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rows = productView.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = row.Cells["ID"].Value.ToString();
                con.Open();
                cmd = new SqlCommand($"DELETE FROM product WHERE id = {Convert.ToInt32(id)}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                initData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = productView.SelectedRows[0].Cells["ID"].Value.ToString();
            con.Open();
            cmd = new SqlCommand($"UPDATE product SET " +
                $"product_name = '{txtName.Text.ToString()}', " +
                $"count = '{Convert.ToInt32(txtCount.Text)}', " +
                $"price = {Convert.ToInt32(txtPrice.Text)} " +
                $"WHERE id = {Convert.ToInt32(id)}", con);

            cmd.ExecuteNonQuery();
            con.Close();
            initData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = productView.DataSource;
            bs.Filter = productView.Columns[1].Name + " like '%" + txtSearch.Text + "%'";
            productView.DataSource = bs;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            bs.Filter = "product_name" + " like '%" + txtSearch.Text + "%'";
            productView.DataSource = bs;
        }
    }
}