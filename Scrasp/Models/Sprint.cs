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
    
        public Sprint(int number = 0, string description = null, DateTime? startDate = null, DateTime? endDate = null, List<Story> stories = null)
        {
            this.number = number;
            this.description = description;
            this.startDate = startDate ?? DateTime.MinValue;
            this.endDate = endDate ?? DateTime.MinValue;
            this.stories = stories;
        }

        public int Number { get { return number; } }
        public string Description { get { return description; } }
        public DateTime StartDate { get { return startDate; } }
        public DateTime EndDate { get { return endDate; } }
        public List<Story> Stories { get { return stories; } }
    }
}
