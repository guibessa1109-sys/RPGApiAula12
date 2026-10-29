using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RpgApi.Models;

namespace RPGAPI.Models
{
    public class Usuario
    {
        //PROP pra criar a propriedade facil        
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // quando tiver uma string é ideil colocar o dps do =

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public byte[]? Foto { get; set; }

        public DateTime? DataAcesso { get; set; }

        [NotMapped]
        public string PasswordString { get; set; } = string.Empty;
        public string? Perfil { get; set; }
        public string? Email { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public List<Personagem> Personagens { get; set; }
             = new List<Personagem>();

        [NotMapped]
        public string Token { get; set; } = string.Empty;

        
    }
}