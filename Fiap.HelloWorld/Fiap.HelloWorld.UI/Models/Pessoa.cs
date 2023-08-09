using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public abstract class Pessoa
    {
        //Atributos
        private string _nome;
        private int _idade;

        //Propriedades (Getters e Setters)

        public Genero Genero { get; set; }

        public string Cpf { get; set; }

        public string Nome 
        { 
            get { return _nome; } 
            set { _nome = value; } 
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public abstract void Trabalhar();

        public virtual void Andar()
        {
            Console.WriteLine("Pessoa andando");
        }

        public void Andar(string destino)
        {
            Console.WriteLine($"Andando até {destino}");
        }

    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }


}
