using Common.Model.Data;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Common.Model
{
    [Table("estados", Schema = "markov")]
    public class Estados : EntidadeBase
    {
        public virtual string UG { get; set; }
        public virtual string EstadoOrigem { get; set; }
        public virtual string EstadoDestino { get; set; }
        public virtual string Ocorrencia { get; set; }
        public virtual DateTime? Inicio { get; set; }        
        public virtual DateTime? Fim { get; set; }
        public virtual double Duracao { get; set; }

        public Estados Copiar()
        {
            return new()
            {
                UG = UG,
                EstadoOrigem = EstadoOrigem,
                EstadoDestino = EstadoDestino,
                Ocorrencia = Ocorrencia,
                Inicio = Inicio,
                Fim = Fim
            };
        }

        public override string ToString()
        {
            return $"UG: '{UG}' Ocorrência: '{Ocorrencia}' Estado: '{EstadoOrigem}' Inicio: '{Inicio}' Fim: '{Fim}'"; ;
        }

        public bool OrigemDiferenteDestino()
        {
            return !EstadoOrigem.Equals(EstadoDestino);
        }
    }
}
