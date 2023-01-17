// Namespace: 
public struct Detail.AsyncResultInt // TypeDefIndex: 14790
{
	// Fields
	private long pad; // 0x0
	public uint asyncId; // 0x8
	public AsyncResultNum asyncNum; // 0xC
	public Result nnResult; // 0x10
	public uint netErrCode; // 0x14
	public int returnCode; // 0x18
	public uint errorCode; // 0x1C
	public IntPtr pParam1; // 0x20
	public IntPtr pParam2; // 0x28

	// Methods

	// RVA: 0x1E1BD20 Offset: 0x1E1BE21 VA: 0x1E1BD20
	public static AsyncResult GetAsyncResult(Detail.AsyncResultInt res) { }

	// RVA: 0x1E1BDC0 Offset: 0x1E1BEC1 VA: 0x1E1BDC0
	public long GetLong(IntPtr pParam) { }

	// RVA: 0x1E1BE60 Offset: 0x1E1BF61 VA: 0x1E1BE60
	public ulong GetUlong(IntPtr pParam) { }

	// RVA: 0x1E1BF00 Offset: 0x1E1C001 VA: 0x1E1BF00
	public int GetInt(IntPtr pParam) { }

	// RVA: 0x1E1BFA0 Offset: 0x1E1C0A1 VA: 0x1E1BFA0
	public uint GetUint(IntPtr pParam) { }

	// RVA: 0x1E1C040 Offset: 0x1E1C141 VA: 0x1E1C040
	public void Trace() { }

	// RVA: 0x1E1C050 Offset: 0x1E1C151 VA: 0x1E1C050 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public struct Detail.NotificationEventInt : Detail.IExchangeList<NotificationEvent> // TypeDefIndex: 14791
{
	// Fields
	public ulong param1; // 0x0
	public ulong param2; // 0x8
	public uint type; // 0x10
	public uint subType; // 0x14
	public Detail.CppArray stringParam; // 0x18
	public ulong pid; // 0x28

	// Methods

	// RVA: 0x1EF37D0 Offset: 0x1EF38D1 VA: 0x1EF37D0
	public static NotificationEvent ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1EF3910 Offset: 0x1EF3A11 VA: 0x1EF3910 Slot: 4
	public NotificationEvent ExchangeStruct() { }
}

// Namespace: 
public static class Detail.Common // TypeDefIndex: 14792
{
	// Methods

	// RVA: 0x1E1C2B0 Offset: 0x1E1C3B1 VA: 0x1E1C2B0
	private static extern bool InitializeNexAsyncInt(uint asyncId, int threadMode) { }

	// RVA: 0x1E1C2D0 Offset: 0x1E1C3D1 VA: 0x1E1C2D0
	public static bool InitializeNexAsync(out uint asyncId, Common.ThreadMode threadMode, AsyncResultCB callback) { }

	// RVA: 0x1E1C390 Offset: 0x1E1C491 VA: 0x1E1C390
	private static extern bool FinalizeNexAsyncInt(uint asyncId) { }

	// RVA: 0x1E1C3B0 Offset: 0x1E1C4B1 VA: 0x1E1C3B0
	public static bool FinalizeNexAsync(out uint asyncId, AsyncResultCB callback) { }

	// RVA: 0x1E1C460 Offset: 0x1E1C561 VA: 0x1E1C460
	public static extern void SetTerminateImmediately(uint terminate) { }

	// RVA: 0x1E1C470 Offset: 0x1E1C571 VA: 0x1E1C470
	private static extern uint DispatchInt(uint dispatchTimeout, uint dispatchFlags) { }

	// RVA: 0x1E1C480 Offset: 0x1E1C581 VA: 0x1E1C480
	public static uint Dispatch(uint dispatchTimeout, Nullable<Common.DispachFlag> dispatchFlags) { }

	// RVA: 0x1E1C510 Offset: 0x1E1C611 VA: 0x1E1C510
	public static extern void DispatchAll() { }

	// RVA: 0x1E1C520 Offset: 0x1E1C621 VA: 0x1E1C520
	public static extern uint GetReadyJobsSize() { }

	// RVA: 0x1E1C530 Offset: 0x1E1C631 VA: 0x1E1C530
	private static extern bool UpdateAsyncResultInt(ref IntPtr pAsyncResult) { }

	// RVA: 0x1E1C550 Offset: 0x1E1C651 VA: 0x1E1C550
	public static bool UpdateAsyncResult() { }

	// RVA: 0x1E1C8E0 Offset: 0x1E1C9E1 VA: 0x1E1C8E0
	public static extern void InitAsyncResultByAsyncId(uint asyncId) { }

	// RVA: 0x1E1C8F0 Offset: 0x1E1C9F1 VA: 0x1E1C8F0
	public static void Wait(uint dispatchTimeOut, Nullable<Common.DispachFlag> dispatchFlags) { }

	// RVA: 0x1E1C9C0 Offset: 0x1E1CAC1 VA: 0x1E1C9C0
	private static extern bool GetNotificationEventInt(ref IntPtr pNotificationEvent) { }

	// RVA: 0x1E1C760 Offset: 0x1E1C861 VA: 0x1E1C760
	public static bool GetNotificationEvent() { }

	// RVA: 0x1E1C9E0 Offset: 0x1E1CAE1 VA: 0x1E1C9E0
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
public interface Detail.IExchangeList<T> // TypeDefIndex: 14793
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T ExchangeStruct();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Detail.IExchangeList<object>.ExchangeStruct
	*/
}

// Namespace: 
public struct Detail.CppArray // TypeDefIndex: 14794
{
	// Fields
	public int count; // 0x0
	public IntPtr ptr; // 0x8

	// Methods

	// RVA: 0x1E1C6D0 Offset: 0x1E1C7D1 VA: 0x1E1C6D0
	public void .ctor(IntPtr src) { }

