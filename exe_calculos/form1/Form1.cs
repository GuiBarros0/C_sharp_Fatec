using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_1_Click(object sender, EventArgs e)
        {
            int Base = Convert.ToInt32(TB_1.Text);
            int Exp = Convert.ToInt32(TB_2.Text);
            int ResultPot = ExibePot(Base, Exp);
            LB.Items.Add(ResultPot);
        }

        int ExibePot(int Base, int Exp)
        {
            if (Exp == 0) return 1;
            return ExibePot(Base, Exp - 1) * Base;
        }
        int i = 0;
        private void BT_Cubos_Click(object sender, EventArgs e)
        {
            int Cubos = Convert.ToInt32(TB_Cubos.Text);
            int ResultCubos = ExibeCubos(Cubos, i);
            LB.Items.Add(ResultCubos);
        }
        int ExibeCubos(int Cubo, int i)
        {
            if (Cubo > 0 && i == 0) return ExibeCubos(Cubo * Cubo * Cubo, i += 1);
            else return Cubo;
        }

        private void BT_MDC_Click(object sender, EventArgs e)
        {
            int BaseMDC = Convert.ToInt32(TB_MDCX.Text);
            int ExpMDC = Convert.ToInt32(TB_MDCY.Text);
            int ResultMDC = ExibeMDC(BaseMDC, ExpMDC);
            LB.Items.Add(ResultMDC);
        }
        int ExibeMDC(int X, int Y)
        {
            if (Y == 0) return X;
            else return ExibeMDC(Y, X % Y);
        }

        private void BT_Fibo_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_Fibo.Text);
            int ResultFibo = ExibeFibo(n);
            LB.Items.Add(ResultFibo);
        }
        int ExibeFibo(int n)
        {
            if (n == 0 || n == 1) return n;
            else return ExibeFibo(n - 1) + ExibeFibo(n - 2);
        }

        private void BT_FiboInt_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_FiboInt.Text);
            ExibeFiboInt(n);
        }
        void ExibeFiboInt(int n)
        {
            int num1 = 0, num2 = 1, aux;
            for (int i = 0; i​​​​​​​ < n-1; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }
            LB.Items.Add(num2);
        }

        private void BT_NB_Click(object sender, EventArgs e)
        {
            int numero_NB = Convert.ToInt32(TB_NB.Text);
            int ResultNB = ExibeNB(numero_NB);
            LB.Items.Add(ResultNB);
        }
        int ExibeNB(int num)
        {
            if (num > 0)
            {
                LB.Items.Clear();
                ExibeNB(num / 2);
                LB.Items.Add(num % 2);
            }
            return (num % 2);
        }
    }
}
    

