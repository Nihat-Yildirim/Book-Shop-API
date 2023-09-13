using AutoMapper;
using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.AddCommentRating
{
    public class AddCommentRatingCommandHandler : IRequestHandler<AddCommentRatingCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICommentReadRepository _commendReadRepository;
        private readonly IUserClaimReadRepository _userClaimReadRepository;
        private readonly ICommentRatingReadRepository _commendRatingReadRepository;
        private readonly ICommentRatingWriteRepository _commendRatingWriteRepository;

        public AddCommentRatingCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, ICommentReadRepository commendReadRepository, IUserClaimReadRepository userClaimReadRepository, ICommentRatingReadRepository commendRatingReadRepository, ICommentRatingWriteRepository commendRatingWriteRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _commendReadRepository = commendReadRepository;
            _userClaimReadRepository = userClaimReadRepository;
            _commendRatingReadRepository = commendRatingReadRepository;
            _commendRatingWriteRepository = commendRatingWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddCommentRatingCommandRequest request, CancellationToken cancellationToken)
        {
            bool anyUser = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.DeletedDate == null);
            if (!anyUser)
                return new FailNoDataResponse();

            bool anyUserClaim = await _userClaimReadRepository.AnyAsync(x => x.UserId == request.UserId && x.ClaimId == (int)Claims.Admin);
            if (anyUserClaim)
                return new FailNoDataResponse();

            bool anyComment = await _commendReadRepository.AnyAsync(x => x.Id == request.CommentId && x.DeletedDate == null);
            if (!anyComment)
                return new FailNoDataResponse();

            bool anyUserComment = await _commendReadRepository.AnyAsync(x => x.UserId == request.UserId && x.Id == request.CommentId && x.DeletedDate == null);
            if (anyUserComment)
                return new FailNoDataResponse();

            bool anyUserCommentRating = await _commendRatingReadRepository.AnyAsync(x => x.UserId == request.UserId && x.CommentId == request.CommentId);
            if(anyUserCommentRating)
                return new FailNoDataResponse();

            var addedCommentRating = _mapper.Map<CommentRating>(request);
            await _commendRatingWriteRepository.AddAsync(addedCommentRating);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}