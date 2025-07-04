using System;
using System.Collections.Generic;

namespace Array;

class Program
{
    static void Main(string[] args)
    {
        var t = new Aggregate();

        Console.WriteLine("Print con foreach su t.OrderItems");
        foreach (var item in t.OrderItems)
            Console.WriteLine(item.ToString());
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Print con t.PrintAll()");
        t.PrintAll();

        ((List<Item>)t.OrderItems).Add(new Item(2, "Item2"));
        t.Add(new Item(3, "Item3"));

        Console.WriteLine("\n\n");

        Console.WriteLine("Print con foreach su t.OrderItems");
        foreach (var item in t.OrderItems)
            Console.WriteLine(item.ToString());
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Print con t.PrintAll()");
        t.PrintAll();
    }


    public class Aggregate
    {

        private readonly List<Item> _orderItems;
        public IReadOnlyCollection<Item> OrderItems => _orderItems;

        public Aggregate()
        {
            _orderItems = new List<Item> { new Item(0, "Item0"), new Item(1, "Item1") };
        }

        public void PrintAll()
        {
            foreach (var item in _orderItems)
                Console.WriteLine(item.ToString());
        }

        public void Add(Item item)
        {
            _orderItems.Add(item);
        }
    }

    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name}";
        }
    }
}
