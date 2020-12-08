namespace AulaPOO_Heranca.classes
{
    public class PessoaJuridica : Pessoa //método para atribuir SUBclasse à SUPERclasse (HERANÇA)
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento)
       {
           if(documento != ""){
               return true;
           }
           return false;
       }
    }
}