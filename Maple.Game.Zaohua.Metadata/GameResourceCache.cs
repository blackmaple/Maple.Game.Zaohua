using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Linq;
using static Maple.Game.Zaohua.Metadata.TbDataImpl;

namespace Maple.Game.Zaohua.Metadata
{
    public partial class GameResourceCache
    {
        public GameMetadataContext Context { get; }
        public ILogger Logger => Context.Logger;

        public GameInventoryDisplayDTOEX[] GameInventories { get; }
        public GameSkillDisplayDTOEX[] GameSkills { get; }

        public GameObjectDisplayDTOEX[] GameObjects { get; }
        public GameResourceCache(GameMetadataContext context)
        {
            this.Context = context;
            var ptr_dataImpl = TbDataImpl.Ptr_TbDataImpl.M_INSTANCE;

            this.GameObjects = [.. LoadResource(ptr_dataImpl)];
            this.GameInventories = [.. LoadItems(ptr_dataImpl)];
            this.GameSkills = [.. LoadSkills(ptr_dataImpl)];
            foreach (var item in this.GameObjects)
            {
                this.Logger.Info(item.ToString());
            }
            foreach (var item in this.GameInventories)
            {
                this.Logger.Info(item.ToString());
            }
            foreach (var item in this.GameSkills)
            {
                this.Logger.Info(item.ToString());
            }
        }

        public IEnumerable<GameInventoryDisplayDTOEX> LoadItems(Ptr_TbDataImpl ptr_dataImpl)
        {
            foreach (var item in ptr_dataImpl.ITEM_CFG_LIST.AsEnumerable())
            {

                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_DES().ToString();
                var effDesc = item.GET_GET_EFF_DES().ToString();
                yield return new GameInventoryDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = GetObjectDisplayCategory(nameof(TbItemCfg), item.TYPE_ID, item.GRADE_ID),
                    DisplayDesc = $"{desc} {effDesc}",
                };

            }

        }
        public IEnumerable<GameSkillDisplayDTOEX> LoadSkills(Ptr_TbDataImpl ptr_dataImpl)
        {
            foreach (var item in ptr_dataImpl.MAGIC_LIST.AsEnumerable())
            {

                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_EFF_DES().ToString();
                yield return new GameSkillDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = GetObjectDisplayCategory(nameof(TbMagicCfg), item.TYPE, item.GRADE_ID),
                    DisplayDesc = desc,
                };


            }

            //foreach(var item in ptr_dataImpl.MAGIC_LIST)


