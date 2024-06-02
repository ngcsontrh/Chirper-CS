namespace Chirper_CS.Seeders
{
    public interface ISeederBase<T> where T : class
    {
        List<T> Generate();
    }
}
