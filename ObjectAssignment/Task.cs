﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAssignment
{
    public class Task
    {
        public string Desc { get; set; }
        public DateTime Finished { get; set; }

        public Task(string description)
        {
            this.Desc = description;
            // A task has a description and a datetime that contains null when the task isn't finished or the date of when the task is finished 
        }


        public void MarkAsFinished()
        {
            // finishedTimestamp = DateTime.Now;
        }

        public bool ItemFinished()
        {
            // Do some more here
            return false;
        }
    }
}
