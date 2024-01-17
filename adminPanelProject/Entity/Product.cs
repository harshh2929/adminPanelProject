namespace adminPanelProject.Entity
{
    public class Product
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ManufacturerName { get; set; } = string.Empty;
        public string ManufacturerLocation { get; set; } = string.Empty;
    }
}
