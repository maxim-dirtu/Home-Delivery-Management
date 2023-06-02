using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariLaDomiciliu
{
    public class Comenzi
    {
        public int id;
        public float weight;//in kg
        public string deliveredItem;
        public string destinationAdress;
        public string receiverName;
        public string senderName;
        public Boolean isFragile;
        public DateTime deliveryDate;

        public Comenzi(int i, float w,string di, string da, string rn, string sn, Boolean iF, DateTime dd)
        {
            id = i;
            weight = w;
            deliveredItem = di;
            destinationAdress = da;
            receiverName = rn;
            senderName = sn;
            isFragile = iF;
            deliveryDate = dd;
        }

        public override string ToString()
        {
            return "ID#" + this.id;
        }

        public Comenzi() { }


    }
}
