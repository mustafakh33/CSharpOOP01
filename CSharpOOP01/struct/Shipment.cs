using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP01
{
    public struct Shipment
    {
        private string? _trackingCode;
        private string? _description;
        private double _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;

        // Constructor that receives only trackingCode and uses defaults
        public Shipment(string trackingCode): this( trackingCode,"Unknown",1,50,new DeliveryAddress())
        {
        }

        // Constructor that receives all values including destination
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        // TrackingCode: read-only from outside, cannot be null/empty/whitespace
        public string TrackingCode
        {
            get => _trackingCode;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        // Description: read/write with validation (cannot be null/empty/whitespace)
        public string Description
        {
            get => _description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        // Weight: read/write with validation (must be > 0)
        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        // DeliveryFee: public getter, private setter; must be > 0
        public decimal DeliveryFee
        {
            get => _deliveryFee;
            private set
            {
                if (value > 0m)
                {
                    _deliveryFee = value;
                }
            }
        }
        
        // Destination: public read/write property
        public DeliveryAddress Destination
        {
            get => _destination;
            set => _destination = value;
        }

        // EstimatedCost: calculated on request (not stored)
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5m);
            }
        }

        // UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0.
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0m)
            {
                DeliveryFee = newFee;
            }
        }

        // PrintShipment(): prints all shipment information, including the estimated cost.
        public void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"  TrackingCode : {TrackingCode}");
            Console.WriteLine($"  Description  : {Description}");
            Console.WriteLine($"  Weight       : {Weight}");
            Console.WriteLine($"  DeliveryFee  : {DeliveryFee:C}");
            Console.WriteLine($"  Destination :  {Destination.GetFullAddress()}");
            Console.WriteLine($"  EstimatedCost: {EstimatedCost:C}");
        }

    }
}
