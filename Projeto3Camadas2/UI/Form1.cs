using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas2.CODE.BLL;
using Projeto3Camadas2.CODE.DTO;



namespace Projeto3Camadas2
{
    public partial class Form1 : Form
    {


        PacotesBLL pacbll = new PacotesBLL();
        PacotesDTO pacdto = new PacotesDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacdto.Preco = txtPreço.Text;
            pacdto.Desc = txtDescrição.Text;
            pacdto.Nome = txtNome.Text;

            pacbll.Inserir(pacdto);

            MessageBox.Show("Cadastrado com Sucesso");

            txtID.Clear();
            txtPreço.Clear();
            txtNome.Clear();
            txtDescrição.Clear();

            dgvLista.DataSource = pacbll.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = pacbll.Listar();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPreço.Text = dgvLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescrição.Text = dgvLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNome.Text = dgvLista.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pacdto.Id = int.Parse(txtID.Text);
            pacdto.Desc = txtDescrição.Text;
            pacdto.Preco = txtPreço.Text;
            pacdto.Nome = txtNome.Text;

            pacbll.Editar(pacdto);

            MessageBox.Show("Atualizado com Sucesso");
            dgvLista.DataSource = pacbll.Listar();

            txtID.Clear();
            txtNome.Clear();
            txtPreço.Clear();
            txtDescrição.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pacdto.Id = int.Parse(txtID.Text);

            pacbll.Excluir(pacdto);

            MessageBox.Show("Excluído com sucesso");
            dgvLista.DataSource = pacbll.Listar();

            txtID.Clear();
            txtNome.Clear();
            txtPreço.Clear();
            txtDescrição.Clear();
        }
    }
}
