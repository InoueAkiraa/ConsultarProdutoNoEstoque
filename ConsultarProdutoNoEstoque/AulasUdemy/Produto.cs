using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarProdutoNoEstoque
{
    class Produto{

        //ATRIBUTOS
        public string nome;
        public double preco;
        public int quantidade;

        //METODOS
        public double ValorTotalEmEstoque(){
            return preco * quantidade;
        }

        public void AdicionarProdutos(int Quantidade) {

            quantidade += Quantidade;
        }

        public void RemoverProdutos(int Quantidade)
        {

            quantidade -= Quantidade;
        }

        public override string ToString(){
            return nome 
                + ", R$ " 
                + preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + quantidade 
                + " unidades, total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
