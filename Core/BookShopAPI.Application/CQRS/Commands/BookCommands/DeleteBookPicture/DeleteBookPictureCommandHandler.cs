using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBookPicture
{
    public class DeleteBookPictureCommandHandler : IRequestHandler<DeleteBookPictureCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileWriteRepository _fileWriteRepository;
        private readonly IBookPictureWriteRepository _bookPictureWriteRepository;
        private readonly IBookPictureReadRepository _bookPictureReadRepository;

        public DeleteBookPictureCommandHandler(IStorage storage, IBookPictureReadRepository bookPictureReadRepository, IFileWriteRepository fileWriteRepository, IUnitOfWork unitOfWork, IBookPictureWriteRepository bookPictureWriteRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _fileWriteRepository = fileWriteRepository;
            _bookPictureReadRepository = bookPictureReadRepository;
            _bookPictureWriteRepository = bookPictureWriteRepository;
        }

        public async Task<BaseResponse> Handle(DeleteBookPictureCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBookPictures = await _bookPictureReadRepository.GetBookPicturesWithPictureFileAsync(x => x.BookId == request.BookId);

            if (selectedBookPictures == null)
                return new FailNoDataResponse();

            var deletedPicture = selectedBookPictures.Find(x => x.Id == request.BookPictureId);

            if (deletedPicture == null)
                return new FailNoDataResponse();

            var otherPictures = selectedBookPictures.Where(x => x.ShowOrder > deletedPicture.ShowOrder).ToList();

            foreach(var picture in otherPictures)
                picture.ShowOrder = picture.ShowOrder - 1;

            _bookPictureWriteRepository.Remove(deletedPicture);
            _storage.Delete(deletedPicture.File.FilePath);
            _fileWriteRepository.Remove(deletedPicture.File);

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}