namespace FashionLine.Domain
{
    public class Order : BaseEntity
    {
        public virtual PaymentInformation PaymentInfo { get; set; }
        public virtual DateTime InitiationDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual List<Clothe> Clothes { get; set; }
        public virtual Customer Owner { get; set; }
        public virtual string DeliveryAddress { get; set; }
    }
}
