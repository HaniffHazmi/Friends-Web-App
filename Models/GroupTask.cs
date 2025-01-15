namespace Friends_Web_App.Models
{
    public class GroupTask
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Priority { get; set; }
        public required DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
    }
}
