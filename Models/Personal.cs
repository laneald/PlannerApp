using System;
namespace Planner_App.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public DateTime Birthday { get; set; }
        public int Personal_Id { get; set; }
    }
}