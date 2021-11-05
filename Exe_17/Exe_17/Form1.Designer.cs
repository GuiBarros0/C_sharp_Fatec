
namespace Exe_17
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_insere = new System.Windows.Forms.Button();
            this.b_remove = new System.Windows.Forms.Button();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.lb_saida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Números Removidos";
            // 
            // b_insere
            // 
            this.b_insere.Location = new System.Drawing.Point(31, 77);
            this.b_insere.Name = "b_insere";
            this.b_insere.Size = new System.Drawing.Size(100, 23);
            this.b_insere.TabIndex = 2;
            this.b_insere.Text = "Insere na Lista";
            this.b_insere.UseVisualStyleBackColor = true;
            this.b_insere.Click += new System.EventHandler(this.b_insere_Click);
            // 
            // b_remove
            // 
            this.b_remove.Location = new System.Drawing.Point(31, 106);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(97, 23);
            this.b_remove.TabIndex = 3;
            this.b_remove.Text = "Remove da lista";
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(31, 51);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(100, 20);
            this.tb_numero.TabIndex = 4;
            this.tb_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_KeyPress);
            // 
            // lb_saida
            // 
            this.lb_saida.FormattingEnabled = true;
            this.lb_saida.Location = new System.Drawing.Point(154, 51);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(120, 95);
            this.lb_saida.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(322, 201);
            this.Controls.Add(this.lb_saida);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.b_remove);
            this.Controls.Add(this.b_insere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_insere;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.ListBox lb_saida;
    }
}

