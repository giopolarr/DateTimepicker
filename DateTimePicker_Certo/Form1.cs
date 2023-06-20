using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_Certo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_obterData_Click(object sender, EventArgs e) // cassiane
        {
            //para buscar a data que esta no datapicker
            tb_data.Text = dtp_data.Text;
            tb_dia.Text = dtp_data.Value.Day.ToString();//retorna um inteiro
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e) // giovanna
        {
            int d, m, a; // facilitar
            d = Int32.Parse(tb_dia.Text); //int parse funciona como uma conversão de string para int
            m = Int32.Parse(tb_mes.Text);
            a = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(a, m, d); //inicializa uma nova estância de estrutura para o ano, mês e dia especificado, resetando os comandos acima.

            dtp_data.Value = dt; // Value define o valor de data/hora atribuido.
        }

        private void dtp_data_ValueChanged(object sender, EventArgs e)// cassiane
        {
            this.dtp_data.MinDate = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e) // giovanna
        {
            dtp_data.Value = DateTime.Today; // Value define o valor de data/hora atribuido. = a data atual dde hoje
        }

        private void tb_dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
