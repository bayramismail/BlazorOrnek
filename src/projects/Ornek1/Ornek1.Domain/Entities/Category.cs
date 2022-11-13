using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Domain.Entities
{
    public class Category:Entity
    {     
        public string Name { get; set; }
        public Category()
        {
                
        }
        public Category(int id,string name):base(id)
        {
            Name= name;
        }
    }
}
