namespace agenSystem
{
    partial class relatorio_Agenda_Dia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorio_Agenda_Dia));
            this.dgvRelatorioAgendaDia = new System.Windows.Forms.DataGridView();
            this.btSairRelatorioAgendaDia = new System.Windows.Forms.Button();
            this.lbDataAgendamentoCliAgen = new System.Windows.Forms.Label();
            this.dtpDataAgendamentoRelatorioDia = new System.Windows.Forms.DateTimePicker();
            this.btVerificarAgendamento = new System.Windows.Forms.Button();
            this.btDeletarRelatorioAgendaDia = new System.Windows.Forms.Button();
            this.btConfirmacaoRelatorioAgendaDia = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAgendaDia)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelatorioAgendaDia
            // 
            this.dgvRelatorioAgendaDia.AllowUserToAddRows = false;
            this.dgvRelatorioAgendaDia.AllowUserToDeleteRows = false;
            this.dgvRelatorioAgendaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioAgendaDia.Location = new System.Drawing.Point(266, 182);
            this.dgvRelatorioAgendaDia.Name = "dgvRelatorioAgendaDia";
            this.dgvRelatorioAgendaDia.ReadOnly = true;
            this.dgvRelatorioAgendaDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorioAgendaDia.Size = new System.Drawing.Size(1053, 425);
            this.dgvRelatorioAgendaDia.TabIndex = 0;
            // 
            // btSairRelatorioAgendaDia
            // 
            this.btSairRelatorioAgendaDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairRelatorioAgendaDia.BackgroundImage")));
            this.btSairRelatorioAgendaDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairRelatorioAgendaDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSairRelatorioAgendaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairRelatorioAgendaDia.ForeColor = System.Drawing.Color.White;
            this.btSairRelatorioAgendaDia.Location = new System.Drawing.Point(1192, 630);
            this.btSairRelatorioAgendaDia.Name = "btSairRelatorioAgendaDia";
            this.btSairRelatorioAgendaDia.Size = new System.Drawing.Size(127, 40);
            this.btSairRelatorioAgendaDia.TabIndex = 5;
            this.btSairRelatorioAgendaDia.Text = "Sair";
            this.btSairRelatorioAgendaDia.UseVisualStyleBackColor = true;
            this.btSairRelatorioAgendaDia.Click += new System.EventHandler(this.btSairRelatorioAgendaDia_Click);
            // 
            // lbDataAgendamentoCliAgen
            // 
            this.lbDataAgendamentoCliAgen.AutoSize = true;
            this.lbDataAgendamentoCliAgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAgendamentoCliAgen.Location = new System.Drawing.Point(263, 131);
            this.lbDataAgendamentoCliAgen.Name = "lbDataAgendamentoCliAgen";
            this.lbDataAgendamentoCliAgen.Size = new System.Drawing.Size(134, 18);
            this.lbDataAgendamentoCliAgen.TabIndex = 36;
            this.lbDataAgendamentoCliAgen.Text = "Data Agendamento";
            // 
            // dtpDataAgendamentoRelatorioDia
            // 
            this.dtpDataAgendamentoRelatorioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAgendamentoRelatorioDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataAgendamentoRelatorioDia.Location = new System.Drawing.Point(266, 152);
            this.dtpDataAgendamentoRelatorioDia.Name = "dtpDataAgendamentoRelatorioDia";
            this.dtpDataAgendamentoRelatorioDia.Size = new System.Drawing.Size(127, 24);
            this.dtpDataAgendamentoRelatorioDia.TabIndex = 1;
            // 
            // btVerificarAgendamento
            // 
            this.btVerificarAgendamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVerificarAgendamento.BackgroundImage")));
            this.btVerificarAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVerificarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVerificarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificarAgendamento.ForeColor = System.Drawing.Color.White;
            this.btVerificarAgendamento.Location = new System.Drawing.Point(425, 136);
            this.btVerificarAgendamento.Name = "btVerificarAgendamento";
            this.btVerificarAgendamento.Size = new System.Drawing.Size(149, 40);
            this.btVerificarAgendamento.TabIndex = 2;
            this.btVerificarAgendamento.Text = "Verificar Agenda";
            this.btVerificarAgendamento.UseVisualStyleBackColor = true;
            this.btVerificarAgendamento.Click += new System.EventHandler(this.btVerificarAgendamento_Click);
            // 
            // btDeletarRelatorioAgendaDia
            // 
            this.btDeletarRelatorioAgendaDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeletarRelatorioAgendaDia.BackgroundImage")));
            this.btDeletarRelatorioAgendaDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDeletarRelatorioAgendaDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeletarRelatorioAgendaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarRelatorioAgendaDia.ForeColor = System.Drawing.Color.White;
            this.btDeletarRelatorioAgendaDia.Location = new System.Drawing.Point(1034, 630);
            this.btDeletarRelatorioAgendaDia.Name = "btDeletarRelatorioAgendaDia";
            this.btDeletarRelatorioAgendaDia.Size = new System.Drawing.Size(127, 40);
            this.btDeletarRelatorioAgendaDia.TabIndex = 4;
            this.btDeletarRelatorioAgendaDia.Text = "Deletar";
            this.btDeletarRelatorioAgendaDia.UseVisualStyleBackColor = true;
            this.btDeletarRelatorioAgendaDia.Click += new System.EventHandler(this.btDeletarRelatorioAgendaDia_Click);
            // 
            // btConfirmacaoRelatorioAgendaDia
            // 
            this.btConfirmacaoRelatorioAgendaDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConfirmacaoRelatorioAgendaDia.BackgroundImage")));
            this.btConfirmacaoRelatorioAgendaDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmacaoRelatorioAgendaDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConfirmacaoRelatorioAgendaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmacaoRelatorioAgendaDia.ForeColor = System.Drawing.Color.White;
            this.btConfirmacaoRelatorioAgendaDia.Location = new System.Drawing.Point(836, 630);
            this.btConfirmacaoRelatorioAgendaDia.Name = "btConfirmacaoRelatorioAgendaDia";
            this.btConfirmacaoRelatorioAgendaDia.Size = new System.Drawing.Size(167, 40);
            this.btConfirmacaoRelatorioAgendaDia.TabIndex = 3;
            this.btConfirmacaoRelatorioAgendaDia.Text = "Enviar Confirmação";
            this.btConfirmacaoRelatorioAgendaDia.UseVisualStyleBackColor = true;
            this.btConfirmacaoRelatorioAgendaDia.Click += new System.EventHandler(this.btConfirmacaoRelatorioAgendaDia_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1400, 3);
            this.tableLayoutPanel4.TabIndex = 75;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1400, 30);
            this.tableLayoutPanel3.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONFIRMAR AGENDAMENTO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1400, 5);
            this.tableLayoutPanel2.TabIndex = 74;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 40);
            this.tableLayoutPanel1.TabIndex = 73;
            // 
            // relatorio_Agenda_Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btConfirmacaoRelatorioAgendaDia);
            this.Controls.Add(this.btDeletarRelatorioAgendaDia);
            this.Controls.Add(this.btVerificarAgendamento);
            this.Controls.Add(this.lbDataAgendamentoCliAgen);
            this.Controls.Add(this.dtpDataAgendamentoRelatorioDia);
            this.Controls.Add(this.btSairRelatorioAgendaDia);
            this.Controls.Add(this.dgvRelatorioAgendaDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "relatorio_Agenda_Dia";
            this.Text = "Agenda do Dia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.relatorio_Agenda_Dia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAgendaDia)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorioAgendaDia;
        private System.Windows.Forms.Button btSairRelatorioAgendaDia;
        private System.Windows.Forms.Label lbDataAgendamentoCliAgen;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamentoRelatorioDia;
        private System.Windows.Forms.Button btVerificarAgendamento;
        private System.Windows.Forms.Button btDeletarRelatorioAgendaDia;
        private System.Windows.Forms.Button btConfirmacaoRelatorioAgendaDia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}