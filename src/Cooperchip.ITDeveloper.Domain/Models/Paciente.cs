using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cooperchip.ITDeveloper.Domain.Models
{
    public class Paciente : EntityBase
    {
        public Paciente()
        {
            Ativo = true;
        }

        [ForeignKey("EstadoPaciente")]//forçando a informação da  origem do relacionamento
        [Display(Name="Estado do Paciente")] //Mudando o nome Estetica em caso de erro e etc...
        public Guid EstadoPacienteId { get; set; } //guarda o id do estado do paciente - relacionamento para saber qual o estado do paciente que esta na outra entidade
        public virtual EstadoPaciente EstadoPaciente { get; set; } //campo de navegação - cria o relacionamento entra a entidade "EstadoPaciente" e "Paciente". a partir dessa navegação e possivel obter o "EstadoPaciente" da entidade.

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInternacao { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string Cpf { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
        public Sexo Sexo { get; set; }
        public string Rg { get; set; }
        public string Rgorgao { get; set; }
        public DateTime RgDataEmissao { get; set; }

        //public override string ToString()
        //{
        //    return this.Id.ToString() + "  -  " + this.Nome;
        //}
    }
}
