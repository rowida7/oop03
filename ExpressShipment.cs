using System;
using System.Collections.Generic;
using System.Text;

namespace oop02
{
    internal class ExpressShipment: Shipment
    {
        private double extraFee;
        public double ExtraFee
        {
            get;
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        // Constructor Chaining
        public ExpressShipment(string trackingCode, string description, double weight, 
            double deliveryFree, DeliveryAddress destination,double extraFee)
            :base(trackingCode,description,weight,deliveryFree,destination)
        {
            ExtraFee = extraFee;
        }

        public ExpressShipment() { }


        public override double EstimatedCost { get { return DeliveryFee + (Weight * 5d) + ExtraFee; } }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee:{ExtraFee}");
        }
    }
}
