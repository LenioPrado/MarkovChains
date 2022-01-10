
namespace MatlabMarkovChains
{
    partial class Probabilidades
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
            this.cmbUGs = new System.Windows.Forms.ComboBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.numIteracoes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInferencia = new System.Windows.Forms.Button();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProbabilidades = new System.Windows.Forms.TabPage();
            this.tabProximosEstados = new System.Windows.Forms.TabPage();
            this.gridProbabilidades = new System.Windows.Forms.DataGridView();
            this.gridProximosEstados = new System.Windows.Forms.DataGridView();
            this.tabDistribuicaoUniforme = new System.Windows.Forms.TabPage();
            this.tabDistribuicaoEstacionaria = new System.Windows.Forms.TabPage();
            this.gridDistribuicaoUniforme = new System.Windows.Forms.DataGridView();
            this.gridDistribuicaoEstacionaria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabProbabilidades.SuspendLayout();
            this.tabProximosEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).BeginInit();
            this.tabDistribuicaoUniforme.SuspendLayout();
            this.tabDistribuicaoEstacionaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoEstacionaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidades Geradoras";
            // 
            // cmbUGs
            // 
            this.cmbUGs.FormattingEnabled = true;
            this.cmbUGs.Location = new System.Drawing.Point(12, 29);
            this.cmbUGs.Name = "cmbUGs";
            this.cmbUGs.Size = new System.Drawing.Size(198, 21);
            this.cmbUGs.TabIndex = 2;
            this.cmbUGs.SelectedIndexChanged += new System.EventHandler(this.cmbUGs_SelectedIndexChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(522, 17);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(174, 32);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // numIteracoes
            // 
            this.numIteracoes.Location = new System.Drawing.Point(269, 29);
            this.numIteracoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIteracoes.Name = "numIteracoes";
            this.numIteracoes.Size = new System.Drawing.Size(120, 20);
            this.numIteracoes.TabIndex = 6;
            this.numIteracoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Iterações";
            // 
            // btnInferencia
            // 
            this.btnInferencia.Location = new System.Drawing.Point(993, 17);
            this.btnInferencia.Name = "btnInferencia";
            this.btnInferencia.Size = new System.Drawing.Size(174, 32);
            this.btnInferencia.TabIndex = 8;
            this.btnInferencia.Text = "Inferência";
            this.btnInferencia.UseVisualStyleBackColor = true;
            this.btnInferencia.Visible = false;
            this.btnInferencia.Click += new System.EventHandler(this.btnInferencia_Click);
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(395, 28);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado Inicial:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabProbabilidades);
            this.tabControl.Controls.Add(this.tabProximosEstados);
            this.tabControl.Controls.Add(this.tabDistribuicaoUniforme);
            this.tabControl.Controls.Add(this.tabDistribuicaoEstacionaria);
            this.tabControl.Location = new System.Drawing.Point(12, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1159, 481);
            this.tabControl.TabIndex = 20;
            // 
            // tabProbabilidades
            // 
            this.tabProbabilidades.Controls.Add(this.gridProbabilidades);
            this.tabProbabilidades.Location = new System.Drawing.Point(4, 22);
            this.tabProbabilidades.Name = "tabProbabilidades";
            this.tabProbabilidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabProbabilidades.Size = new System.Drawing.Size(1151, 455);
            this.tabProbabilidades.TabIndex = 0;
            this.tabProbabilidades.Text = "Matrix Probabilidades";
            this.tabProbabilidades.UseVisualStyleBackColor = true;
            // 
            // tabProximosEstados
            // 
            this.tabProximosEstados.Controls.Add(this.gridProximosEstados);
            this.tabProximosEstados.Location = new System.Drawing.Point(4, 22);
            this.tabProximosEstados.Name = "tabProximosEstados";
            this.tabProximosEstados.Padding = new System.Windows.Forms.Padding(3);
            this.tabProximosEstados.Size = new System.Drawing.Size(1151, 455);
            this.tabProximosEstados.TabIndex = 1;
            this.tabProximosEstados.Text = "Próximos Estados";
            this.tabProximosEstados.UseVisualStyleBackColor = true;
            // 
            // gridProbabilidades
            // 
            this.gridProbabilidades.AllowUserToAddRows = false;
            this.gridProbabilidades.AllowUserToDeleteRows = false;
            this.gridProbabilidades.AllowUserToOrderColumns = true;
            this.gridProbabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProbabilidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProbabilidades.Location = new System.Drawing.Point(3, 3);
            this.gridProbabilidades.Name = "gridProbabilidades";
            this.gridProbabilidades.Size = new System.Drawing.Size(1145, 449);
            this.gridProbabilidades.TabIndex = 13;
            // 
            // gridProximosEstados
            // 
            this.gridProximosEstados.AllowUserToAddRows = false;
            this.gridProximosEstados.AllowUserToDeleteRows = false;
            this.gridProximosEstados.AllowUserToResizeRows = false;
            this.gridProximosEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProximosEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProximosEstados.Location = new System.Drawing.Point(3, 3);
            this.gridProximosEstados.Name = "gridProximosEstados";
            this.gridProximosEstados.ShowEditingIcon = false;
            this.gridProximosEstados.Size = new System.Drawing.Size(1145, 449);
            this.gridProximosEstados.TabIndex = 5;
            // 
            // tabDistribuicaoUniforme
            // 
            this.tabDistribuicaoUniforme.Controls.Add(this.gridDistribuicaoUniforme);
            this.tabDistribuicaoUniforme.Location = new System.Drawing.Point(4, 22);
            this.tabDistribuicaoUniforme.Name = "tabDistribuicaoUniforme";
            this.tabDistribuicaoUniforme.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistribuicaoUniforme.Size = new System.Drawing.Size(1151, 455);
            this.tabDistribuicaoUniforme.TabIndex = 2;
            this.tabDistribuicaoUniforme.Text = "Dist. Uniforme";
            this.tabDistribuicaoUniforme.UseVisualStyleBackColor = true;
            // 
            // tabDistribuicaoEstacionaria
            // 
            this.tabDistribuicaoEstacionaria.Controls.Add(this.gridDistribuicaoEstacionaria);
            this.tabDistribuicaoEstacionaria.Location = new System.Drawing.Point(4, 22);
            this.tabDistribuicaoEstacionaria.Name = "tabDistribuicaoEstacionaria";
            this.tabDistribuicaoEstacionaria.Size = new System.Drawing.Size(1151, 455);
            this.tabDistribuicaoEstacionaria.TabIndex = 3;
            this.tabDistribuicaoEstacionaria.Text = "Dist. Estacionária";
            this.tabDistribuicaoEstacionaria.UseVisualStyleBackColor = true;
            // 
            // gridDistribuicaoUniforme
            // 
            this.gridDistribuicaoUniforme.AllowUserToAddRows = false;
            this.gridDistribuicaoUniforme.AllowUserToDeleteRows = false;
            this.gridDistribuicaoUniforme.AllowUserToOrderColumns = true;
            this.gridDistribuicaoUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribuicaoUniforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDistribuicaoUniforme.Location = new System.Drawing.Point(3, 3);
            this.gridDistribuicaoUniforme.Name = "gridDistribuicaoUniforme";
            this.gridDistribuicaoUniforme.Size = new System.Drawing.Size(1145, 449);
            this.gridDistribuicaoUniforme.TabIndex = 11;
            // 
            // gridDistribuicaoEstacionaria
            // 
            this.gridDistribuicaoEstacionaria.AllowUserToAddRows = false;
            this.gridDistribuicaoEstacionaria.AllowUserToDeleteRows = false;
            this.gridDistribuicaoEstacionaria.AllowUserToOrderColumns = true;
            this.gridDistribuicaoEstacionaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribuicaoEstacionaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDistribuicaoEstacionaria.Location = new System.Drawing.Point(0, 0);
            this.gridDistribuicaoEstacionaria.Name = "gridDistribuicaoEstacionaria";
            this.gridDistribuicaoEstacionaria.Size = new System.Drawing.Size(1151, 455);
            this.gridDistribuicaoEstacionaria.TabIndex = 20;
            // 
            // Probabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1183, 549);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.btnInferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numIteracoes);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.cmbUGs);
            this.Controls.Add(this.label1);
            this.Name = "Probabilidades";
            this.Text = "Cadeias de Markov";
            this.Load += new System.EventHandler(this.Probabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabProbabilidades.ResumeLayout(false);
            this.tabProximosEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).EndInit();
            this.tabDistribuicaoUniforme.ResumeLayout(false);
            this.tabDistribuicaoEstacionaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoEstacionaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUGs;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.NumericUpDown numIteracoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInferencia;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProbabilidades;
        private System.Windows.Forms.DataGridView gridProbabilidades;
        private System.Windows.Forms.TabPage tabProximosEstados;
        private System.Windows.Forms.DataGridView gridProximosEstados;
        private System.Windows.Forms.TabPage tabDistribuicaoUniforme;
        private System.Windows.Forms.DataGridView gridDistribuicaoUniforme;
        private System.Windows.Forms.TabPage tabDistribuicaoEstacionaria;
        private System.Windows.Forms.DataGridView gridDistribuicaoEstacionaria;
    }
}

