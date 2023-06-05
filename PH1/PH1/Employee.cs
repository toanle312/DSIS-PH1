namespace PH1
{
    internal class Employee
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime Birthday { get; set; } = DateTime.Now;
        public string Address { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Salary { get; set; } = "";
        public string Allowance { get; set; } = "";
        public string Role { get; set; } = "";
        public string ManagerId { get; set; } = "";
        public string Department { get; set; } = "";
    }
}