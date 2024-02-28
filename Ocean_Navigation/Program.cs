using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.UI; 
using Ocean_Navigation.DL;

namespace Ocean_Navigation
{
    class Program
    {
       
        static void Main(string[] args)
        {
            if(OceanCRUD.ReadFromFile())
            {
                Console.WriteLine("Read Data Succesfully");
            }
            while (true)
            {
                string op = OceanUI.menu();
                if(op=="1")
                {
                   Ship S = OceanUI.Add_ship();
                    OceanCRUD.addShipstoLists(S);
                }
                else if(op=="2")
                {
                    OceanUI.disply_ship();
                }
                else if (op == "3")
                {
                    string name=OceanUI.searchhByAngle();
                    if(name!=null)
                    {
                        Console.WriteLine("Ship Name is : " + name);
                    }
                    else
                    {
                        Console.WriteLine("No Such Ship Available");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == "4")
                {
                    OceanUI.replace_ship();
                }
                else if (op == "5")
                {
                    OceanCRUD.StoreInFile();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input.....");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        
        
       
    }

}
