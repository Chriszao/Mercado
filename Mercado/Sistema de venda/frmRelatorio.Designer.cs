namespace Sistema_de_venda
{
    partial class frmRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ModeloProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Sistema_de_venda.DataSet1();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Sistema_de_venda.DataSet1TableAdapters.produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ModeloProdutoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.produtoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_venda.frmRelatorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(782, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // ModeloProdutoBindingSource
            // 
            this.ModeloProdutoBindingSource.DataSource = typeof(Modelo.ModeloProduto);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.DataSet1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ModeloProdutoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.produtoTableAdapter produtoTableAdapter;
    }
}