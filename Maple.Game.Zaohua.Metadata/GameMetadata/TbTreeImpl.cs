namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbTreeImpl"]
    /// [Singleton<TbTreeImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbTreeImpl>, Ptr_TbTreeImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbTreeImpl", "TbTreeImpl")]
    public partial class TbTreeImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbTreeImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbTreeImpl(System.IntPtr ptr) => new Ptr_TbTreeImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_TbTreeImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbTreeImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbTreeImpl"]
        /// </summary>
        partial struct Ptr_TbTreeImpl
        {
            /// <summary>
            /// 0x0 TbTreeImpl m_Instance
            /// class ["Assembly-CSharp".""."TbTreeImpl"]
            /// </summary>
            /// <returns>class TbTreeImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "TbTreeImpl")]
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
        /// class ["Assembly-CSharp".""."TbTreeImpl"]
        /// </summary>
        partial struct Ptr_TbTreeImpl
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
            ///   System.Void AddTreeSto(System.Int32 treeId)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTreeSto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_TREE_STO(System.Int32 treeId); 
*/
            /// <summary>
            ///   System.Int32 GetMoneyToTree(System.Int32 treeId)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMoneyToTree", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_MONEY_TO_TREE(System.Int32 treeId); 
*/
            /// <summary>
            ///   TbTreeCfg GetTbTreeCfg(System.Int32 treeId)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <returns>class TbTreeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTbTreeCfg", "TbTreeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TB_TREE_CFG(System.Int32 treeId); 
*/
            /// <summary>
            ///   TbTreeCfg GetTbTreeCfgByGroupId(System.Int32 roleId, System.Int32 groupId)
            /// </summary>
            /// <param name = "roleId">struct System.Int32</param>
            /// <param name = "groupId">struct System.Int32</param>
            /// <returns>class TbTreeCfg</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTbTreeCfgByGroupId", "TbTreeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_TB_TREE_CFG_BY_GROUP_ID(System.Int32 roleId, System.Int32 groupId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbTreeCfg> GetTbTreeCfgListByRoleId(System.Int32 roleId)
            /// </summary>
            /// <param name = "roleId">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<TbTreeCfg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTbTreeCfgListByRoleId", "System.Collections.Generic.List<TbTreeCfg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TB_TREE_CFG_LIST_BY_ROLE_ID(System.Int32 roleId); 
*/
            /// <summary>
            ///   TbTreeSto GetTreeSto(System.Int32 treeId)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <returns>class TbTreeSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTreeSto", "TbTreeSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TREE_STO(System.Int32 treeId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbTreeSto> GetUnlockTree()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTreeSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUnlockTree", "System.Collections.Generic.List<TbTreeSto>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_UNLOCK_TREE(); 
*/
            /// <summary>
            ///   System.Boolean JudHaveCanUnlockTree()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudHaveCanUnlockTree", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean JUD_HAVE_CAN_UNLOCK_TREE(); 
*/
            /// <summary>
            ///   System.Boolean JudTechTree(System.Int32 treeId, System.Int32 flag)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <param name = "flag">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudTechTree", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean JUD_TECH_TREE(System.Int32 treeId, System.Int32 flag); 
*/
            /// <summary>
            ///   System.Boolean JudTreeSto(System.Int32 treeId)
            /// </summary>
            /// <param name = "treeId">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JudTreeSto", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean JUD_TREE_STO(System.Int32 treeId); 
*/
            /// <summary>
            ///   System.Void ResetTree(System.Int32 roleId)
            /// </summary>
            /// <param name = "roleId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void RESET_TREE(System.Int32 roleId); 
*/
            /// <summary>
            ///   System.Void UpdateTechTree()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateTechTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_TECH_TREE(); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_TbTreeImpl
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
            /// static  TbTreeImpl get_Instance()
            /// </summary>
            /// <returns>class TbTreeImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "TbTreeImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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