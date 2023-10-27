using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.UpdateProvince
{
    public class UpdateProvinceCommandHandler : IRequestHandler<UpdateProvinceCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProvinceReadRepository _provinceReadRepository;

        public UpdateProvinceCommandHandler(IUnitOfWork unitOfWork, IProvinceReadRepository provinceReadRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceReadRepository = provinceReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateProvinceCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedProvince = await _provinceReadRepository.GetByIdAsync(request.ProvinceId);
            if (selectedProvince == null)
                return new FailNoDataResponse();

            selectedProvince.Name = request.Name;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();  
        }
    }
}