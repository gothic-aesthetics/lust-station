﻿using Robust.Shared.Configuration;

namespace Content.Shared._Sunrise.SunriseCCVars;

[CVarDefs]
public sealed class SunriseCCVars
{
    /**
     * TTS (Text-To-Speech)
     */

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<bool> TTSEnabled =
        CVarDef.Create("tts.enabled", false, CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiUrl =
        CVarDef.Create("tts.api_url", "", CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Auth token of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiToken =
        CVarDef.Create("tts.api_token", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    /// <summary>
    /// Amount of seconds before timeout for API
    /// </summary>
    public static readonly CVarDef<int> TTSApiTimeout =
        CVarDef.Create("tts.api_timeout", 5, CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Option to disable TTS events for client
    /// </summary>
    public static readonly CVarDef<bool> TTSClientEnabled =
        CVarDef.Create("tts.client_enabled", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound
    /// </summary>
    public static readonly CVarDef<float> TTSVolume =
        CVarDef.Create("tts.volume", 0.50f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> TTSRadioVolume =
        CVarDef.Create("tts.radio_volume", 0.50f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> TTSAnnounceVolume =
        CVarDef.Create("tts.announce_volume", 0.50f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /**
     * Ban Webhook
     */

    public static readonly CVarDef<string> DiscordBanWebhook =
        CVarDef.Create("discord.ban_webhook", string.Empty, CVar.SERVERONLY);

    /*
     * Service Authorization
     */

    public static readonly CVarDef<bool> ServiceAuthEnabled =
        CVarDef.Create("service_auth.enabled", false, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<string> ServiceAuthApiUrl =
        CVarDef.Create("service_auth.api_url", "", CVar.SERVERONLY);

    public static readonly CVarDef<string> ServiceAuthApiToken =
        CVarDef.Create("service_auth.api_token", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<bool> ServiceAuthCheckTelegramMember =
        CVarDef.Create("service_auth.check_telegram_member", false, CVar.SERVERONLY);

    public static readonly CVarDef<bool> ServiceAuthCheckDiscordMember =
        CVarDef.Create("service_auth.check_discord_member", false, CVar.SERVERONLY);

    /*
     * GodMode RoundEnd
     */

    public static readonly CVarDef<bool> GodModeRoundEnd =
        CVarDef.Create("game.godmode_end", false, CVar.SERVERONLY);

    /*
     * Peaceful Round End
     */

    /// <summary>
    /// Making everyone a pacifist at the end of a round.
    /// </summary>
    public static readonly CVarDef<bool> PeacefulRoundEnd =
        CVarDef.Create("game.peaceful_end", false, CVar.SERVERONLY);

    /*
     * Queue
     */

    public static readonly CVarDef<bool>
        QueueEnabled = CVarDef.Create("queue.enabled", false, CVar.SERVERONLY);

    /*
     *  Sponsor API
     */

    public static readonly CVarDef<string> SponsorApiUrl =
        CVarDef.Create("sponsor.api_url", "", CVar.SERVERONLY);

    public static readonly CVarDef<string> SponsorApiToken =
        CVarDef.Create("sponsor.api_token", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<string> SponsorGhostTheme =
        CVarDef.Create("sponsor.ghost_theme", "", CVar.CLIENTONLY | CVar.ARCHIVE);

    /*
     *  Greetings
     */

    public static readonly CVarDef<bool> GreetingsEnable =
        CVarDef.Create("greetings.enable", true);

    public static readonly CVarDef<string> GreetingsMessage =
        CVarDef.Create("greetings.message", "Привет");

    public static readonly CVarDef<string> GreetingsAuthor =
        CVarDef.Create("greetings.author", "Сервер");

    /*
     * New Life
     */

    public static readonly CVarDef<bool> NewLifeEnable =
        CVarDef.Create("newlife.enable", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<bool> NewLifeSponsorOnly =
        CVarDef.Create("newlife.sponsor_only", false, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<int> NewLifeTimeout =
        CVarDef.Create("newlife.timeout", 5, CVar.SERVERONLY);

    /*
     * Servers Hub
     */

    public static readonly CVarDef<bool> ServersHubEnable =
        CVarDef.Create("servers_hub.enable", false, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Список серверов отображаемых в хабе. Разделяются через запятую.
    /// </summary>
    public static readonly CVarDef<string> ServersHubList =
        CVarDef.Create("servers_hub.urls", "", CVar.SERVERONLY);

    /// <summary>
    /// Простое название сервера для отображения в хабе.
    /// </summary>

    public static readonly CVarDef<string> ServersHubShortName =
        CVarDef.Create("servers_hub.short_name", "SS14 SERVER", CVar.SERVERONLY);

    /**
     * Tape Player
     */

    /// <summary>
    /// Параметр отключения школьников с колонками у клиента.
    /// </summary>
    public static readonly CVarDef<bool> TapePlayerClientEnabled =
        CVarDef.Create("tape_player.client_enabled", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    /*
     * INFOLINKS
     */

    /// <summary>
    /// Link to boosty to show in the launcher.
    /// </summary>
    public static readonly CVarDef<string> InfoLinksDonate =
        CVarDef.Create("infolinks.donate", "", CVar.SERVER | CVar.REPLICATED);

    /**
     * Lobby
     */

    public static readonly CVarDef<string> LobbyBackgroundType =
        CVarDef.Create("lobby.background", "Random", CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<string> LobbyArt =
        CVarDef.Create("lobby.art", "Random", CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<string> LobbyAnimation =
        CVarDef.Create("lobby.animation", "Random", CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<string> LobbyParallax =
        CVarDef.Create("lobby.parallax", "Random", CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<float> LobbyOpacity =
        CVarDef.Create("lobby.lobby_opacity", 0.90f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<string> ServerName =
        CVarDef.Create("lobby.server_name", "Sunrise Station", CVar.SERVER | CVar.REPLICATED);

    /*
     * Planet Prison
     */

    public static readonly CVarDef<bool> MinPlayersEnable =
            CVarDef.Create("planet_prison.enable", true, CVar.SERVERONLY);

    public static readonly CVarDef<int> MinPlayersPlanetPrison =
        CVarDef.Create("planet_prison.min_players", 60, CVar.SERVERONLY);

    /*
     * MaxLoadedChunks
     */

    public static readonly CVarDef<int> MaxLoadedChunks =
        CVarDef.Create("chunk.max", 100, CVar.ARCHIVE | CVar.REPLICATED | CVar.SERVER);

    /**
     * Roadmap
     */

    public static readonly CVarDef<string> RoadmapId =
        CVarDef.Create("roadmap.id", "SunriseRoadmap");

    /**
     * Lobby Changelog
     */

    public static readonly CVarDef<string> LobbyChangelogsList =
        CVarDef.Create("lobby_changelog.list", "ChangelogSunrise.yml,Changelog.yml", CVar.SERVER | CVar.REPLICATED);

    /*
     * Cryoteleport
     */

    public static readonly CVarDef<bool> CryoTeleportEnable =
        CVarDef.Create("cryo_teleport.enable", true, CVar.SERVERONLY);

    public static readonly CVarDef<int> CryoTeleportTransferDelay =
        CVarDef.Create("cryo_teleport.transfer_delay", 5, CVar.SERVERONLY);

    /*
     * Damage
     */

    public static readonly CVarDef<float> DamageVariance =
        CVarDef.Create("damage.variance", 0.15f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> DamageModifier =
        CVarDef.Create("damage.damage_modifier", 1f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> HealModifier =
        CVarDef.Create("damage.heal_modifier", 1.2f, CVar.SERVER | CVar.REPLICATED);

    /*
     * NPCs
     */

    public static readonly CVarDef<bool> NPCDisableWithoutPlayers = CVarDef.Create("npc.disable_without_players", true);

    public static readonly CVarDef<float> NPCDisableDistance = CVarDef.Create("npc.disable_distance", 15f);

    /*
     * Vote
     */

    public static readonly CVarDef<bool> ShowRestartVotes = CVarDef.Create("vote.show_restart_votes", true);

    public static readonly CVarDef<bool> ShowPresetVotes = CVarDef.Create("vote.show_preset_votes", true);

    public static readonly CVarDef<bool> ShowMapVotes = CVarDef.Create("vote.show_map_votes", true);

    public static readonly CVarDef<bool> RunMapVoteAfterRestart = CVarDef.Create("vote.run_map_vote_after_restart", false);

    public static readonly CVarDef<bool> RunPresetVoteAfterRestart = CVarDef.Create("vote.run_preset_vote_after_restart", false);

    public static readonly CVarDef<float> ChancePresetVoteAfterRestart = CVarDef.Create("vote.chance_preset_vote_after_restart", 0.5f);

    public static readonly CVarDef<int> VotingsDelay = CVarDef.Create("vote.votings_delay", 60);

    public static readonly CVarDef<int> MapVotingCount = CVarDef.Create("vote.map_voting_count", 3);

    public static readonly CVarDef<int> RoundVotingCount = CVarDef.Create("vote.round_voting_count", 3);

    public static readonly CVarDef<string> RoundVotingChancesPrototype = CVarDef.Create("vote.round_voting_chances_prototype", "SunriseVoteSecret");

    /*
     * Preset
     */

    public static readonly CVarDef<bool> ResetPresetAfterRestart = CVarDef.Create("game.reset_preset_after_restart", false);

    /*
     * Ban links.
     */

    public static readonly CVarDef<string> BanForumLink =
        CVarDef.Create("cl.forum_link", "", CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    public static readonly CVarDef<string> BanDiscordLink =
        CVarDef.Create("cl.discord_link", "", CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    public static readonly CVarDef<string> BanTelegramLink =
        CVarDef.Create("cl.telegram_link", "", CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    /*
     * Mood
     */

    public static readonly CVarDef<bool> MoodEnabled =
        CVarDef.Create("mood.enabled", true, CVar.SERVER);

    public static readonly CVarDef<bool> MoodIncreasesSpeed =
        CVarDef.Create("mood.increases_speed", true, CVar.SERVER);

    public static readonly CVarDef<bool> MoodDecreasesSpeed =
        CVarDef.Create("mood.decreases_speed", true, CVar.SERVER);

    /**
     * Jump
     */

    public static readonly CVarDef<bool> JumpEnable =
        CVarDef.Create("jump.enable", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> JumpDeadChanse =
        CVarDef.Create("jump.dead_chanse", 0.001f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> JumpCooldown =
        CVarDef.Create("jump.cooldown", 0.600f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<bool> JumpSoundEnable =
        CVarDef.Create("jump.sound_enable", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> BunnyHopEnable =
        CVarDef.Create("bunny_hop.enable", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> BunnyHopSpeedUpPerJump =
        CVarDef.Create("bunny_hop.speed_up_per_jump", 0.005f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> BunnyHopSpeedLimit =
        CVarDef.Create("bunny_hop.speed_limit", 2.0f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> BunnyHopMinSpeedThreshold =
        CVarDef.Create("bunny_hop.min_speed_threshold", 4.0f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> BunnyHopSpeedBoostWindow =
        CVarDef.Create("bunny_hop.speed_boost_window", 0.610f, CVar.SERVER | CVar.REPLICATED);

    /**
     * Flip
     */

    public static readonly CVarDef<float> FlipDeadChanse =
        CVarDef.Create("flip.dead_chanse", 0.001f, CVar.SERVER | CVar.REPLICATED);

    /**
     * Slip
     */

    public static readonly CVarDef<float> SlipDeadChanse =
        CVarDef.Create("slip.dead_chanse", 0.001f, CVar.SERVER | CVar.REPLICATED);

    /**
     * VigersRay
     */

    public static readonly CVarDef<bool> VigersRayJoinNotifyEveryone =
        CVarDef.Create("vigers_ray.join_notify_everyone", false, CVar.SERVERONLY);

    public static readonly CVarDef<bool> VigersRayJoinSoundEveryone =
        CVarDef.Create("vigers_ray.join_sound_everyone", false, CVar.SERVERONLY);

    public static readonly CVarDef<bool> VigersRayJoinShockEveryone =
        CVarDef.Create("vigers_ray.join_shock_everyone", false, CVar.SERVERONLY);

    public static readonly CVarDef<string> VigersRayVictims =
        CVarDef.Create("vigers_ray.victims", "", CVar.SERVERONLY);

    public static readonly CVarDef<bool> DisableGameRules =
        CVarDef.Create("vigers_ray.disable_game_rules", true, CVar.SERVERONLY);

    /// <summary>
    ///     Flavor Profile
    /// </summary>
    public static readonly CVarDef<bool> FlavorTextSponsorOnly =
        CVarDef.Create("flavor_text.sponsor_only", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<int> FlavorTextBaseLength =
        CVarDef.Create("flavor_text.length", 512, CVar.SERVER | CVar.REPLICATED);

    /*
     * Damage Overlay
     */

    public static readonly CVarDef<bool> DamageOverlayEnable =
        CVarDef.Create("damage_overlay.enable", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> DamageOverlaySelf =
        CVarDef.Create("damage_overlay.self", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> DamageOverlayStructures =
        CVarDef.Create("damage_overlay.structures", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    /*
     * Radio chat icons
     */

    public static readonly CVarDef<bool> ChatIconsEnable =
        CVarDef.Create("chat_icon.enable", true, CVar.CLIENTONLY | CVar.ARCHIVE);
}
