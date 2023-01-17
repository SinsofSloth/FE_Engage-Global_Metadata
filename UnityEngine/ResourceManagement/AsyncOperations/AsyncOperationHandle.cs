// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>> // TypeDefIndex: 5615
{
	// Fields
	internal AsyncOperationBase<TObject> m_InternalOp; // 0x0
	private int m_Version; // 0x0
	private string m_LocationName; // 0x0

	// Properties
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private AsyncOperationBase<TObject> InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public TObject Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<TObject> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal string get_LocationName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCAC0 Offset: 0x32DCBC1 VA: 0x32DCAC0
	|-AsyncOperationHandle<bool>.get_LocationName
	|
	|-RVA: 0x32DE660 Offset: 0x32DE761 VA: 0x32DE660
	|-AsyncOperationHandle<long>.get_LocationName
	|
	|-RVA: 0x32E0200 Offset: 0x32E0301 VA: 0x32E0200
	|-AsyncOperationHandle<object>.get_LocationName
	|
	|-RVA: 0x32E1D60 Offset: 0x32E1E61 VA: 0x32E1D60
	|-AsyncOperationHandle<SceneInstance>.get_LocationName
	*/

	// RVA: -1 Offset: -1
	internal void set_LocationName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCAD0 Offset: 0x32DCBD1 VA: 0x32DCAD0
	|-AsyncOperationHandle<bool>.set_LocationName
	|
	|-RVA: 0x32DE670 Offset: 0x32DE771 VA: 0x32DE670
	|-AsyncOperationHandle<long>.set_LocationName
	|
	|-RVA: 0x32E0210 Offset: 0x32E0311 VA: 0x32E0210
	|-AsyncOperationHandle<object>.set_LocationName
	|
	|-RVA: 0x32E1D70 Offset: 0x32E1E71 VA: 0x32E1D70
	|-AsyncOperationHandle<SceneInstance>.set_LocationName
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E0220 Offset: 0x32E0321 VA: 0x32E0220
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.op_Implicit
	|-AsyncOperationHandle<IList<IAssetBundleResource>>.op_Implicit
	|-AsyncOperationHandle<List<IResourceLocator>>.op_Implicit
	|-AsyncOperationHandle<ContentCatalogData>.op_Implicit
	|-AsyncOperationHandle<GameObject>.op_Implicit
	|-AsyncOperationHandle<IResourceLocator>.op_Implicit
	|-AsyncOperationHandle<object>.op_Implicit
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.op_Implicit
	|
	|-RVA: 0x32DCAE0 Offset: 0x32DCBE1 VA: 0x32DCAE0
	|-AsyncOperationHandle<bool>.op_Implicit
	|
	|-RVA: 0x32DE680 Offset: 0x32DE781 VA: 0x32DE680
	|-AsyncOperationHandle<long>.op_Implicit
	|
	|-RVA: 0x32E1D80 Offset: 0x32E1E81 VA: 0x32E1D80
	|-AsyncOperationHandle<SceneInstance>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncOperationBase<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCB40 Offset: 0x32DCC41 VA: 0x32DCB40
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x32E0280 Offset: 0x32E0381 VA: 0x32E0280
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x32E1DE0 Offset: 0x32E1EE1 VA: 0x32E1DE0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public DownloadStatus GetDownloadStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCBE0 Offset: 0x32DCCE1 VA: 0x32DCBE0
	|-AsyncOperationHandle<bool>.GetDownloadStatus
	|
	|-RVA: 0x32DE780 Offset: 0x32DE881 VA: 0x32DE780
	|-AsyncOperationHandle<long>.GetDownloadStatus
	|
	|-RVA: 0x32E0320 Offset: 0x32E0421 VA: 0x32E0320
	|-AsyncOperationHandle<object>.GetDownloadStatus
	|
	|-RVA: 0x32E1E80 Offset: 0x32E1F81 VA: 0x32E1E80
	|-AsyncOperationHandle<SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E03F0 Offset: 0x32E04F1 VA: 0x32E03F0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.InternalGetDownloadStatus
	|-AsyncOperationHandle<GameObject>.InternalGetDownloadStatus
	|-AsyncOperationHandle<object>.InternalGetDownloadStatus
	|
	|-RVA: 0x32DCCB0 Offset: 0x32DCDB1 VA: 0x32DCCB0
	|-AsyncOperationHandle<bool>.InternalGetDownloadStatus
	|
	|-RVA: 0x32DE850 Offset: 0x32DE951 VA: 0x32DE850
	|-AsyncOperationHandle<long>.InternalGetDownloadStatus
	|
	|-RVA: 0x32E1F50 Offset: 0x32E2051 VA: 0x32E1F50
	|-AsyncOperationHandle<SceneInstance>.InternalGetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCE40 Offset: 0x32DCF41 VA: 0x32DCE40
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x32DE9E0 Offset: 0x32DEAE1 VA: 0x32DE9E0
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x32E0580 Offset: 0x32E0681 VA: 0x32E0580
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x32E20E0 Offset: 0x32E21E1 VA: 0x32E20E0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DCFA0 Offset: 0x32DD0A1 VA: 0x32DCFA0
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x32DEB40 Offset: 0x32DEC41 VA: 0x32DEB40
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x32E06E0 Offset: 0x32E07E1 VA: 0x32E06E0
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x32E2240 Offset: 0x32E2341 VA: 0x32E2240
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD050 Offset: 0x32DD151 VA: 0x32DD050
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x32DEBF0 Offset: 0x32DECF1 VA: 0x32DEBF0
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x32E0790 Offset: 0x32E0891 VA: 0x32E0790
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x32E22F0 Offset: 0x32E23F1 VA: 0x32E22F0
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD1B0 Offset: 0x32DD2B1 VA: 0x32DD1B0
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x32DED50 Offset: 0x32DEE51 VA: 0x32DED50
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x32E08F0 Offset: 0x32E09F1 VA: 0x32E08F0
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x32E2450 Offset: 0x32E2551 VA: 0x32E2450
	|-AsyncOperationHandle<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E09B0 Offset: 0x32E0AB1 VA: 0x32E09B0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.Acquire
	|-AsyncOperationHandle<object>.Acquire
	|
	|-RVA: 0x32DD270 Offset: 0x32DD371 VA: 0x32DD270
	|-AsyncOperationHandle<bool>.Acquire
	|
	|-RVA: 0x32DEE10 Offset: 0x32DEF11 VA: 0x32DEE10
	|-AsyncOperationHandle<long>.Acquire
	|
	|-RVA: 0x32E2510 Offset: 0x32E2611 VA: 0x32E2510
	|-AsyncOperationHandle<SceneInstance>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E0A70 Offset: 0x32E0B71 VA: 0x32E0A70
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.add_Completed
	|-AsyncOperationHandle<IList<IAssetBundleResource>>.add_Completed
	|-AsyncOperationHandle<ContentCatalogData>.add_Completed
	|-AsyncOperationHandle<IResourceLocator>.add_Completed
	|-AsyncOperationHandle<object>.add_Completed
	|
	|-RVA: 0x32DD330 Offset: 0x32DD431 VA: 0x32DD330
	|-AsyncOperationHandle<bool>.add_Completed
	|
	|-RVA: 0x32DEED0 Offset: 0x32DEFD1 VA: 0x32DEED0
	|-AsyncOperationHandle<long>.add_Completed
	|
	|-RVA: 0x32E25D0 Offset: 0x32E26D1 VA: 0x32E25D0
	|-AsyncOperationHandle<SceneInstance>.add_Completed
	*/

	// RVA: -1 Offset: -1
	public void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD3E0 Offset: 0x32DD4E1 VA: 0x32DD3E0
	|-AsyncOperationHandle<bool>.remove_Completed
	|
	|-RVA: 0x32DEF80 Offset: 0x32DF081 VA: 0x32DEF80
	|-AsyncOperationHandle<long>.remove_Completed
	|
	|-RVA: 0x32E0B20 Offset: 0x32E0C21 VA: 0x32E0B20
	|-AsyncOperationHandle<object>.remove_Completed
	|
	|-RVA: 0x32E2680 Offset: 0x32E2781 VA: 0x32E2680
	|-AsyncOperationHandle<SceneInstance>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E0BD0 Offset: 0x32E0CD1 VA: 0x32E0BD0
	|-AsyncOperationHandle<List<IResourceLocator>>.add_CompletedTypeless
	|-AsyncOperationHandle<List<string>>.add_CompletedTypeless
	|-AsyncOperationHandle<GameObject>.add_CompletedTypeless
	|-AsyncOperationHandle<object>.add_CompletedTypeless
	|
	|-RVA: 0x32DD490 Offset: 0x32DD591 VA: 0x32DD490
	|-AsyncOperationHandle<bool>.add_CompletedTypeless
	|
	|-RVA: 0x32DF030 Offset: 0x32DF131 VA: 0x32DF030
	|-AsyncOperationHandle<long>.add_CompletedTypeless
	|
	|-RVA: 0x32E2730 Offset: 0x32E2831 VA: 0x32E2730
	|-AsyncOperationHandle<SceneInstance>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD540 Offset: 0x32DD641 VA: 0x32DD540
	|-AsyncOperationHandle<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x32DF0E0 Offset: 0x32DF1E1 VA: 0x32DF0E0
	|-AsyncOperationHandle<long>.remove_CompletedTypeless
	|
	|-RVA: 0x32E0C80 Offset: 0x32E0D81 VA: 0x32E0C80
	|-AsyncOperationHandle<object>.remove_CompletedTypeless
	|
	|-RVA: 0x32E27E0 Offset: 0x32E28E1 VA: 0x32E27E0
	|-AsyncOperationHandle<SceneInstance>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E0D30 Offset: 0x32E0E31 VA: 0x32E0D30
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_DebugName
	|-AsyncOperationHandle<GameObject>.get_DebugName
	|-AsyncOperationHandle<object>.get_DebugName
	|
	|-RVA: 0x32DD5F0 Offset: 0x32DD6F1 VA: 0x32DD5F0
	|-AsyncOperationHandle<bool>.get_DebugName
	|
	|-RVA: 0x32DF190 Offset: 0x32DF291 VA: 0x32DF190
	|-AsyncOperationHandle<long>.get_DebugName
	|
	|-RVA: 0x32E2890 Offset: 0x32E2991 VA: 0x32E2890
	|-AsyncOperationHandle<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD790 Offset: 0x32DD891 VA: 0x32DD790
	|-AsyncOperationHandle<bool>.add_Destroyed
	|
	|-RVA: 0x32DF330 Offset: 0x32DF431 VA: 0x32DF330
	|-AsyncOperationHandle<long>.add_Destroyed
	|
	|-RVA: 0x32E0ED0 Offset: 0x32E0FD1 VA: 0x32E0ED0
	|-AsyncOperationHandle<object>.add_Destroyed
	|
	|-RVA: 0x32E2A30 Offset: 0x32E2B31 VA: 0x32E2A30
	|-AsyncOperationHandle<SceneInstance>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD840 Offset: 0x32DD941 VA: 0x32DD840
	|-AsyncOperationHandle<bool>.remove_Destroyed
	|
	|-RVA: 0x32DF3E0 Offset: 0x32DF4E1 VA: 0x32DF3E0
	|-AsyncOperationHandle<long>.remove_Destroyed
	|
	|-RVA: 0x32E0F80 Offset: 0x32E1081 VA: 0x32E0F80
	|-AsyncOperationHandle<object>.remove_Destroyed
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-AsyncOperationHandle<SceneInstance>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(AsyncOperationHandle<TObject> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-AsyncOperationHandle<bool>.Equals
	|
	|-RVA: 0x32DF490 Offset: 0x32DF591 VA: 0x32DF490
	|-AsyncOperationHandle<long>.Equals
	|
	|-RVA: 0x32E1030 Offset: 0x32E1131 VA: 0x32E1030
	|-AsyncOperationHandle<object>.Equals
	|
	|-RVA: 0x32E2B90 Offset: 0x32E2C91 VA: 0x32E2B90
	|-AsyncOperationHandle<SceneInstance>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DD920 Offset: 0x32DDA21 VA: 0x32DD920
	|-AsyncOperationHandle<bool>.GetHashCode
	|
	|-RVA: 0x32DF4C0 Offset: 0x32DF5C1 VA: 0x32DF4C0
	|-AsyncOperationHandle<long>.GetHashCode
	|
	|-RVA: 0x32E1060 Offset: 0x32E1161 VA: 0x32E1060
	|-AsyncOperationHandle<object>.GetHashCode
	|
	|-RVA: 0x32E2BC0 Offset: 0x32E2CC1 VA: 0x32E2BC0
	|-AsyncOperationHandle<SceneInstance>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public TObject WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E10A0 Offset: 0x32E11A1 VA: 0x32E10A0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.WaitForCompletion
	|-AsyncOperationHandle<ContentCatalogData>.WaitForCompletion
	|-AsyncOperationHandle<GameObject>.WaitForCompletion
	|-AsyncOperationHandle<IResourceLocator>.WaitForCompletion
	|-AsyncOperationHandle<object>.WaitForCompletion
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.WaitForCompletion
	|
	|-RVA: 0x32DD960 Offset: 0x32DDA61 VA: 0x32DD960
	|-AsyncOperationHandle<bool>.WaitForCompletion
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-AsyncOperationHandle<long>.WaitForCompletion
	|
	|-RVA: 0x32E2C00 Offset: 0x32E2D01 VA: 0x32E2C00
	|-AsyncOperationHandle<SceneInstance>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationBase<TObject> get_InternalOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DDD70 Offset: 0x32DDE71 VA: 0x32DDD70
	|-AsyncOperationHandle<bool>.get_InternalOp
	|
	|-RVA: 0x32DF910 Offset: 0x32DFA11 VA: 0x32DF910
	|-AsyncOperationHandle<long>.get_InternalOp
	|
	|-RVA: 0x32E14B0 Offset: 0x32E15B1 VA: 0x32E14B0
	|-AsyncOperationHandle<object>.get_InternalOp
	|
	|-RVA: 0x32E3030 Offset: 0x32E3131 VA: 0x32E3030
	|-AsyncOperationHandle<SceneInstance>.get_InternalOp
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1590 Offset: 0x32E1691 VA: 0x32E1590
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_IsDone
	|-AsyncOperationHandle<List<IResourceLocator>>.get_IsDone
	|-AsyncOperationHandle<ContentCatalogData>.get_IsDone
	|-AsyncOperationHandle<GameObject>.get_IsDone
	|-AsyncOperationHandle<IResourceLocator>.get_IsDone
	|-AsyncOperationHandle<object>.get_IsDone
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.get_IsDone
	|
	|-RVA: 0x32DDE50 Offset: 0x32DDF51 VA: 0x32DDE50
	|-AsyncOperationHandle<bool>.get_IsDone
	|
	|-RVA: 0x32DF9F0 Offset: 0x32DFAF1 VA: 0x32DF9F0
	|-AsyncOperationHandle<long>.get_IsDone
	|
	|-RVA: 0x32E3110 Offset: 0x32E3211 VA: 0x32E3110
	|-AsyncOperationHandle<SceneInstance>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E16D0 Offset: 0x32E17D1 VA: 0x32E16D0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.IsValid
	|-AsyncOperationHandle<List<IResourceLocator>>.IsValid
	|-AsyncOperationHandle<List<string>>.IsValid
	|-AsyncOperationHandle<GameObject>.IsValid
	|-AsyncOperationHandle<IResourceLocator>.IsValid
	|-AsyncOperationHandle<object>.IsValid
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.IsValid
	|
	|-RVA: 0x32DDF90 Offset: 0x32DE091 VA: 0x32DDF90
	|-AsyncOperationHandle<bool>.IsValid
	|
	|-RVA: 0x32DFB30 Offset: 0x32DFC31 VA: 0x32DFB30
	|-AsyncOperationHandle<long>.IsValid
	|
	|-RVA: 0x32E3250 Offset: 0x32E3351 VA: 0x32E3250
	|-AsyncOperationHandle<SceneInstance>.IsValid
	*/

	// RVA: -1 Offset: -1
	public Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_OperationException
	|-AsyncOperationHandle<GameObject>.get_OperationException
	|-AsyncOperationHandle<IResourceLocator>.get_OperationException
	|-AsyncOperationHandle<object>.get_OperationException
	|
	|-RVA: 0x32DE030 Offset: 0x32DE131 VA: 0x32DE030
	|-AsyncOperationHandle<bool>.get_OperationException
	|
	|-RVA: 0x32DFBD0 Offset: 0x32DFCD1 VA: 0x32DFBD0
	|-AsyncOperationHandle<long>.get_OperationException
	|
	|-RVA: 0x32E32F0 Offset: 0x32E33F1 VA: 0x32E32F0
	|-AsyncOperationHandle<SceneInstance>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	public float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1820 Offset: 0x32E1921 VA: 0x32E1820
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_PercentComplete
	|-AsyncOperationHandle<GameObject>.get_PercentComplete
	|-AsyncOperationHandle<object>.get_PercentComplete
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.get_PercentComplete
	|
	|-RVA: 0x32DE0E0 Offset: 0x32DE1E1 VA: 0x32DE0E0
	|-AsyncOperationHandle<bool>.get_PercentComplete
	|
	|-RVA: 0x32DFC80 Offset: 0x32DFD81 VA: 0x32DFC80
	|-AsyncOperationHandle<long>.get_PercentComplete
	|
	|-RVA: 0x32E33A0 Offset: 0x32E34A1 VA: 0x32E33A0
	|-AsyncOperationHandle<SceneInstance>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DE190 Offset: 0x32DE291 VA: 0x32DE190
	|-AsyncOperationHandle<bool>.get_ReferenceCount
	|
	|-RVA: 0x32DFD30 Offset: 0x32DFE31 VA: 0x32DFD30
	|-AsyncOperationHandle<long>.get_ReferenceCount
	|
	|-RVA: 0x32E18D0 Offset: 0x32E19D1 VA: 0x32E18D0
	|-AsyncOperationHandle<object>.get_ReferenceCount
	|
	|-RVA: 0x32E3450 Offset: 0x32E3551 VA: 0x32E3450
	|-AsyncOperationHandle<SceneInstance>.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1980 Offset: 0x32E1A81 VA: 0x32E1980
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.Release
	|-AsyncOperationHandle<object>.Release
	|
	|-RVA: 0x32DE240 Offset: 0x32DE341 VA: 0x32DE240
	|-AsyncOperationHandle<bool>.Release
	|
	|-RVA: 0x32DFDE0 Offset: 0x32DFEE1 VA: 0x32DFDE0
	|-AsyncOperationHandle<long>.Release
	|
	|-RVA: 0x32E3500 Offset: 0x32E3601 VA: 0x32E3500
	|-AsyncOperationHandle<SceneInstance>.Release
	*/

	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1A30 Offset: 0x32E1B31 VA: 0x32E1A30
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_Result
	|-AsyncOperationHandle<ContentCatalogData>.get_Result
	|-AsyncOperationHandle<GameObject>.get_Result
	|-AsyncOperationHandle<IResourceLocator>.get_Result
	|-AsyncOperationHandle<object>.get_Result
	|-AsyncOperationHandle<ResourceManagerRuntimeData>.get_Result
	|
	|-RVA: 0x32DE2F0 Offset: 0x32DE3F1 VA: 0x32DE2F0
	|-AsyncOperationHandle<bool>.get_Result
	|
	|-RVA: 0x32DFE90 Offset: 0x32DFF91 VA: 0x32DFE90
	|-AsyncOperationHandle<long>.get_Result
	|
	|-RVA: 0x32E35B0 Offset: 0x32E36B1 VA: 0x32E35B0
	|-AsyncOperationHandle<SceneInstance>.get_Result
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E1AE0 Offset: 0x32E1BE1 VA: 0x32E1AE0
	|-AsyncOperationHandle<IList<AsyncOperationHandle>>.get_Status
	|-AsyncOperationHandle<GameObject>.get_Status
	|-AsyncOperationHandle<object>.get_Status
	|
	|-RVA: 0x32DE3A0 Offset: 0x32DE4A1 VA: 0x32DE3A0
	|-AsyncOperationHandle<bool>.get_Status
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-AsyncOperationHandle<long>.get_Status
	|
	|-RVA: 0x32E3660 Offset: 0x32E3761 VA: 0x32E3660
	|-AsyncOperationHandle<SceneInstance>.get_Status
	*/

	// RVA: -1 Offset: -1
	public Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DE450 Offset: 0x32DE551 VA: 0x32DE450
	|-AsyncOperationHandle<bool>.get_Task
	|
	|-RVA: 0x32DFFF0 Offset: 0x32E00F1 VA: 0x32DFFF0
	|-AsyncOperationHandle<long>.get_Task
	|
	|-RVA: 0x32E1B90 Offset: 0x32E1C91 VA: 0x32E1B90
	|-AsyncOperationHandle<object>.get_Task
	|
	|-RVA: 0x32E3710 Offset: 0x32E3811 VA: 0x32E3710
	|-AsyncOperationHandle<SceneInstance>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DE500 Offset: 0x32DE601 VA: 0x32DE500
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E00A0 Offset: 0x32E01A1 VA: 0x32E00A0
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E1C40 Offset: 0x32E1D41 VA: 0x32E1C40
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32E37C0 Offset: 0x32E38C1 VA: 0x32E37C0
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x32E01A0 Offset: 0x32E02A1 VA: 0x32E01A0
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x32E1D00 Offset: 0x32E1E01 VA: 0x32E1D00
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x32E38C0 Offset: 0x32E39C1 VA: 0x32E38C0
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DE650 Offset: 0x32DE751 VA: 0x32DE650
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E01F0 Offset: 0x32E02F1 VA: 0x32E01F0
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E1D50 Offset: 0x32E1E51 VA: 0x32E1D50
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32E3910 Offset: 0x32E3A11 VA: 0x32E3910
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.Reset
	*/
}

