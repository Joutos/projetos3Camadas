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

namespace Projeto3Camadas2.UI
{
    public partial class FormLogin : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO logindto = new LoginDTO();


        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logindto.Email = txtEmail.Text;
            logindto.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(logindto) == true)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique Email e senha");
            }


        }
    }
}
