using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_uge_3
{
    public class Transportberegner
    {
       
        public double GetPrice(int distanceInMeters, double weightInKg)
        {
            double transportpris = 0;
            //Hvis afstanden er under 5 km og vægten er under 10 kg, så er transporten gratis.
            if (distanceInMeters < 5000 && weightInKg < 10)
            {
                transportpris = 0;

            }
            //Er afstanden under 5 km, men vægten er 10 kg eller mere, så koster transporten 50 kr.
            else if (distanceInMeters < 5000 && weightInKg >= 10)
            {
                transportpris = 50;
            }
            //Hvis afstanden er 5 km eller mere, koster transporten 75 kroner, hvis vægten er under 10 kg
            else if (distanceInMeters >= 5000 && weightInKg < 10)
            {
                transportpris = 75;
            }
            //Hvis afstanden er 5 km eller mere, og vægten over 10 koster transporten 100kr.
            else if (distanceInMeters >= 5000 && weightInKg >= 10)
            {
                transportpris = 100;
            }
            return transportpris;
        }
    }
}
