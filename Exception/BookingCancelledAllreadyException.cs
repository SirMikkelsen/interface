﻿using System.Runtime.Serialization;

namespace HotelSystem.Exception
{
    [DataContract]
    public class BookingCancelledAllreadyException : System.Exception
    {
    }
}