namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbNpcImpl"]
    /// [Singleton<TbNpcImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbNpcImpl>, Ptr_TbNpcImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbNpcImpl", "TbNpcImpl")]
    public partial class TbNpcImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbNpcImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbNpcImpl(System.IntPtr ptr) => new Ptr_TbNpcImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbNpcImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbNpcImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbNpcImpl"]
        /// </summary>
        partial struct Ptr_TbNpcImpl
        {
            /// <summary>
            /// 0x0 TbNpcImpl m_Instance
            /// class ["Assembly-CSharp".""."TbNpcImpl"]
            /// </summary>
            /// <returns>class TbNpcImpl</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbNpcImpl")]
            public static partial Ptr_TbNpcImpl M_INSTANCE { get; set; } 


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
            /// 0x10 System.Int32[] battlePosTarget
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battlePosTarget", "System.Int32[]")]
            public partial nint BATTLE_POS_TARGET { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 count
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("count", "System.Int32")]
            public partial System.Int32 COUNT { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 count2
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("count2", "System.Int32")]
            public partial System.Int32 COUNT2 { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbNpcImpl"]
        /// </summary>
        partial struct Ptr_TbNpcImpl
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
            ///   System.Void AddNpcArt(System.Int32 npcId, System.Int32 artId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNpcArt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_NPC_ART(System.Int32 npcId, System.Int32 artId); 

            /// <summary>
            ///   System.Void AddNpcArtByNpcSto(TbNpcSto npcSto, System.Int32 artId)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNpcArtByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_NPC_ART_BY_NPC_STO(nint npcSto, System.Int32 artId); 
*/
            /// <summary>
            ///   System.Void AddNpcMagic(System.Int32 npcId, System.Int32 magicId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "magicId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNpcMagic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_NPC_MAGIC(System.Int32 npcId, System.Int32 magicId); 

            /// <summary>
            ///   System.Void AddNpcMagicByNpcSto(TbNpcSto npcSto, System.Int32 magicId)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "magicId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNpcMagicByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_NPC_MAGIC_BY_NPC_STO(nint npcSto, System.Int32 magicId); 
*/
            /// <summary>
            ///   System.Void AddNpcSto(TbNpcSto npcSto)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            public partial void ADD_NPC_STO(nint npcSto); 
*/
            /// <summary>
            ///   System.Single AddValueByItem(TbNpcSto _npcSto)
            /// </summary>
            /// <param name = "_npcSto">class TbNpcSto</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddValueByItem", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            public partial System.Single ADD_VALUE_BY_ITEM(nint _npcSto); 
*/
            /// <summary>
            ///   System.Void DelNpcArt(System.Int32 npcId, System.Int32 artId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelNpcArt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DEL_NPC_ART(System.Int32 npcId, System.Int32 artId); 

            /// <summary>
            ///   System.Void DelNpcArtByNpcSto(TbNpcSto npcSto, System.Int32 artId)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "artId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelNpcArtByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DEL_NPC_ART_BY_NPC_STO(nint npcSto, System.Int32 artId); 
*/
            /// <summary>
            ///   System.Void DelNpcMagic(System.Int32 npcId, System.Int32 magicId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "magicId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelNpcMagic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DEL_NPC_MAGIC(System.Int32 npcId, System.Int32 magicId); 

            /// <summary>
            ///   System.Void DelNpcMagicByNpcSto(TbNpcSto npcSto, System.Int32 magicId)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "magicId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelNpcMagicByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DEL_NPC_MAGIC_BY_NPC_STO(nint npcSto, System.Int32 magicId); 
*/
            /// <summary>
            ///   TbAttribCfg GetAttribCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbAttribCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttribCfg", "TbAttribCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ATTRIB_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbAttribCfg GetAttribCfgBy(System.Int32 attri, System.Int32 lv)
            /// </summary>
            /// <param name = "attri">struct System.Int32</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>class TbAttribCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttribCfgBy", "TbAttribCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ATTRIB_CFG_BY(System.Int32 attri, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Int32 GetAttribCfgBy2(System.Int32 attri, System.Int32 lv)
            /// </summary>
            /// <param name = "attri">struct System.Int32</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttribCfgBy2", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_ATTRIB_CFG_BY2(System.Int32 attri, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Int32 GetBattlePos(TbNpcCfg cfg, System.Collections.Generic.List<BattlePos> pos, System.Int32 index)
            /// </summary>
            /// <param name = "cfg">class TbNpcCfg</param>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattlePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 GET_BATTLE_POS(nint cfg, nint pos, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 GetBattlePos(TbNpcSto sto, System.Collections.Generic.List<BattlePos> pos, System.Int32 index)
            /// </summary>
            /// <param name = "sto">class TbNpcSto</param>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattlePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 GET_BATTLE_POS(nint sto, nint pos, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 GetBattlePos(System.Int32 wide, System.Collections.Generic.List<BattlePos> pos, System.Int32 index)
            /// </summary>
            /// <param name = "wide">struct System.Int32</param>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattlePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 GET_BATTLE_POS(System.Int32 wide, nint pos, System.Int32 index); 
*/
            /// <summary>
            ///   BattlePowerTmp GetBattleValueTmp(TbNpcSto npc)
            /// </summary>
            /// <param name = "npc">class TbNpcSto</param>
            /// <returns>class BattlePowerTmp</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleValueTmp", "BattlePowerTmp", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            public partial nint GET_BATTLE_VALUE_TMP(nint npc); 
*/
            /// <summary>
            ///   System.Int32 GetBeatExp(System.Int32 lvId, System.Int32 gradeId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBeatExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_BEAT_EXP(System.Int32 lvId, System.Int32 gradeId); 
*/
            /// <summary>
            ///   System.Int32 GetBigLvCount(System.Int32 bigLv)
            /// </summary>
            /// <param name = "bigLv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBigLvCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_BIG_LV_COUNT(System.Int32 bigLv); 
*/
            /// <summary>
            ///   TbNpcCfg GetDetailNpcCfg(TbNpcCfg oldNpcCfg, TbEnemyCfg enemyCfg)
            /// </summary>
            /// <param name = "oldNpcCfg">class TbNpcCfg</param>
            /// <param name = "enemyCfg">class TbEnemyCfg</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDetailNpcCfg", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbEnemyCfg", 1)]
            public partial nint GET_DETAIL_NPC_CFG(nint oldNpcCfg, nint enemyCfg); 
*/
            /// <summary>
            ///   System.Int32 GetDiffict(System.Collections.Generic.List<TbNpcSto> npcStos)
            /// </summary>
            /// <param name = "npcStos">class System.Collections.Generic.List<TbNpcSto></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDiffict", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcSto>", 0)]
            public partial System.Int32 GET_DIFFICT(nint npcStos); 
*/
            /// <summary>
            ///   System.Int32 GetExp(TbNpcSto _npcSto, TbNpcCfg _npcCfg)
            /// </summary>
            /// <param name = "_npcSto">class TbNpcSto</param>
            /// <param name = "_npcCfg">class TbNpcCfg</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            public partial System.Int32 GET_EXP(nint _npcSto, nint _npcCfg); 
*/
            /// <summary>
            ///   TbFaceDataCfg GetFaceDataCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbFaceDataCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFaceDataCfg", "TbFaceDataCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FACE_DATA_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   System.String GetHeadPath(TbNpcSto npcSto)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeadPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            public partial nint GET_HEAD_PATH(nint npcSto); 
*/
            /// <summary>
            ///   TbEnemyCfg GetInitEnemys(System.Int32 _type, System.Int32 _strong)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_strong">struct System.Int32</param>
            /// <returns>class TbEnemyCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInitEnemys", "TbEnemyCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_INIT_ENEMYS(System.Int32 _type, System.Int32 _strong); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcSto> GetInteractNpcStosByMapInfo(System.String _mapid, MyVector2Int _cellPosition, System.Int32 buildId)
            /// </summary>
            /// <param name = "_mapid">class System.String</param>
            /// <param name = "_cellPosition">struct MyVector2Int</param>
            /// <param name = "buildId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbNpcSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInteractNpcStosByMapInfo", "System.Collections.Generic.List<TbNpcSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint GET_INTERACT_NPC_STOS_BY_MAP_INFO(nint _mapid, MyVector2Int _cellPosition, System.Int32 buildId); 
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
            ///   System.Collections.Generic.List<TbLvCfg> GetLvIdByLayerId(System.Int32 layerId)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbLvCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLvIdByLayerId", "System.Collections.Generic.List<TbLvCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_LV_ID_BY_LAYER_ID(System.Int32 layerId); 
*/
            /// <summary>
            ///   TbLvCfg GetLvNextCfg(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class TbLvCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLvNextCfg", "TbLvCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_LV_NEXT_CFG(System.Int32 lvId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbMagicSto> GetMagicStosByNpcId(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbMagicSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMagicStosByNpcId", "System.Collections.Generic.List<TbMagicSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MAGIC_STOS_BY_NPC_ID(System.Int32 id); 
*/
            /// <summary>
            ///   TbNpcSto GetMainNpcSto()
            /// </summary>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMainNpcSto", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAIN_NPC_STO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<BattlePos> GetNewBattlePos()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BattlePos></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNewBattlePos", "System.Collections.Generic.List<BattlePos>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NEW_BATTLE_POS(); 
*/
            /// <summary>
            ///   System.Int32 GetNextLvId(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNextLvId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_NEXT_LV_ID(System.Int32 lvId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbRoleCfg> GetNoRoleList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRoleCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNoRoleList", "System.Collections.Generic.List<TbRoleCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NO_ROLE_LIST(); 
*/
            /// <summary>
            ///   TbNpcCfg GetNpcCfg(System.Int32 cfgId)
            /// </summary>
            /// <param name = "cfgId">struct System.Int32</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcCfg", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_CFG(System.Int32 cfgId); 
*/
            /// <summary>
            ///   TbNpcCfg GetNpcCfgByNpcStoId(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcCfgByNpcStoId", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_CFG_BY_NPC_STO_ID(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Int32 GetNpcCfgSex(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcCfgSex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_NPC_CFG_SEX(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.String GetNpcName(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_NAME(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.String GetNpcPath(System.Int32 cfgId, System.String type)
            /// </summary>
            /// <param name = "cfgId">struct System.Int32</param>
            /// <param name = "type">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial nint GET_NPC_PATH(System.Int32 cfgId, nint type); 
*/
            /// <summary>
            ///   TbNpcSto GetNpcSto(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcSto", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_STO(System.Int32 id); 
*/
            /// <summary>
            ///   TbNpcSto GetNpcStoByNpcId(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcStoByNpcId", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_STO_BY_NPC_ID(System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcSto> GetNpcstoForGroup(System.Collections.Generic.List<TbNpcPlaceSto> _placeStos)
            /// </summary>
            /// <param name = "_placeStos">class System.Collections.Generic.List<TbNpcPlaceSto></param>
            /// <returns>class System.Collections.Generic.List<TbNpcSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcstoForGroup", "System.Collections.Generic.List<TbNpcSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcPlaceSto>", 0)]
            public partial nint GET_NPCSTO_FOR_GROUP(nint _placeStos); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbNpcSto> GetNpcStoListByMapInfoId(MyVector2Int gamePosition)
            /// </summary>
            /// <param name = "gamePosition">struct MyVector2Int</param>
            /// <returns>class System.Collections.Generic.List<TbNpcSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcStoListByMapInfoId", "System.Collections.Generic.List<TbNpcSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 0)]
            public partial nint GET_NPC_STO_LIST_BY_MAP_INFO_ID(MyVector2Int gamePosition); 
*/
            /// <summary>
            ///   TbNpcCfg GetOneNpcRandom(System.Int32 strong, System.Int32 species)
            /// </summary>
            /// <param name = "strong">struct System.Int32</param>
            /// <param name = "species">struct System.Int32</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOneNpcRandom", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ONE_NPC_RANDOM(System.Int32 strong, System.Int32 species); 
*/
            /// <summary>
            ///   TbNpcCfg GetOneNpcRandomByLayerId(System.Int32 layerId, System.Int32 species, System.Int32 playerType)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <param name = "species">struct System.Int32</param>
            /// <param name = "playerType">struct System.Int32</param>
            /// <returns>class TbNpcCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOneNpcRandomByLayerId", "TbNpcCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint GET_ONE_NPC_RANDOM_BY_LAYER_ID(System.Int32 layerId, System.Int32 species, System.Int32 playerType); 
*/
            /// <summary>
            ///   System.Int32 GetOneWidePos(System.Collections.Generic.List<BattlePos> pos, System.Int32 curIndex)
            /// </summary>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "curIndex">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOneWidePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_ONE_WIDE_POS(nint pos, System.Int32 curIndex); 
*/
            /// <summary>
            ///   TbLayerCfg GetParentLayerCfg(System.Int32 layerId)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <returns>class TbLayerCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetParentLayerCfg", "TbLayerCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PARENT_LAYER_CFG(System.Int32 layerId); 
*/
            /// <summary>
            ///   TbLvCfg GetParentLvCfg(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class TbLvCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetParentLvCfg", "TbLvCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PARENT_LV_CFG(System.Int32 lvId); 
*/
            /// <summary>
            ///   TbPostCfg GetPostCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbPostCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostCfg", "TbPostCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_POST_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   TbPracCfg GetPracCfg(System.Int32 pracId)
            /// </summary>
            /// <param name = "pracId">struct System.Int32</param>
            /// <returns>class TbPracCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPracCfg", "TbPracCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PRAC_CFG(System.Int32 pracId); 
*/
            /// <summary>
            ///   TbPracCfg GetPracCfgBy(System.Int32 species, System.Int32 lv)
            /// </summary>
            /// <param name = "species">struct System.Int32</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>class TbPracCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPracCfgBy", "TbPracCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PRAC_CFG_BY(System.Int32 species, System.Int32 lv); 
*/
            /// <summary>
            ///   TbPracCfg GetPracCfgByRoleId(System.Int32 roleId, System.Int32 difficulty)
            /// </summary>
            /// <param name = "roleId">struct System.Int32</param>
            /// <param name = "difficulty">struct System.Int32</param>
            /// <returns>class TbPracCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPracCfgByRoleId", "TbPracCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PRAC_CFG_BY_ROLE_ID(System.Int32 roleId, System.Int32 difficulty); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbRoleCfg> GetRoleList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbRoleCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleList", "System.Collections.Generic.List<TbRoleCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ROLE_LIST(); 
*/
            /// <summary>
            ///   TbSectCfg GetSectCfg(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbSectCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSectCfg", "TbSectCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SECT_CFG(System.Int32 id); 
*/
            /// <summary>
            ///   System.String GetShowName(TbNpcSto sto, TbNpcCfg npcCfg)
            /// </summary>
            /// <param name = "sto">class TbNpcSto</param>
            /// <param name = "npcCfg">class TbNpcCfg</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShowName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            public partial nint GET_SHOW_NAME(nint sto, nint npcCfg); 
*/
            /// <summary>
            ///   System.Int32 GetStoIdByNpcid(System.Int32 npcId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStoIdByNpcid", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_STO_ID_BY_NPCID(System.Int32 npcId); 
*/
            /// <summary>
            ///   TbLvCfg GetTbLvCfgBefor(System.Int32 lvId)
            /// </summary>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>class TbLvCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTbLvCfgBefor", "TbLvCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TB_LV_CFG_BEFOR(System.Int32 lvId); 
*/
            /// <summary>
            ///   System.Int32 GetThreeWidePos(System.Collections.Generic.List<BattlePos> pos, System.Int32 curIndex)
            /// </summary>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "curIndex">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetThreeWidePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_THREE_WIDE_POS(nint pos, System.Int32 curIndex); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetTradeItemList(System.Int32 tradeCfgId, System.Collections.Generic.HashSet<System.Int32> noTradeList)
            /// </summary>
            /// <param name = "tradeCfgId">struct System.Int32</param>
            /// <param name = "noTradeList">class System.Collections.Generic.HashSet<System.Int32></param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTradeItemList", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<System.Int32>", 1)]
            public partial nint GET_TRADE_ITEM_LIST(System.Int32 tradeCfgId, nint noTradeList); 
*/
            /// <summary>
            ///   System.Int32 GetTwoWidePos(System.Collections.Generic.List<BattlePos> pos, System.Int32 curIndex)
            /// </summary>
            /// <param name = "pos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "curIndex">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTwoWidePos", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_TWO_WIDE_POS(nint pos, System.Int32 curIndex); 
*/
            /// <summary>
            ///   TbNpcSto GetUpdateNpcSto(TbNpcSto _sto, System.Single updateFloat)
            /// </summary>
            /// <param name = "_sto">class TbNpcSto</param>
            /// <param name = "updateFloat">struct System.Single</param>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUpdateNpcSto", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial nint GET_UPDATE_NPC_STO(nint _sto, System.Single updateFloat); 
*/
            /// <summary>
            ///   System.Int32 GetWeight(TbNpcSto _npcSto, TbNpcCfg _npcCfg)
            /// </summary>
            /// <param name = "_npcSto">class TbNpcSto</param>
            /// <param name = "_npcCfg">class TbNpcCfg</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeight", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            public partial System.Int32 GET_WEIGHT(nint _npcSto, nint _npcCfg); 
*/
            /// <summary>
            ///   System.Int32 GetWeightByParentLayerCfg(System.Int32 layerId)
            /// </summary>
            /// <param name = "layerId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeightByParentLayerCfg", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_WEIGHT_BY_PARENT_LAYER_CFG(System.Int32 layerId); 
*/
            /// <summary>
            ///   TbMapInfoSto InitAppointNpcInMap(System.Int32 npcId, System.Int32 terrainId, System.Int32 nameId, System.Int32 buildId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "terrainId">struct System.Int32</param>
            /// <param name = "nameId">struct System.Int32</param>
            /// <param name = "buildId">struct System.Int32</param>
            /// <returns>class TbMapInfoSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitAppointNpcInMap", "TbMapInfoSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint INIT_APPOINT_NPC_IN_MAP(System.Int32 npcId, System.Int32 terrainId, System.Int32 nameId, System.Int32 buildId); 
*/
            /// <summary>
            ///   System.Void InitEnemyNpcStos(System.Collections.Generic.List<TbNpcCfg> npcCfgList, System.Collections.Generic.List<BattlePos> battlePos, TbEnemyCfg enemyCfg, System.Int32 index)
            /// </summary>
            /// <param name = "npcCfgList">class System.Collections.Generic.List<TbNpcCfg></param>
            /// <param name = "battlePos">class System.Collections.Generic.List<BattlePos></param>
            /// <param name = "enemyCfg">class TbEnemyCfg</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitEnemyNpcStos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcCfg>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<BattlePos>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbEnemyCfg", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void INIT_ENEMY_NPC_STOS(nint npcCfgList, nint battlePos, nint enemyCfg, System.Int32 index); 
*/
            /// <summary>
            ///   System.Boolean InitEnemys(System.String _species, MyVector2Int _cellPosition, System.Int32 _terrainId, System.Int32 _type, System.Int32 _strong)
            /// </summary>
            /// <param name = "_species">class System.String</param>
            /// <param name = "_cellPosition">struct MyVector2Int</param>
            /// <param name = "_terrainId">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "_strong">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitEnemys", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial System.Boolean INIT_ENEMYS(nint _species, MyVector2Int _cellPosition, System.Int32 _terrainId, System.Int32 _type, System.Int32 _strong); 
*/
            /// <summary>
            ///   System.Void InitNpcSto(TbActor _actor, TbNpcCfg _cfg, TbPracCfg _prac)
            /// </summary>
            /// <param name = "_actor">class TbActor</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <param name = "_prac">class TbPracCfg</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPracCfg", 2)]
            public partial void INIT_NPC_STO(nint _actor, nint _cfg, nint _prac); 
*/
            /// <summary>
            ///   System.Void InitSpecifiedEnemys(MyVector2Int _cellPosition, System.Int32 _terrainId, System.Collections.Generic.List<System.Int32> npcIdList)
            /// </summary>
            /// <param name = "_cellPosition">struct MyVector2Int</param>
            /// <param name = "_terrainId">struct System.Int32</param>
            /// <param name = "npcIdList">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitSpecifiedEnemys", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 2)]
            public partial void INIT_SPECIFIED_ENEMYS(MyVector2Int _cellPosition, System.Int32 _terrainId, nint npcIdList); 
*/
            /// <summary>
            ///   System.Void InitThisEnemys(MyVector2Int _cellPosition, System.Collections.Generic.List<TbNpcCfg> npcCfgs)
            /// </summary>
            /// <param name = "_cellPosition">struct MyVector2Int</param>
            /// <param name = "npcCfgs">class System.Collections.Generic.List<TbNpcCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitThisEnemys", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MyVector2Int", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbNpcCfg>", 1)]
            public partial void INIT_THIS_ENEMYS(MyVector2Int _cellPosition, nint npcCfgs); 
*/
            /// <summary>
            ///   TbNpcSto InitTraderNpc(System.Int32 attribute, System.Int32 eventType, System.Int32 addLv)
            /// </summary>
            /// <param name = "attribute">struct System.Int32</param>
            /// <param name = "eventType">struct System.Int32</param>
            /// <param name = "addLv">struct System.Int32</param>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitTraderNpc", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint INIT_TRADER_NPC(System.Int32 attribute, System.Int32 eventType, System.Int32 addLv); 
*/
            /// <summary>
            ///   System.Boolean IsEligibleTerrain(TbNpcCfg _npc, System.String _terrainId)
            /// </summary>
            /// <param name = "_npc">class TbNpcCfg</param>
            /// <param name = "_terrainId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsEligibleTerrain", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Boolean IS_ELIGIBLE_TERRAIN(nint _npc, nint _terrainId); 
*/
            /// <summary>
            ///   System.Boolean JudAction(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudAction", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ACTION(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudActionNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudActionNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ACTION_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudAdvance(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudAdvance", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ADVANCE(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudAdvanceNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudAdvanceNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ADVANCE_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudArmor(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudArmor", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ARMOR(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudArmorNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudArmorNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_ARMOR_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudDraw(System.Int32 npcId, System.Int32 clothesType, System.Int32 flag)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "clothesType">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudDraw", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_DRAW(System.Int32 npcId, System.Int32 clothesType, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudHp(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudHp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_HP(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudHpNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudHpNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_HP_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudMoney(System.Int32 npcId, System.String term, System.Int32 num)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "term">class System.String</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudMoney", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_MONEY(System.Int32 npcId, nint term, System.Int32 num); 
*/
            /// <summary>
            ///   System.Boolean JudNpcFlag(System.Int32 npcId, System.Int32 flag)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudNpcFlag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_NPC_FLAG(System.Int32 npcId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudNpcLv(System.Int32 npcId, System.String term, System.Int32 lvid)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "term">class System.String</param>
            /// <param name = "lvid">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudNpcLv", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_NPC_LV(System.Int32 npcId, nint term, System.Int32 lvid); 
*/
            /// <summary>
            ///   System.Boolean JudNpcSpecies(System.Int32 id, System.Int32 type, System.Int32 flag)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudNpcSpecies", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_NPC_SPECIES(System.Int32 id, System.Int32 type, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudPhyAtt(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPhyAtt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_PHY_ATT(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudPhyAttNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPhyAttNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_PHY_ATT_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudPhyDef(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPhyDef", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_PHY_DEF(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudPhyDefNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPhyDefNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_PHY_DEF_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudRewardByLv(TbNpcSto npcSto)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudRewardByLv", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            public partial System.Boolean JUD_REWARD_BY_LV(nint npcSto); 
*/
            /// <summary>
            ///   System.Boolean JudSex(System.Int32 id, System.Int32 type, System.Int32 flag)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudSex", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_SEX(System.Int32 id, System.Int32 type, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudSorAtt(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudSorAtt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_SOR_ATT(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudSorAttNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudSorAttNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_SOR_ATT_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudSorDef(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudSorDef", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_SOR_DEF(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean JudSorDefNow(System.Int32 id, System.String v, System.Int32 value)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "v">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudSorDefNow", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_SOR_DEF_NOW(System.Int32 id, nint v, System.Int32 value); 
*/
            /// <summary>
            ///   TbNpcSto OnitNpcSto(TbNpcCfg cfg)
            /// </summary>
            /// <param name = "cfg">class TbNpcCfg</param>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnitNpcSto", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 0)]
            public partial nint ONIT_NPC_STO(nint cfg); 
*/
            /// <summary>
            ///   System.Void OnitNpcStoBattleData(TbNpcSto _sto, TbNpcCfg _cfg)
            /// </summary>
            /// <param name = "_sto">class TbNpcSto</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnitNpcStoBattleData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            public partial void ONIT_NPC_STO_BATTLE_DATA(nint _sto, nint _cfg); 
*/
            /// <summary>
            ///   System.Void RefresNpcTradeItem(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefresNpcTradeItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REFRES_NPC_TRADE_ITEM(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void RemoveNpcSto(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REMOVE_NPC_STO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void ResetNpcStoBattleData(TbNpcSto npcSto, System.Int32 newLvId, System.String newArtId)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "newLvId">struct System.Int32</param>
            /// <param name = "newArtId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetNpcStoBattleData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void RESET_NPC_STO_BATTLE_DATA(nint npcSto, System.Int32 newLvId, nint newArtId); 
*/
            /// <summary>
            ///   System.Void RestBranchNpc(TbReadPlaySto plots)
            /// </summary>
            /// <param name = "plots">class TbReadPlaySto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RestBranchNpc", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbReadPlaySto", 0)]
            public partial void REST_BRANCH_NPC(nint plots); 
*/
            /// <summary>
            ///   System.Void SetClotheType(System.Int32 type, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClotheType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_CLOTHE_TYPE(System.Int32 type, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void SetCustomFace(System.Int32 faceDataId, UnityEngine.Transform npcNL, System.Int32 type)
            /// </summary>
            /// <param name = "faceDataId">struct System.Int32</param>
            /// <param name = "npcNL">class UnityEngine.Transform</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCustomFace", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void SET_CUSTOM_FACE(System.Int32 faceDataId, nint npcNL, System.Int32 type); 
*/
            /// <summary>
            ///   System.Void SetCustomImage(UnityEngine.UI.Image image, TbFaceCfg faceCfg, System.Int32 type)
            /// </summary>
            /// <param name = "image">class UnityEngine.UI.Image</param>
            /// <param name = "faceCfg">class TbFaceCfg</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCustomImage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Image", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbFaceCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void SET_CUSTOM_IMAGE(nint image, nint faceCfg, System.Int32 type); 
*/
            /// <summary>
            ///   System.Void SetMoney(System.Int32 newMoney)
            /// </summary>
            /// <param name = "newMoney">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMoney", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_MONEY(System.Int32 newMoney); 
*/
            /// <summary>
            ///   System.String SetRandomName(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint SET_RANDOM_NAME(System.Int32 type); 
*/
            /// <summary>
            ///   System.String SpeciesToString(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpeciesToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint SPECIES_TO_STRING(System.Int32 id); 
*/
            /// <summary>
            ///   System.Void UpdateAction(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAction", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_ACTION(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateAdvance(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAdvance", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_ADVANCE(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateArmor(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateArmor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_ARMOR(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateArmorSave(System.Single value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateArmorSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_ARMOR_SAVE(System.Single value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateBattlePath(System.Int32 npcId, System.String battlePath)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "battlePath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateBattlePath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void UPDATE_BATTLE_PATH(System.Int32 npcId, nint battlePath); 
*/
            /// <summary>
            ///   System.Void UpdateDraw(System.Int32 npcId, System.Int32 clothesType)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "clothesType">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateDraw", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_DRAW(System.Int32 npcId, System.Int32 clothesType); 
*/
            /// <summary>
            ///   System.Void UpdateHpLimit(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHpLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_HP_LIMIT(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateMind(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMind", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_MIND(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateMoney(System.Int64 money)
            /// </summary>
            /// <param name = "money">struct System.Int64</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMoney", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 0)]
            public partial void UPDATE_MONEY(System.Int64 money); 
*/
            /// <summary>
            ///   System.Void UpdateMoneyPer(System.String valueStr)
            /// </summary>
            /// <param name = "valueStr">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMoneyPer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_MONEY_PER(nint valueStr); 
*/
            /// <summary>
            ///   System.Void UpdateNpcDis(System.Int32 npcCfgId)
            /// </summary>
            /// <param name = "npcCfgId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcDis", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPDATE_NPC_DIS(System.Int32 npcCfgId); 
*/
            /// <summary>
            ///   System.Void UpdateNpcFlag(System.Int32 npcId, System.Int32 flag)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcFlag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_NPC_FLAG(System.Int32 npcId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Void UpdateNpcIniti(System.Int32 npcId, System.Int32 species, System.Int32 pracId, System.Int32 attribId, System.Int32 type)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "species">struct System.Int32</param>
            /// <param name = "pracId">struct System.Int32</param>
            /// <param name = "attribId">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcIniti", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial void UPDATE_NPC_INITI(System.Int32 npcId, System.Int32 species, System.Int32 pracId, System.Int32 attribId, System.Int32 type); 
*/
            /// <summary>
            ///   System.Void UpdateNpcStoLv(System.Int32 npcId, System.Int32 lvId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "lvId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcStoLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_NPC_STO_LV(System.Int32 npcId, System.Int32 lvId); 
*/
            /// <summary>
            ///   System.Void UpdatePhyAtt(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePhyAtt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_PHY_ATT(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdatePhyDef(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePhyDef", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_PHY_DEF(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateShield(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateShield", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_SHIELD(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateSorAtt(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSorAtt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_SOR_ATT(System.Int32 value, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateSorDef(System.Int32 value, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSorDef", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_SOR_DEF(System.Int32 value, System.Int32 npcStoId); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbNpcImpl
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
            /// static  TbNpcImpl get_Instance()
            /// </summary>
            /// <returns>class TbNpcImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbNpcImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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