using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class tp_no
        {
            public int valor;
            public tp_no prox;
        }

        void Insere(ref tp_no t, int valor)
        {
            tp_no no = new tp_no();
            no.valor = valor;
            if (t != null)
                no.prox = t;
            t = no;
        }
        tp_no Remove(ref tp_no t)
        {
            tp_no no = null;
            if (t != null)
            {
                no = t;
                t = t.prox;
                no.prox = null;
            }
            return no;
        }

        tp_no topo = null;

        private void b_insere_Click(object sender, EventArgs e)
        {
            Insere(ref topo, Convert.ToInt32(tb_numero.Text));
            tb_numero.Clear();
            tb_numero.Focus();
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            tp_no removido = Remove(ref topo);
            if (removido != null)
                lb_saida.Items.Add(removido.valor);
            else MessageBox.Show("Lista esta vazia!");
        }

        private void tb_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
