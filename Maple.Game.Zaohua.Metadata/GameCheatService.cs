using Microsoft.Extensions.Logging;

namespace Maple.Game.Zaohua.Metadata
{
    public partial class GameCheatService(GameResourceCache cache)
    {
        public GameResourceCache Cache { get; } = cache;
        public GameMetadataContext Context => Cache.Context;
        private ILogger Logger => Context.Logger;

    }
}
