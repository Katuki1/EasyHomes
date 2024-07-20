namespace LykEasy.Domain.Entities.Housing
{
    public class Address : BaseHousing
    {
        public int Id { get; set; }
        public string Country { get; set; } = "Kenya";
        public string County { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Area { get; set; } = default!;
        public string StreetName { get; set; } = default!;
    }

}
