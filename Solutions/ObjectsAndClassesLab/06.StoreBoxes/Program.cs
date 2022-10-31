using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while(input != "end")
            {
                string[] details = input.Split(" ");

                Box box = new Box();

                box.SerialNumber = int.Parse(details[0]);

                Item item = new Item();

                item.Name = details[1];
                item.Price = double.Parse(details[3]);

                box.Item = item;

                box.ItemQuantity = int.Parse(details[2]);

                boxes.Add(box);

                input = Console.ReadLine();
            }

            List<double> boxPrices = boxes.Select(box => box.Item.Price * box.ItemQuantity).ToList();

            int len = boxes.Count;

            for (int i = 0; i < len; i++)
            {
                int index = boxPrices.IndexOf(boxPrices.Max());

                Console.WriteLine($"{boxes[index].SerialNumber}");
                Console.WriteLine($"-- {boxes[index].Item.Name} - ${boxes[index].Item.Price:f2}: {boxes[index].ItemQuantity}");
                Console.WriteLine($"-- ${boxPrices[index]:f2}");
                boxPrices.RemoveAt(index);
                boxes.RemoveAt(index);
            }
        }
    }

    public class Box
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForABox { get; set; }
    }
    
    public class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
