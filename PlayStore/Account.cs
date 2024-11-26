using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    public interface Account
    {
        public void deposit(int amt);
        public void withdraw(int amt);
        public void CalculateInterest(int amt,int time);
        public void ViewBalance();
    }
    public class SA : Account
    {
        public int crntamt;
        public SA() 
        {
            Console.Write("Enter the Initial Amount:");
            this.crntamt=Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateInterest(int amt,int time)
        {
            int interest=Convert.ToInt32((amt*0.12*time)/100);
            Console.WriteLine($"Interest is {interest}");
        }

        public void deposit(int amt)
        {
            Console.WriteLine($"You have deposited {amt}");
            this.crntamt = this.crntamt + amt;
        }

        public void ViewBalance()
        {
            Console.WriteLine($"The Balance is:{this.crntamt}");
        }

        public void withdraw(int amt)
        {
            if (this.crntamt < amt)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {

            Console.WriteLine($"You have Withdrawn {amt}");
            this.crntamt = this.crntamt - amt;
            }
        }
    }
    public class CA : Account
    {
        int crntamt;
        public CA()
        {
            Console.Write("Enter the Initial Amount:");
            this.crntamt = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateInterest(int amt, int time)
        {
            int interest = Convert.ToInt32((amt * 0.12 * time) / 100);
            Console.WriteLine($"Interest is {interest}");
        }

        public void deposit(int amt)
        {
            Console.WriteLine($"You have deposited {amt}");
            this.crntamt = this.crntamt + amt;
        }

        public void ViewBalance()
        {
            Console.WriteLine($"The Balance is:{this.crntamt}");
        }

        public void withdraw(int amt)
        {
            throw new NotImplementedException();
        }
    }
}
