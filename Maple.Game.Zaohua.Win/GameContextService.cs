using Maple.Game.Zaohua.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.Game.Zaohua.Win
{
    public sealed class GameContextService(ILogger<GameMetadataContext> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GameMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected override GameMetadataContext LoadGameContext()
        {
            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = GameMetadataContext.MonoJsonClassDTO,
                Methods = GameMetadataContext.MonoJsonMethodDTO,
                Fields = GameMetadataContext.MonoJsonFieldDTO,
            });
            return new GameMetadataContext(Logger, searchService, RuntimeContext);
        }

        protected override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            var cache = MonoGameAssistant.MetadataUnity.UnityMetadataContext_MONO.MethodOffsetCache;

            //UnityEngine.Graphics:Blit2+53 - 48 B8 0083F734FF7F0000 - mov rax,UnityPlayer.dll+9C8300 { (610044232) }
            cache[MonoGameAssistant.MetadataUnity.Graphics.Code_FunctionPointerType_BLIT2_E9370053514A1DE4] = 0x9C8300;

            //UnityEngine.ImageConversion:EncodeToPNG+50 - 48 B8 40CB0D35FF7F0000 - mov rax,UnityPlayer.dll+B2CB40 { ("@USWH??H??") }
            cache[MonoGameAssistant.MetadataUnity.ImageConversion.Code_FunctionPointerType_ENCODE_TO_PNG_B997C8D2C1188DD2] = 0xB2CB40;

            // UnityEngine.Sprite:GetTextureRect_Injected + 5c - 48 B8 00E7F334FF7F0000 - mov rax,UnityPlayer.dll + 98E700 { (610044232) }
            cache[MonoGameAssistant.MetadataUnity.Sprite.Code_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F] = 0x98E700;


            //UnityEngine.Texture2D:ReadPixelsImpl_Injected+6b - 48 B8 90A6F834FF7F0000 - mov rax,UnityPlayer.dll+9DA690 { (610044232) }
            cache[MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_READ_PIXELS_IMPL_INJECTED_3D6557C7BC276B18] = 0x9DA690;

            return MonoGameAssistant.MetadataUnity.UnityMetadataContext.CreateUnityMetadataContext(RuntimeContext, Logger);
        }

        public required GameResourceCache Cache { get; set; }

        protected sealed override async ValueTask LoadGameDataAsync()
        {
            Cache = await this.MonoTaskAsync((p) => GameResourceCache.Create(p)).ConfigureAwait(false);
            foreach (var item in this.Cache.GameInventories)
            {
                if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ObjectId}.png", out var url))
                {
                    item.DisplayImage = url;
                }
            }
            foreach (var item in this.Cache.GameSkills)
            {
                if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ObjectId}.png", out var url))
                {
                    item.DisplayImage = url;
                }
            }
            //var images = await this.UITaskAsync((p, args) => args.Cache.LoadImage(buffer =>
            // {
            //     var unity = args.UnityEngineContext;
            //     if (unity is not null)
            //     {
            //         return unity.ReadSprite2Png(buffer).AsReadOnlySpan().ToArray();
            //     }
            //     return [];

            // }).ToArray(), (Cache, this.UnityEngineContext)).ConfigureAwait(false);

            //var images = await this.UITaskAsync((p, cache) => cache.LoadImage2().ToArray(), Cache).ConfigureAwait(false);



            //foreach (var image in images)
            //{
            //    await this.UITaskAsync((p, args) => args.image.Buffer = args.UnityEngineContext?.ReadSprite2Png(args.image.Image).AsReadOnlySpan().ToArray() ?? [], (this.UnityEngineContext, image)).ConfigureAwait(false);

            //    this.GameSettings.WriteImageFile(image.Buffer, image.DisplayCategory!, $"{image.ObjectId}.png");
            //}

        }

        private Task<GameCheatService> GameCheatServiceThrowIfNotLoadedAsync()
        {
            return this.MonoTaskAsync((p, c) => GameCheatService.CreateGameCheatService(c), this.Cache);
        }

        public override ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            return base.GetSessionInfoAsync();
        }
        //protected override ValueTask F5_KeyDown()
        //{
        //    this.MonoTaskAsync((p) => GameResourceCache.CreateCache(p));
        //    return ValueTask.CompletedTask;
        //}
        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return new ValueTask<GameCurrencyDisplayDTO[]>(GameException.ThrowUIHide<GameCurrencyDisplayDTO[]>(""));
        }

        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return new ValueTask<GameInventoryDisplayDTO[]>(this.Cache.GameInventories);
        }

        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return new ValueTask<GameSkillDisplayDTO[]>(this.Cache.GameSkills);
        }

        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
            return GameException.Throw<GameCharacterDisplayDTO[]>("");
        }

        public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            return new ValueTask<GameMonsterDisplayDTO[]>(GameException.ThrowUIHide<GameMonsterDisplayDTO[]>(""));
        }


        public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return new ValueTask<GameSwitchDisplayDTO[]>(GameException.ThrowUIHide<GameSwitchDisplayDTO[]>(""));
        }

    }
}
