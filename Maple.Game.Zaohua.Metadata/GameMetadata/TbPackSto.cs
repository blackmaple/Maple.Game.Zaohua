namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbPackSto"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbPackSto>, Ptr_TbPackSto>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbPackSto", "TbPackSto")]
    public partial class TbPackSto
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbPackSto(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbPackSto(System.IntPtr ptr) => new Ptr_TbPackSto(ptr);
            public static implicit operator System.IntPtr(Ptr_TbPackSto ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbPackSto ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPackSto"]
        /// </summary>
        partial struct Ptr_TbPackSto
        {
            /// <summary>
            /// 0x10 System.String getGameTime
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("getGameTime", "System.String")]
            public partial nint GET_GAME_TIME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x1C BlendId itemId
            /// struct ["Assembly-CSharp".""."BlendId"]
            /// </summary>
            /// <returns>struct BlendId</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemId", "BlendId")]
            public partial BlendId ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 npcStoId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcStoId", "System.Int32")]
            public partial System.Int32 NPC_STO_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 shoopId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoopId", "System.Int32")]
            public partial System.Int32 SHOOP_ID { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 flag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("flag", "System.Int32")]
            public partial System.Int32 FLAG { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 seq
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("seq", "System.Int32")]
            public partial System.Int32 SEQ { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int64 getTime
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("getTime", "System.Int64")]
            public partial System.Int64 GET_TIME { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean isNew
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isNew", "System.Boolean")]
            public partial System.Boolean IS_NEW { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 useCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useCount", "System.Int32")]
            public partial System.Int32 USE_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int64 haveCount
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveCount", "System.Int64")]
            public partial System.Int64 HAVE_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int64 shopCount
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shopCount", "System.Int64")]
            public partial System.Int64 SHOP_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Boolean isLock
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isLock", "System.Boolean")]
            public partial System.Boolean IS_LOCK { get; set; } 
*/

            /// <summary>
            /// 0x59 System.Boolean isWaitSale
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isWaitSale", "System.Boolean")]
            public partial System.Boolean IS_WAIT_SALE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbPackSto"]
        /// </summary>
        partial struct Ptr_TbPackSto
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
            ///   System.Int32 get_attribute()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_attribute", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ATTRIBUTE(); 
*/
            /// <summary>
            ///   System.Int32 get_disTime()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_disTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_DIS_TIME(); 
*/
            /// <summary>
            ///   System.Int32 get_energy()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_energy", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ENERGY(); 
*/
            /// <summary>
            ///   System.String get_equipEff()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_equipEff", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EQUIP_EFF(); 
*/
            /// <summary>
            ///   System.Int32 get_gradeId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_gradeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_GRADE_ID(); 
*/
            /// <summary>
            ///   System.String get_iconPath()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_iconPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ICON_PATH(); 
*/
            /// <summary>
            ///   TbItemCfg get_itemCfg()
            /// </summary>
            /// <returns>class TbItemCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_itemCfg", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_CFG(); 
*/
            /// <summary>
            ///   System.Int32 get_lingqi()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_lingqi", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LINGQI(); 
*/
            /// <summary>
            ///   System.Int32 get_maxCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_maxCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_COUNT(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.Int32 get_price()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_price", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PRICE(); 
*/
            /// <summary>
            ///   System.Int32 get_suitId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_suitId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SUIT_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_typeId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_typeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TYPE_ID(); 
*/
        }
    }
}