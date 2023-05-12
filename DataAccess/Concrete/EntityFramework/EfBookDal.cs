using Core.DataAccess.EntityFramework;
using Core.Utilities.Helpers.FileAddressHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using Entities.DTOs.BookPictureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookShopContext>, IBookDal
    {
        public List<BookDetailDto> GetAllBookDetail(Expression<Func<BookDetailDto, bool>> filter = null)
        {
            using (BookShopContext context = new BookShopContext())
            {
                var resultBookDetail = from book in context.Books
                                       join author in context.Authors
                                       on book.AuthorId equals author.Id
                                       join publisher in context.Publishers
                                       on book.PublisherId equals publisher.Id
                                       join store in context.Stores
                                       on book.StoreId equals store.Id
                                       select new BookDetailDto
                                       {
                                           BookId = book.Id,
                                           PublisherName = publisher.Name,
                                           StoreName = store.Name,
                                           Author = String.Join(" ", author.FirstName, author.LastName),
                                           BookName = book.BookName,
                                           Language = book.Language,
                                           ReleaseDate = book.ReleaseDate,
                                           ISBN = book.ISBN,
                                           PaperType = book.PaperType,
                                           SkinType = book.SkinType,
                                           PageOfNumber = book.PageOfNumber,
                                           Dimension = book.Dimension,
                                           BookDescription = book.BookDescription,
                                           Stock = book.Stock,
                                           Price = book.Price,
                                           BookPictureAddresses = GetSelectedBookPictureDetail(book.Id),
                                           BookCategories = GetSelectedBookCategories(book.Id)
                                       };


                return filter == null
                    ? resultBookDetail.ToList()
                    : resultBookDetail.Where(filter).ToList();
            }
        }

        public BookDetailDto GetBookDetail(Expression<Func<BookDetailDto, bool>> filter)
        {
            using (BookShopContext context = new BookShopContext())
            {
                var resultBookDetail = from book in context.Books
                                       join author in context.Authors
                                       on book.AuthorId equals author.Id
                                       join publisher in context.Publishers
                                       on book.PublisherId equals publisher.Id
                                       join store in context.Stores
                                       on book.StoreId equals store.Id
                                       select new BookDetailDto
                                       {
                                           BookId = book.Id,
                                           PublisherName = publisher.Name,
                                           StoreName = store.Name,
                                           Author = String.Join(" ", author.FirstName, author.LastName),
                                           BookName = book.BookName,
                                           Language = book.Language,
                                           ReleaseDate = book.ReleaseDate,
                                           ISBN = book.ISBN,
                                           PaperType = book.PaperType,
                                           SkinType = book.SkinType,
                                           PageOfNumber = book.PageOfNumber,
                                           Dimension = book.Dimension,
                                           BookDescription = book.BookDescription,
                                           Stock = book.Stock,
                                           Price = book.Price,
                                           BookPictureAddresses = GetSelectedBookPictureDetail(book.Id),
                                           BookCategories = GetSelectedBookCategories(book.Id)
                                       };

                return resultBookDetail.SingleOrDefault(filter);
            }
        }

        private static List<BookPictureDetailDto> GetSelectedBookPictureDetail(int bookId)
        {
            using (BookShopContext context = new BookShopContext())
            {
                var resultBookPictureAddress = from bookPicture in context.BookPictures
                                               where bookPicture.BookId == bookId
                                               join file in context.Files
                                               on bookPicture.FileId equals file.Id
                                               select new BookPictureDetailDto
                                               {
                                                   BookPictureId = bookPicture.Id,
                                                   BookPictureAddress = FileAddressTool.CreateFileAddress(file.FilePath),
                                                   OrderOfAppearance = bookPicture.OrderOfAppearance,
                                               };

                return resultBookPictureAddress.ToList();
            }
        }

        private static List<string> GetSelectedBookCategories(int bookId)
        {
            using (BookShopContext context = new BookShopContext())
            {
                int categoryId;
                List<string> categoryPaths = new();

                var bookOfCategories = from bookOfCategory in context.BookOfCategories
                                       where bookOfCategory.BookId == bookId
                                       select bookOfCategory;

                var categories = context.Set<Category>().ToList();

                foreach(var bookOfCategory in bookOfCategories)
                {
                    List<string> combinatedCategoryNames = new();

                    categoryId = bookOfCategory.CategoryId;

                    while(categoryId != 0)
                    {
                        var selectedCategory = categories.SingleOrDefault(c => c.Id == categoryId);

                        combinatedCategoryNames.Add(selectedCategory.CategoryName);
                        categoryId = selectedCategory.ParentId;
                    }

                    combinatedCategoryNames.Reverse();
                    categoryPaths.Add(String.Join("/", combinatedCategoryNames));
                }

                return categoryPaths;
            }
        }
    }
}
