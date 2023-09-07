﻿using AutoMapper;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress
{
    public class AddAddressCommandHandler : IRequestHandler<AddAddressCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public AddAddressCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(AddAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithAddressAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if(selectedUser.Addresses.Count == 5)
                return new FailNoDataResponse();

            var addedAddress = _mapper.Map<Address>(request);

            if(selectedUser.Addresses.Count == 0)
                addedAddress.Selected = true;

            selectedUser.Addresses.Add(addedAddress);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}