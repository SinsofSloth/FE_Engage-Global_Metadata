// Namespace: 
public enum SmartDeviceVoiceChat.ShowAppResultStatus // TypeDefIndex: 14974
{
	// Fields
	public int value__; // 0x0
	public const SmartDeviceVoiceChat.ShowAppResultStatus SHOW_APP_RESULT_STATUS_ERROR = 0;
	public const SmartDeviceVoiceChat.ShowAppResultStatus SHOW_APP_RESULT_STATUS_CANCELED = 1;
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

