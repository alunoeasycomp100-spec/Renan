using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class PessoaFisica : Pessoa // classe pessoajuridica herda  a classe pessoa
    {
        private string rg, cpf; // atributos rg e cpf

        public void GravarPessoa (string nome, string endereco, string rg, string cpf) // metodo responsalvel por gravar o nome, endereco, rg e cpf
        {
            base.GravarPessoa(nome, endereco);
            this.rg = rg;
            this.cpf = cpf;            
        }
        public string MostrarRg()
        {
            return rg;
        }
        public string MostrarCpf()
        {
            return cpf;
        }
    }

}