	// RVA: -1 Offset: -1
	public void ToArray<T>(ref T[] list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38842C0 Offset: 0x38843C1 VA: 0x38842C0
	|-Detail.CppArray.ToArray<object>
	*/

	// RVA: -1 Offset: -1
	public void ToList<T>(ref List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38867D0 Offset: 0x38868D1 VA: 0x38867D0
	|-Detail.CppArray.ToList<byte>
	|
	|-RVA: 0x38869D0 Offset: 0x3886AD1 VA: 0x38869D0
	|-Detail.CppArray.ToList<DataStoreRatingInfo>
	|
	|-RVA: 0x3886BF0 Offset: 0x3886CF1 VA: 0x3886BF0
	|-Detail.CppArray.ToList<DataStoreResult>
	|
	|-RVA: 0x3886DF0 Offset: 0x3886EF1 VA: 0x3886DF0
	|-Detail.CppArray.ToList<object>
	|
	|-RVA: 0x3886FF0 Offset: 0x38870F1 VA: 0x3886FF0
	|-Detail.CppArray.ToList<uint>
	|
	|-RVA: 0x38871F0 Offset: 0x38872F1 VA: 0x38871F0
	|-Detail.CppArray.ToList<ulong>
	|
	|-RVA: 0x38873F0 Offset: 0x38874F1 VA: 0x38873F0
	|-Detail.CppArray.ToList<Detail.AsyncResultInt>
	|
	|-RVA: 0x3887610 Offset: 0x3887711 VA: 0x3887610
	|-Detail.CppArray.ToList<Detail.CppArray>
	|
	|-RVA: 0x3887810 Offset: 0x3887911 VA: 0x3887810
	|-Detail.CppArray.ToList<Detail.NotificationEventInt>
	|
	|-RVA: 0x3887A30 Offset: 0x3887B31 VA: 0x3887A30
	|-Detail.CppArray.ToList<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x3887C50 Offset: 0x3887D51 VA: 0x3887C50
	|-Detail.CppArray.ToList<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x3887E70 Offset: 0x3887F71 VA: 0x3887E70
	|-Detail.CppArray.ToList<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x3888090 Offset: 0x3888191 VA: 0x3888090
	|-Detail.CppArray.ToList<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x38882C0 Offset: 0x38883C1 VA: 0x38882C0
	|-Detail.CppArray.ToList<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x38884F0 Offset: 0x38885F1 VA: 0x38884F0
	|-Detail.CppArray.ToList<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x3888730 Offset: 0x3888831 VA: 0x3888730
	|-Detail.CppArray.ToList<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x3888960 Offset: 0x3888A61 VA: 0x3888960
	|-Detail.CppArray.ToList<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x3888B90 Offset: 0x3888C91 VA: 0x3888B90
	|-Detail.CppArray.ToList<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x3888DB0 Offset: 0x3888EB1 VA: 0x3888DB0
	|-Detail.CppArray.ToList<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x3888FB0 Offset: 0x38890B1 VA: 0x3888FB0
	|-Detail.CppArray.ToList<Detail.Utility.UniqueIdInfoInt>
	*/

	// RVA: -1 Offset: -1
	public List<T> ToList<T, U>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3884AE0 Offset: 0x3884BE1 VA: 0x3884AE0
	|-Detail.CppArray.ToList<DataStoreMetaInfo, Detail.DataStore.DataStoreMetaInfoInt>
	|-Detail.CppArray.ToList<object, Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x3884DC0 Offset: 0x3884EC1 VA: 0x3884DC0
	|-Detail.CppArray.ToList<DataStorePasswordInfo, Detail.DataStore.DataStorePasswordInfoInt>
	|-Detail.CppArray.ToList<object, Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x3885060 Offset: 0x3885161 VA: 0x3885060
	|-Detail.CppArray.ToList<DataStorePersistenceInfo, Detail.DataStore.DataStorePersistenceInfoInt>
	|-Detail.CppArray.ToList<object, Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x3884800 Offset: 0x3884901 VA: 0x3884800
	|-Detail.CppArray.ToList<NotificationEvent, Detail.NotificationEventInt>
	|-Detail.CppArray.ToList<object, Detail.NotificationEventInt>
	|
	|-RVA: 0x3884530 Offset: 0x3884631 VA: 0x3884530
	|-Detail.CppArray.ToList<object, object>
	|
	|-RVA: 0x3885300 Offset: 0x3885401 VA: 0x3885300
	|-Detail.CppArray.ToList<object, Detail.Ranking.RankingCachedResultInt>
	|-Detail.CppArray.ToList<RankingCachedResult, Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x3885600 Offset: 0x3885701 VA: 0x3885600
	|-Detail.CppArray.ToList<object, Detail.Ranking.RankingRankDataInt>
	|-Detail.CppArray.ToList<RankingRankData, Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x3885900 Offset: 0x3885A01 VA: 0x3885900
	|-Detail.CppArray.ToList<object, Detail.Ranking2.Ranking2ChartInfoInt>
	|-Detail.CppArray.ToList<Ranking2ChartInfo, Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x3885C50 Offset: 0x3885D51 VA: 0x3885C50
	|-Detail.CppArray.ToList<object, Detail.Ranking2.Ranking2RankDataInt>
	|-Detail.CppArray.ToList<Ranking2RankData, Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x3885F50 Offset: 0x3886051 VA: 0x3885F50
	|-Detail.CppArray.ToList<object, Detail.Subscriber.SubscriberContentInt>
	|-Detail.CppArray.ToList<SubscriberContent, Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x3886280 Offset: 0x3886381 VA: 0x3886280
	|-Detail.CppArray.ToList<object, Detail.Subscriber.SubscriberUserStatusInfoInt>
	|-Detail.CppArray.ToList<SubscriberUserStatusInfo, Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x3886550 Offset: 0x3886651 VA: 0x3886550
	|-Detail.CppArray.ToList<object, Detail.Utility.UniqueIdInfoInt>
	|-Detail.CppArray.ToList<UniqueIdInfo, Detail.Utility.UniqueIdInfoInt>
	*/

	// RVA: 0x1E1CA80 Offset: 0x1E1CB81 VA: 0x1E1CA80
	public string ToStr() { }

	// RVA: 0x1E1CB40 Offset: 0x1E1CC41 VA: 0x1E1CB40
	public static Detail.CppArray StringToArray(List<IntPtr> useptr, string param) { }

	// RVA: 0x1E1CC80 Offset: 0x1E1CD81 VA: 0x1E1CC80
	public static Detail.CppArray StringsToArray(List<IntPtr> useptr, List<string> param) { }

	// RVA: -1 Offset: -1
	public static Detail.CppArray ArrayToArray<T>(List<IntPtr> useptr, T[] param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x387A930 Offset: 0x387AA31 VA: 0x387A930
	|-Detail.CppArray.ArrayToArray<byte>
	|
	|-RVA: 0x387AB40 Offset: 0x387AC41 VA: 0x387AB40
	|-Detail.CppArray.ArrayToArray<object>
	*/

	// RVA: -1 Offset: -1
	public static Detail.CppArray ListToArray<T>(List<IntPtr> useptr, List<T> param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x387AD50 Offset: 0x387AE51 VA: 0x387AD50
	|-Detail.CppArray.ListToArray<byte>
	|
	|-RVA: 0x387AFC0 Offset: 0x387B0C1 VA: 0x387AFC0
	|-Detail.CppArray.ListToArray<object>
	|
	|-RVA: 0x387B230 Offset: 0x387B331 VA: 0x387B230
	|-Detail.CppArray.ListToArray<Ranking2ChartInfoInput>
	|
	|-RVA: 0x387B4A0 Offset: 0x387B5A1 VA: 0x387B4A0
	|-Detail.CppArray.ListToArray<ushort>
	|
	|-RVA: 0x387B710 Offset: 0x387B811 VA: 0x387B710
	|-Detail.CppArray.ListToArray<uint>
	|
	|-RVA: 0x387B980 Offset: 0x387BA81 VA: 0x387B980
	|-Detail.CppArray.ListToArray<ulong>
	|
	|-RVA: 0x387BBF0 Offset: 0x387BCF1 VA: 0x387BBF0
	|-Detail.CppArray.ListToArray<Detail.CppArray>
	|
	|-RVA: 0x387BE70 Offset: 0x387BF71 VA: 0x387BE70
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x387C110 Offset: 0x387C211 VA: 0x387C110
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x387C390 Offset: 0x387C491 VA: 0x387C390
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x387C630 Offset: 0x387C731 VA: 0x387C630
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x387C8D0 Offset: 0x387C9D1 VA: 0x387C8D0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x387CB50 Offset: 0x387CC51 VA: 0x387CB50
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x387CDE0 Offset: 0x387CEE1 VA: 0x387CDE0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x387D060 Offset: 0x387D161 VA: 0x387D060
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x387D2E0 Offset: 0x387D3E1 VA: 0x387D2E0
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x387D5A0 Offset: 0x387D6A1 VA: 0x387D5A0
	|-Detail.CppArray.ListToArray<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x387D820 Offset: 0x387D921 VA: 0x387D820
	|-Detail.CppArray.ListToArray<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x387DAB0 Offset: 0x387DBB1 VA: 0x387DAB0
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x387DD40 Offset: 0x387DE41 VA: 0x387DD40
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x387DFD0 Offset: 0x387E0D1 VA: 0x387DFD0
	|-Detail.CppArray.ListToArray<Detail.Utility.UniqueIdInfoInt>
	*/

	// RVA: -1 Offset: -1
	public static Detail.CppArray ListToArray<U, T>(List<IntPtr> useptr, List<T> param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x387E250 Offset: 0x387E351 VA: 0x387E250
	|-Detail.CppArray.ListToArray<object, object>
	|
	|-RVA: 0x387E910 Offset: 0x387EA11 VA: 0x387E910
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreChangeMetaParamInt, DataStoreChangeMetaParam>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreChangeMetaParamInt, object>
	|
	|-RVA: 0x387F000 Offset: 0x387F101 VA: 0x387F000
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreDeleteParamInt, DataStoreDeleteParam>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreDeleteParamInt, object>
	|
	|-RVA: 0x387F6D0 Offset: 0x387F7D1 VA: 0x387F6D0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreGetMetaParamInt, DataStoreGetMetaParam>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreGetMetaParamInt, object>
	|
	|-RVA: 0x387FDD0 Offset: 0x387FED1 VA: 0x387FDD0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStorePreparePostParamInt, DataStorePreparePostParam>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStorePreparePostParamInt, object>
	|
	|-RVA: 0x38804D0 Offset: 0x38805D1 VA: 0x38804D0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRateObjectParamInt, DataStoreRateObjectParam>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRateObjectParamInt, object>
	|
	|-RVA: 0x3880BA0 Offset: 0x3880CA1 VA: 0x3880BA0
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRatingTargetInt, DataStoreRatingTarget>
	|-Detail.CppArray.ListToArray<Detail.DataStore.DataStoreRatingTargetInt, object>
	|
	|-RVA: 0x3881270 Offset: 0x3881371 VA: 0x3881270
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingOrderParamInt, object>
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingOrderParamInt, RankingOrderParam>
	|
	|-RVA: 0x3881940 Offset: 0x3881A41 VA: 0x3881940
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingRankDataInt, object>
	|-Detail.CppArray.ListToArray<Detail.Ranking.RankingRankDataInt, RankingRankData>
	|
	|-RVA: 0x3882050 Offset: 0x3882151 VA: 0x3882050
	|-Detail.CppArray.ListToArray<Detail.Ranking2.Ranking2ScoreDataInt, object>
	|-Detail.CppArray.ListToArray<Detail.Ranking2.Ranking2ScoreDataInt, Ranking2ScoreData>
	|
	|-RVA: 0x3882720 Offset: 0x3882821 VA: 0x3882720
	|-Detail.CppArray.ListToArray<Detail.Screening.ScreeningContextInfoInt, object>
	|-Detail.CppArray.ListToArray<Detail.Screening.ScreeningContextInfoInt, ScreeningContextInfo>
	|
	|-RVA: 0x3882E10 Offset: 0x3882F11 VA: 0x3882E10
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberGetContentParamInt, object>
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberGetContentParamInt, SubscriberGetContentParam>
	|
	|-RVA: 0x3883500 Offset: 0x3883601 VA: 0x3883500
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberUserStatusParamInt, object>
	|-Detail.CppArray.ListToArray<Detail.Subscriber.SubscriberUserStatusParamInt, SubscriberUserStatusParam>
	|
	|-RVA: 0x3883BF0 Offset: 0x3883CF1 VA: 0x3883BF0
	|-Detail.CppArray.ListToArray<Detail.Utility.UniqueIdInfoInt, object>
	|-Detail.CppArray.ListToArray<Detail.Utility.UniqueIdInfoInt, UniqueIdInfo>
	*/
}

// Namespace: 
private struct Detail.DataStore.DataStorePersistenceInfoInt : Detail.IExchangeList<DataStorePersistenceInfo> // TypeDefIndex: 14795
{
	// Fields
	private ulong dataId; // 0x0
	private ulong principalId; // 0x8
	private ushort persistenceSlotId; // 0x10

	// Methods

	// RVA: 0x1DC5A20 Offset: 0x1DC5B21 VA: 0x1DC5A20 Slot: 4
	public DataStorePersistenceInfo ExchangeStruct() { }

	// RVA: 0x1DC5AA0 Offset: 0x1DC5BA1 VA: 0x1DC5AA0
	public static DataStorePersistenceInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC5B90 Offset: 0x1DC5C91 VA: 0x1DC5B90
	public void .ctor(DataStorePersistenceInfo param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePasswordInfoInt : Detail.IExchangeList<DataStorePasswordInfo> // TypeDefIndex: 14796
{
	// Fields
	private ulong dataId; // 0x0
	private ulong accessPassword; // 0x8
	private ulong updatePassword; // 0x10

	// Methods

	// RVA: 0x1DC5830 Offset: 0x1DC5931 VA: 0x1DC5830 Slot: 4
	public DataStorePasswordInfo ExchangeStruct() { }

	// RVA: 0x1DC58B0 Offset: 0x1DC59B1 VA: 0x1DC58B0
	public static DataStorePasswordInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC59A0 Offset: 0x1DC5AA1 VA: 0x1DC59A0
	public void .ctor(DataStorePasswordInfo param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePermissionInt : Detail.IExchangeList<DataStorePermission> // TypeDefIndex: 14797
{
	// Fields
	private Detail.CppArray recipientIds; // 0x0
	private uint permission; // 0x10

	// Methods

	// RVA: 0x1DC5740 Offset: 0x1DC5841 VA: 0x1DC5740 Slot: 4
	public DataStorePermission ExchangeStruct() { }

	// RVA: 0x1DC4D00 Offset: 0x1DC4E01 VA: 0x1DC4D00
	public void .ctor(List<IntPtr> useptr, DataStorePermission param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreMetaInfoInt : Detail.IExchangeList<DataStoreMetaInfo> // TypeDefIndex: 14798
{
	// Fields
	private ulong dataId; // 0x0
	private ulong ownerId; // 0x8
	private uint size; // 0x10
	private ushort dataType; // 0x14
	private ushort period; // 0x16
	private uint status; // 0x18
	private uint referDataId; // 0x1C
	private uint flag; // 0x20
	private Detail.DataStore.DataStorePermissionInt accessPermission; // 0x28
	private Detail.DataStore.DataStorePermissionInt updatePermission; // 0x40
	private Detail.CppArray name; // 0x58
	private Detail.CppArray meta; // 0x68
	private Detail.CppArray tags; // 0x78
	private Detail.CppArray ratingInfo; // 0x88
	private NpDateTime createdTime; // 0x98
	private NpDateTime updatedTime; // 0xA0
	private NpDateTime expireTime; // 0xA8

	// Methods

	// RVA: 0x1DC5230 Offset: 0x1DC5331 VA: 0x1DC5230
	public static DataStoreMetaInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC5310 Offset: 0x1DC5411 VA: 0x1DC5310 Slot: 4
	public DataStoreMetaInfo ExchangeStruct() { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreSearchResultInt // TypeDefIndex: 14799
{
	// Fields
	private Detail.CppArray result; // 0x0
	private uint totalCount; // 0x10
	private uint totalCountType; // 0x14

	// Methods

	// RVA: 0x1DC66C0 Offset: 0x1DC67C1 VA: 0x1DC66C0
	public static DataStoreSearchResult ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreRatingLogInt // TypeDefIndex: 14800
{
	// Fields
	private NpDateTime lockExpirationTime; // 0x0
	private ulong pid; // 0x8
	private int ratingValue; // 0x10
	private bool isRated; // 0x14

	// Methods

	// RVA: 0x1DC6350 Offset: 0x1DC6451 VA: 0x1DC6350
	public static DataStoreRatingLog ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePersistenceInitParamInt // TypeDefIndex: 14801
{
	// Fields
	private ushort persistenceSlotId; // 0x0
	private byte deleteLastObject; // 0x2

	// Methods

	// RVA: 0x1DC5C10 Offset: 0x1DC5D11 VA: 0x1DC5C10
	public void .ctor(DataStorePersistenceInitParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreRatingInitParamInt // TypeDefIndex: 14802
{
	// Fields
	private long initialValue; // 0x0
	private int rangeMin; // 0x8
	private int rangeMax; // 0xC
	private int flag; // 0x10
	private int internalFlag; // 0x14
	private int lockType; // 0x18
	private short periodDuration; // 0x1C
	private sbyte periodHour; // 0x1E
	private sbyte slot; // 0x1F

	// Methods

	// RVA: 0x1DC61A0 Offset: 0x1DC62A1 VA: 0x1DC61A0
	public void .ctor(DataStoreRatingInitParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePreparePostParamInt // TypeDefIndex: 14803
{
	// Fields
	private Detail.DataStore.DataStorePermissionInt accessPermission; // 0x0
	private Detail.DataStore.DataStorePermissionInt updatePermission; // 0x18
	private Detail.DataStore.DataStorePersistenceInitParamInt persistenceInitParam; // 0x30
	private Detail.CppArray name; // 0x38
	private Detail.CppArray tags; // 0x48
	private Detail.CppArray ratingInitParams; // 0x58
	private Detail.CppArray meta; // 0x68
	private uint size; // 0x78
	private uint dataFlag; // 0x7C
	private ushort dataType; // 0x80
	private ushort period; // 0x82

	// Methods

	// RVA: 0x1DC5D70 Offset: 0x1DC5E71 VA: 0x1DC5D70
	public void .ctor(List<IntPtr> useptr, DataStorePreparePostParam param, uint size) { }

	// RVA: 0x1DC5DA0 Offset: 0x1DC5EA1 VA: 0x1DC5DA0
	public void .ctor(List<IntPtr> useptr, DataStorePreparePostParam param) { }
}

// Namespace: 
private struct Detail.DataStore.ResultRangeInt // TypeDefIndex: 14804
{
	// Fields
	private uint offset; // 0x0
	private uint size; // 0x4

	// Methods

	// RVA: 0x1DC6640 Offset: 0x1DC6741 VA: 0x1DC6640
	public void .ctor(ResultRange param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreSearchParamInt // TypeDefIndex: 14805
{
	// Fields
	private uint searchType; // 0x0
	private uint ownerType; // 0x4
	private Detail.CppArray ownerIds; // 0x8
	private Detail.CppArray destinationIds; // 0x18
	private NpDateTime createdAfter; // 0x28
	private NpDateTime createdBefore; // 0x30
	private NpDateTime updatedAfter; // 0x38
	private NpDateTime updatedBefore; // 0x40
	private uint sortOrderColumn; // 0x48
	private uint sortOrder; // 0x4C
	private Detail.DataStore.ResultRangeInt resultRange; // 0x50
	private Detail.CppArray tags; // 0x58
	private uint resultOption; // 0x68
	private uint minimalRatingFrequency; // 0x6C
	private int totalCountEnabled; // 0x70
	private int useCache; // 0x74
	private Detail.CppArray dataTypes; // 0x78

	// Methods

	// RVA: 0x1DC64C0 Offset: 0x1DC65C1 VA: 0x1DC64C0
	public void .ctor(List<IntPtr> useptr, DataStoreSearchParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreDeleteParamInt // TypeDefIndex: 14806
{
	// Fields
	private ulong dataId; // 0x0
	private ulong updatePassword; // 0x8

	// Methods

	// RVA: 0x1DC50C0 Offset: 0x1DC51C1 VA: 0x1DC50C0
	public void .ctor(DataStoreDeleteParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePrepareUpdateParamInt // TypeDefIndex: 14807
{
	// Fields
	private ulong dataId; // 0x0
	private ulong updatePassword; // 0x8
	private uint size; // 0x10

	// Methods

	// RVA: 0x1DC6250 Offset: 0x1DC6351 VA: 0x1DC6250
	public void .ctor(DataStorePrepareUpdateParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePersistenceTargetInt // TypeDefIndex: 14808
{
	// Fields
	private ulong ownerId; // 0x0
	private ushort persistenceSlotId; // 0x8

	// Methods

	// RVA: 0x1DC5040 Offset: 0x1DC5141 VA: 0x1DC5040
	public void .ctor(DataStorePersistenceTarget param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStorePrepareGetParamInt // TypeDefIndex: 14809
{
	// Fields
	private ulong dataId; // 0x0
	private ulong accessPassword; // 0x8
	private Detail.DataStore.DataStorePersistenceTargetInt persistenceTarget; // 0x10
	private int useDataId; // 0x20

	// Methods

	// RVA: 0x1DC5C90 Offset: 0x1DC5D91 VA: 0x1DC5C90
	public void .ctor(DataStorePrepareGetParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreTouchObjectParamInt // TypeDefIndex: 14810
{
	// Fields
	private ulong dataId; // 0x0
	private ulong accessPassword; // 0x8

	// Methods

	// RVA: 0x1DC67E0 Offset: 0x1DC68E1 VA: 0x1DC67E0
	public void .ctor(DataStoreTouchObjectParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreGetMetaParamInt // TypeDefIndex: 14811
{
	// Fields
	private ulong dataId; // 0x0
	private ulong accessPassword; // 0x8
	private Detail.DataStore.DataStorePersistenceTargetInt persistenceTarget; // 0x10
	private uint resultOption; // 0x20
	private int useDataId; // 0x24

	// Methods

	// RVA: 0x1DC5140 Offset: 0x1DC5241 VA: 0x1DC5140
	public void .ctor(DataStoreGetMetaParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreChangeMetaCompareParamInt // TypeDefIndex: 14812
{
	// Fields
	private Detail.DataStore.DataStorePermissionInt accessPermission; // 0x0
	private Detail.DataStore.DataStorePermissionInt updatePermission; // 0x18
	private Detail.CppArray name; // 0x30
	private Detail.CppArray tags; // 0x40
	private Detail.CppArray metaBinary; // 0x50
	private uint comparisonFlag; // 0x60
	private uint status; // 0x64
	private ushort dataType; // 0x68
	private ushort period; // 0x6A

	// Methods

	// RVA: 0x1DC4B30 Offset: 0x1DC4C31 VA: 0x1DC4B30
	public void .ctor(List<IntPtr> useptr, DataStoreChangeMetaCompareParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreChangeMetaParamInt // TypeDefIndex: 14813
{
	// Fields
	private Detail.DataStore.DataStorePermissionInt accessPermission; // 0x0
	private Detail.DataStore.DataStorePermissionInt updatePermission; // 0x18
	private Detail.CppArray name; // 0x30
	private Detail.CppArray tags; // 0x40
	private Detail.CppArray metaBinary; // 0x50
	private Detail.DataStore.DataStoreChangeMetaCompareParamInt compareParam; // 0x60
	private ulong dataId; // 0xD0
	private ulong updatePassword; // 0xD8
	private uint modifiesFlag; // 0xE0
	private uint dataStatus; // 0xE4
	private Detail.DataStore.DataStorePersistenceTargetInt persistenceTarget; // 0xE8
	private ushort dataType; // 0xF8
	private ushort period; // 0xFA

	// Methods

	// RVA: 0x1DC4DA0 Offset: 0x1DC4EA1 VA: 0x1DC4DA0
	public void .ctor(List<IntPtr> useptr, DataStoreChangeMetaParam param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreRatingTargetInt // TypeDefIndex: 14814
{
	// Fields
	private ulong dataId; // 0x0
	private sbyte slot; // 0x8

	// Methods

	// RVA: 0x1DC6440 Offset: 0x1DC6541 VA: 0x1DC6440
	public void .ctor(DataStoreRatingTarget param) { }
}

// Namespace: 
private struct Detail.DataStore.DataStoreRateObjectParamInt // TypeDefIndex: 14815
{
	// Fields
	private ulong accessPassword; // 0x0
	private int ratingValue; // 0x8

	// Methods

	// RVA: 0x1DC62D0 Offset: 0x1DC63D1 VA: 0x1DC62D0
	public void .ctor(DataStoreRateObjectParam param) { }
}

// Namespace: 
public static class Detail.DataStore // TypeDefIndex: 14816
{
	// Methods

	// RVA: 0x1EED5A0 Offset: 0x1EED6A1 VA: 0x1EED5A0
	private static List<Dictionary<sbyte, DataStoreRatingInfo>> DataStore_ExchangeRatingInfosList(IntPtr src) { }

	// RVA: 0x1EEDA20 Offset: 0x1EEDB21 VA: 0x1EEDA20
	private static extern bool DataStore_PostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStorePreparePostParamInt pParam, IntPtr pUpBuf, int timeOut) { }

	// RVA: -1 Offset: -1
	public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0, DataStore.PostCB callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38891B0 Offset: 0x38892B1 VA: 0x38891B0
	|-Detail.DataStore.PostObjectAsync<byte>
	*/

	// RVA: 0x1EEDA40 Offset: 0x1EEDB41 VA: 0x1EEDA40
	private static extern bool DataStore_PostMetaAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStorePreparePostParamInt pParam, int timeOut) { }

	// RVA: 0x1EEDA60 Offset: 0x1EEDB61 VA: 0x1EEDA60
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0, DataStore.PostCB callback) { }

	// RVA: 0x1EEDD90 Offset: 0x1EEDE91 VA: 0x1EEDD90
	private static extern bool DataStore_PostMetaAsyncByDataID(uint asyncId, IntPtr pNgsFacade, ulong dataId, ref Detail.DataStore.DataStorePreparePostParamInt pParam, int timeOut) { }

	// RVA: 0x1EEDDB0 Offset: 0x1EEDEB1 VA: 0x1EEDDB0
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EEDFF0 Offset: 0x1EEE0F1 VA: 0x1EEDFF0
	private static extern bool DataStore_PostMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref Detail.CppArray dataIds, ref Detail.CppArray param, int transactional, int timeOut) { }

	// RVA: 0x1EEE010 Offset: 0x1EEE111 VA: 0x1EEE010
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<ulong> dataIds, List<DataStorePreparePostParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x1EEE280 Offset: 0x1EEE381 VA: 0x1EEE280
	private static extern bool DataStore_CompleteSuspendedPostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, int timeOut) { }

	// RVA: 0x1EEE2A0 Offset: 0x1EEE3A1 VA: 0x1EEE2A0
	public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EEE4D0 Offset: 0x1EEE5D1 VA: 0x1EEE4D0
	private static extern bool DataStore_SearchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreSearchParamInt pParam, int timeOut) { }

	// RVA: 0x1EEE4F0 Offset: 0x1EEE5F1 VA: 0x1EEE4F0
	public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, DataStore.SearchObjectCB callback) { }

	// RVA: 0x1EEE730 Offset: 0x1EEE831 VA: 0x1EEE730
	private static extern bool DataStore_SearchObjectLightAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreSearchParamInt pParam, int timeOut) { }

	// RVA: 0x1EEE750 Offset: 0x1EEE851 VA: 0x1EEE750
	public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, DataStore.SearchObjectCB callback) { }

	// RVA: 0x1EEE990 Offset: 0x1EEEA91 VA: 0x1EEE990
	private static extern bool DataStore_DeleteObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreDeleteParamInt pParam, int timeOut) { }

	// RVA: 0x1EEE9B0 Offset: 0x1EEEAB1 VA: 0x1EEE9B0
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EEEAB0 Offset: 0x1EEEBB1 VA: 0x1EEEAB0
	private static extern bool DataStore_DeleteObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray param, int transactional, int timeOut) { }

	// RVA: 0x1EEEAD0 Offset: 0x1EEEBD1 VA: 0x1EEEAD0
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x1EEED00 Offset: 0x1EEEE01 VA: 0x1EEED00
	private static extern bool DataStore_UpdateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStorePrepareUpdateParamInt pParam, IntPtr pUpBuf, int timeOut) { }

	// RVA: -1 Offset: -1
	public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0, AsyncResultCB callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889500 Offset: 0x3889601 VA: 0x3889500
	|-Detail.DataStore.UpdateObjectAsync<byte>
	*/

	// RVA: 0x1EEED20 Offset: 0x1EEEE21 VA: 0x1EEED20
	private static extern bool DataStore_GetObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStorePrepareGetParamInt pParam, ulong getBufSize, int timeOut) { }

	// RVA: 0x1EEED40 Offset: 0x1EEEE41 VA: 0x1EEED40
	public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0, DataStore.GetObjectCB callback) { }

	// RVA: 0x1EEEE50 Offset: 0x1EEEF51 VA: 0x1EEEE50
	private static extern bool DataStore_TouchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreTouchObjectParamInt param, int timeOut) { }

	// RVA: 0x1EEEE70 Offset: 0x1EEEF71 VA: 0x1EEEE70
	public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EEEF70 Offset: 0x1EEF071 VA: 0x1EEEF70
	private static extern bool DataStore_GetMetaAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreGetMetaParamInt pParam, int timeOut) { }

	// RVA: 0x1EEEF90 Offset: 0x1EEF091 VA: 0x1EEEF90
	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0, DataStore.GetMetaCB callback) { }

	// RVA: 0x1EEF090 Offset: 0x1EEF191 VA: 0x1EEF090
	private static extern bool DataStore_GetMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref Detail.CppArray dataIds, ref Detail.CppArray param, int timeOut) { }

	// RVA: 0x1EEF0B0 Offset: 0x1EEF1B1 VA: 0x1EEF0B0
	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreGetMetaParam> param, int timeOut = 0, DataStore.GetMetaListCB callback) { }

	// RVA: 0x1EEF310 Offset: 0x1EEF411 VA: 0x1EEF310
	private static extern bool DataStore_ChangeMetaAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreChangeMetaParamInt pParam, int timeOut) { }

	// RVA: 0x1EEF330 Offset: 0x1EEF431 VA: 0x1EEF330
	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EEF590 Offset: 0x1EEF691 VA: 0x1EEF590
	private static extern bool DataStore_ChangeMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref Detail.CppArray dataIds, ref Detail.CppArray param, int transactional, int timeOut) { }

	// RVA: 0x1EEF5B0 Offset: 0x1EEF6B1 VA: 0x1EEF5B0
	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreChangeMetaParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x1EEF820 Offset: 0x1EEF921 VA: 0x1EEF820
	private static extern bool DataStore_RateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreRatingTargetInt pTarget, ref Detail.DataStore.DataStoreRateObjectParamInt pRateParam, int timeOut) { }

	// RVA: 0x1EEF840 Offset: 0x1EEF941 VA: 0x1EEF840
	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x1EEF950 Offset: 0x1EEFA51 VA: 0x1EEF950
	private static extern bool DataStore_RateObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneObjectParam, ref Detail.CppArray target, ref Detail.CppArray param, int transactional, int timeOut) { }

	// RVA: 0x1EEF970 Offset: 0x1EEFA71 VA: 0x1EEF970
	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneObjectParam, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = True, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x1EEFBE0 Offset: 0x1EEFCE1 VA: 0x1EEFBE0
	private static extern bool DataStore_RateObjectWithPostingAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreRatingTargetInt pParam, ref Detail.DataStore.DataStoreRateObjectParamInt pObject, ref Detail.DataStore.DataStorePreparePostParamInt pPostParam, int timeOut) { }

	// RVA: 0x1EEFC00 Offset: 0x1EEFD01 VA: 0x1EEFC00
	public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget pParam, DataStoreRateObjectParam pObject, DataStorePreparePostParam pPostParam, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x1EEFE70 Offset: 0x1EEFF71 VA: 0x1EEFE70
	private static extern bool DataStore_RateObjectsWithPostingAsync(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref Detail.CppArray pParam, ref Detail.CppArray pObject, ref Detail.CppArray pPostParam, int transactional, int timeOut) { }

	// RVA: 0x1EEFE90 Offset: 0x1EEFF91 VA: 0x1EEFE90
	public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<DataStoreRatingTarget> pParam, List<DataStoreRateObjectParam> pObject, List<DataStorePreparePostParam> pPostParam, bool transactional, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x1EF01A0 Offset: 0x1EF02A1 VA: 0x1EF01A0
	private static extern bool DataStore_GetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreRatingTargetInt target, ulong accessPassword, int timeOut) { }

	// RVA: 0x1EF01C0 Offset: 0x1EF02C1 VA: 0x1EF01C0
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x1EF02C0 Offset: 0x1EF03C1 VA: 0x1EF02C0
	private static extern bool DataStore_GetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut) { }

	// RVA: 0x1EF02E0 Offset: 0x1EF03E1 VA: 0x1EF02E0
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, DataStore.RatingInfoAllSlotCB callback) { }

	// RVA: 0x1EF03C0 Offset: 0x1EF04C1 VA: 0x1EF03C0
	private static extern bool DataStore_GetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray dataIds, int timeOut) { }

	// RVA: 0x1EF03E0 Offset: 0x1EF04E1 VA: 0x1EF03E0
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, DataStore.RatingInfosListCB callback) { }

	// RVA: 0x1EF0610 Offset: 0x1EF0711 VA: 0x1EF0610
	private static extern bool DataStore_GetRatingWithLogAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreRatingTargetInt target, ulong accessPassword, int timeOut) { }

	// RVA: 0x1EF0630 Offset: 0x1EF0731 VA: 0x1EF0630
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, DataStore.RatingInfoWithLogCB callback) { }

	// RVA: 0x1EF0730 Offset: 0x1EF0831 VA: 0x1EF0730
	private static extern bool DataStore_ResetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.DataStore.DataStoreRatingTargetInt target, ulong accessPassword, int timeOut) { }

	// RVA: 0x1EF0750 Offset: 0x1EF0851 VA: 0x1EF0750
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF0850 Offset: 0x1EF0951 VA: 0x1EF0850
	private static extern bool DataStore_ResetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut) { }

	// RVA: 0x1EF0870 Offset: 0x1EF0971 VA: 0x1EF0870
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF0950 Offset: 0x1EF0A51 VA: 0x1EF0950
	private static extern bool DataStore_ResetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray dataIds, int transactional, int timeOut) { }

	// RVA: 0x1EF0970 Offset: 0x1EF0A71 VA: 0x1EF0970
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x1EF0BA0 Offset: 0x1EF0CA1 VA: 0x1EF0BA0
	private static extern bool DataStore_GetPersistenceInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort slotId, int timeOut) { }

	// RVA: 0x1EF0BC0 Offset: 0x1EF0CC1 VA: 0x1EF0BC0
	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0, DataStore.GetPersistenceInfoCB callback) { }

	// RVA: 0x1EF0CA0 Offset: 0x1EF0DA1 VA: 0x1EF0CA0
	private static extern bool DataStore_GetPersistenceInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ulong principalId, ref Detail.CppArray persistenceSlotIds, int timeOut) { }

	// RVA: 0x1EF0CC0 Offset: 0x1EF0DC1 VA: 0x1EF0CC0
	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0, DataStore.GetPersistenceInfoListCB callback) { }

	// RVA: 0x1EF0EF0 Offset: 0x1EF0FF1 VA: 0x1EF0EF0
	private static extern bool DataStore_PerpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, ulong dataId, int deleteFlag, int timeOut) { }

