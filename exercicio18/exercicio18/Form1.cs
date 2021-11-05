using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class tp_no
        {
            public string nome, idade, genero;
            public tp_no prox;
        }
        void Insere(ref tp_no t, string n, string i, string g)
        {
            tp_no no = new tp_no();
            no.nome = n;
            no.idade = i;
            no.genero = g;
            if (t != null)
                no.prox = t;
            t = no;
        }

        tp_no lista = null;
        tp_no atual = null;
        tp_no anterior = null;

        private void B_Inclui_Click(object sender, EventArgs e)
        {
            // Pega os dados da IU e joga pra memória (lista)
            Insere(ref lista, TB_Nome.Text, TB_Idade.Text, CB_Genero.Text);

            TB_Nome.Text = "";
            TB_Idade.Text = "";
            CB_Genero.Text = "";
            TB_Nome.Focus();
        }

        private void B_Exibe_Click(object sender, EventArgs e)
        {
            LB_Registros.Items.Clear();
            tp_no aux = lista;
            while (aux != null)
            {
                LB_Registros.Items.Add("Nome: " + aux.nome);
                LB_Registros.Items.Add("Idade: " + aux.idade);
                LB_Registros.Items.Add("Genero: " + aux.genero);

                aux = aux.prox;
            }
        }
        void procura(tp_no l, string procurado, ref tp_no atu, ref tp_no ant)
        {
            ant = null;
            atu = l;
            while (atu != null && procurado.ToUpper() != atu.nome.ToUpper())
            {
                ant = atu;
                atu = atu.prox;
            }
        }
        private void B_Procurar_A_Click(object sender, EventArgs e)
        {
            procura(lista, TB_Procurado_A.Text, ref atual, ref anterior);
            if (atual != null)  // encontrou (pega da memória e joga pra IU)
            {
                TB_Nome_A.Text = atual.nome;
                TB_IDADE_A.Text = atual.idade;
                CB_GENERO_A.Text = atual.genero;
                // continua com a idade e o genero
            }
            else  // não encontrou
                MessageBox.Show("Não encontrado !");
        }

        private void B_Altera_Click(object sender, EventArgs e)
        {
            // pega da IU e joga pra memória
            atual.nome = TB_Nome_A.Text;
            atual.idade = TB_IDADE_A.Text;
            atual.genero = CB_GENERO_A.Text;
            TB_Procurado_A.Focus();
            TB_Procurado_A.Text = "";
            TB_Nome_A.Text = "";
            TB_IDADE_A.Text = "";
            CB_GENERO_A.Text = "";
            // continua com a idade e o genero
        }

        private void B_Procurar_E_Click(object sender, EventArgs e)
        {
            procura(lista, TB_Procurado_E.Text, ref atual, ref anterior);
            if (atual != null)  // encontrou (pega da memória e joga pra IU)
            {
                TB_NOME_B.Text = atual.nome;
                TB_IDADE_B.Text = atual.idade;
                CB_GENERO_B.Text = atual.genero;
                // continua com a idade e o genero
            }
            else  // não encontrou
                MessageBox.Show("Não encontrado !");
        }

        private void B_Exclui_Click(object sender, EventArgs e)
        {
            if (atual == lista)  // É o 1o elemento
            {
                lista = atual.prox;
                atual.prox = null;
            }
            else if (atual.prox == null)   // É o último elemento
            {
                anterior.prox = null;
            }
            else
            {
                anterior.prox = atual.prox;
                atual.prox = null;
            }
            TB_Procurado_E.Text = "";
            TB_NOME_B.Text = "";
            TB_IDADE_B.Text = "";
            CB_GENERO_B.Text = "";
            TB_Procurado_E.Focus();
        }
    }
}

