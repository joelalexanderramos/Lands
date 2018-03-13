namespace Lands.Models
{
    using Domain;
    using SQLite.Net.Attributes;

    public class UserLocal : User
    {
        [PrimaryKey, AutoIncrement]
        public int UserLocalId { get; set; }
    }
}