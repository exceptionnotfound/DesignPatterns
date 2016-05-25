using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    /// <summary>
    /// The Receiver abstract class
    /// </summary>
    public abstract class Order
    {
        List<MenuItem> items { get; set; }
    }

    /// <summary>
    /// The Invoker
    /// </summary>
    public class FastFoodOrder : Order
    {
        List<MenuItem> currentItems { get; set; }
        public FastFoodOrder()
        {
            currentItems = new List<MenuItem>();
        }

        public void SubmitCommand(int commandOption, MenuItem item)
        {
            OrderCommand command = new CommandFactory().GetCommand(commandOption);
            command.Execute(currentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach(var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }

    }

    /// <summary>
    /// Represents an item being ordered from this restaurant.
    /// </summary>
    public class MenuItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + Amount.ToString());
            Console.WriteLine("Price: $" + Price.ToString());
        }
    }

    /// <summary>
    /// The Command interface
    /// </summary>
    public abstract class OrderCommand
    {
        public abstract List<MenuItem> Execute(List<MenuItem> currentItems, MenuItem newItem);
    }

    /// <summary>
    /// A concrete command
    /// </summary>
    public class AddCommand : OrderCommand
    {
        public override List<MenuItem> Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
            return currentItems;
        }
    }

    /// <summary>
    /// A concrete command
    /// </summary>
    public class RemoveCommand : OrderCommand
    {
        public override List<MenuItem> Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Remove(currentItems.Where(x=>x.Name == newItem.Name).First());
            return currentItems;
        }
    }

    /// <summary>
    /// A concrete command
    /// </summary>
    public class ModifyCommand : OrderCommand
    {
        public override List<MenuItem> Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
            return currentItems;
        }
    }

    public class CommandFactory
    {
        //Factory method
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                case 3:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }
}
