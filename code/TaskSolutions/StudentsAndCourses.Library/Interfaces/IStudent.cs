namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
