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

