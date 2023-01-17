// Namespace: NexPlugin
public static class DataStore // TypeDefIndex: 14923
{
	// Fields
	public const ushort MAX_PERIOD = 365;
	public const uint MAX_METABIN_SIZE = 1024;
	public const uint DATASTOREPERMISSION_RECIPIENTIDS_MAX = 100;
	public const ulong INVALID_DATAID = 0;
	public const ushort INVALID_DATA_TYPE = 65535;
	public const ulong INVALID_PASSWORD = 0;
	public const uint MAX_NAME_LENGTH = 64;
	public const uint MAX_SEARCH_RESULT_SIZE = 100;
	public const uint MAX_SEARCH_ANY_RESULT_SIZE = 20;
	public const uint MAX_SEARCH_DATA_TYPE_SIZE = 10;
	public const uint NUM_TAG_SLOT = 16;
	public const uint RATING_SLOT_MAX = 15;
	public const uint NUM_RATING_SLOT = 16;
	public const uint MAX_TAG_LENGTH = 24;
	public const ushort DEFAULT_PERIOD = 90;
	public const uint DEFAULT_HTTP_THREAD_PRIORITY = 16;
	public const uint DEFAULT_RELAY_BUFFER_SIZE = 16384;
	public const uint DEFAULT_HTTP_BUFFER_SIZE = 32768;
	public const uint DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND = 167;
	public const int DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT = 60000;
	public const uint DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE = 65536;
	public const uint DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE = 65536;
	public const ushort INVALID_PERSISTENCE_SLOT_ID = 65535;
	public const ushort NUM_PERSISTENCE_SLOT = 16;
	public const uint BATCH_PROCESSING_CAPACITY_POST_OBJECT = 16;
	public const uint BATCH_PROCESSING_CAPACITY = 100;
	public const ulong RESULTRANGE_ANY_OFFSET = 4294967295;
	public const uint RESULTRANGE_DEFAULT_SIZE = 20;

	// Methods

	// RVA: -1 Offset: -1
	public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0, DataStore.PostCB callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DFD0 Offset: 0x229E0D1 VA: 0x229DFD0
	|-DataStore.PostObjectAsync<byte>
	*/

