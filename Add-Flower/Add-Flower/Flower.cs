using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Flower
{
    internal class Flower
    {
        private string _name;
        private string _color;
        private float _price;

        public string Name
        {
            get => Name;
            set
            {
                if(value.Trim().Length >=3)
                {
                    _name= value.Trim();
                }
            }
        }
        
        public float Price
        {
            get => Price;
            set 
            {
                if (value >0.09f)
                {
                    _price = value;
                }
            }
        }


    }
}
