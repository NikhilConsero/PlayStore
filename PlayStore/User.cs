using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public class User:IUser 
    { 
        //Properties 
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int   Mobile { get; set; }
        private int UserKey { get; set; }

        public void AddUser()
        {
            
        }

        //Functions
        //SyntaxCheck: public ReturnTypeEncoder/no-return-type MethodName() { }
        public void CreateUser()
        {
            Console.WriteLine("Register");
            //How to read input from Keyboard
            Console.Write("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Welcome, "+Name);
            Console.Write("Enter Mobile:");
            Mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void deleteUser()
        {
            
        }

      

        public void Getresult()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            
        }

        public void updateuser()
        {
            
        }
    }
}
