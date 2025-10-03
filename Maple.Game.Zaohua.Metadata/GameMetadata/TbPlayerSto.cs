namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbPlayerSto"]
    /// [System.Object]
    /// [ICloneable<TbPlayerSto>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbPlayerSto>, Ptr_TbPlayerSto>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbPlayerSto", "TbPlayerSto")]
    public partial class TbPlayerSto
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbPlayerSto(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbPlayerSto(System.IntPtr ptr) => new Ptr_TbPlayerSto(ptr);
            public static implicit operator System.IntPtr(Ptr_TbPlayerSto ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_TbPlayerSto ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayerSto"]
        /// </summary>
        partial struct Ptr_TbPlayerSto
        {
            /// <summary>
            /// 0x10 System.String surname
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("surname", "System.String")]
           public partial nint SURNAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
           public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String mapStoId
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapStoId", "System.String")]
           public partial nint MAP_STO_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String mapName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapName", "System.String")]
           public partial nint MAP_NAME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String mapPath
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapPath", "System.String")]
           public partial nint MAP_PATH { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<BlendId> praticeArtList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BlendId></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("praticeArtList", "System.Collections.Generic.List<BlendId>")]
           public partial nint PRATICE_ART_LIST { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<EquipPracticeItem> praticeDrugList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EquipPracticeItem></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("praticeDrugList", "System.Collections.Generic.List<EquipPracticeItem>")]
           public partial nint PRATICE_DRUG_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; }


            /// <summary>
            /// 0x4C System.Int32 roleId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("roleId", "System.Int32")]
            public partial System.Int32 ROLE_ID { get; set; }


            /// <summary>
            /// 0x50 System.Int32 mapModelId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mapModelId", "System.Int32")]
           public partial System.Int32 MAP_MODEL_ID { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 chapterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chapterId", "System.Int32")]
           public partial System.Int32 CHAPTER_ID { get; set; } 
*/

            /// <summary>
            /// 0x58 MyVector2Int lastPosition
            /// struct ["Assembly-CSharp".""."MyVector2Int"]
            /// </summary>
            /// <returns>struct MyVector2Int</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastPosition", "MyVector2Int")]
           public partial MyVector2Int LAST_POSITION { get; set; } 
*/

            /// <summary>
            /// 0x60 MyVector2Int cellPosition
            /// struct ["Assembly-CSharp".""."MyVector2Int"]
            /// </summary>
            /// <returns>struct MyVector2Int</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cellPosition", "MyVector2Int")]
           public partial MyVector2Int CELL_POSITION { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 age
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("age", "System.Int32")]
            public partial System.Int32 AGE { get; set; }


            /// <summary>
            /// 0x6C System.Int32 year
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("year", "System.Int32")]
            public partial System.Int32 YEAR { get; set; }


            /// <summary>
            /// 0x70 System.Int32 fate
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fate", "System.Int32")]
            public partial System.Int32 FATE { get; set; }


            /// <summary>
            /// 0x74 System.Int32 justice
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("justice", "System.Int32")]
            public partial System.Int32 JUSTICE { get; set; }


            /// <summary>
            /// 0x78 System.Int32 brave
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("brave", "System.Int32")]
            public partial System.Int32 BRAVE { get; set; }


            /// <summary>
            /// 0x7C System.Int32 exchange
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exchange", "System.Int32")]
            public partial System.Int32 EXCHANGE { get; set; }


            /// <summary>
            /// 0x80 System.Int32 credit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("credit", "System.Int32")]
            public partial System.Int32 CREDIT { get; set; }


            /// <summary>
            /// 0x84 System.Single exp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exp", "System.Single")]
            public partial System.Single EXP { get; set; }


            /// <summary>
            /// 0x88 System.Int32 hpNow
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hpNow", "System.Int32")]
            public partial System.Int32 HP_NOW { get; set; }


            /// <summary>
            /// 0x8C System.Int32 mpNow
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mpNow", "System.Int32")]
            public partial System.Int32 MP_NOW { get; set; }


            /// <summary>
            /// 0x90 System.Int32 gold
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gold", "System.Int32")]
            public partial System.Int32 GOLD { get; set; }


            /// <summary>
            /// 0x94 System.Int32 water
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("water", "System.Int32")]
            public partial System.Int32 WATER { get; set; }


            /// <summary>
            /// 0x98 System.Int32 wood
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("wood", "System.Int32")]
            public partial System.Int32 WOOD { get; set; }


            /// <summary>
            /// 0x9C System.Int32 fire
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fire", "System.Int32")]
            public partial System.Int32 FIRE { get; set; }


            /// <summary>
            /// 0xA0 System.Int32 soil
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("soil", "System.Int32")]
            public partial System.Int32 SOIL { get; set; }


            /// <summary>
            /// 0xA4 System.Int32 ice
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ice", "System.Int32")]
            public partial System.Int32 ICE { get; set; }


            /// <summary>
            /// 0xA8 System.Int32 wind
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("wind", "System.Int32")]
            public partial System.Int32 WIND { get; set; }


            /// <summary>
            /// 0xAC System.Int32 thunder
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thunder", "System.Int32")]
            public partial System.Int32 THUNDER { get; set; }


            /// <summary>
            /// 0xB0 System.Int32 spaceCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("spaceCount", "System.Int32")]
            public partial System.Int32 SPACE_COUNT { get; set; }


            /// <summary>
            /// 0xB4 System.Int32 magicCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magicCount", "System.Int32")]
            public partial System.Int32 MAGIC_COUNT { get; set; }


            /// <summary>
            /// 0xB8 System.Int32 treasCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treasCount", "System.Int32")]
            public partial System.Int32 TREAS_COUNT { get; set; }


            /// <summary>
            /// 0xBC System.Int32 upLimit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("upLimit", "System.Int32")]
           public partial System.Int32 UP_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32 exploreLv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exploreLv", "System.Int32")]
           public partial System.Int32 EXPLORE_LV { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 endId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("endId", "System.Int32")]
           public partial System.Int32 END_ID { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Single expRatio
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expRatio", "System.Single")]
           public partial System.Single EXP_RATIO { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Single battleSpeed
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battleSpeed", "System.Single")]
            public partial System.Single BATTLE_SPEED { get; set; }


            /// <summary>
            /// 0xD0 System.Int32 compareMagicFlag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareMagicFlag", "System.Int32")]
           public partial System.Int32 COMPARE_MAGIC_FLAG { get; set; } 
*/

            /// <summary>
            /// 0xD4 BlendId compareArtId
            /// struct ["Assembly-CSharp".""."BlendId"]
            /// </summary>
            /// <returns>struct BlendId</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareArtId", "BlendId")]
           public partial BlendId COMPARE_ART_ID { get; set; } 
*/

            /// <summary>
            /// 0xDC System.Int32 compareOrnaments
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareOrnaments", "System.Int32")]
           public partial System.Int32 COMPARE_ORNAMENTS { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Int32 compareTreas
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareTreas", "System.Int32")]
           public partial System.Int32 COMPARE_TREAS { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Int32 compareProp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareProp", "System.Int32")]
           public partial System.Int32 COMPARE_PROP { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Boolean isCompareHelmet
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isCompareHelmet", "System.Boolean")]
           public partial System.Boolean IS_COMPARE_HELMET { get; set; } 
*/

            /// <summary>
            /// 0xE9 System.Boolean isCompareClothes
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isCompareClothes", "System.Boolean")]
           public partial System.Boolean IS_COMPARE_CLOTHES { get; set; } 
*/

            /// <summary>
            /// 0xEA System.Boolean isCompareShoe
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isCompareShoe", "System.Boolean")]
           public partial System.Boolean IS_COMPARE_SHOE { get; set; } 
*/

            /// <summary>
            /// 0xEB System.Boolean compareCapacity
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compareCapacity", "System.Boolean")]
           public partial System.Boolean COMPARE_CAPACITY { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Int32 fly
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fly", "System.Int32")]
            public partial System.Int32 FLY { get; set; }


            /// <summary>
            /// 0xF0 System.Int32 praticeFormationId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("praticeFormationId", "System.Int32")]
           public partial System.Int32 PRATICE_FORMATION_ID { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Int32 treeMoney
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treeMoney", "System.Int32")]
            public partial System.Int32 TREE_MONEY { get; set; }


            /// <summary>
            /// 0xF8 System.Int32 treeAllMoney
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treeAllMoney", "System.Int32")]
            public partial System.Int32 TREE_ALL_MONEY { get; set; }


            /// <summary>
            /// 0xFC System.Int32 dantianCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dantianCount", "System.Int32")]
            public partial System.Int32 DANTIAN_COUNT { get; set; }


            /// <summary>
            /// 0x100 System.Int32 artCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("artCount", "System.Int32")]
            public partial System.Int32 ART_COUNT { get; set; }


            /// <summary>
            /// 0x104 System.Boolean isInitialDantian
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isInitialDantian", "System.Boolean")]
           public partial System.Boolean IS_INITIAL_DANTIAN { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 maxFlipScore
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxFlipScore", "System.Int32")]
           public partial System.Int32 MAX_FLIP_SCORE { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayerSto"]
        /// </summary>
        partial struct Ptr_TbPlayerSto
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
            ///   TbPlayerSto Clone()
            /// </summary>
            /// <returns>class TbPlayerSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "TbPlayerSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CLONE(); 
*/
            /// <summary>
            ///   TbPlayerSto Copy()
            /// </summary>
            /// <returns>class TbPlayerSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Copy", "TbPlayerSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint COPY(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> get_attrList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_attrList", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTR_LIST(); 
*/
        }
    }
}