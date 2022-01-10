using Common;
using Common.Helpers;
using Common.Model;
using MarkovChains.Inferencia;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MatlabMarkovChains
{
    public partial class Probabilidades : Form
    {
        private IEnumerable<DadosUG> _dadosUGsEstados;
        private IEnumerable<string> _UGs;
        private IEnumerable<string> _estados;
        private double[,] _matrizProbabilidades;
        private readonly AppLogger _appLogger;

        public Probabilidades(ILogger<Probabilidades> logger)
        {            
            _appLogger = new AppLogger(logger, "_logProjeto.log");
            ShowResultsHelper.SetAppLogger(_appLogger);
            InitializeComponent();
            ObterDadosUGs();            
        }

        private void ObterDadosUGs()
        {
            var estados = LerArquivoExcel.LerArquivo();

            EstadosPorUnidade estadosPorUnidade = new EstadosPorUnidade(estados);
            _dadosUGsEstados = estadosPorUnidade.ObterDadosUGsPorEstados();
            _UGs = _dadosUGsEstados.Select(c => c.UG).Distinct().OrderBy(c => c);
            _estados = _dadosUGsEstados.SelectMany(c => c.Estados).Select(c => c.Sigla).Distinct().OrderBy(c => c);

            estadosPorUnidade.ExibirResultados();

            _matrizProbabilidades = new double[_estados.Count(), _estados.Count()];
        }

        private void Probabilidades_Load(object sender, EventArgs e)
        {
            PreencherComboUGs();
            PreencherComboEstados();
            PreencherCabecalhosGridView(gridProbabilidades);
            PreencherCabecalhosGridView(gridDistribuicaoUniforme);
            PreencherCabecalhosGridView(gridDistribuicaoEstacionaria);
            PreencherGridViewDadosProbabilidadesUG();
        }

        private void cmbUGs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherGridViewDadosProbabilidadesUG();
            PreencherResultadoCadeiaMarkov(null);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var cadeiaMarkov = InterpretadorMatlab.ExecutarMatlab(_matrizProbabilidades, _estados, (int) numIteracoes.Value, cmbEstados.SelectedIndex + 1);

            PreencherResultadoCadeiaMarkov(cadeiaMarkov);            
        }

        private void btnInferencia_Click(object sender, EventArgs e)
        {
            ExecutorInferencia.RodarInferencia(_dadosUGsEstados);
        }


        private void PreencherResultadoCadeiaMarkov(CadeiaMarkov cadeiaMarkov)
        {
            gridProximosEstados.Rows.Clear();
            gridProximosEstados.Columns.Clear();

            gridDistribuicaoUniforme.Rows.Clear();
            gridDistribuicaoEstacionaria.Rows.Clear();

            if (cadeiaMarkov != null)
            {
                ProximosEstados(cadeiaMarkov);
                PreencherDistribuicao(cadeiaMarkov.DistribuicaoUniforme, gridDistribuicaoUniforme);
                PreencherDistribuicao(cadeiaMarkov.DistribuicaoEstacionaria, gridDistribuicaoEstacionaria);
            }
        }

        private void ProximosEstados(CadeiaMarkov cadeiaMarkov)
        {
            for (int index = 0; index < cadeiaMarkov.Simulacao.GetLength(1); index++)
            {
                gridProximosEstados.Columns.Add($"{index}", $"{index}");
            }

            for (int index = 0; index < cadeiaMarkov.Simulacao.GetLength(0); index++)
            {
                var valorLinha = ObterValorLinhaArray(cadeiaMarkov.Simulacao, index);
                var valorLinha1 = valorLinha.Select(c => _estados.ElementAt((int)c - 1)).ToArray();

                gridProximosEstados.Rows.Add(valorLinha1);
                gridProximosEstados.Rows[index].HeaderCell.Value = $"{index}";
            }
            InscreverEventoRemoverSetaGridView(gridProximosEstados);
        }

        private void PreencherDistribuicao(double[,] distribuicao, DataGridView gridView)
        {
            for (int index = 0; index < distribuicao.GetLength(0); index++)
            {
                var valorLinha = ObterValorLinhaArray(distribuicao, index);
                var valorLinha1 = valorLinha.Select(c => c as object).ToArray();

                double max1 = ObterIndiceDoXMaiorValor(valorLinha, 1);
                int maxIndex1 = valorLinha.ToList().IndexOf(max1);

                double max2 = ObterIndiceDoXMaiorValor(valorLinha, 2);
                int maxIndex2 = valorLinha.ToList().IndexOf(max2);

                double max3 = ObterIndiceDoXMaiorValor(valorLinha, 3);
                int maxIndex3 = valorLinha.ToList().IndexOf(max3);

                gridView.Rows.Add(valorLinha1);
                gridView.Rows[index].HeaderCell.Value = $"{index}";

                PintarCelula(gridView.Rows[index].Cells[maxIndex1], 1);
                PintarCelula(gridView.Rows[index].Cells[maxIndex2], 2);
                PintarCelula(gridView.Rows[index].Cells[maxIndex3], 3);
            }

            InscreverEventoRemoverSetaGridView(gridView);
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private double ObterIndiceDoXMaiorValor(double[] valores, int posicao)
        {
            return valores.OrderByDescending(c => c).ElementAt(posicao - 1);
        }

        private double[] ObterValorLinhaArray(double[,] array, int linha)
        {
            return Enumerable.Range(0, array.GetLength(1))
                            .Select(x => Math.Round(array[linha, x], 3))
                            .ToArray();
        }        

        private void PreencherComboUGs()
        {
            foreach (var ug in _UGs)
            {
                cmbUGs.Items.Add(ug);
            }

            if (cmbUGs.Items.Count > 0)
                cmbUGs.SelectedIndex = 0;
        }

        private void PreencherComboEstados()
        {
            foreach (var estado in _estados)
            {
                cmbEstados.Items.Add(estado);
            }

            if (cmbEstados.Items.Count > 0)
                cmbEstados.SelectedIndex = 0;
        }

        private void PreencherCabecalhosGridView(DataGridView gridView, bool redimensionarColunas = true)
        {
            // Inserir nomes de colunas e linhas
            for (int index = 0; index < _estados.Count(); index++)
            {
                string estado = _estados.ElementAt(index);
                gridView.Columns.Add(estado, estado);
                gridView.Columns[estado].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridView.Rows.Add();
                gridView.Rows[index].HeaderCell.Value = estado;
            }
                        
            gridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader);

            if (redimensionarColunas)
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PreencherGridViewDadosProbabilidadesUG()
        {
            if (cmbUGs.Items.Count > 0)
            {
                // Preencher com os percentuais
                string selectedUG = cmbUGs.SelectedItem.ToString();

                for (int rowIndex = 0; rowIndex < gridProbabilidades.RowCount; rowIndex++)
                {
                    string estadoOrigem = _estados.ElementAt(rowIndex);
                    for (int colIndex = 0; colIndex < gridProbabilidades.ColumnCount; colIndex++)
                    {                        
                        string estadoDestino = _estados.ElementAt(colIndex);

                        var dadosOrigensDestinos = _dadosUGsEstados.Where(c => c.UG.Equals(selectedUG)).Select(c => c.ObterDadosOrigemDestino(estadoOrigem, estadoDestino));

                        if (dadosOrigensDestinos.Count() > 0)
                        {
                            DadosOrigemDestino dadosOrigemDestino = dadosOrigensDestinos.FirstOrDefault();
                            gridProbabilidades.Rows[rowIndex].Cells[colIndex].Value = dadosOrigemDestino.PercentualFormatado;
                            _matrizProbabilidades[rowIndex,colIndex] = dadosOrigemDestino.Percentual;
                        }
                    }
                }
            }
        }
        
        private void PintarCelula(DataGridViewCell cell, int posicao = -1)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            if (posicao <= 1)
            {
                style.BackColor = Color.Green;
            }
            else if (posicao == 2)
            {
                style.BackColor = Color.Yellow;
            }
            else
            {
                style.BackColor = Color.Red;
            }
            
            cell.Style = style;
        }

        private void InscreverEventoRemoverSetaGridView(DataGridView gridView)
        {
            gridView.RowHeadersDefaultCellStyle.Padding = new Padding(gridView.RowHeadersWidth);

            if (Convert.ToBoolean(gridView.Tag) == true)
                gridView.RowPostPaint -= new DataGridViewRowPostPaintEventHandler(DataGridView_RowPostPaint);

            gridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(DataGridView_RowPostPaint);
            gridView.Tag = true;
        }

        private void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Remover seta do cabeçalho da linha
            DataGridView gridView = sender as DataGridView;
            object o = gridView.Rows[e.RowIndex].HeaderCell.Value;

            e.Graphics.DrawString(
                o != null ? o.ToString() : "",
                gridView.Font,
                new SolidBrush(gridView.RowHeadersDefaultCellStyle.ForeColor),
                new PointF((float)e.RowBounds.Left + 2, (float)e.RowBounds.Top + 4));
        }
    }
}
