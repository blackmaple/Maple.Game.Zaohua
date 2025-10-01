namespace Maple.Game.Zaohua.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp".""."BsSaveDataImpl"]
    /// [Singleton<BsSaveDataImpl>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BsSaveDataImpl>, Ptr_BsSaveDataImpl>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "BsSaveDataImpl", "BsSaveDataImpl")]
    public partial class BsSaveDataImpl
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BsSaveDataImpl(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BsSaveDataImpl(System.IntPtr ptr) => new Ptr_BsSaveDataImpl(ptr);
            public static implicit operator System.IntPtr(Ptr_BsSaveDataImpl ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_BsSaveDataImpl ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."BsSaveDataImpl"]
        /// </summary>
        partial struct Ptr_BsSaveDataImpl
        {
            /// <summary>
            /// 0x0 System.Int32 MAX_CHARACTER_COUNT
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           public const System.Int32 MAX_CHARACTER_COUNT = 9; 
*/
            /// <summary>
            /// 0x0 System.Int32 MAX_SAVE_COUNT
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           public const System.Int32 MAX_SAVE_COUNT = 20; 
*/
            /// <summary>
            /// 0x0 System.Collections.Generic.List<TbSaveDataAll> SaveDataList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbSaveDataAll></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SaveDataList", "System.Collections.Generic.List<TbSaveDataAll>")]
           public static partial nint SAVE_DATA_LIST { get; set; } 
*/

            /// <summary>
            /// 0x0 BsSaveDataImpl m_Instance
            /// class ["Assembly-CSharp".""."BsSaveDataImpl"]
            /// </summary>
            /// <returns>class BsSaveDataImpl</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Instance", "BsSaveDataImpl")]
            public static partial Ptr_BsSaveDataImpl M_INSTANCE { get; set; }


            /// <summary>
            /// 0x8 System.Int32 SelectedCharacterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SelectedCharacterId", "System.Int32")]
           public static partial System.Int32 SELECTED_CHARACTER_ID { get; set; } 
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
            /// 0x10 TbActor nowActor
            /// class ["Assembly-CSharp".""."TbActor"]
            /// </summary>
            /// <returns>class TbActor</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nowActor", "TbActor")]
            public static partial TbActor.Ptr_TbActor NOW_ACTOR { get; set; }


            /// <summary>
            /// 0x10 System.String preActor
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("preActor", "System.String")]
           public partial nint PRE_ACTOR { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String SAVE_FILEPATH
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SAVE_FILEPATH", "System.String")]
           public partial nint SAVE_FILEPATH { get; set; } 
*/

            /// <summary>
            /// 0x20 TbEndRewardAll endRewardAll
            /// class ["Assembly-CSharp".""."TbEndRewardAll"]
            /// </summary>
            /// <returns>class TbEndRewardAll</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("endRewardAll", "TbEndRewardAll")]
           public partial nint END_REWARD_ALL { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<TbQuickKeyAll> quickKeyAll
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuickKeyAll></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("quickKeyAll", "System.Collections.Generic.List<TbQuickKeyAll>")]
           public partial nint QUICK_KEY_ALL { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<TbStoryLineAll> storyLineDatas
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStoryLineAll></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("storyLineDatas", "System.Collections.Generic.List<TbStoryLineAll>")]
           public partial nint STORY_LINE_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x38 SerializableEnum SAVE_SERIALIZABLE_TYPE
            /// enum ["Assembly-CSharp".""."SerializableEnum"]
            /// </summary>
            /// <returns>enum SerializableEnum</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SAVE_SERIALIZABLE_TYPE", "SerializableEnum")]
           public partial SerializableEnum SAVE_SERIALIZABLE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int64 enterGameTime
            /// struct ["mscorlib"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("enterGameTime", "System.Int64")]
           public partial System.Int64 ENTER_GAME_TIME { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 characterId
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("characterId", "System.Int32")]
           public partial System.Int32 CHARACTER_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."BsSaveDataImpl"]
        /// </summary>
        partial struct Ptr_BsSaveDataImpl
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
            /// static  TbActor CloneNowActor()
            /// </summary>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CloneNowActor", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint CLONE_NOW_ACTOR(); 
*/
            /// <summary>
            /// static  TbActor get_NowActor()
            /// </summary>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NowActor", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_NOW_ACTOR(); 
*/
            /// <summary>
            /// static  System.Void set_NowActor(TbActor value)
            /// </summary>
            /// <param name = "value">class TbActor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NowActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
           public static partial void SET_NOW_ACTOR(nint value); 
*/
            /// <summary>
            /// static  System.Void SetNowActor(TbActor actor)
            /// </summary>
            /// <param name = "actor">class TbActor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNowActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
           public static partial void SET_NOW_ACTOR(nint actor); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AutoSave()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void AUTO_SAVE(); 
*/
            /// <summary>
            ///   System.Threading.Tasks.Task AutoSaveAsync()
            /// </summary>
            /// <returns>class System.Threading.Tasks.Task</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSaveAsync", "System.Threading.Tasks.Task", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint AUTO_SAVE_ASYNC(); 
*/
            /// <summary>
            ///   System.Void AutoSaveStoryLine(System.Int32 id, System.Int32 StoryLineDataId)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "StoryLineDataId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSaveStoryLine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void AUTO_SAVE_STORY_LINE(System.Int32 id, System.Int32 StoryLineDataId); 
*/
            /// <summary>
            ///   System.Void DeleteByUuid(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "StoryLineDataId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteByUuid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void DELETE_BY_UUID(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId); 
*/
            /// <summary>
            ///   System.Void DeleteSave(System.Int32 characterId, System.Int32 saveType, System.Int32 id)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void DELETE_SAVE(System.Int32 characterId, System.Int32 saveType, System.Int32 id); 
*/
            /// <summary>
            ///   System.Void DeleteSaveAll()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSaveAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void DELETE_SAVE_ALL(); 
*/
            /// <summary>
            ///   System.Void DeleteSaveAllByCharacterId(System.Int32 characterId)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSaveAllByCharacterId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void DELETE_SAVE_ALL_BY_CHARACTER_ID(System.Int32 characterId); 
*/
            /// <summary>
            ///   UnityEngine.Sprite GetDifficultImage(DifficultyEnum difficulty)
            /// </summary>
            /// <param name = "difficulty">enum DifficultyEnum</param>
            /// <returns>class UnityEngine.Sprite</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDifficultImage", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DifficultyEnum", 0)]
            public partial nint GET_DIFFICULT_IMAGE(DifficultyEnum difficulty);

            /// <summary>
            ///   System.String GetGameLong(System.Int64 totalTime)
            /// </summary>
            /// <param name = "totalTime">struct System.Int64</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameLong", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 0)]
           public partial nint GET_GAME_LONG(System.Int64 totalTime); 
*/
            /// <summary>
            ///   System.String GetLastTimeStr(System.String time)
            /// </summary>
            /// <param name = "time">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLastTimeStr", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint GET_LAST_TIME_STR(nint time); 
*/
            /// <summary>
            ///   TbSaveDataAll GetNewSaveData(System.Int32 characterId, System.Int32 saveType)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <returns>class TbSaveDataAll</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNewSaveData", "TbSaveDataAll", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial nint GET_NEW_SAVE_DATA(System.Int32 characterId, System.Int32 saveType); 
*/
            /// <summary>
            ///   System.Int32 GetOldActorId(System.Int32 characterId, System.Int32 saveType)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOldActorId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Int32 GET_OLD_ACTOR_ID(System.Int32 characterId, System.Int32 saveType); 
*/
            /// <summary>
            ///   System.Int32 GetOldCharacterId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOldCharacterId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_OLD_CHARACTER_ID(); 
*/
            /// <summary>
            ///   TbSaveDataAll GetSaveData(TbActor actor)
            /// </summary>
            /// <param name = "actor">class TbActor</param>
            /// <returns>class TbSaveDataAll</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveData", "TbSaveDataAll", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbActor", 0)]
           public partial nint GET_SAVE_DATA(nint actor); 
*/
            /// <summary>
            ///   System.String GetSavePath(System.Int32 characterId, System.Int32 saveType, System.Int32 actorId, System.Nullable<System.Int32> StorylinedataId)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "actorId">struct System.Int32</param>
            /// <param name = "StorylinedataId">struct System.Nullable<System.Int32></param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSavePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<System.Int32>", 3)]
           public partial nint GET_SAVE_PATH(System.Int32 characterId, System.Int32 saveType, System.Int32 actorId, System.Nullable<System.Int32> StorylinedataId); 
*/
            /// <summary>
            ///   System.String GetSavePathByUuid(System.Int32 saveType, System.Int32 characterId, System.Int32 StoryLineData)
            /// </summary>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "StoryLineData">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSavePathByUuid", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint GET_SAVE_PATH_BY_UUID(System.Int32 saveType, System.Int32 characterId, System.Int32 StoryLineData); 
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
            ///   System.Void InitPath()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitPath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void INIT_PATH(); 
*/
            /// <summary>
            ///   System.Void InitTbActor(System.Int32 characterId, TbRoleCfg _role, System.String _sur, System.String _name, System.Collections.Generic.List<TbCreateCfg> equippedCreateCfgList, SaveModeEnum saveMode, DifficultyEnum difficulty, System.Boolean isTeach, System.Boolean isDub)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "_role">class TbRoleCfg</param>
            /// <param name = "_sur">class System.String</param>
            /// <param name = "_name">class System.String</param>
            /// <param name = "equippedCreateCfgList">class System.Collections.Generic.List<TbCreateCfg></param>
            /// <param name = "saveMode">enum SaveModeEnum</param>
            /// <param name = "difficulty">enum DifficultyEnum</param>
            /// <param name = "isTeach">struct System.Boolean</param>
            /// <param name = "isDub">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitTbActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TbRoleCfg", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<TbCreateCfg>", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SaveModeEnum", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DifficultyEnum", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           public partial void INIT_TB_ACTOR(System.Int32 characterId, nint _role, nint _sur, nint _name, nint equippedCreateCfgList, SaveModeEnum saveMode, DifficultyEnum difficulty, System.Boolean isTeach, System.Boolean isDub); 
*/
            /// <summary>
            ///   TbActor Load(System.String _path)
            /// </summary>
            /// <param name = "_path">class System.String</param>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial nint LOAD(nint _path); 
*/
            /// <summary>
            ///   TbActor LoadById(System.Int32 characterId, System.Int32 saveType, System.Int32 id)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadById", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint LOAD_BY_ID(System.Int32 characterId, System.Int32 saveType, System.Int32 id); 
*/
            /// <summary>
            ///   TbActor LoadByUuid(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "StoryLineDataId">struct System.Int32</param>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadByUuid", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint LOAD_BY_UUID(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId); 
*/
            /// <summary>
            ///   TbEndRewardAll LoadEndRewardSav()
            /// </summary>
            /// <returns>class TbEndRewardAll</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadEndRewardSav", "TbEndRewardAll", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint LOAD_END_REWARD_SAV(); 
*/
            /// <summary>
            ///   TbActor LoadLastCreate()
            /// </summary>
            /// <returns>class TbActor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadLastCreate", "TbActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint LOAD_LAST_CREATE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbQuickKeyAll> LoadQuickKeyAllSave()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbQuickKeyAll></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadQuickKeyAllSave", "System.Collections.Generic.List<TbQuickKeyAll>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint LOAD_QUICK_KEY_ALL_SAVE(); 
*/
            /// <summary>
            ///   System.Void LoadSaveDataList()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSaveDataList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void LOAD_SAVE_DATA_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TbStoryLineAll> LoadStoryLineDataSav()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<TbStoryLineAll></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadStoryLineDataSav", "System.Collections.Generic.List<TbStoryLineAll>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint LOAD_STORY_LINE_DATA_SAV(); 
*/
            /// <summary>
            ///   System.Void QuickLoad()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("QuickLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void QUICK_LOAD(); 
*/
            /// <summary>
            ///   System.Void QuickSave()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("QuickSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void QUICK_SAVE(); 
*/
            /// <summary>
            ///   System.Void QuitGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("QuitGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void QUIT_GAME(); 
*/
            /// <summary>
            ///   System.Void SaveById(System.Int32 characterId, System.Int32 saveType, System.Int32 id)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveById", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void SAVE_BY_ID(System.Int32 characterId, System.Int32 saveType, System.Int32 id); 
*/
            /// <summary>
            ///   System.Threading.Tasks.Task SaveByIdAsync(System.Int32 characterId, System.Int32 saveType, System.Int32 id)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.Threading.Tasks.Task</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveByIdAsync", "System.Threading.Tasks.Task", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint SAVE_BY_ID_ASYNC(System.Int32 characterId, System.Int32 saveType, System.Int32 id); 
*/
            /// <summary>
            ///   System.Void SaveByUuid(System.Int32 saveType, System.Int32 StoryLineDataId)
            /// </summary>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "StoryLineDataId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveByUuid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SAVE_BY_UUID(System.Int32 saveType, System.Int32 StoryLineDataId); 
*/
            /// <summary>
            ///   System.Void SaveEndRewardSav()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveEndRewardSav", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_END_REWARD_SAV(); 
*/
            /// <summary>
            ///   System.Void SaveLastCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveLastCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_LAST_CREATE(); 
*/
            /// <summary>
            ///   System.Void SaveQuickKeyAll()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveQuickKeyAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_QUICK_KEY_ALL(); 
*/
            /// <summary>
            ///   System.Void SaveSaveDataList()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveSaveDataList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_SAVE_DATA_LIST(); 
*/
            /// <summary>
            ///   System.Void SaveStoryLineDataSav()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveStoryLineDataSav", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_STORY_LINE_DATA_SAV(); 
*/
            /// <summary>
            ///   System.Void ToLoadGame(System.Int32 characterId, System.Int32 saveType, System.Int32 id)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToLoadGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void TO_LOAD_GAME(System.Int32 characterId, System.Int32 saveType, System.Int32 id); 
*/
            /// <summary>
            ///   System.Void ToLoadGameByUUID(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId)
            /// </summary>
            /// <param name = "characterId">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <param name = "StoryLineDataId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToLoadGameByUUID", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void TO_LOAD_GAME_BY_UUID(System.Int32 characterId, System.Int32 saveType, System.Int32 StoryLineDataId); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp".""."Singleton`1"]
        /// </summary>
        partial struct Ptr_BsSaveDataImpl
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
            /// static  BsSaveDataImpl get_Instance()
            /// </summary>
            /// <returns>class BsSaveDataImpl</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "BsSaveDataImpl", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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