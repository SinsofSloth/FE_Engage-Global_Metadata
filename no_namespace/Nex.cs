// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2730F0 Offset: 0x2731F1 VA: 0x2730F0
private sealed class Nex.SystemImpl.<>c__DisplayClass2_0 // TypeDefIndex: 8289
{
	// Fields
	public AsyncResultCB callback; // 0x10

	// Methods

	// RVA: 0x21F1770 Offset: 0x21F1871 VA: 0x21F1770
	public void .ctor() { }

	// RVA: 0x21F1780 Offset: 0x21F1881 VA: 0x21F1780
	internal void <InitializeNexAsync>b__0(AsyncResult asyncResult) { }
}

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
public struct Nex.ApiCallChecker.Guideline // TypeDefIndex: 8291
{
	// Fields
	public int limitCount; // 0x0
	public int seconds; // 0x4
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
private enum Nex.AutoLogoutFinalize.Label // TypeDefIndex: 8293
{
	// Fields
	public int value__; // 0x0
	public const Nex.AutoLogoutFinalize.Label WaitInitializeNex = 0;
	public const Nex.AutoLogoutFinalize.Label WaitLogin = 1;
	public const Nex.AutoLogoutFinalize.Label WaitDisconnect = 2;
	public const Nex.AutoLogoutFinalize.Label Logout = 3;
	public const Nex.AutoLogoutFinalize.Label FinalizeNex = 4;
	public const Nex.AutoLogoutFinalize.Label End = 5;
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
public enum Nex.Result // TypeDefIndex: 8295
{
	// Fields
	public int value__; // 0x0
	public const Nex.Result Success = 0;
	public const Nex.Result Failure = 1;
	public const Nex.Result TooMuchCall = 2;
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
[CompilerGeneratedAttribute] // RVA: 0x273110 Offset: 0x273211 VA: 0x273110
private sealed class Nex.DataStore.Impl.<>c__DisplayClass20_0 // TypeDefIndex: 8297
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStorePrepareGetParam param; // 0x18
	public DataStore.GetObjectCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D350 Offset: 0x2D7D451 VA: 0x2D7D350
	public void .ctor() { }

	// RVA: 0x2D7D360 Offset: 0x2D7D461 VA: 0x2D7D360
	internal void <GetAsyncImpl>b__0(AsyncResult asyncResult, byte[] data) { }
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
[CompilerGeneratedAttribute] // RVA: 0x273130 Offset: 0x273231 VA: 0x273130
private sealed class Nex.DataStore.Impl.<>c__DisplayClass28_0 // TypeDefIndex: 8299
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStoreGetMetaParam param; // 0x18
	public DataStore.GetMetaListCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D430 Offset: 0x2D7D531 VA: 0x2D7D430
	public void .ctor() { }

	// RVA: 0x2D7D440 Offset: 0x2D7D541 VA: 0x2D7D440
	internal void <GetMetaAsyncImpl>b__0(AsyncResult asyncResult, List<DataStoreMetaInfo> infos, List<DataStoreResult> results) { }
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
[CompilerGeneratedAttribute] // RVA: 0x273150 Offset: 0x273251 VA: 0x273150
private sealed class Nex.DataStore.Impl.<>c__DisplayClass32_0 // TypeDefIndex: 8301
{
	// Fields
	public DataStore.GetPersistenceInfoCB callback; // 0x10

	// Methods

	// RVA: 0x2D7D530 Offset: 0x2D7D631 VA: 0x2D7D530
	public void .ctor() { }

	// RVA: 0x2D7D540 Offset: 0x2D7D641 VA: 0x2D7D540
	internal void <GetPersistenceInfoAsync>b__0(AsyncResult asyncResult, DataStorePersistenceInfo info) { }
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
[CompilerGeneratedAttribute] // RVA: 0x273170 Offset: 0x273271 VA: 0x273170
private sealed class Nex.DataStore.Impl.<>c__DisplayClass38_0 // TypeDefIndex: 8303
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStorePreparePostParam param; // 0x18
	public DataStore.PostCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D5D0 Offset: 0x2D7D6D1 VA: 0x2D7D5D0
	public void .ctor() { }

