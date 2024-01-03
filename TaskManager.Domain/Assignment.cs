﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CreatorId { get; set; }
        public User Creator { get; set; }
        public int AssigneeId {  get; set; }
        public User Assignee { get; set; }
        public AssignmentStatusType Status { get; set; }
    }
}
