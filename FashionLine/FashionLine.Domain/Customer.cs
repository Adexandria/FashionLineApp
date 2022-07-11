namespace FashionLine.Domain
{
    public class Customer : BaseEntity
    {
        public virtual List<Order> Orders { get; set; }
        public virtual string Address { get; set; }
        public virtual FashionLine FashionLine { get; set; }
    }
}
