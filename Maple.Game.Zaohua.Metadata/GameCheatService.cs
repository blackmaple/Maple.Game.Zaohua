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
            foreach (var tree in this.Cache.GameObjects.Where(p=>p.DisplayCategory == nameof(TbTreeCfg)))
            {
                var ptrTreeCfg = new TbTreeCfg .Ptr_TbTreeCfg (tree.ObjectPointer);
                var sto = treeStos.FirstOrDefault(p => p.TREE_ID == ptrTreeCfg.ID);
                yield return new GameSwitchDisplayDTO()
                {
                    ObjectId = tree.ObjectId,
                    DisplayName = tree.DisplayName,
                    DisplayCategory = tree.DisplayCategory,
                    DisplayDesc = tree.DisplayDesc,
                    DisplayImage = tree.DisplayImage,
                    UIType = (int)EnumGameSwitchUIType.Switches,
                    CanWrite = true,
                    SwitchValue = sto.IsNotNull() && sto.IS_STUDY
                };

            }

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
                CharacterAttributes = [.. EnumCharacterTree(this.PlayerId)]
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
