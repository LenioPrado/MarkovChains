using Common.Model;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    public class LerArquivoExcel
    {
        static readonly string PATH = @"D:\GoogleDriveUnifei\Doutorado\Jirau\Estados de Operação das UGs\Estados_UGs_Exemplo.xlsx";

        public static IEnumerable<Estados> LerArquivo()
        {
            IList<Estados> estados = new List<Estados>();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(PATH, FileMode.Open, FileAccess.Read))
            {
                using var leitor = ExcelReaderFactory.CreateReader(stream);
                int contador = 0;
                while (leitor.Read()) 
                {
                    if (contador > 0)
                    {
                        Estados estado = new()
                        {
                            UG = ObterValor(leitor, 1),
                            Ocorrencia = ObterValor(leitor, 2),
                            Sigla = ObterValor(leitor, 3),
                            Inicio = ConverterParaDateTime(leitor, 4),
                            Fim = ConverterParaDateTime(leitor, 5),
                            Duracao = ConverterParaTimeSpan(leitor, 6),
                        };

                        estados.Add(estado);
                    }
                    contador++;
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