	// RVA: 0x23C6B30 Offset: 0x23C6C31 VA: 0x23C6B30
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0, DataStore.PostCB callback) { }

	// RVA: 0x23C6B40 Offset: 0x23C6C41 VA: 0x23C6B40
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C6B50 Offset: 0x23C6C51 VA: 0x23C6B50
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, Dictionary<ulong, DataStorePreparePostParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C6CB0 Offset: 0x23C6DB1 VA: 0x23C6CB0
	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStorePreparePostParam param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C6DB0 Offset: 0x23C6EB1 VA: 0x23C6DB0
	public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C6DC0 Offset: 0x23C6EC1 VA: 0x23C6DC0
	public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, DataStore.SearchObjectCB callback) { }

	// RVA: 0x23C6DD0 Offset: 0x23C6ED1 VA: 0x23C6DD0
	public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, DataStore.SearchObjectCB callback) { }

	// RVA: 0x23C6DE0 Offset: 0x23C6EE1 VA: 0x23C6DE0
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C6DF0 Offset: 0x23C6EF1 VA: 0x23C6DF0
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C6E90 Offset: 0x23C6F91 VA: 0x23C6E90
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C6EA0 Offset: 0x23C6FA1 VA: 0x23C6EA0
	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: -1 Offset: -1
	public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0, AsyncResultCB callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DFE0 Offset: 0x229E0E1 VA: 0x229DFE0
	|-DataStore.UpdateObjectAsync<byte>
	*/

	// RVA: 0x23C70A0 Offset: 0x23C71A1 VA: 0x23C70A0
	public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0, DataStore.GetObjectCB callback) { }

	// RVA: 0x23C70B0 Offset: 0x23C71B1 VA: 0x23C70B0
	public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C70C0 Offset: 0x23C71C1 VA: 0x23C70C0
	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0, DataStore.GetMetaCB callback) { }

	// RVA: 0x23C70D0 Offset: 0x23C71D1 VA: 0x23C70D0
	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreGetMetaParam param, int timeOut = 0, DataStore.GetMetaListCB callback) { }

	// RVA: 0x23C71C0 Offset: 0x23C72C1 VA: 0x23C71C0
	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreGetMetaParam> param, int timeOut = 0, DataStore.GetMetaListCB callback) { }

	// RVA: 0x23C7280 Offset: 0x23C7381 VA: 0x23C7280
	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C7290 Offset: 0x23C7391 VA: 0x23C7290
	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreChangeMetaParam param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C7390 Offset: 0x23C7491 VA: 0x23C7390
	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreChangeMetaParam> param, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C7470 Offset: 0x23C7571 VA: 0x23C7470
	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x23C7480 Offset: 0x23C7581 VA: 0x23C7480
	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam param, bool transactional = True, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x23C7580 Offset: 0x23C7681 VA: 0x23C7580
	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = True, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x23C75C0 Offset: 0x23C76C1 VA: 0x23C75C0
	public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x23C75D0 Offset: 0x23C76D1 VA: 0x23C75D0
	public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> rateParam, List<DataStorePreparePostParam> postParam, bool transactional = True, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x23C7620 Offset: 0x23C7721 VA: 0x23C7620
	public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, bool transactional = True, int timeOut = 0, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x23C7780 Offset: 0x23C7881 VA: 0x23C7780
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0, int timeOut = 0, DataStore.RatingInfoCB callback) { }

	// RVA: 0x23C7790 Offset: 0x23C7891 VA: 0x23C7790
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, DataStore.RatingInfoAllSlotCB callback) { }

	// RVA: 0x23C77A0 Offset: 0x23C78A1 VA: 0x23C77A0
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, DataStore.RatingInfosListCB callback) { }

	// RVA: 0x23C77B0 Offset: 0x23C78B1 VA: 0x23C77B0
	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0, int timeOut = 0, DataStore.RatingInfoWithLogCB callback) { }

	// RVA: 0x23C77C0 Offset: 0x23C78C1 VA: 0x23C77C0
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C77D0 Offset: 0x23C78D1 VA: 0x23C77D0
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C77E0 Offset: 0x23C78E1 VA: 0x23C77E0
	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = True, int timeOut = 0, DataStore.ResultListCB callback) { }

	// RVA: 0x23C77F0 Offset: 0x23C78F1 VA: 0x23C77F0
	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0, DataStore.GetPersistenceInfoCB callback) { }

	// RVA: 0x23C7800 Offset: 0x23C7901 VA: 0x23C7800
	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0, DataStore.GetPersistenceInfoListCB callback) { }

	// RVA: 0x23C7810 Offset: 0x23C7911 VA: 0x23C7810
	public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = True, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C7820 Offset: 0x23C7921 VA: 0x23C7820
	public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = False, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x23C7830 Offset: 0x23C7931 VA: 0x23C7830
	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, DataStore.GetPasswordInfoCB callback) { }

	// RVA: 0x23C7840 Offset: 0x23C7941 VA: 0x23C7840
	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, DataStore.GetPasswordInfoListCB callback) { }

	// RVA: 0x23C7850 Offset: 0x23C7951 VA: 0x23C7850
	public static extern bool SetHttpThreadPriority(uint priority) { }

	// RVA: 0x23C7870 Offset: 0x23C7971 VA: 0x23C7870
	public static extern bool GetHttpThreadPriority(ref uint priority) { }

	// RVA: 0x23C7890 Offset: 0x23C7991 VA: 0x23C7890
	public static extern bool SetRelayBufferSize(uint relayBufferSize) { }

	// RVA: 0x23C78B0 Offset: 0x23C79B1 VA: 0x23C78B0
	public static extern bool GetRelayBufferSize(ref uint relayBufferSize) { }

	// RVA: 0x23C78D0 Offset: 0x23C79D1 VA: 0x23C78D0
	public static extern bool SetHttpBufferSize(uint httpBufferSize) { }

	// RVA: 0x23C78F0 Offset: 0x23C79F1 VA: 0x23C78F0
	public static extern bool GetHttpBufferSize(ref uint httpBufferSize) { }

	// RVA: 0x23C7910 Offset: 0x23C7A11 VA: 0x23C7910
	public static extern bool SetDataTransferTimeout(uint timeoutBytesPerSecond, int minimumTimeoutMilliSecond) { }

	// RVA: 0x23C7930 Offset: 0x23C7A31 VA: 0x23C7930
	public static extern bool SetHttpSendSocketBufferSize(uint size) { }

	// RVA: 0x23C7950 Offset: 0x23C7A51 VA: 0x23C7950
	public static extern bool GetHttpSendSocketBufferSize(ref uint size) { }

	// RVA: 0x23C7970 Offset: 0x23C7A71 VA: 0x23C7970
	public static extern bool SetHttpRecvSocketBufferSize(uint size) { }

	// RVA: 0x23C7990 Offset: 0x23C7A91 VA: 0x23C7990
	public static extern bool GetHttpRecvSocketBufferSize(ref uint size) { }
}

