using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using static Maple.Game.Zaohua.Metadata.TbDataImpl;

namespace Maple.Game.Zaohua.Metadata
{
    public partial class GameResourceCache
    {
        public GameMetadataContext Context { get; }
        public ILogger Logger => Context.Logger;

        public GameInventoryDisplayDTO[] GameInventories { get; }
        public GameSkillDisplayDTO[] GameSkills { get; }
        public GameResourceCache(GameMetadataContext context)
        {
            this.Context = context;
            var ptr_dataImpl = TbDataImpl.Ptr_TbDataImpl.M_INSTANCE;
            this.GameInventories = [.. LoadItems(ptr_dataImpl)];
            this.GameSkills = [.. LoadSkills(ptr_dataImpl)];

        }

        public IEnumerable<GameInventoryDisplayDTO> LoadItems(Ptr_TbDataImpl ptr_dataImpl)
        {
            foreach (var item in ptr_dataImpl.ITEM_CFG_LIST.AsEnumerable())
            {

                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_DES().ToString();
                this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbItemCfg), name, desc);
            }
            yield break;
        }
        public IEnumerable<GameSkillDisplayDTO> LoadSkills(Ptr_TbDataImpl ptr_dataImpl)
        {
            foreach (var item in ptr_dataImpl.MAGIC_LIST.AsEnumerable())
            {

                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_EFF_DES().ToString();
                this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbMagicCfg), name, desc);


            }
            foreach (var item in ptr_dataImpl.LV_LIST.AsEnumerable())
            {

                var name = item.GET_GET_LV_NAME().ToString();
                var desc = item.GET_GET_INTRODUCE().ToString();

                this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbLvCfg), name, desc);


            }
            yield break;
        }

        public static GameResourceCache Create(GameMetadataContext context)
        {
            SpinWait.SpinUntil(() => TbDataImpl.Ptr_TbDataImpl.M_INSTANCE.IsNotNull());
            return new GameResourceCache(context);
        }
    }
}
