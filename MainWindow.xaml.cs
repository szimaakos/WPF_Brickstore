using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows;

namespace WPF_Brickstore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Item> items = new List<Item>();

        public MainWindow()
        {
            InitializeComponent();

            ReadXamlFile();
        }

        private void ReadXamlFile()
        {
            
            XDocument xaml = XDocument.Load("brickstore_parts_7288-1-mobile-police-unit.bsx");

            foreach (var elem in xaml.Descendants("Item"))
            {
                Item item = new Item
                {
                    ItemID = elem.Element("ItemID").Value,
                    ItemTypeID = elem.Element("ItemTypeID").Value,
                    ColorID = elem.Element("ColorID").Value,
                    ItemName = elem.Element("ItemName").Value,
                    ItemTypeName = elem.Element("ItemTypeName").Value,
                    ColorName = elem.Element("ColorName").Value,
                    CategoryID = elem.Element("CategoryID").Value,
                    CategoryName = elem.Element("CategoryName").Value,
                    Status = elem.Element("Status").Value,
                    Qty = int.Parse(elem.Element("Qty").Value),
                    Price = decimal.Parse(elem.Element("Price").Value),
                    Condition = elem.Element("Condition").Value,
                    OrigQty = int.Parse(elem.Element("OrigQty").Value)
                };

                items.Add(item);
            }

         
            foreach (var item in items)
            {
                Console.WriteLine(item.ItemName);
            }
        }
    }
} //