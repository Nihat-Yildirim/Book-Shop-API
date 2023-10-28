using AutoMapper;
using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
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
        private readonly IProvinceReadRepository _provinceReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public AddAddressCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IMapper mapper, IProvinceReadRepository provinceReadRepository, IDistrictReadRepository districtReadRepository, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _provinceReadRepository = provinceReadRepository;
            _districtReadRepository = districtReadRepository;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseResponse> Handle(AddAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithAddressAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if (selectedUser.Addresses.Count == 5)
                return new FailNoDataResponse();

            bool isProvinceExists = await _provinceReadRepository.AnyAsync(x => x.Id == request.ProvinceId && x.DeletedDate == null);
            if(!isProvinceExists)
                return new FailNoDataResponse();

            bool isDistrictExists = await _districtReadRepository.AnyAsync(x => x.Id == request.DistrictId && x.DeletedDate == null && x.ProvinceId == request.ProvinceId);
            if(!isDistrictExists)
                return new FailNoDataResponse();

            bool isNeighbourhoodExists = await _neighbourhoodReadRepository.AnyAsync(x => x.Id == request.NeighbourhoodId && x.DeletedDate == null && x.DistrictId == request.DistrictId);
            if(!isNeighbourhoodExists)
                return new FailNoDataResponse();

            var addedAddress = _mapper.Map<Address>(request);
            if (selectedUser.Addresses.Count == 0)
                addedAddress.Selected = true;

            selectedUser.Addresses.Add(addedAddress);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}