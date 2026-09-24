using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP01 
{
    public struct DeliveryCenter
    {
        private Shipment[] _shipments;
        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return default;
                }

                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];
                    }
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(_shipments[i].TrackingCode))
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }


    }
}
