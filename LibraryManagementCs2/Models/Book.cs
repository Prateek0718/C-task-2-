using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementCs2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string dateIssuedOn { get; set;}
        public string dateOfReturning { get; set; }
        public string nameOfAuthor { get; set;}
    }
}