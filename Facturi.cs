using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariLaDomiciliu
{
    public class Facturi
    {
        public Comenzi order;
        public int orderID;
        public DateTime issuanceDate;
        public string deliveryPersonName;
        public float deliveryPrice;
        public string paymentMethod;

        public Facturi(Comenzi o, string dpn, float dp, string pm)
        {
            this.order = o;
            this.orderID = o.id;
            this.issuanceDate = DateTime.Now;
            this.deliveryPersonName = dpn;
            this.deliveryPrice = dp;
            this.paymentMethod = pm;
        }

        public Facturi() { }


        public override string ToString()
        {
            return "Factura pentru comanda cu id#" + this.orderID
                + "\r\nGreutate (kg.): " + this.order.weight
                + "\r\nObiect livrat: " + this.order.deliveredItem
                + "\r\nAdresa destinatarului: " + this.order.destinationAdress
                + "\r\nNumele destinatarului: " + this.order.receiverName
                + "\r\nNumele expeditorului: " + this.order.senderName
                + "\r\nNumele livratorului: " + this.deliveryPersonName
                + "\r\nPretul livrarii: " + this.deliveryPrice +" RON"
                + "\r\nMetoda de plata: " + this.paymentMethod
                + "\r\nData si ora: " + this.issuanceDate.ToString();
                
        }

    }
}
