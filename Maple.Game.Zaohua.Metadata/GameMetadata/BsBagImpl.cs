namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."BsBagImpl"]
    /// [Singleton<BsBagImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BsBagImpl>, Ptr_BsBagImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "BsBagImpl", "BsBagImpl")]
    public partial class BsBagImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BsBagImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BsBagImpl(System.IntPtr ptr) => new Ptr_BsBagImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_BsBagImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BsBagImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."BsBagImpl"]
        /// </summary>
        partial struct Ptr_BsBagImpl
        {
            /// <summary>
            /// 0x0 BsBagImpl m_Instance
            /// class ["Assembly-CSharp".""."BsBagImpl"]
            /// </summary>
            /// <returns>class BsBagImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "BsBagImpl")]
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

            /// <summary>
            /// 0x10 System.Int32 maxItemId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxItemId", "System.Int32")]
            public partial System.Int32 MAX_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 maxItemSeq
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxItemSeq", "System.Int32")]
            public partial System.Int32 MAX_ITEM_SEQ { get; set; } 
*/

            /// <summary>
            /// 0x18 BagSortEnum sortEnum
            /// enum ["Assembly-CSharp".""."BagSortEnum"]
            /// </summary>
            /// <returns>enum BagSortEnum</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sortEnum", "BagSortEnum")]
            public partial BagSortEnum SORT_ENUM { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."BsBagImpl"]
        /// </summary>
        partial struct Ptr_BsBagImpl
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
            ///   System.Void AddPackSto(BlendId itemId, System.Int64 number, System.Int32 npcStoId, System.Boolean isShowLog, System.Boolean isLock, System.Boolean isShop)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "number">struct System.Int64</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "isShowLog">struct System.Boolean</param>
            /// <param name = "isLock">struct System.Boolean</param>
            /// <param name = "isShop">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPackSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            public partial void ADD_PACK_STO(BlendId itemId, System.Int64 number, System.Int32 npcStoId, System.Boolean isShowLog, System.Boolean isLock, System.Boolean isShop); 
*/
            /// <summary>
            ///   TbPackSto AddPackStoOne(TbItemCfg itemCfg, System.Int32 flag, System.Int32 npcStoId, System.Boolean isBattle, System.Boolean isShowLog, System.Boolean isLock, System.Boolean isShop)
            /// </summary>
            /// <param name = "itemCfg">class TbItemCfg</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "isBattle">struct System.Boolean</param>
            /// <param name = "isShowLog">struct System.Boolean</param>
            /// <param name = "isLock">struct System.Boolean</param>
            /// <param name = "isShop">struct System.Boolean</param>
            /// <returns>class TbPackSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPackStoOne", "TbPackSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
            public partial nint ADD_PACK_STO_ONE(nint itemCfg, System.Int32 flag, System.Int32 npcStoId, System.Boolean isBattle, System.Boolean isShowLog, System.Boolean isLock, System.Boolean isShop); 
*/
            /// <summary>
            ///   System.Void ChangeEquip(BagEquipCellController _oldEquipCell, BagEquipCellController _newEquipCell, System.Int32 npcId)
            /// </summary>
            /// <param name = "_oldEquipCell">class BagEquipCellController</param>
            /// <param name = "_newEquipCell">class BagEquipCellController</param>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeEquip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BagEquipCellController", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BagEquipCellController", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void CHANGE_EQUIP(nint _oldEquipCell, nint _newEquipCell, System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Void CheckPackDisTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckPackDisTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_PACK_DIS_TIME(); 
*/
            /// <summary>
            ///   System.Void DeleteNpcEquipByNpcSto(TbNpcSto npcSto, System.Int32 itemSlot)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "itemSlot">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteNpcEquipByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void DELETE_NPC_EQUIP_BY_NPC_STO(nint npcSto, System.Int32 itemSlot); 
*/
            /// <summary>
            ///   System.Void DelPackOne(TbPackSto packSto)
            /// </summary>
            /// <param name = "packSto">class TbPackSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelPackOne", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            public partial void DEL_PACK_ONE(nint packSto); 
*/
            /// <summary>
            ///   System.Void DelPackSto(BlendId itemId, System.Int64 number, System.Int32 npcStoId, System.Boolean isShowLog)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "number">struct System.Int64</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "isShowLog">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelPackSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void DEL_PACK_STO(BlendId itemId, System.Int64 number, System.Int32 npcStoId, System.Boolean isShowLog); 
*/
            /// <summary>
            ///   System.Void DelPackStoOneBy(System.Int32 npcId, BlendId itemId)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DelPackStoOneBy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            public partial void DEL_PACK_STO_ONE_BY(System.Int32 npcId, BlendId itemId); 
*/
            /// <summary>
            ///   System.Void EquipItem(TbPackSto _oldSto, TbPackSto _NewSto, BagEquipCellController _equipCell, System.Int32 npcId)
            /// </summary>
            /// <param name = "_oldSto">class TbPackSto</param>
            /// <param name = "_NewSto">class TbPackSto</param>
            /// <param name = "_equipCell">class BagEquipCellController</param>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BagEquipCellController", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void EQUIP_ITEM(nint _oldSto, nint _NewSto, nint _equipCell, System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Int64 GetItemNumberByNpcStoId(System.Int32 npcStoId, BlendId itemId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "itemId">struct BlendId</param>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemNumberByNpcStoId", "System.Int64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            public partial System.Int64 GET_ITEM_NUMBER_BY_NPC_STO_ID(System.Int32 npcStoId, BlendId itemId); 
*/
            /// <summary>
            ///   System.Int64 GetMoney(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMoney", "System.Int64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int64 GET_MONEY(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> GetNpcStoEquips(System.Int32 npcStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNpcStoEquips", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_NPC_STO_EQUIPS(System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Int32 GetPackHaveCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackHaveCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PACK_HAVE_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetPackIdBy(System.Int32 npcStoId, System.Int32 flag)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackIdBy", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_PACK_ID_BY(System.Int32 npcStoId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> GetPackListByNpcStoId(System.Int32 npcStoId, System.Int32 flag)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackListByNpcStoId", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PACK_LIST_BY_NPC_STO_ID(System.Int32 npcStoId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> GetPackListByTypeId(System.Int32 npcStoId, System.Int32 flag, System.Int32 typeId, System.Int32 gradeId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <param name = "typeId">struct System.Int32</param>
            /// <param name = "gradeId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackListByTypeId", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint GET_PACK_LIST_BY_TYPE_ID(System.Int32 npcStoId, System.Int32 flag, System.Int32 typeId, System.Int32 gradeId); 
*/
            /// <summary>
            ///   TbPackSto GetPackSto(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>class TbPackSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackSto", "TbPackSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PACK_STO(System.Int32 packId); 
*/
            /// <summary>
            ///   TbPackSto GetPackStoByCfgId(System.Int32 cfgId)
            /// </summary>
            /// <param name = "cfgId">struct System.Int32</param>
            /// <returns>class TbPackSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackStoByCfgId", "TbPackSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_PACK_STO_BY_CFG_ID(System.Int32 cfgId); 
*/
            /// <summary>
            ///   System.Int32 GetPackStoGradeId(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackStoGradeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_PACK_STO_GRADE_ID(System.Int32 packId); 
*/
            /// <summary>
            ///   System.Int32 GetPackStoIdByItemSlot(System.Int32 npcStoId, ItemSlot itemSlot)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "itemSlot">enum ItemSlot</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackStoIdByItemSlot", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemSlot", 1)]
            public partial System.Int32 GET_PACK_STO_ID_BY_ITEM_SLOT(System.Int32 npcStoId, ItemSlot itemSlot); 
*/
            /// <summary>
            ///   System.Int32 GetPackStoMax()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackStoMax", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PACK_STO_MAX(); 
*/
            /// <summary>
            ///   System.Int32 GetPackStoTypeId(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackStoTypeId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_PACK_STO_TYPE_ID(System.Int32 packId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> GetPlayerProps(System.Int32 _id, System.Int32 _type)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_type">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerProps", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PLAYER_PROPS(System.Int32 _id, System.Int32 _type); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> GetPlayerTreas(System.Int32 npcStoId, System.Int32 type)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerTreas", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_PLAYER_TREAS(System.Int32 npcStoId, System.Int32 type); 
*/
            /// <summary>
            ///   System.Void InitPackStosToNpc(TbNpcSto _npcSto, TbNpcCfg _cfg)
            /// </summary>
            /// <param name = "_npcSto">class TbNpcSto</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitPackStosToNpc", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            public partial void INIT_PACK_STOS_TO_NPC(nint _npcSto, nint _cfg); 
*/
            /// <summary>
            ///   System.Void InitPackStosToPlayer(TbNpcSto _npcSto, TbNpcCfg _cfg, System.Collections.Generic.List<TbCreateCfg> equippedCreateCfgList)
            /// </summary>
            /// <param name = "_npcSto">class TbNpcSto</param>
            /// <param name = "_cfg">class TbNpcCfg</param>
            /// <param name = "equippedCreateCfgList">class System.Collections.Generic.List<TbCreateCfg></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitPackStosToPlayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcCfg", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbCreateCfg>", 2)]
            public partial void INIT_PACK_STOS_TO_PLAYER(nint _npcSto, nint _cfg, nint equippedCreateCfgList); 
*/
            /// <summary>
            ///   System.Boolean IsCanEquipType(System.Int32 packId)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCanEquipType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean IS_CAN_EQUIP_TYPE(System.Int32 packId); 
*/
            /// <summary>
            ///   System.Boolean IsCanGetItem(System.Int32 num)
            /// </summary>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCanGetItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean IS_CAN_GET_ITEM(System.Int32 num); 
*/
            /// <summary>
            ///   System.Boolean IsPackStoBy(System.Int32 npcStoId, System.Int32 flag)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPackStoBy", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean IS_PACK_STO_BY(System.Int32 npcStoId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudPackEquip(BlendId itemId, System.Int32 flag, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPackEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean JUD_PACK_EQUIP(BlendId itemId, System.Int32 flag, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Boolean JudPackItem(System.Int32 npcId, BlendId itemId, System.String term, System.Int32 number)
            /// </summary>
            /// <param name = "npcId">struct System.Int32</param>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "term">class System.String</param>
            /// <param name = "number">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudPackItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial System.Boolean JUD_PACK_ITEM(System.Int32 npcId, BlendId itemId, nint term, System.Int32 number); 
*/
            /// <summary>
            ///   System.String OtherEffToStr(TbItemCfg itemCfg, System.Boolean isEquip, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "itemCfg">class TbItemCfg</param>
            /// <param name = "isEquip">struct System.Boolean</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OtherEffToStr", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbItemCfg", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint OTHER_EFF_TO_STR(nint itemCfg, System.Boolean isEquip, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void RefreshMaxId()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshMaxId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_MAX_ID(); 
*/
            /// <summary>
            ///   System.Void RefreshPackStoSeq(System.Int32 type, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshPackStoSeq", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REFRESH_PACK_STO_SEQ(System.Int32 type, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void SetBagImage(UnityEngine.UI.Image image, TbPackSto packSto)
            /// </summary>
            /// <param name = "image">class UnityEngine.UI.Image</param>
            /// <param name = "packSto">class TbPackSto</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBagImage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Image", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 1)]
            public partial void SET_BAG_IMAGE(nint image, nint packSto); 
*/
            /// <summary>
            ///   System.Void SetBagImage(UnityEngine.UI.Image image, System.String iconPath)
            /// </summary>
            /// <param name = "image">class UnityEngine.UI.Image</param>
            /// <param name = "iconPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBagImage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Image", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void SET_BAG_IMAGE(nint image, nint iconPath); 
*/
            /// <summary>
            ///   System.Void SetPackStoIdByItemSlot(System.Int32 npcStoId, ItemSlot itemSlot, System.Int32 packStoId)
            /// </summary>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <param name = "itemSlot">enum ItemSlot</param>
            /// <param name = "packStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPackStoIdByItemSlot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemSlot", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void SET_PACK_STO_ID_BY_ITEM_SLOT(System.Int32 npcStoId, ItemSlot itemSlot, System.Int32 packStoId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbPackSto> SortItemS(System.Int32 parentId, System.Int32 sortType, System.Boolean isUp, System.Int32 npcId)
            /// </summary>
            /// <param name = "parentId">struct System.Int32</param>
            /// <param name = "sortType">struct System.Int32</param>
            /// <param name = "isUp">struct System.Boolean</param>
            /// <param name = "npcId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbPackSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortItemS", "System.Collections.Generic.List<TbPackSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint SORT_ITEM_S(System.Int32 parentId, System.Int32 sortType, System.Boolean isUp, System.Int32 npcId); 
*/
            /// <summary>
            ///   System.Void UnsnatchEquip(TbPackSto _itemSto, System.Int32 flag, System.Int32 npcStoId)
            /// </summary>
            /// <param name = "_itemSto">class TbPackSto</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <param name = "npcStoId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnsnatchEquip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbPackSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void UNSNATCH_EQUIP(nint _itemSto, System.Int32 flag, System.Int32 npcStoId); 
*/
            /// <summary>
            ///   System.Void UpdateMoney(System.Int64 money, System.Boolean isShowLog)
            /// </summary>
            /// <param name = "money">struct System.Int64</param>
            /// <param name = "isShowLog">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateMoney", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void UPDATE_MONEY(System.Int64 money, System.Boolean isShowLog); 
*/
            /// <summary>
            ///   System.Void UpdateNpcEquip(System.Int32 npcCfgId, BlendId itemId, System.Int32 itemSlot)
            /// </summary>
            /// <param name = "npcCfgId">struct System.Int32</param>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "itemSlot">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcEquip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void UPDATE_NPC_EQUIP(System.Int32 npcCfgId, BlendId itemId, System.Int32 itemSlot); 
*/
            /// <summary>
            ///   System.Void UpdateNpcEquipByNpcSto(TbNpcSto npcSto, BlendId itemId, System.Int32 itemSlot)
            /// </summary>
            /// <param name = "npcSto">class TbNpcSto</param>
            /// <param name = "itemId">struct BlendId</param>
            /// <param name = "itemSlot">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNpcEquipByNpcSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbNpcSto", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void UPDATE_NPC_EQUIP_BY_NPC_STO(nint npcSto, BlendId itemId, System.Int32 itemSlot); 
*/
            /// <summary>
            ///   System.Void UpdatePackByExchange(BlendId itemId1, System.Int64 number1, BlendId itemId2, System.Int64 number2, System.Int64 money)
            /// </summary>
            /// <param name = "itemId1">struct BlendId</param>
            /// <param name = "number1">struct System.Int64</param>
            /// <param name = "itemId2">struct BlendId</param>
            /// <param name = "number2">struct System.Int64</param>
            /// <param name = "money">struct System.Int64</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePackByExchange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BlendId", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 4)]
            public partial void UPDATE_PACK_BY_EXCHANGE(BlendId itemId1, System.Int64 number1, BlendId itemId2, System.Int64 number2, System.Int64 money); 
*/
            /// <summary>
            ///   System.Void UpdatePackFlag(System.Int32 packId, System.Int32 newFlag)
            /// </summary>
            /// <param name = "packId">struct System.Int32</param>
            /// <param name = "newFlag">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdatePackFlag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_PACK_FLAG(System.Int32 packId, System.Int32 newFlag); 
*/
            /// <summary>
            ///   System.Void UpdateSectPost(System.Int32 npcCfgId, System.Int32 sectId, System.Int32 postId)
            /// </summary>
            /// <param name = "npcCfgId">struct System.Int32</param>
            /// <param name = "sectId">struct System.Int32</param>
            /// <param name = "postId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSectPost", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void UPDATE_SECT_POST(System.Int32 npcCfgId, System.Int32 sectId, System.Int32 postId); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_BsBagImpl
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
            /// static  BsBagImpl get_Instance()
            /// </summary>
            /// <returns>class BsBagImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "BsBagImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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