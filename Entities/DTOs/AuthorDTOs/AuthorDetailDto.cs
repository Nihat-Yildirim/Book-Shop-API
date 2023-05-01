using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.AuthorDTOs
{
    public class AuthorDetailDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Autobiography { get; set; }
        public string AuthorPictureAddress { get; set; }
        public bool Status { get; set; }
    }
}
