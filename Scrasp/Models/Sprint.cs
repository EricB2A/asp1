using System;
using System.Collections.Generic;

namespace Scrasp.Models
{
    public class Sprint
    {
        private int number;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private List<Story> stories;
    
        public Sprint(int number, string description, DateTime startDate, DateTime endDate, List<Story> stories)
        {
            this.number = number;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.stories = stories;
        }

        public int Number { get { return number; } }
        public string Description { get { return description; } }
        public DateTime StartDate { get { return startDate; } }
        public DateTime EndDate { get { return endDate; } }
        public List<Story> Stories { get { return stories; } }
    }
}
