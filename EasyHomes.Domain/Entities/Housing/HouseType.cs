namespace LykEasy.Domain.Entities.Housing
{
    public class HouseType : BaseHousing
    {
        public int Id { get; set; }
        public string Type { get; set; } = default!;
        public string Size { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int HouseId { get; set; }
    }

}
