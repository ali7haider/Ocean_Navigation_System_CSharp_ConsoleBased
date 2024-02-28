using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ocean_Navigation.BL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.DL
{
    class OceanCRUD
    {
        static public List<Ship> Ships = new List<Ship>();
        static public void addShipstoLists(Ship s)
        {
            Ships.Add(s);
        }
        static public string ship_name(Angle longi,Angle lati)
        {
            foreach (Ship s in Ships)
            {
                if(s.getLongitude().getDegree()==longi.getDegree() && s.getLongitude().getMinutes()==longi.getMinutes() && s.getLongitude().getDirection()==longi.getDirection() && s.getLatitiude().getDegree() == lati.getDegree() && s.getLatitiude().getMinutes() == lati.getMinutes() && s.getLatitiude().getDirection() == lati.getDirection())
                {
                    return s.getName();
                }
            }
            return null;
        }
        static public void StoreInFile()
        {
            string path = "ships.txt";
            StreamWriter file = new StreamWriter(path,true);
            foreach (Ship S in Ships)
            {
                file.WriteLine(S.getName() + "," + S.getLongitude().getDegree() + "," + S.getLongitude().getMinutes() + "," + S.getLongitude().getDirection() + "," + S.getLatitiude().getDegree() + "," + S.getLatitiude().getMinutes() + "," + S.getLatitiude().getDirection());
            }
            file.Flush();
            file.Close();

        }
        static public bool ReadFromFile()
        {
            string path = "ships.txt";
            StreamReader file = new StreamReader(path);
            string record = "";
            if(File.Exists(path))
            {
                while((record=file.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int LogiD = int.Parse(splittedRecord[1]);
                    float LogiM = float.Parse(splittedRecord[2]);
                    char LogiDirec = char.Parse(splittedRecord[3]);
                    Angle A1 = new Angle(LogiD, LogiM, LogiDirec);
                    int LatiD = int.Parse(splittedRecord[4]);
                    float LatiM = float.Parse(splittedRecord[5]);
                    char LatiDirec = char.Parse(splittedRecord[6]);
                    Angle A2 = new Angle(LatiD, LatiM, LatiDirec);
                    Ship S = new Ship(name, A1, A2);
                    addShipstoLists(S);

                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
