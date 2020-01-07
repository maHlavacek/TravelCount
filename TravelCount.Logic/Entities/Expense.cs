namespace TravelCount.Logic.Entities
{
    internal class Expense : IdentityObject
    {
        
        public string Designation { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Friends { get; set; }
        public string Category { get; set; }
    }
}