using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Aula_01.Classes
{
    internal class Empresa
    {
        string Cnpj { get; set; }
        string RazaoSocial { get; set; }    
        string Nome { get; set; }
        string SituacaoCadastral { get; set; }
        string RegimeTributario { get; set; }
        DateTime DataInicio { get; set; }
        string Telefone { get; set; }
        double CapitalSocial { get; set; }
        string EnderecoCompleto { get; set; }
        string Tipo { get; set; }
        string PorteEmpresa { get; set; }   
        string NaturezaJuridica { get; set; }
        string NomeProprietario { get; set; }
        string CpfProprietario { get; set; }

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
