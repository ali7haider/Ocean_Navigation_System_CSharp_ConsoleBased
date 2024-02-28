using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Ship
    {
        private string name;
        private Angle latitude;
        private Angle longitude;

        public Ship(string name,Angle longitude,Angle latitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public Ship(Angle longitude, Angle latitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public Angle getLatitiude()
        {
            return latitude;
        }
        public void setLatitude(Angle latitude)
        {
            this.latitude = latitude;
        }
        public Angle getLongitude()
        {
            return longitude;
        }
        public void setLongitude(Angle longitude)
        {
            this.longitude=longitude;
        }
       
    }
}
