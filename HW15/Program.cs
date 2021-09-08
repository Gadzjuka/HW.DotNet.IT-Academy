using HW15.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseMotorcycle[] purchases = new PurchaseMotorcycle[5];
            purchases[0] = new PurchaseMotorcycle("asd");
            purchases[1] = new PurchaseMotorcycle("123");
            purchases[2] = new PurchaseMotorcycle("1234567812345678");
            purchases[3] = new PurchaseMotorcycle("1234-5678-1234-5678");
            purchases[4] = new PurchaseMotorcycle("1234 5678 1234 5678");

            foreach (var purchase in purchases)
            {
                if (purchase.Validate())
                {
                    Console.WriteLine($"{purchase.CreditCardNumber} is valid");
                }
                else
                {
                    Console.WriteLine($"{purchase.CreditCardNumber} is invalid");
                }
            }
        }
    }
}
