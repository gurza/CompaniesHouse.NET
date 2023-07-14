using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Request;
using CompaniesHouse.Response.Search.CompanySearch;

namespace CompaniesHouse
{
    public interface ICompaniesHouseSearchCompanyClient
    {
        Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(SearchCompanyRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}