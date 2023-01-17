// Namespace: 
private class Nex.SystemImpl : SingletonClass<Nex.SystemImpl> // TypeDefIndex: 8290
{
	// Methods

	// RVA: 0x26EBE10 Offset: 0x26EBF11 VA: 0x26EBE10 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x26EBE20 Offset: 0x26EBF21 VA: 0x26EBE20 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x26EBE30 Offset: 0x26EBF31 VA: 0x26EBE30
	public Nex.Result InitializeNexAsync(AsyncResultCB callback) { }

	// RVA: 0x26EBF80 Offset: 0x26EC081 VA: 0x26EBF80
	public void CleanupNex() { }

	// RVA: 0x26EC120 Offset: 0x26EC221 VA: 0x26EC120
	public bool IsInitializedNex() { }

	// RVA: 0x26EC130 Offset: 0x26EC231 VA: 0x26EC130
	public bool IsNetworkConnected() { }

	// RVA: 0x26EC140 Offset: 0x26EC241 VA: 0x26EC140
	public int GetAsyncCallCount() { }

	// RVA: 0x26EC150 Offset: 0x26EC251 VA: 0x26EC150
	public void .ctor() { }
}

// Namespace: 
private abstract class Nex.ApiCallChecker // TypeDefIndex: 8292
{
	// Fields
	protected readonly Nex.ApiCallChecker.Guideline[] m_Guidelines; // 0x10
	protected float[,] m_CalledTimes; // 0x18
	protected int m_MaxCallCount; // 0x20

	// Methods

	// RVA: 0x26E81F0 Offset: 0x26E82F1 VA: 0x26E81F0
	protected void .ctor(int maxCallCount, Nex.ApiCallChecker.Guideline[] guidelines) { }

	// RVA: 0x26E8300 Offset: 0x26E8401 VA: 0x26E8300
	public bool Run(int api) { }

	// RVA: 0x26E8460 Offset: 0x26E8561 VA: 0x26E8460
	private void RemoveOldCalledTimes(int api, ref Nex.ApiCallChecker.Guideline guideline) { }

	// RVA: 0x26E8510 Offset: 0x26E8611 VA: 0x26E8510
	private bool Check(int api, ref Nex.ApiCallChecker.Guideline guideline) { }

	// RVA: 0x26E85B0 Offset: 0x26E86B1 VA: 0x26E85B0
	private void RecordCalledTime(int api) { }

	// RVA: 0x26E82C0 Offset: 0x26E83C1 VA: 0x26E82C0
	public void Clear() { }

	[ConditionalAttribute] // RVA: 0x2A75C0 Offset: 0x2A76C1 VA: 0x2A75C0
	// RVA: 0x26E8660 Offset: 0x26E8761 VA: 0x26E8660 Slot: 4
	protected virtual void DbgOnInvalidApi(int api) { }

	[ConditionalAttribute] // RVA: 0x2A7600 Offset: 0x2A7701 VA: 0x2A7600
	// RVA: 0x26E8670 Offset: 0x26E8771 VA: 0x26E8670 Slot: 5
	protected virtual void DbgOnTooMuchCall(int api) { }

	[ConditionalAttribute] // RVA: 0x2A7640 Offset: 0x2A7741 VA: 0x2A7640
	// RVA: 0x26E8680 Offset: 0x26E8781 VA: 0x26E8680 Slot: 6
	protected virtual void DbgOnFullCalledTimes(int api) { }
}

// Namespace: 
private class Nex.AutoLogoutFinalize : SingletonProcInst<Nex.AutoLogoutFinalize> // TypeDefIndex: 8294
{
	// Fields
	private bool m_IsBusy; // 0x72
	private bool m_IsEnd; // 0x73

	// Methods

	// RVA: 0x26E8690 Offset: 0x26E8791 VA: 0x26E8690
	private void WaitInitializeNex() { }

	// RVA: 0x26E86D0 Offset: 0x26E87D1 VA: 0x26E86D0
	private void WaitLogin() { }

	// RVA: 0x26E8870 Offset: 0x26E8971 VA: 0x26E8870
	private void WaitDisconnect() { }

	// RVA: 0x26E88D0 Offset: 0x26E89D1 VA: 0x26E88D0
	private void Logout() { }

	// RVA: 0x26E8AA0 Offset: 0x26E8BA1 VA: 0x26E8AA0
	private void Postlogout() { }

	// RVA: 0x26E8B50 Offset: 0x26E8C51 VA: 0x26E8B50
	private void FinalizeNex() { }

	// RVA: 0x26E8BF0 Offset: 0x26E8CF1 VA: 0x26E8BF0
	private bool IsBusyImpl() { }

	// RVA: 0x26E8C00 Offset: 0x26E8D01 VA: 0x26E8C00
	private void EndImpl() { }

	// RVA: 0x26E8CA0 Offset: 0x26E8DA1 VA: 0x26E8CA0
	public static void TryCreate() { }

	// RVA: 0x26E9400 Offset: 0x26E9501 VA: 0x26E9400
	public static bool IsBusy() { }

