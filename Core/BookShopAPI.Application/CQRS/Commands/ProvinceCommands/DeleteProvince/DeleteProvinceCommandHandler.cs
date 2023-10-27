using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.DeleteProvince
{
    public class DeleteProvinceCommandHandler : IRequestHandler<DeleteProvinceCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProvinceReadRepository _provinceReadRepository;

        public DeleteProvinceCommandHandler(IUnitOfWork unitOfWork, IProvinceReadRepository provinceReadRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceReadRepository = provinceReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteProvinceCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedProvince = await _provinceReadRepository.GetByIdAsync(request.Id);
            if (selectedProvince == null)
                return new FailNoDataResponse();

            selectedProvince.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}