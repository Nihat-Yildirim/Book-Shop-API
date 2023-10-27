using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.AddDistrict
{
    public class AddDistrictCommandHandler : IRequestHandler<AddDistrictCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProvinceReadRepository _provinceReadRepository;
        private readonly IDistrictWriteRepository _districtWriteRepository;
        private readonly IDistrictReadRepository _districtReadRepository;

        public AddDistrictCommandHandler(IUnitOfWork unitOfWork, IProvinceReadRepository provinceReadRepository, IDistrictWriteRepository districtWriteRespository, IDistrictReadRepository districtReadRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceReadRepository = provinceReadRepository;
            _districtWriteRepository = districtWriteRespository;
            _districtReadRepository = districtReadRepository;
        }

        public async Task<BaseResponse> Handle(AddDistrictCommandRequest request, CancellationToken cancellationToken)
        {
            bool isExists = await _provinceReadRepository.AnyAsync(x => x.Id == request.ProvinceId);
            if (!isExists)
                return new FailNoDataResponse();

            var isNameExists = await _districtReadRepository.AnyAsync(x => x.ProvinceId == request.ProvinceId && x.Name == request.Name);
            if (isNameExists)
                return new FailNoDataResponse();

            District addedDistrict = new();
            addedDistrict.ProvinceId = request.ProvinceId;
            addedDistrict.Name = request.Name;

            await _districtWriteRepository.AddAsync(addedDistrict);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}