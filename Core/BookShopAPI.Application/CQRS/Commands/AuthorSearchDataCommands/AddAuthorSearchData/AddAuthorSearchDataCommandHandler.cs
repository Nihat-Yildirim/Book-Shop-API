using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.AuthorSearchDataRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorSearchDataCommands.AddAuthorSearchData
{
    public class AddAuthorSearchDataCommandHandler : IRequestHandler<AddAuthorSearchDataCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorSearchDataWriteRepository _authorSearchDataWriteRepository;

        public AddAuthorSearchDataCommandHandler(IUnitOfWork unitOfWork, IAuthorReadRepository authorReadRepository, IAuthorSearchDataWriteRepository authorSearchDataWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _authorReadRepository = authorReadRepository;
            _authorSearchDataWriteRepository = authorSearchDataWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddAuthorSearchDataCommandRequest request, CancellationToken cancellationToken)
        {
            bool isAuthorExists = await _authorReadRepository.AnyAsync(x => x.Id == request.AuthorId);
            if (!isAuthorExists)
                return new FailNoDataResponse();

            AuthorSearchData authorSearchData = new();
            authorSearchData.AuthorId = request.AuthorId;

            await _authorSearchDataWriteRepository.AddAsync(authorSearchData);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();  
        }
    }
}