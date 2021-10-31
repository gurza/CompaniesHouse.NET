using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IChargesUriBuilder
    {
        Uri Build(string companyNumber, int startIndex, int pageSize);
        Uri Build(string companyNumber, string chargeId);
    }
}