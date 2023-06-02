using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariLaDomiciliu
{
    public class Clienti
    {
        public string name;
        public char gender;//M/F
        public string phoneNumber;
        public int nrPreviousOrders;
        public string adress;
        public int age;
        
        
        public Clienti(string n, char g, string pn, int ncp, string a, int age)
        {
            name = n;
            gender = g;
            phoneNumber = pn;  
            nrPreviousOrders = ncp;
            adress = a;
            this.age = age;
            
        }

        public Clienti() { }
    }
}
