using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Maple.Game.Zaohua.Metadata
{
    public partial class GameCheatService(GameResourceCache cache, TbActor.Ptr_TbActor ptr_TbActor)
    {
        public GameResourceCache Cache { get; } = cache;
        public GameMetadataContext Context => Cache.Context;
        private ILogger Logger => Context.Logger;

        public TbActor.Ptr_TbActor Ptr_TbActor { get; } = ptr_TbActor;
        public BsBagImpl.Ptr_BsBagImpl Ptr_BsBagImpl { get; } = BsBagImpl.Ptr_BsBagImpl.M_INSTANCE;
        private TbPlayerSto.Ptr_TbPlayerSto Ptr_PlayerSto { get; } = ptr_TbActor._PLAYER_STO;
        private int PlayerId { get; } = ptr_TbActor._PLAYER_STO.ID;

        public static GameCheatService CreateGameCheatService(GameResourceCache c)
        {
            var ptr_TbActor = BsSaveDataImpl.Ptr_BsSaveDataImpl.NOW_ACTOR;
            if (ptr_TbActor.IsNull())
            {
                return GameException.ThrowIfNotLoaded<GameCheatService>();
            }
            return new GameCheatService(c, ptr_TbActor);
        }

        #region Character

        public IEnumerable<GameCharacterDisplayDTO> GetGameCharacters()
        {
            var characterId = this.PlayerId;
            if (this.TryFindNpcSto(characterId, out var npc))
            {
                this.Logger.LogInformation("{player}:{npc}", this.Ptr_PlayerSto.Ptr.ToString("X8"), npc.Ptr.ToString("X8"));

                yield return new GameCharacterDisplayDTO
                {
                    ObjectId = npc.ID.ToString(),
                    DisplayCategory = nameof(TbNpcSto),
                    DisplayDesc = npc.INTRODUCE.ToString(),
                    DisplayName = npc.NAME.ToString(),
                };
            }
        }

        private bool TryFindNpcSto(int npcId, out TbNpcSto.Ptr_TbNpcSto ptr_TbNpcSto)
        {
            Unsafe.SkipInit(out ptr_TbNpcSto);
            foreach (var npc in this.Ptr_TbActor._NPC_STO_LIST.AsEnumerable())
            {
                if (npc.ID == npcId)
                {
                    ptr_TbNpcSto = npc;
                    return true;
                }
            }
            return false;
        }

        private IEnumerable<TbMagicSto.Ptr_TbMagicSto> EnumMagicStos(int npcId)
        {
            foreach (var m in this.Ptr_TbActor._MAGIC_STO_LIST.AsEnumerable())
            {

                if (m.NPC_STO_ID == npcId)
                {
                    yield return m;
                }
            }
        }
        private IEnumerable<GameSkillInfoDTO> EnumMagicCfg(int npcId)
        {
            var magicStos = this.EnumMagicStos(npcId).ToArray();
            foreach (var skill in this.Cache.GameSkills.Where(p => p.DisplayCategory == nameof(TbMagicCfg)))
            {
                var ptrMagicCfg = new TbMagicCfg.Ptr_TbMagicCfg(skill.ObjectPointer);
                foreach (var sto in magicStos)
                {
                    var m = sto.MAGIC_ID;
                    if (m.blendEnum == ptrMagicCfg.BLEND_ENUM && m.sedId == ptrMagicCfg.ID)
                    {
                        yield return new GameSkillInfoDTO()
                        {
                            ObjectId = skill.ObjectId,
                            DisplayName = skill.DisplayName,
                            DisplayCategory = skill.DisplayCategory,
                            DisplayDesc = skill.DisplayDesc,
                            DisplayImage = skill.DisplayImage,
                            CanWrite = sto.FLAG == 0,
                        };

                    }
                }
            }
        }
        private bool TryGetMagicSto(int npcId, TbMagicCfg.Ptr_TbMagicCfg ptr_TbMagicCfg, out TbMagicSto.Ptr_TbMagicSto ptr_TbMagicSto)
        {
            Unsafe.SkipInit(out ptr_TbMagicSto);

            foreach (var m in EnumMagicStos(npcId))
            {
                var ref_blend = m.MAGIC_ID;
                if (ref_blend.blendEnum == ptr_TbMagicCfg.BLEND_ENUM && ref_blend.sedId == ptr_TbMagicCfg.ID)
                {
                    ptr_TbMagicSto = m;
                    return true;
                }
            }

            return false;
        }

        private IEnumerable<TbArtSto.Ptr_TbArtSto> EnumArtStos(int npcId)
        {
            foreach (var m in this.Ptr_TbActor._ART_STO_LIST.AsEnumerable())
            {
                if (m.NPC_STO_ID == npcId)
                {
                    yield return m;
                }
            }
        }
        private IEnumerable<GameSkillInfoDTO> EnumArtCfg(int npcId)
        {
            var artStos = this.EnumArtStos(npcId).ToArray();
            foreach (var skill in this.Cache.GameSkills.Where(p => p.DisplayCategory == nameof(TbArtCfg)))
            {
                var ptrAtrCfg = new TbArtCfg.Ptr_TbArtCfg(skill.ObjectPointer);
                foreach (var sto in artStos)
                {
                    var m = sto.ART_ID;
                    if (m.blendEnum == ptrAtrCfg.BLEND_ENUM && m.sedId == ptrAtrCfg.ID)
                    {
                        yield return new GameSkillInfoDTO()
                        {
                            ObjectId = skill.ObjectId,
                            DisplayName = skill.DisplayName,
                            DisplayCategory = skill.DisplayCategory,
                            DisplayDesc = skill.DisplayDesc,
                            DisplayImage = skill.DisplayImage,
                            CanWrite = sto.FLAG == 0,

                        };

                    }
                }
            }
        }
        private bool TryGeArtSto(int npcId, TbArtCfg.Ptr_TbArtCfg ptr_TbArtCfg, out TbArtSto.Ptr_TbArtSto ptr_TbArtSto)
        {
            Unsafe.SkipInit(out ptr_TbArtSto);

            foreach (var m in EnumArtStos(npcId))
            {
                var ref_blend = m.ART_ID;
                if (ref_blend.blendEnum == ptr_TbArtCfg.BLEND_ENUM && ref_blend.sedId == ptr_TbArtCfg.ID)
                {
                    ptr_TbArtSto = m;
                    return true;
                }
            }

            return false;
        }
        private IEnumerable<TbTreeSto.Ptr_TbTreeSto> EnumTreeStos(int npcId)
        {
            foreach (var m in this.Ptr_TbActor._TREE_STO_LIST.AsEnumerable())
            {
                yield return m;
            }
        }
        private IEnumerable<GameSwitchDisplayDTO> EnumCharacterTree(int npcId)
        {
            var treeStos = this.EnumTreeStos(npcId).ToArray();
            foreach (var tree in this.Cache.GameObjects.Where(p => p.DisplayCategory == nameof(TbTreeCfg)))
            {
                var ptrTreeCfg = new TbTreeCfg.Ptr_TbTreeCfg(tree.ObjectPointer);
                var sto = treeStos.FirstOrDefault(p => p.TREE_ID == ptrTreeCfg.ID);
                yield return new GameSwitchDisplayDTO()
                {
                    ObjectId = tree.ObjectId,
                    DisplayName = $"至宝*{tree.DisplayName}",
                    DisplayCategory = tree.DisplayCategory,
                    DisplayDesc = tree.DisplayDesc,
                    DisplayImage = tree.DisplayImage,
                    UIType = (int)EnumGameSwitchUIType.Switches,
                    CanWrite = true,
                    SwitchValue = sto.IsNotNull() && sto.IS_STUDY
                };

            }

        }
        private IEnumerable<GameSwitchDisplayDTO> EnumCharacterProp(int npcId)
        {
            #region PlayerSto

            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.HP_NOW), "属性*当前气血", "当前气血", this.Ptr_PlayerSto.HP_NOW.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.MP_NOW), "属性*当前法术", "当前法术", this.Ptr_PlayerSto.MP_NOW.ToString());

            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.GOLD), "灵根*金", "灵根*金", this.Ptr_PlayerSto.GOLD.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.WOOD), "灵根*木", "灵根*木", this.Ptr_PlayerSto.WOOD.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.WATER), "灵根*水", "灵根*水", this.Ptr_PlayerSto.WATER.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.FIRE), "灵根*火", "灵根*火", this.Ptr_PlayerSto.FIRE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.SOIL), "灵根*土", "灵根*土", this.Ptr_PlayerSto.SOIL.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.ICE), "灵根*冰", "灵根*冰", this.Ptr_PlayerSto.ICE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.WIND), "灵根*风", "灵根*风", this.Ptr_PlayerSto.WIND.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.THUNDER), "灵根*雷", "灵根*雷", this.Ptr_PlayerSto.THUNDER.ToString());


            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.AGE), "属性*骨龄", "当前的岁数", this.Ptr_PlayerSto.AGE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.YEAR), "属性*寿命", "存活的最大岁数", this.Ptr_PlayerSto.YEAR.ToString());

            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.JUSTICE), "属性*正邪", "正邪", this.Ptr_PlayerSto.JUSTICE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.FATE), "属性*气运", "气运", this.Ptr_PlayerSto.FATE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.EXP), "属性*经验", "经验", this.Ptr_PlayerSto.EXP.ToString());

            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.BRAVE), "隐藏*勇气", "勇气", this.Ptr_PlayerSto.BRAVE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.EXCHANGE), "隐藏*交谈", "交谈", this.Ptr_PlayerSto.EXCHANGE.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.CREDIT), "隐藏*信用", "信用", this.Ptr_PlayerSto.CREDIT.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.BATTLE_SPEED), "隐藏*战斗速度", "战斗速度", this.Ptr_PlayerSto.BATTLE_SPEED.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.FLY), "隐藏*飞行", "飞行", this.Ptr_PlayerSto.FLY.ToString());


            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.SPACE_COUNT), "数量*背包", "背包数量", this.Ptr_PlayerSto.SPACE_COUNT.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.MAGIC_COUNT), "数量*术法", "术法数量", this.Ptr_PlayerSto.MAGIC_COUNT.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.TREAS_COUNT), "数量*法宝", "法宝数量", this.Ptr_PlayerSto.TREAS_COUNT.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.DANTIAN_COUNT), "数量*扩容", "扩容数量", this.Ptr_PlayerSto.DANTIAN_COUNT.ToString());
            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.ART_COUNT), "数量*功法", "功法数量", this.Ptr_PlayerSto.ART_COUNT.ToString());

            yield return CreatePlayerSto(nameof(TbPlayerSto.Ptr_TbPlayerSto.MAX_FLIP_SCORE), "数量*游戏", "游戏分数", this.Ptr_PlayerSto.MAX_FLIP_SCORE.ToString());
            #endregion

            #region NpcSto
            if (!TryFindNpcSto(npcId, out var ptr_TbNpcSto))
            {
                yield break;
            }
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.HP), "属性*最大气血", "最大气血", ptr_TbNpcSto.HP.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.MP), "属性*精力", "最大精力", ptr_TbNpcSto.MP.ToString());

            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.SOR_ATT), "属性*术攻", "影响术法攻击的威力", ptr_TbNpcSto.SOR_ATT.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.SOR_DEF), "属性*术防", "影响术法防御的威力", ptr_TbNpcSto.SOR_DEF.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.PHY_ATT), "属性*物攻", "影响物理攻击的威力", ptr_TbNpcSto.PHY_ATT.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.PHY_DEF), "属性*物防", "影响物理防御的威力", ptr_TbNpcSto.PHY_DEF.ToString());


            //yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.ARMOR_SAVE), "ARMOR_SAVE", "ARMOR_SAVE", ptr_TbNpcSto.ARMOR_SAVE.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.ACTION), "属性*精力", "战斗中每回合增加精力值", ptr_TbNpcSto.ACTION.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.ARMOR), "属性*护甲", "每回合固定产生护盾,用以格挡伤害值", ptr_TbNpcSto.ARMOR.ToString());
            //yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.CAPACITY), "状态*背包?", "CAPACITY", ptr_TbNpcSto.CAPACITY.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.ADVANCE), "属性*速度", "影响行动的先后顺序", ptr_TbNpcSto.ADVANCE.ToString());
            //yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.WIDE), "WIDE", "WIDE", ptr_TbNpcSto.WIDE.ToString());
            //yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.HIGH), "HIGH", "HIGH", ptr_TbNpcSto.HIGH.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.MIND), "属性*神魂", "允许存储最大的精力值", ptr_TbNpcSto.MIND.ToString());
            yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.SHIELD), "属性*护罩", "只在战斗初产生护盾,防止被秒杀", ptr_TbNpcSto.SHIELD.ToString());

            yield return CreateNpcSto_SelectedContents(nameof(TbNpcSto.Ptr_TbNpcSto.SECT_ID), "属性*宗门", "宗门", ptr_TbNpcSto.SECT_ID.ToString(), this.Cache.GameKeyValues.GetValueOrDefault(nameof(TbSectCfg)) ?? []);
            yield return CreateNpcSto_SelectedContents(nameof(TbNpcSto.Ptr_TbNpcSto.POST_ID), "属性*身份", "身份", ptr_TbNpcSto.POST_ID.ToString(), this.Cache.GameKeyValues.GetValueOrDefault(nameof(TbPostCfg)) ?? []);
            //yield return CreateNpcSto(nameof(TbNpcSto.Ptr_TbNpcSto.PLOY_ID), "PLOY_ID", "PLOY_ID", ptr_TbNpcSto.PLOY_ID.ToString());
            yield return CreateNpcSto_SelectedContents(nameof(TbNpcSto.Ptr_TbNpcSto.LV_ID), "属性*等级", "属性*等级", ptr_TbNpcSto.LV_ID.ToString(), this.Cache.GameKeyValues.GetValueOrDefault(nameof(TbLvCfg)) ?? []);
            //yield return CreateNpcSto_SelectedContents(nameof(TbNpcSto.Ptr_TbNpcSto.ATTRIB_ID), "ATTRIB_ID", "ATTRIB_ID", ptr_TbNpcSto.ATTRIB_ID.ToString(), this.Cache.GameKeyValues.GetValueOrDefault(nameof(TbAttribCfg)) ?? []);


            #endregion

        }

        private static GameSwitchDisplayDTO CreatePlayerSto(string key, string name, string desc, string val)
        {
            return new GameSwitchDisplayDTO() { ObjectId = key, DisplayCategory = nameof(TbPlayerSto), DisplayName = name, DisplayDesc = desc, ContentValue = val, UIType = (int)EnumGameSwitchUIType.TextEditor };
        }

        private static GameSwitchDisplayDTO CreateNpcSto(string key, string name, string desc, string val)
        {
            return new GameSwitchDisplayDTO() { ObjectId = key, DisplayCategory = nameof(TbNpcSto), DisplayName = name, DisplayDesc = desc, ContentValue = val, UIType = (int)EnumGameSwitchUIType.TextEditor };
        }
        private static GameSwitchDisplayDTO CreateNpcSto_SelectedContents(string key, string name, string desc, string val, GameValueInfoDTO[] selectedContents)
        {
            return new GameSwitchDisplayDTO()
            {
                ObjectId = key,
                DisplayCategory = nameof(TbNpcSto),
                DisplayName = name,
                DisplayDesc = desc,
                ContentValue = val,
                UIType = (int)EnumGameSwitchUIType.Selects,
                SelectedContents = [.. selectedContents]

            };
        }

        public GameCharacterStatusDTO GetGameCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterId != this.PlayerId.ToString())
            {
                return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
            }


            return new GameCharacterStatusDTO()
            {
                ObjectId = characterObjectDTO.CharacterId,
                CharacterAttributes = [.. EnumCharacterProp(this.PlayerId), .. EnumCharacterTree(this.PlayerId)]
            };


        }

        public GameCharacterSkillDTO GetGameCharacterSkills(GameCharacterObjectDTO characterObjectDTO)
        {
            if (characterObjectDTO.CharacterId != this.PlayerId.ToString())
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterObjectDTO.CharacterId}");
            }



            return new GameCharacterSkillDTO
            {
                ObjectId = characterObjectDTO.CharacterId,
                SkillInfos = [.. GameResourceCache.EmptySkills, .. this.EnumArtCfg(this.PlayerId), .. this.EnumMagicCfg(this.PlayerId)],
            };

        }

        public GameCharacterSkillDTO UpdateGameCharacterSkill(GameCharacterModifyDTO characterModifyDTO)
        {
            if (characterModifyDTO.CharacterId != this.PlayerId.ToString())
            {
                return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.CharacterId}");
            }



            //   var npcImp = TbNpcImpl.Ptr_TbNpcImpl.M_INSTANCE;


            if (false == string.IsNullOrEmpty(characterModifyDTO.ModifyObject))
            {
                var removeSkillInfo = this.Cache.GameSkills.FirstOrDefault(p => p.DisplayCategory == characterModifyDTO.ModifyCategory && p.ObjectId == characterModifyDTO.ModifyObject);
                if (removeSkillInfo is null)
                {
                    return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.ModifyCategory}:{characterModifyDTO.ModifyObject}");
                }

                if (removeSkillInfo.DisplayCategory == nameof(TbArtCfg)
                    && this.TryGeArtSto(this.PlayerId, removeSkillInfo.ObjectPointer, out var ptr_TbArtSto)
                    && ptr_TbArtSto.FLAG == 0)
                {
                    var artImp = TbArtImpl.Ptr_TbArtImpl.M_INSTANCE;
                    artImp.DEL_ART(ptr_TbArtSto.ID, this.PlayerId);
                    this.Logger.LogInformation("{id}:{info}", this.PlayerId, removeSkillInfo.ToString());
                }
                else if (removeSkillInfo.DisplayCategory == nameof(TbMagicCfg)
                    && this.TryGetMagicSto(this.PlayerId, removeSkillInfo.ObjectPointer, out var ptr_TbMagicSto)
                    && ptr_TbMagicSto.FLAG == 0)
                {
                    var magicImp = TbMagicImpl.Ptr_TbMagicImpl.M_INSTANCE;
                    magicImp.DEL_MAGIC_STO(ptr_TbMagicSto);
                    this.Logger.LogInformation("{id}:{info}", this.PlayerId, removeSkillInfo.ToString());
                }
                else
                {
                    return GameException.Throw<GameCharacterSkillDTO>($"REMOVE ERROR {characterModifyDTO.ModifyCategory}:{characterModifyDTO.ModifyObject}");
                }
            }

            if (false == string.IsNullOrEmpty(characterModifyDTO.NewValue))
            {
                var newSkillInfo = this.Cache.GameSkills.FirstOrDefault(p => p.DisplayCategory == characterModifyDTO.ModifyCategory && p.ObjectId == characterModifyDTO.NewValue);
                if (newSkillInfo is null)
                {
                    return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND {characterModifyDTO.ModifyCategory}:{characterModifyDTO.NewValue}");
                }

                if (newSkillInfo.DisplayCategory == nameof(TbArtCfg))
                {
                    //   npcImp.ADD_NPC_ART(this.PlayerId, new TbArtCfg.Ptr_TbArtCfg(newSkillInfo.ObjectPointer).ID);

                    var artCfg = new TbArtCfg.Ptr_TbArtCfg(newSkillInfo.ObjectPointer);
                    var artImp = TbArtImpl.Ptr_TbArtImpl.M_INSTANCE;
                    var ref_BlendId = new BlendId.Ref_BlendId
                    {
                        blendEnum = artCfg.BLEND_ENUM,
                        sedId = artCfg.ID,
                    };
                    artImp.DO_STUDY_ART(ref_BlendId, this.PlayerId);
                    this.Logger.LogInformation("{id}:{info}", this.PlayerId, newSkillInfo.ToString());

                }
                else if (newSkillInfo.DisplayCategory == nameof(TbMagicCfg))
                {
                    var magicCfg = new TbMagicCfg.Ptr_TbMagicCfg(newSkillInfo.ObjectPointer);
                    var magicImp = TbMagicImpl.Ptr_TbMagicImpl.M_INSTANCE;
                    var ref_BlendId = new BlendId.Ref_BlendId
                    {
                        blendEnum = magicCfg.BLEND_ENUM,
                        sedId = magicCfg.ID,
                    };
                    magicImp.DO_STUDY_MAGIC_BY_MAGIC_ID(ref_BlendId, false);
                    this.Logger.LogInformation("{id}:{info}", this.PlayerId, newSkillInfo.ToString());
                }
                else
                {
                    return GameException.Throw<GameCharacterSkillDTO>($"ADD ERROR {characterModifyDTO.ModifyCategory}:{characterModifyDTO.NewValue}");
                }

            }



            return new GameCharacterSkillDTO
            {
                ObjectId = characterModifyDTO.CharacterId,
                SkillInfos = [.. GameResourceCache.EmptySkills, .. this.EnumArtCfg(this.PlayerId), .. this.EnumMagicCfg(this.PlayerId)],
            };
        }
        #endregion

        #region Inventory
        private bool TryFindItemCfg(GameInventoryObjectDTO inventoryObjectDTO, [MaybeNullWhen(false)] out GameInventoryDisplayDTOEX inventoryDisplayDTOEX)
        {
            Unsafe.SkipInit(out inventoryDisplayDTOEX);
            inventoryDisplayDTOEX = this.Cache.GameInventories.FirstOrDefault(p =>
            p.DisplayCategory == inventoryObjectDTO.InventoryCategory
            && p.ObjectId == inventoryObjectDTO.InventoryObject);
            return inventoryDisplayDTOEX is not null;
        }
        private bool TryFindPackSto(int npcId, TbItemCfg.Ptr_TbItemCfg ptr_TbItemCfg, out TbPackSto.Ptr_TbPackSto ptr_TbPackSto)
        {
            Unsafe.SkipInit(out ptr_TbPackSto);
            foreach (var pack in this.Ptr_TbActor._PACK_STO_LIST.AsEnumerable())
            {
                if (pack.NPC_STO_ID == npcId)
                {
                    var ref_blend = pack.ITEM_ID;
                    if (ref_blend.blendEnum == ptr_TbItemCfg.BLEND_ENUM && ref_blend.sedId == ptr_TbItemCfg.ID)
                    {
                        ptr_TbPackSto = pack;
                        return true;
                    }
                }

            }
            return false;
        }

        public GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (!this.TryFindItemCfg(inventoryObjectDTO, out var inventoryDisplayDTOEX))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryObjectDTO.InventoryCategory}:{inventoryObjectDTO.InventoryObject}");
            }
            var info = new GameInventoryInfoDTO
            {
                ObjectId = inventoryObjectDTO.InventoryObject,
            };
            if (TryFindPackSto(this.PlayerId, inventoryDisplayDTOEX.ObjectPointer, out var ptr_TbPackSto))
            {
                //this.Logger.LogInformation("{p}-{desc}--{pack}-{COUNT}",
                //    inventoryDisplayDTOEX.ObjectPointer.ToString("X8"),
                //    inventoryDisplayDTOEX.ToString(),
                //    ptr_TbPackSto.Ptr.ToString("X8"),
                //    ptr_TbPackSto.HAVE_COUNT.ToString());

                info.DisplayValue = ptr_TbPackSto.HAVE_COUNT.ToString();
            }
            return info;
        }

        public GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryModifyDTO)
        {
            if (!this.TryFindItemCfg(inventoryModifyDTO, out var inventoryDisplayDTOEX))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND {inventoryModifyDTO.InventoryCategory}:{inventoryModifyDTO.InventoryObject}");
            }

            if (!long.TryParse(inventoryModifyDTO.NewValue, out var number))
            {
                number = 1;
            }

            if (TryFindPackSto(this.PlayerId, inventoryDisplayDTOEX.ObjectPointer, out var ptr_TbPackSto))
            {
                number -= ptr_TbPackSto.HAVE_COUNT;
            }

            TbItemCfg.Ptr_TbItemCfg ptr_TbItemCfg = inventoryDisplayDTOEX.ObjectPointer;
            var ref_blend = new BlendId.Ref_BlendId
            {
                blendEnum = ptr_TbItemCfg.BLEND_ENUM,
                sedId = ptr_TbItemCfg.ID,
            };
            if (number > 0)
            {
                this.Ptr_BsBagImpl.ADD_PACK_STO(ref_blend, number, this.PlayerId, false, false, false);
            }
            else
            {
                this.Ptr_BsBagImpl.DEL_PACK_STO(ref_blend, -number, this.PlayerId, false);
            }

            var info = new GameInventoryInfoDTO
            {
                ObjectId = inventoryModifyDTO.InventoryObject,
                DisplayValue = inventoryModifyDTO.NewValue,
            };

            return info;
        }
        #endregion

    }
}
