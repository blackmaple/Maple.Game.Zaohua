namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbDantianImpl"]
    /// [Singleton<TbDantianImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbDantianImpl>, Ptr_TbDantianImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbDantianImpl", "TbDantianImpl")]
    public partial class TbDantianImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbDantianImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbDantianImpl(System.IntPtr ptr) => new Ptr_TbDantianImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbDantianImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbDantianImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbDantianImpl"]
        /// </summary>
        partial struct Ptr_TbDantianImpl
        {
            /// <summary>
            /// 0x0 TbDantianImpl m_Instance
            /// class ["Assembly-CSharp".""."TbDantianImpl"]
            /// </summary>
            /// <returns>class TbDantianImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbDantianImpl")]
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
        /// class ["Assembly-CSharp".""."TbDantianImpl"]
        /// </summary>
        partial struct Ptr_TbDantianImpl
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
            ///   TbDantianSto GetDantianSto(System.Int32 dantianId)
            /// </summary>
            /// <param name = "dantianId">struct System.Int32</param>
            /// <returns>class TbDantianSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDantianSto", "TbDantianSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_DANTIAN_STO(System.Int32 dantianId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDantianSto> GetDantianStoList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbDantianSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDantianStoList", "System.Collections.Generic.List<TbDantianSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DANTIAN_STO_LIST(); 
*/
            /// <summary>
            ///   TbDrawCfg GetDrawCfgById(System.Int32 cfgId)
            /// </summary>
            /// <param name = "cfgId">struct System.Int32</param>
            /// <returns>class TbDrawCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDrawCfgById", "TbDrawCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_DRAW_CFG_BY_ID(System.Int32 cfgId); 
*/
            /// <summary>
            ///   TbDrawStateCfg GetDrawStateCfgById(System.Int32 cfgId)
            /// </summary>
            /// <param name = "cfgId">struct System.Int32</param>
            /// <returns>class TbDrawStateCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDrawStateCfgById", "TbDrawStateCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_DRAW_STATE_CFG_BY_ID(System.Int32 cfgId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbDrawStateCfg> GetDrawStateCfgByString(System.String drawStateStr)
            /// </summary>
            /// <param name = "drawStateStr">class System.String</param>
            /// <returns>class System.Collections.Generic.List<TbDrawStateCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDrawStateCfgByString", "System.Collections.Generic.List<TbDrawStateCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_DRAW_STATE_CFG_BY_STRING(nint drawStateStr); 
*/
            /// <summary>
            ///   System.Void InitDantianSto()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitDantianSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_DANTIAN_STO(); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbDantianImpl
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
            /// static  TbDantianImpl get_Instance()
            /// </summary>
            /// <returns>class TbDantianImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbDantianImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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