using Core.DTOs;
using Entities.DTOs.BookPictureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.BookDTOs
{
    public class BookDetailDto : IDto
    {
        public int BookId { get; set; }
        public string PublisherName { get; set; }
        public string StoreName { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public string PaperType { get; set; }
        public string SkinType { get; set; }
        public int PageOfNumber { get; set; }
        public string Dimension { get; set; }
        public string BookDescription { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public List<BookPictureDetailDto> BookPictureAddresses { get; set; }
        public List<string> BookCategories { get; set; }
    }
}