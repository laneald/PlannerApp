using System;

namespace Planner_App.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public bool Importance { get; set; }
        public DateTime DateDue { get; set; }
        public int DueTime { get; set; }
        public int Task_Id { get; set; }
    }
}