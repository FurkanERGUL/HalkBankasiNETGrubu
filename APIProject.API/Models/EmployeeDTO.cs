namespace APIProject.API.Models
{
    public record EmployeeDTO
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Department { get; init; }
    }
}
