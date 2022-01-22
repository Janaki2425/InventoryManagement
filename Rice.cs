using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Rice
    {
        public List<TypesOfRice> typesofRice;
        public List<TypesOfWheat> typesofWheat;
        public List<TypesOfPulses> typesofPulses;
    }

    public class TypesOfRice
    {
        public String name;
        public int weight;
        public String price;
    }
        public class TypesOfWheat
        {
            public String name;
            public int weight;
            public String price;
        }
        public class TypesOfPulses
        {
            public String name;
            public int weight;
            public String price;
        }
    }

