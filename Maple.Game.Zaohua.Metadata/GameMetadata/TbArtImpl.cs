namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbArtImpl"]
    /// [Singleton<TbArtImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbArtImpl>, Ptr_TbArtImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbArtImpl", "TbArtImpl")]
    public partial class TbArtImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbArtImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbArtImpl(System.IntPtr ptr) => new Ptr_TbArtImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbArtImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbArtImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbArtImpl"]
        /// </summary>
        partial struct Ptr_TbArtImpl
        {
            /// <summary>
            /// 0x0 TbArtImpl m_Instance
            /// class ["Assembly-CSharp".""."TbArtImpl"]
            /// </summary>
            /// <returns>class TbArtImpl</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbArtImpl")]
            public static partial Ptr_TbArtImpl M_INSTANCE { get; set; } 


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
        /// class ["Assembly-CSharp".""."TbArtImpl"]
        /// </summary>
        partial struct Ptr_TbArtImpl
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
            ///   System.Void AddArtLog(System.Int32 npcStoId, System.Int32 artId, System.Int32 lvId, System.Int32 type)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <param name = "lvId">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddArtLog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void ADD_ART_LOG(System.Int32 npcStoId, System.Int32 artId, System.Int32 lvId, System.Int32 type); 
*/
            /// <summary>
            ///   System.Boolean CheckArtCanStudy(BlendId artCfgId)
            /// </summary>
            /// <param name = "artCfgId">struct BlendId</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckArtCanStudy", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial System.Boolean CHECK_ART_CAN_STUDY(BlendId artCfgId); 
*/
            /// <summary>
            ///   System.Void DelArt(System.Int32 _artStoId, System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "_artStoId">struct System.Int32</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelArt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DEL_ART(System.Int32 _artStoId, System.Int32 _npcStoid); 

            /// <summary>
            ///   System.Void DoStudyArt(BlendId _artId, System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "_artId">struct BlendId</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoStudyArt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DO_STUDY_ART(BlendId.Ref_BlendId _artId, System.Int32 _npcStoid); 

            /// <summary>
            ///   System.Void DoStudyArtInBag(TbPackSto packSto, System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "packSto">class TbPackSto</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoStudyArtInBag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DO_STUDY_ART_IN_BAG(nint packSto, System.Int32 _npcStoid); 
*/
            /// <summary>
            ///   System.Boolean EquipArt(System.Int32 artStoId)
            /// </summary>
            /// <param name = "artStoId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean EQUIP_ART(System.Int32 artStoId); 
*/
            /// <summary>
            ///   System.Int32[] GetArtAttributeByCfgStr(System.String str)
            /// </summary>
            /// <param name = "str">class System.String</param>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtAttributeByCfgStr", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ART_ATTRIBUTE_BY_CFG_STR(nint str); 
*/
            /// <summary>
            ///   System.String GetArtAttrName(ArtAttrEnum type)
            /// </summary>
            /// <param name = "type">enum ArtAttrEnum</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtAttrName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ArtAttrEnum", 0)]
            public partial nint GET_ART_ATTR_NAME(ArtAttrEnum type); 
*/
            /// <summary>
            ///   System.Int32 GetArtAttrValue(TbArtCfg _cfg, System.Boolean isBig, ArtAttrEnum type)
            /// </summary>
            /// <param name = "_cfg">class TbArtCfg</param>
            /// <param name = "isBig">struct System.Boolean</param>
            /// <param name = "type">enum ArtAttrEnum</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtAttrValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ArtAttrEnum", 2)]
            public partial System.Int32 GET_ART_ATTR_VALUE(nint _cfg, System.Boolean isBig, ArtAttrEnum type); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<BlendId> GetArtByNpcStoId(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<BlendId></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtByNpcStoId", "System.Collections.Generic.List<BlendId>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ART_BY_NPC_STO_ID(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   TbArtCfg GetArtCfg(BlendId artId)
            /// </summary>
            /// <param name = "artId">struct BlendId</param>
            /// <returns>class TbArtCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtCfg", "TbArtCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            public partial nint GET_ART_CFG(BlendId artId); 
*/
            /// <summary>
            ///   System.Int32 GetArtCountOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtCountOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_ART_COUNT_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   System.String GetArtEffs(TbArtCfg _cfg, System.Boolean isBig)
            /// </summary>
            /// <param name = "_cfg">class TbArtCfg</param>
            /// <param name = "isBig">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtEffs", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_ART_EFFS(nint _cfg, System.Boolean isBig); 
*/
            /// <summary>
            ///   System.Int32 GetArtGradeOfNpcStoId(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "attr">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "gradeType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtGradeOfNpcStoId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Int32 GET_ART_GRADE_OF_NPC_STO_ID(System.Int32 npcStoId, System.Int32 attr, System.Int32 type, System.Int32 gradeType); 
*/
            /// <summary>
            ///   TbArtSto GetArtStoByArtId(BlendId artId, System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "artId">struct BlendId</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>class TbArtSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtStoByArtId", "TbArtSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ART_STO_BY_ART_ID(BlendId artId, System.Int32 _npcStoid); 
*/
            /// <summary>
            ///   TbArtSto GetArtStoByArtStoId(System.Int32 _artStoId, System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "_artStoId">struct System.Int32</param>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>class TbArtSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtStoByArtStoId", "TbArtSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ART_STO_BY_ART_STO_ID(System.Int32 _artStoId, System.Int32 _npcStoid); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> GetArtStoListByFlag(System.Int32 flag)
            /// </summary>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArtStoListByFlag", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ART_STO_LIST_BY_FLAG(System.Int32 flag); 
*/
            /// <summary>
            ///   TbArtSto GetExArt(System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>class TbArtSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExArt", "TbArtSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_EX_ART(System.Int32 _npcStoid); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> GetExArts(System.Int32 _npcStoid)
            /// </summary>
            /// <param name = "_npcStoid">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExArts", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_EX_ARTS(System.Int32 _npcStoid); 
*/
            /// <summary>
            ///   BlendId GetMaxArt(System.String art)
            /// </summary>
            /// <param name = "art">class System.String</param>
            /// <returns>struct BlendId</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxArt", "BlendId", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial BlendId GET_MAX_ART(nint art); 
*/
            /// <summary>
            ///   TbArtCfg GetNpcArtCfgBy(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _playerType, System.Collections.Generic.List<TbArtCfg> equipArtCfgs)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_gradeId">struct System.Int32</param>
            /// <param name = "_attribute">struct System.Int32</param>
            /// <param name = "_playerType">struct System.Int32</param>
            /// <param name = "equipArtCfgs">class System.Collections.Generic.List<TbArtCfg></param>
            /// <returns>class TbArtCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcArtCfgBy", "TbArtCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtCfg>", 4)]
            public partial nint GET_NPC_ART_CFG_BY(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _playerType, nint equipArtCfgs); 
*/
            /// <summary>
            ///   TbArtCfg GetOneNpcArtCfgBy(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _playerType, System.Collections.Generic.List<TbArtCfg> equipArtCfgs)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_gradeId">struct System.Int32</param>
            /// <param name = "_attribute">struct System.Int32</param>
            /// <param name = "_playerType">struct System.Int32</param>
            /// <param name = "equipArtCfgs">class System.Collections.Generic.List<TbArtCfg></param>
            /// <returns>class TbArtCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOneNpcArtCfgBy", "TbArtCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtCfg>", 4)]
            public partial nint GET_ONE_NPC_ART_CFG_BY(System.Int32 _type, System.Int32 _gradeId, System.Int32 _attribute, System.Int32 _playerType, nint equipArtCfgs); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> GetPlayerArtList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerArtList", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_ART_LIST(); 
*/
            /// <summary>
            ///   System.String GetStudyConditionDes(TbArtCfg artCfg, System.Boolean isShowCanStudy)
            /// </summary>
            /// <param name = "artCfg">class TbArtCfg</param>
            /// <param name = "isShowCanStudy">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyConditionDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_STUDY_CONDITION_DES(nint artCfg, System.Boolean isShowCanStudy); 
*/
            /// <summary>
            ///   System.Void InitArtSto(TbActor _actor, TbNpcCfg _cfg, System.Collections.Generic.List<TbCreateCfg> equippedCreateCfgList)
            /// </summary>
            /// <param name = "_actor">class TbActor</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <param name = "equippedCreateCfgList">class System.Collections.Generic.List<TbCreateCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitArtSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbCreateCfg>", 2)]
            public partial void INIT_ART_STO(nint _actor, nint _cfg, nint equippedCreateCfgList); 
*/
            /// <summary>
            ///   System.Boolean IsArtLog(System.Int32 npcStoId, System.Int32 artId, System.Int32 lvId, System.Int32 type)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <param name = "lvId">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsArtLog", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Boolean IS_ART_LOG(System.Int32 npcStoId, System.Int32 artId, System.Int32 lvId, System.Int32 type); 
*/
            /// <summary>
            ///   System.Boolean IsEquipArt()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsEquipArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_EQUIP_ART(); 
*/
            /// <summary>
            ///   System.Boolean IsStudyArt(TbPackSto packSto)
            /// </summary>
            /// <param name = "packSto">class TbPackSto</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            public partial System.Boolean IS_STUDY_ART(nint packSto); 
*/
            /// <summary>
            ///   System.Boolean IsStudyArt(TbItemCfg itemCfg)
            /// </summary>
            /// <param name = "itemCfg">class TbItemCfg</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            public partial System.Boolean IS_STUDY_ART(nint itemCfg); 
*/
            /// <summary>
            ///   System.Boolean IsStudyArtByCfg(TbArtCfg cfg)
            /// </summary>
            /// <param name = "cfg">class TbArtCfg</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyArtByCfg", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
            public partial System.Boolean IS_STUDY_ART_BY_CFG(nint cfg); 
*/
            /// <summary>
            ///   System.Boolean IsStudyMagicByCfg(TbMagicCfg cfg)
            /// </summary>
            /// <param name = "cfg">class TbMagicCfg</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsStudyMagicByCfg", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
            public partial System.Boolean IS_STUDY_MAGIC_BY_CFG(nint cfg); 
*/
            /// <summary>
            ///   System.Boolean JudArt(System.Int32 _npcId, System.Int32 _artId, System.Int32 _type, System.Int32 _flag)
            /// </summary>
            /// <param name = "_npcId">struct System.Int32</param>
            /// <param name = "_artId">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Boolean JUD_ART(System.Int32 _npcId, System.Int32 _artId, System.Int32 _type, System.Int32 _flag); 
*/
            /// <summary>
            ///   System.Void RefrushHp(System.Int32 oldHp)
            /// </summary>
            /// <param name = "oldHp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefrushHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REFRUSH_HP(System.Int32 oldHp); 
*/
            /// <summary>
            ///   System.Boolean RemoveArt(System.Int32 artStoId)
            /// </summary>
            /// <param name = "artStoId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveArt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean REMOVE_ART(System.Int32 artStoId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> ScreenArtSto(System.Collections.Generic.List<TbArtSto> _artStos, System.Int32 _grade, System.Int32 _att)
            /// </summary>
            /// <param name = "_artStos">class System.Collections.Generic.List<TbArtSto></param>
            /// <param name = "_grade">struct System.Int32</param>
            /// <param name = "_att">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ScreenArtSto", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtSto>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint SCREEN_ART_STO(nint _artStos, System.Int32 _grade, System.Int32 _att); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbArtSto> SortArtSto(System.Collections.Generic.List<TbArtSto> _artStos, SortEnum sort)
            /// </summary>
            /// <param name = "_artStos">class System.Collections.Generic.List<TbArtSto></param>
            /// <param name = "sort">enum SortEnum</param>
            /// <returns>class System.Collections.Generic.List<TbArtSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortArtSto", "System.Collections.Generic.List<TbArtSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtSto>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SortEnum", 1)]
            public partial nint SORT_ART_STO(nint _artStos, SortEnum sort); 
*/
            /// <summary>
            ///   System.Void UpdateAdFormula(System.Int32 _value, System.Int32 _npcTmpId, System.String _parameter, System.String _coefficient, System.Int32 maxValue)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <param name = "_npcTmpId">struct System.Int32</param>
            /// <param name = "_parameter">class System.String</param>
            /// <param name = "_coefficient">class System.String</param>
            /// <param name = "maxValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAdFormula", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial void UPDATE_AD_FORMULA(System.Int32 _value, System.Int32 _npcTmpId, nint _parameter, nint _coefficient, System.Int32 maxValue); 
*/
            /// <summary>
            ///   System.Void UpdateAdPer(System.Int32 _value, System.String _per)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <param name = "_per">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAdPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void UPDATE_AD_PER(System.Int32 _value, nint _per); 
*/
            /// <summary>
            ///   System.Void UpdateAdValue(System.Int32 _value, System.Int32 _changValue)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <param name = "_changValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAdValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_AD_VALUE(System.Int32 _value, System.Int32 _changValue); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbArtImpl
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
            /// static  TbArtImpl get_Instance()
            /// </summary>
            /// <returns>class TbArtImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbArtImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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