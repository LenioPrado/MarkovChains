using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatlabMarkovChains
{
    public partial class Probabilidades : Form
    {
        private IEnumerable<DadosUG> _dadosUGsEstados;
        private IEnumerable<string> _UGs;
        private IEnumerable<string> _estados;

        public Probabilidades()
        {
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
        }

        private void Probabilidades_Load(object sender, EventArgs e)
        {
            PreencherComboUGs();
            PreencherGridView();
            PreencherDadosGridView();
        }

        private void cmbUGs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDadosGridView();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

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

        private void PreencherGridView()
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
                    string estadoOrigem = _estados.ElementAt(rowIndex);
                    for (int colIndex = 0; colIndex < gridProbabilidades.ColumnCount; colIndex++)
                    {
                        string estadoDestino = _estados.ElementAt(colIndex);

                        var dadosOrigensDestinos = _dadosUGsEstados.Where(c => c.UG.Equals(selectedUG)).Select(c => c.ObterDadosOrigemDestino(estadoOrigem, estadoDestino));

                        if (dadosOrigensDestinos.Count() > 0)
                        {
                            DadosOrigemDestino dadosOrigemDestino = dadosOrigensDestinos.FirstOrDefault();
                            gridProbabilidades.Rows[rowIndex].Cells[colIndex].Value = dadosOrigemDestino.PercentualFormatado;
                        }
                    }
                }
            }
        }       
    }
}
