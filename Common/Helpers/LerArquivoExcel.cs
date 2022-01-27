using Common.Model;
using Common.Model.Data;
using ExcelDataReader;
using Ganss.Excel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class LerArquivoExcel
    {
        static readonly string PATH_INPUT = @"D:\GoogleDriveUnifei\Doutorado\Jirau\Estados de Operação das UGs\Estados_UGs_Exemplo.xlsx";
        static readonly string PATH_OUTPUT = @"D:\GoogleDriveUnifei\Doutorado\Jirau\Estados de Operação das UGs\Estados_UGs_Exemplo_Output.xlsx";
        static readonly int DURACAO = 30;
        static readonly int DURACAO_TRANSICAO = 1;

        public static async Task<IEnumerable<Estados>> LerExcel(IRepositorio<Estados> repositorio)
        {
            var excel = new ExcelMapper();

            excel.AddMapping<Estados>("Inicio", p => p.Inicio).SetCellUsing(SetCellUsing).SetPropertyUsing(SetPropertyUsing);
            excel.AddMapping<Estados>("Fim", p => p.Fim).SetCellUsing(SetCellUsing).SetPropertyUsing(SetPropertyUsing);

            var estados = (await excel.FetchAsync<Estados>(PATH_INPUT)).ToList();

            return estados;
        }

        public static async Task GravarExcel(IEnumerable<Estados> estados)
        {
            if (File.Exists(PATH_OUTPUT))
                File.Delete(PATH_OUTPUT);
            
            await new ExcelMapper().SaveAsync(PATH_OUTPUT, estados, sheetName: "Processado");
        }

        private static void SetCellUsing(ICell c, object o)
        {
            if (o == null) c.SetCellValue("NULL"); else c.SetCellValue((DateTime)o);
        }

        private static object SetPropertyUsing(object v)
        {
            if ((v as string) == "NULL") return null;
            return DateTime.Parse(v.ToString(), new CultureInfo("pt-BR", false));
        }

        public static async Task<IEnumerable<Estados>> LerArquivo(IRepositorio<Estados> repositorio)
        {
            IList<Estados> estados = new List<Estados>();

            await repositorio.RemoveAll();
            await repositorio.ExecuteQuery("DBCC CHECKIDENT('markov.estados', RESEED, 1);");
            await repositorio.SaveChanges();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(PATH_INPUT, FileMode.Open, FileAccess.Read))
            {
                using var leitor = ExcelReaderFactory.CreateReader(stream);
                int contador = 0;
                while (leitor.Read()) 
                {
                    // Não efetua a leitura do cabeçalho
                    if (contador > 0)
                    {
                        TimeSpan? duracao = ConverterParaTimeSpan(leitor, 6);
                        Estados estado = new()
                        {
                            UG = ObterValor(leitor, 1),
                            Ocorrencia = ObterValor(leitor, 2),
                            EstadoOrigem = ObterValor(leitor, 3),
                            Inicio = ConverterParaDateTime(leitor, 4),
                            Fim = ConverterParaDateTime(leitor, 5),
                            Duracao = duracao.HasValue ? duracao.Value.TotalMinutes / DURACAO : 0,
                        };

                        if (contador > 1)
                        {
                            Estados estadoAnterior = estados[estados.Count - 1];

                            if (estado.UG.Equals(estadoAnterior.UG))
                            {
                                if (!estado.EstadoOrigem.Equals(estadoAnterior.EstadoOrigem) && estadoAnterior.Duracao > 0)
                                {
                                    Estados novoEstado = estadoAnterior.Copiar();

                                    estadoAnterior.EstadoDestino = novoEstado.EstadoOrigem;
                                    estadoAnterior.Fim = estadoAnterior.Fim.Value.AddMinutes(-DURACAO_TRANSICAO);
                                    estadoAnterior.Duracao = ((estadoAnterior.Duracao * DURACAO) - DURACAO_TRANSICAO) / DURACAO;

                                    novoEstado.Duracao = DURACAO_TRANSICAO;
                                    novoEstado.Inicio = estadoAnterior.Fim.Value;
                                    novoEstado.Ocorrencia = $"{novoEstado.Ocorrencia}_1";
                                    novoEstado.EstadoDestino = estado.EstadoOrigem;

                                    estados.Add(novoEstado);
                                }
                                else
                                {
                                    estadoAnterior.EstadoDestino = estado.EstadoOrigem;
                                }                               
                            }
                        }

                        estados.Add(estado);                                               
                    }
                    contador++;
                }

                ShowResultsHelper.ShowEstadosValues("Listagem de Estados", estados);

                try
                {
                    await repositorio.AddRange(estados);
                    await repositorio.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return estados;
        }

        public static DateTime? ConverterParaDateTime(IExcelDataReader reader, int index)
        {
            string value = ObterValor(reader, index);
            if (value != null)
                return DateTime.Parse(value);
            else
                return null;
        }

        public static TimeSpan? ConverterParaTimeSpan(IExcelDataReader reader, int index)
        {
            string value = ObterValor(reader, index);
            if (value != null)
                return TimeSpan.Parse(value);
            else
                return null;
        }

        public static string ObterValor(IExcelDataReader reader, int index)
        {
            return reader.GetValue(index)?.ToString();
        }
    }
}
