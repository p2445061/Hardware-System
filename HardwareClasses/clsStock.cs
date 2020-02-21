using System;

namespace HardwareClasses
{
    public class clsStock
    {
        public bool Available { get; set; }
        public DateTime DateAdded { get; set; }
        public object PartNo { get; set; }
        public int SupplierId { get; set; }
        public object PartDescription { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool Find(int PartNo)
        {
            return true;
        }
    }
}