	// RVA: 0x1EF0F10 Offset: 0x1EF1011 VA: 0x1EF0F10
	public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = True, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF1000 Offset: 0x1EF1101 VA: 0x1EF1000
	private static extern bool DataStore_UnperpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, int deleteFlag, int timeOut) { }

	// RVA: 0x1EF1020 Offset: 0x1EF1121 VA: 0x1EF1020
	public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = False, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF1100 Offset: 0x1EF1201 VA: 0x1EF1100
	private static extern bool DataStore_GetPasswordInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut) { }

	// RVA: 0x1EF1120 Offset: 0x1EF1221 VA: 0x1EF1120
	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, DataStore.GetPasswordInfoCB callback) { }

	// RVA: 0x1EF1200 Offset: 0x1EF1301 VA: 0x1EF1200
	private static extern bool DataStore_GetPasswordInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, int timeOut) { }

	// RVA: 0x1EF1220 Offset: 0x1EF1321 VA: 0x1EF1220
	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, DataStore.GetPasswordInfoListCB callback) { }

	// RVA: 0x1EF1450 Offset: 0x1EF1551 VA: 0x1EF1450
	private static void DataStore_PostResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1510 Offset: 0x1EF1611 VA: 0x1EF1510
	private static void DataStore_ResultListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1660 Offset: 0x1EF1761 VA: 0x1EF1660
	private static void DataStore_SearchObjectResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1760 Offset: 0x1EF1861 VA: 0x1EF1760
	private static void DataStore_GetObjectResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF18D0 Offset: 0x1EF19D1 VA: 0x1EF18D0
	private static void DataStore_GetMetaResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF19D0 Offset: 0x1EF1AD1 VA: 0x1EF19D0
	private static void DataStore_GetMetaByDataListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1BC0 Offset: 0x1EF1CC1 VA: 0x1EF1BC0
	private static void DataStore_RatingInfoResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1D10 Offset: 0x1EF1E11 VA: 0x1EF1D10
	private static void DataStore_RatingInfoAllSlotResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF1FF0 Offset: 0x1EF20F1 VA: 0x1EF1FF0
	private static void DataStore_RatingInfoListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF21E0 Offset: 0x1EF22E1 VA: 0x1EF21E0
	private static void DataStore_RatingInfosListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2390 Offset: 0x1EF2491 VA: 0x1EF2390
	private static void DataStore_RatingInfoWithLogResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2530 Offset: 0x1EF2631 VA: 0x1EF2530
	private static void DataStore_GetPersistenceInfoResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2630 Offset: 0x1EF2731 VA: 0x1EF2630
	private static void DataStore_GetPersistenceInfoListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2820 Offset: 0x1EF2921 VA: 0x1EF2820
	private static void DataStore_GetPasswordInfoResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2920 Offset: 0x1EF2A21 VA: 0x1EF2920
	private static void DataStore_GetPasswordInfoListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF2B10 Offset: 0x1EF2C11 VA: 0x1EF2B10
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
public static class Detail.DataStoreDataCode // TypeDefIndex: 14817
{
	// Fields
	private const int MAX_STRING = 15;

