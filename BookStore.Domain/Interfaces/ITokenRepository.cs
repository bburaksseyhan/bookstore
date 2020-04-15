namespace BookStore.Domain.Interfaces
{
    public interface ITokenRepository
    {
        string GetRefreshToken(string refreshToken);

        bool UpdateUserToken(int id, string refreshToken, string token);
    }
}
