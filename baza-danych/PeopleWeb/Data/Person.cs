using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleWeb.Data
{
    public class Person
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Birth date")]
        public DateTime BirthDate { get; set; }        
    }
}
