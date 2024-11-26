using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public  class Categories
    {
        public int Id {  get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        //Constructor:
        //It should be same name as class
        //It trigger automatically when object is created
        //It does not have return type
        //Default constructor
        public Categories()         
        {
            Console.WriteLine(Id);
        }
        //Parametrized Constructor
        public Categories(int id,string name,string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public void AddCategory(int id, string name)
        {
            Console.WriteLine("Category details:"+id+","+name);

        }
        public void AddCategory(int id, string name,string description)
        {
            Console.WriteLine("Category details:"+id+","+name+","+description);
        }
    }
}
