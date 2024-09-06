using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Brickstore
{
    internal class Item
    {
        public string ItemID { get; set; }
        public string ItemTypeID { get; set; }
        public string ColorID { get; set; }
        public string ItemName { get; set; }
        public string ItemTypeName { get; set; }
        public string ColorName { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public int OrigQty { get; set; }
    }
}
