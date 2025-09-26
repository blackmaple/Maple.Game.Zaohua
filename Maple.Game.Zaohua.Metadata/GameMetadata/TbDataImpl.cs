namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbDataImpl"]
    /// [Singleton<TbDataImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbDataImpl>, Ptr_TbDataImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbDataImpl", "TbDataImpl")]
    public partial class TbDataImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbDataImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbDataImpl(System.IntPtr ptr) => new Ptr_TbDataImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbDataImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbDataImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbDataImpl"]
        /// </summary>
        partial struct Ptr_TbDataImpl
        {
            /// <summary>
            /// 0x0 System.String ConfigPath
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint CONFIG_PATH = Xml/; 
*/
            /// <summary>
            /// 0x0 System.String JsonPath
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint JSON_PATH = Json/; 
*/
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , System.String> RenameDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RenameDic", "System.Collections.Generic.Dictionary<System.String,System.String>")]
            public static partial nint RENAME_DIC { get; set; } 
*/

            /// <summary>
            /// 0x0 TbDataImpl m_Instance
            /// class ["Assembly-CSharp".""."TbDataImpl"]
            /// </summary>
            /// <returns>class TbDataImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbDataImpl")]
            public static partial nint M_INSTANCE { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.List<TbPlayCfg> <NpcPlayCfg>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlayCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<NpcPlayCfg>k__BackingField", "System.Collections.Generic.List<TbPlayCfg>")]
            public static partial nint NPC_PLAY_CFG { get; set; } 
*/

            /// <summary>
            /// 0x8 System.String m_Lock
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Lock", "System.String")]
            public static partial nint M_LOCK { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Collections.Generic.List<TbBgmCfg> bgmCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbBgmCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bgmCfgList", "System.Collections.Generic.List<TbBgmCfg>")]
            public partial nint BGM_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<TbSoundCfg> soundCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSoundCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("soundCfgList", "System.Collections.Generic.List<TbSoundCfg>")]
            public partial nint SOUND_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<TbMapCfg> mapCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapCfgList", "System.Collections.Generic.List<TbMapCfg>")]
            public partial nint MAP_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<TbTileCfg> tileCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTileCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tileCfgList", "System.Collections.Generic.List<TbTileCfg>")]
            public partial nint TILE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<TbTileExcelCfg> tileExcelCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTileExcelCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tileExcelCfgList", "System.Collections.Generic.List<TbTileExcelCfg>")]
            public partial nint TILE_EXCEL_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<TbLingqiGenCfg> lingqiGenCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbLingqiGenCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lingqiGenCfgList", "System.Collections.Generic.List<TbLingqiGenCfg>")]
            public partial nint LINGQI_GEN_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<TbPlaceTypeCfg> placeTypeCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlaceTypeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("placeTypeCfgList", "System.Collections.Generic.List<TbPlaceTypeCfg>")]
            public partial nint PLACE_TYPE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<TbMapObjectCfg> mapObjectCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapObjectCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapObjectCfgList", "System.Collections.Generic.List<TbMapObjectCfg>")]
            public partial nint MAP_OBJECT_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.List<TbMapRandomCfg> mapRandomCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapRandomCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapRandomCfgList", "System.Collections.Generic.List<TbMapRandomCfg>")]
            public partial nint MAP_RANDOM_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.List<TbTerrainCfg> terrainList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTerrainCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("terrainList", "System.Collections.Generic.List<TbTerrainCfg>")]
            public partial nint TERRAIN_LIST { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<TbNameCfg> nameList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNameCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nameList", "System.Collections.Generic.List<TbNameCfg>")]
            public partial nint NAME_LIST { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<TbFunctionCfg> functionList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFunctionCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("functionList", "System.Collections.Generic.List<TbFunctionCfg>")]
            public partial nint FUNCTION_LIST { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<TbBuildCfg> buildList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbBuildCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buildList", "System.Collections.Generic.List<TbBuildCfg>")]
            public partial nint BUILD_LIST { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<TbChapterCfg> chapterList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbChapterCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chapterList", "System.Collections.Generic.List<TbChapterCfg>")]
            public partial nint CHAPTER_LIST { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.List<TbWeatherCfg> weatherList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbWeatherCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weatherList", "System.Collections.Generic.List<TbWeatherCfg>")]
            public partial nint WEATHER_LIST { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<TbCgCfg> cgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbCgCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cgList", "System.Collections.Generic.List<TbCgCfg>")]
            public partial nint CG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<TbSceneCfg> sceneList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSceneCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sceneList", "System.Collections.Generic.List<TbSceneCfg>")]
            public partial nint SCENE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.List<TbPlayCfg> playCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlayCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playCfgList", "System.Collections.Generic.List<TbPlayCfg>")]
            public partial nint PLAY_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Collections.Generic.List<TbActCfg> actList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbActCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("actList", "System.Collections.Generic.List<TbActCfg>")]
            public partial nint ACT_LIST { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Collections.Generic.List<TbPathCfg> pathList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPathCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pathList", "System.Collections.Generic.List<TbPathCfg>")]
            public partial nint PATH_LIST { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.List<TbNpcCfg> npcCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcCfgList", "System.Collections.Generic.List<TbNpcCfg>")]
            public partial nint NPC_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<TbRoleCfg> roleList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRoleCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("roleList", "System.Collections.Generic.List<TbRoleCfg>")]
            public partial nint ROLE_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Collections.Generic.List<TbPracCfg> pracList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPracCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pracList", "System.Collections.Generic.List<TbPracCfg>")]
            public partial nint PRAC_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<TbAttribCfg> attribList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbAttribCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attribList", "System.Collections.Generic.List<TbAttribCfg>")]
            public partial nint ATTRIB_LIST { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<TbEnemyCfg> enemyList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEnemyCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("enemyList", "System.Collections.Generic.List<TbEnemyCfg>")]
            public partial nint ENEMY_LIST { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<TbLayerCfg> layerList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbLayerCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("layerList", "System.Collections.Generic.List<TbLayerCfg>")]
            public partial nint LAYER_LIST { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Collections.Generic.List<TbLvCfg> lvList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbLvCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lvList", "System.Collections.Generic.List<TbLvCfg>")]
            public partial nint LV_LIST { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Collections.Generic.List<TbAscensionCfg> ascensionList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbAscensionCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ascensionList", "System.Collections.Generic.List<TbAscensionCfg>")]
            public partial nint ASCENSION_LIST { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Collections.Generic.List<TbSectCfg> sectList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSectCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sectList", "System.Collections.Generic.List<TbSectCfg>")]
            public partial nint SECT_LIST { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.List<TbPostCfg> postList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPostCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("postList", "System.Collections.Generic.List<TbPostCfg>")]
            public partial nint POST_LIST { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Collections.Generic.List<TbEndRewardCfg> endRewardList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEndRewardCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("endRewardList", "System.Collections.Generic.List<TbEndRewardCfg>")]
            public partial nint END_REWARD_LIST { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Collections.Generic.List<TbGlobalModifierCfg> globalModifierList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbGlobalModifierCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("globalModifierList", "System.Collections.Generic.List<TbGlobalModifierCfg>")]
            public partial nint GLOBAL_MODIFIER_LIST { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Collections.Generic.List<TbNpcPlaceCfg> npcPlaceCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbNpcPlaceCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcPlaceCfgList", "System.Collections.Generic.List<TbNpcPlaceCfg>")]
            public partial nint NPC_PLACE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Collections.Generic.List<TbItemCfg> itemCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbItemCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemCfgList", "System.Collections.Generic.List<TbItemCfg>")]
            public partial nint ITEM_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Collections.Generic.List<TbTypeCfg> typeCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTypeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("typeCfgList", "System.Collections.Generic.List<TbTypeCfg>")]
            public partial nint TYPE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Collections.Generic.List<TbGradeCfg> gradeCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbGradeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gradeCfgList", "System.Collections.Generic.List<TbGradeCfg>")]
            public partial nint GRADE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<TbValueCfg> valueCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbValueCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("valueCfgList", "System.Collections.Generic.List<TbValueCfg>")]
            public partial nint VALUE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Collections.Generic.List<TbArtCfg> artList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("artList", "System.Collections.Generic.List<TbArtCfg>")]
            public partial nint ART_LIST { get; set; } 
*/

            /// <summary>
            /// 0x140 System.Collections.Generic.List<TbMagicCfg> magicList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magicList", "System.Collections.Generic.List<TbMagicCfg>")]
            public partial nint MAGIC_LIST { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Collections.Generic.List<TbQuickCfg> quickList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuickCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("quickList", "System.Collections.Generic.List<TbQuickCfg>")]
            public partial nint QUICK_LIST { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Collections.Generic.List<TbMapEventCfg> mapEventList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapEventCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapEventList", "System.Collections.Generic.List<TbMapEventCfg>")]
            public partial nint MAP_EVENT_LIST { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Collections.Generic.List<TbEventCfg> eventList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEventCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eventList", "System.Collections.Generic.List<TbEventCfg>")]
            public partial nint EVENT_LIST { get; set; } 
*/

            /// <summary>
            /// 0x160 System.Collections.Generic.List<TbTradeCfg> tradeCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTradeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tradeCfgList", "System.Collections.Generic.List<TbTradeCfg>")]
            public partial nint TRADE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x168 System.Collections.Generic.List<TbPriceCfg> priceList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPriceCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("priceList", "System.Collections.Generic.List<TbPriceCfg>")]
            public partial nint PRICE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x170 System.Collections.Generic.List<TbFindCfg> findList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFindCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("findList", "System.Collections.Generic.List<TbFindCfg>")]
            public partial nint FIND_LIST { get; set; } 
*/

            /// <summary>
            /// 0x178 System.Collections.Generic.List<TbShopFixCfg> shopFixList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbShopFixCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shopFixList", "System.Collections.Generic.List<TbShopFixCfg>")]
            public partial nint SHOP_FIX_LIST { get; set; } 
*/

            /// <summary>
            /// 0x180 System.Collections.Generic.List<TbTaskCfg> taskList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTaskCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("taskList", "System.Collections.Generic.List<TbTaskCfg>")]
            public partial nint TASK_LIST { get; set; } 
*/

            /// <summary>
            /// 0x188 System.Collections.Generic.List<TbMapTaskCfg> mapTaskList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMapTaskCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapTaskList", "System.Collections.Generic.List<TbMapTaskCfg>")]
            public partial nint MAP_TASK_LIST { get; set; } 
*/

            /// <summary>
            /// 0x190 System.Collections.Generic.List<TbStateCfg> stateList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStateCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("stateList", "System.Collections.Generic.List<TbStateCfg>")]
            public partial nint STATE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x198 System.Collections.Generic.List<TbRandomCfg> RandomList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRandomCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RandomList", "System.Collections.Generic.List<TbRandomCfg>")]
            public partial nint RANDOM_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1A0 System.Collections.Generic.List<TbUpLogCfg> UpLogList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbUpLogCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UpLogList", "System.Collections.Generic.List<TbUpLogCfg>")]
            public partial nint UP_LOG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1A8 System.Collections.Generic.List<TbUpLogMessageCfg> UpLogMessageList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbUpLogMessageCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UpLogMessageList", "System.Collections.Generic.List<TbUpLogMessageCfg>")]
            public partial nint UP_LOG_MESSAGE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1B0 System.Collections.Generic.List<TbFolderCfg> folderCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFolderCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("folderCfgList", "System.Collections.Generic.List<TbFolderCfg>")]
            public partial nint FOLDER_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1B8 System.Collections.Generic.List<TbEndCfg> endList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEndCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("endList", "System.Collections.Generic.List<TbEndCfg>")]
            public partial nint END_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1C0 System.Collections.Generic.List<TbDrawCfg> drawCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDrawCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("drawCfgList", "System.Collections.Generic.List<TbDrawCfg>")]
            public partial nint DRAW_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1C8 System.Collections.Generic.List<TbDrawStateCfg> drawStateCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDrawStateCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("drawStateCfgList", "System.Collections.Generic.List<TbDrawStateCfg>")]
            public partial nint DRAW_STATE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1D0 System.Collections.Generic.List<TbEquipEffectCfg> equipEffectCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbEquipEffectCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipEffectCfgList", "System.Collections.Generic.List<TbEquipEffectCfg>")]
            public partial nint EQUIP_EFFECT_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1D8 System.Collections.Generic.List<TbTreeCfg> treeCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treeCfgList", "System.Collections.Generic.List<TbTreeCfg>")]
            public partial nint TREE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1E0 System.Collections.Generic.List<TbCreateCfg> createCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbCreateCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("createCfgList", "System.Collections.Generic.List<TbCreateCfg>")]
            public partial nint CREATE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1E8 System.Collections.Generic.List<TLNodeData> allTLNodeData
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TLNodeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("allTLNodeData", "System.Collections.Generic.List<TLNodeData>")]
            public partial nint ALL_TL_NODE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x1F0 System.Collections.Generic.List<TbStoryLineCfg> storyLineCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStoryLineCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("storyLineCfgList", "System.Collections.Generic.List<TbStoryLineCfg>")]
            public partial nint STORY_LINE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x1F8 System.Collections.Generic.List<TbFaceCfg> faceList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFaceCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("faceList", "System.Collections.Generic.List<TbFaceCfg>")]
            public partial nint FACE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x200 System.Collections.Generic.List<TbFaceEmoteCfg> faceEmoteCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFaceEmoteCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("faceEmoteCfgList", "System.Collections.Generic.List<TbFaceEmoteCfg>")]
            public partial nint FACE_EMOTE_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x208 System.Collections.Generic.List<TbFaceDataCfg> allFaces
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbFaceDataCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("allFaces", "System.Collections.Generic.List<TbFaceDataCfg>")]
            public partial nint ALL_FACES { get; set; } 
