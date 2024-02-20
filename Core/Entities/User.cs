
namespace Core.Entities
{
    public class User : Entity<int>
    {
        // GENEL USER FIELDLARI
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Approved { get; set; }

        // abc123  => Plain Text
        // Hashing SHA512, MD5 => VKQWLELXQWOE03129FKLSLQW
        // Salting => abc123 + SALT => HASH => 


    }
}