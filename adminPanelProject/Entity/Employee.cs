namespace adminPanelProject.Entity
{
    public class Employee
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string Performance { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public long Mobile { get; set; }
    }
}