*/

            /// <summary>
            /// 0x210 System.Collections.Generic.List<TbRuleModelMapCfg> ruleModelMapCfgList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRuleModelMapCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ruleModelMapCfgList", "System.Collections.Generic.List<TbRuleModelMapCfg>")]
            public partial nint RULE_MODEL_MAP_CFG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x218 System.Collections.Generic.List<TbSmallMapCfg> smallMapList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSmallMapCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("smallMapList", "System.Collections.Generic.List<TbSmallMapCfg>")]
            public partial nint SMALL_MAP_LIST { get; set; } 
*/

            /// <summary>
            /// 0x220 System.Collections.Generic.List<TbTestPathCfg> testPathList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTestPathCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("testPathList", "System.Collections.Generic.List<TbTestPathCfg>")]
            public partial nint TEST_PATH_LIST { get; set; } 
*/

            /// <summary>
            /// 0x228 System.Collections.Generic.List<TbQuotationsCfg> quotationsList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuotationsCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("quotationsList", "System.Collections.Generic.List<TbQuotationsCfg>")]
            public partial nint QUOTATIONS_LIST { get; set; } 
*/

            /// <summary>
            /// 0x230 System.Collections.Generic.List<TbSuitCfg> suitList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSuitCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("suitList", "System.Collections.Generic.List<TbSuitCfg>")]
            public partial nint SUIT_LIST { get; set; } 
