using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroProject.Models
{
    public class Superhero
    {
        [Key] 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string alter_ego { get; set; }
        public string primary_superhero_ability { get; set; }
        public string secondary_ability { get; set; }
        public string catchphrase { get; set; }
    }
}