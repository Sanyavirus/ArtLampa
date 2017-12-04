namespace DomMezonin.DomainModel.Entity
{
    /// <summary>
    /// Поставщик
    /// </summary>
    public class Vendor : EntityBaseNamed
    {
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}