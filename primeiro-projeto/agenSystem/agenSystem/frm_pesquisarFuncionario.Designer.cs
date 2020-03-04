namespace agenSystem
{
    partial class frm_pesquisarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisarFuncionario));
            this.mkNascimentoConsultaFun = new System.Windows.Forms.MaskedTextBox();
            this.mkCepConsultaFun = new System.Windows.Forms.MaskedTextBox();
            this.cbEstadoConsultaFun = new System.Windows.Forms.ComboBox();
            this.mkTelefoneConsultaFun = new System.Windows.Forms.MaskedTextBox();
            this.mkCelularConsultaFun = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfConsultaFun = new System.Windows.Forms.Label();
            this.lbCelularConsultaFun = new System.Windows.Forms.Label();
            this.lbTelefoneConsultaFun = new System.Windows.Forms.Label();
            this.lbEstadoConsultaFun = new System.Windows.Forms.Label();
            this.lbCepConsultaFun = new System.Windows.Forms.Label();
            this.txtCidadeConsultaFun = new System.Windows.Forms.TextBox();
            this.lbCidadeConsultaFun = new System.Windows.Forms.Label();
            this.txtBairroConsultaFun = new System.Windows.Forms.TextBox();
            this.lbBairroConsultaFun = new System.Windows.Forms.Label();
            this.txtComplementoConsultaFun = new System.Windows.Forms.TextBox();
            this.lbComplementoConsultaFun = new System.Windows.Forms.Label();
            this.txtEnderecoConsultaFun = new System.Windows.Forms.TextBox();
            this.lbEnderecoConsultaFun = new System.Windows.Forms.Label();
            this.lbNascimentoConsultaFun = new System.Windows.Forms.Label();
            this.txtEmailConsultaFun = new System.Windows.Forms.TextBox();
            this.lbEmailConsultaFun = new System.Windows.Forms.Label();
            this.txtFuncaoConsultaFun = new System.Windows.Forms.TextBox();
            this.lbFuncaoConsultaFun = new System.Windows.Forms.Label();
            this.txtNomeConsultaFun = new System.Windows.Forms.TextBox();
            this.lbNomeConsultaFun = new System.Windows.Forms.Label();
            this.txtCodigoConsultaFun = new System.Windows.Forms.TextBox();
            this.lbCodigoConsultaFun = new System.Windows.Forms.Label();
            this.btSairConsultaFun = new System.Windows.Forms.Button();
            this.btExcluirConsultaFun = new System.Windows.Forms.Button();
            this.btEditarConsultaFun = new System.Windows.Forms.Button();
            this.btSalvarConsultaFun = new System.Windows.Forms.Button();
            this.btPesquisarConsultaFun = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mkCpfConsultaFun = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mkNascimentoConsultaFun
            // 
            this.mkNascimentoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkNascimentoConsultaFun.Location = new System.Drawing.Point(375, 295);
            this.mkNascimentoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.mkNascimentoConsultaFun.Mask = "00/00/0000";
            this.mkNascimentoConsultaFun.Name = "mkNascimentoConsultaFun";
            this.mkNascimentoConsultaFun.Size = new System.Drawing.Size(82, 24);
            this.mkNascimentoConsultaFun.TabIndex = 12;
            this.mkNascimentoConsultaFun.ValidatingType = typeof(System.DateTime);
            // 
            // mkCepConsultaFun
            // 
            this.mkCepConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCepConsultaFun.Location = new System.Drawing.Point(375, 331);
            this.mkCepConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.mkCepConsultaFun.Mask = "00000-999";
            this.mkCepConsultaFun.Name = "mkCepConsultaFun";
            this.mkCepConsultaFun.Size = new System.Drawing.Size(82, 24);
            this.mkCepConsultaFun.TabIndex = 14;
            // 
            // cbEstadoConsultaFun
            // 
            this.cbEstadoConsultaFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoConsultaFun.FormattingEnabled = true;
            this.cbEstadoConsultaFun.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso do Sul (MS)",
            "Mato Grosso (MT)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbEstadoConsultaFun.Location = new System.Drawing.Point(375, 511);
            this.cbEstadoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoConsultaFun.Name = "cbEstadoConsultaFun";
            this.cbEstadoConsultaFun.Size = new System.Drawing.Size(271, 26);
            this.cbEstadoConsultaFun.TabIndex = 24;
            // 
            // mkTelefoneConsultaFun
            // 
            this.mkTelefoneConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkTelefoneConsultaFun.Location = new System.Drawing.Point(375, 547);
            this.mkTelefoneConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.mkTelefoneConsultaFun.Mask = "(99) 00000-0000";
            this.mkTelefoneConsultaFun.Name = "mkTelefoneConsultaFun";
            this.mkTelefoneConsultaFun.Size = new System.Drawing.Size(115, 24);
            this.mkTelefoneConsultaFun.TabIndex = 26;
            // 
            // mkCelularConsultaFun
            // 
            this.mkCelularConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCelularConsultaFun.Location = new System.Drawing.Point(375, 583);
            this.mkCelularConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.mkCelularConsultaFun.Mask = "(99) 00000-0000";
            this.mkCelularConsultaFun.Name = "mkCelularConsultaFun";
            this.mkCelularConsultaFun.Size = new System.Drawing.Size(115, 24);
            this.mkCelularConsultaFun.TabIndex = 28;
            // 
            // lbCpfConsultaFun
            // 
            this.lbCpfConsultaFun.AutoSize = true;
            this.lbCpfConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfConsultaFun.Location = new System.Drawing.Point(260, 193);
            this.lbCpfConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpfConsultaFun.Name = "lbCpfConsultaFun";
            this.lbCpfConsultaFun.Size = new System.Drawing.Size(44, 18);
            this.lbCpfConsultaFun.TabIndex = 5;
            this.lbCpfConsultaFun.Text = "CPF*";
            // 
            // lbCelularConsultaFun
            // 
            this.lbCelularConsultaFun.AutoSize = true;
            this.lbCelularConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelularConsultaFun.Location = new System.Drawing.Point(260, 587);
            this.lbCelularConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCelularConsultaFun.Name = "lbCelularConsultaFun";
            this.lbCelularConsultaFun.Size = new System.Drawing.Size(54, 18);
            this.lbCelularConsultaFun.TabIndex = 27;
            this.lbCelularConsultaFun.Text = "Celular";
            // 
            // lbTelefoneConsultaFun
            // 
            this.lbTelefoneConsultaFun.AutoSize = true;
            this.lbTelefoneConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneConsultaFun.Location = new System.Drawing.Point(260, 551);
            this.lbTelefoneConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefoneConsultaFun.Name = "lbTelefoneConsultaFun";
            this.lbTelefoneConsultaFun.Size = new System.Drawing.Size(65, 18);
            this.lbTelefoneConsultaFun.TabIndex = 25;
            this.lbTelefoneConsultaFun.Text = "Telefone";
            // 
            // lbEstadoConsultaFun
            // 
            this.lbEstadoConsultaFun.AutoSize = true;
            this.lbEstadoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoConsultaFun.Location = new System.Drawing.Point(260, 515);
            this.lbEstadoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstadoConsultaFun.Name = "lbEstadoConsultaFun";
            this.lbEstadoConsultaFun.Size = new System.Drawing.Size(55, 18);
            this.lbEstadoConsultaFun.TabIndex = 23;
            this.lbEstadoConsultaFun.Text = "Estado";
            // 
            // lbCepConsultaFun
            // 
            this.lbCepConsultaFun.AutoSize = true;
            this.lbCepConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCepConsultaFun.Location = new System.Drawing.Point(260, 335);
            this.lbCepConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCepConsultaFun.Name = "lbCepConsultaFun";
            this.lbCepConsultaFun.Size = new System.Drawing.Size(39, 18);
            this.lbCepConsultaFun.TabIndex = 13;
            this.lbCepConsultaFun.Text = "CEP";
            // 
            // txtCidadeConsultaFun
            // 
            this.txtCidadeConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeConsultaFun.Location = new System.Drawing.Point(375, 475);
            this.txtCidadeConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeConsultaFun.Name = "txtCidadeConsultaFun";
            this.txtCidadeConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtCidadeConsultaFun.TabIndex = 22;
            // 
            // lbCidadeConsultaFun
            // 
            this.lbCidadeConsultaFun.AutoSize = true;
            this.lbCidadeConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidadeConsultaFun.Location = new System.Drawing.Point(260, 479);
            this.lbCidadeConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCidadeConsultaFun.Name = "lbCidadeConsultaFun";
            this.lbCidadeConsultaFun.Size = new System.Drawing.Size(54, 18);
            this.lbCidadeConsultaFun.TabIndex = 21;
            this.lbCidadeConsultaFun.Text = "Cidade";
            // 
            // txtBairroConsultaFun
            // 
            this.txtBairroConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroConsultaFun.Location = new System.Drawing.Point(375, 439);
            this.txtBairroConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairroConsultaFun.Name = "txtBairroConsultaFun";
            this.txtBairroConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtBairroConsultaFun.TabIndex = 20;
            // 
            // lbBairroConsultaFun
            // 
            this.lbBairroConsultaFun.AutoSize = true;
            this.lbBairroConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairroConsultaFun.Location = new System.Drawing.Point(260, 443);
            this.lbBairroConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBairroConsultaFun.Name = "lbBairroConsultaFun";
            this.lbBairroConsultaFun.Size = new System.Drawing.Size(48, 18);
            this.lbBairroConsultaFun.TabIndex = 19;
            this.lbBairroConsultaFun.Text = "Bairro";
            // 
            // txtComplementoConsultaFun
            // 
            this.txtComplementoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoConsultaFun.Location = new System.Drawing.Point(375, 403);
            this.txtComplementoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplementoConsultaFun.Name = "txtComplementoConsultaFun";
            this.txtComplementoConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtComplementoConsultaFun.TabIndex = 18;
            // 
            // lbComplementoConsultaFun
            // 
            this.lbComplementoConsultaFun.AutoSize = true;
            this.lbComplementoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplementoConsultaFun.Location = new System.Drawing.Point(260, 407);
            this.lbComplementoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComplementoConsultaFun.Name = "lbComplementoConsultaFun";
            this.lbComplementoConsultaFun.Size = new System.Drawing.Size(102, 18);
            this.lbComplementoConsultaFun.TabIndex = 17;
            this.lbComplementoConsultaFun.Text = "Complemento";
            // 
            // txtEnderecoConsultaFun
            // 
            this.txtEnderecoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoConsultaFun.Location = new System.Drawing.Point(375, 367);
            this.txtEnderecoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnderecoConsultaFun.Name = "txtEnderecoConsultaFun";
            this.txtEnderecoConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtEnderecoConsultaFun.TabIndex = 16;
            // 
            // lbEnderecoConsultaFun
            // 
            this.lbEnderecoConsultaFun.AutoSize = true;
            this.lbEnderecoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnderecoConsultaFun.Location = new System.Drawing.Point(260, 371);
            this.lbEnderecoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnderecoConsultaFun.Name = "lbEnderecoConsultaFun";
            this.lbEnderecoConsultaFun.Size = new System.Drawing.Size(72, 18);
            this.lbEnderecoConsultaFun.TabIndex = 15;
            this.lbEnderecoConsultaFun.Text = "Endereço";
            // 
            // lbNascimentoConsultaFun
            // 
            this.lbNascimentoConsultaFun.AutoSize = true;
            this.lbNascimentoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimentoConsultaFun.Location = new System.Drawing.Point(260, 301);
            this.lbNascimentoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNascimentoConsultaFun.Name = "lbNascimentoConsultaFun";
            this.lbNascimentoConsultaFun.Size = new System.Drawing.Size(88, 18);
            this.lbNascimentoConsultaFun.TabIndex = 11;
            this.lbNascimentoConsultaFun.Text = "Nascimento";
            // 
            // txtEmailConsultaFun
            // 
            this.txtEmailConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailConsultaFun.Location = new System.Drawing.Point(375, 261);
            this.txtEmailConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailConsultaFun.Name = "txtEmailConsultaFun";
            this.txtEmailConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtEmailConsultaFun.TabIndex = 10;
            // 
            // lbEmailConsultaFun
            // 
            this.lbEmailConsultaFun.AutoSize = true;
            this.lbEmailConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailConsultaFun.Location = new System.Drawing.Point(260, 265);
            this.lbEmailConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailConsultaFun.Name = "lbEmailConsultaFun";
            this.lbEmailConsultaFun.Size = new System.Drawing.Size(50, 18);
            this.lbEmailConsultaFun.TabIndex = 9;
            this.lbEmailConsultaFun.Text = "E-mail";
            // 
            // txtFuncaoConsultaFun
            // 
            this.txtFuncaoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncaoConsultaFun.Location = new System.Drawing.Point(375, 225);
            this.txtFuncaoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncaoConsultaFun.Name = "txtFuncaoConsultaFun";
            this.txtFuncaoConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtFuncaoConsultaFun.TabIndex = 8;
            // 
            // lbFuncaoConsultaFun
            // 
            this.lbFuncaoConsultaFun.AutoSize = true;
            this.lbFuncaoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncaoConsultaFun.Location = new System.Drawing.Point(260, 229);
            this.lbFuncaoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFuncaoConsultaFun.Name = "lbFuncaoConsultaFun";
            this.lbFuncaoConsultaFun.Size = new System.Drawing.Size(64, 18);
            this.lbFuncaoConsultaFun.TabIndex = 7;
            this.lbFuncaoConsultaFun.Text = "Função*";
            // 
            // txtNomeConsultaFun
            // 
            this.txtNomeConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConsultaFun.Location = new System.Drawing.Point(375, 154);
            this.txtNomeConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeConsultaFun.Name = "txtNomeConsultaFun";
            this.txtNomeConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtNomeConsultaFun.TabIndex = 4;
            // 
            // lbNomeConsultaFun
            // 
            this.lbNomeConsultaFun.AutoSize = true;
            this.lbNomeConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeConsultaFun.Location = new System.Drawing.Point(260, 158);
            this.lbNomeConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeConsultaFun.Name = "lbNomeConsultaFun";
            this.lbNomeConsultaFun.Size = new System.Drawing.Size(55, 18);
            this.lbNomeConsultaFun.TabIndex = 3;
            this.lbNomeConsultaFun.Text = "Nome*";
            // 
            // txtCodigoConsultaFun
            // 
            this.txtCodigoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoConsultaFun.Location = new System.Drawing.Point(375, 118);
            this.txtCodigoConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoConsultaFun.Name = "txtCodigoConsultaFun";
            this.txtCodigoConsultaFun.Size = new System.Drawing.Size(271, 24);
            this.txtCodigoConsultaFun.TabIndex = 2;
            // 
            // lbCodigoConsultaFun
            // 
            this.lbCodigoConsultaFun.AutoSize = true;
            this.lbCodigoConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoConsultaFun.Location = new System.Drawing.Point(260, 122);
            this.lbCodigoConsultaFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoConsultaFun.Name = "lbCodigoConsultaFun";
            this.lbCodigoConsultaFun.Size = new System.Drawing.Size(56, 18);
            this.lbCodigoConsultaFun.TabIndex = 1;
            this.lbCodigoConsultaFun.Text = "Código";
            // 
            // btSairConsultaFun
            // 
            this.btSairConsultaFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairConsultaFun.BackgroundImage")));
            this.btSairConsultaFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSairConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairConsultaFun.ForeColor = System.Drawing.Color.White;
            this.btSairConsultaFun.Location = new System.Drawing.Point(751, 625);
            this.btSairConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.btSairConsultaFun.Name = "btSairConsultaFun";
            this.btSairConsultaFun.Size = new System.Drawing.Size(127, 40);
            this.btSairConsultaFun.TabIndex = 32;
            this.btSairConsultaFun.Text = "Sair";
            this.btSairConsultaFun.UseVisualStyleBackColor = true;
            this.btSairConsultaFun.Click += new System.EventHandler(this.btSairConsultaFun_Click);
            // 
            // btExcluirConsultaFun
            // 
            this.btExcluirConsultaFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluirConsultaFun.BackgroundImage")));
            this.btExcluirConsultaFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluirConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirConsultaFun.ForeColor = System.Drawing.Color.White;
            this.btExcluirConsultaFun.Location = new System.Drawing.Point(590, 625);
            this.btExcluirConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluirConsultaFun.Name = "btExcluirConsultaFun";
            this.btExcluirConsultaFun.Size = new System.Drawing.Size(127, 40);
            this.btExcluirConsultaFun.TabIndex = 31;
            this.btExcluirConsultaFun.Text = "Deletar";
            this.btExcluirConsultaFun.UseVisualStyleBackColor = true;
            this.btExcluirConsultaFun.Click += new System.EventHandler(this.btExcluirConsultaFun_Click);
            // 
            // btEditarConsultaFun
            // 
            this.btEditarConsultaFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarConsultaFun.BackgroundImage")));
            this.btEditarConsultaFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditarConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarConsultaFun.ForeColor = System.Drawing.Color.White;
            this.btEditarConsultaFun.Location = new System.Drawing.Point(428, 625);
            this.btEditarConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.btEditarConsultaFun.Name = "btEditarConsultaFun";
            this.btEditarConsultaFun.Size = new System.Drawing.Size(127, 40);
            this.btEditarConsultaFun.TabIndex = 30;
            this.btEditarConsultaFun.Text = "Editar";
            this.btEditarConsultaFun.UseVisualStyleBackColor = true;
            this.btEditarConsultaFun.Click += new System.EventHandler(this.btEditarConsultaFun_Click);
            // 
            // btSalvarConsultaFun
            // 
            this.btSalvarConsultaFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvarConsultaFun.BackgroundImage")));
            this.btSalvarConsultaFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarConsultaFun.ForeColor = System.Drawing.Color.White;
            this.btSalvarConsultaFun.Location = new System.Drawing.Point(260, 625);
            this.btSalvarConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.btSalvarConsultaFun.Name = "btSalvarConsultaFun";
            this.btSalvarConsultaFun.Size = new System.Drawing.Size(127, 40);
            this.btSalvarConsultaFun.TabIndex = 29;
            this.btSalvarConsultaFun.Text = "Salvar";
            this.btSalvarConsultaFun.UseVisualStyleBackColor = true;
            this.btSalvarConsultaFun.Click += new System.EventHandler(this.btSalvarConsultaCli_Click);
            // 
            // btPesquisarConsultaFun
            // 
            this.btPesquisarConsultaFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesquisarConsultaFun.BackgroundImage")));
            this.btPesquisarConsultaFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisarConsultaFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisarConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarConsultaFun.ForeColor = System.Drawing.Color.White;
            this.btPesquisarConsultaFun.Location = new System.Drawing.Point(751, 118);
            this.btPesquisarConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisarConsultaFun.Name = "btPesquisarConsultaFun";
            this.btPesquisarConsultaFun.Size = new System.Drawing.Size(112, 60);
            this.btPesquisarConsultaFun.TabIndex = 33;
            this.btPesquisarConsultaFun.Text = "Pesquisar Funcionário";
            this.btPesquisarConsultaFun.UseVisualStyleBackColor = true;
            this.btPesquisarConsultaFun.Click += new System.EventHandler(this.btPesquisarConsultaFun_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1400, 3);
            this.tableLayoutPanel4.TabIndex = 67;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1400, 30);
            this.tableLayoutPanel3.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONSULTA FUNCIONÁRIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1400, 5);
            this.tableLayoutPanel2.TabIndex = 66;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 40);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // mkCpfConsultaFun
            // 
            this.mkCpfConsultaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCpfConsultaFun.Location = new System.Drawing.Point(376, 187);
            this.mkCpfConsultaFun.Margin = new System.Windows.Forms.Padding(4);
            this.mkCpfConsultaFun.Mask = "000,000,000-00";
            this.mkCpfConsultaFun.Name = "mkCpfConsultaFun";
            this.mkCpfConsultaFun.Size = new System.Drawing.Size(114, 24);
            this.mkCpfConsultaFun.TabIndex = 69;
            this.mkCpfConsultaFun.ValidatingType = typeof(System.DateTime);
            // 
            // frm_pesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mkCpfConsultaFun);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btPesquisarConsultaFun);
            this.Controls.Add(this.btSairConsultaFun);
            this.Controls.Add(this.btExcluirConsultaFun);
            this.Controls.Add(this.btEditarConsultaFun);
            this.Controls.Add(this.btSalvarConsultaFun);
            this.Controls.Add(this.txtCodigoConsultaFun);
            this.Controls.Add(this.lbCodigoConsultaFun);
            this.Controls.Add(this.mkNascimentoConsultaFun);
            this.Controls.Add(this.mkCepConsultaFun);
            this.Controls.Add(this.cbEstadoConsultaFun);
            this.Controls.Add(this.mkTelefoneConsultaFun);
            this.Controls.Add(this.mkCelularConsultaFun);
            this.Controls.Add(this.lbCpfConsultaFun);
            this.Controls.Add(this.lbCelularConsultaFun);
            this.Controls.Add(this.lbTelefoneConsultaFun);
            this.Controls.Add(this.lbEstadoConsultaFun);
            this.Controls.Add(this.lbCepConsultaFun);
            this.Controls.Add(this.txtCidadeConsultaFun);
            this.Controls.Add(this.lbCidadeConsultaFun);
            this.Controls.Add(this.txtBairroConsultaFun);
            this.Controls.Add(this.lbBairroConsultaFun);
            this.Controls.Add(this.txtComplementoConsultaFun);
            this.Controls.Add(this.lbComplementoConsultaFun);
            this.Controls.Add(this.txtEnderecoConsultaFun);
            this.Controls.Add(this.lbEnderecoConsultaFun);
            this.Controls.Add(this.lbNascimentoConsultaFun);
            this.Controls.Add(this.txtEmailConsultaFun);
            this.Controls.Add(this.lbEmailConsultaFun);
            this.Controls.Add(this.txtFuncaoConsultaFun);
            this.Controls.Add(this.lbFuncaoConsultaFun);
            this.Controls.Add(this.txtNomeConsultaFun);
            this.Controls.Add(this.lbNomeConsultaFun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_pesquisarFuncionario";
            this.Text = "frm_pesquisarFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_pesquisarFuncionario_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkNascimentoConsultaFun;
        private System.Windows.Forms.MaskedTextBox mkCepConsultaFun;
        private System.Windows.Forms.ComboBox cbEstadoConsultaFun;
        private System.Windows.Forms.MaskedTextBox mkTelefoneConsultaFun;
        private System.Windows.Forms.MaskedTextBox mkCelularConsultaFun;
        private System.Windows.Forms.Label lbCpfConsultaFun;
        private System.Windows.Forms.Label lbCelularConsultaFun;
        private System.Windows.Forms.Label lbTelefoneConsultaFun;
        private System.Windows.Forms.Label lbEstadoConsultaFun;
        private System.Windows.Forms.Label lbCepConsultaFun;
        private System.Windows.Forms.TextBox txtCidadeConsultaFun;
        private System.Windows.Forms.Label lbCidadeConsultaFun;
        private System.Windows.Forms.TextBox txtBairroConsultaFun;
        private System.Windows.Forms.Label lbBairroConsultaFun;
        private System.Windows.Forms.TextBox txtComplementoConsultaFun;
        private System.Windows.Forms.Label lbComplementoConsultaFun;
        private System.Windows.Forms.TextBox txtEnderecoConsultaFun;
        private System.Windows.Forms.Label lbEnderecoConsultaFun;
        private System.Windows.Forms.Label lbNascimentoConsultaFun;
        private System.Windows.Forms.TextBox txtEmailConsultaFun;
        private System.Windows.Forms.Label lbEmailConsultaFun;
        private System.Windows.Forms.TextBox txtFuncaoConsultaFun;
        private System.Windows.Forms.Label lbFuncaoConsultaFun;
        private System.Windows.Forms.TextBox txtNomeConsultaFun;
        private System.Windows.Forms.Label lbNomeConsultaFun;
        private System.Windows.Forms.TextBox txtCodigoConsultaFun;
        private System.Windows.Forms.Label lbCodigoConsultaFun;
        private System.Windows.Forms.Button btSairConsultaFun;
        private System.Windows.Forms.Button btExcluirConsultaFun;
        private System.Windows.Forms.Button btEditarConsultaFun;
        private System.Windows.Forms.Button btSalvarConsultaFun;
        private System.Windows.Forms.Button btPesquisarConsultaFun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkCpfConsultaFun;
    }
}