	// RVA: 0x2D7D5E0 Offset: 0x2D7D6E1 VA: 0x2D7D5E0
	internal void <PostMetaAsyncImpl>b__0(AsyncResult asyncResult, ulong dataId) { }
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
[CompilerGeneratedAttribute] // RVA: 0x273190 Offset: 0x273291 VA: 0x273190
private sealed class Nex.DataStore.Impl.<>c__DisplayClass42_0 // TypeDefIndex: 8305
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStorePrepareUpdateParam param; // 0x18
	public AsyncResultCB callback; // 0x20

	// Methods

	// RVA: 0x2D7D670 Offset: 0x2D7D771 VA: 0x2D7D670
	public void .ctor() { }

	// RVA: 0x2D7D680 Offset: 0x2D7D781 VA: 0x2D7D680
	internal void <UpdateAsyncImpl>b__0(AsyncResult asyncResult) { }
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
[CompilerGeneratedAttribute] // RVA: 0x2731B0 Offset: 0x2732B1 VA: 0x2731B0
private sealed class Nex.DataStore.Impl.<>c__DisplayClass53_0 // TypeDefIndex: 8307
{
	// Fields
	public Nex.DataStore.Impl <>4__this; // 0x10
	public DataStoreRatingTarget target; // 0x18
	public DataStoreRateObjectParam rateParam; // 0x20
	public DataStore.RatingInfoCB callback; // 0x28

	// Methods

	// RVA: 0x2D7D730 Offset: 0x2D7D831 VA: 0x2D7D730
	public void .ctor() { }

	// RVA: 0x2D7D740 Offset: 0x2D7D841 VA: 0x2D7D740
	internal void <RateAsyncImpl>b__0(AsyncResult asyncResult, DataStoreRatingInfo info) { }
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
[CompilerGeneratedAttribute] // RVA: 0x2731D0 Offset: 0x2732D1 VA: 0x2731D0
[Serializable]
private sealed class Nex.DataStore.Impl.<>c // TypeDefIndex: 8309
{
	// Fields
	public static readonly Nex.DataStore.Impl.<>c <>9; // 0x0
	public static Comparison<DataStoreRatingTarget> <>9__55_0; // 0x8

	// Methods

	// RVA: 0x2D7D260 Offset: 0x2D7D361 VA: 0x2D7D260
	private static void .cctor() { }

	// RVA: 0x2D7D2D0 Offset: 0x2D7D3D1 VA: 0x2D7D2D0
	public void .ctor() { }

	// RVA: 0x2D7D2E0 Offset: 0x2D7D3E1 VA: 0x2D7D2E0
	internal int <RateWithPostingAsyncImpl>b__55_0(DataStoreRatingTarget x, DataStoreRatingTarget y) { }
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
[CompilerGeneratedAttribute] // RVA: 0x2731F0 Offset: 0x2732F1 VA: 0x2731F0
private sealed class Nex.DataStore.Impl.<>c__DisplayClass63_0 // TypeDefIndex: 8311
{
	// Fields
	public AsyncResultCB callback; // 0x10

	// Methods

	// RVA: 0x2D7D8A0 Offset: 0x2D7D9A1 VA: 0x2D7D8A0
	public void .ctor() { }

	// RVA: 0x2D7D8B0 Offset: 0x2D7D9B1 VA: 0x2D7D8B0
	internal void <UnperpetuateAsync>b__0(AsyncResult asyncResult) { }
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
private struct Nex.DataStore.ParamPool.Data<T> // TypeDefIndex: 8313
{
	// Fields
	public T param; // 0x0
	public bool isUsed; // 0x0
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
private class Nex.DataStore.PostParamPool : Nex.DataStore.ParamPool<DataStorePreparePostParam> // TypeDefIndex: 8315
{
	// Methods

	// RVA: 0x21EE330 Offset: 0x21EE431 VA: 0x21EE330
	public void .ctor() { }

