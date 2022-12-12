using Havit.Extensions.DependencyInjection.Abstractions;
using Havit.NewProjectTemplate.Contracts;
using Havit.NewProjectTemplate.DataLayer.Repositories.Common;

namespace Havit.NewProjectTemplate.Facades;

[Service]
public class CountryFacade : ICountryFacade
{
	private readonly ICountryRepository countryRepository;

	public CountryFacade(ICountryRepository countryRepository)
	{
		this.countryRepository = countryRepository;
	}

	public async Task<DataFragmentResult<CountryVM>> GetCountriesAsync(DataFragmentRequest<CountryVM> request, CancellationToken cancellationToken = default)
	{
		var countries = await countryRepository.GetAllAsync(cancellationToken);

		return new()
		{
			Data = countries.Skip(request.StartIndex).Take(request.Count ?? 0).Select(item => new CountryVM() { Id = item.Id, IsoCode = item.IsoCode }).ToList(),
			TotalCount = countries.Count
		};
	}
}
