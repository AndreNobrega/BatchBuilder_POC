using System;

namespace Domain.Entities
{
    public class Memo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Person Owner { get; set; }
        public List<Person> Recipients { get; set; } = new List<Person>();

        public Memo(Person creator, string title, string content)
        {
            Owner = creator;
            Title = title;
            Content = content;
        }
    }
}