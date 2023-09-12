namespace BookShopAPI.Application.DTOs.AddressDTOs
{
    public class AddressForAdminDto
    {
        public int Id { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
        public bool Selected { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}