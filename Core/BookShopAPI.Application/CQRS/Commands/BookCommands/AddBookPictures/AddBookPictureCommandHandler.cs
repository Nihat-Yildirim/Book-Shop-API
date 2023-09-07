using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Application.Storage;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Constants;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.AddBookPictures
{
    public class AddBookPictureCommandHandler : IRequestHandler<AddBookPicturesCommandRequest, BaseResponse>
    {
        private readonly IStorage _storage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IFileWriteRepository _fileWriteRepository;

        public AddBookPictureCommandHandler(IStorage storage, IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository, IFileWriteRepository fileWriteRepository)
        {
            _storage = storage;
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _fileWriteRepository = fileWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddBookPicturesCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.Table
                .Include(x => x.BookPictures)
                .SingleOrDefaultAsync(x => x.DeletedDate == null && x.Id == request.BookId);

            if (selectedBook == null)
                return new FailNoDataResponse();

            if(selectedBook.BookPictures.Count == 5)
                return new FailNoDataResponse();
            
            List<FileEntity> files = new();

            foreach (IFormFile file in request.Pictures)
            {
                if(selectedBook.BookPictures.Count != 5)
                {
                    var storageResult = await _storage.UploadFileAsync(file, Paths.BookPicturePath);

                    FileEntity addedFile = new()
                    {
                        FilePath = storageResult.FilePath,
                        FileExtension = storageResult.FileExtension,
                        FileName = storageResult.FileName,
                    };

                    files.Add(addedFile);
                }
            }

            await _fileWriteRepository.AddRangeAsync(files);
            await _unitOfWork.SaveChangesAsync();

            files.ForEach(file =>
            {
                BookPicture bookPicture = new()
                {
                    BookId = selectedBook.Id,
                    BookPictureFileId = file.Id,
                    ShowOrder = selectedBook.BookPictures.Max(x => x.ShowOrder) + 1
                };

                selectedBook.BookPictures.Add(bookPicture);
            });

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}