namespace Chirper_CS.DTO
{
    public class ChirpDTO
    {
        public string Message { get; set; }
    }

    public class ChirpAddDTO : ChirpDTO
    {
        public int UserId { get; set; }
    }

    public class ChirpResponseDTO : ChirpDTO
    {
        public int ChirpId { get; set; }
        public string UserFullName { get; set; }
    }

}
