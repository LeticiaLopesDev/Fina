using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Trasactions;

public class UpdateTransactionRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Valor Inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categória Inválida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data Inválida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}