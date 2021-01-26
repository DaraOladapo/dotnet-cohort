namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface ICourse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
