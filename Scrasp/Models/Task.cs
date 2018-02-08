using System;
namespace Scrasp.Models
{
    public class Task
    {
        private string description;
        private int state;
        private User owner;
        private DateTime plannedStart;
        private int plannedDuration;
        private string description1;

        public Task(string description = null, int state = 0, User owner = null, DateTime? plannedStart = null, int plannedDuration = 0)
        {
            this.description = description;
            this.state = state;
            this.owner = owner;
            this.plannedStart = plannedStart ?? DateTime.MinValue;
            this.plannedDuration = plannedDuration;
        }

        public string Description { get { return description; } }
        public int State { get { return state; } }
        public User Owner { get { return owner; } }
        public DateTime PlannedStart { get { return plannedStart; } }
        public int PlannedDuration { get { return plannedDuration; } }
    }
}

