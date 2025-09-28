using Maple.MonoGameAssistant.Core;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbSectCfg"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbSectCfg>, Ptr_TbSectCfg>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbSectCfg", "TbSectCfg")]
    public partial class TbSectCfg
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbSectCfg(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbSectCfg(System.IntPtr ptr) => new Ptr_TbSectCfg(ptr);
            public static implicit operator System.IntPtr(Ptr_TbSectCfg ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbSectCfg ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbSectCfg"]
        /// </summary>
        partial struct Ptr_TbSectCfg
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String introduce
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("introduce", "System.String")]
            public partial nint INTRODUCE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String eff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eff", "System.String")]
            public partial nint EFF { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbSectCfg"]
        /// </summary>
        partial struct Ptr_TbSectCfg
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

        }
    }
}