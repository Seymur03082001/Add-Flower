using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Flower
{
    internal class BucketClass
    {
        private Flower _flower;
        private uint _flowerCount;
        private float _discountPercent;
    }
    
    public uint FlowerCount
    {
        get => _flowerCount;
        set
        {
            if (value <20)
            {
                _flowerCount = value;
            }
        }
    }

    public float DiscountPercent
    {
        get => _discountPercent;
        set 
        {
            if (value >=0 && value <=100
            {
                _discountPercent= value;
            }
        }
    }
     public void AddFlower(Flower flower)
    {
        if(Add_Flower =flower)
        {
            FlowerCount++;
        }

    }
    public float GetTotal()
    {
        if(FlowerCount >= 1)
        {
            return _flowerCount;
        }
    }


}
