// Namespace: NexPlugin
public static class Subscriber // TypeDefIndex: 14955
{
	// Fields
	public const uint MAX_TOPIC_CONTENT_SIZE = 100;
	public const uint MAX_TIMELINE_CONTENT_SIZE = 100;
	public const uint MAX_FOLLOWING_SIZE = 20;
	public const uint NUM_RESERVED_TOPICS = 128;
	public const uint INVALID_RESERVED_TOPIC_NUM = 4294967295;
	public const uint MAX_GET_FOLLOWER_SIZE = 1000;
	public const uint MAX_CONTENT_MESSAGE_LEN = 140;
	public const uint MAX_CONTENT_BINARY_SIZE = 256;
	public const uint MAX_POST_CONTENT_TOPIC_SIZE = 10;
	public const uint MAX_GET_CONTENT_PARAMS_SIZE = 3;
	public const byte STATUS_KEY_SIZE = 8;
	public const uint MAX_STATUS_BINARY_SIZE = 128;
	public const uint MAX_GET_STATUS_USER_SIZE = 100;
	public const uint DEFAULT_RMC_INTERVAL = 5000;

	// Methods

	// RVA: 0x2927320 Offset: 0x2927421 VA: 0x2927320
	public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0, Subscriber.PostContentCB callback) { }

	// RVA: 0x2927330 Offset: 0x2927431 VA: 0x2927330
	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0, Subscriber.GetContentCB callback) { }

	// RVA: 0x2927340 Offset: 0x2927441 VA: 0x2927340
	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0, Subscriber.GetContentsCB callback) { }

	// RVA: 0x2927350 Offset: 0x2927451 VA: 0x2927350
	public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x2927360 Offset: 0x2927461 VA: 0x2927360
	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x2927370 Offset: 0x2927471 VA: 0x2927370
	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x2927380 Offset: 0x2927481 VA: 0x2927380
	public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x2927390 Offset: 0x2927491 VA: 0x2927390
	public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify = False, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x29273A0 Offset: 0x29274A1 VA: 0x29273A0
	public static extern bool EnableFriendUserStatusesCache(IntPtr pNgsFacade) { }

	// RVA: 0x29273C0 Offset: 0x29274C1 VA: 0x29273C0
	public static extern bool DisableFriendUserStatusesCache(IntPtr pNgsFacade) { }

	// RVA: 0x29273E0 Offset: 0x29274E1 VA: 0x29273E0
	public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result) { }

	// RVA: 0x29273F0 Offset: 0x29274F1 VA: 0x29273F0
	public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result) { }

	// RVA: 0x2927400 Offset: 0x2927501 VA: 0x2927400
	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result) { }

	// RVA: 0x2927410 Offset: 0x2927511 VA: 0x2927410
	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result) { }

	// RVA: 0x2927420 Offset: 0x2927521 VA: 0x2927420
	public static extern bool GetUserStatusRevision(IntPtr pNgsFacade, out uint revision) { }
}

