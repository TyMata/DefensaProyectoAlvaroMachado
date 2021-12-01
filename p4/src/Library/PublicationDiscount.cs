using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if(value > -1)
                {
                    throw new ArgumentException();
                }
                this.amount = value;
            }
        }

        public PublicationDiscount(int discount)
        {
            if(discount > -1)
            {
                throw new ArgumentException();
            }
            this.amount = discount;
        }

        public int ItemSubTotal()
        {
            return this.SubTotal;
        }


    }
}