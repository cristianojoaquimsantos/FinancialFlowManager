using System;

namespace FinancialFlowManager.Application.ViewModel
{
    public class TransactionViewModel
    {
        public TransactionViewModel()
        {
            
        }

        public Guid UserId { get; set; }
        public Guid AssociatedAccountId { get; set; }
        public Guid ConsolidationId { get; set; }
        public Guid CategoryId { get; set; } // Reference to the category (Credit/Debit)
        public string Description { get; set; } = string.Empty; // Avoid nullability issues
        public decimal Amount { get; set; }
        public DateTimeOffset TransactionDate { get; set; } // Supports time zones
        public string PaymentMethod { get; set; } = string.Empty; // Payment method details
        public string? SourceIdentifier { get; set; } // Optional identifier for external systems
        public TransactionStatus Status { get; set; } // Enum for transaction status

        // Navigation properties
        public FinancialAccountViewModel? AssociatedAccount { get; set; }
        public TransactionCategoryViewModel? TransactionCategory { get; set; }
        public DailyConsolidationViewModel? DailyConsolidation { get; set; }
        public UserViewModel? UserViewModel { get; set; }
    }

    public enum TransactionStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}
