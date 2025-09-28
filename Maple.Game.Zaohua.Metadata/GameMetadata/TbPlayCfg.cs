namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbPlayCfg"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbPlayCfg>, Ptr_TbPlayCfg>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbPlayCfg", "TbPlayCfg")]
    public partial class TbPlayCfg
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbPlayCfg(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbPlayCfg(System.IntPtr ptr) => new Ptr_TbPlayCfg(ptr);
            public static implicit operator System.IntPtr(Ptr_TbPlayCfg ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbPlayCfg ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayCfg"]
        /// </summary>
        partial struct Ptr_TbPlayCfg
        {
            /// <summary>
            /// 0x10 System.String uuid
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("uuid", "System.String")]
            public partial nint UUID { get; set; } 
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
            /// 0x20 System.String modId
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("modId", "System.String")]
            public partial nint MOD_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 PlayEditor.ComplexEffect effCfg
            /// class ["Assembly-CSharp"."PlayEditor"."ComplexEffect"]
            /// </summary>
            /// <returns>class PlayEditor.ComplexEffect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effCfg", "PlayEditor.ComplexEffect")]
            public partial nint EFF_CFG { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String des
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("des", "System.String")]
            public partial nint DES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 chapterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chapterId", "System.Int32")]
            public partial System.Int32 CHAPTER_ID { get; set; } 
*/

            /// <summary>
            /// 0x3C PlayType playEnum
            /// enum ["Assembly-CSharp".""."PlayType"]
            /// </summary>
            /// <returns>enum PlayType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playEnum", "PlayType")]
            public partial PlayType PLAY_ENUM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 priority
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("priority", "System.Int32")]
            public partial System.Int32 PRIORITY { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 roleId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("roleId", "System.Int32")]
            public partial System.Int32 ROLE_ID { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 npcId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcId", "System.Int32")]
            public partial System.Int32 NPC_ID { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 terrainId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("terrainId", "System.Int32")]
            public partial System.Int32 TERRAIN_ID { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 buildId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buildId", "System.Int32")]
            public partial System.Int32 BUILD_ID { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 nameId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nameId", "System.Int32")]
            public partial System.Int32 NAME_ID { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 functionId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("functionId", "System.Int32")]
            public partial System.Int32 FUNCTION_ID { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 eventId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eventId", "System.Int32")]
            public partial System.Int32 EVENT_ID { get; set; } 
*/

            /// <summary>
            /// 0x60 MyVector2Int genPos
            /// struct ["Assembly-CSharp".""."MyVector2Int"]
            /// </summary>
            /// <returns>struct MyVector2Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("genPos", "MyVector2Int")]
            public partial MyVector2Int GEN_POS { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 isRepeatable
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isRepeatable", "System.Int32")]
            public partial System.Int32 IS_REPEATABLE { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 isNoWenhao
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isNoWenhao", "System.Int32")]
            public partial System.Int32 IS_NO_WENHAO { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 contTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("contTime", "System.Int32")]
            public partial System.Int32 CONT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Boolean isScan
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isScan", "System.Boolean")]
            public partial System.Boolean IS_SCAN { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 triggerType
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("triggerType", "System.Int32")]
            public partial System.Int32 TRIGGER_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 branchType
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("branchType", "System.Int32")]
            public partial System.Int32 BRANCH_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 isChangeChapter
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isChangeChapter", "System.Int32")]
            public partial System.Int32 IS_CHANGE_CHAPTER { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Boolean isAffectsMainPlot
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isAffectsMainPlot", "System.Boolean")]
            public partial System.Boolean IS_AFFECTS_MAIN_PLOT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int64 lastChangeTime
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastChangeTime", "System.Int64")]
            public partial System.Int64 LAST_CHANGE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Boolean haveChooses
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveChooses", "System.Boolean")]
            public partial System.Boolean HAVE_CHOOSES { get; set; } 
*/

            /// <summary>
            /// 0x91 System.Boolean haveEffects
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveEffects", "System.Boolean")]
            public partial System.Boolean HAVE_EFFECTS { get; set; } 
*/

            /// <summary>
            /// 0x92 System.Boolean haveMusic
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveMusic", "System.Boolean")]
            public partial System.Boolean HAVE_MUSIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPlayCfg"]
        /// </summary>
        partial struct Ptr_TbPlayCfg
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
            ///   TbPlayCfg Copy()
            /// </summary>
            /// <returns>class TbPlayCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Copy", "TbPlayCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint COPY(); 
*/
        }
    }
}