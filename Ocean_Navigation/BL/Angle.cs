using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.BL
{
    class Angle
    {
        private int degree;
        private float minutes;
        private char direction;

       
        public Angle(int degree, float minutes, char direction)
        {
            
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;

           
        }
        public Angle()
        {

        }
        public void setvalue(int d,float m,char direct)
        {
            degree = d;
            m = minutes;
            direction = direct;
        }

        public void disply()
        {
            Console.WriteLine(degree + "\u00b0" + minutes + "\u00b0" + direction);
        }
        public void setDegree(int degree)
        {
            this.degree = degree;
        }
        public int getDegree()
        {
            return degree;
        }
        public void setMinutes(float minutes)
        {
            this.minutes = minutes;
        }
        public float getMinutes()
        {
            return minutes;
        }
        public void setDirection(char direction)
        {
            this.direction = direction;
        }
        public char getDirection()
        {
            return direction;
        }
        public bool setDirectionofLongi(char direction)
        {
            if (direction == 'W' || direction == 'E')
            {
                this.direction = direction;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setDirectionofLati(char direction)
        {
            if (direction == 'N' || direction == 'S')
            {
                this.direction = direction;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
