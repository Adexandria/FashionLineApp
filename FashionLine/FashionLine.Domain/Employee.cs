namespace FashionLine.Domain
{
    public class Employee :BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual Role EmployeeRole { get; set; }
        public virtual FashionLine FashionLine { get; set; }
    }
}