	// Methods

	// RVA: 0x1EF2DE0 Offset: 0x1EF2EE1 VA: 0x1EF2DE0
	private static extern bool DataStoreDataCode_DataId2String(string key, ulong dataId, [In] [Out] StringBuilder sb) { }

	// RVA: 0x1EF2E60 Offset: 0x1EF2F61 VA: 0x1EF2E60
	public static bool DataId2String(string key, ulong dataId, out string str) { }

	// RVA: 0x1EF2F50 Offset: 0x1EF3051 VA: 0x1EF2F50
	private static extern bool DataStoreDataCode_String2DataId(string key, string str, ref ulong dataId) { }

	// RVA: 0x1EF2FC0 Offset: 0x1EF30C1 VA: 0x1EF2FC0
	public static bool String2DataId(string key, string str, ref ulong dataId) { }
}

// Namespace: 
public static class Detail.NgsFacade // TypeDefIndex: 14818
{
	// Methods

	// RVA: 0x1EF3020 Offset: 0x1EF3121 VA: 0x1EF3020
	private static extern bool Ngs_LoginAsync(uint asyncId, uint gameServerId, ref Detail.CppArray accessKey, ulong nsaId, ref Detail.CppArray nsaIdToken, int timeOut) { }

	// RVA: 0x1EF3040 Offset: 0x1EF3141 VA: 0x1EF3040
	public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000, NgsFacade.LoginCB callback) { }

	// RVA: 0x1EF32E0 Offset: 0x1EF33E1 VA: 0x1EF32E0
	private static extern bool Ngs_LogoutAsync(uint asyncId, IntPtr pNgsFacade) { }

	// RVA: 0x1EF3300 Offset: 0x1EF3401 VA: 0x1EF3300
	public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, AsyncResultCB callback) { }

	// RVA: 0x1EF33C0 Offset: 0x1EF34C1 VA: 0x1EF33C0
	private static extern bool Ngs_TestConnectivityAsync(uint asyncId, IntPtr pNgsFacade) { }

	// RVA: 0x1EF33E0 Offset: 0x1EF34E1 VA: 0x1EF33E0
	public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, NgsFacade.TestConnectivityCB callback) { }

	// RVA: 0x1EF34A0 Offset: 0x1EF35A1 VA: 0x1EF34A0
	private static void NGSLoginResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF3560 Offset: 0x1EF3661 VA: 0x1EF3560
	private static void TestConnectivityResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF3610 Offset: 0x1EF3711 VA: 0x1EF3610
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
private struct Detail.Ranking.RankingRankDataInt : Detail.IExchangeList<RankingRankData> // TypeDefIndex: 14819
{
	// Fields
	private ulong uniqueId; // 0x0
	private uint category; // 0x8
	private uint score; // 0xC
	private ulong param; // 0x10
	private NpDateTime updateTime; // 0x18
	private Detail.CppArray commonData; // 0x20
	private ulong principalId; // 0x30
	private uint order; // 0x38
	private byte group0; // 0x3C
	private byte group1; // 0x3D

