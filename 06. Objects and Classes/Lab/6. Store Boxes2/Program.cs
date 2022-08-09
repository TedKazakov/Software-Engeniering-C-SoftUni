using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
            while (data[0] != "end")
            {
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                Item item = new Item(itemName, itemPrice);  
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);


                data = Console.ReadLine().Split();
            }
            List<Box> orderedboxes = boxes.OrderByDescending(box => box.PiceForABox).ToList();
            foreach (Box box in orderedboxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PiceForABox:f2}");
            }
        }
    }
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        //Serial Number, Item, Item Quantity and Price for a Box
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PiceForABox
        {
            get
            {
                return Item.Price * ItemQuantity;
            }
        }
    }
}
