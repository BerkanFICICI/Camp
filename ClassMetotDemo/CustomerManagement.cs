using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManagement
    {
        //void yerine string kullandım çünkü sonucu döndürmek ve onu program.cs'de başka yerlerde de...
        //kullanabilmek istiyorum.
        //I used string rather than void because I would like to return a result and use it anywhere in 'program.cs'.
        public string Add(Customer customer) 
        {
            string text = $"{customer.Name} adlı müşreti başarıyla sisteme eklendi.";
            return text;
        }
        
        public string Remove(Customer customer)
        {
            string text = $"{customer.Name} adlı müşreti başarıyla sistemden silindi";
            return text;
        }
        public string Balance(Customer customer) 
        {
            string text = $"{customer.Name} adlı müşretinin bakiyesinde {customer.Balance} kadar döviz bulunmaktadır.";
            return text;
        }
    }
}