	// Methods

	// RVA: 0x1DC6E80 Offset: 0x1DC6F81 VA: 0x1DC6E80 Slot: 4
	public RankingRankData ExchangeStruct() { }

	// RVA: 0x1DC6FB0 Offset: 0x1DC70B1 VA: 0x1DC6FB0
	public void .ctor(List<IntPtr> useptr, RankingRankData param) { }
}

// Namespace: 
private struct Detail.Ranking.RankingResultInt : Detail.IExchangeList<RankingResult> // TypeDefIndex: 14820
{
	// Fields
	private Detail.CppArray rankDataList; // 0x0
	private NpDateTime sinceTime; // 0x10
	private uint totalCount; // 0x18

	// Methods

	// RVA: 0x1DC7090 Offset: 0x1DC7191 VA: 0x1DC7090
	public static RankingResult ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC6A60 Offset: 0x1DC6B61 VA: 0x1DC6A60 Slot: 4
	public RankingResult ExchangeStruct() { }

	// RVA: 0x1DC6BD0 Offset: 0x1DC6CD1 VA: 0x1DC6BD0
	public void .ctor(List<IntPtr> useptr, RankingResult param) { }
}

// Namespace: 
private struct Detail.Ranking.RankingCachedResultInt : Detail.IExchangeList<RankingCachedResult> // TypeDefIndex: 14821
{
	// Fields
	public NpDateTime createdTime; // 0x0
	public NpDateTime expiredTime; // 0x8
	public Detail.Ranking.RankingResultInt rankingResult; // 0x10
	public uint maxLength; // 0x30

	// Methods

	// RVA: 0x1DC6860 Offset: 0x1DC6961 VA: 0x1DC6860
	public static RankingCachedResult ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC6930 Offset: 0x1DC6A31 VA: 0x1DC6930 Slot: 4
	public RankingCachedResult ExchangeStruct() { }

	// RVA: 0x1DC6B10 Offset: 0x1DC6C11 VA: 0x1DC6B10
	public void .ctor(List<IntPtr> useptr, RankingCachedResult param) { }
}

// Namespace: 
private struct Detail.Ranking.RankingScoreDataInt // TypeDefIndex: 14822
{
	// Fields
	private ulong param; // 0x0
	private uint category; // 0x8
	private uint score; // 0xC
	private byte orderBy; // 0x10
	private byte updateMode; // 0x11
	private byte group0; // 0x12
	private byte group1; // 0x13

	// Methods

	// RVA: 0x1DC71C0 Offset: 0x1DC72C1 VA: 0x1DC71C0
	public void .ctor(RankingScoreData param) { }
}

// Namespace: 
private struct Detail.Ranking.RankingOrderParamInt // TypeDefIndex: 14823
{
	// Fields
	private byte orderCalc; // 0x0
	private byte groupIndex; // 0x1
	private byte groupNum; // 0x2
	private byte timeScope; // 0x3
	private uint offset; // 0x4
	private byte length; // 0x8

	// Methods

	// RVA: 0x1DC6DE0 Offset: 0x1DC6EE1 VA: 0x1DC6DE0
	public void .ctor(RankingOrderParam param) { }
}

// Namespace: 
private struct Detail.Ranking.RankingChangeAttributesParamInt // TypeDefIndex: 14824
{
	// Fields
	private ulong param; // 0x0
	private byte modificationFlag; // 0x8
	private byte group0; // 0x9
	private byte group1; // 0xA

	// Methods

	// RVA: 0x1DC6D50 Offset: 0x1DC6E51 VA: 0x1DC6D50
	public void .ctor(RankingChangeAttributesParam param) { }
}

// Namespace: 
public static class Detail.Ranking // TypeDefIndex: 14825
{
	// Methods

