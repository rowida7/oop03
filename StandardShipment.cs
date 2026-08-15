using System;
using System.Collections.Generic;
using System.Text;

namespace oop02
{
    internal class StandardShipment: Shipment
    {
   
        public StandardShipment() { }

        //Constructor Chaining
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFree, DeliveryAddress destination)
           : base(trackingCode, description, weight, deliveryFree, destination) { }

        
    }
}