	// RVA: 0x26E94B0 Offset: 0x26E95B1 VA: 0x26E94B0
	public static void End() { }

	// RVA: 0x26E9380 Offset: 0x26E9481 VA: 0x26E9380
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7680 Offset: 0x2A7781 VA: 0x2A7680
	// RVA: 0x26E95C0 Offset: 0x26E96C1 VA: 0x26E95C0
	private void <Logout>b__6_0(AsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273100 Offset: 0x273201 VA: 0x273100
private sealed class Nex.DataStore.Impl.<>c__DisplayClass17_0 // TypeDefIndex: 8296
{
	// Fields
	public DataStore.SearchObjectCB callback; // 0x10

	// Methods

	// RVA: 0x2D7D320 Offset: 0x2D7D421 VA: 0x2D7D320
	public void .ctor() { }

	// RVA: 0x2D7D330 Offset: 0x2D7D431 VA: 0x2D7D330
	internal void <SearchAsyncCommon>b__0(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273120 Offset: 0x273221 VA: 0x273120
private sealed class Nex.DataStore.Impl.<>c__DisplayClass27_0 // TypeDefIndex: 8298
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStoreGetMetaParam param; // 0x18
	public DataStore.GetMetaCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D3C0 Offset: 0x2D7D4C1 VA: 0x2D7D3C0
	public void .ctor() { }

	// RVA: 0x2D7D3D0 Offset: 0x2D7D4D1 VA: 0x2D7D3D0
	internal void <GetMetaAsyncImpl>b__0(AsyncResult asyncResult, DataStoreMetaInfo info) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273140 Offset: 0x273241 VA: 0x273140
private sealed class Nex.DataStore.Impl.<>c__DisplayClass29_0 // TypeDefIndex: 8300
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public List<DataStoreGetMetaParam> param; // 0x18
	public DataStore.GetMetaListCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D4B0 Offset: 0x2D7D5B1 VA: 0x2D7D4B0
	public void .ctor() { }

	// RVA: 0x2D7D4C0 Offset: 0x2D7D5C1 VA: 0x2D7D4C0
	internal void <GetMetaAsyncImpl>b__0(AsyncResult asyncResult, List<DataStoreMetaInfo> infos, List<DataStoreResult> results) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273160 Offset: 0x273261 VA: 0x273160
private sealed class Nex.DataStore.Impl.<>c__DisplayClass35_0 // TypeDefIndex: 8302
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStorePreparePostParam param; // 0x18
	public DataStore.PostCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D560 Offset: 0x2D7D661 VA: 0x2D7D560
	public void .ctor() { }

	// RVA: 0x2D7D570 Offset: 0x2D7D671 VA: 0x2D7D570
	internal void <PostAsyncImpl>b__0(AsyncResult asyncResult, ulong dataId) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273180 Offset: 0x273281 VA: 0x273180
private sealed class Nex.DataStore.Impl.<>c__DisplayClass39_0 // TypeDefIndex: 8304
{
	// Fields
	public AsyncResultCB callback; // 0x10

	// Methods

	// RVA: 0x2D7D640 Offset: 0x2D7D741 VA: 0x2D7D640
	public void .ctor() { }

	// RVA: 0x2D7D650 Offset: 0x2D7D751 VA: 0x2D7D650
	internal void <CompleteSuspendedPostAsync>b__0(AsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2731A0 Offset: 0x2732A1 VA: 0x2731A0
private sealed class Nex.DataStore.Impl.<>c__DisplayClass46_0 // TypeDefIndex: 8306
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStoreChangeMetaParam param; // 0x18
	public AsyncResultCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D6D0 Offset: 0x2D7D7D1 VA: 0x2D7D6D0
	public void .ctor() { }

	// RVA: 0x2D7D6E0 Offset: 0x2D7D7E1 VA: 0x2D7D6E0
	internal void <ChangeMetaAsyncImpl>b__0(AsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2731C0 Offset: 0x2732C1 VA: 0x2731C0
private sealed class Nex.DataStore.Impl.<>c__DisplayClass55_0 // TypeDefIndex: 8308
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public List<DataStoreRatingTarget> targets; // 0x18
	public DataStoreRateObjectParam rateParam; // 0x20
	public DataStorePreparePostParam postParam; // 0x28
	public DataStore.RatingInfoListCB callback; // 0x30

	// Methods

	// RVA: 0x2D7D7B0 Offset: 0x2D7D8B1 VA: 0x2D7D7B0
	public void .ctor() { }

	// RVA: 0x2D7D7C0 Offset: 0x2D7D8C1 VA: 0x2D7D7C0
	internal void <RateWithPostingAsyncImpl>b__1(AsyncResult asyncResult, List<DataStoreRatingInfo> infos, List<DataStoreResult> results) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2731E0 Offset: 0x2732E1 VA: 0x2731E0
private sealed class Nex.DataStore.Impl.<>c__DisplayClass61_0 // TypeDefIndex: 8310
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public List<DataStoreDeleteParam> param; // 0x18
	public DataStore.ResultListCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D830 Offset: 0x2D7D931 VA: 0x2D7D830
	public void .ctor() { }

	// RVA: 0x2D7D840 Offset: 0x2D7D941 VA: 0x2D7D840
	internal void <DeleteAsyncImpl>b__0(AsyncResult asyncResult, List<DataStoreResult> deleteResults) { }
}

// Namespace: 
private class Nex.DataStore.Impl : SingletonClass<Nex.DataStore.Impl> // TypeDefIndex: 8312
{
	// Fields
	private Nex.DataStore.GetParamPool m_GetParamPool; // 0x20
	private Nex.DataStore.GetMetaParamListPool m_GetMetaParamListPool; // 0x28
	private Nex.DataStore.GetMetaParamPool m_GetMetaParamPool; // 0x30
	private Nex.DataStore.PostParamPool m_PostParamPool; // 0x38
	private Nex.DataStore.UpdateParamPool m_UpdateParamPool; // 0x40
	private Nex.DataStore.ChangeMetaParamPool m_ChangeMetaParamPool; // 0x48
	private Nex.DataStore.RatingInitParamPool m_RatingInitParamPool; // 0x50
	private Nex.DataStore.RatingTargetListPool m_RatingTargetListPool; // 0x58
	private Nex.DataStore.RatingTargetPool m_RatingTargetPool; // 0x60
	private Nex.DataStore.RateObjectParamPool m_RateObjectParamPool; // 0x68
	private Nex.DataStore.DeleteParamListPool m_DeleteParamListPool; // 0x70
	private Nex.DataStore.DeleteParamPool m_DeleteParamPool; // 0x78
	private Nex.DataStore.DataStoreApiCallChecker m_ApiCallChecker; // 0x80

	// Methods

	// RVA: 0x21EDD40 Offset: 0x21EDE41 VA: 0x21EDD40
	public void .ctor() { }

	// RVA: 0x21EE570 Offset: 0x21EE671 VA: 0x21EE570
	public DataStoreSearchParam GetSearchParam() { }

	// RVA: 0x21EE5D0 Offset: 0x21EE6D1 VA: 0x21EE5D0
	public Nex.Result SearchAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback) { }

	// RVA: 0x21EE730 Offset: 0x21EE831 VA: 0x21EE730
	public Nex.Result SearchLightAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback) { }

	// RVA: 0x21EE5E0 Offset: 0x21EE6E1 VA: 0x21EE5E0
	private Nex.Result SearchAsyncCommon(DataStoreSearchParam param, DataStore.SearchObjectCB callback, bool isLight) { }

	// RVA: 0x21EE740 Offset: 0x21EE841 VA: 0x21EE740
	public DataStorePrepareGetParam GetGetParam() { }

	// RVA: 0x21EE7A0 Offset: 0x21EE8A1 VA: 0x21EE7A0
	public Nex.Result GetAsync(DataStorePrepareGetParam param, ulong bufferSize, DataStore.GetObjectCB callback) { }

	// RVA: 0x21EE820 Offset: 0x21EE921 VA: 0x21EE820
	private Nex.Result GetAsyncImpl(DataStorePrepareGetParam param, ulong bufferSize, DataStore.GetObjectCB callback) { }

	// RVA: 0x21EE970 Offset: 0x21EEA71 VA: 0x21EE970
	private void UnmarkParamsForGet(DataStorePrepareGetParam param) { }

	// RVA: 0x21EE9D0 Offset: 0x21EEAD1 VA: 0x21EE9D0
	public List<DataStoreGetMetaParam> GetGetMetaParamList() { }

	// RVA: 0x21EEA30 Offset: 0x21EEB31 VA: 0x21EEA30
	public DataStoreGetMetaParam GetGetMetaParam() { }

	// RVA: 0x21EEA90 Offset: 0x21EEB91 VA: 0x21EEA90
	public Nex.Result GetMetaAsync(DataStoreGetMetaParam param, DataStore.GetMetaCB callback) { }

	// RVA: 0x21EECB0 Offset: 0x21EEDB1 VA: 0x21EECB0
	public Nex.Result GetMetaAsync(List<ulong> dataIds, DataStoreGetMetaParam param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x21EEE80 Offset: 0x21EEF81 VA: 0x21EEE80
	public Nex.Result GetMetaAsync(List<DataStoreGetMetaParam> param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x21EEB10 Offset: 0x21EEC11 VA: 0x21EEB10
	private Nex.Result GetMetaAsyncImpl(DataStoreGetMetaParam param, DataStore.GetMetaCB callback) { }

	// RVA: 0x21EED30 Offset: 0x21EEE31 VA: 0x21EED30
	private Nex.Result GetMetaAsyncImpl(List<ulong> dataIds, DataStoreGetMetaParam param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x21EEF20 Offset: 0x21EF021 VA: 0x21EEF20
	private Nex.Result GetMetaAsyncImpl(List<DataStoreGetMetaParam> param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x21EEC50 Offset: 0x21EED51 VA: 0x21EEC50
	private void UnmarkParamsForGetMeta(DataStoreGetMetaParam param) { }

	// RVA: 0x21EF060 Offset: 0x21EF161 VA: 0x21EF060
	private void UnmarkParamsForGetMeta(List<DataStoreGetMetaParam> paramList) { }

	// RVA: 0x21EF0F0 Offset: 0x21EF1F1 VA: 0x21EF0F0
	public Nex.Result GetPersistenceInfoAsync(ulong principalId, ushort slot, DataStore.GetPersistenceInfoCB callback) { }

	// RVA: 0x21EF220 Offset: 0x21EF321 VA: 0x21EF220
	public DataStorePreparePostParam GetPostParam() { }

	// RVA: 0x21EF280 Offset: 0x21EF381 VA: 0x21EF280
	public Nex.Result PostAsync(DataStorePreparePostParam param, byte[] buffer, DataStore.PostCB callback) { }

	// RVA: 0x21EF310 Offset: 0x21EF411 VA: 0x21EF310
	private Nex.Result PostAsyncImpl(DataStorePreparePostParam param, byte[] buffer, DataStore.PostCB callback) { }

	// RVA: 0x21EF470 Offset: 0x21EF571 VA: 0x21EF470
	private void UnmarkParamsForPost(DataStorePreparePostParam param) { }

	// RVA: 0x21EF870 Offset: 0x21EF971 VA: 0x21EF870
	public Nex.Result PostMetaAsync(DataStorePreparePostParam param, DataStore.PostCB callback) { }

	// RVA: 0x21EF900 Offset: 0x21EFA01 VA: 0x21EF900
	private Nex.Result PostMetaAsyncImpl(DataStorePreparePostParam param, DataStore.PostCB callback) { }

	// RVA: 0x21EFA40 Offset: 0x21EFB41 VA: 0x21EFA40
	public Nex.Result CompleteSuspendedPostAsync(List<ulong> dataIds, AsyncResultCB callback) { }

	// RVA: 0x21EFB40 Offset: 0x21EFC41 VA: 0x21EFB40
	public DataStorePrepareUpdateParam GetUpdateParam() { }

	// RVA: 0x21EFBA0 Offset: 0x21EFCA1 VA: 0x21EFBA0
	public Nex.Result UpdateAsync(DataStorePrepareUpdateParam param, byte[] buffer, AsyncResultCB callback) { }

	// RVA: 0x21EFC20 Offset: 0x21EFD21 VA: 0x21EFC20
	private Nex.Result UpdateAsyncImpl(DataStorePrepareUpdateParam param, byte[] buffer, AsyncResultCB callback) { }

	// RVA: 0x21EFD80 Offset: 0x21EFE81 VA: 0x21EFD80
	private void UnmarkParamsForUpdate(DataStorePrepareUpdateParam param) { }

	// RVA: 0x21EFDE0 Offset: 0x21EFEE1 VA: 0x21EFDE0
	public DataStoreChangeMetaParam GetChangeMetaParam() { }

	// RVA: 0x21EFE40 Offset: 0x21EFF41 VA: 0x21EFE40
	public Nex.Result ChangeMetaAsync(DataStoreChangeMetaParam param, AsyncResultCB callback) { }

	// RVA: 0x21EFEC0 Offset: 0x21EFFC1 VA: 0x21EFEC0
	private Nex.Result ChangeMetaAsyncImpl(DataStoreChangeMetaParam param, AsyncResultCB callback) { }

	// RVA: 0x21F0000 Offset: 0x21F0101 VA: 0x21F0000
	private void UnmarkParamsForChangeMeta(DataStoreChangeMetaParam param) { }

	// RVA: 0x21F0060 Offset: 0x21F0161 VA: 0x21F0060
	public DataStoreRatingInitParam GetRatingInitParam() { }

	// RVA: 0x21F00C0 Offset: 0x21F01C1 VA: 0x21F00C0
	public List<DataStoreRatingTarget> GetRatingTargetList() { }

	// RVA: 0x21F0120 Offset: 0x21F0221 VA: 0x21F0120
	public DataStoreRatingTarget GetRatingTarget() { }

	// RVA: 0x21F0180 Offset: 0x21F0281 VA: 0x21F0180
	public DataStoreRateObjectParam GetRateObjectParam() { }

	// RVA: 0x21F01E0 Offset: 0x21F02E1 VA: 0x21F01E0
	public Nex.Result RateAsync(DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStore.RatingInfoCB callback) { }

	// RVA: 0x21F0290 Offset: 0x21F0391 VA: 0x21F0290
	private Nex.Result RateAsyncImpl(DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStore.RatingInfoCB callback) { }

	// RVA: 0x21F0480 Offset: 0x21F0581 VA: 0x21F0480
	public Nex.Result RateWithPostingAsync(List<DataStoreRatingTarget> targets, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x21F04E0 Offset: 0x21F05E1 VA: 0x21F04E0
	private Nex.Result RateWithPostingAsyncImpl(List<DataStoreRatingTarget> targets, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x21F03F0 Offset: 0x21F04F1 VA: 0x21F03F0
	private void UnmarkParamsForRate(DataStoreRatingTarget target, DataStoreRateObjectParam rateParam) { }

	// RVA: 0x21F0770 Offset: 0x21F0871 VA: 0x21F0770
	private void UnmarkParamsForRateWithPosting(List<DataStoreRatingTarget> targets, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam) { }

	// RVA: 0x21F0870 Offset: 0x21F0971 VA: 0x21F0870
	public List<DataStoreDeleteParam> GetDeleteParamList() { }

	// RVA: 0x21F08D0 Offset: 0x21F09D1 VA: 0x21F08D0
	public DataStoreDeleteParam GetDeleteParam() { }

	// RVA: 0x21F0930 Offset: 0x21F0A31 VA: 0x21F0930
	public Nex.Result DeleteAsync(List<DataStoreDeleteParam> param, DataStore.ResultListCB callback) { }

	// RVA: 0x21F09D0 Offset: 0x21F0AD1 VA: 0x21F09D0
	private Nex.Result DeleteAsyncImpl(List<DataStoreDeleteParam> param, DataStore.ResultListCB callback) { }

	// RVA: 0x21F0B10 Offset: 0x21F0C11 VA: 0x21F0B10
	private void UnmarkParamsForDelete(List<DataStoreDeleteParam> param) { }

	// RVA: 0x21F0BA0 Offset: 0x21F0CA1 VA: 0x21F0BA0
	public Nex.Result UnperpetuateAsync(ushort persistenceSlotId, bool deleteLastObject, AsyncResultCB callback) { }
}

// Namespace: 
private abstract class Nex.DataStore.ParamPool<T> // TypeDefIndex: 8314
{
	// Fields
	private Nex.DataStore.ParamPool.Data<T>[] m_Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60C30 Offset: 0x2A60D31 VA: 0x2A60C30
	|-Nex.DataStore.ParamPool<List<DataStoreDeleteParam>>..ctor
	|-Nex.DataStore.ParamPool<List<DataStoreGetMetaParam>>..ctor
	|-Nex.DataStore.ParamPool<List<DataStoreRatingTarget>>..ctor
	|-Nex.DataStore.ParamPool<DataStoreChangeMetaParam>..ctor
	|-Nex.DataStore.ParamPool<DataStoreDeleteParam>..ctor
	|-Nex.DataStore.ParamPool<DataStoreGetMetaParam>..ctor
	|-Nex.DataStore.ParamPool<DataStorePrepareGetParam>..ctor
	|-Nex.DataStore.ParamPool<DataStorePreparePostParam>..ctor
	|-Nex.DataStore.ParamPool<DataStorePrepareUpdateParam>..ctor
	|-Nex.DataStore.ParamPool<DataStoreRateObjectParam>..ctor
	|-Nex.DataStore.ParamPool<DataStoreRatingInitParam>..ctor
	|-Nex.DataStore.ParamPool<DataStoreRatingTarget>..ctor
	|-Nex.DataStore.ParamPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60CB0 Offset: 0x2A60DB1 VA: 0x2A60CB0
	|-Nex.DataStore.ParamPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60D60 Offset: 0x2A60E61 VA: 0x2A60D60
	|-Nex.DataStore.ParamPool<List<DataStoreDeleteParam>>.Get
	|-Nex.DataStore.ParamPool<List<DataStoreGetMetaParam>>.Get
	|-Nex.DataStore.ParamPool<List<DataStoreRatingTarget>>.Get
	|-Nex.DataStore.ParamPool<DataStoreChangeMetaParam>.Get
	|-Nex.DataStore.ParamPool<DataStoreDeleteParam>.Get
	|-Nex.DataStore.ParamPool<DataStoreGetMetaParam>.Get
	|-Nex.DataStore.ParamPool<DataStorePrepareGetParam>.Get
	|-Nex.DataStore.ParamPool<DataStorePreparePostParam>.Get
	|-Nex.DataStore.ParamPool<DataStorePrepareUpdateParam>.Get
	|-Nex.DataStore.ParamPool<DataStoreRateObjectParam>.Get
	|-Nex.DataStore.ParamPool<DataStoreRatingInitParam>.Get
	|-Nex.DataStore.ParamPool<DataStoreRatingTarget>.Get
	|-Nex.DataStore.ParamPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	private void Mark(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60F40 Offset: 0x2A61041 VA: 0x2A60F40
	|-Nex.DataStore.ParamPool<object>.Mark
	*/

	// RVA: -1 Offset: -1
	public void Unmark(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60F90 Offset: 0x2A61091 VA: 0x2A60F90
	|-Nex.DataStore.ParamPool<List<DataStoreDeleteParam>>.Unmark
	|-Nex.DataStore.ParamPool<List<DataStoreGetMetaParam>>.Unmark
	|-Nex.DataStore.ParamPool<List<DataStoreRatingTarget>>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreChangeMetaParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreGetMetaParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStorePrepareGetParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStorePreparePostParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStorePrepareUpdateParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreRateObjectParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreRatingInitParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreRatingTarget>.Unmark
	|-Nex.DataStore.ParamPool<object>.Unmark
	*/

	// RVA: -1 Offset: -1
	public void Unmark(List<T> paramList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60FE0 Offset: 0x2A610E1 VA: 0x2A60FE0
	|-Nex.DataStore.ParamPool<DataStoreDeleteParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreGetMetaParam>.Unmark
	|-Nex.DataStore.ParamPool<DataStoreRatingTarget>.Unmark
	|-Nex.DataStore.ParamPool<object>.Unmark
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ResetParam(T param);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Nex.DataStore.ParamPool<object>.ResetParam
	*/
}

// Namespace: 
private class Nex.DataStore.GetParamPool : Nex.DataStore.ParamPool<DataStorePrepareGetParam> // TypeDefIndex: 8316
{
	// Methods

	// RVA: 0x21EDCD0 Offset: 0x21EDDD1 VA: 0x21EDCD0
	public void .ctor() { }

	// RVA: 0x21EDD30 Offset: 0x21EDE31 VA: 0x21EDD30 Slot: 4
	protected override void ResetParam(DataStorePrepareGetParam param) { }
}

// Namespace: 
private class Nex.DataStore.GetMetaParamPool : Nex.DataStore.ParamPool<DataStoreGetMetaParam> // TypeDefIndex: 8318
{
	// Methods

	// RVA: 0x21EDC60 Offset: 0x21EDD61 VA: 0x21EDC60
	public void .ctor() { }

	// RVA: 0x21EDCC0 Offset: 0x21EDDC1 VA: 0x21EDCC0 Slot: 4
	protected override void ResetParam(DataStoreGetMetaParam param) { }
}

// Namespace: 
private class Nex.DataStore.ChangeMetaParamPool : Nex.DataStore.ParamPool<DataStoreChangeMetaParam> // TypeDefIndex: 8320
{
	// Methods

	// RVA: 0x21ED720 Offset: 0x21ED821 VA: 0x21ED720
	public void .ctor() { }

	// RVA: 0x21ED780 Offset: 0x21ED881 VA: 0x21ED780 Slot: 4
	protected override void ResetParam(DataStoreChangeMetaParam param) { }
}

// Namespace: 
private class Nex.DataStore.RatingTargetListPool : Nex.DataStore.ParamPool<List<DataStoreRatingTarget>> // TypeDefIndex: 8322
{
	// Methods

	// RVA: 0x21EE450 Offset: 0x21EE551 VA: 0x21EE450
	public void .ctor() { }

	// RVA: 0x21F0D00 Offset: 0x21F0E01 VA: 0x21F0D00 Slot: 4
	protected override void ResetParam(List<DataStoreRatingTarget> param) { }
}

// Namespace: 
private class Nex.DataStore.RateObjectParamPool : Nex.DataStore.ParamPool<DataStoreRateObjectParam> // TypeDefIndex: 8324
{
	// Methods

	// RVA: 0x21EE510 Offset: 0x21EE611 VA: 0x21EE510
	public void .ctor() { }

	// RVA: 0x21F0CE0 Offset: 0x21F0DE1 VA: 0x21F0CE0 Slot: 4
	protected override void ResetParam(DataStoreRateObjectParam param) { }
}

// Namespace: 
private class Nex.DataStore.DeleteParamPool : Nex.DataStore.ParamPool<DataStoreDeleteParam> // TypeDefIndex: 8326
{
	// Methods

	// RVA: 0x21EDB30 Offset: 0x21EDC31 VA: 0x21EDB30
	public void .ctor() { }

	// RVA: 0x21EDB90 Offset: 0x21EDC91 VA: 0x21EDB90 Slot: 4
	protected override void ResetParam(DataStoreDeleteParam param) { }
}

// Namespace: 
private class Nex.DataStore.DataStoreApiCallChecker : Nex.ApiCallChecker // TypeDefIndex: 8328
{
	// Fields
	private static readonly Nex.ApiCallChecker.Guideline[] Guidelines; // 0x0

	// Methods

	// RVA: 0x21ED790 Offset: 0x21ED891 VA: 0x21ED790
	public void .ctor() { }

	// RVA: 0x21ED810 Offset: 0x21ED911 VA: 0x21ED810
	public bool Run(Nex.DataStore.Api api) { }

	// RVA: 0x21ED820 Offset: 0x21ED921 VA: 0x21ED820 Slot: 4
	protected override void DbgOnInvalidApi(int api) { }

	// RVA: 0x21ED830 Offset: 0x21ED931 VA: 0x21ED830 Slot: 5
	protected override void DbgOnTooMuchCall(int api) { }

	// RVA: 0x21ED900 Offset: 0x21EDA01 VA: 0x21ED900 Slot: 6
	protected override void DbgOnFullCalledTimes(int api) { }

	// RVA: 0x21ED910 Offset: 0x21EDA11 VA: 0x21ED910
	private static void .cctor() { }
}

// Namespace: 
public static class Nex.DataStoreDataCode // TypeDefIndex: 8330
{
	// Methods

	// RVA: 0x26EAB80 Offset: 0x26EAC81 VA: 0x26EAB80
	public static string DataId2DataCode(ulong dataId) { }

	// RVA: 0x26EABF0 Offset: 0x26EACF1 VA: 0x26EABF0
	public static ulong DataCode2DataId(string dataCode) { }
}

// Namespace: 
private class Nex.DispatchHigh : Nex.DispatchBase<Nex.DispatchHigh> // TypeDefIndex: 8332
{
	// Methods

	// RVA: 0x26EAC60 Offset: 0x26EAD61 VA: 0x26EAC60
	protected void .ctor() { }

	// RVA: 0x26EACC0 Offset: 0x26EADC1 VA: 0x26EACC0
	public static void Create() { }
}

// Namespace: 
private enum Nex.DispatchKeepAlive.Status // TypeDefIndex: 8334
{
	// Fields
	public int value__; // 0x0
	public const Nex.DispatchKeepAlive.Status Wait = 0;
	public const Nex.DispatchKeepAlive.Status Run = 1;
	public const Nex.DispatchKeepAlive.Status End = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273200 Offset: 0x273301 VA: 0x273200
private sealed class Nex.GameServer.Impl.<>c__DisplayClass2_0 // TypeDefIndex: 8336
{
	// Fields
	public Nex.GameServer.Impl <>4__this; // 0x10
	public AsyncResultCB callback; // 0x18

	// Methods

	// RVA: 0x2D7D8D0 Offset: 0x2D7D9D1 VA: 0x2D7D8D0
	public void .ctor() { }

	// RVA: 0x2D7D8E0 Offset: 0x2D7D9E1 VA: 0x2D7D8E0
	internal void <LoginAsync>b__0(AsyncResult asyncResult, ulong principalId, IntPtr ngsFacadePtr) { }
}

// Namespace: 
private class Nex.GameServer.Impl : SingletonClass<Nex.GameServer.Impl> // TypeDefIndex: 8338
{
	// Fields
	private ulong m_PrincipalId; // 0x20
	private IntPtr m_NgsFacadePtr; // 0x28

	// Properties
	public ulong PrincipalId { get; }
	public IntPtr NgsFacadePtr { get; }

	// Methods

	// RVA: 0x21F0D80 Offset: 0x21F0E81 VA: 0x21F0D80
	public Nex.Result LoginAsync(AsyncResultCB callback) { }

	// RVA: 0x21F1020 Offset: 0x21F1121 VA: 0x21F1020
	public Nex.Result LogoutAsync(AsyncResultCB callback) { }

	// RVA: 0x21F1120 Offset: 0x21F1221 VA: 0x21F1120
	public Result IsConnected() { }

	// RVA: 0x21F1140 Offset: 0x21F1241 VA: 0x21F1140
	public ulong get_PrincipalId() { }

	// RVA: 0x21F1150 Offset: 0x21F1251 VA: 0x21F1150
	public IntPtr get_NgsFacadePtr() { }

	// RVA: 0x21F1160 Offset: 0x21F1261 VA: 0x21F1160
	public void .ctor() { }
}

// Namespace: 
public static class Nex.Log // TypeDefIndex: 8340
{
	// Fields
	private const string Header = "[NexLog]";

	// Methods

	[ConditionalAttribute] // RVA: 0x2A7690 Offset: 0x2A7791 VA: 0x2A7690
	// RVA: 0x26EBA80 Offset: 0x26EBB81 VA: 0x26EBA80
	public static void Call(string methodName, object param1, object param2) { }

	[ConditionalAttribute] // RVA: 0x2A76D0 Offset: 0x2A77D1 VA: 0x2A76D0
	// RVA: 0x26EBAA0 Offset: 0x26EBBA1 VA: 0x26EBAA0
	public static void CallResult(bool isSuccess) { }

	[ConditionalAttribute] // RVA: 0x2A7710 Offset: 0x2A7811 VA: 0x2A7710
	// RVA: 0x26EBAB0 Offset: 0x26EBBB1 VA: 0x26EBAB0
	public static void AsyncResult(AsyncResult asyncResult, string msg) { }

	[ConditionalAttribute] // RVA: 0x2A7750 Offset: 0x2A7851 VA: 0x2A7750
	// RVA: 0x26EBAE0 Offset: 0x26EBBE1 VA: 0x26EBAE0
	public static void Message(string msg) { }

	// RVA: 0x26EBA90 Offset: 0x26EBB91 VA: 0x26EBA90
	private static bool IsEnable() { }
}

// Namespace: 
public static class Nex.QError // TypeDefIndex: 8342
{
	// Fields
	public const int ErrorBit = -2147483648;
}

// Namespace: 
private class Nex.Screening.Impl : SingletonClass<Nex.Screening.Impl> // TypeDefIndex: 8344
{
	// Fields
	private Nex.Screening.DataStoreContentParamPool m_DataStoreContentParamPool; // 0x20
	private Nex.Screening.UgcViolationParamPool m_UgcViolationParamPool; // 0x28

	// Methods

	// RVA: 0x21F1250 Offset: 0x21F1351 VA: 0x21F1250
	public void .ctor() { }

	// RVA: 0x21F1410 Offset: 0x21F1511 VA: 0x21F1410
	public ScreeningDataStoreContentParam GetDataStoreContentParam() { }

	// RVA: 0x21F1470 Offset: 0x21F1571 VA: 0x21F1470
	public ScreeningUgcViolationParam GetUgcViolationParam() { }

	// RVA: 0x21F14D0 Offset: 0x21F15D1 VA: 0x21F14D0
	public Nex.Result ReportDataStoreContentAsync(ScreeningDataStoreContentParam contentParam, ScreeningUgcViolationParam violationParam, AsyncResultCB callback) { }

	// RVA: 0x21F1580 Offset: 0x21F1681 VA: 0x21F1580
	private Nex.Result ReportDataStoreContentAsyncImpl(ScreeningDataStoreContentParam contentParam, ScreeningUgcViolationParam violationParam, AsyncResultCB callback) { }

	// RVA: 0x21F16D0 Offset: 0x21F17D1 VA: 0x21F16D0
	private void UnmarkParamsForReportDataStoreContent(ScreeningDataStoreContentParam contentParam, ScreeningUgcViolationParam violationParam) { }
}

// Namespace: 
private abstract class Nex.Screening.ParamPool<T> // TypeDefIndex: 8346
{
	// Fields
	private Nex.Screening.ParamPool.Data<T>[] m_Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61080 Offset: 0x2A61181 VA: 0x2A61080
	|-Nex.Screening.ParamPool<object>..ctor
	|-Nex.Screening.ParamPool<ScreeningDataStoreContentParam>..ctor
	|-Nex.Screening.ParamPool<ScreeningUgcViolationParam>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61100 Offset: 0x2A61201 VA: 0x2A61100
	|-Nex.Screening.ParamPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A611B0 Offset: 0x2A612B1 VA: 0x2A611B0
	|-Nex.Screening.ParamPool<object>.Get
	|-Nex.Screening.ParamPool<ScreeningDataStoreContentParam>.Get
	|-Nex.Screening.ParamPool<ScreeningUgcViolationParam>.Get
	*/

	// RVA: -1 Offset: -1
	private void Mark(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61390 Offset: 0x2A61491 VA: 0x2A61390
	|-Nex.Screening.ParamPool<object>.Mark
	*/

	// RVA: -1 Offset: -1
	public void Unmark(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A613E0 Offset: 0x2A614E1 VA: 0x2A613E0
	|-Nex.Screening.ParamPool<object>.Unmark
	|-Nex.Screening.ParamPool<ScreeningDataStoreContentParam>.Unmark
	|-Nex.Screening.ParamPool<ScreeningUgcViolationParam>.Unmark
	*/

	// RVA: -1 Offset: -1
	public void Unmark(List<T> paramList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61430 Offset: 0x2A61531 VA: 0x2A61430
	|-Nex.Screening.ParamPool<object>.Unmark
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ResetParam(T param);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Nex.Screening.ParamPool<object>.ResetParam
	*/
}

// Namespace: 
private class Nex.Screening.UgcViolationParamPool : Nex.Screening.ParamPool<ScreeningUgcViolationParam> // TypeDefIndex: 8348
{
	// Methods

	// RVA: 0x21F13B0 Offset: 0x21F14B1 VA: 0x21F13B0
	public void .ctor() { }

	// RVA: 0x21F1760 Offset: 0x21F1861 VA: 0x21F1760 Slot: 4
	protected override void ResetParam(ScreeningUgcViolationParam param) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273230 Offset: 0x273331 VA: 0x273230
private sealed class Nex.Utility.Impl.<>c__DisplayClass2_0 // TypeDefIndex: 8350
{
	// Fields
	public Utility.GetIntegerSettingsCB callback; // 0x10

	// Methods

	// RVA: 0x2D7DA40 Offset: 0x2D7DB41 VA: 0x2D7DA40
	public void .ctor() { }

	// RVA: 0x2D7DA50 Offset: 0x2D7DB51 VA: 0x2D7DA50
	internal void <GetIntegerSettingsAsync>b__0(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings) { }
}

// Namespace: 
private enum Nex.Utility.Api // TypeDefIndex: 8352
{
	// Fields
	public int value__; // 0x0
	public const Nex.Utility.Api AcquireNexUniqueId = 0;
	public const Nex.Utility.Api AcquireNexUniqueIdWithPassword = 1;
	public const Nex.Utility.Api AssociateNexUniqueIdWithMyPrincipalId = 2;
	public const Nex.Utility.Api GetAssociatedNexUniqueIdWithMyPrincipalId = 3;
	public const Nex.Utility.Api GetIntegerSettings = 4;
	public const Nex.Utility.Api Max = 5;
}

// Namespace: 
public static class Nex.Utility // TypeDefIndex: 8354
{
	// Methods

	// RVA: 0x26EC1D0 Offset: 0x26EC2D1 VA: 0x26EC1D0
	public static void TryInitialize() { }

	// RVA: 0x26EC260 Offset: 0x26EC361 VA: 0x26EC260
	public static void TryCleanup() { }

	// RVA: 0x26EC2E0 Offset: 0x26EC3E1 VA: 0x26EC2E0
	public static Nex.Result GetIntegerSettingsAsync(uint integerSettingIndex, Utility.GetIntegerSettingsCB callback) { }
}