	// RVA: 0x1EF39C0 Offset: 0x1EF3AC1 VA: 0x1EF39C0
	private static extern bool Ranking_UploadCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray commonData, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF39E0 Offset: 0x1EF3AE1 VA: 0x1EF39E0
	public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF3C10 Offset: 0x1EF3D11 VA: 0x1EF3C10
	private static extern bool Ranking_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF3C30 Offset: 0x1EF3D31 VA: 0x1EF3C30
	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF3D10 Offset: 0x1EF3E11 VA: 0x1EF3D10
	private static extern bool Ranking_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF3D30 Offset: 0x1EF3E31 VA: 0x1EF3D30
	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, Ranking.GetCommonDataCB callback) { }

	// RVA: 0x1EF3E10 Offset: 0x1EF3F11 VA: 0x1EF3E10
	private static extern bool Ranking_UploadScoreAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Ranking.RankingScoreDataInt scoreData, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF3E30 Offset: 0x1EF3F31 VA: 0x1EF3E30
	public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF3F30 Offset: 0x1EF4031 VA: 0x1EF3F30
	private static extern bool Ranking_DeleteScoreAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF3F50 Offset: 0x1EF4051 VA: 0x1EF3F50
	public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF4040 Offset: 0x1EF4141 VA: 0x1EF4040
	private static extern bool Ranking_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, uint rankingMode, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, ulong nexUniqueId, ulong principalId, int timeOut) { }

	// RVA: 0x1EF4060 Offset: 0x1EF4161 VA: 0x1EF4060
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, ulong principalId, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x1EF4180 Offset: 0x1EF4281 VA: 0x1EF4180
	private static extern bool Ranking_GetRankingByPIDListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray principalIdList, uint rankingMode, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF41A0 Offset: 0x1EF42A1 VA: 0x1EF41A0
	public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x1EF4400 Offset: 0x1EF4501 VA: 0x1EF4400
	private static extern bool Ranking_GetRankingByUIDListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray nexUniqueIdList, uint rankingMode, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF4420 Offset: 0x1EF4521 VA: 0x1EF4420
	public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0, Ranking.GetRankingCB callback) { }

	// RVA: 0x1EF4680 Offset: 0x1EF4781 VA: 0x1EF4680
	private static extern bool Ranking_GetApproxOrderAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut) { }

	// RVA: 0x1EF46A0 Offset: 0x1EF47A1 VA: 0x1EF46A0
	public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut = 0, Ranking.GetApproxOrderCB callback) { }

	// RVA: 0x1EF47C0 Offset: 0x1EF48C1 VA: 0x1EF47C0
	private static extern bool Ranking_GetStatsAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, uint flags, int timeOut) { }

	// RVA: 0x1EF47E0 Offset: 0x1EF48E1 VA: 0x1EF47E0
	public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, Ranking.StatsFlag flags, int timeOut = 0, Ranking.GetStatsCB callback) { }

	// RVA: 0x1EF48F0 Offset: 0x1EF49F1 VA: 0x1EF48F0
	private static extern bool Ranking_ChangeAttributesAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ref Detail.Ranking.RankingChangeAttributesParamInt changeParam, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF4910 Offset: 0x1EF4A11 VA: 0x1EF4910
	public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF4A30 Offset: 0x1EF4B31 VA: 0x1EF4A30
	private static extern bool Ranking_GetCachedTopXRankingAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref Detail.Ranking.RankingOrderParamInt orderParam, int timeOut) { }

	// RVA: 0x1EF4A50 Offset: 0x1EF4B51 VA: 0x1EF4A50
	public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0, Ranking.GetCachedTopXRankingCB callback) { }

	// RVA: 0x1EF4B50 Offset: 0x1EF4C51 VA: 0x1EF4B50
	private static extern bool Ranking_GetCachedTopXRankingsAsync(uint asyncId, IntPtr pNgsFacade, int useOneRankingOrderParam, ref Detail.CppArray categories, ref Detail.CppArray orderParams, int timeOut) { }

	// RVA: 0x1EF4B70 Offset: 0x1EF4C71 VA: 0x1EF4B70
	public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneRankingOrderParam, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0, Ranking.GetCachedTopXRankingsCB callback) { }

	// RVA: 0x1EF4E10 Offset: 0x1EF4F11 VA: 0x1EF4E10
	private static extern RankingCachedResult.LocalUpdateState Ranking_LocalUpdate(ref IntPtr pNewResult, ref Detail.Ranking.RankingCachedResultInt cachedResult, ref Detail.Ranking.RankingOrderParamInt orderParam, ref Detail.Ranking.RankingScoreDataInt scoreData, ulong pid, ulong nexUniqueId, ref NpDateTime utcCurrentTime, ref Detail.CppArray pCommonData) { }

	// RVA: 0x1EF4E20 Offset: 0x1EF4F21 VA: 0x1EF4E20
	public static RankingCachedResult.LocalUpdateState LocalUpdate(out RankingCachedResult newResult, RankingCachedResult result, RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId, NpDateTime utcCurrentTime, List<byte> pCommonData) { }

	// RVA: 0x1EF5100 Offset: 0x1EF5201 VA: 0x1EF5100
	private static extern void Ranking_DeleteCachedResult(IntPtr cachedResult) { }

	// RVA: 0x1EF5110 Offset: 0x1EF5211 VA: 0x1EF5110
	private static void Ranking_GetCommonDataResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF5260 Offset: 0x1EF5361 VA: 0x1EF5260
	private static void Ranking_GetRankingResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF5360 Offset: 0x1EF5461 VA: 0x1EF5360
	private static void Ranking_GetApproxOrderResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF5420 Offset: 0x1EF5521 VA: 0x1EF5420
	private static void Ranking_GetStatsResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF5590 Offset: 0x1EF5691 VA: 0x1EF5590
	private static void Ranking_GetCachedTopXRankingResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF5690 Offset: 0x1EF5791 VA: 0x1EF5690
	private static void Ranking_GetCachedTopXRankingsResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF57E0 Offset: 0x1EF58E1 VA: 0x1EF57E0
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2CommonDataInt // TypeDefIndex: 14826
{
	// Fields
	public Detail.CppArray binaryData; // 0x0
	public Detail.CppArray userName; // 0x10

	// Methods

	// RVA: 0x1DC7560 Offset: 0x1DC7661 VA: 0x1DC7560
	public static Ranking2CommonData ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC7610 Offset: 0x1DC7711 VA: 0x1DC7610
	public Ranking2CommonData ExchangeStruct() { }

	// RVA: 0x1DC7710 Offset: 0x1DC7811 VA: 0x1DC7710
	public void .ctor(List<IntPtr> useptr, Ranking2CommonData param) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2RankDataInt : Detail.IExchangeList<Ranking2RankData> // TypeDefIndex: 14827
{
	// Fields
	private Detail.Ranking2.Ranking2CommonDataInt commonData; // 0x0
	private ulong misc; // 0x20
	private ulong nexUniqueId; // 0x28
	private uint rank; // 0x30
	private uint score; // 0x34
	private ulong principalId; // 0x38

	// Methods

	// RVA: 0x1DC7A40 Offset: 0x1DC7B41 VA: 0x1DC7A40 Slot: 4
	public Ranking2RankData ExchangeStruct() { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2InfoInt // TypeDefIndex: 14828
{
	// Fields
	private Detail.CppArray ranking2RankDataList; // 0x0
	private uint numRankedIn; // 0x10
	private uint lowestRank; // 0x14
	private int season; // 0x18

	// Methods

	// RVA: 0x1DC7910 Offset: 0x1DC7A11 VA: 0x1DC7910
	public static Ranking2Info ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2CategorySettingInt // TypeDefIndex: 14829
{
	// Fields
	private uint minScore; // 0x0
	private uint maxScore; // 0x4
	private ushort lowestRank; // 0x8
	private byte maxSeasonsToGoBack; // 0xA
	private byte resetMode; // 0xB
	private byte resetHour; // 0xC
	private byte resetDay; // 0xD
	private ushort resetMonth; // 0xE
	private byte scoreorder; // 0x10

	// Methods

	// RVA: 0x1DC7260 Offset: 0x1DC7361 VA: 0x1DC7260
	public static Ranking2CategorySetting ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2ChartInfoInt : Detail.IExchangeList<Ranking2ChartInfo> // TypeDefIndex: 14830
{
	// Fields
	private uint index; // 0x0
	private uint category; // 0x4
	private uint season; // 0x8
	private uint samplingRate; // 0xC
	private uint scoreOrder; // 0x10
	private uint estimateLength; // 0x14
	private uint estimateHighestScore; // 0x18
	private uint estimateLowestScore; // 0x1C
	private uint estimateMedianScore; // 0x20
	private uint highestBinsScore; // 0x24
	private uint lowestBinsScore; // 0x28
	private uint binsWidth; // 0x2C
	private uint attribute1; // 0x30
	private uint attribute2; // 0x34
	private NpDateTime createTime; // 0x38
	private double estimateAverageScore; // 0x40
	private Detail.CppArray quantities; // 0x48
	private byte binsSize; // 0x58

	// Methods

	// RVA: 0x1DC7360 Offset: 0x1DC7461 VA: 0x1DC7360
	public static Ranking2ChartInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC7440 Offset: 0x1DC7541 VA: 0x1DC7440 Slot: 4
	public Ranking2ChartInfo ExchangeStruct() { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2ScoreDataInt // TypeDefIndex: 14831
{
	// Fields
	private uint category; // 0x0
	private uint score; // 0x4
	private ulong misc; // 0x8

	// Methods

	// RVA: 0x1DC7AF0 Offset: 0x1DC7BF1 VA: 0x1DC7AF0
	public void .ctor(Ranking2ScoreData param) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2GetParamInt // TypeDefIndex: 14832
{
	// Fields
	private ulong nexUniqueId; // 0x0
	private ulong principalId; // 0x8
	private uint category; // 0x10
	private uint offset; // 0x14
	private uint length; // 0x18
	private uint optionFlags; // 0x1C
	private uint sortFlags; // 0x20
	private byte mode; // 0x24
	private byte numSeasonsToGoBack; // 0x25

	// Methods

	// RVA: 0x1DC7860 Offset: 0x1DC7961 VA: 0x1DC7860
	public void .ctor(List<IntPtr> useptr, Ranking2GetParam param) { }
}

// Namespace: 
private struct Detail.Ranking2.Ranking2GetByListParamInt // TypeDefIndex: 14833
{
	// Fields
	private uint category; // 0x0
	private uint offset; // 0x4
	private uint length; // 0x8
	private uint optionFlags; // 0xC
	private uint sortFlags; // 0x10
	private byte numSeasonsToGoBack; // 0x14

	// Methods

	// RVA: 0x1DC77C0 Offset: 0x1DC78C1 VA: 0x1DC77C0
	public void .ctor(List<IntPtr> useptr, Ranking2GetByListParam param) { }
}

// Namespace: 
public static class Detail.Ranking2 // TypeDefIndex: 14834
{
	// Methods

	// RVA: 0x1EF59B0 Offset: 0x1EF5AB1 VA: 0x1EF59B0
	private static extern bool Ranking2_PutScoreAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Ranking2.Ranking2ScoreDataInt pParam, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF59D0 Offset: 0x1EF5AD1 VA: 0x1EF59D0
	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF5AD0 Offset: 0x1EF5BD1 VA: 0x1EF5AD0
	private static extern bool Ranking2_PutScoreListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF5AF0 Offset: 0x1EF5BF1 VA: 0x1EF5AF0
	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF5D60 Offset: 0x1EF5E61 VA: 0x1EF5D60
	private static extern bool Ranking2_PutCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Ranking2.Ranking2CommonDataInt commonData, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF5D80 Offset: 0x1EF5E81 VA: 0x1EF5D80
	public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF5FB0 Offset: 0x1EF60B1 VA: 0x1EF5FB0
	private static extern bool Ranking2_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, uint optionFlags, ulong principalId, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF5FD0 Offset: 0x1EF60D1 VA: 0x1EF5FD0
	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2.Ranking2GetOptionFlags optionFlags, ulong principalId, ulong nexUniqueId, int timeOut = 0, Ranking2.GetCommonDataCB callback) { }

	// RVA: 0x1EF60C0 Offset: 0x1EF61C1 VA: 0x1EF60C0
	private static extern bool Ranking2_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut) { }

	// RVA: 0x1EF60E0 Offset: 0x1EF61E1 VA: 0x1EF60E0
	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF61C0 Offset: 0x1EF62C1 VA: 0x1EF61C0
	private static extern bool Ranking2_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Ranking2.Ranking2GetParamInt getParam, int timeOut) { }

	// RVA: 0x1EF61E0 Offset: 0x1EF62E1 VA: 0x1EF61E0
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0, Ranking2.GetRankingCB callback) { }

	// RVA: 0x1EF6400 Offset: 0x1EF6501 VA: 0x1EF6400
	private static extern bool Ranking2_GetRankingByListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Ranking2.Ranking2GetByListParamInt getParam, ref Detail.CppArray principalIdList, int timeOut) { }

	// RVA: 0x1EF6420 Offset: 0x1EF6521 VA: 0x1EF6420
	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0, Ranking2.GetRankingCB callback) { }

	// RVA: 0x1EF6670 Offset: 0x1EF6771 VA: 0x1EF6670
	private static extern bool Ranking2_GetCategorySettingAsync(uint asyncId, IntPtr pNgsFacade, uint category, int timeOut) { }

	// RVA: 0x1EF6690 Offset: 0x1EF6791 VA: 0x1EF6690
	public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0, Ranking2.GetCategorySettingCB callback) { }

	// RVA: 0x1EF6770 Offset: 0x1EF6871 VA: 0x1EF6770
	private static extern bool Ranking2_GetRankingChartAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2ChartInfoInput info, int timeOut) { }

	// RVA: 0x1EF6790 Offset: 0x1EF6891 VA: 0x1EF6790
	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0, Ranking2.GetRanking2ChartInfoCB callback) { }

	// RVA: 0x1EF6870 Offset: 0x1EF6971 VA: 0x1EF6870
	private static extern bool Ranking2_GetRankingChartsAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray info, int timeOut) { }

	// RVA: 0x1EF6890 Offset: 0x1EF6991 VA: 0x1EF6890
	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0, Ranking2.GetRanking2ChartInfoListCB callback) { }

	// RVA: 0x1EF6AC0 Offset: 0x1EF6BC1 VA: 0x1EF6AC0
	private static extern bool Ranking2_GetEstimateScoreRankAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2EstimateScoreRankInput info, int timeOut) { }

	// RVA: 0x1EF6AE0 Offset: 0x1EF6BE1 VA: 0x1EF6AE0
	public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0, Ranking2.GetRanking2EstimateScoreRankCB callback) { }

	// RVA: 0x1EF6BC0 Offset: 0x1EF6CC1 VA: 0x1EF6BC0
	private static void Ranking2_GetCommonDataResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF6CC0 Offset: 0x1EF6DC1 VA: 0x1EF6CC0
	private static void Ranking2_GetRankingResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF6DC0 Offset: 0x1EF6EC1 VA: 0x1EF6DC0
	private static void Ranking2_GetCategorySettingResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF6EC0 Offset: 0x1EF6FC1 VA: 0x1EF6EC0
	private static void Ranking2_GetRanking2ChartInfoResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF6FC0 Offset: 0x1EF70C1 VA: 0x1EF6FC0
	private static void Ranking2_GetRanking2ChartInfoListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF7110 Offset: 0x1EF7211 VA: 0x1EF7110
	private static void Ranking2_GetRanking2EstimateScoreRankResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF7260 Offset: 0x1EF7361 VA: 0x1EF7260
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
private struct Detail.Screening.ScreeningContextInfoInt // TypeDefIndex: 14835
{
	// Fields
	private Detail.CppArray key; // 0x0
	private Detail.CppArray value; // 0x10

