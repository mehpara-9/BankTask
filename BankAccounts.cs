using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTask
{
    public class BankAccounts
    {
        private decimal _balanc;

        public decimal _balancbalace
        {
            get { return _balanc; }

        }

        private int _AccountNumber;
        public int AccountNumber
        {
            get { return _AccountNumber; }

        }
        public string Ownername { get; set; }

        public BankAccounts(int AAccountNumber, string customername, int balanc)
        {
            _AccountNumber = AAccountNumber;
            Ownername = customername;
            _balanc = balanc;

        }
        public void Deposit(decimal depositamount)
        {
            if (depositamount > 0)
            {
                _balanc += depositamount;
                Console.WriteLine($"{depositamount}azn ugurla kocuruldu,cari balans {_balanc}");

            }
            else
            {
                Console.WriteLine("elave edeceyim mebleg menfi ola bilmez");
            }
        }
        public void WithDraw(decimal withdrawamount)
        {
            if (_balanc > withdrawamount)
            {
                _balanc -= withdrawamount;
                Console.WriteLine($"{withdrawamount} cixarildi");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"balansiniz {_balanc}, adiniz{Ownername},musteri nomreniz{AccountNumber}");
        }


        public void TransferFunds(BankAccounts recipient, decimal amount)
        {
            recipient.Deposit(amount);
            Console.WriteLine($"{recipient} sexsine {amount} azn qeder mebleg kocuruldu");
        }
    }
}
