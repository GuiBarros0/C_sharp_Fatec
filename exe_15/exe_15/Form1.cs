using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 5;
        class LLS_Fila
        {
            public int inicio = 0;
            public int fim = 0;
            public int[] vetor = new int[MAX];
        }
        bool EstaVazia(LLS_Fila f)
        {
            if (f.inicio == f.fim)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Fila f)
        {
            if (f.fim == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Fila f, int valor)
        {
            f.vetor[f.fim] = valor;
            f.fim = f.fim + 1;
        }
        int Remove(LLS_Fila f)
        {
            int valor = f.vetor[f.inicio];
            f.inicio = f.inicio + 1;
            return valor;
        }

        LLS_Fila fila = new LLS_Fila();

        private void b_adiciona_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tb_num_aviao.Text);
            if (! EstaCheia(fila))
                Insere(fila, n);
            else
                MessageBox.Show("Fila Cheia!");
            tb_num_aviao.Clear(); 
            tb_num_aviao.Focus();
        }
        int qnt_valor_fila(LLS_Fila f)
        {
            return (f.fim - f.inicio);
        }
        private void b_quantidade_Click(object sender, EventArgs e)
        {
            int qtd = qnt_valor_fila(fila);
            tb_num_quantidade.Text = Convert.ToString(qtd);
        }

        private void b_decolagem_Click(object sender, EventArgs e)
        {
            if (! EstaVazia(fila))
            {
                int n = Remove(fila);
                tb_num_autoriza.Text = Convert.ToString(n);
            }
            else MessageBox.Show("Fila vazia!");
               
        }
        int primeiro_fila (LLS_Fila f)
        {
            return (f.vetor[f.inicio]);
        }
        private void b_primeiro_Click(object sender, EventArgs e)
        {
            tb_num_primeiro.Text = Convert.ToString(primeiro_fila(fila));
        }

        private void b_aviao_fila_Click(object sender, EventArgs e)
        {
            int i;
            lb_resultados.Items.Clear();
            for (i = fila.inicio; i <= fila.fim - 1; i++)
            {
                lb_resultados.Items.Add(fila.vetor[i]);
            }
        }
    }
}
