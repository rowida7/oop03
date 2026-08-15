using System;
using System.Collections.Generic;
using System.Text;

namespace oop02
{
    internal class InternationalShipment: Shipment
    {
        private string destinationCountry;
        private double customsFee;

        public string DestinationCountry {  
            get; 
            set 
            {
                if(!string.IsNullOrWhiteSpace(destinationCountry))
                    destinationCountry = value;
            }
        }
        public double CustomsFee {  
            get;
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public InternationalShipment() { }

        //Constructor Chaining
        public InternationalShipment(string trackingCode, string description, double weight, 
            double deliveryFree, DeliveryAddress destination, string destinationCountry, double customsFee)
           : base(trackingCode, description, weight, deliveryFree, destination) 
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public double EstimatedCost { get { return DeliveryFee + (Weight * 5d) + CustomsFee; } }
    }
}
