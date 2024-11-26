using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public  interface IPayment
    {
        void MakePayment(int acno, int amount);
        void PaymentStatus(int transaction);
        void CancelPayment();
    }
    public class SBI : IPayment
    {
        public void CancelPayment()
        {

        }

        public void MakePayment(int acno, int amount)
        {
            
        }

        public void PaymentStatus(int transaction)
        {
            
        }
    }
    public class HDFC : IPayment
    {
        public void CancelPayment()
        {
            
        }

        public void MakePayment(int acno, int amount)
        {
            
        }

        public void PaymentStatus(int transaction)
        {
            
        }
    }
}
