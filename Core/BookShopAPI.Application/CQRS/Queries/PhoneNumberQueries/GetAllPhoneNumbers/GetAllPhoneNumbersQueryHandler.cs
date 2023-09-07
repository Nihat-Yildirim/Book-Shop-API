using AutoMapper;
using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Application.Repositories.PhoneNumberRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetAllPhoneNumbers
{
    public class GetAllPhoneNumbersQueryHandler : IRequestHandler<GetAllPhoneNumbersQueryRequest, BaseDataResponse<List<PhoneNumberForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPhoneNumberReadRepository _phoneNumberReadRepository;

        public GetAllPhoneNumbersQueryHandler(IPhoneNumberReadRepository phoneNumberReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _phoneNumberReadRepository = phoneNumberReadRepository;
        }

        public async Task<BaseDataResponse<List<PhoneNumberForAdminDto>>> Handle(GetAllPhoneNumbersQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneNumbers = await _phoneNumberReadRepository.GetAll(false).ToListAsync();
            var responsePhoneNumber = _mapper.Map<List<PhoneNumberForAdminDto>>(phoneNumbers);

            return new SuccessDataResponse<List<PhoneNumberForAdminDto>>(responsePhoneNumber);
        }
    }
}