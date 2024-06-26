﻿using RemoteWorkProductivityTracker.Models.Data.Entities;

namespace RemoteWorkProductivityTracker.Areas.Identity.Data
{
    public class TrackerTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        private string Description { get; set; }
        private bool Compleate { get; set; }
        private List<User> Users { get; set; }
        private List<TrackerTask>? SubTasks { get; set; } //ptional subtask addition
    }
}