*/

            /// <summary>
            /// 0x238 System.Collections.Generic.List<FunctionGroup> functionGroupList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<FunctionGroup></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("functionGroupList", "System.Collections.Generic.List<FunctionGroup>")]
            public partial nint FUNCTION_GROUP_LIST { get; set; } 
*/

            /// <summary>
            /// 0x240 System.Collections.Generic.List<FunctionGroup> functionJudGroupList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<FunctionGroup></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("functionJudGroupList", "System.Collections.Generic.List<FunctionGroup>")]
            public partial nint FUNCTION_JUD_GROUP_LIST { get; set; } 
*/

            /// <summary>
            /// 0x248 System.Collections.Generic.Dictionary<System.Int32 , TbMapObjectCfg> mapObjectCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbMapObjectCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapObjectCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbMapObjectCfg>")]
            public partial nint MAP_OBJECT_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x250 System.Collections.Generic.Dictionary<System.Int32 , TbNameCfg> nameCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbNameCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nameCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbNameCfg>")]
            public partial nint NAME_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x258 System.Collections.Generic.Dictionary<System.Int32 , TbTerrainCfg> terrainCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbTerrainCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("terrainCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbTerrainCfg>")]
            public partial nint TERRAIN_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x260 System.Collections.Generic.Dictionary<System.Int32 , TbNpcCfg> npcCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbNpcCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbNpcCfg>")]
            public partial nint NPC_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x268 System.Collections.Generic.Dictionary<System.Int32 , TbFaceCfg> faceCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbFaceCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("faceCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbFaceCfg>")]
            public partial nint FACE_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x270 System.Collections.Generic.Dictionary<System.Int32 , TbMapRandomCfg> mapRandomCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbMapRandomCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapRandomCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbMapRandomCfg>")]
            public partial nint MAP_RANDOM_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x278 System.Collections.Generic.Dictionary<System.Int32 , TbItemCfg> itemCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbItemCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbItemCfg>")]
            public partial nint ITEM_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x280 System.Collections.Generic.Dictionary<System.String , TbPlayCfg> playCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , TbPlayCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playCfgDic", "System.Collections.Generic.Dictionary<System.String,TbPlayCfg>")]
            public partial nint PLAY_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x288 System.Collections.Generic.Dictionary<System.Int32 , TbGradeCfg> gradeCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbGradeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gradeCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbGradeCfg>")]
            public partial nint GRADE_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x290 System.Collections.Generic.Dictionary<System.Int32 , TbMagicCfg> magicCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbMagicCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magicCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbMagicCfg>")]
            public partial nint MAGIC_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x298 System.Collections.Generic.Dictionary<System.Int32 , TbArtCfg> artCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbArtCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("artCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbArtCfg>")]
            public partial nint ART_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2A0 System.Collections.Generic.Dictionary<System.Int32 , TbTypeCfg> typeCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbTypeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("typeCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbTypeCfg>")]
            public partial nint TYPE_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2A8 System.Collections.Generic.Dictionary<System.Int32 , TbEquipEffectCfg> equipEffCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbEquipEffectCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipEffCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbEquipEffectCfg>")]
            public partial nint EQUIP_EFF_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2B0 System.Collections.Generic.Dictionary<System.Int32 , TbLvCfg> lvCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbLvCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lvCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbLvCfg>")]
            public partial nint LV_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2B8 System.Collections.Generic.Dictionary<System.Int32 , TbTradeCfg> tradeCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbTradeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tradeCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbTradeCfg>")]
            public partial nint TRADE_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2C0 System.Collections.Generic.Dictionary<System.Int32 , TbFunctionCfg> functionCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbFunctionCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("functionCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbFunctionCfg>")]
            public partial nint FUNCTION_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2C8 System.Collections.Generic.Dictionary<System.Int32 , TbSuitCfg> suitCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbSuitCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("suitCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbSuitCfg>")]
            public partial nint SUIT_CFG_DIC { get; set; } 
