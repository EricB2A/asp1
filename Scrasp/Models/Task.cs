using System;
namespace Scrasp.Models
{
    public class Task
    {
        private int description;
        private int state;
        private User owner;
        private DateTime plannedStart;
        private int plannedDuration;

        public Task(int description, int state, User owner, DateTime plannedStart, int plannedDuration)
        {
            this.description = description;
            this.state = state;
            this.owner = owner;
            this.plannedStart = plannedStart;
            this.plannedDuration = plannedDuration;
        }

        public int Description { get { return description; } }
        public int State { get { return state; } }
        public User Owner { get { return owner; } }
        public DateTime PlannedStart { get { return plannedStart; } }
        public int PlannedDuration { get { return plannedDuration; } }
    }
}

