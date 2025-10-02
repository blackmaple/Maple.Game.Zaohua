using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbActor"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbActor>, Ptr_TbActor>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbActor", "TbActor")]
    public partial class TbActor
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbActor(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbActor(System.IntPtr ptr) => new Ptr_TbActor(ptr);
            public static implicit operator System.IntPtr(Ptr_TbActor ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_TbActor ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbActor"]
        /// </summary>
        partial struct Ptr_TbActor
        {
            /// <summary>
            /// 0x10 System.Object _syncLock
            /// class ["mscorlib"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncLock", "System.Object")]
           public partial nint _SYNC_LOCK { get; set; } 
*/

            /// <summary>
            /// 0x18 TbFileSto _fileSto
            /// class ["Assembly-CSharp".""."TbFileSto"]
            /// </summary>
            /// <returns>class TbFileSto</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_fileSto", "TbFileSto")]
           public partial nint _FILE_STO { get; set; } 
*/

            /// <summary>
            /// 0x20 TbPlayerSto _playerSto
            /// class ["Assembly-CSharp".""."TbPlayerSto"]
            /// </summary>
            /// <returns>class TbPlayerSto</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_playerSto", "TbPlayerSto")]
            public partial TbPlayerSto.Ptr_TbPlayerSto _PLAYER_STO { get; set; }


            /// <summary>
            /// 0x28 System.Collections.Generic.List<TbArtSto> _artStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_artStoList", "System.Collections.Generic.List<TbArtSto>")]
           public partial SysPtrList<TbArtSto.Ptr_TbArtSto> _ART_STO_LIST { get; set; } 


            /// <summary>
            /// 0x30 System.Collections.Generic.List<TbArtLogSto> _artLogStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtLogSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_artLogStoList", "System.Collections.Generic.List<TbArtLogSto>")]
           public partial nint _ART_LOG_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<TbMagicSto> _magicStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_magicStoList", "System.Collections.Generic.List<TbMagicSto>")]
           public partial SysPtrList<TbMagicSto.Ptr_TbMagicSto> _MAGIC_STO_LIST { get; set; } 


            /// <summary>
            /// 0x40 System.Collections.Generic.List<TbQuickItemSto> _quickItemStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuickItemSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_quickItemStoList", "System.Collections.Generic.List<TbQuickItemSto>")]
           public partial nint _QUICK_ITEM_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<TbDantianSto> _dantianStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_dantianStoList", "System.Collections.Generic.List<TbDantianSto>")]
           public partial nint _DANTIAN_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.List<TbDantianUpSto> _dantianUpStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianUpSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_dantianUpStoList", "System.Collections.Generic.List<TbDantianUpSto>")]
           public partial nint _DANTIAN_UP_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.List<TbDantianCbSto> _dantianCombinationSto
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianCbSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_dantianCombinationSto", "System.Collections.Generic.List<TbDantianCbSto>")]
           public partial nint _DANTIAN_COMBINATION_STO { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<TbEquipEffectSto> _equipEffectStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEquipEffectSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_equipEffectStoList", "System.Collections.Generic.List<TbEquipEffectSto>")]
           public partial nint _EQUIP_EFFECT_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<TbEquipEffectRecordSto> _equipEffectRecordStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEquipEffectRecordSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_equipEffectRecordStoList", "System.Collections.Generic.List<TbEquipEffectRecordSto>")]
           public partial nint _EQUIP_EFFECT_RECORD_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<TbTreeSto> _treeStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreeSto></returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_treeStoList", "System.Collections.Generic.List<TbTreeSto>")]
           public partial SysPtrList<TbTreeSto.Ptr_TbTreeSto> _TREE_STO_LIST { get; set; } 


            /// <summary>
            /// 0x78 System.Collections.Generic.List<TbNpcSto> _npcStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcSto></returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_npcStoList", "System.Collections.Generic.List<TbNpcSto>")]
           public partial SysPtrList<TbNpcSto.Ptr_TbNpcSto> _NPC_STO_LIST { get; set; } 


            /// <summary>
            /// 0x80 System.Collections.Generic.List<TbNpcPlaceSto> _npcPlaceStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcPlaceSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_npcPlaceStoList", "System.Collections.Generic.List<TbNpcPlaceSto>")]
           public partial nint _NPC_PLACE_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<TbNpcPlaceCacheSto> _npcPlaceCacheStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcPlaceCacheSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_npcPlaceCacheStoList", "System.Collections.Generic.List<TbNpcPlaceCacheSto>")]
           public partial nint _NPC_PLACE_CACHE_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<TbPackSto> _packStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_packStoList", "System.Collections.Generic.List<TbPackSto>")]
           public partial SysPtrList<TbPackSto.Ptr_TbPackSto> _PACK_STO_LIST { get; set; } 


            /// <summary>
            /// 0x98 System.Collections.Generic.List<TbDrugMaxSto> _drugMaxStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDrugMaxSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_drugMaxStoList", "System.Collections.Generic.List<TbDrugMaxSto>")]
           public partial nint _DRUG_MAX_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Collections.Generic.List<TbShopSto> _shopStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbShopSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_shopStoList", "System.Collections.Generic.List<TbShopSto>")]
           public partial nint _SHOP_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Collections.Generic.List<TbShopItemSto> _shopItemStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbShopItemSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_shopItemStoList", "System.Collections.Generic.List<TbShopItemSto>")]
           public partial nint _SHOP_ITEM_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.List<TbFusionSto> _fusionStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFusionSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_fusionStoList", "System.Collections.Generic.List<TbFusionSto>")]
           public partial nint _FUSION_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<TbArtCfg> _fusionArtList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtCfg></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_fusionArtList", "System.Collections.Generic.List<TbArtCfg>")]
           public partial nint _FUSION_ART_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Collections.Generic.List<TbMagicCfg> _fusionMagicList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicCfg></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_fusionMagicList", "System.Collections.Generic.List<TbMagicCfg>")]
           public partial nint _FUSION_MAGIC_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<TbMapSto> _mapStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mapStoList", "System.Collections.Generic.List<TbMapSto>")]
           public partial nint _MAP_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<TbMapEventSto> _mapEventStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapEventSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mapEventStoList", "System.Collections.Generic.List<TbMapEventSto>")]
           public partial nint _MAP_EVENT_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<TbRandomSto> _randomStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRandomSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_randomStoList", "System.Collections.Generic.List<TbRandomSto>")]
           public partial nint _RANDOM_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Collections.Generic.List<TbTreasureHuntSto> _treasureHuntStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreasureHuntSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_treasureHuntStoList", "System.Collections.Generic.List<TbTreasureHuntSto>")]
           public partial nint _TREASURE_HUNT_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Collections.Generic.List<TbPlayerTaskSto> _playerTaskStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlayerTaskSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_playerTaskStoList", "System.Collections.Generic.List<TbPlayerTaskSto>")]
           public partial nint _PLAYER_TASK_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Collections.Generic.List<TbDeaconTaskSto> _deaconTaskStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDeaconTaskSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_deaconTaskStoList", "System.Collections.Generic.List<TbDeaconTaskSto>")]
           public partial nint _DEACON_TASK_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.List<TbBattleStatSto> _battleStatStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbBattleStatSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_battleStatStoList", "System.Collections.Generic.List<TbBattleStatSto>")]
           public partial nint _BATTLE_STAT_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Collections.Generic.List<TbReadPlaySto> _readPlayStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbReadPlaySto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_readPlayStoList", "System.Collections.Generic.List<TbReadPlaySto>")]
           public partial nint _READ_PLAY_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Collections.Generic.List<TbOverPlaySto> _overPlayStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbOverPlaySto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_overPlayStoList", "System.Collections.Generic.List<TbOverPlaySto>")]
           public partial nint _OVER_PLAY_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Collections.Generic.List<TbEndRewardSto> _endRewardStoList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEndRewardSto></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_endRewardStoList", "System.Collections.Generic.List<TbEndRewardSto>")]
           public partial nint _END_REWARD_STO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Int32 _id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_id", "System.Int32")]
           public partial System.Int32 _ID { get; set; } 
*/

            /// <summary>
            /// 0x11C System.Int32 _randomSeed
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_randomSeed", "System.Int32")]
           public partial System.Int32 _RANDOM_SEED { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbActor"]
        /// </summary>
        partial struct Ptr_TbActor
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtLogSto> get_artLogStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtLogSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_artLogStoList", "System.Collections.Generic.List<TbArtLogSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ART_LOG_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> get_artStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_artStoList", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ART_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStatSto> get_battleStatStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbBattleStatSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_battleStatStoList", "System.Collections.Generic.List<TbBattleStatSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_STAT_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDantianCbSto> get_dantianCombinationSto()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianCbSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dantianCombinationSto", "System.Collections.Generic.List<TbDantianCbSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DANTIAN_COMBINATION_STO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDantianSto> get_dantianStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dantianStoList", "System.Collections.Generic.List<TbDantianSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DANTIAN_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDantianUpSto> get_dantianUpStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianUpSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dantianUpStoList", "System.Collections.Generic.List<TbDantianUpSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DANTIAN_UP_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDeaconTaskSto> get_deaconTaskStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDeaconTaskSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_deaconTaskStoList", "System.Collections.Generic.List<TbDeaconTaskSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEACON_TASK_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDrugMaxSto> get_drugMaxStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDrugMaxSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_drugMaxStoList", "System.Collections.Generic.List<TbDrugMaxSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DRUG_MAX_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbEndRewardSto> get_endRewardStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEndRewardSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_endRewardStoList", "System.Collections.Generic.List<TbEndRewardSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_END_REWARD_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbEquipEffectRecordSto> get_equipEffectRecordStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEquipEffectRecordSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_equipEffectRecordStoList", "System.Collections.Generic.List<TbEquipEffectRecordSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EQUIP_EFFECT_RECORD_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbEquipEffectSto> get_equipEffectStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEquipEffectSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_equipEffectStoList", "System.Collections.Generic.List<TbEquipEffectSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EQUIP_EFFECT_STO_LIST(); 
*/
            /// <summary>
            ///   TbFileSto get_fileSto()
            /// </summary>
            /// <returns>class TbFileSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_fileSto", "TbFileSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FILE_STO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtCfg> get_FusionArtList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FusionArtList", "System.Collections.Generic.List<TbArtCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FUSION_ART_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicCfg> get_FusionMagicList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FusionMagicList", "System.Collections.Generic.List<TbMagicCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FUSION_MAGIC_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbFusionSto> get_fusionStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFusionSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_fusionStoList", "System.Collections.Generic.List<TbFusionSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FUSION_STO_LIST(); 
*/
            /// <summary>
            ///   System.Int32 get_id()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_id", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ID(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> get_magicStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_magicStoList", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAGIC_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMapEventSto> get_mapEventStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapEventSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mapEventStoList", "System.Collections.Generic.List<TbMapEventSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_EVENT_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMapSto> get_mapStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mapStoList", "System.Collections.Generic.List<TbMapSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcPlaceCacheSto> get_npcPlaceCacheStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcPlaceCacheSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_npcPlaceCacheStoList", "System.Collections.Generic.List<TbNpcPlaceCacheSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NPC_PLACE_CACHE_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcPlaceSto> get_npcPlaceStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcPlaceSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_npcPlaceStoList", "System.Collections.Generic.List<TbNpcPlaceSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NPC_PLACE_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcSto> get_npcStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_npcStoList", "System.Collections.Generic.List<TbNpcSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NPC_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbOverPlaySto> get_overPlayStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbOverPlaySto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_overPlayStoList", "System.Collections.Generic.List<TbOverPlaySto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OVER_PLAY_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> get_packStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_packStoList", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PACK_STO_LIST(); 
*/
            /// <summary>
            ///   TbPlayerSto get_playerSto()
            /// </summary>
            /// <returns>class TbPlayerSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_playerSto", "TbPlayerSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_STO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPlayerTaskSto> get_playerTaskStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlayerTaskSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_playerTaskStoList", "System.Collections.Generic.List<TbPlayerTaskSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_TASK_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbQuickItemSto> get_quickItemStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuickItemSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_quickItemStoList", "System.Collections.Generic.List<TbQuickItemSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_QUICK_ITEM_STO_LIST(); 
*/
            /// <summary>
            ///   System.Int32 get_randomSeed()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_randomSeed", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_RANDOM_SEED(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbRandomSto> get_randomStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRandomSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_randomStoList", "System.Collections.Generic.List<TbRandomSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RANDOM_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbReadPlaySto> get_readPlayStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbReadPlaySto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_readPlayStoList", "System.Collections.Generic.List<TbReadPlaySto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_READ_PLAY_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbShopItemSto> get_shopItemStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbShopItemSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_shopItemStoList", "System.Collections.Generic.List<TbShopItemSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SHOP_ITEM_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbShopSto> get_shopStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbShopSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_shopStoList", "System.Collections.Generic.List<TbShopSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SHOP_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbTreasureHuntSto> get_treasureHuntStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreasureHuntSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_treasureHuntStoList", "System.Collections.Generic.List<TbTreasureHuntSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TREASURE_HUNT_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbTreeSto> get_treeStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreeSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_treeStoList", "System.Collections.Generic.List<TbTreeSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TREE_STO_LIST(); 
*/
            /// <summary>
            ///   System.Void set_artLogStoList(System.Collections.Generic.List<TbArtLogSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbArtLogSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_artLogStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtLogSto>", 0)]
            public partial void SET_ART_LOG_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_artStoList(System.Collections.Generic.List<TbArtSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbArtSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_artStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtSto>", 0)]
            public partial void SET_ART_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_battleStatStoList(System.Collections.Generic.List<TbBattleStatSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbBattleStatSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_battleStatStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbBattleStatSto>", 0)]
            public partial void SET_BATTLE_STAT_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_dantianCombinationSto(System.Collections.Generic.List<TbDantianCbSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbDantianCbSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_dantianCombinationSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbDantianCbSto>", 0)]
            public partial void SET_DANTIAN_COMBINATION_STO(nint value); 
*/
            /// <summary>
            ///   System.Void set_dantianStoList(System.Collections.Generic.List<TbDantianSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbDantianSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_dantianStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbDantianSto>", 0)]
            public partial void SET_DANTIAN_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_dantianUpStoList(System.Collections.Generic.List<TbDantianUpSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbDantianUpSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_dantianUpStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbDantianUpSto>", 0)]
            public partial void SET_DANTIAN_UP_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_deaconTaskStoList(System.Collections.Generic.List<TbDeaconTaskSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbDeaconTaskSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_deaconTaskStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbDeaconTaskSto>", 0)]
            public partial void SET_DEACON_TASK_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_drugMaxStoList(System.Collections.Generic.List<TbDrugMaxSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbDrugMaxSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_drugMaxStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbDrugMaxSto>", 0)]
            public partial void SET_DRUG_MAX_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_endRewardStoList(System.Collections.Generic.List<TbEndRewardSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbEndRewardSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_endRewardStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbEndRewardSto>", 0)]
            public partial void SET_END_REWARD_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_equipEffectRecordStoList(System.Collections.Generic.List<TbEquipEffectRecordSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbEquipEffectRecordSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_equipEffectRecordStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbEquipEffectRecordSto>", 0)]
            public partial void SET_EQUIP_EFFECT_RECORD_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_equipEffectStoList(System.Collections.Generic.List<TbEquipEffectSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbEquipEffectSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_equipEffectStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbEquipEffectSto>", 0)]
            public partial void SET_EQUIP_EFFECT_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_fileSto(TbFileSto value)
            /// </summary>
            /// <param name = "value">class TbFileSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_fileSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbFileSto", 0)]
            public partial void SET_FILE_STO(nint value); 
*/
            /// <summary>
            ///   System.Void set_FusionArtList(System.Collections.Generic.List<TbArtCfg> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbArtCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FusionArtList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtCfg>", 0)]
            public partial void SET_FUSION_ART_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_FusionMagicList(System.Collections.Generic.List<TbMagicCfg> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbMagicCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FusionMagicList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicCfg>", 0)]
            public partial void SET_FUSION_MAGIC_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_fusionStoList(System.Collections.Generic.List<TbFusionSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbFusionSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_fusionStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbFusionSto>", 0)]
            public partial void SET_FUSION_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_id(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_magicStoList(System.Collections.Generic.List<TbMagicSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbMagicSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_magicStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicSto>", 0)]
            public partial void SET_MAGIC_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_mapEventStoList(System.Collections.Generic.List<TbMapEventSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbMapEventSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_mapEventStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMapEventSto>", 0)]
            public partial void SET_MAP_EVENT_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_mapStoList(System.Collections.Generic.List<TbMapSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbMapSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_mapStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMapSto>", 0)]
            public partial void SET_MAP_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_npcPlaceCacheStoList(System.Collections.Generic.List<TbNpcPlaceCacheSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbNpcPlaceCacheSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_npcPlaceCacheStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcPlaceCacheSto>", 0)]
            public partial void SET_NPC_PLACE_CACHE_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_npcPlaceStoList(System.Collections.Generic.List<TbNpcPlaceSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbNpcPlaceSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_npcPlaceStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcPlaceSto>", 0)]
            public partial void SET_NPC_PLACE_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_npcStoList(System.Collections.Generic.List<TbNpcSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbNpcSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_npcStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcSto>", 0)]
            public partial void SET_NPC_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_overPlayStoList(System.Collections.Generic.List<TbOverPlaySto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbOverPlaySto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_overPlayStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbOverPlaySto>", 0)]
            public partial void SET_OVER_PLAY_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_packStoList(System.Collections.Generic.List<TbPackSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbPackSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_packStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbPackSto>", 0)]
            public partial void SET_PACK_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_playerSto(TbPlayerSto value)
            /// </summary>
            /// <param name = "value">class TbPlayerSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_playerSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPlayerSto", 0)]
            public partial void SET_PLAYER_STO(nint value); 
*/
            /// <summary>
            ///   System.Void set_playerTaskStoList(System.Collections.Generic.List<TbPlayerTaskSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbPlayerTaskSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_playerTaskStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbPlayerTaskSto>", 0)]
            public partial void SET_PLAYER_TASK_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_quickItemStoList(System.Collections.Generic.List<TbQuickItemSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbQuickItemSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_quickItemStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbQuickItemSto>", 0)]
            public partial void SET_QUICK_ITEM_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_randomSeed(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_randomSeed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_RANDOM_SEED(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_randomStoList(System.Collections.Generic.List<TbRandomSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbRandomSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_randomStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbRandomSto>", 0)]
            public partial void SET_RANDOM_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_readPlayStoList(System.Collections.Generic.List<TbReadPlaySto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbReadPlaySto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_readPlayStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbReadPlaySto>", 0)]
            public partial void SET_READ_PLAY_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_shopItemStoList(System.Collections.Generic.List<TbShopItemSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbShopItemSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_shopItemStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbShopItemSto>", 0)]
            public partial void SET_SHOP_ITEM_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_shopStoList(System.Collections.Generic.List<TbShopSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbShopSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_shopStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbShopSto>", 0)]
            public partial void SET_SHOP_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_treasureHuntStoList(System.Collections.Generic.List<TbTreasureHuntSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbTreasureHuntSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_treasureHuntStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbTreasureHuntSto>", 0)]
            public partial void SET_TREASURE_HUNT_STO_LIST(nint value); 
*/
            /// <summary>
            ///   System.Void set_treeStoList(System.Collections.Generic.List<TbTreeSto> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbTreeSto></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_treeStoList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbTreeSto>", 0)]
            public partial void SET_TREE_STO_LIST(nint value); 
*/
        }
    }
}