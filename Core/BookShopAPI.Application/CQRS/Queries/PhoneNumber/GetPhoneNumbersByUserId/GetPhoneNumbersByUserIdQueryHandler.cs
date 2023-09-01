using AutoMapper;
using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Application.Repositories.PhoneNumberRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetPhoneNumbersByUserId
{
    public class GetPhoneNumbersByUserIdQueryHandler : IRequestHandler<GetPhoneNumbersByUserIdQueryRequest, BaseDataResponse<List<PhoneNumberDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPhoneNumberReadRepository _phoneNumberReadRepository;

        public GetPhoneNumbersByUserIdQueryHandler(IMapper mapper, IPhoneNumberReadRepository phoneNumberReadRepository)
        {
            _mapper = mapper;
            _phoneNumberReadRepository = phoneNumberReadRepository;
        }

        public async Task<BaseDataResponse<List<PhoneNumberDto>>> Handle(GetPhoneNumbersByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneNumbers = await _phoneNumberReadRepository.GetWhere(x => x.UserId == request.UserId).ToListAsync();
        
            var responsePhoneNumbers = _mapper.Map<List<PhoneNumberDto>>(phoneNumbers);

            return new SuccessDataResponse<List<PhoneNumberDto>>(responsePhoneNumbers);
        }
    }
}