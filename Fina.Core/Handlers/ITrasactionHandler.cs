using Fina.Core.Models;
using Fina.Core.Requests.Trasactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers;

public interface ITrasactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<Response<List<Transaction>?>> GetByPeriodAsync(GetTrasanctionsByPeriodRequest request);
}