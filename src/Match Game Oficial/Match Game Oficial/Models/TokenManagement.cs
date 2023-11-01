using IGDB;
using System.Threading.Tasks;


class CustomTokenStore : ITokenStore
{

   async Task<TwitchAccessToken> GetTokenAsync()
    {

        // Get token from database, etc.
        var tokenValue = "Bearer y17uussmnevjz6ylt0vfh8aoxb93pj";

        var token = new TwitchAccessToken { AccessToken = tokenValue };  

        return token;
    }

    Task<TwitchAccessToken> ITokenStore.GetTokenAsync()
    {
        throw new NotImplementedException();
    }

    async Task<TwitchAccessToken> StoreTokenAsync(TwitchAccessToken token)
    {
        // Store new token in database, etc.
        return token;
    }

    Task<TwitchAccessToken> ITokenStore.StoreTokenAsync(TwitchAccessToken token)
    {
        throw new NotImplementedException();
    }
}

