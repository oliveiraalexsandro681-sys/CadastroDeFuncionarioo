using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionarioCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string nome = Nome.Text;
            string cpf = CPF.Text;
            int idade = Convert.ToInt16(Idade.Text);
            string vaga = Res.Text;
            if (idade >=18)
            {
                MessageBox.Show($" Funcionario {nome} do CPF {cpf} foi cadastrado na vaga : {vaga}");
            }
            else
            {
                MessageBox.Show($" Funcionario {nome} do CPF {cpf} é menor de idade para vaga : {vaga}");
            }


        }
    }
}
