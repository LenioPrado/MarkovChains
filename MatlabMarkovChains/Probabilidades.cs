using Common;
using Common.Helpers;
using Common.Model;
using MarkovChains.Inferencia;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
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
        private double[][] _matrizProbabilidades;
        private readonly AppLogger _appLogger;
        private readonly string SCRIPT_FULL_PATH = @"D:\Develop\AspNetCore\Markov Chains\Common\Scripts\ExecutarCadeiasMarkov.m";

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

            _matrizProbabilidades = new double[_estados.Count()][];
        }

        private void Probabilidades_Load(object sender, EventArgs e)
        {
            PreencherComboUGs();
            PreencherCabecalhosGridView();
            PreencherDadosGridView();
        }

        private void cmbUGs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDadosGridView();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            InterpretadorOctave interpretador = new InterpretadorOctave(SCRIPT_FULL_PATH, _appLogger);

            string scriptPath = Path.GetDirectoryName(SCRIPT_FULL_PATH);

            interpretador.AdicionarParametro("ScriptsPath", scriptPath);
            interpretador.AdicionarParametro("matriz", _matrizProbabilidades);
            interpretador.AdicionarParametro("estados", _estados.ToArray());
            interpretador.AdicionarParametro("iteracoes", Convert.ToDouble(numIteracoes.Value));

            interpretador.Executar();
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

        private void PreencherCabecalhosGridView()
        {
            // Inserir nomes de colunas e linhas
            for (int index = 0; index < _estados.Count(); index++)
            {
                string estado = _estados.ElementAt(index);
                gridProbabilidades.Columns.Add(estado, estado);
                gridProbabilidades.Columns[estado].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridProbabilidades.Rows.Add();
                gridProbabilidades.Rows[index].HeaderCell.Value = estado;
            }

            gridProbabilidades.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader);
            gridProbabilidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PreencherDadosGridView()
        {
            if (cmbUGs.Items.Count > 0)
            {
                // Preencher com os percentuais
                string selectedUG = cmbUGs.SelectedItem.ToString();

                for (int rowIndex = 0; rowIndex < gridProbabilidades.RowCount; rowIndex++)
                {
                    _matrizProbabilidades[rowIndex] = new double[_estados.Count()];
                    string estadoOrigem = _estados.ElementAt(rowIndex);
                    for (int colIndex = 0; colIndex < gridProbabilidades.ColumnCount; colIndex++)
                    {                        
                        string estadoDestino = _estados.ElementAt(colIndex);

                        var dadosOrigensDestinos = _dadosUGsEstados.Where(c => c.UG.Equals(selectedUG)).Select(c => c.ObterDadosOrigemDestino(estadoOrigem, estadoDestino));

                        if (dadosOrigensDestinos.Count() > 0)
                        {
                            DadosOrigemDestino dadosOrigemDestino = dadosOrigensDestinos.FirstOrDefault();
                            gridProbabilidades.Rows[rowIndex].Cells[colIndex].Value = dadosOrigemDestino.PercentualFormatado;
                            _matrizProbabilidades[rowIndex][colIndex] = dadosOrigemDestino.Percentual;
                        }
                    }
                }
            }
        }

        private void btnInferencia_Click(object sender, EventArgs e)
        {
            ExecutorInferencia.RodarInferencia(_dadosUGsEstados);
        }
    }
}
