namespace Chirper_CS.Models
{
    public class Chirp
    {
        public int ChirpId { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
