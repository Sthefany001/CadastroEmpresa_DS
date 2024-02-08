using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Aula_01.Classes
{
    internal class Empresa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }    
        public string Nome { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public DateTime DataInicio { get; set; }
        public string Telefone { get; set; }
        public double CapitalSocial { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpresa { get; set; }   
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CpfProprietario { get; set; }

        public Empresa() { }

        public Empresa(string cnpj, string razaoSocial, string nome, string situacaoCadastral, string regimeTributario, DateTime dataInicio, string telefone, double capitalSocial, string enderecoCompleto, string tipo, string porteEmpresa, string naturezaJuridica, string nomeProprietario, string cpfProprietario)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Nome = nome;
            SituacaoCadastral = situacaoCadastral;
            RegimeTributario = regimeTributario;
            DataInicio = dataInicio;
            Telefone = telefone;
            CapitalSocial = capitalSocial;
            EnderecoCompleto = enderecoCompleto;
            Tipo = tipo;
            PorteEmpresa = porteEmpresa;
            NaturezaJuridica = naturezaJuridica;
            NomeProprietario = nomeProprietario;
            CpfProprietario = cpfProprietario;
        }
    }
}
