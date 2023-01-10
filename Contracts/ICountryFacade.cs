namespace Havit.NewProjectTemplate.Contracts;

[ApiContract(RequireAuthorization = false)]
public interface ICountryFacade
{
	Task<DataFragmentResult<CountryVM>> GetCountriesAsync(DataFragmentRequest<CountryVM> request, CancellationToken cancellationToken = default);
}