	// Methods

	// RVA: 0x1DC7B70 Offset: 0x1DC7C71 VA: 0x1DC7B70
	public void .ctor(List<IntPtr> useptr, ScreeningContextInfo context) { }
}

// Namespace: 
private struct Detail.Screening.ScreeningDataStoreContentParamInt // TypeDefIndex: 14836
{
	// Fields
	private ulong dataId; // 0x0
	private ulong contentDataId; // 0x8
	private Detail.CppArray ugcType; // 0x10
	private Detail.CppArray language; // 0x20
	private Detail.CppArray searchKey; // 0x30

	// Methods

	// RVA: 0x1DC7C10 Offset: 0x1DC7D11 VA: 0x1DC7C10
	public void .ctor(List<IntPtr> useptr, ScreeningDataStoreContentParam param) { }
}

// Namespace: 
private struct Detail.Screening.ScreeningUgcViolationParamInt // TypeDefIndex: 14837
{
	// Fields
	private uint category; // 0x0
	private Detail.CppArray reason; // 0x8
	private Detail.CppArray context; // 0x18
	private ulong screenshotDataId; // 0x28

	// Methods

	// RVA: 0x1DC7CD0 Offset: 0x1DC7DD1 VA: 0x1DC7CD0
	public void .ctor(List<IntPtr> useptr, ScreeningUgcViolationParam param) { }
}

// Namespace: 
public static class Detail.Screening // TypeDefIndex: 14838
{
	// Methods

	// RVA: 0x1EF73A0 Offset: 0x1EF74A1 VA: 0x1EF73A0
	private static extern bool Screening_ReportDataStoreContentAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Screening.ScreeningDataStoreContentParamInt pContentParam, ref Detail.Screening.ScreeningUgcViolationParamInt pViolationParam, int timeOut) { }

	// RVA: 0x1EF73C0 Offset: 0x1EF74C1 VA: 0x1EF73C0
	public static bool ReportDataStoreContentAsync(out uint asyncId, IntPtr pNgsFacade, ScreeningDataStoreContentParam contentParam, ScreeningUgcViolationParam violationParam, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF7610 Offset: 0x1EF7711 VA: 0x1EF7610
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatJoinRoomResultInt // TypeDefIndex: 14839
{
	// Fields
	private ulong roomId; // 0x0

	// Methods

	// RVA: 0x1DC7E90 Offset: 0x1DC7F91 VA: 0x1DC7E90
	public void .ctor(SmartDeviceVoiceChatJoinRoomResult param) { }

	// RVA: 0x1DC7F00 Offset: 0x1DC8001 VA: 0x1DC7F00
	public static SmartDeviceVoiceChatJoinRoomResult ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatShowAppPageResultInt // TypeDefIndex: 14840
{
	// Fields
	private int status; // 0x0

	// Methods

	// RVA: 0x1DC80C0 Offset: 0x1DC81C1 VA: 0x1DC80C0
	public void .ctor(SmartDeviceVoiceChatShowAppPageResult param) { }

	// RVA: 0x1DC8130 Offset: 0x1DC8231 VA: 0x1DC8130
	public static SmartDeviceVoiceChatShowAppPageResult ExchangePtrToStruct(IntPtr src) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatJoinRoomParamInt // TypeDefIndex: 14841
{
	// Fields
	private ulong sessionId; // 0x0
	private uint gameMode; // 0x8
	private uint channelId; // 0xC

	// Methods

	// RVA: 0x1DC7E10 Offset: 0x1DC7F11 VA: 0x1DC7E10
	public void .ctor(SmartDeviceVoiceChatJoinRoomParam param) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatLeaveRoomParamInt // TypeDefIndex: 14842
{
	// Fields
	private ulong roomId; // 0x0

	// Methods

	// RVA: 0x1DC7FC0 Offset: 0x1DC80C1 VA: 0x1DC7FC0
	public void .ctor(SmartDeviceVoiceChatLeaveRoomParam param) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatChangeVoiceChatChannelParamInt // TypeDefIndex: 14843
{
	// Fields
	private ulong roomId; // 0x0
	private uint channelId; // 0x8

	// Methods

	// RVA: 0x1DC7D90 Offset: 0x1DC7E91 VA: 0x1DC7D90
	public void .ctor(SmartDeviceVoiceChatChangeVoiceChatChannelParam param) { }
}

// Namespace: 
private struct Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatShowAppPageParamInt // TypeDefIndex: 14844
{
	// Fields
	private UserHandle userHandle; // 0x0

	// Methods

	// RVA: 0x1DC8030 Offset: 0x1DC8131 VA: 0x1DC8030
	public void .ctor(ref SmartDeviceVoiceChatShowAppPageParam param) { }
}

// Namespace: 
public static class Detail.SmartDeviceVoiceChat // TypeDefIndex: 14845
{
	// Methods

	// RVA: 0x1EF76A0 Offset: 0x1EF77A1 VA: 0x1EF76A0
	private static extern bool SmartDeviceVoiceChat_ShowAppPageAsync(uint asyncId, ref Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatShowAppPageParamInt pParam) { }

	// RVA: 0x1EF76C0 Offset: 0x1EF77C1 VA: 0x1EF76C0
	public static bool ShowAppPageAsync(out uint asyncId, SmartDeviceVoiceChatShowAppPageParam param, SmartDeviceVoiceChat.ShowAppPageCB callback) { }

	// RVA: 0x1EF77B0 Offset: 0x1EF78B1 VA: 0x1EF77B0
	private static extern bool SmartDeviceVoiceChat_ChangeVoiceChatChannelAsync(uint asyncId, ref Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatChangeVoiceChatChannelParamInt pParam, int timeOut) { }

	// RVA: 0x1EF77D0 Offset: 0x1EF78D1 VA: 0x1EF77D0
	public static bool ChangeVoiceChatChannelAsync(out uint asyncId, SmartDeviceVoiceChatChangeVoiceChatChannelParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF78C0 Offset: 0x1EF79C1 VA: 0x1EF78C0
	private static extern bool SmartDeviceVoiceChat_GetAvailabilityAsync(uint asyncId, int timeOut) { }

	// RVA: 0x1EF78E0 Offset: 0x1EF79E1 VA: 0x1EF78E0
	public static bool GetAvailabilityAsync(out uint asyncId, int timeOut = 0, SmartDeviceVoiceChat.GetAvailabilityCB callback) { }

	// RVA: 0x1EF79A0 Offset: 0x1EF7AA1 VA: 0x1EF79A0
	private static extern bool SmartDeviceVoiceChat_JoinRoomAsync(uint asyncId, ref Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatJoinRoomParamInt pParam, int timeOut = 0) { }

	// RVA: 0x1EF79C0 Offset: 0x1EF7AC1 VA: 0x1EF79C0
	public static bool JoinRoomAsync(out uint asyncId, SmartDeviceVoiceChatJoinRoomParam param, int timeOut = 0, SmartDeviceVoiceChat.JoinRoomCB callback) { }

	// RVA: 0x1EF7AB0 Offset: 0x1EF7BB1 VA: 0x1EF7AB0
	private static extern bool SmartDeviceVoiceChat_LeaveRoomAsync(uint asyncId, ref Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatLeaveRoomParamInt pParam, int timeOut = 0) { }

	// RVA: 0x1EF7AD0 Offset: 0x1EF7BD1 VA: 0x1EF7AD0
	public static bool LeaveRoomAsync(out uint asyncId, SmartDeviceVoiceChatLeaveRoomParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF7BC0 Offset: 0x1EF7CC1 VA: 0x1EF7BC0
	private static extern bool SmartDeviceVoiceChat_LeaveRoom(ref Detail.SmartDeviceVoiceChat.SmartDeviceVoiceChatLeaveRoomParamInt pParam) { }

	// RVA: 0x1EF7BE0 Offset: 0x1EF7CE1 VA: 0x1EF7BE0
	public static bool LeaveRoom(SmartDeviceVoiceChatLeaveRoomParam param) { }

	// RVA: 0x1EF7C20 Offset: 0x1EF7D21 VA: 0x1EF7C20
	private static void SmartDeviceVoiceChat_GetAvailabilityResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF7CE0 Offset: 0x1EF7DE1 VA: 0x1EF7CE0
	private static void SmartDeviceVoiceChat_JoinRoomResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF7DE0 Offset: 0x1EF7EE1 VA: 0x1EF7DE0
	private static void SmartDeviceVoiceChat_ShowAppPageResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF7EE0 Offset: 0x1EF7FE1 VA: 0x1EF7EE0
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
private struct Detail.Subscriber.SubscriberContentInt : Detail.IExchangeList<SubscriberContent> // TypeDefIndex: 14846
{
	// Fields
	private ulong contentId; // 0x0
	private NpDateTime postTime; // 0x8
	private Detail.CppArray topics; // 0x10
	private Detail.CppArray binary; // 0x20
	private Detail.CppArray message; // 0x30
	private ulong pid; // 0x40

	// Methods

	// RVA: 0x1DC81F0 Offset: 0x1DC82F1 VA: 0x1DC81F0 Slot: 4
	public SubscriberContent ExchangeStruct() { }
}

// Namespace: 
private struct Detail.Subscriber.SubscriberPostContentParamInt // TypeDefIndex: 14847
{
	// Fields
	private Detail.CppArray topics; // 0x0
	private Detail.CppArray contentBinary; // 0x10
	private Detail.CppArray contentMessage; // 0x20

	// Methods

	// RVA: 0x1DC8420 Offset: 0x1DC8521 VA: 0x1DC8420
	public void .ctor(List<IntPtr> useptr, SubscriberPostContentParam param) { }
}

// Namespace: 
public struct Detail.Subscriber.SubscriberGetContentParamInt // TypeDefIndex: 14848
{
	// Fields
	private uint size; // 0x0
	private uint offset; // 0x4
	private ulong minimumContentId; // 0x8
	private uint topic; // 0x10

	// Methods

	// RVA: 0x1DC8390 Offset: 0x1DC8491 VA: 0x1DC8390
	public void .ctor(SubscriberGetContentParam param) { }
}

// Namespace: 
private struct Detail.Subscriber.SubscriberUserStatusInfoInt : Detail.IExchangeList<SubscriberUserStatusInfo> // TypeDefIndex: 14849
{
	// Fields
	private Detail.CppArray keys; // 0x0
	private Detail.CppArray values; // 0x10
	private ulong pid; // 0x20

	// Methods

	// RVA: 0x1DC8500 Offset: 0x1DC8601 VA: 0x1DC8500
	public static SubscriberUserStatusInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC85C0 Offset: 0x1DC86C1 VA: 0x1DC85C0 Slot: 4
	public SubscriberUserStatusInfo ExchangeStruct() { }
}

// Namespace: 
private struct Detail.Subscriber.SubscriberUserStatusParamInt // TypeDefIndex: 14850
{
	// Fields
	private Detail.CppArray value; // 0x0
	private byte key; // 0x10

	// Methods

	// RVA: 0x1DC8870 Offset: 0x1DC8971 VA: 0x1DC8870
	public void .ctor(List<IntPtr> useptr, SubscriberUserStatusParam param) { }
}

// Namespace: 
public static class Detail.Subscriber // TypeDefIndex: 14851
{
	// Methods

	// RVA: 0x1EF8060 Offset: 0x1EF8161 VA: 0x1EF8060
	private static List<List<SubscriberContent>> Exchange(IntPtr src) { }

	// RVA: 0x1EF82A0 Offset: 0x1EF83A1 VA: 0x1EF82A0
	private static extern bool Subscriber_PostContentAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Subscriber.SubscriberPostContentParamInt pParam, int timeOut) { }

	// RVA: 0x1EF82C0 Offset: 0x1EF83C1 VA: 0x1EF82C0
	public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0, Subscriber.PostContentCB callback) { }

	// RVA: 0x1EF84E0 Offset: 0x1EF85E1 VA: 0x1EF84E0
	private static extern bool Subscriber_GetContentAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Subscriber.SubscriberGetContentParamInt pParam, int timeOut) { }

	// RVA: 0x1EF8500 Offset: 0x1EF8601 VA: 0x1EF8500
	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0, Subscriber.GetContentCB callback) { }

	// RVA: 0x1EF8720 Offset: 0x1EF8821 VA: 0x1EF8720
	private static extern bool Subscriber_GetContentsAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, int timeOut) { }

	// RVA: 0x1EF8740 Offset: 0x1EF8841 VA: 0x1EF8740
	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0, Subscriber.GetContentsCB callback) { }

	// RVA: 0x1EF89B0 Offset: 0x1EF8AB1 VA: 0x1EF89B0
	private static extern bool Subscriber_DeleteContentAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray topics, ulong contentId, int timeOut) { }

	// RVA: 0x1EF89D0 Offset: 0x1EF8AD1 VA: 0x1EF89D0
	public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF8C00 Offset: 0x1EF8D01 VA: 0x1EF8C00
	private static extern bool Subscriber_GetFriendUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EF8C20 Offset: 0x1EF8D21 VA: 0x1EF8C20
	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x1EF8CF0 Offset: 0x1EF8DF1 VA: 0x1EF8CF0
	private static extern bool Subscriber_GetFriendUserStatusesWithKeyAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray keys, int timeOut) { }

	// RVA: 0x1EF8D10 Offset: 0x1EF8E11 VA: 0x1EF8D10
	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x1EF8F40 Offset: 0x1EF9041 VA: 0x1EF8F40
	private static extern bool Subscriber_GetUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray users, ref Detail.CppArray keys, int timeOut) { }

	// RVA: 0x1EF8F60 Offset: 0x1EF9061 VA: 0x1EF8F60
	public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0, Subscriber.GetSubscriberUserStatusInfoCB callback) { }

	// RVA: 0x1EF91C0 Offset: 0x1EF92C1 VA: 0x1EF91C0
	private static extern bool Subscriber_UpdateUserStatusAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray param, int isNotify, int timeOut) { }

	// RVA: 0x1EF91E0 Offset: 0x1EF92E1 VA: 0x1EF91E0
	public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EF9410 Offset: 0x1EF9511 VA: 0x1EF9410
	private static extern bool Subscriber_GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, ref int result) { }

	// RVA: 0x1EF9430 Offset: 0x1EF9531 VA: 0x1EF9430
	public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result) { }

	// RVA: 0x1EF9470 Offset: 0x1EF9571 VA: 0x1EF9470
	private static extern bool Subscriber_GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, ref Result result) { }

	// RVA: 0x1EF9490 Offset: 0x1EF9591 VA: 0x1EF9490
	public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result) { }

	// RVA: 0x1EF94B0 Offset: 0x1EF95B1 VA: 0x1EF94B0
	private static extern bool Subscriber_GetFriendUserStatuses(IntPtr pNgsFacade, ref IntPtr infos, ref Result result) { }

	// RVA: 0x1EF94D0 Offset: 0x1EF95D1 VA: 0x1EF94D0
	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result) { }

	// RVA: 0x1EF9630 Offset: 0x1EF9731 VA: 0x1EF9630
	private static extern bool Subscriber_GetFriendUserStatusesWithKey(IntPtr pNgsFacade, ref Detail.CppArray users, ref IntPtr infos, ref Result result) { }

	// RVA: 0x1EF9650 Offset: 0x1EF9751 VA: 0x1EF9650
	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result) { }

	// RVA: 0x1EF9620 Offset: 0x1EF9721 VA: 0x1EF9620
	private static extern void Subscriber_DeleteSubscriberUserStatusInfo(IntPtr info) { }

	// RVA: 0x1EF98F0 Offset: 0x1EF99F1 VA: 0x1EF98F0
	private static void Subscriber_PostContentResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF99B0 Offset: 0x1EF9AB1 VA: 0x1EF99B0
	private static void Subscriber_GetContentResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF9B00 Offset: 0x1EF9C01 VA: 0x1EF9B00
	private static void Subscriber_GetContentsResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF9C10 Offset: 0x1EF9D11 VA: 0x1EF9C10
	private static void Subscriber_UserStatusInfoResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EF9D60 Offset: 0x1EF9E61 VA: 0x1EF9D60
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

