using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.Game.Zaohua.Metadata
{
    public partial class GameCheatService
    {
        public GameResourceCache Cache { get; }
        public GameMetadataContext Context => Cache.Context;
        private ILogger Logger => Context.Logger;

        public TbActor.Ptr_TbActor Ptr_TbActor { get; }

        public GameCheatService(GameResourceCache cache, TbActor.Ptr_TbActor ptr_TbActor)
        {
            this.Cache = cache;
            this.Ptr_TbActor = ptr_TbActor;
        }

        public static GameCheatService CreateGameCheatService(GameResourceCache c)
        {
            var ptr_TbActor = BsSaveDataImpl.Ptr_BsSaveDataImpl.NOW_ACTOR;
            if (ptr_TbActor.IsNull())
            {
                return GameException.ThrowIfNotLoaded<GameCheatService>();
            }
            return new GameCheatService(c, ptr_TbActor);
        }

        public IEnumerable<GameCharacterDisplayDTO> GetGameCharacters()
        {
            var actor = this.Ptr_TbActor._PLAYER_STO.
        }
    }
}
