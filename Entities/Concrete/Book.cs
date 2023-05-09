using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int StoreId { get; set; }
        public int AuthorId { get; set; }
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
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}