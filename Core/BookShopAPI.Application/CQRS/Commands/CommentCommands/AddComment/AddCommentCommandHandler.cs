using AutoMapper;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.AddComment
{
    public class AddCommentCommandHandler : IRequestHandler<AddCommentCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICommentReadRepository _commendReadRepository;
        private readonly ICommentWriteRepository _commendWriteRepository;
        private readonly IUserClaimReadRepository _userClaimReadRepository;

        public AddCommentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, ICommentReadRepository commendReadRepository, ICommentWriteRepository commendWriteRepository, IBookReadRepository bookReadRepository, IUserClaimReadRepository userClaimReadRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _userReadRepository = userReadRepository;
            _commendReadRepository = commendReadRepository;
            _commendWriteRepository = commendWriteRepository;
            _userClaimReadRepository = userClaimReadRepository;
        }

        public async Task<BaseResponse> Handle(AddCommentCommandRequest request, CancellationToken cancellationToken)
        {
            bool anyUser = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.DeletedDate == null);
            if (!anyUser)
                return new FailNoDataResponse();

            bool anyUserClaim = await _userClaimReadRepository.AnyAsync(x => x.UserId == request.UserId && x.ClaimId == (int)Claims.Admin);
            if(anyUserClaim)
                return new FailNoDataResponse();

            bool anyBook = await _bookReadRepository.AnyAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if(!anyBook)
                return new FailNoDataResponse();

            if(request.ParentCommentId == 0)
            {
                bool anyUserComment = await _commendReadRepository.AnyAsync(x => x.UserId == request.UserId && x.BookId == request.BookId && x.ParentCommentId == 0 && x.DeletedDate == null);
                if (anyUserComment)
                    return new FailNoDataResponse();
            }

            if(request.ParentCommentId != 0)
            {
                bool anyComment = await _commendReadRepository.AnyAsync(x => x.Id == request.ParentCommentId && x.BookId == request.BookId && x.DeletedDate == null);
                if(!anyComment)
                    return new FailNoDataResponse();
            }

            var addedComment = _mapper.Map<CommentEntity>(request);
            await _commendWriteRepository.AddAsync(addedComment);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}