            yield break;
        }

        public IEnumerable<GameObjectDisplayDTOEX> LoadResource(Ptr_TbDataImpl ptr_dataImpl)
        {


            foreach (var item in ptr_dataImpl.ATTRIB_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = string.Empty;
                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbAttribCfg),
                    DisplayDesc = desc,
                };
            }

            //foreach (var item in ptr_dataImpl.EQUIP_EFFECT_CFG_LIST.AsEnumerable())
            //{
            //    var name = item.GET_GET_NAME().ToString();
            //    var desc = string.Empty;
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbEquipEffectCfg), name, desc);
            //}

            //foreach (var item in ptr_dataImpl.FUNCTION_LIST.AsEnumerable())
            //{
            //    var name = item.GET_GET_NAME().ToString();
            //    var desc = string.Empty;
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbFunctionCfg), name, desc);
            //}

            foreach (var item in ptr_dataImpl.GRADE_CFG_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = string.Empty;
                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbGradeCfg),
                    DisplayDesc = desc,
                };
            }

            foreach (var item in ptr_dataImpl.LV_LIST.AsEnumerable())
            {

                var name = item.GET_GET_LV_NAME().ToString();
                var desc = item.GET_GET_INTRODUCE().ToString();

                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbLvCfg),
                    DisplayDesc = desc,
                };
            }

            //foreach (var item in ptr_dataImpl.NAME_LIST.AsEnumerable())
            //{
            //    var name = item.GET_GET_NAME().ToString();
            //    var desc = string.Empty;
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbNameCfg), name, desc);
            //}

            foreach (var item in ptr_dataImpl.ROLE_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_ROLE_NAME().ToString();
                var desc2 = item.GET_GET_SURNAME().ToString();

                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbRoleCfg),
                    DisplayDesc = $"{desc} {desc2}",
                };
            }

            foreach (var item in ptr_dataImpl.SECT_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = item.GET_GET_INTRODUCE().ToString();

                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbSectCfg),
                    DisplayDesc = desc,
                };
            }

            //foreach (var item in ptr_dataImpl.SUIT_LIST.AsEnumerable())
            //{
            //    var name = item.GET_GET_NAME().ToString();
            //    var desc = item.GET_GET_EFF_DES().ToString();
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbSuitCfg), name, desc);
            //}

            foreach (var item in ptr_dataImpl.TYPE_CFG_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = string.Empty;

                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbTypeCfg),
                    DisplayDesc = desc,
                };
            }

            //foreach (var item in ptr_dataImpl.VALUE_CFG_LIST.AsEnumerable())
            //{
            //    var name = item.ID.ToString();
            //    var desc = item.VALUE.ToString();
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbValueCfg), name, desc);
            //}

            //foreach (var item in ptr_dataImpl.WEATHER_LIST.AsEnumerable())
            //{
            //    var name = item.ID.ToString();
            //    var desc = item.NAME.ToString();
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbWeatherCfg), name, desc);
            //}

            //foreach (var item in ptr_dataImpl.PLAY_CFG_LIST.AsEnumerable())
            //{
            //    var name = item.get().ToString();
            //    var desc = string.Empty;
            //    this.Logger.LogInformation("{type}:{name}:{desc}", nameof(TbPlayCfg), name, desc);
            //}

            foreach (var item in ptr_dataImpl.POST_LIST.AsEnumerable())
            {
                var name = item.GET_GET_NAME().ToString();
                var desc = string.Empty;


                yield return new GameObjectDisplayDTOEX()
                {
                    ObjectPointer = item,
                    ObjectId = item.ID.ToString(),
                    DisplayName = name,
                    DisplayCategory = nameof(TbPostCfg),
                    DisplayDesc = desc,
                };
            }


        }

        public static GameResourceCache Create(GameMetadataContext context)
        {
            //      Thread.Sleep(5000);
            SpinWait.SpinUntil(() => TbDataImpl.Ptr_TbDataImpl.M_INSTANCE.IsNotNull());
            return new GameResourceCache(context);
        }

        private IEnumerable<string?> SearchObjectDisplayCategory(int type_id, int grade_id)
        {
            var txt_type_id = type_id.ToString();
            var typeObj = this.GameObjects.Where(p => p.DisplayCategory == nameof(TbTypeCfg) && p.ObjectId == txt_type_id).FirstOrDefault();
            if (typeObj is not null)
            {
                yield return typeObj.DisplayName;
            }
            var txt_grade_id = grade_id.ToString();
            var gradeObj = this.GameObjects.Where(p => p.DisplayCategory == nameof(TbGradeCfg) && p.ObjectId == txt_grade_id).FirstOrDefault();
            if (gradeObj is not null)
            {
                yield return gradeObj.DisplayName;
            }
        }

        private string GetObjectDisplayCategory(string? displayCategory, int type_id, int grade_id)
        {
            return string.Join('*', [displayCategory, .. SearchObjectDisplayCategory(type_id, grade_id)]);
        }
    }



    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public nint ObjectPointer { get; set; }

        public override string ToString()
        {
            return $"{this.ObjectId}|{this.DisplayCategory}|{this.DisplayName}|{this.DisplayDesc}";
        }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public nint ObjectPointer { get; set; }
        public override string ToString()
        {
            return $"{this.ObjectId}|{this.DisplayCategory}|{this.DisplayName}|{this.DisplayDesc}";
        }
    }


    public class GameObjectDisplayDTOEX : GameObjectDisplayDTO
    {
        public nint ObjectPointer { get; set; }
        public override string ToString()
        {
            return $"{this.ObjectId}|{this.DisplayCategory}|{this.DisplayName}|{this.DisplayDesc}";
        }
    }
}
