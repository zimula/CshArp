namespace ToDoApi.Models
{

    //limit access to data
    public class TodoitemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
