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

namespace CrudInstrumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PAULINHO;Initial Catalog=ApiInstrumentos;User ID=sa;Password=phflo0905");

        private void btnCadastrar(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Instrumento_Insert '" + txtDesc.Text + "','" + decimal.Parse(txtPreco.Text) + "','" + txtUrl.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserido novo instrumento com sucesso");
            CarregaInstrumentos();
        }

        void CarregaInstrumentos()
        {
            SqlCommand com = new SqlCommand("exec dbo.Instrumento_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable instrumentos = new DataTable();
            da.Fill(instrumentos);
            dtInstrumentos.DataSource = instrumentos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaInstrumentos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Instrumento_Update '" + txtDesc.Text + "','" + decimal.Parse(txtPreco.Text) + "','" + txtUrl.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Instrumento alterado com sucesso");
            CarregaInstrumentos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer realmente excluir este instrumento?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.Instrumento_Delete '" + int.Parse(txtCod.Text) + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Instrumento excluído com sucesso");
                CarregaInstrumentos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                SqlCommand com = new SqlCommand("exec dbo.Instrumento_Search'" + int.Parse(txtCod.Text) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable instrumentos = new DataTable();
                da.Fill(instrumentos);
                dtInstrumentos.DataSource = instrumentos;
            }
            else
                CarregaInstrumentos();
        }

        private void dtInstrumentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                txtCod.Text = this.dtInstrumentos.CurrentRow.Cells[0].Value.ToString();
                txtDesc.Text = this.dtInstrumentos.CurrentRow.Cells[1].Value.ToString();
                txtPreco.Text = this.dtInstrumentos.CurrentRow.Cells[2].Value.ToString();
                txtUrl.Text = this.dtInstrumentos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
