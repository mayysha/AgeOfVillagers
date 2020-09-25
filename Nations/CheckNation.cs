﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class CheckNation
    {
        public INation GetNation(String name)
        {
            if (name == "Bangladeshi Farmers")
                return new BangladeshiFarmers();
            else if (name == "Arab Bedouin")
                return new ArabBedouins();
            else if (name == "Egyptian Kings")
                return new EgyptianKings();
            else if (name == "Inuit Hunters")
                return new InuitHunters();
            else
                return new NullNation();
  

        }
    }
}
