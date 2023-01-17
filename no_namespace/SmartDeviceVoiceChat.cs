// Namespace: 
public enum SmartDeviceVoiceChat.ShowAppResultStatus // TypeDefIndex: 14974
{
	// Fields
	public int value__; // 0x0
	public const SmartDeviceVoiceChat.ShowAppResultStatus SHOW_APP_RESULT_STATUS_ERROR = 0;
	public const SmartDeviceVoiceChat.ShowAppResultStatus SHOW_APP_RESULT_STATUS_CANCELED = 1;
}

// Namespace: 
public sealed class SmartDeviceVoiceChat.GetAvailabilityCB : MulticastDelegate // TypeDefIndex: 14975
{
	// Methods

	// RVA: 0x203CC70 Offset: 0x203CD71 VA: 0x203CC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x203CC90 Offset: 0x203CD91 VA: 0x203CC90 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, bool availability) { }

	// RVA: 0x203D000 Offset: 0x203D101 VA: 0x203D000 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, bool availability, AsyncCallback callback, object object) { }

	// RVA: 0x203D0A0 Offset: 0x203D1A1 VA: 0x203D0A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SmartDeviceVoiceChat.JoinRoomCB : MulticastDelegate // TypeDefIndex: 14976
{
	// Methods

	// RVA: 0x203D0B0 Offset: 0x203D1B1 VA: 0x203D0B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x203D0D0 Offset: 0x203D1D1 VA: 0x203D0D0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, SmartDeviceVoiceChatJoinRoomResult result) { }

	// RVA: 0x203D440 Offset: 0x203D541 VA: 0x203D440 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, SmartDeviceVoiceChatJoinRoomResult result, AsyncCallback callback, object object) { }

	// RVA: 0x203D470 Offset: 0x203D571 VA: 0x203D470 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SmartDeviceVoiceChat.ShowAppPageCB : MulticastDelegate // TypeDefIndex: 14977
{
	// Methods

	// RVA: 0x203D480 Offset: 0x203D581 VA: 0x203D480
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x203D4A0 Offset: 0x203D5A1 VA: 0x203D4A0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, SmartDeviceVoiceChatShowAppPageResult result) { }

	// RVA: 0x203D810 Offset: 0x203D911 VA: 0x203D810 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, SmartDeviceVoiceChatShowAppPageResult result, AsyncCallback callback, object object) { }

	// RVA: 0x203D840 Offset: 0x203D941 VA: 0x203D840 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

