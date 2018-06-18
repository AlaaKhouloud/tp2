using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string nom { get; set; }
        public string prenom { get; set; }

        public User(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}