	// RVA: 0x21F0CD0 Offset: 0x21F0DD1 VA: 0x21F0CD0 Slot: 4
	protected override void ResetParam(DataStorePreparePostParam param) { }
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
private class Nex.DataStore.GetMetaParamListPool : Nex.DataStore.ParamPool<List<DataStoreGetMetaParam>> // TypeDefIndex: 8317
{
	// Methods

	// RVA: 0x21EDBA0 Offset: 0x21EDCA1 VA: 0x21EDBA0
	public void .ctor() { }

	// RVA: 0x21EDC00 Offset: 0x21EDD01 VA: 0x21EDC00 Slot: 4
	protected override void ResetParam(List<DataStoreGetMetaParam> param) { }
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
private class Nex.DataStore.UpdateParamPool : Nex.DataStore.ParamPool<DataStorePrepareUpdateParam> // TypeDefIndex: 8319
{
	// Methods

	// RVA: 0x21EE390 Offset: 0x21EE491 VA: 0x21EE390
	public void .ctor() { }

	// RVA: 0x21F0D70 Offset: 0x21F0E71 VA: 0x21F0D70 Slot: 4
	protected override void ResetParam(DataStorePrepareUpdateParam param) { }
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
private class Nex.DataStore.RatingInitParamPool : Nex.DataStore.ParamPool<DataStoreRatingInitParam> // TypeDefIndex: 8321
{
	// Methods

	// RVA: 0x21EE3F0 Offset: 0x21EE4F1 VA: 0x21EE3F0
	public void .ctor() { }

	// RVA: 0x21F0CF0 Offset: 0x21F0DF1 VA: 0x21F0CF0 Slot: 4
	protected override void ResetParam(DataStoreRatingInitParam param) { }

	// RVA: 0x21EF4E0 Offset: 0x21EF5E1 VA: 0x21EF4E0
	public void Unmark(DataStorePreparePostParam postParam) { }
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
private class Nex.DataStore.RatingTargetPool : Nex.DataStore.ParamPool<DataStoreRatingTarget> // TypeDefIndex: 8323
{
	// Methods

	// RVA: 0x21EE4B0 Offset: 0x21EE5B1 VA: 0x21EE4B0
	public void .ctor() { }

	// RVA: 0x21F0D60 Offset: 0x21F0E61 VA: 0x21F0D60 Slot: 4
	protected override void ResetParam(DataStoreRatingTarget param) { }
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
private class Nex.DataStore.DeleteParamListPool : Nex.DataStore.ParamPool<List<DataStoreDeleteParam>> // TypeDefIndex: 8325
{
	// Methods

	// RVA: 0x21EDA70 Offset: 0x21EDB71 VA: 0x21EDA70
	public void .ctor() { }

	// RVA: 0x21EDAD0 Offset: 0x21EDBD1 VA: 0x21EDAD0 Slot: 4
	protected override void ResetParam(List<DataStoreDeleteParam> param) { }
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
private enum Nex.DataStore.Api // TypeDefIndex: 8327
{
	// Fields
	public int value__; // 0x0
	public const Nex.DataStore.Api GetRating = 0;
	public const Nex.DataStore.Api ResetRating = 1;
	public const Nex.DataStore.Api DeleteObject = 2;
	public const Nex.DataStore.Api GetMeta = 3;
	public const Nex.DataStore.Api ChangeMeta = 4;
	public const Nex.DataStore.Api GetObject = 5;
	public const Nex.DataStore.Api PostObject = 6;
	public const Nex.DataStore.Api UpdateObject = 7;
	public const Nex.DataStore.Api RateObject = 8;
	public const Nex.DataStore.Api RateObjects = 9;
	public const Nex.DataStore.Api RateObjectWithPosting = 10;
	public const Nex.DataStore.Api RateObjectsWithPosting = 11;
	public const Nex.DataStore.Api TouchObject = 12;
	public const Nex.DataStore.Api PerpetuateObject = 13;
	public const Nex.DataStore.Api UnperpetuateObject = 14;
	public const Nex.DataStore.Api GetPersistenceInfo = 15;
	public const Nex.DataStore.Api SearchObjectLight = 16;
	public const Nex.DataStore.Api SearchObject = 17;
	public const Nex.DataStore.Api Max = 18;
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
public static class Nex.DataStore // TypeDefIndex: 8329
{
	// Methods

