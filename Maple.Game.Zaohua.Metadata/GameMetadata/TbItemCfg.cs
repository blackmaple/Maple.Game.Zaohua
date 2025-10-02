using Maple.MonoGameAssistant.Core;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."TbItemCfg"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TbItemCfg>, Ptr_TbItemCfg>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "TbItemCfg", "TbItemCfg")]
    public partial class TbItemCfg
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TbItemCfg(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TbItemCfg(System.IntPtr ptr) => new Ptr_TbItemCfg(ptr);
            public static implicit operator System.IntPtr(Ptr_TbItemCfg ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_TbItemCfg ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbItemCfg"]
        /// </summary>
        partial struct Ptr_TbItemCfg
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
            /// 0x18 System.String iconPath
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("iconPath", "System.String")]
            public partial PMonoString ICON_PATH { get; set; }


            /// <summary>
            /// 0x20 System.String des
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("des", "System.String")]
           public partial nint DES { get; set; } 
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
            /// 0x30 System.String attEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attEff", "System.String")]
           public partial nint ATT_EFF { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String armorEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("armorEff", "System.String")]
           public partial nint ARMOR_EFF { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String hpEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hpEff", "System.String")]
           public partial nint HP_EFF { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String energyEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("energyEff", "System.String")]
           public partial nint ENERGY_EFF { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String attribEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attribEff", "System.String")]
           public partial nint ATTRIB_EFF { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String limitEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("limitEff", "System.String")]
           public partial nint LIMIT_EFF { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String stateEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("stateEff", "System.String")]
           public partial nint STATE_EFF { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String useEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useEff", "System.String")]
           public partial nint USE_EFF { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String equipEff
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipEff", "System.String")]
           public partial nint EQUIP_EFF { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String npcList
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcList", "System.String")]
           public partial nint NPC_LIST { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String actId
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("actId", "System.String")]
           public partial nint ACT_ID { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String effectType
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectType", "System.String")]
           public partial nint EFFECT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String equipNotes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipNotes", "System.String")]
           public partial nint EQUIP_NOTES { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String limitNotes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("limitNotes", "System.String")]
           public partial nint LIMIT_NOTES { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String useNotes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useNotes", "System.String")]
           public partial nint USE_NOTES { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String selfNotes
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selfNotes", "System.String")]
           public partial nint SELF_NOTES { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String tlNodeId
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tlNodeId", "System.String")]
           public partial nint TL_NODE_ID { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<EffTypeEnum> skillTypeList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EffTypeEnum></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillTypeList", "System.Collections.Generic.List<EffTypeEnum>")]
           public partial nint SKILL_TYPE_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC0 TbTypeCfg edTypeCfg
            /// class ["Assembly-CSharp".""."TbTypeCfg"]
            /// </summary>
            /// <returns>class TbTypeCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("edTypeCfg", "TbTypeCfg")]
           public partial nint ED_TYPE_CFG { get; set; } 
*/

            /// <summary>
            /// 0xC8 TbArtCfg edArtCfg
            /// class ["Assembly-CSharp".""."TbArtCfg"]
            /// </summary>
            /// <returns>class TbArtCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("edArtCfg", "TbArtCfg")]
           public partial nint ED_ART_CFG { get; set; } 
*/

            /// <summary>
            /// 0xD0 TbMagicCfg edMagicCfg
            /// class ["Assembly-CSharp".""."TbMagicCfg"]
            /// </summary>
            /// <returns>class TbMagicCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("edMagicCfg", "TbMagicCfg")]
           public partial nint ED_MAGIC_CFG { get; set; } 
*/

            /// <summary>
            /// 0xD8 TbGradeCfg edGradeCfg
            /// class ["Assembly-CSharp".""."TbGradeCfg"]
            /// </summary>
            /// <returns>class TbGradeCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("edGradeCfg", "TbGradeCfg")]
           public partial nint ED_GRADE_CFG { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; }


            /// <summary>
            /// 0xE4 System.Int32 npcUse
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("npcUse", "System.Int32")]
           public partial System.Int32 NPC_USE { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 typeId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("typeId", "System.Int32")]
            public partial System.Int32 TYPE_ID { get; set; }


            /// <summary>
            /// 0xEC System.Int32 gradeId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gradeId", "System.Int32")]
            public partial System.Int32 GRADE_ID { get; set; }


            /// <summary>
            /// 0xF0 System.Int32 attribute
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attribute", "System.Int32")]
           public partial System.Int32 ATTRIBUTE { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Int32 energy
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("energy", "System.Int32")]
           public partial System.Int32 ENERGY { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Int32 maxCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxCount", "System.Int32")]
           public partial System.Int32 MAX_COUNT { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Int32 price
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("price", "System.Int32")]
           public partial System.Int32 PRICE { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 augment
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("augment", "System.Int32")]
           public partial System.Int32 AUGMENT { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Int32 efficacy
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("efficacy", "System.Int32")]
           public partial System.Int32 EFFICACY { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 consume
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("consume", "System.Int32")]
           public partial System.Int32 CONSUME { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 lingqi
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lingqi", "System.Int32")]
           public partial System.Int32 LINGQI { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Int32 noRemove
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("noRemove", "System.Int32")]
           public partial System.Int32 NO_REMOVE { get; set; } 
*/

            /// <summary>
            /// 0x114 System.Int32 drugMax
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("drugMax", "System.Int32")]
           public partial System.Int32 DRUG_MAX { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Int32 disTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("disTime", "System.Int32")]
           public partial System.Int32 DIS_TIME { get; set; } 
*/

            /// <summary>
            /// 0x11C System.Int32 IsShop
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsShop", "System.Int32")]
           public partial System.Int32 IS_SHOP { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Int32 IsTrader
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsTrader", "System.Int32")]
           public partial System.Int32 IS_TRADER { get; set; } 
*/

            /// <summary>
            /// 0x124 System.Int32 IsBlack
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsBlack", "System.Int32")]
            public partial System.Int32 IS_BLACK { get; set; }


            /// <summary>
            /// 0x128 System.Int32 IsReward
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsReward", "System.Int32")]
           public partial System.Int32 IS_REWARD { get; set; } 
*/

            /// <summary>
            /// 0x12C System.Int32 suitId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("suitId", "System.Int32")]
           public partial System.Int32 SUIT_ID { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Int32 useFlag
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useFlag", "System.Int32")]
           public partial System.Int32 USE_FLAG { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Int64 haveCount
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveCount", "System.Int64")]
           public partial System.Int64 HAVE_COUNT { get; set; } 


            /// <summary>
            /// 0x140 System.Int32 block
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("block", "System.Int32")]
            public partial System.Int32 BLOCK { get; set; }


            /// <summary>
            /// 0x144 BlendEnum blendEnum
            /// enum ["Assembly-CSharp".""."BlendEnum"]
            /// </summary>
            /// <returns>enum BlendEnum</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("blendEnum", "BlendEnum")]
            public partial BlendEnum BLEND_ENUM { get; set; }


            /// <summary>
            /// 0x148 EquipBitTag bitTag
            /// enum ["Assembly-CSharp".""."EquipBitTag"]
            /// </summary>
            /// <returns>enum EquipBitTag</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bitTag", "EquipBitTag")]
           public partial EquipBitTag BIT_TAG { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."TbItemCfg"]
        /// </summary>
        partial struct Ptr_TbItemCfg
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
            ///   System.Boolean <EditorRefreshReferCfg>b__74_0(TbTypeCfg x)
            /// </summary>
            /// <param name = "x">class TbTypeCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<EditorRefreshReferCfg>b__74_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbTypeCfg", 0)]
           public partial System.Boolean EDITOR_REFRESH_REFER_CFGB__74_0(nint x); 
*/
            /// <summary>
            ///   System.Boolean <EditorRefreshReferCfg>b__74_1(TbArtCfg x)
            /// </summary>
            /// <param name = "x">class TbArtCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<EditorRefreshReferCfg>b__74_1", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
           public partial System.Boolean EDITOR_REFRESH_REFER_CFGB__74_1(nint x); 
*/
            /// <summary>
            ///   System.Boolean <EditorRefreshReferCfg>b__74_2(TbMagicCfg x)
            /// </summary>
            /// <param name = "x">class TbMagicCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<EditorRefreshReferCfg>b__74_2", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
           public partial System.Boolean EDITOR_REFRESH_REFER_CFGB__74_2(nint x); 
*/
            /// <summary>
            ///   System.Boolean <EditorRefreshReferCfg>b__74_3(TbGradeCfg x)
            /// </summary>
            /// <param name = "x">class TbGradeCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<EditorRefreshReferCfg>b__74_3", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbGradeCfg", 0)]
           public partial System.Boolean EDITOR_REFRESH_REFER_CFGB__74_3(nint x); 
*/
            /// <summary>
            ///   System.Boolean <get_EdArtCfg>b__64_0(TbArtCfg x)
            /// </summary>
            /// <param name = "x">class TbArtCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_EdArtCfg>b__64_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
           public partial System.Boolean GET_ED_ART_CFGB__64_0(nint x); 
*/
            /// <summary>
            ///   System.Boolean <get_EdGradeCfg>b__72_0(TbGradeCfg x)
            /// </summary>
            /// <param name = "x">class TbGradeCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_EdGradeCfg>b__72_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbGradeCfg", 0)]
           public partial System.Boolean GET_ED_GRADE_CFGB__72_0(nint x); 
*/
            /// <summary>
            ///   System.Boolean <get_EdMagicCfg>b__68_0(TbMagicCfg x)
            /// </summary>
            /// <param name = "x">class TbMagicCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_EdMagicCfg>b__68_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
           public partial System.Boolean GET_ED_MAGIC_CFGB__68_0(nint x); 
*/
            /// <summary>
            ///   System.Boolean <get_EdTypeCfg>b__60_0(TbTypeCfg x)
            /// </summary>
            /// <param name = "x">class TbTypeCfg</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_EdTypeCfg>b__60_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbTypeCfg", 0)]
           public partial System.Boolean GET_ED_TYPE_CFGB__60_0(nint x); 
*/
            /// <summary>
            ///   System.Void EditorRefreshReferCfg()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EditorRefreshReferCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void EDITOR_REFRESH_REFER_CFG(); 
*/
            /// <summary>
            ///   TbArtCfg get_EdArtCfg()
            /// </summary>
            /// <returns>class TbArtCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EdArtCfg", "TbArtCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ED_ART_CFG(); 
*/
            /// <summary>
            ///   TbGradeCfg get_EdGradeCfg()
            /// </summary>
            /// <returns>class TbGradeCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EdGradeCfg", "TbGradeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ED_GRADE_CFG(); 
*/
            /// <summary>
            ///   TbMagicCfg get_EdMagicCfg()
            /// </summary>
            /// <returns>class TbMagicCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EdMagicCfg", "TbMagicCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ED_MAGIC_CFG(); 
*/
            /// <summary>
            ///   TbTypeCfg get_EdTypeCfg()
            /// </summary>
            /// <returns>class TbTypeCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EdTypeCfg", "TbTypeCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ED_TYPE_CFG(); 
*/
            /// <summary>
            ///   System.String get_GetDes()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_DES();

            /// <summary>
            ///   System.String get_GetEffDes()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetEffDes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_EFF_DES();

            /// <summary>
            ///   System.Collections.Generic.List<EffTypeEnum> get_GetEffType()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EffTypeEnum></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetEffType", "System.Collections.Generic.List<EffTypeEnum>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_GET_EFF_TYPE(); 
*/
            /// <summary>
            ///   System.String get_GetName()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_GET_NAME();

            /// <summary>
            ///   System.Int32[] get_GetTLNodeIds()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GetTLNodeIds", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_GET_TL_NODE_IDS(); 
*/
            /// <summary>
            ///   TbItemCfg MemoryClone()
            /// </summary>
            /// <returns>class TbItemCfg</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MemoryClone", "TbItemCfg", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint MEMORY_CLONE(); 
*/
            /// <summary>
            ///   System.Void set_EdArtCfg(TbArtCfg value)
            /// </summary>
            /// <param name = "value">class TbArtCfg</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EdArtCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbArtCfg", 0)]
           public partial void SET_ED_ART_CFG(nint value); 
*/
            /// <summary>
            ///   System.Void set_EdGradeCfg(TbGradeCfg value)
            /// </summary>
            /// <param name = "value">class TbGradeCfg</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EdGradeCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbGradeCfg", 0)]
           public partial void SET_ED_GRADE_CFG(nint value); 
*/
            /// <summary>
            ///   System.Void set_EdMagicCfg(TbMagicCfg value)
            /// </summary>
            /// <param name = "value">class TbMagicCfg</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EdMagicCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbMagicCfg", 0)]
           public partial void SET_ED_MAGIC_CFG(nint value); 
*/
            /// <summary>
            ///   System.Void set_EdTypeCfg(TbTypeCfg value)
            /// </summary>
            /// <param name = "value">class TbTypeCfg</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EdTypeCfg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbTypeCfg", 0)]
           public partial void SET_ED_TYPE_CFG(nint value); 
*/
        }
    }
}