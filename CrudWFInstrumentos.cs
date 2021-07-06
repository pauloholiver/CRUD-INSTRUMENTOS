using CrudInstrumentos.Entities;
using CrudInstrumentos.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CrudInstrumentos
{
    public partial class CrudWFInstrumentos : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public CrudWFInstrumentos()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtInstrumentos.DataSource = db.Instrumentos.ToList();

        }

        private void btnCadastrar(object sender, EventArgs e)
        {
            try
            {
                var instrumento = new Instrumento
                {
                    Descricao = txtDesc.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    Imagem = txtUrl.Text
                };
                db.Instrumentos.Add(instrumento);
                db.SaveChanges();
                dtInstrumentos.DataSource = db.Instrumentos.ToList();
                MessageBox.Show("Instrumento cadastrado com sucesso.");
            }
            catch
            {
                MessageBox.Show("Falha ao cadastrar novo instrumento.");
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var instrumento = db.Instrumentos.Find(int.Parse(txtCod.Text));
            try
            {
                instrumento.Descricao = txtDesc.Text;
                instrumento.Preco = decimal.Parse(txtPreco.Text);
                instrumento.Imagem = txtUrl.Text;
                db.SaveChanges();
                MessageBox.Show($"Instrumento - {instrumento.Id}: Atualizado");
                dtInstrumentos.DataSource = db.Instrumentos.ToList();
            }
            catch
            {
                MessageBox.Show($"Falha ao atualizar");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
                var id = txtCod.Text;
                var instrumento = db.Instrumentos.Find(int.Parse(id));
            try 
            {
                var result = MessageBox.Show("Quer realmente excluir este instrumento?", "Excluir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Instrumentos.Remove(instrumento);
                    db.SaveChanges();
                    dtInstrumentos.DataSource = db.Instrumentos.ToList();
                    MessageBox.Show($"Instrumento {instrumento.Id} - {instrumento.Descricao} deletado");
                }
            }
            catch
            {
                MessageBox.Show($"Falha ao deletar {instrumento.Id} - {instrumento.Descricao}");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         //   var id = txtCod.Text;
         //   var instrumento = db.Instrumentos.Find(int.Parse(id));
         //   dtInstrumentos.DataSource = db.Instrumentos.ToList().Where(con);
        }

        private void dtInstrumentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dtInstrumentos.Rows[e.RowIndex].Cells[0].Value;
            var instrumento = db.Instrumentos.Find(id);
            txtCod.Text = instrumento.Id.ToString();
            txtDesc.Text = instrumento.Descricao;
            txtPreco.Text = instrumento.Preco.ToString();
            txtUrl.Text = instrumento.Imagem;
            this.btnAlterar.Enabled = true;
            this.btnDeletar.Enabled = true;
        }
    }
}
