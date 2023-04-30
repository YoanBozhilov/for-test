﻿namespace for_test.Models
{
    public class Event
    {
        public Event()
        {

        }
        public Event(int id, string name, string description, string picture, string premiereDate)
        {

            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
            PremiereDate = premiereDate;

        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public string PremiereDate { get; set; }

    }
}

