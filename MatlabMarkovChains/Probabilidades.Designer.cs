﻿
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
            this.gridProbabilidades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUGs = new System.Windows.Forms.ComboBox();
            this.gridProximosEstados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.numIteracoes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProbabilidades
            // 
            this.gridProbabilidades.AllowUserToAddRows = false;
            this.gridProbabilidades.AllowUserToDeleteRows = false;
            this.gridProbabilidades.AllowUserToOrderColumns = true;
            this.gridProbabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProbabilidades.Location = new System.Drawing.Point(12, 56);
            this.gridProbabilidades.Name = "gridProbabilidades";
            this.gridProbabilidades.Size = new System.Drawing.Size(776, 439);
            this.gridProbabilidades.TabIndex = 0;
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
            // gridProximosEstados
            // 
            this.gridProximosEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProximosEstados.Location = new System.Drawing.Point(805, 56);
            this.gridProximosEstados.Name = "gridProximosEstados";
            this.gridProximosEstados.Size = new System.Drawing.Size(278, 439);
            this.gridProximosEstados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Próximos Estados";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(613, 17);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(174, 32);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // numIteracoes
            // 
            this.numIteracoes.Location = new System.Drawing.Point(487, 29);
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
            this.label3.Location = new System.Drawing.Point(484, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Iterações";
            // 
            // btnInferencia
            // 
            this.btnInferencia.Location = new System.Drawing.Point(1008, 22);
            this.btnInferencia.Name = "btnInferencia";
            this.btnInferencia.Size = new System.Drawing.Size(75, 23);
            this.btnInferencia.TabIndex = 8;
            this.btnInferencia.Text = "Inferência";
            this.btnInferencia.UseVisualStyleBackColor = true;
            this.btnInferencia.Click += new System.EventHandler(this.btnInferencia_Click);
            // 
            // Probabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 505);
            this.Controls.Add(this.btnInferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numIteracoes);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridProximosEstados);
            this.Controls.Add(this.cmbUGs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProbabilidades);
            this.Name = "Probabilidades";
            this.Text = "Cadeias de Markov";
            this.Load += new System.EventHandler(this.Probabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProbabilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProximosEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteracoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProbabilidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUGs;
        private System.Windows.Forms.DataGridView gridProximosEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.NumericUpDown numIteracoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInferencia;
    }
}

