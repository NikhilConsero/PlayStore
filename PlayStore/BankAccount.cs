using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public abstract class BankAccount
    {
        public abstract void deposit(int amount);
        public abstract void withdraw(int amount);
        public int currentamt;
    }
    public class SavingAccount : BankAccount
    {
        public SavingAccount()
        {
            Console.WriteLine("Enter the Initail Amount:");
            this.currentamt = Convert.ToInt32(Console.ReadLine());
        }
        public override void deposit(int amount)
        {

            Console.WriteLine($"You have deposited {amount}");
            this.currentamt = this.currentamt + amount;
        }

        public override void withdraw(int amount)
        {
            if (this.currentamt < amount)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {

            }
            Console.WriteLine($"You have Withdrawn {amount}");
            this.currentamt = this.currentamt - amount;
        }
    }
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount()
        {
            Console.WriteLine("Enter the Initail Amount:");
            this.currentamt = Convert.ToInt32(Console.ReadLine());
        }
        public override void deposit(int amount)
        {
            Console.WriteLine($"You have deposited {amount}");
            this.currentamt = this.currentamt + amount;
        }

        public override void withdraw(int amount)
        {
            if (this.currentamt < amount)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {
                Console.WriteLine($"You have Withdrawn {amount}");
                this.currentamt = this.currentamt - amount;
            }
        }
    }
}