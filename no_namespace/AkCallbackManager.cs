// Namespace: 
public static class AkCallbackManager // TypeDefIndex: 7933
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27D5F0 Offset: 0x27D6F1 VA: 0x27D5F0
	private static bool <IsLoggingEnabled>k__BackingField; // 0x0
	private static readonly AkEventCallbackInfo AkEventCallbackInfo; // 0x8
	private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo; // 0x10
	private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo; // 0x18
	private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo; // 0x20
	private static readonly AkDurationCallbackInfo AkDurationCallbackInfo; // 0x28
	private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo; // 0x30
	private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo; // 0x38
	private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo; // 0x40
	private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo; // 0x48
	private static readonly AkBankCallbackInfo AkBankCallbackInfo; // 0x50
	private static readonly Dictionary<int, AkCallbackManager.EventCallbackPackage> m_mapEventCallbacks; // 0x58
	private static readonly Dictionary<int, AkCallbackManager.BankCallbackPackage> m_mapBankCallbacks; // 0x60
	private static AkCallbackManager.EventCallbackPackage m_LastAddedEventPackage; // 0x68
	private static IntPtr m_pNotifMem; // 0x70
	private static AkCallbackManager.MonitoringCallback m_MonitoringCB; // 0x78
	private static AkCallbackManager.BGMCallbackPackage ms_sourceChangeCallbackPkg; // 0x80

	// Properties
	private static bool IsLoggingEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7010 Offset: 0x2A7111 VA: 0x2A7010
	// RVA: 0x2ED4600 Offset: 0x2ED4701 VA: 0x2ED4600
	private static bool get_IsLoggingEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7020 Offset: 0x2A7121 VA: 0x2A7020
	// RVA: 0x2ED4670 Offset: 0x2ED4771 VA: 0x2ED4670
	private static void set_IsLoggingEnabled(bool value) { }

	// RVA: 0x2ED46F0 Offset: 0x2ED47F1 VA: 0x2ED46F0
	public static void RemoveEventCallback(uint in_playingID) { }

	// RVA: 0x2ED49C0 Offset: 0x2ED4AC1 VA: 0x2ED49C0
	public static void RemoveEventCallbackCookie(object in_cookie) { }

	// RVA: 0x2ED4C80 Offset: 0x2ED4D81 VA: 0x2ED4C80
	public static void RemoveBankCallback(object in_cookie) { }

	// RVA: 0x2ED4F40 Offset: 0x2ED5041 VA: 0x2ED4F40
	public static void SetLastAddedPlayingID(uint in_playingID) { }

	// RVA: 0x2ED5020 Offset: 0x2ED5121 VA: 0x2ED5020
	public static AKRESULT Init(AkCallbackManager.InitializationSettings settings) { }

	// RVA: 0x2ED5190 Offset: 0x2ED5291 VA: 0x2ED5190
	public static void Term() { }

	// RVA: 0x2ED5280 Offset: 0x2ED5381 VA: 0x2ED5280
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB) { }

	// RVA: 0x2ED5310 Offset: 0x2ED5411 VA: 0x2ED5310
	public static void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, object in_cookie) { }

	// RVA: 0x2ED53E0 Offset: 0x2ED54E1 VA: 0x2ED53E0
	public static int PostCallbacks() { }

	// RVA: 0x2ED6030 Offset: 0x2ED6131 VA: 0x2ED6030
	private static void .cctor() { }
}

