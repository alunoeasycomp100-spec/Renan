using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    internal class PessoaJuridica : Pessoa
    {
        private string ie, cnpj; // atributos ie e cnpj

        public void GravarPessoa(string nome, string endereco, string ie, string cnpj) // metodo responsalvel por gravar o nome, endereco, ie e cnpj
        {
            base.GravarPessoa(nome, endereco);
            this.ie = ie;
            this.cnpj = cnpj;
        }
        public string MostrarIe()
        {
            return ie;
        }
        public string MostrarCnpj()
        {
            return cnpj;
        }
    }
}
