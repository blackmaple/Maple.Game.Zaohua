using Maple.Game.Zaohua.Metadata;
using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
using Maple.XScheduler;
using Microsoft.Extensions.Logging;
namespace Maple.Game.Zaohua.UI;

public sealed class GameContextService(
    ILogger<GameContextService> logger,
    MonoRuntimeContext runtimeContext,
    MonoTaskScheduler taskScheduler,
    WinMsgHookFactory winMsgHookFactory,
    MonoInternalCallService internalCallService,
     MonoGameSettings gameSettings,
    IHookFactory hookFactory,
    IXSchedulerFactory schedulerFactory)
    : GameContextService<GameMetadataContext>(logger, runtimeContext, taskScheduler, winMsgHookFactory, internalCallService, gameSettings, hookFactory, schedulerFactory)
{
    protected override GameMetadataContext LoadContextMetadata()
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
    public required GameResourceCache Cache { get; set; }
    protected override async ValueTask LoadGameResourcesAsync()
    {
        this.Cache = await this.MonoTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);

        return;
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

    public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.GetInventoryInfo(args.inventoryObjectDTO), (cheatService, inventoryObjectDTO)).ConfigureAwait(false);
    }

    public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.UpdateInventoryInfo(args.inventoryObjectDTO), (cheatService, inventoryObjectDTO)).ConfigureAwait(false);
    }

    public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
    {
        return new ValueTask<GameSkillDisplayDTO[]>(this.Cache.GameSkills);
    }

    public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, cheat) => cheat.GetGameCharacters().ToArray(), cheatService).ConfigureAwait(false);
    }

    public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.GetGameCharacterSkills(args.characterObjectDTO), (cheatService, characterObjectDTO)).ConfigureAwait(false);
    }
    public sealed override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.UpdateGameCharacterStatus(args.characterModifyDTO), (cheatService, characterModifyDTO)).ConfigureAwait(false);
    }
    public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.UpdateGameCharacterSkill(args.characterModifyDTO), (cheatService, characterModifyDTO)).ConfigureAwait(false);
    }

    public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
    {
        var cheatService = await GameCheatServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MonoTaskAsync((p, args) => args.cheatService.GetGameCharacterStatus(args.characterObjectDTO), (cheatService, characterObjectDTO)).ConfigureAwait(false);
    }



    //public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
    //{
    //    return new ValueTask<GameMonsterDisplayDTO[]>(GameException.ThrowUIHide<GameMonsterDisplayDTO[]>(""));
    //}


    //public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
    //{
    //    return new ValueTask<GameSwitchDisplayDTO[]>(GameException.ThrowUIHide<GameSwitchDisplayDTO[]>(""));
    //}

}



