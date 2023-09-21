namespace ToDoApp.Model
{
    public class ToDoItemModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Completed { get; set; }
        public DateTime Date { get; set; }

    }
}