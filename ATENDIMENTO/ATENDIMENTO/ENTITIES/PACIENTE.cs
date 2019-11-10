using SHAREDCONTEXT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ATENDIMENTO.ENTITIES
{
    public class Paciente : EntityBase
    {
        public bool IsValid { get; private set; }
        public List<Tuple<string, string>> Erros { get; private set; }
        public Paciente(Guid _id, String _nome, String _sobrenome, String _cpf)
        {
            _id = ID;
            _nome = Nome;
            _sobrenome = Sobrenome;
            _cpf = CPF;
            IsValid = true;
            if (Nome.Length < 2 || Nome.Length > 15)
            {
                Erros.Add(new Tuple<string, string>("Nome", "O campo Nome não pode ser menor que 2 ou maior que 15!"));
                IsValid = false;
            }
            if (Sobrenome.Length < 5 || Sobrenome.Length > 40)
            {
                Erros.Add(new Tuple<string, string>("Sobrenome", "O campo Sobrenome não pode ser menor que 5 ou maior que 40!"));
                IsValid = false;
            }
            if (CPF.Length == 0 || CPF.Length > 11)
            {
                Erros.Add(new Tuple<string, string>("CPF", "Insira um CPF válido!"));
                IsValid = false;
            }
        }
        public string CPF { get; private set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; private set; }
        public string Endereco { get; private set; }
    }
}