*/

            /// <summary>
            /// 0x2D0 System.Collections.Generic.Dictionary<System.Int32 , TbLayerCfg> layerCfgDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TbLayerCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("layerCfgDic", "System.Collections.Generic.Dictionary<System.Int32,TbLayerCfg>")]
            public partial nint LAYER_CFG_DIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbDataImpl"]
        /// </summary>
        partial struct Ptr_TbDataImpl
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<TbPlayCfg> get_NpcPlayCfg()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbPlayCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NpcPlayCfg", "System.Collections.Generic.List<TbPlayCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_NPC_PLAY_CFG(); 
*/
            /// <summary>
            /// static  System.Void set_NpcPlayCfg(System.Collections.Generic.List<TbPlayCfg> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<TbPlayCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NpcPlayCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbPlayCfg>", 0)]
            public static partial void SET_NPC_PLAY_CFG(nint value); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void ClearAllDic()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearAllDic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_ALL_DIC(); 
*/
            /// <summary>
            ///   TbArtCfg GetArtCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbArtCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtCfg", "TbArtCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ART_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbEquipEffectCfg GetEquipEffCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbEquipEffectCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipEffCfg", "TbEquipEffectCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_EQUIP_EFF_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbFaceCfg GetFaceCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbFaceCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFaceCfg", "TbFaceCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FACE_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbFunctionCfg GetFunctionCfg(System.Int32 functionId)
            /// </summary>
            /// <param name = "functionId">struct System.Int32</param>
            /// <returns>class TbFunctionCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFunctionCfg", "TbFunctionCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FUNCTION_CFG(System.Int32 functionId); 
