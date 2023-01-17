// Namespace: NexPlugin
public static class SmartDeviceVoiceChat // TypeDefIndex: 14978
{
	// Fields
	public const uint DEFAULT_CHANNELID = 0;
	public const uint DEFAULT_HTTP_THREAD_PRIORITY = 16;
	public const uint INVALID_ROOMID = 0;

	// Methods

	// RVA: 0x27E4E50 Offset: 0x27E4F51 VA: 0x27E4E50
	public static bool ShowAppPageAsync(out uint asyncId, SmartDeviceVoiceChatShowAppPageParam param, SmartDeviceVoiceChat.ShowAppPageCB callback) { }

	// RVA: 0x27E4E60 Offset: 0x27E4F61 VA: 0x27E4E60
	public static bool ChangeVoiceChatChannelAsync(out uint asyncId, SmartDeviceVoiceChatChangeVoiceChatChannelParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x27E4E70 Offset: 0x27E4F71 VA: 0x27E4E70
	public static bool GetAvailabilityAsync(out uint asyncId, int timeOut = 0, SmartDeviceVoiceChat.GetAvailabilityCB callback) { }

	// RVA: 0x27E4E80 Offset: 0x27E4F81 VA: 0x27E4E80
	public static bool JoinRoomAsync(out uint asyncId, SmartDeviceVoiceChatJoinRoomParam param, int timeOut = 0, SmartDeviceVoiceChat.JoinRoomCB callback) { }

	// RVA: 0x27E4E90 Offset: 0x27E4F91 VA: 0x27E4E90
	public static bool LeaveRoomAsync(out uint asyncId, SmartDeviceVoiceChatLeaveRoomParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x27E4EA0 Offset: 0x27E4FA1 VA: 0x27E4EA0
	public static bool LeaveRoom(SmartDeviceVoiceChatLeaveRoomParam param) { }

	// RVA: 0x27E4EB0 Offset: 0x27E4FB1 VA: 0x27E4EB0
	public static extern bool GetLastAccountNnResult(ref Result result) { }

	// RVA: 0x27E4ED0 Offset: 0x27E4FD1 VA: 0x27E4ED0
	public static extern bool GetHttpThreadPriority(ref uint priority) { }

	// RVA: 0x27E4EF0 Offset: 0x27E4FF1 VA: 0x27E4EF0
	public static extern bool SetHttpThreadPriority(uint httpThreadPriority) { }

	// RVA: 0x27E4F10 Offset: 0x27E5011 VA: 0x27E4F10
	public static extern bool SetUserHandle(UserHandle userHandle) { }
}

