namespace Sistema_de_venda
{
    partial class frmConsultaVenda
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
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.pData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pCliente = new System.Windows.Forms.Panel();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcDados.SuspendLayout();
            this.tpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pData.SuspendLayout();
            this.pCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpVenda);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(8, 106);
            this.tbcDados.Margin = new System.Windows.Forms.Padding(2);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(566, 340);
            this.tbcDados.TabIndex = 24;
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.dgvDados);
            this.tpVenda.Location = new System.Drawing.Point(4, 22);
            this.tpVenda.Margin = new System.Windows.Forms.Padding(2);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(2);
            this.tpVenda.Size = new System.Drawing.Size(558, 314);
            this.tpVenda.TabIndex = 0;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(4, 4);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(551, 308);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Margin = new System.Windows.Forms.Padding(2);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(2);
            this.tpItens.Size = new System.Drawing.Size(558, 314);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da venda selecionada";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(4, 4);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(551, 308);
            this.dgvItens.TabIndex = 13;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(2);
            this.tpParcelas.Size = new System.Drawing.Size(558, 314);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da venda selecionada";
            this.tpParcelas.UseVisualStyleBackColor = true;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(4, 4);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(551, 308);
            this.dgvParcelas.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(560, 40);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo:";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(12, 15);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(2);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(112, 17);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(426, 15);
            this.rbParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(116, 17);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(285, 15);
            this.rbData.Margin = new System.Windows.Forms.Padding(2);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(101, 17);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da compra";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(165, 15);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // pData
            // 
            this.pData.Controls.Add(this.label2);
            this.pData.Controls.Add(this.dateTimePicker2);
            this.pData.Controls.Add(this.dateTimePicker1);
            this.pData.Controls.Add(this.btLocData);
            this.pData.Controls.Add(this.label3);
            this.pData.Location = new System.Drawing.Point(8, 55);
            this.pData.Margin = new System.Windows.Forms.Padding(2);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(560, 48);
            this.pData.TabIndex = 26;
            this.pData.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 24);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btLocData
            // 
            this.btLocData.Location = new System.Drawing.Point(406, 25);
            this.btLocData.Margin = new System.Windows.Forms.Padding(2);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(134, 19);
            this.btLocData.TabIndex = 2;
            this.btLocData.Text = "Localizar";
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicial";
            // 
            // pCliente
            // 
            this.pCliente.Controls.Add(this.lbCliNome);
            this.pCliente.Controls.Add(this.btLocCliente);
            this.pCliente.Controls.Add(this.txtCliCod);
            this.pCliente.Controls.Add(this.label1);
            this.pCliente.Location = new System.Drawing.Point(10, 55);
            this.pCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(560, 44);
            this.pCliente.TabIndex = 25;
            this.pCliente.Visible = false;
            this.pCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pCliente_Paint);
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Location = new System.Drawing.Point(123, 4);
            this.lbCliNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(87, 13);
            this.lbCliNome.TabIndex = 3;
            this.lbCliNome.Text = "Nome do cliente:";
            // 
            // btLocCliente
            // 
            this.btLocCliente.Location = new System.Drawing.Point(123, 20);
            this.btLocCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(134, 19);
            this.btLocCliente.TabIndex = 2;
            this.btLocCliente.Text = "Localizar Cliente";
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(12, 20);
            this.txtCliCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(108, 20);
            this.txtCliCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do cliente";
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            this.tbcDados.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label1;
    }
}