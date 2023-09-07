using AutoMapper;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.AddPhoneNumber
{
    public class AddPhoneNumberCommandHandler : IRequestHandler<AddPhoneNumberCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public AddPhoneNumberCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(AddPhoneNumberCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithPhoneNumberAsync(x => x.Id == request.UserId);
            
            if (selectedUser == null)
                return new FailNoDataResponse();

            if (selectedUser.PhoneNumbers.Count == 5)
                return new FailNoDataResponse();

            var addedPhoneNumber = _mapper.Map<PhoneNumberEntity>(request);

            if(selectedUser.PhoneNumbers.Count == 0)
                addedPhoneNumber.Selected = true;

            selectedUser.PhoneNumbers.Add(addedPhoneNumber);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}