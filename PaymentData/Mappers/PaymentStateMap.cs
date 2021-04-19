using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentSolution.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentData.Mappers
{
    public class PaymentStateMap
    {
        public PaymentStateMap(EntityTypeBuilder<PaymentState> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id); 
            entityBuilder.Property(t => t.PaymentStatus).IsRequired(); 
            entityBuilder.HasOne(e => e.Card).WithMany(e => e.PaymentStates).HasForeignKey(e => e.CardId); 
        }
    }
    }
