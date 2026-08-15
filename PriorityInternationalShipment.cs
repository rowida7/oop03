using oop02;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop03
{
    internal class PriorityInternationalShipment :InternationalShipment
    {
        //Sealed Method
        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine("Priority international customs report");
        }
    }
}
