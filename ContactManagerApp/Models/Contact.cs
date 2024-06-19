using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        // user ID from AspNetUser table.
        public string? OwnerID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public int Status { get; set; }
    }
    public enum ContactStatus
    {
        Submitted = 0,
        Approved = 1,
        Rejected = 2
    }
}