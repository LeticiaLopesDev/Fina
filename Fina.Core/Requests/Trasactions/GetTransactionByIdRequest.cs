using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Trasactions;

public class GetTransactionByIdRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}