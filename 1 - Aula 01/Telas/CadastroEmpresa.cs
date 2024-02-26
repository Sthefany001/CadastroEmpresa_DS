using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1___Aula_01.Classes;
using _1___Aula_01.Telas;

namespace _1___Aula_01.Telas
{
    
    public partial class CadastroEmpresa : Form
    {
        List<Empresa> listaEmpresa = new List<Empresa>();

        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Empresa x = new Empresa();
                x.Cnpj = tb_Cnpj.Text;
                x.RazaoSocial = tb_RazaoSocial.Text;
                x.Nome = tb_NomeFantasia.Text;
                x.SituacaoCadastral = cb_SituacaoCadastral.Text;

                //regime tributário
                if(rb_rt1.Checked)
                {
                    x.RegimeTributario = "Simples Nacional";
                }
                else if(rb_rt2.Checked)
                {
                    x.RegimeTributario = "Lucro Presumido";
                }
                else
                {
                    x.RegimeTributario = "Real";
                }
                 
                x.DataInicio = dateTimePicker1.Value.Date;
                x.Telefone = mtb_Telefone.Text;
                x.CapitalSocial = Convert.ToDouble(tb_CapitalSocial.Text);

                //endereco completo
                x.Rua = tb_Rua.Text;
                x.Numero = tb_numero.Text;
                x.Complemento = tb_complemento.Text;
                x.Cidade = tb_Cidade.Text;
                x.Estado = cb_EndecoEstado.Text;

                //tipo
                if (rb_Tipo1.Checked)
                {
                    x.Tipo = "Matriz";
                }
                else
                {
                    x.Tipo = "Filial";
                }

                //porte da empresa
                if (rb_pe1.Checked)
                {
                    x.PorteEmpresa = "Pequeno";
                }
                else if (rb_pe2.Checked)
                {
                    x.PorteEmpresa = "Médio";
                }
                else
                {
                    x.PorteEmpresa = "Grande";
                }

                x.NaturezaJuridica = cb_NaturezaJuridica.Text;
                x.NomeProprietario = tb_NomeProprietario.Text;
                x.CpfProprietario = tb_CpfProprietario.Text;

                listaEmpresa.Add(x);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = listaEmpresa;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERRO! {ex.Message}");
            }

        }

        private void rb_RegimeTributario1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Excluir_Click(object sender, EventArgs e)
        {
            tb_Cnpj.Clear();
            tb_RazaoSocial.Clear(); 
            tb_NomeFantasia.Clear();
            cb_SituacaoCadastral.SelectedItem = null;
            rb_rt1.Checked = false;
            rb_rt2.Checked = false;
            rb_rt3.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
            mtb_Telefone.Clear();
            tb_CapitalSocial.Clear();
            tb_Rua.Clear();
            tb_numero.Clear();
            tb_complemento.Clear();
            tb_Cidade.Clear();
            cb_EndecoEstado.SelectedItem = null;
            rb_Tipo1.Checked = false;
            rb_Tipo2.Checked = false;
            rb_pe1.Checked = false;
            rb_pe2.Checked = false;
            rb_pe3.Checked = false;
            cb_NaturezaJuridica.SelectedItem = null;
            tb_NomeProprietario.Clear();
            tb_CpfProprietario.Clear();
            dataGridView1.DataSource = null;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button_voltarMenu_Click(object sender, EventArgs e)
        {
            Menu telaMenu = new Menu();
            telaMenu.ShowDialog();
        }
    }
}
