using System;
namespace cadastroPessoa

{
    public class PessoaJurica : Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }
        public override double pagarImposto(float rendimento){
            if (rendimento <= 5000)
            {
               return (rendimento * 0.06);
            }else if(rendimento > 5000 && rendimento <= 10000){
                return (rendimento * 0.08); 
            }
            return (rendimento * 0.10);
        }

        public bool ValidarCNPJ(string cnpj){
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6,4) == "0001")
            {
             return true;   
            }
            return false;
        }

    }
}