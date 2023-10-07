namespace Match_Game___Perfil.Models
{
    public class UserName
    {
        public string Name { get; set; }
    }

    public class Usuario
    {
        //Declarando as propriedades
        public string Name { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public string Senha { get; set; }
        public int UserID { get; set; }
        public string Interesses { get; set; }
        public int InteressesID { get; set; }
        public byte[] Foto { get; set; }

        //Criando o construtor para ser instanciado em outro momento
        public Usuario(string name, string email, string dataNasc, string senha, int userID, string interesses, int interessesID, byte[] foto)
        {
            Name = name;
            Email = email;
            DataNasc = dataNasc;
            Senha = senha;
            UserID = userID;
            Interesses = interesses;
            InteressesID = interessesID;
            Foto = foto;
        }

        //Criando o metodo de cadastro
        public Cadastro()
        {

            
        }

        //Criando o metodo de Logim



    }

}
