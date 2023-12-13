namespace MiniERPAdoNET
{
    partial class Mini_ERP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Tab_CadastroProdutos = new TabPage();
            dataGridViewProdutos = new DataGridView();
            label2 = new Label();
            panel_produto = new Panel();
            textBoxCNPJVinculo = new TextBox();
            label20 = new Label();
            btnAdicionarProduto = new Button();
            textBoxPreco = new TextBox();
            textBoxQuantidade = new TextBox();
            comboBoxCor = new ComboBox();
            comboBoxTamanho = new ComboBox();
            comboBoxTipo = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tabPageCadastroFornecedores = new TabPage();
            label3 = new Label();
            buttonMostrarFornecedores = new Button();
            BtnAtualizarForne = new Button();
            label9 = new Label();
            Box_Fornecedores = new DataGridView();
            panel2 = new Panel();
            textBoxTelFornecedor = new TextBox();
            buttonDeletarFornecedor = new Button();
            textBoxEndFornecedor = new TextBox();
            textBoxCNPJ = new TextBox();
            buttonAdicionarFornecedor = new Button();
            textBoxNomeFornecedor = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPageCadastroClientes = new TabPage();
            label12 = new Label();
            dataGridViewClientes = new DataGridView();
            label15 = new Label();
            panel3 = new Panel();
            textBoxTelCliente = new TextBox();
            textBoxEndCliente = new TextBox();
            textBoxCPF = new TextBox();
            button2 = new Button();
            textBoxNomeCliente = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            tabPageNotas = new TabPage();
            label21 = new Label();
            dataGridViewNota = new DataGridView();
            panel4 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonGerarPDF = new Button();
            label25 = new Label();
            buttonEnviarNota = new Button();
            label26 = new Label();
            textBox4 = new TextBox();
            label24 = new Label();
            label22 = new Label();
            tabControl1.SuspendLayout();
            Tab_CadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            panel_produto.SuspendLayout();
            tabPageCadastroFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Box_Fornecedores).BeginInit();
            panel2.SuspendLayout();
            tabPageCadastroClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel3.SuspendLayout();
            tabPageNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Tab_CadastroProdutos);
            tabControl1.Controls.Add(tabPageCadastroFornecedores);
            tabControl1.Controls.Add(tabPageCadastroClientes);
            tabControl1.Controls.Add(tabPageNotas);
            tabControl1.Location = new Point(-1, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(908, 415);
            tabControl1.TabIndex = 0;
            // 
            // Tab_CadastroProdutos
            // 
            Tab_CadastroProdutos.BackColor = Color.Transparent;
            Tab_CadastroProdutos.Controls.Add(dataGridViewProdutos);
            Tab_CadastroProdutos.Controls.Add(label2);
            Tab_CadastroProdutos.Controls.Add(panel_produto);
            Tab_CadastroProdutos.Controls.Add(label1);
            Tab_CadastroProdutos.Location = new Point(4, 24);
            Tab_CadastroProdutos.Margin = new Padding(3, 2, 3, 2);
            Tab_CadastroProdutos.Name = "Tab_CadastroProdutos";
            Tab_CadastroProdutos.Padding = new Padding(3, 2, 3, 2);
            Tab_CadastroProdutos.Size = new Size(900, 387);
            Tab_CadastroProdutos.TabIndex = 0;
            Tab_CadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(484, 46);
            dataGridViewProdutos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.RowTemplate.Height = 29;
            dataGridViewProdutos.Size = new Size(410, 322);
            dataGridViewProdutos.TabIndex = 3;
            dataGridViewProdutos.CellContentClick += dataGridViewProdutos_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(558, 17);
            label2.Name = "label2";
            label2.Size = new Size(256, 27);
            label2.TabIndex = 2;
            label2.Text = "ESTOQUE DE PRODUTOS";
            label2.Click += label2_Click;
            // 
            // panel_produto
            // 
            panel_produto.BackColor = Color.Gainsboro;
            panel_produto.BorderStyle = BorderStyle.FixedSingle;
            panel_produto.Controls.Add(textBoxCNPJVinculo);
            panel_produto.Controls.Add(label20);
            panel_produto.Controls.Add(btnAdicionarProduto);
            panel_produto.Controls.Add(textBoxPreco);
            panel_produto.Controls.Add(textBoxQuantidade);
            panel_produto.Controls.Add(comboBoxCor);
            panel_produto.Controls.Add(comboBoxTamanho);
            panel_produto.Controls.Add(comboBoxTipo);
            panel_produto.Controls.Add(label8);
            panel_produto.Controls.Add(label7);
            panel_produto.Controls.Add(label6);
            panel_produto.Controls.Add(label5);
            panel_produto.Controls.Add(label4);
            panel_produto.ForeColor = SystemColors.ActiveCaptionText;
            panel_produto.Location = new Point(9, 46);
            panel_produto.Margin = new Padding(3, 2, 3, 2);
            panel_produto.Name = "panel_produto";
            panel_produto.Size = new Size(460, 322);
            panel_produto.TabIndex = 0;
            // 
            // textBoxCNPJVinculo
            // 
            textBoxCNPJVinculo.Location = new Point(128, 176);
            textBoxCNPJVinculo.Margin = new Padding(3, 2, 3, 2);
            textBoxCNPJVinculo.Name = "textBoxCNPJVinculo";
            textBoxCNPJVinculo.Size = new Size(285, 23);
            textBoxCNPJVinculo.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(19, 179);
            label20.Name = "label20";
            label20.Size = new Size(113, 15);
            label20.TabIndex = 16;
            label20.Text = "CNPJ Fornecedor :";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarProduto.Location = new Point(109, 239);
            btnAdicionarProduto.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(208, 33);
            btnAdicionarProduto.TabIndex = 1;
            btnAdicionarProduto.Text = "Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(363, 74);
            textBoxPreco.Margin = new Padding(3, 2, 3, 2);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(75, 23);
            textBoxPreco.TabIndex = 15;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(255, 74);
            textBoxQuantidade.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(62, 23);
            textBoxQuantidade.TabIndex = 14;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Items.AddRange(new object[] { "Preto", "Branco", "Jeans" });
            comboBoxCor.Location = new Point(246, 121);
            comboBoxCor.Margin = new Padding(3, 2, 3, 2);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(115, 23);
            comboBoxCor.TabIndex = 13;
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "P", "M", "G" });
            comboBoxTamanho.Location = new Point(104, 121);
            comboBoxTamanho.Margin = new Padding(3, 2, 3, 2);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(72, 23);
            comboBoxTamanho.TabIndex = 12;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Camiseta", "Calça", "Moletom", "Vestido", "Shorts" });
            comboBoxTipo.Location = new Point(43, 74);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(133, 23);
            comboBoxTipo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(212, 121);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 9;
            label8.Text = "Cor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 121);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 8;
            label7.Text = "Tamanho :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(186, 54);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 7;
            label6.Text = "Quantidade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(324, 57);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Preço :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 54);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 17);
            label1.Name = "label1";
            label1.Size = new Size(240, 27);
            label1.TabIndex = 0;
            label1.Text = "CADASTRE O PRODUTO";
            // 
            // tabPageCadastroFornecedores
            // 
            tabPageCadastroFornecedores.Controls.Add(label3);
            tabPageCadastroFornecedores.Controls.Add(buttonMostrarFornecedores);
            tabPageCadastroFornecedores.Controls.Add(BtnAtualizarForne);
            tabPageCadastroFornecedores.Controls.Add(label9);
            tabPageCadastroFornecedores.Controls.Add(Box_Fornecedores);
            tabPageCadastroFornecedores.Controls.Add(panel2);
            tabPageCadastroFornecedores.Location = new Point(4, 24);
            tabPageCadastroFornecedores.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastroFornecedores.Name = "tabPageCadastroFornecedores";
            tabPageCadastroFornecedores.Padding = new Padding(3, 2, 3, 2);
            tabPageCadastroFornecedores.Size = new Size(900, 387);
            tabPageCadastroFornecedores.TabIndex = 1;
            tabPageCadastroFornecedores.Text = "Cadastro de Fornecedores";
            tabPageCadastroFornecedores.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(510, 11);
            label3.Name = "label3";
            label3.Size = new Size(324, 27);
            label3.TabIndex = 12;
            label3.Text = "FORNECEDORES CADASTRADOS";
            // 
            // buttonMostrarFornecedores
            // 
            buttonMostrarFornecedores.BackColor = SystemColors.ActiveCaption;
            buttonMostrarFornecedores.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMostrarFornecedores.Location = new Point(759, 332);
            buttonMostrarFornecedores.Margin = new Padding(3, 2, 3, 2);
            buttonMostrarFornecedores.Name = "buttonMostrarFornecedores";
            buttonMostrarFornecedores.Size = new Size(125, 35);
            buttonMostrarFornecedores.TabIndex = 11;
            buttonMostrarFornecedores.Text = "Visualizar Todos";
            buttonMostrarFornecedores.UseVisualStyleBackColor = false;
            buttonMostrarFornecedores.Click += buttonMostrarFornecedores_Click;
            // 
            // BtnAtualizarForne
            // 
            BtnAtualizarForne.BackColor = SystemColors.ActiveCaption;
            BtnAtualizarForne.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAtualizarForne.Location = new Point(470, 332);
            BtnAtualizarForne.Margin = new Padding(3, 2, 3, 2);
            BtnAtualizarForne.Name = "BtnAtualizarForne";
            BtnAtualizarForne.Size = new Size(121, 35);
            BtnAtualizarForne.TabIndex = 9;
            BtnAtualizarForne.Text = "Atualizar";
            BtnAtualizarForne.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(78, 11);
            label9.Name = "label9";
            label9.Size = new Size(278, 27);
            label9.TabIndex = 4;
            label9.Text = "CADASTRE O FORNECEDOR";
            // 
            // Box_Fornecedores
            // 
            Box_Fornecedores.BackgroundColor = SystemColors.ControlLight;
            Box_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Box_Fornecedores.GridColor = Color.Black;
            Box_Fornecedores.Location = new Point(470, 40);
            Box_Fornecedores.Margin = new Padding(3, 2, 3, 2);
            Box_Fornecedores.Name = "Box_Fornecedores";
            Box_Fornecedores.RowHeadersWidth = 51;
            Box_Fornecedores.RowTemplate.Height = 29;
            Box_Fornecedores.Size = new Size(414, 288);
            Box_Fornecedores.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxTelFornecedor);
            panel2.Controls.Add(buttonDeletarFornecedor);
            panel2.Controls.Add(textBoxEndFornecedor);
            panel2.Controls.Add(textBoxCNPJ);
            panel2.Controls.Add(buttonAdicionarFornecedor);
            panel2.Controls.Add(textBoxNomeFornecedor);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(9, 40);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 288);
            panel2.TabIndex = 5;
            // 
            // textBoxTelFornecedor
            // 
            textBoxTelFornecedor.Location = new Point(58, 133);
            textBoxTelFornecedor.Margin = new Padding(3, 2, 3, 2);
            textBoxTelFornecedor.Name = "textBoxTelFornecedor";
            textBoxTelFornecedor.Size = new Size(160, 23);
            textBoxTelFornecedor.TabIndex = 17;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.BackColor = Color.Gray;
            buttonDeletarFornecedor.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletarFornecedor.Location = new Point(247, 191);
            buttonDeletarFornecedor.Margin = new Padding(3, 2, 3, 2);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(90, 35);
            buttonDeletarFornecedor.TabIndex = 10;
            buttonDeletarFornecedor.Text = "Deletar";
            buttonDeletarFornecedor.UseVisualStyleBackColor = false;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // textBoxEndFornecedor
            // 
            textBoxEndFornecedor.Location = new Point(58, 96);
            textBoxEndFornecedor.Margin = new Padding(3, 2, 3, 2);
            textBoxEndFornecedor.Name = "textBoxEndFornecedor";
            textBoxEndFornecedor.Size = new Size(348, 23);
            textBoxEndFornecedor.TabIndex = 16;
            // 
            // textBoxCNPJ
            // 
            textBoxCNPJ.Location = new Point(262, 133);
            textBoxCNPJ.Margin = new Padding(3, 2, 3, 2);
            textBoxCNPJ.Multiline = true;
            textBoxCNPJ.Name = "textBoxCNPJ";
            textBoxCNPJ.Size = new Size(144, 23);
            textBoxCNPJ.TabIndex = 15;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = SystemColors.GradientActiveCaption;
            buttonAdicionarFornecedor.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarFornecedor.Location = new Point(120, 191);
            buttonAdicionarFornecedor.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(96, 35);
            buttonAdicionarFornecedor.TabIndex = 6;
            buttonAdicionarFornecedor.Text = "Adicionar";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(58, 53);
            textBoxNomeFornecedor.Margin = new Padding(3, 2, 3, 2);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(348, 23);
            textBoxNomeFornecedor.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(2, 136);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 9;
            label10.Text = "Contato";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1, 99);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 8;
            label11.Text = "Endereço";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(224, 136);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 6;
            label13.Text = "CNPJ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(9, 56);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 5;
            label14.Text = "Nome";
            // 
            // tabPageCadastroClientes
            // 
            tabPageCadastroClientes.Controls.Add(label12);
            tabPageCadastroClientes.Controls.Add(dataGridViewClientes);
            tabPageCadastroClientes.Controls.Add(label15);
            tabPageCadastroClientes.Controls.Add(panel3);
            tabPageCadastroClientes.Location = new Point(4, 24);
            tabPageCadastroClientes.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastroClientes.Name = "tabPageCadastroClientes";
            tabPageCadastroClientes.Size = new Size(900, 387);
            tabPageCadastroClientes.TabIndex = 2;
            tabPageCadastroClientes.Text = "Cadastro de Clientes";
            tabPageCadastroClientes.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(551, 11);
            label12.Name = "label12";
            label12.Size = new Size(211, 27);
            label12.TabIndex = 14;
            label12.Text = "LISTA DE CLIENTES";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = SystemColors.ControlLight;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(467, 40);
            dataGridViewClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(407, 314);
            dataGridViewClientes.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(117, 11);
            label15.Name = "label15";
            label15.Size = new Size(231, 27);
            label15.TabIndex = 9;
            label15.Text = "CADASTRE O CLIENTE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxTelCliente);
            panel3.Controls.Add(textBoxEndCliente);
            panel3.Controls.Add(textBoxCPF);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBoxNomeCliente);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(9, 40);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 314);
            panel3.TabIndex = 10;
            // 
            // textBoxTelCliente
            // 
            textBoxTelCliente.Location = new Point(68, 156);
            textBoxTelCliente.Margin = new Padding(3, 2, 3, 2);
            textBoxTelCliente.Multiline = true;
            textBoxTelCliente.Name = "textBoxTelCliente";
            textBoxTelCliente.Size = new Size(132, 23);
            textBoxTelCliente.TabIndex = 17;
            textBoxTelCliente.TextChanged += textBoxTelCliente_TextChanged;
            // 
            // textBoxEndCliente
            // 
            textBoxEndCliente.Location = new Point(68, 109);
            textBoxEndCliente.Margin = new Padding(3, 2, 3, 2);
            textBoxEndCliente.Name = "textBoxEndCliente";
            textBoxEndCliente.Size = new Size(314, 23);
            textBoxEndCliente.TabIndex = 16;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(237, 156);
            textBoxCPF.Margin = new Padding(3, 2, 3, 2);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(145, 23);
            textBoxCPF.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(143, 229);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 11;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(68, 62);
            textBoxNomeCliente.Margin = new Padding(3, 2, 3, 2);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(314, 23);
            textBoxNomeCliente.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(11, 156);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 9;
            label16.Text = "Telefone";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(6, 112);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 8;
            label17.Text = "Endereço";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(203, 156);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 6;
            label18.Text = "CPF";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(22, 70);
            label19.Name = "label19";
            label19.Size = new Size(41, 15);
            label19.TabIndex = 5;
            label19.Text = "Nome";
            // 
            // tabPageNotas
            // 
            tabPageNotas.Controls.Add(label21);
            tabPageNotas.Controls.Add(dataGridViewNota);
            tabPageNotas.Controls.Add(panel4);
            tabPageNotas.Controls.Add(label22);
            tabPageNotas.Location = new Point(4, 24);
            tabPageNotas.Margin = new Padding(3, 2, 3, 2);
            tabPageNotas.Name = "tabPageNotas";
            tabPageNotas.Size = new Size(900, 387);
            tabPageNotas.TabIndex = 3;
            tabPageNotas.Text = "Lançamento de Notas";
            tabPageNotas.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(586, 7);
            label21.Name = "label21";
            label21.Size = new Size(156, 27);
            label21.TabIndex = 18;
            label21.Text = "NOTA GERADA";
            // 
            // dataGridViewNota
            // 
            dataGridViewNota.AllowUserToAddRows = false;
            dataGridViewNota.AllowUserToDeleteRows = false;
            dataGridViewNota.BackgroundColor = SystemColors.ControlLight;
            dataGridViewNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNota.Location = new Point(490, 36);
            dataGridViewNota.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNota.Name = "dataGridViewNota";
            dataGridViewNota.ReadOnly = true;
            dataGridViewNota.RowHeadersWidth = 51;
            dataGridViewNota.RowTemplate.Height = 29;
            dataGridViewNota.Size = new Size(376, 340);
            dataGridViewNota.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(buttonGerarPDF);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(buttonEnviarNota);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label24);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(27, 36);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 340);
            panel4.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 136);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 92);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 23);
            textBox3.TabIndex = 15;
            // 
            // buttonGerarPDF
            // 
            buttonGerarPDF.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarPDF.Location = new Point(273, 285);
            buttonGerarPDF.Margin = new Padding(3, 2, 3, 2);
            buttonGerarPDF.Name = "buttonGerarPDF";
            buttonGerarPDF.Size = new Size(134, 39);
            buttonGerarPDF.TabIndex = 16;
            buttonGerarPDF.Text = "Gerar PDF da Nota";
            buttonGerarPDF.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(81, 100);
            label25.Name = "label25";
            label25.Size = new Size(75, 15);
            label25.TabIndex = 6;
            label25.Text = "Quantidade";
            label25.Click += label25_Click;
            // 
            // buttonEnviarNota
            // 
            buttonEnviarNota.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnviarNota.Location = new Point(115, 195);
            buttonEnviarNota.Margin = new Padding(3, 2, 3, 2);
            buttonEnviarNota.Name = "buttonEnviarNota";
            buttonEnviarNota.Size = new Size(127, 39);
            buttonEnviarNota.TabIndex = 15;
            buttonEnviarNota.Text = "Enviar";
            buttonEnviarNota.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(82, 60);
            label26.Name = "label26";
            label26.Size = new Size(68, 15);
            label26.TabIndex = 5;
            label26.Text = "ID Produto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 52);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(82, 144);
            label24.Name = "label24";
            label24.Size = new Size(73, 15);
            label24.TabIndex = 8;
            label24.Text = "CPF Cliente";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(110, 7);
            label22.Name = "label22";
            label22.Size = new Size(248, 27);
            label22.TabIndex = 13;
            label22.Text = "LANÇAMENTO DE NOTA";
            // 
            // Mini_ERP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 428);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Mini_ERP";
            Text = "Mini_ERP";
            tabControl1.ResumeLayout(false);
            Tab_CadastroProdutos.ResumeLayout(false);
            Tab_CadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            panel_produto.ResumeLayout(false);
            panel_produto.PerformLayout();
            tabPageCadastroFornecedores.ResumeLayout(false);
            tabPageCadastroFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Box_Fornecedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageCadastroClientes.ResumeLayout(false);
            tabPageCadastroClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPageNotas.ResumeLayout(false);
            tabPageNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCadastroFornecedores;
        private TabPage tabPageCadastroClientes;
        private TabPage tabPageNotas;
        private DataGridView dataGridViewClientes;
        private Button button2;
        private Label label15;
        private Panel panel3;
        private TextBox textBoxTelCliente;
        private TextBox textBoxEndCliente;
        private TextBox textBoxCPF;
        private TextBox textBoxNomeCliente;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView Box_Fornecedores;
        private Button buttonAdicionarFornecedor;
        private Label label9;
        private Panel panel2;
        private TextBox textBoxTelFornecedor;
        private TextBox textBoxEndFornecedor;
        private TextBox textBoxCNPJ;
        private TextBox textBoxNomeFornecedor;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private DataGridView dataGridView2;
        private Button button3;
        private Label label22;
        private Panel panel4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button buttonGerarPDF;
        private Label label21;
        private DataGridView dataGridViewNota;
        private Button buttonEnviarNota;
        private Button BtnAtualizarForne;
        private Button buttonDeletarFornecedor;
        private Button buttonMostrarFornecedores;
        private TabPage Tab_CadastroProdutos;
        private DataGridView dataGridViewProdutos;
        private Label label2;
        private Panel panel_produto;
        private TextBox textBoxCNPJVinculo;
        private Label label20;
        private Button btnAdicionarProduto;
        private TextBox textBoxPreco;
        private Label label1;
        private TextBox textBoxQuantidade;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxTipo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxTamanho;
        private Label label3;
        private Label label12;
    }
}