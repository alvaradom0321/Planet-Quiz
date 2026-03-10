using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Planet
    {
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string image_file { get; set; }


        public Planet()
        {
            name = "";
            size = "";
            type = "";
            image_file = "";

        }

        public Planet( string initName, string initSize, string initType, string initImage_file)
        {
            name = initName;
            size = initSize;
            type = initType;
            image_file = initImage_file;    
        }

        public string getName() { return name; }
        public string getSize() { return size; }    

        public string getType() { return type; }    

        public string getImage_file() { return image_file; }    



        public override string ToString()
        {
            return name + " is the " + size + " planet. Planet type: " + type;
        }






    }
}
