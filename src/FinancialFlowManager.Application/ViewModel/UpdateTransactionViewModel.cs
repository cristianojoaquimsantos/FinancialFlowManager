using System.ComponentModel.DataAnnotations;

namespace FinancialFlowManager.Application.ViewModel
{
    public class UpdateTransactionViewModel
    {
        [Required(ErrorMessage = "Transaction ID is required.")]
        public Guid Id { get; set; } // Identificador único da transação.

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(255, ErrorMessage = "Description must be less than 255 characters.")]
        public string Description { get; set; } = string.Empty; // Descrição editável.

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; } // Valor da transação.

        [Required(ErrorMessage = "Transaction date is required.")]
        public DateTimeOffset TransactionDate { get; set; } // Data editável da transação.

        [Required(ErrorMessage = "Payment method is required.")]
        [StringLength(100, ErrorMessage = "Payment method must be less than 100 characters.")]
        public string PaymentMethod { get; set; } = string.Empty; // Método de pagamento.

        [Required(ErrorMessage = "Category ID is required.")]
        public Guid CategoryId { get; set; } // Categoria editável da transação.

        [Required(ErrorMessage = "Financial account ID is required.")]
        public Guid FinancialAccountId { get; set; } // Conta financeira associada editável.

        [EnumDataType(typeof(TransactionStatus), ErrorMessage = "Invalid status value.")]
        public TransactionStatus Status { get; set; } // Status editável da transação.

        [StringLength(500, ErrorMessage = "Notes must be less than 500 characters.")]
        public string? Notes { get; set; } // Observações opcionais.
    }
}
