using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop02
{
    internal class Shipment
    {
        #region Q4: Shipment 
        private string? trackingCode;
        private string? description ;
        private double weight;
        private double deliveryFee;
        private DeliveryAddress destination;

       public string TrackingCode { get { return trackingCode; } }
       public string Description { get { return description; } set { if (!string.IsNullOrWhiteSpace(value)) description = value ; } }
       public double Weight { get { return weight; } set { if (value > 0) weight = value; } }
       public double DeliveryFee { get { return deliveryFee; } private set { if(value > 0) deliveryFee = value; } }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        //Virtual EstimatedCost property
        public virtual double EstimatedCost { get { return DeliveryFee + (Weight * 5d); } }


        public Shipment() { }

        #region first constructor overloading to Shipment
        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Cairo", "Salah Salem", 55);
        }
        #endregion



        #region second constructor overloading to Shipment
        //The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        //Each constructor must initialize the object with valid data.

        public Shipment(string trackingCode, string description, double weight,double deliveryFree, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFree;
            Destination = destination;
        }
        #endregion



        #region part3
        //UpdateDeliveryFee(double newFee): updates the fee only when newFee is greater than 0.
        
        public void UpdateDeliveryFee(double newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        //PrintShipment() : prints all shipment information, including the estimated cost.
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code:{TrackingCode}\nDescription:{Description}\nWeight:{Weight}\n" +
                $"Delivery Fee:{DeliveryFee}\nEstimated Cost:{EstimatedCost}\nDistination:{Destination.GetFullAddress()}");
        }

        #region Update the Shipment Class
        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraPackageWeight)
        {
            Weight = newWeight + extraPackageWeight;
        }
        #endregion


        #endregion
        #endregion
    }
}
