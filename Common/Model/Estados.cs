using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class Estados
    {
        public string UG { get; set; }
        public string Sigla { get; set; }
        public Estados EstadoDestino { get; set; }
        public string Ocorrencia { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public TimeSpan? Duracao { get; set; }

        public override string ToString()
        {
            return $"UG: '{UG}' Ocorrência: '{Ocorrencia}' Estado: '{Sigla}' Inicio: '{Inicio}' Fim: '{Fim}'"; ;
        }

        public string ChaveUGEstadoAtual { get { return $"{UG}-{Sigla}"; } }

        public string ChaveUGEstadoAtualDestino{ get { return $"{UG}-{Sigla}-{EstadoDestino?.Sigla}"; } }
    }
}
