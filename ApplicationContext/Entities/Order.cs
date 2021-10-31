using System;

namespace ApplicationContext.Entities
{
    public class Order
    {
        public long OrderId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Cost { get; set; }
        public User User { get; set; }
        public long UserId { get; set; }
    }
}