// Namespace: 
public class Detail.Util_UnmanagedManager // TypeDefIndex: 14852
{
	// Methods

	// RVA: 0x1EF9F00 Offset: 0x1EFA001 VA: 0x1EF9F00
	public static IntPtr AllocHGlobal(int size, bool output = True) { }

	// RVA: 0x1EEDCA0 Offset: 0x1EEDDA1 VA: 0x1EEDCA0
	public static bool FreeHGlobal(IntPtr p, bool output = True) { }

	// RVA: 0x1EF9FF0 Offset: 0x1EFA0F1 VA: 0x1EF9FF0
	public static int GetAllocedCount() { }

	// RVA: 0x1EFA000 Offset: 0x1EFA101 VA: 0x1EFA000
	public static int GetUsedAllocsize() { }

	// RVA: 0x1EFA010 Offset: 0x1EFA111 VA: 0x1EFA010
	public void .ctor() { }
}

// Namespace: 
private struct Detail.Utility.UniqueIdInfoInt : Detail.IExchangeList<UniqueIdInfo> // TypeDefIndex: 14853
{
	// Fields
	private ulong nexUniqueId; // 0x0
	private ulong nexUniqueIdPassword; // 0x8

	// Methods

	// RVA: 0x1DC8910 Offset: 0x1DC8A11 VA: 0x1DC8910 Slot: 4
	public UniqueIdInfo ExchangeStruct() { }

	// RVA: 0x1DC8990 Offset: 0x1DC8A91 VA: 0x1DC8990
	public static UniqueIdInfo ExchangePtrToStruct(IntPtr src) { }

	// RVA: 0x1DC8A60 Offset: 0x1DC8B61 VA: 0x1DC8A60
	public void .ctor(UniqueIdInfo param) { }
}

// Namespace: 
private struct Detail.Utility.IntegerSettings // TypeDefIndex: 14854
{
	// Fields
	public int value; // 0x0
	public ushort key; // 0x4
}

// Namespace: 
public static class Detail.Utility // TypeDefIndex: 14855
{
	// Methods

	// RVA: 0x1EFA020 Offset: 0x1EFA121 VA: 0x1EFA020
	private static extern bool Utility_AcquireNexUniqueIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA040 Offset: 0x1EFA141 VA: 0x1EFA040
	public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdCB callback) { }

	// RVA: 0x1EFA110 Offset: 0x1EFA211 VA: 0x1EFA110
	private static extern bool Utility_AcquireNexUniqueIdWithPasswordAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA130 Offset: 0x1EFA231 VA: 0x1EFA130
	public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdWithPasswordCB callback) { }

	// RVA: 0x1EFA200 Offset: 0x1EFA301 VA: 0x1EFA200
	private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Utility.UniqueIdInfoInt pParam, int timeOut) { }

	// RVA: 0x1EFA220 Offset: 0x1EFA321 VA: 0x1EFA220
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EFA320 Offset: 0x1EFA421 VA: 0x1EFA320
	private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, int timeOut) { }

	// RVA: 0x1EFA340 Offset: 0x1EFA441 VA: 0x1EFA340
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EFA5B0 Offset: 0x1EFA6B1 VA: 0x1EFA5B0
	private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA5D0 Offset: 0x1EFA6D1 VA: 0x1EFA5D0
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback) { }

	// RVA: 0x1EFA6A0 Offset: 0x1EFA7A1 VA: 0x1EFA6A0
	private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA6C0 Offset: 0x1EFA7C1 VA: 0x1EFA6C0
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback) { }

	// RVA: 0x1EFA790 Offset: 0x1EFA891 VA: 0x1EFA790
	private static extern bool Utility_GetIntegerSettingsAsync(uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut) { }

	// RVA: 0x1EFA7B0 Offset: 0x1EFA8B1 VA: 0x1EFA7B0
	public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0, Utility.GetIntegerSettingsCB callback) { }

	// RVA: 0x1EFA890 Offset: 0x1EFA991 VA: 0x1EFA890
	private static void AcquireNexUniqueIdResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFA950 Offset: 0x1EFAA51 VA: 0x1EFA950
	private static void AcquireNexUniqueIdWithPasswordResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAA10 Offset: 0x1EFAB11 VA: 0x1EFAA10
	private static void GetAssociatedNexUniqueIdWithMyPrincipalIdResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAAD0 Offset: 0x1EFABD1 VA: 0x1EFAAD0
	private static void GetAssociatedNexUniqueIdWithMyPrincipalIdListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAC20 Offset: 0x1EFAD21 VA: 0x1EFAC20
	private static void GetIntegerSettingsResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAEB0 Offset: 0x1EFAFB1 VA: 0x1EFAEB0
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

