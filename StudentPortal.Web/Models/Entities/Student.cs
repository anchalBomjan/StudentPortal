namespace StudentPortal.Web.Models.Entities
{
    public class Student
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
