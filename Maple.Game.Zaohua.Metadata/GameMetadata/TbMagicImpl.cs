namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbMagicImpl"]
    /// [Singleton<TbMagicImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbMagicImpl>, Ptr_TbMagicImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbMagicImpl", "TbMagicImpl")]
    public partial class TbMagicImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbMagicImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbMagicImpl(System.IntPtr ptr) => new Ptr_TbMagicImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbMagicImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbMagicImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbMagicImpl"]
        /// </summary>
        partial struct Ptr_TbMagicImpl
        {
            /// <summary>
            /// 0x0 TbMagicImpl m_Instance
            /// class ["Assembly-CSharp".""."TbMagicImpl"]
            /// </summary>
            /// <returns>class TbMagicImpl</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbMagicImpl")]
            public static partial Ptr_TbMagicImpl M_INSTANCE { get; set; } 


            /// <summary>
            /// 0x8 System.String m_Lock
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Lock", "System.String")]
            public static partial nint M_LOCK { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbMagicImpl"]
        /// </summary>
        partial struct Ptr_TbMagicImpl
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
            ///   TbMagicSto AddNewMagicSto(BlendId _cfgId, System.Int32 _npcStoid, System.Int32 flag)
            /// </summary>
            /// <param name = "_cfgId">struct BlendId</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>class TbMagicSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNewMagicSto", "TbMagicSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint ADD_NEW_MAGIC_STO(BlendId _cfgId, System.Int32 _npcStoid, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Void ChangeMagic(TbMagicSto oldSto, TbMagicSto newSto)
            /// </summary>
            /// <param name = "oldSto">class TbMagicSto</param>
            /// <param name = "newSto">class TbMagicSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMagic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicSto", 1)]
            public partial void CHANGE_MAGIC(nint oldSto, nint newSto); 
*/
            /// <summary>
            ///   System.Void DelMagicSto(TbMagicSto magicSto)
            /// </summary>
            /// <param name = "magicSto">class TbMagicSto</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelMagicSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicSto", 0)]
            public partial void DEL_MAGIC_STO(TbMagicSto.Ptr_TbMagicSto magicSto); 

            /// <summary>
            ///   System.Void DelMagicStoBy(System.Int32 _magicStoId)
            /// </summary>
            /// <param name = "_magicStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelMagicStoBy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void DEL_MAGIC_STO_BY(System.Int32 _magicStoId); 
*/
            /// <summary>
            ///   System.Void DisboardMagic(TbMagicSto oldSto)
            /// </summary>
            /// <param name = "oldSto">class TbMagicSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DisboardMagic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicSto", 0)]
            public partial void DISBOARD_MAGIC(nint oldSto); 
*/
            /// <summary>
            ///   System.String DoStudyMagic(TbPackSto packSto, System.Boolean show)
            /// </summary>
            /// <param name = "packSto">class TbPackSto</param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoStudyMagic", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint DO_STUDY_MAGIC(nint packSto, System.Boolean show); 
*/
            /// <summary>
            ///   System.String DoStudyMagicByMagicId(BlendId magicId, System.Boolean show)
            /// </summary>
            /// <param name = "magicId">struct BlendId</param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoStudyMagicByMagicId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint DO_STUDY_MAGIC_BY_MAGIC_ID(BlendId.Ref_BlendId magicId, System.Boolean show); 

            /// <summary>
            ///   System.Void EqurpMagic(TbMagicSto newSto, System.Int32 _flag)
            /// </summary>
            /// <param name = "newSto">class TbMagicSto</param>
            /// <param name = "_flag">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EqurpMagic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void EQURP_MAGIC(nint newSto, System.Int32 _flag); 
*/
            /// <summary>
            ///   TbMagicCfg GeNpctMagicCfgBy(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _magicType, System.Int32 action, System.Int32 _playerType, System.Collections.Generic.List<TbMagicCfg> equipMagicCfgs)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_gradeId">struct System.Int32</param>
            /// <param name = "_attribute">struct System.Int32</param>
            /// <param name = "_magicType">struct System.Int32</param>
            /// <param name = "action">struct System.Int32</param>
            /// <param name = "_playerType">struct System.Int32</param>
            /// <param name = "equipMagicCfgs">class System.Collections.Generic.List<TbMagicCfg></param>
            /// <returns>class TbMagicCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeNpctMagicCfgBy", "TbMagicCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicCfg>", 6)]
            public partial nint GE_NPCT_MAGIC_CFG_BY(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _magicType, System.Int32 action, System.Int32 _playerType, nint equipMagicCfgs); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetAllEff(TbBattleMagicTmp _magicTmp)
            /// </summary>
            /// <param name = "_magicTmp">class TbBattleMagicTmp</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllEff", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleMagicTmp", 0)]
            public partial nint GET_ALL_EFF(nint _magicTmp); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetAllEff(TLDefaultActData data)
            /// </summary>
            /// <param name = "data">class TLDefaultActData</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllEff", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TLDefaultActData", 0)]
            public partial nint GET_ALL_EFF(nint data); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetAllEffByTL(TbMagicCfg magic, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "magic">class TbMagicCfg</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllEffByTL", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            public partial nint GET_ALL_EFF_BY_TL(nint magic, nint npcTmp); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetAllEffByTL(TbItemCfg itemCfg, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "itemCfg">class TbItemCfg</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllEffByTL", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            public partial nint GET_ALL_EFF_BY_TL(nint itemCfg, nint npcTmp); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetEquipMagicStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipMagicStoList", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EQUIP_MAGIC_STO_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetLimitAndEquipEff(TbItemCfg _item)
            /// </summary>
            /// <param name = "_item">class TbItemCfg</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLimitAndEquipEff", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            public partial nint GET_LIMIT_AND_EQUIP_EFF(nint _item); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetLimitOrEquipEff(TbMagicCfg _magic)
            /// </summary>
            /// <param name = "_magic">class TbMagicCfg</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLimitOrEquipEff", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
            public partial nint GET_LIMIT_OR_EQUIP_EFF(nint _magic); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetLimitOrUseEff(TbBattlePackTmp _packTmp)
            /// </summary>
            /// <param name = "_packTmp">class TbBattlePackTmp</param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLimitOrUseEff", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattlePackTmp", 0)]
            public partial nint GET_LIMIT_OR_USE_EFF(nint _packTmp); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<BlendId> GetMagicByNpcSto(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<BlendId></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicByNpcSto", "System.Collections.Generic.List<BlendId>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_BY_NPC_STO(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   TbMagicCfg GetMagicCfg(BlendId artMagicId)
            /// </summary>
            /// <param name = "artMagicId">struct BlendId</param>
            /// <returns>class TbMagicCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicCfg", "TbMagicCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_MAGIC_CFG(BlendId artMagicId); 
*/
            /// <summary>
            ///   System.Int32 GetMagicCountOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicCountOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_MAGIC_COUNT_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   System.Int32 GetMagicGradeOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicGradeOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_MAGIC_GRADE_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   TbMagicSto GetMagicSto(System.Int32 _magicStoId)
            /// </summary>
            /// <param name = "_magicStoId">struct System.Int32</param>
            /// <returns>class TbMagicSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicSto", "TbMagicSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STO(System.Int32 _magicStoId); 
*/
            /// <summary>
            ///   TbMagicSto GetMagicStoByMagicId(BlendId artMagicId)
            /// </summary>
            /// <param name = "artMagicId">struct BlendId</param>
            /// <returns>class TbMagicSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStoByMagicId", "TbMagicSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_MAGIC_STO_BY_MAGIC_ID(BlendId artMagicId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetMagicStoListByFlag(System.Int32 flag)
            /// </summary>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStoListByFlag", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STO_LIST_BY_FLAG(System.Int32 flag); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetMagicStoListByNpcStoId(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStoListByNpcStoId", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STO_LIST_BY_NPC_STO_ID(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetMagicStoListByNpcStoIdEquip(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStoListByNpcStoIdEquip", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STO_LIST_BY_NPC_STO_ID_EQUIP(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetMagicStoListByNpcStoIdNo(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStoListByNpcStoIdNo", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STO_LIST_BY_NPC_STO_ID_NO(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   TbMagicCfg GetOneNpcMagicCfgBy(System.Int32 _type, System.Int32 gradeId, System.Int32 _attribute, System.Int32 _magicType, System.Int32 action, System.Int32 _playerType, System.Collections.Generic.List<TbMagicCfg> equipMagicCfgs)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "_attribute">struct System.Int32</param>
            /// <param name = "_magicType">struct System.Int32</param>
            /// <param name = "action">struct System.Int32</param>
            /// <param name = "_playerType">struct System.Int32</param>
            /// <param name = "equipMagicCfgs">class System.Collections.Generic.List<TbMagicCfg></param>
            /// <returns>class TbMagicCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOneNpcMagicCfgBy", "TbMagicCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicCfg>", 6)]
            public partial nint GET_ONE_NPC_MAGIC_CFG_BY(System.Int32 _type, System.Int32 gradeId, System.Int32 _attribute, System.Int32 _magicType, System.Int32 action, System.Int32 _playerType, nint equipMagicCfgs); 
*/
            /// <summary>
            ///   Effect GetStateLimit(System.Collections.Generic.List<Effect> effects)
            /// </summary>
            /// <param name = "effects">class System.Collections.Generic.List<Effect></param>
            /// <returns>class Effect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStateLimit", "Effect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Effect>", 0)]
            public partial nint GET_STATE_LIMIT(nint effects); 
*/
            /// <summary>
            ///   Effect GetTimesLimit(System.Collections.Generic.List<Effect> effects)
            /// </summary>
            /// <param name = "effects">class System.Collections.Generic.List<Effect></param>
            /// <returns>class Effect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTimesLimit", "Effect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Effect>", 0)]
            public partial nint GET_TIMES_LIMIT(nint effects); 
*/
            /// <summary>
            ///   System.String GetTipSpritePathByGradId(System.Int32 gradeId, System.Int32 size)
            /// </summary>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <param name = "size">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTipSpritePathByGradId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_TIP_SPRITE_PATH_BY_GRAD_ID(System.Int32 gradeId, System.Int32 size); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Effect> GetUseLimitList(System.Collections.Generic.List<Effect> effects)
            /// </summary>
            /// <param name = "effects">class System.Collections.Generic.List<Effect></param>
            /// <returns>class System.Collections.Generic.List<Effect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUseLimitList", "System.Collections.Generic.List<Effect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Effect>", 0)]
            public partial nint GET_USE_LIMIT_LIST(nint effects); 
*/
            /// <summary>
            ///   Effect GetUseLimitTwo(System.Collections.Generic.List<Effect> effects)
            /// </summary>
            /// <param name = "effects">class System.Collections.Generic.List<Effect></param>
            /// <returns>class Effect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUseLimitTwo", "Effect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Effect>", 0)]
            public partial nint GET_USE_LIMIT_TWO(nint effects); 
*/
            /// <summary>
            ///   System.Void InitMagicSto(TbActor _actor, TbNpcCfg _cfg, System.Collections.Generic.List<TbCreateCfg> equippedCreateCfgList)
            /// </summary>
            /// <param name = "_actor">class TbActor</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <param name = "equippedCreateCfgList">class System.Collections.Generic.List<TbCreateCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitMagicSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbCreateCfg>", 2)]
            public partial void INIT_MAGIC_STO(nint _actor, nint _cfg, nint equippedCreateCfgList); 
*/
            /// <summary>
            ///   System.Boolean IsContainsMagicType(BlendId magicId, System.Int32 _magicType)
            /// </summary>
            /// <param name = "magicId">struct BlendId</param>
            /// <param name = "_magicType">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsContainsMagicType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean IS_CONTAINS_MAGIC_TYPE(BlendId magicId, System.Int32 _magicType); 
*/
            /// <summary>
            ///   System.Boolean IsStudyEndMagic(TbPackSto packSto)
            /// </summary>
            /// <param name = "packSto">class TbPackSto</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyEndMagic", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            public partial System.Boolean IS_STUDY_END_MAGIC(nint packSto); 
*/
            /// <summary>
            ///   System.Boolean IsStudyEndMagic(TbItemCfg itemCfg)
            /// </summary>
            /// <param name = "itemCfg">class TbItemCfg</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyEndMagic", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            public partial System.Boolean IS_STUDY_END_MAGIC(nint itemCfg); 
*/
            /// <summary>
            ///   System.Boolean JudMagic(System.Int32 _npcId, BlendId _magicId, System.Int32 _type, System.Int32 _flag)
            /// </summary>
            /// <param name = "_npcId">struct System.Int32</param>
            /// <param name = "_magicId">struct BlendId</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMagic", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Boolean JUD_MAGIC(System.Int32 _npcId, BlendId _magicId, System.Int32 _type, System.Int32 _flag); 
*/
            /// <summary>
            ///   System.Boolean JudMagicAttr(BlendId _magicId, System.Int32 attr)
            /// </summary>
            /// <param name = "_magicId">struct BlendId</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMagicAttr", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_MAGIC_ATTR(BlendId _magicId, System.Int32 attr); 
*/
            /// <summary>
            ///   System.Boolean JudMagicType(BlendId _magicId, System.Int32 type)
            /// </summary>
            /// <param name = "_magicId">struct BlendId</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMagicType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_MAGIC_TYPE(BlendId _magicId, System.Int32 type); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> ScreenMagicSto(System.Collections.Generic.List<TbMagicSto> _magicStos, System.Int32 _grade, System.Int32 _att)
            /// </summary>
            /// <param name = "_magicStos">class System.Collections.Generic.List<TbMagicSto></param>
            /// <param name = "_grade">struct System.Int32</param>
            /// <param name = "_att">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ScreenMagicSto", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicSto>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint SCREEN_MAGIC_STO(nint _magicStos, System.Int32 _grade, System.Int32 _att); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> SortMagicSto(System.Collections.Generic.List<TbMagicSto> _magicStos, SortEnum sort)
            /// </summary>
            /// <param name = "_magicStos">class System.Collections.Generic.List<TbMagicSto></param>
            /// <param name = "sort">enum SortEnum</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortMagicSto", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbMagicSto>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SortEnum", 1)]
            public partial nint SORT_MAGIC_STO(nint _magicStos, SortEnum sort); 
*/
            /// <summary>
            ///   System.Void UpdateMagicUp(BlendId _magicId, System.Int32 _epxAdd, System.Boolean show)
            /// </summary>
            /// <param name = "_magicId">struct BlendId</param>
            /// <param name = "_epxAdd">struct System.Int32</param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMagicUp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void UPDATE_MAGIC_UP(BlendId _magicId, System.Int32 _epxAdd, System.Boolean show); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbMagicImpl
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
            /// static  TbMagicImpl get_Instance()
            /// </summary>
            /// <returns>class TbMagicImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbMagicImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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