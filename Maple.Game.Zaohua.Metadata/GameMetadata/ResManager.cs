using Maple.MonoGameAssistant.Core;

namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."ResManager"]
    /// [Singleton<ResManager>]=>[System.Object]
    /// [IManager]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ResManager>, Ptr_ResManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "ResManager", "ResManager")]
    public partial class ResManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ResManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ResManager(System.IntPtr ptr) => new Ptr_ResManager(ptr);
            public static implicit operator System.IntPtr(Ptr_ResManager ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ResManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."ResManager"]
        /// </summary>
        partial struct Ptr_ResManager
        {
            /// <summary>
            /// 0x0 ResManager m_Instance
            /// class ["Assembly-CSharp".""."ResManager"]
            /// </summary>
            /// <returns>class ResManager</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "ResManager")]
            public static partial Ptr_ResManager M_INSTANCE { get; set; }


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
            /// 0x10 ILoader loader
            /// interface ["Assembly-CSharp".""."ILoader"]
            /// </summary>
            /// <returns>interface ILoader</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("loader", "ILoader")]
           public partial nint LOADER { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<System.String , IConfiger> configDict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , IConfiger></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("configDict", "System.Collections.Generic.Dictionary<System.String,IConfiger>")]
           public partial nint CONFIG_DICT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String tempConfigkey
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tempConfigkey", "System.String")]
           public partial nint TEMP_CONFIGKEY { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , System.ValueTuple<UnityEngine.U2D.SpriteAtlas , System.Single>> _atlasCache
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<UnityEngine.U2D.SpriteAtlas , System.Single>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_atlasCache", "System.Collections.Generic.Dictionary<System.String,System.ValueTuple<UnityEngine.U2D.SpriteAtlas,System.Single>>")]
           public partial nint _ATLAS_CACHE { get; set; } 
*/

            /// <summary>
            /// 0x30 ResLoadMethod CurrentLoadMethod
            /// enum ["Assembly-CSharp".""."ResLoadMethod"]
            /// </summary>
            /// <returns>enum ResLoadMethod</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CurrentLoadMethod", "ResLoadMethod")]
           public partial ResLoadMethod CURRENT_LOAD_METHOD { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."ResManager"]
        /// </summary>
        partial struct Ptr_ResManager
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
            ///   System.Boolean CheckAss(System.String oldName)
            /// </summary>
            /// <param name = "oldName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckAss", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial System.Boolean CHECK_ASS(nint oldName); 
*/
            /// <summary>
            ///   System.String[] GetABname(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetABname", "System.String[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint GET_A_BNAME(nint path); 
*/
            /// <summary>
            ///   T GetConfiger()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetConfiger", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CONFIGER(); 
*/
            /// <summary>
            ///   ILoader GetLoader(ResLoadMethod resLoadMethod)
            /// </summary>
            /// <param name = "resLoadMethod">enum ResLoadMethod</param>
            /// <returns>interface ILoader</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLoader", "ILoader", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResLoadMethod", 0)]
           public partial nint GET_LOADER(ResLoadMethod resLoadMethod); 
*/
            /// <summary>
            ///   T GetLoader()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLoader", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_LOADER(); 
*/
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void INIT(); 
*/
            /// <summary>
            ///   System.String JoinAssName(System.String oldName)
            /// </summary>
            /// <param name = "oldName">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JoinAssName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint JOIN_ASS_NAME(nint oldName); 
*/
            /// <summary>
            ///   T LoadAssetBundle(System.String assetBundleName, System.String assetName)
            /// </summary>
            /// <param name = "assetBundleName">class System.String</param>
            /// <param name = "assetName">class System.String</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAssetBundle", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public partial nint LOAD_ASSET_BUNDLE(nint assetBundleName, nint assetName); 
*/
            /// <summary>
            ///   T[] LoadAssetBundleAll(System.String assetBundleName)
            /// </summary>
            /// <param name = "assetBundleName">class System.String</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAssetBundleAll", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint LOAD_ASSET_BUNDLE_ALL(nint assetBundleName); 
*/
            /// <summary>
            ///   UnityEngine.Sprite LoadAtlasSprite(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>class UnityEngine.Sprite</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAtlasSprite", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD_ATLAS_SPRITE(PMonoString name);

            /// <summary>
            ///   T LoadConfig(System.String path, ResType resType)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "resType">enum ResType</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadConfig", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResType", 1)]
           public partial nint LOAD_CONFIG(nint path, ResType resType); 
*/
            /// <summary>
            ///   T LoadConfig(UnityEngine.TextAsset textAsset, ResType resType)
            /// </summary>
            /// <param name = "textAsset">class UnityEngine.TextAsset</param>
            /// <param name = "resType">enum ResType</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadConfig", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextAsset", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResType", 1)]
           public partial nint LOAD_CONFIG(nint textAsset, ResType resType); 
*/
            /// <summary>
            ///   UnityEngine.AssetBundle LoadMainAsset(System.String assetBundleName)
            /// </summary>
            /// <param name = "assetBundleName">class System.String</param>
            /// <returns>class UnityEngine.AssetBundle</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadMainAsset", "UnityEngine.AssetBundle", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint LOAD_MAIN_ASSET(nint assetBundleName); 
*/
            /// <summary>
            ///   T LoadRes(System.String path, System.Boolean isNeedJoin, CoroutineSignal signal, UnityEngine.Events.UnityAction<T> callback)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "isNeedJoin">struct System.Boolean</param>
            /// <param name = "signal">class CoroutineSignal</param>
            /// <param name = "callback">class UnityEngine.Events.UnityAction<T></param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRes", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CoroutineSignal", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Events.UnityAction<T>", 3)]
           public partial nint LOAD_RES(nint path, System.Boolean isNeedJoin, nint signal, nint callback); 
*/
            /// <summary>
            ///   T LoadResource(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadResource", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint LOAD_RESOURCE(nint path); 
*/
            /// <summary>
            ///   System.String ReadFile(System.String fileName)
            /// </summary>
            /// <param name = "fileName">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadFile", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint READ_FILE(nint fileName); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator ResourAsync(System.String path, CoroutineSignal signal, UnityEngine.Events.UnityAction<T> callback)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "signal">class CoroutineSignal</param>
            /// <param name = "callback">class UnityEngine.Events.UnityAction<T></param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResourAsync", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CoroutineSignal", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Events.UnityAction<T>", 2)]
           public partial nint RESOUR_ASYNC(nint path, nint signal, nint callback); 
*/
            /// <summary>
            ///   System.Void SaveConfig(T obj, System.String path)
            /// </summary>
            /// <param name = "obj">class T</param>
            /// <param name = "path">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveConfig", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public partial void SAVE_CONFIG(nint obj, nint path); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_ResManager
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
            /// static  ResManager get_Instance()
            /// </summary>
            /// <returns>class ResManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "ResManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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