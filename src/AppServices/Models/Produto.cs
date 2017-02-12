using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppServices.Models
{
    public class Produto
    {
        public int id;
        public string nome;
        public string marca;
        public double preco;

        private List<Produto> lista = new List<Produto>();

        public Produto()
        {

            
        }


        public List<Produto> GetAll ()
        {


            lista.Clear();
            lista.Add(new Produto() { id = 1, nome = "Bombril", marca = "PeG", preco = 100 });
            lista.Add(new Produto() { id = 2, nome = "Cafe Voluto", marca = "Nespresso", preco = 35.90 });
            lista.Add(new Produto() { id = 3, nome = "Delirium Tremens", marca = "Deliriuns", preco = 100 });

            return this.lista;

        }

        public Produto Get(int id)
        {


            return new Produto() { id = 1, nome = "Bombril", marca = "PeG", preco = 100 };
        }

    }
}
