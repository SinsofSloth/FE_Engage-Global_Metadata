// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 850
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B990 Offset: 0x250BA91 VA: 0x250B990
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x250BB90 Offset: 0x250BC91 VA: 0x250BB90
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x250BD90 Offset: 0x250BE91 VA: 0x250BD90
	|-ContinuationTaskFromResultTask<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x250BF90 Offset: 0x250C091 VA: 0x250BF90
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x250C190 Offset: 0x250C291 VA: 0x250C190
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x250C390 Offset: 0x250C491 VA: 0x250C390
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x250C590 Offset: 0x250C691 VA: 0x250C590
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x250C790 Offset: 0x250C891 VA: 0x250C790
	|-ContinuationTaskFromResultTask<long>..ctor
	|
	|-RVA: 0x250C990 Offset: 0x250CA91 VA: 0x250C990
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x250CB90 Offset: 0x250CC91 VA: 0x250CB90
	|-ContinuationTaskFromResultTask<SceneInstance>..ctor
	|
	|-RVA: 0x250CD90 Offset: 0x250CE91 VA: 0x250CD90
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250BA80 Offset: 0x250BB81 VA: 0x250BA80
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x250BC80 Offset: 0x250BD81 VA: 0x250BC80
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x250BE80 Offset: 0x250BF81 VA: 0x250BE80
	|-ContinuationTaskFromResultTask<ValueTuple<int, int>>.InnerInvoke
	|
	|-RVA: 0x250C080 Offset: 0x250C181 VA: 0x250C080
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x250C280 Offset: 0x250C381 VA: 0x250C280
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x250C480 Offset: 0x250C581 VA: 0x250C480
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|
	|-RVA: 0x250C680 Offset: 0x250C781 VA: 0x250C680
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|
	|-RVA: 0x250C880 Offset: 0x250C981 VA: 0x250C880
	|-ContinuationTaskFromResultTask<long>.InnerInvoke
	|
	|-RVA: 0x250CA80 Offset: 0x250CB81 VA: 0x250CA80
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|
	|-RVA: 0x250CC80 Offset: 0x250CD81 VA: 0x250CC80
	|-ContinuationTaskFromResultTask<SceneInstance>.InnerInvoke
	|
	|-RVA: 0x250CE80 Offset: 0x250CF81 VA: 0x250CE80
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	*/
}

