namespace LykEasy.Domain.Entities.Housing
{
    public class House : BaseHousing
    {
        public int Id { get; set; }
        public string ApartmentName { get; set; } = default!;
        public bool HasVacancy { get; set; }

        public string? ContactEmail { get; set; }
        public string? ContactNumber { get; set; }

        public required Address Address { get; set; }
        public List<HouseType> HouseTypes { get; set; } = new();

    }
}