*/
            /// <summary>
            ///   TbGradeCfg GetGradeCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbGradeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeCfg", "TbGradeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_GRADE_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbItemCfg GetItemCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemCfg", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ITEM_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbLayerCfg GetLayerCfg(System.Int32 layerId)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <returns>class TbLayerCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLayerCfg", "TbLayerCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_LAYER_CFG(System.Int32 layerId); 
*/
            /// <summary>
            ///   TbLvCfg GetLvCfg(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class TbLvCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLvCfg", "TbLvCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_LV_CFG(System.Int32 lvId); 
*/
            /// <summary>
            ///   TbMagicCfg GetMagicCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbMagicCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicCfg", "TbMagicCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbMapObjectCfg GetMapObjectCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbMapObjectCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapObjectCfg", "TbMapObjectCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAP_OBJECT_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbMapRandomCfg GetMapRandomCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbMapRandomCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapRandomCfg", "TbMapRandomCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAP_RANDOM_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbNameCfg GetNameCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbNameCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNameCfg", "TbNameCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NAME_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbNpcCfg GetNpcCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcCfg", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbPlayCfg GetPlayCfg(System.String uuid)
            /// </summary>
            /// <param name = "uuid">class System.String</param>
            /// <returns>class TbPlayCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayCfg", "TbPlayCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_PLAY_CFG(nint uuid); 
*/
            /// <summary>
            ///   TbSuitCfg GetSuitCfg(System.Int32 suitId)
            /// </summary>
            /// <param name = "suitId">struct System.Int32</param>
            /// <returns>class TbSuitCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSuitCfg", "TbSuitCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SUIT_CFG(System.Int32 suitId); 
*/
            /// <summary>
            ///   TbTerrainCfg GetTerrainCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbTerrainCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTerrainCfg", "TbTerrainCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TERRAIN_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbTradeCfg GetTradeCfg(System.Int32 tradeCfgId)
            /// </summary>
            /// <param name = "tradeCfgId">struct System.Int32</param>
            /// <returns>class TbTradeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTradeCfg", "TbTradeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TRADE_CFG(System.Int32 tradeCfgId); 
*/
            /// <summary>
            ///   TbTypeCfg GetTypeCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbTypeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTypeCfg", "TbTypeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TYPE_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void LoadConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadConfig", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_CONFIG(); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbDataImpl
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  TbDataImpl get_Instance()
            /// </summary>
            /// <returns>class TbDataImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbDataImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INSTANCE(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}