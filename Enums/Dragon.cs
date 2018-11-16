﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum DragonType { Red = 1, Frost, Elder, Blue, Gold}
    class Dragon
    {
        public DragonType TypeOfDragon { get; set; }
        public bool BreathesFire { get; set; }
        public bool IsScary { get; set; }
        public int AmountOfGold { get; set; }



    }
}
