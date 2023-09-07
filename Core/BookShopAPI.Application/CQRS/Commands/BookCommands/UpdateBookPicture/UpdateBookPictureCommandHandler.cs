using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookPicture
{
    public class UpdateBookPictureCommandHandler : IRequestHandler<UpdateBookPictureCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookPictureReadRepository _bookPictureReadRepository;

        public UpdateBookPictureCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IBookPictureReadRepository bookPictureReadRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _bookPictureReadRepository = bookPictureReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateBookPictureCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBookPictures = await _bookPictureReadRepository.GetBookPicturesWithPictureFileAsync(x => x.BookId == request.BookId);
            if (selectedBookPictures == null)
                return new FailNoDataResponse();

            if(selectedBookPictures.Count < request.ShowOrder)
                return new FailNoDataResponse();

            var updatedBookPicture = selectedBookPictures.SingleOrDefault(x => x.Id == request.BookPictureId);
            if(updatedBookPicture == null)
                return new FailNoDataResponse();

            if(request.Picture != null)
            {
                var storageResult = await _storage.UploadFileAsync(request.Picture, Paths.BookPicturePath);

                updatedBookPicture.File.FilePath = storageResult.FilePath;
                updatedBookPicture.File.FileName = storageResult.FileName;
                updatedBookPicture.File.FileExtension = storageResult.FileExtension;
            }

            selectedBookPictures.SingleOrDefault(x => x.ShowOrder == request.ShowOrder).ShowOrder = updatedBookPicture.ShowOrder;
            updatedBookPicture.ShowOrder = request.ShowOrder;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}