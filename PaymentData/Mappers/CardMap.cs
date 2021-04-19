using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentData.Mappers
{
    public class CardMap
    {
        public CardMap(EntityTypeBuilder<Card> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.CreditCardNumber).IsRequired();
            entityBuilder.Property(t => t.CardHolder).IsRequired();
            entityBuilder.Property(t => t.SecurityCode);
            entityBuilder.Property(t => t.Amount).IsRequired();
            entityBuilder.Property(t => t.AddedDate).IsRequired();
        }
    }
}
