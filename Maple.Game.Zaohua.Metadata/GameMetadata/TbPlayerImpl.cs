namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbPlayerImpl"]
    /// [Singleton<TbPlayerImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbPlayerImpl>, Ptr_TbPlayerImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbPlayerImpl", "TbPlayerImpl")]
    public partial class TbPlayerImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbPlayerImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbPlayerImpl(System.IntPtr ptr) => new Ptr_TbPlayerImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbPlayerImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbPlayerImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayerImpl"]
        /// </summary>
        partial struct Ptr_TbPlayerImpl
        {
            /// <summary>
            /// 0x0 TbPlayerImpl m_Instance
            /// class ["Assembly-CSharp".""."TbPlayerImpl"]
            /// </summary>
            /// <returns>class TbPlayerImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbPlayerImpl")]
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
            /// 0x10 TbPlayerUpTmp playerUpTmpAll
            /// class ["Assembly-CSharp".""."TbPlayerUpTmp"]
            /// </summary>
            /// <returns>class TbPlayerUpTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerUpTmpAll", "TbPlayerUpTmp")]
            public partial nint PLAYER_UP_TMP_ALL { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Boolean isDead
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDead", "System.Boolean")]
            public partial System.Boolean IS_DEAD { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayerImpl"]
        /// </summary>
        partial struct Ptr_TbPlayerImpl
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
            ///   System.Void DoKillNpc(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoKillNpc", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void DO_KILL_NPC(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int32 GetAttribValue(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttribValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_ATTRIB_VALUE(System.Int32 type); 
*/
            /// <summary>
            ///   System.Single GetBuyMultiple(TbPriceCfg priceCfg)
            /// </summary>
            /// <param name = "priceCfg">class TbPriceCfg</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuyMultiple", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPriceCfg", 0)]
            public partial System.Single GET_BUY_MULTIPLE(nint priceCfg); 
*/
            /// <summary>
            ///   System.Int32 GetDantianCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDantianCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_DANTIAN_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetExtraDaySpent()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExtraDaySpent", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_EXTRA_DAY_SPENT(); 
*/
            /// <summary>
            ///   TbMapInfoSto GetMapInfoSto(System.Boolean groupFlag)
            /// </summary>
            /// <param name = "groupFlag">struct System.Boolean</param>
            /// <returns>class TbMapInfoSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapInfoSto", "TbMapInfoSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_MAP_INFO_STO(System.Boolean groupFlag); 
*/
            /// <summary>
            ///   MyVector2Int GetMapInfoStoId(System.Boolean groupFlag)
            /// </summary>
            /// <param name = "groupFlag">struct System.Boolean</param>
            /// <returns>struct MyVector2Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapInfoStoId", "MyVector2Int", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial MyVector2Int GET_MAP_INFO_STO_ID(System.Boolean groupFlag); 
*/
            /// <summary>
            ///   System.String GetMapStoId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapStoId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_STO_ID(); 
*/
            /// <summary>
            ///   System.Int32 GetNoByFate()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNoByFate", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_NO_BY_FATE(); 
*/
            /// <summary>
            ///   System.Int32 GetNunberByFate()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNunberByFate", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_NUNBER_BY_FATE(); 
*/
            /// <summary>
            ///   TbPlaceSto GetPlaceSto()
            /// </summary>
            /// <returns>class TbPlaceSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlaceSto", "TbPlaceSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLACE_STO(); 
*/
            /// <summary>
            ///   System.String GetPlayerAttrName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerAttrName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_ATTR_NAME(); 
*/
            /// <summary>
            ///   System.String GetPlayerLvName(System.Int32 id, System.Int32 lvId)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerLvName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PLAYER_LV_NAME(System.Int32 id, System.Int32 lvId); 
*/
            /// <summary>
            ///   System.String GetPlayerLvName(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerLvName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PLAYER_LV_NAME(System.Int32 lvId); 
*/
            /// <summary>
            ///   TbPlayerSto GetPlayerSto()
            /// </summary>
            /// <returns>class TbPlayerSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerSto", "TbPlayerSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_STO(); 
*/
            /// <summary>
            ///   System.Single GetPlayerStoExp()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerStoExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_PLAYER_STO_EXP(); 
*/
            /// <summary>
            ///   System.Int32 GetPlayerStoHpNow()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerStoHpNow", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PLAYER_STO_HP_NOW(); 
*/
            /// <summary>
            ///   System.Int32 GetPlayerStoSpaceCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerStoSpaceCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PLAYER_STO_SPACE_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetPlayerStoTreasCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerStoTreasCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PLAYER_STO_TREAS_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetPlyerStoMagicCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlyerStoMagicCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PLYER_STO_MAGIC_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetRankByFate()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRankByFate", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_RANK_BY_FATE(); 
*/
            /// <summary>
            ///   System.Single GetSellMultiple(TbPriceCfg priceCfg)
            /// </summary>
            /// <param name = "priceCfg">class TbPriceCfg</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSellMultiple", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPriceCfg", 0)]
            public partial System.Single GET_SELL_MULTIPLE(nint priceCfg); 
*/
            /// <summary>
            ///   System.Void InitPlayerSto(TbActor _actor, TbRoleCfg _role, System.String _sur, System.String _name, TbAttribCfg _attrib, TbPracCfg _prac)
            /// </summary>
            /// <param name = "_actor">class TbActor</param>
            /// <param name = "_role">class TbRoleCfg</param>
            /// <param name = "_sur">class System.String</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "_attrib">class TbAttribCfg</param>
            /// <param name = "_prac">class TbPracCfg</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitPlayerSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbRoleCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbAttribCfg", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPracCfg", 5)]
            public partial void INIT_PLAYER_STO(nint _actor, nint _role, nint _sur, nint _name, nint _attrib, nint _prac); 
*/
            /// <summary>
            ///   System.Boolean IsFullLv()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsFullLv", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_FULL_LV(); 
*/
            /// <summary>
            ///   System.Boolean JudAge(System.String term, System.Int32 num)
            /// </summary>
            /// <param name = "term">class System.String</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudAge", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_AGE(nint term, System.Int32 num); 
*/
            /// <summary>
            ///   System.Boolean JudAttrib(System.Int32 type, System.Int32 value, System.String v)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudAttrib", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial System.Boolean JUD_ATTRIB(System.Int32 type, System.Int32 value, nint v); 
*/
            /// <summary>
            ///   System.Boolean JudBrave(System.Int32 value, System.String v)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudBrave", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Boolean JUD_BRAVE(System.Int32 value, nint v); 
*/
            /// <summary>
            ///   System.Boolean JudChapter(System.Int32 chapter, System.Int32 flag)
            /// </summary>
            /// <param name = "chapter">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudChapter", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_CHAPTER(System.Int32 chapter, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudExchange(System.String term, System.Int32 value)
            /// </summary>
            /// <param name = "term">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudExchange", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_EXCHANGE(nint term, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudFate(System.Int32 value, System.String v)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudFate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Boolean JUD_FATE(System.Int32 value, nint v); 
*/
            /// <summary>
            ///   System.Boolean JudJustice(System.Int32 value, System.String v)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudJustice", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Boolean JUD_JUSTICE(System.Int32 value, nint v); 
*/
            /// <summary>
            ///   System.Boolean JudMap(System.String mapId, System.Int32 flag)
            /// </summary>
            /// <param name = "mapId">class System.String</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMap", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_MAP(nint mapId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudMapMove(System.Int32 type, System.Int32 flag)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMapMove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_MAP_MOVE(System.Int32 type, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudPlace(System.Int32 nameId, System.Int32 flag)
            /// </summary>
            /// <param name = "nameId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPlace", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_PLACE(System.Int32 nameId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudPosition(System.String mapStoId, System.Int32 x, System.Int32 y, System.Int32 flag)
            /// </summary>
            /// <param name = "mapStoId">class System.String</param>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPosition", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Boolean JUD_POSITION(nint mapStoId, System.Int32 x, System.Int32 y, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudReYear(System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudReYear", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_RE_YEAR(nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudTerrain(System.Int32 terrainId, System.Int32 flag)
            /// </summary>
            /// <param name = "terrainId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudTerrain", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_TERRAIN(System.Int32 terrainId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudYear(System.String term, System.Int32 num)
            /// </summary>
            /// <param name = "term">class System.String</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudYear", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_YEAR(nint term, System.Int32 num); 
*/
            /// <summary>
            ///   System.Void SetCurrentPlayerPos(MyVector2Int pos, System.Boolean changeLastPos)
            /// </summary>
            /// <param name = "pos">struct MyVector2Int</param>
            /// <param name = "changeLastPos">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCurrentPlayerPos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_CURRENT_PLAYER_POS(MyVector2Int pos, System.Boolean changeLastPos); 
*/
            /// <summary>
            ///   System.Void SetDantianCount(System.Int32 dantianCount)
            /// </summary>
            /// <param name = "dantianCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetDantianCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_DANTIAN_COUNT(System.Int32 dantianCount); 
*/
            /// <summary>
            ///   System.Void UpdateAge(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAge", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_AGE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateBattleSpeed(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateBattleSpeed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_BATTLE_SPEED(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void UpdateBrave(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateBrave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_BRAVE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateChapterId(System.Int32 chapterId)
            /// </summary>
            /// <param name = "chapterId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateChapterId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_CHAPTER_ID(System.Int32 chapterId); 
*/
            /// <summary>
            ///   System.Void UpdateCredit(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCredit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_CREDIT(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Boolean UpdateDownMinLv(TbPlayerSto playerSto, TbNpcSto npcSto, System.Collections.Generic.List<TbArtCfg> artCfgs, System.Boolean flag, System.Boolean isOnlyArt)
            /// </summary>
            /// <param name = "playerSto">class TbPlayerSto</param>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "artCfgs">class System.Collections.Generic.List<TbArtCfg></param>
            /// <param name = "flag">struct System.Boolean</param>
            /// <param name = "isOnlyArt">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateDownMinLv", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPlayerSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtCfg>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial System.Boolean UPDATE_DOWN_MIN_LV(nint playerSto, nint npcSto, nint artCfgs, System.Boolean flag, System.Boolean isOnlyArt); 
*/
            /// <summary>
            ///   System.Void UpdateEpx(System.Single exp)
            /// </summary>
            /// <param name = "exp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateEpx", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void UPDATE_EPX(System.Single exp); 
*/
            /// <summary>
            ///   System.Void UpdateEpxPer(System.String valueStr)
            /// </summary>
            /// <param name = "valueStr">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateEpxPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_EPX_PER(nint valueStr); 
*/
            /// <summary>
            ///   System.Void UpdateExchange(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateExchange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_EXCHANGE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateExpRatio(System.Single _value)
            /// </summary>
            /// <param name = "_value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateExpRatio", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void UPDATE_EXP_RATIO(System.Single _value); 
*/
            /// <summary>
            ///   System.Void UpdateFate(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateFate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_FATE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateFire(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateFire", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_FIRE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateGold(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateGold", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_GOLD(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Boolean UpdateGrade(System.Int32 newLvId, System.Boolean flag)
            /// </summary>
            /// <param name = "newLvId">struct System.Int32</param>
            /// <param name = "flag">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateGrade", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean UPDATE_GRADE(System.Int32 newLvId, System.Boolean flag); 
*/
            /// <summary>
            ///   System.Void UpdateHp(System.Int32 hp)
            /// </summary>
            /// <param name = "hp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_HP(System.Int32 hp); 
*/
            /// <summary>
            ///   System.Void UpdateHpLimit(System.Int32 hp)
            /// </summary>
            /// <param name = "hp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHpLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_HP_LIMIT(System.Int32 hp); 
*/
            /// <summary>
            ///   System.Void UpdateHpLimitPer(System.String hpPer)
            /// </summary>
            /// <param name = "hpPer">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHpLimitPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_HP_LIMIT_PER(nint hpPer); 
*/
            /// <summary>
            ///   System.Void UpdateHpPer(System.String hpPer)
            /// </summary>
            /// <param name = "hpPer">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHpPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_HP_PER(nint hpPer); 
*/
            /// <summary>
            ///   System.Void UpdateIce(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateIce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_ICE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateJustice(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateJustice", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_JUSTICE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateMagicCount(System.Int32 number)
            /// </summary>
            /// <param name = "number">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMagicCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_MAGIC_COUNT(System.Int32 number); 
*/
            /// <summary>
            ///   System.Void UpdateMapInfoStoId(MyVector2Int cellPossition)
            /// </summary>
            /// <param name = "cellPossition">struct MyVector2Int</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMapInfoStoId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 0)]
            public partial void UPDATE_MAP_INFO_STO_ID(MyVector2Int cellPossition); 
*/
            /// <summary>
            ///   System.Void UpdateMapMove(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMapMove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_MAP_MOVE(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void UpdateMapStoId(System.String mapStoId)
            /// </summary>
            /// <param name = "mapStoId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMapStoId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_MAP_STO_ID(nint mapStoId); 
*/
            /// <summary>
            ///   System.Void UpdatePlaceLeaveByNameId(System.Int32 nameId, TbMapInfoSto curMapInfo)
            /// </summary>
            /// <param name = "nameId">struct System.Int32</param>
            /// <param name = "curMapInfo">class TbMapInfoSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePlaceLeaveByNameId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMapInfoSto", 1)]
            public partial void UPDATE_PLACE_LEAVE_BY_NAME_ID(System.Int32 nameId, nint curMapInfo); 
*/
            /// <summary>
            ///   System.Void UpdatePlaceRandom()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePlaceRandom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_PLACE_RANDOM(); 
*/
            /// <summary>
            ///   System.Void UpdateSoil(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSoil", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_SOIL(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateSpaceCount(System.Int32 number)
            /// </summary>
            /// <param name = "number">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSpaceCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_SPACE_COUNT(System.Int32 number); 
*/
            /// <summary>
            ///   System.Void UpdateStepBack()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateStepBack", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_STEP_BACK(); 
*/
            /// <summary>
            ///   System.Void UpdateSureAge(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSureAge", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_SURE_AGE(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateThunder(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateThunder", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_THUNDER(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateTreasCount(System.Int32 number)
            /// </summary>
            /// <param name = "number">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateTreasCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_TREAS_COUNT(System.Int32 number); 
*/
            /// <summary>
            ///   System.Boolean UpdateUpMinLv(System.Int32 lvId, TbPlayerSto playerSto, TbNpcSto npcSto, System.Collections.Generic.List<TbArtCfg> artCfgs, System.Boolean flag, System.Boolean isOnlyArt)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <param name = "playerSto">class TbPlayerSto</param>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "artCfgs">class System.Collections.Generic.List<TbArtCfg></param>
            /// <param name = "flag">struct System.Boolean</param>
            /// <param name = "isOnlyArt">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateUpMinLv", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPlayerSto", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbArtCfg>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            public partial System.Boolean UPDATE_UP_MIN_LV(System.Int32 lvId, nint playerSto, nint npcSto, nint artCfgs, System.Boolean flag, System.Boolean isOnlyArt); 
*/
            /// <summary>
            ///   System.Void UpdateWater(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateWater", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_WATER(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateWind(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateWind", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_WIND(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateWood(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateWood", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_WOOD(System.Int32 _value); 
*/
            /// <summary>
            ///   System.Void UpdateYear(System.Int32 _value)
            /// </summary>
            /// <param name = "_value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateYear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_YEAR(System.Int32 _value); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbPlayerImpl
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
            /// static  TbPlayerImpl get_Instance()
            /// </summary>
            /// <returns>class TbPlayerImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbPlayerImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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