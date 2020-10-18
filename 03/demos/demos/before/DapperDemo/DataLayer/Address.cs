namespace DataLayer
{
    public class Address
    {
        public int ID { get; set; }
        public int ContactID { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public string PostalCode { get; set; }
        internal bool IsNew => (this.ID == default(int));

        public bool IsDeleted { get; set; }

    }
}