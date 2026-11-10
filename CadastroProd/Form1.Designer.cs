namespace CadastroProd
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtDescricao = new TextBox();
            cmbFornecedor = new ComboBox();
            cmbCategoria = new ComboBox();
            txtNomeProd = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            numEstoqueMinimo = new NumericUpDown();
            numEstoqueInicial = new NumericUpDown();
            txtMargem = new TextBox();
            txtPrecoVenda = new TextBox();
            txtPrecoCusto = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dtpDataCadastro = new DateTimePicker();
            label12 = new Label();
            chkAtivo = new CheckBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            panel1 = new Panel();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEstoqueInicial).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(cmbFornecedor);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtNomeProd);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Emoji", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 148);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(1777, 453);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Principais";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(633, 251);
            txtDescricao.Margin = new Padding(6, 7, 6, 7);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1102, 174);
            txtDescricao.TabIndex = 4;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(12, 276);
            cmbFornecedor.Margin = new Padding(6, 7, 6, 7);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(537, 44);
            cmbFornecedor.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(1306, 114);
            cmbCategoria.Margin = new Padding(6, 7, 6, 7);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(429, 44);
            cmbCategoria.TabIndex = 2;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(502, 115);
            txtNomeProd.Margin = new Padding(6, 7, 6, 7);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(754, 43);
            txtNomeProd.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ScrollBar;
            txtCodigo.Location = new Point(12, 115);
            txtCodigo.Margin = new Padding(6, 7, 6, 7);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(320, 43);
            txtCodigo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 208);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 36);
            label5.TabIndex = 5;
            label5.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 208);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 6;
            label4.Text = "Fornecedor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1306, 54);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 36);
            label3.TabIndex = 7;
            label3.Text = "Categoria: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 54);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 36);
            label2.TabIndex = 8;
            label2.Text = "Nome do Produto: *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 36);
            label1.TabIndex = 9;
            label1.Text = "Código:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numEstoqueMinimo);
            groupBox2.Controls.Add(numEstoqueInicial);
            groupBox2.Controls.Add(txtMargem);
            groupBox2.Controls.Add(txtPrecoVenda);
            groupBox2.Controls.Add(txtPrecoCusto);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(26, 615);
            groupBox2.Margin = new Padding(6, 7, 6, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 7, 6, 7);
            groupBox2.Size = new Size(1029, 350);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precificação e Estoque";
            // 
            // numEstoqueMinimo
            // 
            numEstoqueMinimo.Location = new Point(675, 286);
            numEstoqueMinimo.Margin = new Padding(6, 7, 6, 7);
            numEstoqueMinimo.Name = "numEstoqueMinimo";
            numEstoqueMinimo.Size = new Size(260, 39);
            numEstoqueMinimo.TabIndex = 9;
            // 
            // numEstoqueInicial
            // 
            numEstoqueInicial.Location = new Point(7, 286);
            numEstoqueInicial.Margin = new Padding(6, 7, 6, 7);
            numEstoqueInicial.Name = "numEstoqueInicial";
            numEstoqueInicial.Size = new Size(260, 39);
            numEstoqueInicial.TabIndex = 8;
            // 
            // txtMargem
            // 
            txtMargem.BackColor = SystemColors.ScrollBar;
            txtMargem.Location = new Point(12, 190);
            txtMargem.Margin = new Padding(6, 7, 6, 7);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(303, 39);
            txtMargem.TabIndex = 7;
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Location = new Point(693, 51);
            txtPrecoVenda.Margin = new Padding(6, 7, 6, 7);
            txtPrecoVenda.Multiline = true;
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(255, 39);
            txtPrecoVenda.TabIndex = 6;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(12, 98);
            txtPrecoCusto.Margin = new Padding(6, 7, 6, 7);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(255, 39);
            txtPrecoCusto.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(356, 288);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(209, 32);
            label10.TabIndex = 10;
            label10.Text = "Estoque Mínimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 243);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(188, 32);
            label9.TabIndex = 11;
            label9.Text = "Estoque Inicial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 153);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 32);
            label8.TabIndex = 12;
            label8.Text = "Margem (R$):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 54);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(255, 32);
            label7.TabIndex = 13;
            label7.Text = "Preço de Venda (R$):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 54);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(248, 32);
            label6.TabIndex = 14;
            label6.Text = "Preço de Custo (R$):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpDataCadastro);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(chkAtivo);
            groupBox3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1148, 615);
            groupBox3.Margin = new Padding(6, 7, 6, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6, 7, 6, 7);
            groupBox3.Size = new Size(650, 371);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Situação / Detalhes";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(50, 236);
            dtpDataCadastro.Margin = new Padding(6, 7, 6, 7);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(494, 39);
            dtpDataCadastro.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 197);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(219, 32);
            label12.TabIndex = 12;
            label12.Text = "Data de Cadastro:";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(43, 98);
            chkAtivo.Margin = new Padding(6, 7, 6, 7);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(206, 36);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Produto Ativo";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(479, 1024);
            btnNovo.Margin = new Padding(6, 7, 6, 7);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(195, 74);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(710, 1024);
            btnSalvar.Margin = new Padding(6, 7, 6, 7);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(195, 74);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(954, 1024);
            btnLimpar.Margin = new Padding(6, 7, 6, 7);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(195, 74);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(1209, 1024);
            btnExcluir.Margin = new Padding(6, 7, 6, 7);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(195, 74);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label11);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1841, 124);
            panel1.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.HotTrack;
            label11.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(38, 26);
            label11.Name = "label11";
            label11.Size = new Size(505, 65);
            label11.TabIndex = 10;
            label11.Text = "Cadastro de Produtos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1842, 1123);
            Controls.Add(panel1);
            Controls.Add(btnExcluir);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEstoqueInicial).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numEstoqueMinimo;
        private System.Windows.Forms.NumericUpDown numEstoqueInicial;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private Panel panel1;
        private Label label11;
    }
}

