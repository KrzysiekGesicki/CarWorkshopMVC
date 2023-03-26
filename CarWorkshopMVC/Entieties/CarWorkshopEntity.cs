namespace CarWorkshopMVC.Entieties
{
    public class CarWorkshopEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Address { get; set; } = default!;
        public string? PhoneNumber { get; set; }
    }
}
