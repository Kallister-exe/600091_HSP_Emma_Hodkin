namespace Honours.Models
{
    public class User
    {
        public Guid ID { get; init; } // GUID data type used to make primary key
        public string Name { get; set; }
        public string Email { get; set; }
        public User(string name, string email) : this(Guid.NewGuid(), name, email) { }
        public User(Guid id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
