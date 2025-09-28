using Maple.MonoGameAssistant.Core;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbSuitCfg"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbSuitCfg>, Ptr_TbSuitCfg>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbSuitCfg", "TbSuitCfg")]
    public partial class TbSuitCfg
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbSuitCfg(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbSuitCfg(System.IntPtr ptr) => new Ptr_TbSuitCfg(ptr);
            public static implicit operator System.IntPtr(Ptr_TbSuitCfg ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbSuitCfg ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbSuitCfg"]
        /// </summary>
        partial struct Ptr_TbSuitCfg
        {
            /// <summary>
            /// 0x10 System.String itemid
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemid", "System.String")]
            public partial nint ITEMID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Lazy<System.Collections.Generic.List<System.Int32>> _lazyItemList
            /// class ["mscorlib"."System"."Lazy`1"]
            /// </summary>
            /// <returns>class System.Lazy<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lazyItemList", "System.Lazy<System.Collections.Generic.List<System.Int32>>")]
            public partial nint _LAZY_ITEM_LIST { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String effDes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effDes", "System.String")]
            public partial nint EFF_DES { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String equipEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipEff", "System.String")]
            public partial nint EQUIP_EFF { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 


            /// <summary>
            /// 0x3C System.Int32 layerId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("layerId", "System.Int32")]
            public partial System.Int32 LAYER_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbSuitCfg"]
        /// </summary>
        partial struct Ptr_TbSuitCfg
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
            ///   System.Collections.Generic.List<System.Int32> < . ctor>b__0_0()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<.ctor>b__0_0", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CTORB__0_0(); 
*/
            /// <summary>
            ///   System.String get_GetEffDes()
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetEffDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_EFF_DES(); 

            /// <summary>
            ///   System.String get_GetName()
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_NAME(); 

            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> get_ItemList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemList", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_LIST(); 
*/
        }
    }
}