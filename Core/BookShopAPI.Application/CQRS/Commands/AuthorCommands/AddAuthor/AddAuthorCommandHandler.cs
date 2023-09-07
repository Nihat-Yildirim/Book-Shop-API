using AutoMapper;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor
{
    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public AddAuthorCommandHandler(IMapper mapper, IAuthorWriteRepository authorWriteRepository, IAuthorReadRepository authorReadRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _authorWriteRepository = authorWriteRepository;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseResponse> Handle(AddAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetSingleAsync(x => x.FirstName == request.FirstName && x.LastName == request.LastName && x.DeletedDate == null);

            if (selectedAuthor != null)
                return new FailNoDataResponse();

            var addedAuthor = _mapper.Map<Author>(request);
            await _authorWriteRepository.AddAsync(addedAuthor);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}