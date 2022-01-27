
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
            this.gridProbabilidades = new System.Windows.Forms.DataGridView();
            this.tabProximosEstados = new System.Windows.Forms.TabPage();
            this.gridProximosEstados = new System.Windows.Forms.DataGridView();
            this.tabDistribuicaoUniforme = new System.Windows.Forms.TabPage();
            this.gridDistribuicaoUniforme = new System.Windows.Forms.DataGridView();
            this.tabDistribuicaoEstacionaria = new System.Windows.Forms.TabPage();
            this.gridDistribuicaoEstacionaria = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabProbabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).BeginInit();
            this.tabProximosEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).BeginInit();
            this.tabDistribuicaoUniforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoUniforme)).BeginInit();
            this.tabDistribuicaoEstacionaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoEstacionaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidades Geradoras";
            // 
            // cmbUGs
            // 
            this.cmbUGs.FormattingEnabled = true;
            this.cmbUGs.Location = new System.Drawing.Point(14, 33);
            this.cmbUGs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUGs.Name = "cmbUGs";
            this.cmbUGs.Size = new System.Drawing.Size(230, 23);
            this.cmbUGs.TabIndex = 2;
            this.cmbUGs.SelectedIndexChanged += new System.EventHandler(this.cmbUGs_SelectedIndexChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(609, 20);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(203, 37);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // numIteracoes
            // 
            this.numIteracoes.Location = new System.Drawing.Point(314, 33);
            this.numIteracoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numIteracoes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIteracoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIteracoes.Name = "numIteracoes";
            this.numIteracoes.Size = new System.Drawing.Size(140, 23);
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
            this.label3.Location = new System.Drawing.Point(310, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Iterações";
            // 
            // btnInferencia
            // 
            this.btnInferencia.Location = new System.Drawing.Point(1158, 20);
            this.btnInferencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInferencia.Name = "btnInferencia";
            this.btnInferencia.Size = new System.Drawing.Size(203, 37);
            this.btnInferencia.TabIndex = 8;
            this.btnInferencia.Text = "Inferência";
            this.btnInferencia.UseVisualStyleBackColor = true;
            this.btnInferencia.Visible = false;
            this.btnInferencia.Click += new System.EventHandler(this.btnInferencia_Click);
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(461, 32);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(140, 23);
            this.cmbEstados.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
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
            this.tabControl.Location = new System.Drawing.Point(14, 65);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1352, 555);
            this.tabControl.TabIndex = 20;
            // 
            // tabProbabilidades
            // 
            this.tabProbabilidades.Controls.Add(this.gridProbabilidades);
            this.tabProbabilidades.Location = new System.Drawing.Point(4, 24);
            this.tabProbabilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProbabilidades.Name = "tabProbabilidades";
            this.tabProbabilidades.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProbabilidades.Size = new System.Drawing.Size(1344, 527);
            this.tabProbabilidades.TabIndex = 0;
            this.tabProbabilidades.Text = "Matrix Probabilidades";
            this.tabProbabilidades.UseVisualStyleBackColor = true;
            // 
            // gridProbabilidades
            // 
            this.gridProbabilidades.AllowUserToAddRows = false;
            this.gridProbabilidades.AllowUserToDeleteRows = false;
            this.gridProbabilidades.AllowUserToOrderColumns = true;
            this.gridProbabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProbabilidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProbabilidades.Location = new System.Drawing.Point(4, 3);
            this.gridProbabilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridProbabilidades.Name = "gridProbabilidades";
            this.gridProbabilidades.Size = new System.Drawing.Size(1336, 521);
            this.gridProbabilidades.TabIndex = 13;
            // 
            // tabProximosEstados
            // 
            this.tabProximosEstados.Controls.Add(this.gridProximosEstados);
            this.tabProximosEstados.Location = new System.Drawing.Point(4, 24);
            this.tabProximosEstados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProximosEstados.Name = "tabProximosEstados";
            this.tabProximosEstados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProximosEstados.Size = new System.Drawing.Size(1344, 527);
            this.tabProximosEstados.TabIndex = 1;
            this.tabProximosEstados.Text = "Próximos Estados";
            this.tabProximosEstados.UseVisualStyleBackColor = true;
            // 
            // gridProximosEstados
            // 
            this.gridProximosEstados.AllowUserToAddRows = false;
            this.gridProximosEstados.AllowUserToDeleteRows = false;
            this.gridProximosEstados.AllowUserToResizeRows = false;
            this.gridProximosEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProximosEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProximosEstados.Location = new System.Drawing.Point(4, 3);
            this.gridProximosEstados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridProximosEstados.Name = "gridProximosEstados";
            this.gridProximosEstados.ShowEditingIcon = false;
            this.gridProximosEstados.Size = new System.Drawing.Size(1336, 521);
            this.gridProximosEstados.TabIndex = 5;
            // 
            // tabDistribuicaoUniforme
            // 
            this.tabDistribuicaoUniforme.Controls.Add(this.gridDistribuicaoUniforme);
            this.tabDistribuicaoUniforme.Location = new System.Drawing.Point(4, 24);
            this.tabDistribuicaoUniforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDistribuicaoUniforme.Name = "tabDistribuicaoUniforme";
            this.tabDistribuicaoUniforme.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDistribuicaoUniforme.Size = new System.Drawing.Size(1344, 527);
            this.tabDistribuicaoUniforme.TabIndex = 2;
            this.tabDistribuicaoUniforme.Text = "Dist. Uniforme";
            this.tabDistribuicaoUniforme.UseVisualStyleBackColor = true;
            // 
            // gridDistribuicaoUniforme
            // 
            this.gridDistribuicaoUniforme.AllowUserToAddRows = false;
            this.gridDistribuicaoUniforme.AllowUserToDeleteRows = false;
            this.gridDistribuicaoUniforme.AllowUserToOrderColumns = true;
            this.gridDistribuicaoUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribuicaoUniforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDistribuicaoUniforme.Location = new System.Drawing.Point(4, 3);
            this.gridDistribuicaoUniforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridDistribuicaoUniforme.Name = "gridDistribuicaoUniforme";
            this.gridDistribuicaoUniforme.Size = new System.Drawing.Size(1336, 521);
            this.gridDistribuicaoUniforme.TabIndex = 11;
            // 
            // tabDistribuicaoEstacionaria
            // 
            this.tabDistribuicaoEstacionaria.Controls.Add(this.gridDistribuicaoEstacionaria);
            this.tabDistribuicaoEstacionaria.Location = new System.Drawing.Point(4, 24);
            this.tabDistribuicaoEstacionaria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDistribuicaoEstacionaria.Name = "tabDistribuicaoEstacionaria";
            this.tabDistribuicaoEstacionaria.Size = new System.Drawing.Size(1344, 527);
            this.tabDistribuicaoEstacionaria.TabIndex = 3;
            this.tabDistribuicaoEstacionaria.Text = "Dist. Estacionária";
            this.tabDistribuicaoEstacionaria.UseVisualStyleBackColor = true;
            // 
            // gridDistribuicaoEstacionaria
            // 
            this.gridDistribuicaoEstacionaria.AllowUserToAddRows = false;
            this.gridDistribuicaoEstacionaria.AllowUserToDeleteRows = false;
            this.gridDistribuicaoEstacionaria.AllowUserToOrderColumns = true;
            this.gridDistribuicaoEstacionaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribuicaoEstacionaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDistribuicaoEstacionaria.Location = new System.Drawing.Point(0, 0);
            this.gridDistribuicaoEstacionaria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridDistribuicaoEstacionaria.Name = "gridDistribuicaoEstacionaria";
            this.gridDistribuicaoEstacionaria.Size = new System.Drawing.Size(1344, 527);
            this.gridDistribuicaoEstacionaria.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(828, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 37);
            this.lblStatus.TabIndex = 21;
            // 
            // Probabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1380, 633);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.btnInferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numIteracoes);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.cmbUGs);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Probabilidades";
            this.Text = "Cadeias de Markov";
            this.Shown += new System.EventHandler(this.Probabilidades_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabProbabilidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).EndInit();
            this.tabProximosEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).EndInit();
            this.tabDistribuicaoUniforme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuicaoUniforme)).EndInit();
            this.tabDistribuicaoEstacionaria.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblStatus;
    }
}

