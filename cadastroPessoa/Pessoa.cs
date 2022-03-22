using System;
namespace cadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public float rendimento { get; set; }

        public Endereco endereco { get; set; }
        
        
        public abstract double pagarImposto(float salario);
        
    }
}