// Namespace: 
public sealed class AkCallbackManager.EventCallback : MulticastDelegate // TypeDefIndex: 7925
{
	// Methods

	// RVA: 0x24B2890 Offset: 0x24B2991 VA: 0x24B2890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B28B0 Offset: 0x24B29B1 VA: 0x24B28B0 Slot: 13
	public virtual void Invoke(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }

	// RVA: 0x24B2C50 Offset: 0x24B2D51 VA: 0x24B2C50 Slot: 14
	public virtual IAsyncResult BeginInvoke(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info, AsyncCallback callback, object object) { }

	// RVA: 0x24B2D00 Offset: 0x24B2E01 VA: 0x24B2D00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AkCallbackManager.MonitoringCallback : MulticastDelegate // TypeDefIndex: 7926
{
	// Methods

	// RVA: 0x24B2F50 Offset: 0x24B3051 VA: 0x24B2F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B2F70 Offset: 0x24B3071 VA: 0x24B2F70 Slot: 13
	public virtual void Invoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg) { }

	// RVA: 0x24B3230 Offset: 0x24B3331 VA: 0x24B3230 Slot: 14
	public virtual IAsyncResult BeginInvoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg, AsyncCallback callback, object object) { }

	// RVA: 0x24B3350 Offset: 0x24B3451 VA: 0x24B3350 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AkCallbackManager.BankCallback : MulticastDelegate // TypeDefIndex: 7927
{
	// Methods

	// RVA: 0x24B1870 Offset: 0x24B1971 VA: 0x24B1870
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B1520 Offset: 0x24B1621 VA: 0x24B1520 Slot: 13
	public virtual void Invoke(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie) { }

	// RVA: 0x24B26B0 Offset: 0x24B27B1 VA: 0x24B26B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie, AsyncCallback callback, object object) { }

	// RVA: 0x24B27A0 Offset: 0x24B28A1 VA: 0x24B27A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class AkCallbackManager.EventCallbackPackage // TypeDefIndex: 7928
{
	// Fields
	public bool m_bNotifyEndOfEvent; // 0x10
	public AkCallbackManager.EventCallback m_Callback; // 0x18
	public object m_Cookie; // 0x20
	public uint m_playingID; // 0x28

	// Methods

	// RVA: 0x24B2D10 Offset: 0x24B2E11 VA: 0x24B2D10
	public static AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback in_cb, object in_cookie, ref uint io_Flags) { }

	// RVA: 0x24B2E50 Offset: 0x24B2F51 VA: 0x24B2E50
	public void .ctor() { }
}

// Namespace: 
public class AkCallbackManager.BankCallbackPackage // TypeDefIndex: 7929
{
	// Fields
	public AkCallbackManager.BankCallback m_Callback; // 0x10
	public object m_Cookie; // 0x18

	// Methods

	// RVA: 0x24B27B0 Offset: 0x24B28B1 VA: 0x24B27B0
	public void .ctor(AkCallbackManager.BankCallback in_cb, object in_cookie) { }
}

// Namespace: 
public sealed class AkCallbackManager.BGMCallback : MulticastDelegate // TypeDefIndex: 7930
{
	// Methods

	// RVA: 0x24B2370 Offset: 0x24B2471 VA: 0x24B2370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B2390 Offset: 0x24B2491 VA: 0x24B2390 Slot: 13
	public virtual AKRESULT Invoke(bool in_bOtherAudioPlaying, object in_Cookie) { }

	// RVA: 0x24B25D0 Offset: 0x24B26D1 VA: 0x24B25D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool in_bOtherAudioPlaying, object in_Cookie, AsyncCallback callback, object object) { }

	// RVA: 0x24B2670 Offset: 0x24B2771 VA: 0x24B2670 Slot: 15
	public virtual AKRESULT EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class AkCallbackManager.BGMCallbackPackage // TypeDefIndex: 7931
{
	// Fields
	public AkCallbackManager.BGMCallback m_Callback; // 0x10
	public object m_Cookie; // 0x18

	// Methods

	// RVA: 0x24B26A0 Offset: 0x24B27A1 VA: 0x24B26A0
	public void .ctor() { }
}

// Namespace: 
public class AkCallbackManager.InitializationSettings // TypeDefIndex: 7932
{
	// Fields
	public static int DefaultBufferSize; // 0x0
	public static bool DefaultIsLoggingEnabled; // 0x4
	public int BufferSize; // 0x10
	public bool IsLoggingEnabled; // 0x14

	// Methods

	// RVA: 0x24B2E60 Offset: 0x24B2F61 VA: 0x24B2E60
	public void .ctor() { }

	// RVA: 0x24B2EF0 Offset: 0x24B2FF1 VA: 0x24B2EF0
	private static void .cctor() { }
}

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

