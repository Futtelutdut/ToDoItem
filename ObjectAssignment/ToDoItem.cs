using System;
using System.Collections.Generic;

// Description on this class => look at Controller for inspiration

namespace ObjectAssignment
{
    public class ToDoItem
    {
        List<Task> tasks;
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime ItemDeadline { get; set; }

        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            tasks = new List<Task>();
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
            this.ItemDeadline = itemDeadline;
            AddTask(firstTaskDescription);
            // Do some more here
        }
        public void PrintFirstTask() {
            Console.WriteLine(tasks[0].Desc);
        }

        public void AddTask(string TaskDescription)
        {
            tasks.Add(new Task(TaskDescription));
            // Do some more here
        }

        public bool ItemFinished()
        {
            // Do some more here
            return false;
        }

        public bool DeadlineExceeded()
        {
            // Do some more here
            return false;
        }

        public string GetItemReport()
        {
            return "ToDoItem.GetItemReport()";
        }
    }
}
