using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace ProductsManager.Domain.Entities
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}
