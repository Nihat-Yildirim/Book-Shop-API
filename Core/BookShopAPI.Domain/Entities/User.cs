﻿using BookShopAPI.Domain.Entities.Common;
using BookShopAPI.Domain.Enums;

namespace BookShopAPI.Domain.Entities
{
    public class User : Entity
    {
        public User()
        {
            Baskets = new HashSet<Basket>();
            Addresses = new HashSet<Address>();
            Comments = new HashSet<CommentEntity>();
            CommentRatings = new HashSet<CommentRating>();
        }

        public int? UserAvatarFileId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public AuthenticatorType AuthenticatorType { get; set; }
        public DateTime? DeletedDate { get; set; }

        public FileEntity? File { get; set; }
        public UserClaim? UserClaim { get; set; }
        public RefreshToken? RefreshToken { get; set; }
        public MailComfirmCode? MailComfirmCode { get; set; }
        public MailAuthentication? MailAuthentication { get; set; }
        public OtpAuthentication? OtpAuthentication { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }
        public ICollection<FavoriteBook> FavoriteBooks { get; set; }
        public ICollection<CommentRating> CommentRatings { get; set; }
    }
}