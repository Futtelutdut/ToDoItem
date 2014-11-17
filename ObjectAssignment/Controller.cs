using System;
using System.Collections.Generic;

namespace ObjectAssignment
{
    public class Controller
    {
        List<ToDoItem> _items;

        public Controller()
        {
            _items = new List<ToDoItem>();
            // Consider what must be done in this constructor
        }
        public void PrintFirst() {
            Console.WriteLine(_items[0].ShortDescription);
            _items[0].PrintFirstTask();
            
        }

        public void AddNewToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            _items.Add(new ToDoItem(shortDescription, longDescription, itemDeadline, firstTaskDescription));
            // A to do item contains 
            // a short description
            // a long description
            // a deadline
            // and one or more tasks that each contains a description
        }

        /// <summary>
        /// Creates a report on Items
        /// </summary>
        /// <param name="OnlyNotfinished">True = Items that aren't finished</param>
        /// <returns>The report in one string</returns>
        public string GetAllItemReports(bool OnlyNotfinished = false)
        {
            // Do some more here
            return "Controller.GetAllItemReports()";
        }
    }
}
