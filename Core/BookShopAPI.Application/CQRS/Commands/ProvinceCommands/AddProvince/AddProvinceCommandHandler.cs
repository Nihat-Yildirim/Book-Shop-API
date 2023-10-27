using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.AddProvince
{
    public class AddProvinceCommandHandler : IRequestHandler<AddProvinceCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProvinceReadRepository _provinceReadRepository;
        private readonly IProvinceWriteRepository _provinceWriteRepository;

        public AddProvinceCommandHandler(IUnitOfWork unitOfWork, IProvinceWriteRepository provinceWriteRepository, IProvinceReadRepository provinceReadRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceReadRepository = provinceReadRepository;
            _provinceWriteRepository = provinceWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddProvinceCommandRequest request, CancellationToken cancellationToken)
        {
            bool isNameExists = await _provinceReadRepository.AnyAsync(x => x.Name == request.Name);
            if (isNameExists)
                return new FailNoDataResponse();

            Province province = new();
            province.Name = request.Name;

            await _provinceWriteRepository.AddAsync(province);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}