using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Client
    {

        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? CPF {get; set;}
        public int Id {get; set;}
        public string? Email {get; set;}

        
        
        
        public Client()
        {

        }
        public Client(string? firstName, string? lastName, string? cPF, int id, string email)
        {  
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Id = id;
            Email = email;
        }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id} \nName: {this.FullName} \nCPF: {this.CPF} \nEmail: {this.Email}";
        }

    }
}