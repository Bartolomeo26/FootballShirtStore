﻿using FootballShirtStore.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballShirtStore.Entities
{
    public enum State
    {
        Accepted,
        Ongoing,
        Completed,
        Cancelled
    }
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? DateCompleted { get; set; }
        public ApplicationUser User { get; set; }
		[Required]
		public DeliveryMethod DeliveryMethod { get; set; }
		[Required]
		public PaymentMethod PaymentMethod { get; set; }
		public State State { get; set; } = State.Accepted;
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
    public enum DeliveryMethod
    {
        InPost,
        Courier,
        Orlen,
        DPD
    }

    public enum PaymentMethod
    {
        PayPal,
        MasterCard,
        Skrill,
        PaySafeCard
    }
}
