using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IResult UpdateBook(UpdateBookDto updatedBookDto);
        IDataResult<Book> Add(AddBookDto addedBook);
        IDataResult<Book> GetBookById(int id);
        IDataResult<List<BookDetailDto>> GetAllBookDetail();
        IDataResult<List<BookDetailDto>> GetAllBookDetailByStoreName(string storeName);
    }
}