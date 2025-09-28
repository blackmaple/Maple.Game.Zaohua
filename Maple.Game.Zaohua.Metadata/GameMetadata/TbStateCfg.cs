using Maple.MonoGameAssistant.Core;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbStateCfg"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbStateCfg>, Ptr_TbStateCfg>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbStateCfg", "TbStateCfg")]
    public partial class TbStateCfg
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbStateCfg(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbStateCfg(System.IntPtr ptr) => new Ptr_TbStateCfg(ptr);
            public static implicit operator System.IntPtr(Ptr_TbStateCfg ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbStateCfg ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbStateCfg"]
        /// </summary>
        partial struct Ptr_TbStateCfg
        {
            /// <summary>
            /// 0x10 System.String attribute2
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attribute2", "System.String")]
            public partial nint ATTRIBUTE2 { get; set; } 
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
            /// 0x20 System.String introduce
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("introduce", "System.String")]
            public partial nint INTRODUCE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String effTime
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effTime", "System.String")]
            public partial nint EFF_TIME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String effTime1
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effTime1", "System.String")]
            public partial nint EFF_TIME1 { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String effTime2
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effTime2", "System.String")]
            public partial nint EFF_TIME2 { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String effTime3
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effTime3", "System.String")]
            public partial nint EFF_TIME3 { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String changeTime
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeTime", "System.String")]
            public partial nint CHANGE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String eff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eff", "System.String")]
            public partial nint EFF { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String effectiveTLNode
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectiveTLNode", "System.String")]
            public partial nint EFFECTIVE_TL_NODE { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String disEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("disEff", "System.String")]
            public partial nint DIS_EFF { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String path
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("path", "System.String")]
            public partial nint PATH { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<TbStateCfg.StateEffect> stateEffects
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStateCfg.StateEffect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("stateEffects", "System.Collections.Generic.List<TbStateCfg.StateEffect>")]
            public partial nint STATE_EFFECTS { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 


            /// <summary>
            /// 0x7C System.Int32 flag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("flag", "System.Int32")]
            public partial System.Int32 FLAG { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 group
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("group", "System.Int32")]
            public partial System.Int32 GROUP { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 groupOrder
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("groupOrder", "System.Int32")]
            public partial System.Int32 GROUP_ORDER { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 order
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("order", "System.Int32")]
            public partial System.Int32 ORDER { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Int32 actId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("actId", "System.Int32")]
            public partial System.Int32 ACT_ID { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 maxLayer
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxLayer", "System.Int32")]
            public partial System.Int32 MAX_LAYER { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbStateCfg"]
        /// </summary>
        partial struct Ptr_TbStateCfg
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
            ///   System.Collections.Generic.List<StateEffType> get_EffType()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<StateEffType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EffType", "System.Collections.Generic.List<StateEffType>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EFF_TYPE(); 
*/
            /// <summary>
            ///   System.String get_GetIntroduce()
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetIntroduce", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_INTRODUCE(); 

            /// <summary>
            ///   System.String get_GetName()
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_NAME(); 

            /// <summary>
            ///   System.String get_GetTipEpl()
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetTipEpl", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_TIP_EPL(); 

            /// <summary>
            ///   System.Collections.Generic.List<TbStateCfg.StateEffect> get_StateEffects()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStateCfg.StateEffect></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StateEffects", "System.Collections.Generic.List<TbStateCfg.StateEffect>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STATE_EFFECTS(); 
*/
        }
    }
}