	// RVA: 0x26E95D0 Offset: 0x26E96D1 VA: 0x26E95D0
	public static void TryInitialize() { }

	// RVA: 0x26E9660 Offset: 0x26E9761 VA: 0x26E9660
	public static void TryCleanup() { }

	// RVA: 0x26E96E0 Offset: 0x26E97E1 VA: 0x26E96E0
	public static DataStoreSearchParam GetSearchParam() { }

	// RVA: 0x26E9780 Offset: 0x26E9881 VA: 0x26E9780
	public static Nex.Result SearchAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback) { }

	// RVA: 0x26E9840 Offset: 0x26E9941 VA: 0x26E9840
	public static Nex.Result SearchLightAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback) { }

	// RVA: 0x26E9900 Offset: 0x26E9A01 VA: 0x26E9900
	public static DataStorePrepareGetParam GetGetParam() { }

	// RVA: 0x26E99A0 Offset: 0x26E9AA1 VA: 0x26E99A0
	public static Nex.Result GetAsync(DataStorePrepareGetParam param, ulong bufferSize, DataStore.GetObjectCB callback) { }

	// RVA: 0x26E9A70 Offset: 0x26E9B71 VA: 0x26E9A70
	public static List<DataStoreGetMetaParam> GetGetMetaParamList() { }

	// RVA: 0x26E9B10 Offset: 0x26E9C11 VA: 0x26E9B10
	public static DataStoreGetMetaParam GetGetMetaParam() { }

	// RVA: 0x26E9BB0 Offset: 0x26E9CB1 VA: 0x26E9BB0
	public static Nex.Result GetMetaAsync(DataStoreGetMetaParam param, DataStore.GetMetaCB callback) { }

