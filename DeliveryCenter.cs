using oop03;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop02
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        public string CenterName {  get; set; }
        public Driver Driver { get; set; }
        public DeliveryCenter()
        {
            shipments = new Shipment[3];
        }

        #region Add an integer indexer
        //Returns the shipment at the given position.
        //Allows replacing a shipment.
        //If the index is invalid, the getter returns default.
        //If the index is invalid while setting, do nothing.

        public Shipment this[int index]
        {
            get
            {
                if (index < shipments.Length && index >= 0)
                {
                    return shipments[index];
                }

                return default;

            }

            set
            {
                if (index < shipments.Length && index >= 0)
                {
                    shipments[index] = value;

                }
            }
        }

        #endregion



        #region Add a string indexer
        //Returns the first shipment with the matching tracking code.
        //Returns default if no matching shipment is found.

        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments is not null)
                {
                    foreach (Shipment shipment in shipments)
                    {

                        if (shipment.TrackingCode == trackingCode)
                        {
                            return shipment;
                        }
                    }

                }
                return default;
            }
        }

        #endregion

        #region Add Method named AddShipment
        //Adds the shipment to the first available position.
        //Returns true if the shipment was added successfully.
        //Returns false if the delivery center is full

        public bool AddShipment(Shipment newShipment)
        {
            if (shipments is not null)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i]?.TrackingCode == null)
                    {
                        shipments[i] = newShipment;
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion


        #region RemoveShipment
        public bool RemoveShipment(string trackingCode)
        {
            if (shipments is not null)            
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        shipments[i] = default;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion


        #region PrintAllShipments
        public void PrintAllShipments()
        {
            foreach(Shipment shipment in shipments)
            {
                //Modify PrintAllShipments()
                shipment.PrintShipment();
                Console.WriteLine("=========================");
            }
            
        }



        public void PrintInfo()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("=========================");
            Console.WriteLine($"\nDriver:{Driver.Name}\n");
            Console.WriteLine("-------------------------");

        }
        #endregion

    }

}
