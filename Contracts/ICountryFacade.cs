namespace Havit.NewProjectTemplate.Contracts;

[ApiContract]
public interface ICountryFacade
{
	Task<DataFragmentResult<CountryVM>> GetCountriesAsync(DataFragmentRequest<CountryVM> request, CancellationToken cancellationToken = default);
}
