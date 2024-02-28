using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;

namespace Ocean_Navigation.UI
{
    class OceanUI
    {
        static public void header()
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                  Ocean Navigation                      ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("                                                        ");
        }
        static public string menu()
        {
            header();
            Console.WriteLine("[1]- Add Ship");
            Console.WriteLine("[2]- View Ship Position");
            Console.WriteLine("[3]- View Ship Serial Number");
            Console.WriteLine("[4]- Change Ship Position");
            Console.WriteLine("[5]- Exit");
            Console.Write("Your Option....");
            string o = Console.ReadLine();
            return o;
        }
        static public Ship Add_ship()
        {
            Console.Write("Enter Ship Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Ship Longitude....");
            Console.Write("Enter Longitude Degree : ");
            int LongiDeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes : ");
            float LongiMin = float.Parse(Console.ReadLine());
            char LongiDir;
            int x = 0;
            Angle A = new Angle();
            do
            {
                if(x>0)
                {
                    Console.WriteLine("Longitude Direction Could be Only W(West) or E(East");
                }
                Console.Write("Enter Longitude Direction : ");
                LongiDir = char.Parse(Console.ReadLine());
                x++;
                
            }
            while (!A.setDirectionofLongi(LongiDir));
            Angle longi = new Angle(LongiDeg, LongiMin, LongiDir);
            Console.WriteLine("Enter Ship Latitude....");
            Console.Write("Enter Latitude Degree : ");
            int LatiDeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Minutes : ");
            float LatiMin = float.Parse(Console.ReadLine());
            char LatiDir;
            x = 0;
            do
            {
                if (x > 0)
                {
                    Console.WriteLine("Latitude Direction Could be Only S(South) or N(North");
                }
                Console.Write("Enter Latitude Direction : ");
                LatiDir = char.Parse(Console.ReadLine());
                x++;

            }
            while (!A.setDirectionofLati(LatiDir));
          
            Angle lati = new Angle(LatiDeg, LatiMin, LatiDir);
            Ship S = new Ship(name, longi, lati);
            Console.Clear();
            return S;

        }
        static public void disply_ship()
        {
            Console.Write("Enter Ship Name : ");
            string s = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < OceanCRUD.Ships.Count; i++)
            {
                if (s == OceanCRUD.Ships[i].getName())
                {
                    flag = true;
                    Console.WriteLine("Ship is at " + OceanCRUD.Ships[i].getLongitude().getDegree() + "\u00b0" + OceanCRUD.Ships[i].getLongitude().getMinutes() + "\u00b0" + OceanCRUD.Ships[i].getLongitude().getDirection() + " and " + OceanCRUD.Ships[i].getLatitiude().getDegree() + "\u00b0" + OceanCRUD.Ships[i].getLatitiude().getMinutes() + "\u00b0" + OceanCRUD.Ships[i].getLatitiude().getDirection());
                }
            }
            if (flag == false)
            {
                Console.Write("No Such Ship Avilable");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static public string searchhByAngle()
        {
            Console.WriteLine("Enter Ship Longitude....");
            Console.Write("Enter Longitude Degree : ");
            int LongiDeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes : ");
            float LongiMin = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction : ");
            char LongiDir = char.Parse(Console.ReadLine());
            Angle longi = new Angle(LongiDeg, LongiMin, LongiDir);
            Console.WriteLine("Enter Ship Latitude....");
            Console.Write("Enter Latitude Degree : ");
            int LatiDeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Minutes : ");
            float LatiMin = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Direction : ");
            char LatiDir = char.Parse(Console.ReadLine());
            Angle lati = new Angle(LatiDeg, LatiMin, LatiDir);
            string name_Ship = OceanCRUD.ship_name(longi,lati);
            return name_Ship;
        }
        static public void replace_ship()
        {
            bool flag = false;
            Console.Write("Enter Ship Name : ");
            string s = Console.ReadLine();
            for (int i = 0; i < OceanCRUD.Ships.Count; i++)
            {
                if (s == OceanCRUD.Ships[i].getName())
                {
                    flag = true;
                    Console.WriteLine("Enter Ship Longitude....");
                    Console.Write("Enter Longitude Degree : ");
                    int LongiDeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Minutes : ");
                    float LongiMin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Direction : ");
                    char LongiDir = char.Parse(Console.ReadLine());
                    Angle longi = new Angle(LongiDeg, LongiMin, LongiDir);
                    Console.WriteLine("Enter Ship Latitude....");
                    Console.Write("Enter Latitude Degree : ");
                    int LatiDeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Minutes : ");
                    float LatiMin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Direction : ");
                    char LatiDir = char.Parse(Console.ReadLine());
                    Angle lati = new Angle(LatiDeg, LatiMin, LatiDir);
                    Ship S = new Ship(s,longi, lati);
                    OceanCRUD.Ships.RemoveAt(i);
                    OceanCRUD.Ships.Insert(i, S);
                    Console.Clear();
                    break;

                }
            }
            if (flag == false)
            {
                Console.WriteLine("No Such Ships Avilable");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
