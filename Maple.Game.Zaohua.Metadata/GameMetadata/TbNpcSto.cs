namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbNpcSto"]
    /// [System.Object]
    /// [ICloneable<TbNpcSto>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbNpcSto>, Ptr_TbNpcSto>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbNpcSto", "TbNpcSto")]
    public partial class TbNpcSto
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbNpcSto(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbNpcSto(System.IntPtr ptr) => new Ptr_TbNpcSto(ptr);
            public static implicit operator System.IntPtr(Ptr_TbNpcSto ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TbNpcSto ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbNpcSto"]
        /// </summary>
        partial struct Ptr_TbNpcSto
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
            /// 0x20 System.String path
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("path", "System.String")]
            public partial nint PATH { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String battlePath
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battlePath", "System.String")]
            public partial nint BATTLE_PATH { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String artId
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("artId", "System.String")]
            public partial nint ART_ID { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String magicList
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magicList", "System.String")]
            public partial nint MAGIC_LIST { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<TbTradeSto> tradeList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbTradeSto></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tradeList", "System.Collections.Generic.List<TbTradeSto>")]
            public partial nint TRADE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String tradeUpdateTime
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tradeUpdateTime", "System.String")]
            public partial nint TRADE_UPDATE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 npcId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcId", "System.Int32")]
            public partial System.Int32 NPC_ID { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 pracId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pracId", "System.Int32")]
            public partial System.Int32 PRAC_ID { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 playerType
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerType", "System.Int32")]
            public partial System.Int32 PLAYER_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single armorSave
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("armorSave", "System.Single")]
            public partial System.Single ARMOR_SAVE { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 flag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("flag", "System.Int32")]
            public partial System.Int32 FLAG { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int64 money
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("money", "System.Int64")]
            public partial System.Int64 MONEY { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 species
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("species", "System.Int32")]
            public partial System.Int32 SPECIES { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 attribId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attribId", "System.Int32")]
            public partial System.Int32 ATTRIB_ID { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 clothesType
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("clothesType", "System.Int32")]
            public partial System.Int32 CLOTHES_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 sex
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sex", "System.Int32")]
            public partial System.Int32 SEX { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 lvId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lvId", "System.Int32")]
            public partial System.Int32 LV_ID { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 helmet
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("helmet", "System.Int32")]
            public partial System.Int32 HELMET { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Int32 clothes
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("clothes", "System.Int32")]
            public partial System.Int32 CLOTHES { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 shoe
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoe", "System.Int32")]
            public partial System.Int32 SHOE { get; set; } 
*/

            /// <summary>
            /// 0x94 System.Int32 ornaments1
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ornaments1", "System.Int32")]
            public partial System.Int32 ORNAMENTS1 { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Int32 ornaments2
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ornaments2", "System.Int32")]
            public partial System.Int32 ORNAMENTS2 { get; set; } 
*/

            /// <summary>
            /// 0x9C System.Int32 ornaments3
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ornaments3", "System.Int32")]
            public partial System.Int32 ORNAMENTS3 { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 treas1
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas1", "System.Int32")]
            public partial System.Int32 TREAS1 { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 treas2
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas2", "System.Int32")]
            public partial System.Int32 TREAS2 { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 treas3
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas3", "System.Int32")]
            public partial System.Int32 TREAS3 { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Int32 treas4
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas4", "System.Int32")]
            public partial System.Int32 TREAS4 { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 treas5
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas5", "System.Int32")]
            public partial System.Int32 TREAS5 { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 treas6
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treas6", "System.Int32")]
            public partial System.Int32 TREAS6 { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 prop1
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop1", "System.Int32")]
            public partial System.Int32 PROP1 { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Int32 prop2
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop2", "System.Int32")]
            public partial System.Int32 PROP2 { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32 prop3
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop3", "System.Int32")]
            public partial System.Int32 PROP3 { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 prop4
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop4", "System.Int32")]
            public partial System.Int32 PROP4 { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Int32 prop5
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop5", "System.Int32")]
            public partial System.Int32 PROP5 { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Int32 prop6
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prop6", "System.Int32")]
            public partial System.Int32 PROP6 { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Int32 capacity
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("capacity", "System.Int32")]
            public partial System.Int32 CAPACITY { get; set; } 
*/

            /// <summary>
            /// 0xD4 System.Int32 hp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Int32")]
            public partial System.Int32 HP { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Int32 mp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mp", "System.Int32")]
            public partial System.Int32 MP { get; set; } 
*/

            /// <summary>
            /// 0xDC System.Int32 action
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("action", "System.Int32")]
            public partial System.Int32 ACTION { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Int32 sorAtt
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sorAtt", "System.Int32")]
            public partial System.Int32 SOR_ATT { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Int32 sorDef
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sorDef", "System.Int32")]
            public partial System.Int32 SOR_DEF { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 phyAtt
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyAtt", "System.Int32")]
            public partial System.Int32 PHY_ATT { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Int32 phyDef
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyDef", "System.Int32")]
            public partial System.Int32 PHY_DEF { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Int32 armor
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("armor", "System.Int32")]
            public partial System.Int32 ARMOR { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Int32 advance
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advance", "System.Int32")]
            public partial System.Int32 ADVANCE { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Single fly
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fly", "System.Single")]
            public partial System.Single FLY { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Int32 wide
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("wide", "System.Int32")]
            public partial System.Int32 WIDE { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 high
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("high", "System.Int32")]
            public partial System.Int32 HIGH { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Int32 sectId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sectId", "System.Int32")]
            public partial System.Int32 SECT_ID { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 postId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("postId", "System.Int32")]
            public partial System.Int32 POST_ID { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 mind
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mind", "System.Int32")]
            public partial System.Int32 MIND { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Int32 shield
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shield", "System.Int32")]
            public partial System.Int32 SHIELD { get; set; } 
*/

            /// <summary>
            /// 0x114 System.Int32 ployId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ployId", "System.Int32")]
            public partial System.Int32 PLOY_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbNpcSto"]
        /// </summary>
        partial struct Ptr_TbNpcSto
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
            ///   TbNpcSto Clone()
            /// </summary>
            /// <returns>class TbNpcSto</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "TbNpcSto", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CLONE(); 
*/
            /// <summary>
            ///   System.String GetBattlePath(System.Boolean isCheckFly)
            /// </summary>
            /// <param name = "isCheckFly">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattlePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_BATTLE_PATH(System.Boolean isCheckFly); 
*/
            /// <summary>
            ///   System.Single GetFly(System.Boolean loadFlyModel)
            /// </summary>
            /// <param name = "loadFlyModel">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFly", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Single GET_FLY(System.Boolean loadFlyModel); 
*/
        }
    }
}