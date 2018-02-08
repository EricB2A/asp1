using System;
using System.Collections.Generic;

namespace Scrasp.Models
{
    public class Story
    {
        private string description;
        private string refName;
        private string actor;
        private int type;
        private int state;
		private int points;    
        private List<Task> tasks;

        public Story(string description = null, string refName = null, string actor = null, int type = 0, int state = 0, int points = 0, List<Task> tasks = null)
        {
            this.description = description;
            this.refName = refName;
            this.actor = actor;
            this.type = type;
            this.state = state;
            this.points = points;
            this.tasks = tasks;
        }

        public string Description { get { return description; } }
        public string RefName { get { return refName; } }
        public string Actor { get { return actor; } }
        public int Type { get { return type; } }
        public int State { get { return state; } }
        public int Points { get { return points; } }
        public List<Task> Tasks { get { return tasks; } }
    }
}
