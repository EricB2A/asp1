using System;
using System.Collections.Generic;

namespace Scrasp.Models
{
    public class Projet
    {
        private string title;
        private string description;
        private string refRepo;
        private List<User> team;
        private List<Sprint> sprints;

        public Projet(string title, string description, string refRepo, List<User> team, List<Sprint> sprints)
        {
            this.title = title;
            this.description = description;
            this.refRepo = refRepo;
            this.team = team;
            this.sprints = sprints;
        }

        public string Title { get { return title; } }
        public string Description { get { return description; } }
        public string RefRepo { get { return refRepo; } }
        public List<User> Team { get { return team; } }
        public List<Sprint> Sprints { get { return sprints; } }

    }
}
