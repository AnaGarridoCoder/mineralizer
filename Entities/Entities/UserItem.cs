﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem()
        {
            IsActive = true;
        }

        public int Id { get; set; } 
        public Guid IdWeb { get; set; } 
        public string UserName { get; set; }    
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }  
        public int IdRol { get; set; }  

        private string Password { get; set; }
        private string EncryptedPassword { get; set; }  
        public string ExampleGitSasasa { get; set; }
    }
}
