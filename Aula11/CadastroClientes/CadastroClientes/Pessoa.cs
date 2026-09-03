using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class Pessoa // classe pessoa
    {
        private string nome, endereco; // atributo nome e endereco

        public void GravarPessoa (string nome, string endereco) // metodo responsavel por gravar o nome e o endereco
        {
            this.nome = nome; // o atributo noem recebera o etxto o parametro nome
            this.endereco = endereco;
        }
        public string MostrarNome()
        {
            return nome;           
        }
        public string MostrarEndereco()
        {
            return endereco;
        }
    }
}
