using IGDB;
using System.Threading.Tasks;


class CustomTokenStore : ITokenStore
{

   async Task<TwitchAccessToken> GetTokenAsync()
    {

        // Get token from database, etc.
        var tokenValue =  "9vs4soz4pr6ppkdki3zo1bgpoe0zka";

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

