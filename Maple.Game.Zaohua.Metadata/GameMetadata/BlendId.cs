namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// struct ["Assembly-CSharp".""."BlendId"]
    /// [ICloneable<BlendId>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BlendId>, Ptr_BlendId>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "BlendId", "BlendId")]
    public partial class BlendId
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_BlendId
        {
            /// <summary>
            /// 0x0 BlendEnum blendEnum
            /// enum ["Assembly-CSharp".""."BlendEnum"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public BlendEnum blendEnum;
            /// <summary>
            /// 0x4 System.Int32 sedId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public System.Int32 sedId;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BlendId(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BlendId(System.IntPtr ptr) => new Ptr_BlendId(ptr);
            public static implicit operator System.IntPtr(Ptr_BlendId ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BlendId ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp".""."BlendId"]
        /// </summary>
        partial struct Ptr_BlendId
        {
            /// <summary>
            /// 0x0 BlendId none
            /// struct ["Assembly-CSharp".""."BlendId"]
            /// </summary>
            /// <returns>struct BlendId</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("none", "BlendId")]
            public static partial BlendId NONE { get; set; } 
*/

            /// <summary>
            /// 0x10 BlendEnum blendEnum
            /// enum ["Assembly-CSharp".""."BlendEnum"]
            /// </summary>
            /// <returns>enum BlendEnum</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("blendEnum", "BlendEnum")]
            public partial BlendEnum BLEND_ENUM { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 sedId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sedId", "System.Int32")]
            public partial System.Int32 SED_ID { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp".""."BlendId"]
        /// </summary>
        partial struct Ptr_BlendId
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
            /// static  System.Boolean op_Equality(BlendId x, BlendId y)
            /// </summary>
            /// <param name = "x">struct BlendId</param>
            /// <param name = "y">struct BlendId</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            public static partial System.Boolean OP_EQUALITY(BlendId x, BlendId y); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(BlendId x, BlendId y)
            /// </summary>
            /// <param name = "x">struct BlendId</param>
            /// <param name = "y">struct BlendId</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            public static partial System.Boolean OP_INEQUALITY(BlendId x, BlendId y); 
*/
            /// <summary>
            ///   System.Void .ctor(BlendEnum upTargetType, System.Int32 sedId)
            /// </summary>
            /// <param name = "upTargetType">enum BlendEnum</param>
            /// <param name = "sedId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendEnum", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CTOR(BlendEnum upTargetType, System.Int32 sedId); 
*/
            /// <summary>
            ///   BlendId Clone()
            /// </summary>
            /// <returns>struct BlendId</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "BlendId", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial BlendId CLONE(); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object obj)
            /// </summary>
            /// <param name = "obj">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint obj); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
        }
    }
}