	// RVA: 0x26E9C70 Offset: 0x26E9D71 VA: 0x26E9C70
	public static Nex.Result GetMetaAsync(List<ulong> dataIds, DataStoreGetMetaParam param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x26E9D40 Offset: 0x26E9E41 VA: 0x26E9D40
	public static Nex.Result GetMetaAsync(List<DataStoreGetMetaParam> param, DataStore.GetMetaListCB callback) { }

	// RVA: 0x26E9E00 Offset: 0x26E9F01 VA: 0x26E9E00
	public static Nex.Result GetPersistenceInfoAsync(ulong principalId, ushort slot, DataStore.GetPersistenceInfoCB callback) { }

	// RVA: 0x26E9ED0 Offset: 0x26E9FD1 VA: 0x26E9ED0
	public static DataStorePreparePostParam GetPostParam() { }

	// RVA: 0x26E9F70 Offset: 0x26EA071 VA: 0x26E9F70
	public static Nex.Result PostAsync(DataStorePreparePostParam param, byte[] buffer, DataStore.PostCB callback) { }

	// RVA: 0x26EA040 Offset: 0x26EA141 VA: 0x26EA040
	public static Nex.Result PostMetaAsync(DataStorePreparePostParam param, DataStore.PostCB callback) { }

	// RVA: 0x26EA100 Offset: 0x26EA201 VA: 0x26EA100
	public static Nex.Result CompleteSuspendedPostAsync(List<ulong> dataIds, AsyncResultCB callback) { }

	// RVA: 0x26EA1C0 Offset: 0x26EA2C1 VA: 0x26EA1C0
	public static DataStorePrepareUpdateParam GetUpdateParam() { }

	// RVA: 0x26EA260 Offset: 0x26EA361 VA: 0x26EA260
	public static Nex.Result UpdateAsync(DataStorePrepareUpdateParam param, byte[] buffer, AsyncResultCB callback) { }

	// RVA: 0x26EA330 Offset: 0x26EA431 VA: 0x26EA330
	public static DataStoreChangeMetaParam GetChangeMetaParam() { }

	// RVA: 0x26EA3D0 Offset: 0x26EA4D1 VA: 0x26EA3D0
	public static Nex.Result ChangeMetaAsync(DataStoreChangeMetaParam param, AsyncResultCB callback) { }

	// RVA: 0x26EA490 Offset: 0x26EA591 VA: 0x26EA490
	public static DataStoreRatingInitParam GetRatingInitParam() { }

	// RVA: 0x26EA530 Offset: 0x26EA631 VA: 0x26EA530
	public static List<DataStoreRatingTarget> GetRatingTargetList() { }

	// RVA: 0x26EA5D0 Offset: 0x26EA6D1 VA: 0x26EA5D0
	public static DataStoreRatingTarget GetRatingTarget() { }

	// RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	public static DataStoreRateObjectParam GetRateObjectParam() { }

	// RVA: 0x26EA710 Offset: 0x26EA811 VA: 0x26EA710
	public static Nex.Result RateAsync(DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStore.RatingInfoCB callback) { }

	// RVA: 0x26EA7E0 Offset: 0x26EA8E1 VA: 0x26EA7E0
	public static Nex.Result RateWithPostingAsync(List<DataStoreRatingTarget> targets, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, DataStore.RatingInfoListCB callback) { }

	// RVA: 0x26EA8B0 Offset: 0x26EA9B1 VA: 0x26EA8B0
	public static List<DataStoreDeleteParam> GetDeleteParamList() { }

	// RVA: 0x26EA950 Offset: 0x26EAA51 VA: 0x26EA950
	public static DataStoreDeleteParam GetDeleteParam() { }

	// RVA: 0x26EA9F0 Offset: 0x26EAAF1 VA: 0x26EA9F0
	public static Nex.Result DeleteAsync(List<DataStoreDeleteParam> param, DataStore.ResultListCB callback) { }

	// RVA: 0x26EAAB0 Offset: 0x26EABB1 VA: 0x26EAAB0
	public static Nex.Result UnperpetuateAsync(ushort persistenceSlotId, bool deleteLastObject, AsyncResultCB callback) { }
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
private abstract class Nex.DispatchBase<T> : SingletonProcInst<T> // TypeDefIndex: 8331
{
	// Fields
	private const uint TimeoutMsec = 3;
	private bool m_IsNeedToUpdateAsyncResult; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(bool isNeedToUpdateAsyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x262E460 Offset: 0x262E561 VA: 0x262E460
	|-Nex.DispatchBase<object>..ctor
	|-Nex.DispatchBase<Nex.DispatchHigh>..ctor
	|-Nex.DispatchBase<Nex.DispatchLow>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void OnPersistent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x262E520 Offset: 0x262E621 VA: 0x262E520
	|-Nex.DispatchBase<object>.OnPersistent
	|-Nex.DispatchBase<Nex.DispatchHigh>.OnPersistent
	|-Nex.DispatchBase<Nex.DispatchLow>.OnPersistent
	*/
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
private class Nex.DispatchLow : Nex.DispatchBase<Nex.DispatchLow> // TypeDefIndex: 8333
{
	// Methods

	// RVA: 0x26EB640 Offset: 0x26EB741 VA: 0x26EB640
	protected void .ctor() { }

	// RVA: 0x26EB6A0 Offset: 0x26EB7A1 VA: 0x26EB6A0
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
private class Nex.DispatchKeepAlive : SingletonClass<Nex.DispatchKeepAlive> // TypeDefIndex: 8335
{
	// Fields
	private const int SleepMsec = 4;
	private Thread m_Thread; // 0x20
	private object m_Lock; // 0x28
	private AutoResetEvent m_Event; // 0x30
	private Nex.DispatchKeepAlive.Status m_Status; // 0x38

	// Methods

	// RVA: 0x26EADB0 Offset: 0x26EAEB1 VA: 0x26EADB0
	public void .ctor() { }

	// RVA: 0x26EAF60 Offset: 0x26EB061 VA: 0x26EAF60 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x26EB0A0 Offset: 0x26EB1A1 VA: 0x26EB0A0
	private static void ThreadFunc(object obj) { }

	// RVA: 0x26EB120 Offset: 0x26EB221 VA: 0x26EB120
	private void ThreadFuncImpl() { }

	// RVA: 0x26EB440 Offset: 0x26EB541 VA: 0x26EB440
	public void Run() { }

	// RVA: 0x26EB470 Offset: 0x26EB571 VA: 0x26EB470
	public void Stop() { }

	// RVA: 0x26EAF70 Offset: 0x26EB071 VA: 0x26EAF70
	public void End() { }

	// RVA: 0x26EB560 Offset: 0x26EB661 VA: 0x26EB560
	public bool IsRunning() { }
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
[CompilerGeneratedAttribute] // RVA: 0x273210 Offset: 0x273311 VA: 0x273210
private sealed class Nex.GameServer.Impl.<>c__DisplayClass3_0 // TypeDefIndex: 8337
{
	// Fields
	public Nex.GameServer.Impl <>4__this; // 0x10
	public AsyncResultCB callback; // 0x18

	// Methods

	// RVA: 0x2D7D950 Offset: 0x2D7DA51 VA: 0x2D7D950
	public void .ctor() { }

	// RVA: 0x2D7D960 Offset: 0x2D7DA61 VA: 0x2D7D960
	internal void <LogoutAsync>b__0(AsyncResult asyncResult) { }
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
public static class Nex.GameServer // TypeDefIndex: 8339
{
	// Properties
	public static ulong PrincipalId { get; }
	public static IntPtr NgsFacadePtr { get; }

	// Methods

	// RVA: 0x26EB790 Offset: 0x26EB891 VA: 0x26EB790
	public static void TryInitialize() { }

	// RVA: 0x26EB820 Offset: 0x26EB921 VA: 0x26EB820
	public static void TryCleanup() { }

	// RVA: 0x26EB8A0 Offset: 0x26EB9A1 VA: 0x26EB8A0
	public static Nex.Result LoginAsync(AsyncResultCB callback) { }

	// RVA: 0x26E89F0 Offset: 0x26E8AF1 VA: 0x26E89F0
	public static Nex.Result LogoutAsync(AsyncResultCB callback) { }

	// RVA: 0x26E87B0 Offset: 0x26E88B1 VA: 0x26E87B0
	public static Result IsConnected() { }

	// RVA: 0x26EB950 Offset: 0x26EBA51 VA: 0x26EB950
	public static ulong get_PrincipalId() { }

	// RVA: 0x26EB9E0 Offset: 0x26EBAE1 VA: 0x26EB9E0
	public static IntPtr get_NgsFacadePtr() { }
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
public static class Nex.QError.DataStore // TypeDefIndex: 8341
{
	// Fields
	public const int Facility = 105;
	public const int Unknown = -2140602367;
	public const int InvalidArgument = -2140602366;
	public const int PermissionDenied = -2140602365;
	public const int NotFound = -2140602364;
	public const int AlreadyLocked = -2140602363;
	public const int UnderReviewing = -2140602362;
	public const int Expired = -2140602361;
	public const int InvalidCheckToken = -2140602360;
	public const int SystemFileError = -2140602359;
	public const int OverCapacity = -2140602358;
	public const int OperationNotAllowed = -2140602357;
	public const int InvalidPassword = -2140602356;
	public const int ValueNotEqual = -2140602355;
}

// Namespace: 
public static class Nex.QError // TypeDefIndex: 8342
{
	// Fields
	public const int ErrorBit = -2147483648;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273220 Offset: 0x273321 VA: 0x273220
private sealed class Nex.Screening.Impl.<>c__DisplayClass6_0 // TypeDefIndex: 8343
{
	// Fields
	public Nex.Screening.Impl <>4__this; // 0x10
	public ScreeningDataStoreContentParam contentParam; // 0x18
	public ScreeningUgcViolationParam violationParam; // 0x20
	public AsyncResultCB callback; // 0x28

	// Methods

	// RVA: 0x2D7D9E0 Offset: 0x2D7DAE1 VA: 0x2D7D9E0
	public void .ctor() { }

	// RVA: 0x2D7D9F0 Offset: 0x2D7DAF1 VA: 0x2D7D9F0
	internal void <ReportDataStoreContentAsyncImpl>b__0(AsyncResult asyncResult) { }
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
private struct Nex.Screening.ParamPool.Data<T> // TypeDefIndex: 8345
{
	// Fields
	public T param; // 0x0
	public bool isUsed; // 0x0
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
private class Nex.Screening.DataStoreContentParamPool : Nex.Screening.ParamPool<ScreeningDataStoreContentParam> // TypeDefIndex: 8347
{
	// Methods

	// RVA: 0x21F11E0 Offset: 0x21F12E1 VA: 0x21F11E0
	public void .ctor() { }

	// RVA: 0x21F1240 Offset: 0x21F1341 VA: 0x21F1240 Slot: 4
	protected override void ResetParam(ScreeningDataStoreContentParam param) { }
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
public static class Nex.Screening // TypeDefIndex: 8349
{
	// Methods

	// RVA: 0x26EBAF0 Offset: 0x26EBBF1 VA: 0x26EBAF0
	public static void TryInitialize() { }

	// RVA: 0x26EBB80 Offset: 0x26EBC81 VA: 0x26EBB80
	public static void TryCleanup() { }

	// RVA: 0x26EBC00 Offset: 0x26EBD01 VA: 0x26EBC00
	public static ScreeningDataStoreContentParam GetDataStoreContentParam() { }

	// RVA: 0x26EBCA0 Offset: 0x26EBDA1 VA: 0x26EBCA0
	public static ScreeningUgcViolationParam GetUgcViolationParam() { }

	// RVA: 0x26EBD40 Offset: 0x26EBE41 VA: 0x26EBD40
	public static Nex.Result ReportDataStoreContentAsync(ScreeningDataStoreContentParam contentParam, ScreeningUgcViolationParam violationParam, AsyncResultCB callback) { }
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
private class Nex.Utility.Impl : SingletonClass<Nex.Utility.Impl> // TypeDefIndex: 8351
{
	// Fields
	private Nex.Utility.UtilityApiCallChecker m_ApiCallChecker; // 0x20

	// Methods

	// RVA: 0x21F17A0 Offset: 0x21F18A1 VA: 0x21F17A0
	public void .ctor() { }

	// RVA: 0x21F1930 Offset: 0x21F1A31 VA: 0x21F1930
	public Nex.Result GetIntegerSettingsAsync(uint integerSettingIndex, Utility.GetIntegerSettingsCB callback) { }
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
private class Nex.Utility.UtilityApiCallChecker : Nex.ApiCallChecker // TypeDefIndex: 8353
{
	// Fields
	private static readonly Nex.ApiCallChecker.Guideline[] Guidelines; // 0x0

	// Methods

	// RVA: 0x21F18B0 Offset: 0x21F19B1 VA: 0x21F18B0
	public void .ctor() { }

	// RVA: 0x21F1A50 Offset: 0x21F1B51 VA: 0x21F1A50
	public bool Run(Nex.Utility.Api api) { }

	// RVA: 0x21F1A60 Offset: 0x21F1B61 VA: 0x21F1A60 Slot: 4
	protected override void DbgOnInvalidApi(int api) { }

	// RVA: 0x21F1A70 Offset: 0x21F1B71 VA: 0x21F1A70 Slot: 5
	protected override void DbgOnTooMuchCall(int api) { }

	// RVA: 0x21F1B40 Offset: 0x21F1C41 VA: 0x21F1B40 Slot: 6
	protected override void DbgOnFullCalledTimes(int api) { }

	// RVA: 0x21F1B50 Offset: 0x21F1C51 VA: 0x21F1B50
	private static void .cctor() { }
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

