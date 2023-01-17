// Namespace: NexPlugin
internal static class Detail // TypeDefIndex: 14856
{
	// Fields
	public const string DLL_NAME = "__Internal";
	private static List<NotificationEventCB> s_NotificationEventCB; // 0x0
	private static Dictionary<uint, object> s_NexAsyncCall; // 0x8
	private static uint m_AsyncId; // 0x10

	// Methods

	// RVA: 0x2371020 Offset: 0x2371121 VA: 0x2371020
	public static void GetAsyncResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x23710C0 Offset: 0x23711C1 VA: 0x23710C0
	public static bool RegisterNotificationEventHandler(NotificationEventCB callback) { }

	// RVA: 0x23711B0 Offset: 0x23712B1 VA: 0x23711B0
	public static bool UnregisterNotificationEventHandler(NotificationEventCB callback) { }

	// RVA: 0x2371240 Offset: 0x2371341 VA: 0x2371240
	public static void NotificationEventListCallback(List<NotificationEvent> notificationEventList) { }

	// RVA: 0x2371510 Offset: 0x2371611 VA: 0x2371510
	public static void AddNexResultCallback(uint asyncId, object callback) { }

	// RVA: 0x23715B0 Offset: 0x23716B1 VA: 0x23715B0
	public static void AsyncResultCallback(ref List<Detail.AsyncResultInt> AsyncResultList) { }

	// RVA: 0x2371C50 Offset: 0x2371D51 VA: 0x2371C50
	public static uint PublishAsyncId() { }

	// RVA: 0x2371D20 Offset: 0x2371E21 VA: 0x2371D20
	public static int GetNexAsyncCallCount() { }

	// RVA: 0x2371DA0 Offset: 0x2371EA1 VA: 0x2371DA0
	public static void DumpNexAsyncCallList() { }

	// RVA: 0x2371DB0 Offset: 0x2371EB1 VA: 0x2371DB0
	public static void NP_LOG(string str) { }

	// RVA: 0x2371C40 Offset: 0x2371D41 VA: 0x2371C40
	public static void NP_LOG(string format, object[] arg) { }

	// RVA: -1 Offset: -1
	public static T ExchangePtrToStruct<T>(IntPtr src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229F580 Offset: 0x229F681 VA: 0x229F580
	|-Detail.ExchangePtrToStruct<DataStoreRatingInfo>
	|
	|-RVA: 0x229F6A0 Offset: 0x229F7A1 VA: 0x229F6A0
	|-Detail.ExchangePtrToStruct<NpDateTime>
	|
	|-RVA: 0x229F7B0 Offset: 0x229F8B1 VA: 0x229F7B0
	|-Detail.ExchangePtrToStruct<object>
	|
	|-RVA: 0x229F8C0 Offset: 0x229F9C1 VA: 0x229F8C0
	|-Detail.ExchangePtrToStruct<Ranking2EstimateScoreRankOutput>
	|
	|-RVA: 0x229F9E0 Offset: 0x229FAE1 VA: 0x229F9E0
	|-Detail.ExchangePtrToStruct<RankingStats>
	|
	|-RVA: 0x229FB10 Offset: 0x229FC11 VA: 0x229FB10
	|-Detail.ExchangePtrToStruct<Detail.CppArray>
	|
	|-RVA: 0x229FC30 Offset: 0x229FD31 VA: 0x229FC30
	|-Detail.ExchangePtrToStruct<Detail.NotificationEventInt>
	|
	|-RVA: 0x229FD60 Offset: 0x229FE61 VA: 0x229FD60
	|-Detail.ExchangePtrToStruct<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x229FE80 Offset: 0x229FF81 VA: 0x229FE80
	|-Detail.ExchangePtrToStruct<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x229FFA0 Offset: 0x22A00A1 VA: 0x229FFA0
	|-Detail.ExchangePtrToStruct<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x22A00C0 Offset: 0x22A01C1 VA: 0x22A00C0
	|-Detail.ExchangePtrToStruct<Detail.DataStore.DataStoreRatingLogInt>
	|
	|-RVA: 0x22A01E0 Offset: 0x22A02E1 VA: 0x22A01E0
	|-Detail.ExchangePtrToStruct<Detail.DataStore.DataStoreSearchResultInt>
	|
	|-RVA: 0x22A0300 Offset: 0x22A0401 VA: 0x22A0300
	|-Detail.ExchangePtrToStruct<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x22A0430 Offset: 0x22A0531 VA: 0x22A0430
	|-Detail.ExchangePtrToStruct<Detail.Ranking.RankingResultInt>
	|
	|-RVA: 0x22A0550 Offset: 0x22A0651 VA: 0x22A0550
	|-Detail.ExchangePtrToStruct<Detail.Ranking2.Ranking2CategorySettingInt>
	|
	|-RVA: 0x22A0670 Offset: 0x22A0771 VA: 0x22A0670
	|-Detail.ExchangePtrToStruct<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x22A07B0 Offset: 0x22A08B1 VA: 0x22A07B0
	|-Detail.ExchangePtrToStruct<Detail.Ranking2.Ranking2CommonDataInt>
	|
	|-RVA: 0x22A08D0 Offset: 0x22A09D1 VA: 0x22A08D0
	|-Detail.ExchangePtrToStruct<Detail.Ranking2.Ranking2InfoInt>
	|
	|-RVA: 0x22A09F0 Offset: 0x22A0AF1 VA: 0x22A09F0
	|-Detail.ExchangePtrToStruct<Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatJoinRoomResultInt>
	|
	|-RVA: 0x22A0B00 Offset: 0x22A0C01 VA: 0x22A0B00
	|-Detail.ExchangePtrToStruct<Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatShowAppPageResultInt>
	|
	|-RVA: 0x22A0C10 Offset: 0x22A0D11 VA: 0x22A0C10
	|-Detail.ExchangePtrToStruct<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x22A0D40 Offset: 0x22A0E41 VA: 0x22A0D40
	|-Detail.ExchangePtrToStruct<Detail.Utility.UniqueIdInfoInt>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr CopyStruct<T>(T[] param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229F1C0 Offset: 0x229F2C1 VA: 0x229F1C0
	|-Detail.CopyStruct<byte>
	|
	|-RVA: 0x229F3A0 Offset: 0x229F4A1 VA: 0x229F3A0
	|-Detail.CopyStruct<object>
	*/

	// RVA: 0x2371DC0 Offset: 0x2371EC1 VA: 0x2371DC0
	private static void .cctor() { }
}

