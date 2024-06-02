using Chirper_CS.Models;

namespace Chirper_CS.Seeders
{
    public class ChirpSeeder : ISeederBase<Chirp>
    {
        public List<Chirp> Generate()
        {
            var chirps = new List<Chirp>();
            var random = new Random();
            for (int i = -50; i < 0; i++)
            {
                chirps.Add(new Chirp()
                {
                    ChirpId = i,
                    Message = $"Chirp #{i}",
                    UserId = random.Next(-50, 0)
                });
            }
            return chirps;
        }
    }
}
