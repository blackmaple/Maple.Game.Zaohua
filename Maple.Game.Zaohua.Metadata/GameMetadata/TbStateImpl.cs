namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbStateImpl"]
    /// [Singleton<TbStateImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbStateImpl>, Ptr_TbStateImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbStateImpl", "TbStateImpl")]
    public partial class TbStateImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbStateImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbStateImpl(System.IntPtr ptr) => new Ptr_TbStateImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbStateImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbStateImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbStateImpl"]
        /// </summary>
        partial struct Ptr_TbStateImpl
        {
            /// <summary>
            /// 0x0 TbStateImpl m_Instance
            /// class ["Assembly-CSharp".""."TbStateImpl"]
            /// </summary>
            /// <returns>class TbStateImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbStateImpl")]
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
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbStateImpl"]
        /// </summary>
        partial struct Ptr_TbStateImpl
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
            ///   TbBattleStateTmp AddStateTmp(System.Int32 npcTmpId, System.Int32 stateId, System.Int32 layers, TbActionTmp actionTmp)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "stateId">struct System.Int32</param>
            /// <param name = "layers">struct System.Int32</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <returns>class TbBattleStateTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStateTmp", "TbBattleStateTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 3)]
            public partial nint ADD_STATE_TMP(System.Int32 npcTmpId, System.Int32 stateId, System.Int32 layers, nint actionTmp); 
*/
            /// <summary>
            ///   System.Boolean CheckEffTime(EffTimeEnum effTimeNow, TbBattleStateTmp state, System.Int32 effIndex, TbActionTmp actionTmp)
            /// </summary>
            /// <param name = "effTimeNow">enum EffTimeEnum</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "effIndex">struct System.Int32</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckEffTime", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 3)]
            public partial System.Boolean CHECK_EFF_TIME(EffTimeEnum effTimeNow, nint state, System.Int32 effIndex, nint actionTmp); 
*/
            /// <summary>
            ///   System.Boolean CheckIsContainStateType(StateEffType type, TbBattleMagicTmp magic, TbBattlePackTmp pack)
            /// </summary>
            /// <param name = "type">enum StateEffType</param>
            /// <param name = "magic">class TbBattleMagicTmp</param>
            /// <param name = "pack">class TbBattlePackTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckIsContainStateType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateEffType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleMagicTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattlePackTmp", 2)]
            public partial System.Boolean CHECK_IS_CONTAIN_STATE_TYPE(StateEffType type, nint magic, nint pack); 
*/
            /// <summary>
            ///   System.Boolean CheckIsContainStateType(StateEffType type1, StateEffType type2, TbBattleMagicTmp magic, TbBattlePackTmp pack)
            /// </summary>
            /// <param name = "type1">enum StateEffType</param>
            /// <param name = "type2">enum StateEffType</param>
            /// <param name = "magic">class TbBattleMagicTmp</param>
            /// <param name = "pack">class TbBattlePackTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckIsContainStateType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateEffType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateEffType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleMagicTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattlePackTmp", 3)]
            public partial System.Boolean CHECK_IS_CONTAIN_STATE_TYPE(StateEffType type1, StateEffType type2, nint magic, nint pack); 
*/
            /// <summary>
            ///   System.Boolean CheckState(EffTimeEnum effTimeNow, TbBattleStateTmp state, TbActionTmp actionTmp)
            /// </summary>
            /// <param name = "effTimeNow">enum EffTimeEnum</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckState", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 2)]
            public partial System.Boolean CHECK_STATE(EffTimeEnum effTimeNow, nint state, nint actionTmp); 
*/
            /// <summary>
            ///   System.Boolean CheckStateCanAdd(System.Int32 npcTmpId, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckStateCanAdd", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            public partial System.Boolean CHECK_STATE_CAN_ADD(System.Int32 npcTmpId, nint state); 
*/
            /// <summary>
            ///   System.Boolean CheckStateTimeLine(EffTimeEnum effTimeNow, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "effTimeNow">enum EffTimeEnum</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckStateTimeLine", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            public partial System.Boolean CHECK_STATE_TIME_LINE(EffTimeEnum effTimeNow, nint state); 
*/
            /// <summary>
            ///   System.Boolean CheckTLNodeTime(EffTimeEnum effTimeNow, TbBattleStateTmp state, System.Int32 tlEffIndex)
            /// </summary>
            /// <param name = "effTimeNow">enum EffTimeEnum</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "tlEffIndex">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckTLNodeTime", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean CHECK_TL_NODE_TIME(EffTimeEnum effTimeNow, nint state, System.Int32 tlEffIndex); 
*/
            /// <summary>
            ///   System.Void DoCountAd(TbBattleNpcTmp _npcTmp, System.Int32 _value, System.Int32 _armor)
            /// </summary>
            /// <param name = "_npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "_value">struct System.Int32</param>
            /// <param name = "_armor">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoCountAd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void DO_COUNT_AD(nint _npcTmp, System.Int32 _value, System.Int32 _armor); 
*/
            /// <summary>
            ///   System.Void DoCountAdByState(FloatRef _value, TbBattleNpcTmp npcTmp, TbEffCfg effect, ActionTypeEnum type, TbBattleStateTmp state, System.Boolean isPreview)
            /// </summary>
            /// <param name = "_value">class FloatRef</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "effect">class TbEffCfg</param>
            /// <param name = "type">enum ActionTypeEnum</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "isPreview">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoCountAdByState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbEffCfg", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ActionTypeEnum", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            public partial void DO_COUNT_AD_BY_STATE(nint _value, nint npcTmp, nint effect, ActionTypeEnum type, nint state, System.Boolean isPreview); 
*/
            /// <summary>
            ///   TbBattleNpcTmp DoStateEffs(TbBattleNpcTmp npcTmp, TbBattleStateTmp state, EffTimeEnum effTime, FloatRef _value, ActionTypeEnum type, System.Boolean isOnlyCount, TbActionTmp actionTmp, System.Boolean isPreview)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "effTime">enum EffTimeEnum</param>
            /// <param name = "_value">class FloatRef</param>
            /// <param name = "type">enum ActionTypeEnum</param>
            /// <param name = "isOnlyCount">struct System.Boolean</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "isPreview">struct System.Boolean</param>
            /// <returns>class TbBattleNpcTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoStateEffs", "TbBattleNpcTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ActionTypeEnum", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
            public partial nint DO_STATE_EFFS(nint npcTmp, nint state, EffTimeEnum effTime, nint _value, ActionTypeEnum type, System.Boolean isOnlyCount, nint actionTmp, System.Boolean isPreview); 
*/
            /// <summary>
            ///   System.Int32 GetAllEnemyStateLayer(System.Int32 stateId)
            /// </summary>
            /// <param name = "stateId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllEnemyStateLayer", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_ALL_ENEMY_STATE_LAYER(System.Int32 stateId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbStateCfg> GetEffState(TbMagicCfg magicCfg, TbItemCfg packCfg, TbArtCfg artCfg, TbNpcSto npcSto, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "magicCfg">class TbMagicCfg</param>
            /// <param name = "packCfg">class TbItemCfg</param>
            /// <param name = "artCfg">class TbArtCfg</param>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>class System.Collections.Generic.List<TbStateCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEffState", "System.Collections.Generic.List<TbStateCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 4)]
            public partial nint GET_EFF_STATE(nint magicCfg, nint packCfg, nint artCfg, nint npcSto, nint npcTmp); 
*/
            /// <summary>
            ///   System.Int32 GetLayerValue(System.Collections.Generic.List<System.String> parameter, System.Int32 layer)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLayerValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_LAYER_VALUE(nint parameter, System.Int32 layer); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStateTmp> GetNpcAllState(System.Int32 npcTmpId)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbBattleStateTmp></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcAllState", "System.Collections.Generic.List<TbBattleStateTmp>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_ALL_STATE(System.Int32 npcTmpId); 
*/
            /// <summary>
            ///   TbStateCfg GetStateByType(StateEffType type, TbBattleMagicTmp magic, TbBattlePackTmp pack)
            /// </summary>
            /// <param name = "type">enum StateEffType</param>
            /// <param name = "magic">class TbBattleMagicTmp</param>
            /// <param name = "pack">class TbBattlePackTmp</param>
            /// <returns>class TbStateCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStateByType", "TbStateCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateEffType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleMagicTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattlePackTmp", 2)]
            public partial nint GET_STATE_BY_TYPE(StateEffType type, nint magic, nint pack); 
*/
            /// <summary>
            ///   TbStateCfg GetStateCfg(System.Int32 _id)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <returns>class TbStateCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStateCfg", "TbStateCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_STATE_CFG(System.Int32 _id); 
*/
            /// <summary>
            ///   System.Int32 GetStateLayer(System.Int32 npcTmpId, System.Int32 stateId)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "stateId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStateLayer", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_STATE_LAYER(System.Int32 npcTmpId, System.Int32 stateId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStateTmp> GetStatesBy(System.Int32 npcTmpId, EffTimeEnum effTime)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "effTime">enum EffTimeEnum</param>
            /// <returns>class System.Collections.Generic.List<TbBattleStateTmp></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStatesBy", "System.Collections.Generic.List<TbBattleStateTmp>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EffTimeEnum", 1)]
            public partial nint GET_STATES_BY(System.Int32 npcTmpId, EffTimeEnum effTime); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStateTmp> GetStatesByChange(System.Int32 npcTmpId, StateChangeEnum change)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "change">enum StateChangeEnum</param>
            /// <returns>class System.Collections.Generic.List<TbBattleStateTmp></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStatesByChange", "System.Collections.Generic.List<TbBattleStateTmp>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateChangeEnum", 1)]
            public partial nint GET_STATES_BY_CHANGE(System.Int32 npcTmpId, StateChangeEnum change); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetStatesChanges(TbBattleStateTmp States)
            /// </summary>
            /// <param name = "States">class TbBattleStateTmp</param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStatesChanges", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 0)]
            public partial nint GET_STATES_CHANGES(nint States); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStateTmp> GetStateTmpByEff(System.Int32 npcTmpId, StateEnum eff)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <param name = "eff">enum StateEnum</param>
            /// <returns>class System.Collections.Generic.List<TbBattleStateTmp></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStateTmpByEff", "System.Collections.Generic.List<TbBattleStateTmp>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("StateEnum", 1)]
            public partial nint GET_STATE_TMP_BY_EFF(System.Int32 npcTmpId, StateEnum eff); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbBattleStateTmp> GetTargetState(System.Int32 npcTmpId)
            /// </summary>
            /// <param name = "npcTmpId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbBattleStateTmp></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTargetState", "System.Collections.Generic.List<TbBattleStateTmp>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TARGET_STATE(System.Int32 npcTmpId); 
*/
            /// <summary>
            ///   System.Void InFire(TbBattleNpcTmp npcTmp, System.Collections.Generic.List<System.String> parameter, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InFire", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void IN_FIRE(nint npcTmp, nint parameter, nint state); 
*/
            /// <summary>
            ///   System.Void JumpRound(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JumpRound", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            public partial void JUMP_ROUND(nint parameter, nint npcTmp); 
*/
            /// <summary>
            ///   System.Void RecoveryPackByLayer(System.Collections.Generic.List<System.String> parameter, TbActionTmp actionTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecoveryPackByLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void RECOVERY_PACK_BY_LAYER(nint parameter, nint actionTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ReHarm(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbActionTmp actionTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReHarm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 3)]
            public partial void RE_HARM(nint parameter, nint npcTmp, nint actionTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ReHarmByDamage(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, FloatRef damageValue, System.Boolean isCount, System.Boolean isPreview, TbActionTmp actionTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "damageValue">class FloatRef</param>
            /// <param name = "isCount">struct System.Boolean</param>
            /// <param name = "isPreview">struct System.Boolean</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReHarmByDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 6)]
            public partial void RE_HARM_BY_DAMAGE(nint parameter, nint npcTmp, nint damageValue, System.Boolean isCount, System.Boolean isPreview, nint actionTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ReHarmByLayer(System.Collections.Generic.List<System.String> parameter, System.Int32 layer, TbBattleNpcTmp npcTmp, TbActionTmp actionTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReHarmByLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 4)]
            public partial void RE_HARM_BY_LAYER(nint parameter, System.Int32 layer, nint npcTmp, nint actionTmp, nint state); 
*/
            /// <summary>
            ///   System.Void RemoveState(TbBattleStateTmp state)
            /// </summary>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 0)]
            public partial void REMOVE_STATE(nint state); 
*/
            /// <summary>
            ///   System.Void SetNpcLimit(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNpcLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void SET_NPC_LIMIT(nint parameter, nint npcTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ToHarm(System.Int32 value, TbBattleStateTmp state, TbBattleNpcTmp npcTmp, TbBattleNpcTmp caster)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "caster">class TbBattleNpcTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 3)]
            public partial void TO_HARM(System.Int32 value, nint state, nint npcTmp, nint caster); 
*/
            /// <summary>
            ///   System.Void ToHarmByDamage(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbActionTmp actionTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarmByDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 3)]
            public partial void TO_HARM_BY_DAMAGE(nint parameter, nint npcTmp, nint actionTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ToHarmByHpPer(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarmByHpPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void TO_HARM_BY_HP_PER(nint parameter, nint npcTmp, nint state); 
*/
            /// <summary>
            ///   System.Void ToHarmByLayer(System.Collections.Generic.List<System.String> parameter, System.Int32 layer, TbBattleStateTmp state, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarmByLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 3)]
            public partial void TO_HARM_BY_LAYER(nint parameter, System.Int32 layer, nint state, nint npcTmp); 
*/
            /// <summary>
            ///   System.Void ToHarmFixed(System.Collections.Generic.List<System.String> parameter, TbBattleStateTmp state, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarmFixed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 2)]
            public partial void TO_HARM_FIXED(nint parameter, nint state, nint npcTmp); 
*/
            /// <summary>
            ///   System.Void ToHarmOnZeroLayer(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToHarmOnZeroLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void TO_HARM_ON_ZERO_LAYER(nint parameter, nint npcTmp, nint state); 
*/
            /// <summary>
            ///   TbBattleNpcTmp UpdateAttrByLayer(TbBattleNpcTmp npcTmp, System.Collections.Generic.List<System.String> parameter, TbBattleStateTmp state, ActionTypeEnum type)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "type">enum ActionTypeEnum</param>
            /// <returns>class TbBattleNpcTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAttrByLayer", "TbBattleNpcTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ActionTypeEnum", 3)]
            public partial nint UPDATE_ATTR_BY_LAYER(nint npcTmp, nint parameter, nint state, ActionTypeEnum type); 
*/
            /// <summary>
            ///   TbBattleNpcTmp UpdateAttrByState(TbBattleNpcTmp npcTmp, System.Collections.Generic.List<System.String> parameter, TbBattleStateTmp state, ActionTypeEnum type, System.Int32 flag)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <param name = "type">enum ActionTypeEnum</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>class TbBattleNpcTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAttrByState", "TbBattleNpcTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ActionTypeEnum", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial nint UPDATE_ATTR_BY_STATE(nint npcTmp, nint parameter, nint state, ActionTypeEnum type, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Void UpdateHarm(FloatRef damageValue, System.Collections.Generic.List<System.String> parameter)
            /// </summary>
            /// <param name = "damageValue">class FloatRef</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHarm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            public partial void UPDATE_HARM(nint damageValue, nint parameter); 
*/
            /// <summary>
            ///   System.Void UpdateHarmByHp(FloatRef damageValue, System.Collections.Generic.List<System.String> parameter)
            /// </summary>
            /// <param name = "damageValue">class FloatRef</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHarmByHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            public partial void UPDATE_HARM_BY_HP(nint damageValue, nint parameter); 
*/
            /// <summary>
            ///   System.Void UpdateHarmByLayer(FloatRef damageValue, System.Collections.Generic.List<System.String> parameter, System.Int32 layer, TbBattleNpcTmp npcTmp)
            /// </summary>
            /// <param name = "damageValue">class FloatRef</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHarmByLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 3)]
            public partial void UPDATE_HARM_BY_LAYER(nint damageValue, nint parameter, System.Int32 layer, nint npcTmp); 
*/
            /// <summary>
            ///   System.Void UpdateHarmPer(FloatRef damageValue, System.Collections.Generic.List<System.String> parameter)
            /// </summary>
            /// <param name = "damageValue">class FloatRef</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHarmPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FloatRef", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            public partial void UPDATE_HARM_PER(nint damageValue, nint parameter); 
*/
            /// <summary>
            ///   System.Void UpdateNow(TbBattleNpcTmp npcTmp, System.String attrName, System.Int32 value)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "attrName">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void UPDATE_NOW(nint npcTmp, nint attrName, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void UpdateNowByDamage(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbActionTmp actionTmp)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "actionTmp">class TbActionTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNowByDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActionTmp", 2)]
            public partial void UPDATE_NOW_BY_DAMAGE(nint parameter, nint npcTmp, nint actionTmp); 
*/
            /// <summary>
            ///   TbBattleNpcTmp UpdateNowByLayer(TbBattleNpcTmp npcTmp, System.Collections.Generic.List<System.String> parameter, TbBattleStateTmp state)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "state">class TbBattleStateTmp</param>
            /// <returns>class TbBattleNpcTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNowByLayer", "TbBattleNpcTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial nint UPDATE_NOW_BY_LAYER(nint npcTmp, nint parameter, nint state); 
*/
            /// <summary>
            ///   TbBattleNpcTmp UpdateNowFix(TbBattleNpcTmp npcTmp, System.Collections.Generic.List<System.String> parameter)
            /// </summary>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <returns>class TbBattleNpcTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNowFix", "TbBattleNpcTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            public partial nint UPDATE_NOW_FIX(nint npcTmp, nint parameter); 
*/
            /// <summary>
            ///   System.Void UpdateStateLayer(System.Collections.Generic.List<System.String> parameter, TbBattleNpcTmp npcTmp, TbBattleStateTmp curState)
            /// </summary>
            /// <param name = "parameter">class System.Collections.Generic.List<System.String></param>
            /// <param name = "npcTmp">class TbBattleNpcTmp</param>
            /// <param name = "curState">class TbBattleStateTmp</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateStateLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleNpcTmp", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbBattleStateTmp", 2)]
            public partial void UPDATE_STATE_LAYER(nint parameter, nint npcTmp, nint curState); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbStateImpl
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
            /// static  TbStateImpl get_Instance()
            /// </summary>
            /// <returns>class TbStateImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbStateImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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