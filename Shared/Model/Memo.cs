namespace Shared.Model
{
    public class Memo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public User Owner { get; set; }
        public List<User> Recipients { get; set; } = new List<User>();

        public Memo(User creator, string title, string content)
        {
            Owner = creator;
            Title = title;
            Content = content;
        }
    }
}