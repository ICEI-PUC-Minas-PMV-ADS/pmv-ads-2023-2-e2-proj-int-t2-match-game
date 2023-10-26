﻿using System.ComponentModel.DataAnnotations;

namespace Match_Game.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public int ID_User { get; set; }



    }
}
