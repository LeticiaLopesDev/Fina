namespace Fina.Core.Requests.Trasactions;

public class GetTrasanctionsByPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}