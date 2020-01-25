using System;

namespace MassTransit.Messages
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Message (int id, string content, DateTime date)
        {
            Id = id;
            Content = content;
            Date = date;
        }

    }
}
