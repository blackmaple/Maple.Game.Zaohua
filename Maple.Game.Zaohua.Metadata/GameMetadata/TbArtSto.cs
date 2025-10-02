namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbArtSto"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbArtSto>, Ptr_TbArtSto>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbArtSto", "TbArtSto")]
    public partial class TbArtSto
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbArtSto(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbArtSto(System.IntPtr ptr) => new Ptr_TbArtSto(ptr);
            public static implicit operator System.IntPtr(Ptr_TbArtSto ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbArtSto ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbArtSto"]
        /// </summary>
        partial struct Ptr_TbArtSto
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 


            /// <summary>
            /// 0x14 System.Int32 npcStoId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcStoId", "System.Int32")]
            public partial System.Int32 NPC_STO_ID { get; set; } 


            /// <summary>
            /// 0x18 BlendId artId
            /// struct ["Assembly-CSharp".""."BlendId"]
            /// </summary>
            /// <returns>struct BlendId</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("artId", "BlendId")]
            public partial BlendId.Ref_BlendId ART_ID { get; set; } 


            /// <summary>
            /// 0x20 System.Int32 flag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("flag", "System.Int32")]
            public partial System.Int32 FLAG { get; set; } 


            /// <summary>
            /// 0x28 System.Int64 getTime
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("getTime", "System.Int64")]
            public partial System.Int64 GET_TIME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Boolean isNew
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isNew", "System.Boolean")]
            public partial System.Boolean IS_NEW { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 dantianStoId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dantianStoId", "System.Int32")]
            public partial System.Int32 DANTIAN_STO_ID { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 rotate
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rotate", "System.Int32")]
            public partial System.Int32 ROTATE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbArtSto"]
        /// </summary>
        partial struct Ptr_TbArtSto
        {
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