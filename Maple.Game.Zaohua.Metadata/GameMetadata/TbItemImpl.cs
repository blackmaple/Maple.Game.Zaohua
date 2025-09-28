namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbItemImpl"]
    /// [Singleton<TbItemImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbItemImpl>, Ptr_TbItemImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbItemImpl", "TbItemImpl")]
    public partial class TbItemImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbItemImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbItemImpl(System.IntPtr ptr) => new Ptr_TbItemImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbItemImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbItemImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbItemImpl"]
        /// </summary>
        partial struct Ptr_TbItemImpl
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Int32 , System.String> gradeIdToQuality
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gradeIdToQuality", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
            public static partial nint GRADE_ID_TO_QUALITY { get; set; } 
*/

            /// <summary>
            /// 0x0 TbItemImpl m_Instance
            /// class ["Assembly-CSharp".""."TbItemImpl"]
            /// </summary>
            /// <returns>class TbItemImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbItemImpl")]
            public static partial nint M_INSTANCE { get; set; } 
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
            /// 0x10 System.Collections.Generic.Dictionary<System.Int32 , System.Int32> parentTypeDic
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("parentTypeDic", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>")]
            public partial nint PARENT_TYPE_DIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbItemImpl"]
        /// </summary>
        partial struct Ptr_TbItemImpl
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
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.String GetAttributeName(System.Int32 attr, System.Boolean isSimplify)
            /// </summary>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "isSimplify">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_ATTRIBUTE_NAME(System.Int32 attr, System.Boolean isSimplify); 
*/
            /// <summary>
            ///   System.String GetAttributeSprite(System.Int32 attributeId)
            /// </summary>
            /// <param name = "attributeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeSprite", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ATTRIBUTE_SPRITE(System.Int32 attributeId); 
*/
            /// <summary>
            ///   TbItemCfg GetEquipBySpecialItemId(TbNpcSto sto, EquipBitTag bitTag, System.Int32 typeId)
            /// </summary>
            /// <param name = "sto">class TbNpcSto</param>
            /// <param name = "bitTag">enum EquipBitTag</param>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipBySpecialItemId", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipBitTag", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint GET_EQUIP_BY_SPECIAL_ITEM_ID(nint sto, EquipBitTag bitTag, System.Int32 typeId); 
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
            ///   TbGradeCfg GetGradeCfgBy(System.Int32 lv, System.Int32 parent, TbNpcCfg npcCfg, TbEnemyCfg enemyCfg)
            /// </summary>
            /// <param name = "lv">struct System.Int32</param>
            /// <param name = "parent">struct System.Int32</param>
            /// <param name = "npcCfg">class TbNpcCfg</param>
            /// <param name = "enemyCfg">class TbEnemyCfg</param>
            /// <returns>class TbGradeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeCfgBy", "TbGradeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbEnemyCfg", 3)]
            public partial nint GET_GRADE_CFG_BY(System.Int32 lv, System.Int32 parent, nint npcCfg, nint enemyCfg); 
*/
            /// <summary>
            ///   System.Int32 GetGradeLvByGradeId(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeLvByGradeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_GRADE_LV_BY_GRADE_ID(System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.String GetGradeLvImgPath(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeLvImgPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_GRADE_LV_IMG_PATH(System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.String GetGradeLvName(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeLvName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_GRADE_LV_NAME(System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.String GetGradeName(System.Int32 gradeId, System.Boolean onlyGrade)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "onlyGrade">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_GRADE_NAME(System.Int32 gradeId, System.Boolean onlyGrade); 
*/
            /// <summary>
            ///   System.String GetGradeNameByItemId(BlendId itemId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeNameByItemId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_GRADE_NAME_BY_ITEM_ID(BlendId itemId); 
*/
            /// <summary>
            ///   System.String GetGradeSplitLevelsPath(System.Int32 gradeid)
            /// </summary>
            /// <param name = "gradeid">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeSplitLevelsPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_GRADE_SPLIT_LEVELS_PATH(System.Int32 gradeid); 
*/
            /// <summary>
            ///   System.Int32 GetGradeWeight(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeWeight", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_GRADE_WEIGHT(System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.Int32 GetGradeWeightByItemId(BlendId itemid)
            /// </summary>
            /// <param name = "itemid">struct BlendId</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGradeWeightByItemId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial System.Int32 GET_GRADE_WEIGHT_BY_ITEM_ID(BlendId itemid); 
*/
            /// <summary>
            ///   System.String GetInnerGradePath(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInnerGradePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_INNER_GRADE_PATH(System.Int32 gradeId); 
*/
            /// <summary>
            ///   TbItemCfg GetItemByGradeId(System.Int32 typeId, System.Int32 gradeId, SceneEnum sceneEnum, System.Int32 useFlag)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "sceneEnum">enum SceneEnum</param>
            /// <param name = "useFlag">struct System.Int32</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemByGradeId", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint GET_ITEM_BY_GRADE_ID(System.Int32 typeId, System.Int32 gradeId, SceneEnum sceneEnum, System.Int32 useFlag); 
*/
            /// <summary>
            ///   System.Void GetItemByLayerId(System.Int32 typeId, System.Int32 gradeId, SceneEnum sceneEnum)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "sceneEnum">enum SceneEnum</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemByLayerId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 2)]
            public partial void GET_ITEM_BY_LAYER_ID(System.Int32 typeId, System.Int32 gradeId, SceneEnum sceneEnum); 
*/
            /// <summary>
            ///   TbItemCfg GetItemByNpcuse(System.Int32 typeId, System.Int32 gradeId, System.Int32 attribute, System.Int32 useFlag)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "attribute">struct System.Int32</param>
            /// <param name = "useFlag">struct System.Int32</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemByNpcuse", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint GET_ITEM_BY_NPCUSE(System.Int32 typeId, System.Int32 gradeId, System.Int32 attribute, System.Int32 useFlag); 
*/
            /// <summary>
            ///   TbItemCfg GetItemByPrice(System.Int32 typeId, System.Int32 price, SceneEnum sceneEnum)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <param name = "price">struct System.Int32</param>
            /// <param name = "sceneEnum">enum SceneEnum</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemByPrice", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 2)]
            public partial nint GET_ITEM_BY_PRICE(System.Int32 typeId, System.Int32 price, SceneEnum sceneEnum); 
*/
            /// <summary>
            ///   TbItemCfg GetItemCfg(BlendId id)
            /// </summary>
            /// <param name = "id">struct BlendId</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemCfg", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_ITEM_CFG(BlendId id); 
*/
            /// <summary>
            ///   System.Int32 GetItemCountOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemCountOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_ITEM_COUNT_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   System.String GetItemDes(BlendId itemId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_ITEM_DES(BlendId itemId); 
*/
            /// <summary>
            ///   System.Int32 GetItemGradeOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemGradeOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_ITEM_GRADE_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   System.String GetItemName(BlendId itemId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_ITEM_NAME(BlendId itemId); 
*/
            /// <summary>
            ///   System.String GetOutlineGradeSprite(System.Int32 gradeId, System.Boolean isHighLight)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "isHighLight">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOutlineGradeSprite", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_OUTLINE_GRADE_SPRITE(System.Int32 gradeId, System.Boolean isHighLight); 
*/
            /// <summary>
            ///   System.String GetPackDes(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PACK_DES(System.Int32 packId); 
*/
            /// <summary>
            ///   System.String GetPackEffDes(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackEffDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PACK_EFF_DES(System.Int32 packId); 
*/
            /// <summary>
            ///   System.Int32 GetParentByTypeId(System.Int32 typeId)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetParentByTypeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_PARENT_BY_TYPE_ID(System.Int32 typeId); 
*/
            /// <summary>
            ///   System.Int32 GetParentIdByIndex(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetParentIdByIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_PARENT_ID_BY_INDEX(System.Int32 index); 
*/
            /// <summary>
            ///   System.String GetParentNameByItemId(BlendId itemId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetParentNameByItemId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_PARENT_NAME_BY_ITEM_ID(BlendId itemId); 
*/
            /// <summary>
            ///   TbItemCfg GetRandomItemByLayerId(System.Int32 layerId, SceneEnum sceneEnum)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <param name = "sceneEnum">enum SceneEnum</param>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomItemByLayerId", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 1)]
            public partial nint GET_RANDOM_ITEM_BY_LAYER_ID(System.Int32 layerId, SceneEnum sceneEnum); 
*/
            /// <summary>
            ///   System.String GetShiftTipSprite(System.Int32 gradeId)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShiftTipSprite", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SHIFT_TIP_SPRITE(System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.String GetTipSpritePathByGradId(System.Int32 gradeId, System.Int32 type)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTipSpritePathByGradId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_TIP_SPRITE_PATH_BY_GRAD_ID(System.Int32 gradeId, System.Int32 type); 
*/
            /// <summary>
            ///   System.String GetTipSpritePathByItemId(BlendId itemId, System.Int32 type)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTipSpritePathByItemId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_TIP_SPRITE_PATH_BY_ITEM_ID(BlendId itemId, System.Int32 type); 
*/
            /// <summary>
            ///   TbTypeCfg GetTypeCfg(System.Int32 typeId)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>class TbTypeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTypeCfg", "TbTypeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TYPE_CFG(System.Int32 typeId); 
*/
            /// <summary>
            ///   System.String GetTypeName(System.Int32 typeId)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTypeName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TYPE_NAME(System.Int32 typeId); 
*/
            /// <summary>
            ///   System.String GetTypeNameByItemId(BlendId itemId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTypeNameByItemId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_TYPE_NAME_BY_ITEM_ID(BlendId itemId); 
*/
            /// <summary>
            ///   System.String GetTypeParentName(System.Int32 typeId)
            /// </summary>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTypeParentName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TYPE_PARENT_NAME(System.Int32 typeId); 
*/
            /// <summary>
            ///   TbValueCfg GetValueCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbValueCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValueCfg", "TbValueCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_VALUE_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbValueCfg GetValueCfgByValue(System.String type, System.Int32 value)
            /// </summary>
            /// <param name = "type">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>class TbValueCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValueCfgByValue", "TbValueCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_VALUE_CFG_BY_VALUE(nint type, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean IsHaveItem(System.Int32 itemId, SceneEnum sceneEnum)
            /// </summary>
            /// <param name = "itemId">struct System.Int32</param>
            /// <param name = "sceneEnum">enum SceneEnum</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsHaveItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SceneEnum", 1)]
            public partial System.Boolean IS_HAVE_ITEM(System.Int32 itemId, SceneEnum sceneEnum); 
*/
            /// <summary>
            ///   System.Boolean JudItemType(BlendId _itemId, System.Int32 typeId)
            /// </summary>
            /// <param name = "_itemId">struct BlendId</param>
            /// <param name = "typeId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudItemType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_ITEM_TYPE(BlendId _itemId, System.Int32 typeId); 
*/
            /// <summary>
            ///   System.Boolean JudTreasAttr(BlendId _itemId, System.Int32 attr)
            /// </summary>
            /// <param name = "_itemId">struct BlendId</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudTreasAttr", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_TREAS_ATTR(BlendId _itemId, System.Int32 attr); 
*/
            /// <summary>
            ///   System.Void RefreshCfg()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_CFG(); 
*/
            /// <summary>
            ///   System.Void SetItemBitTag(TbItemCfg item)
            /// </summary>
            /// <param name = "item">class TbItemCfg</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetItemBitTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            public partial void SET_ITEM_BIT_TAG(nint item); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbItemImpl
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
            /// static  TbItemImpl get_Instance()
            /// </summary>
            /// <returns>class TbItemImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbItemImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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