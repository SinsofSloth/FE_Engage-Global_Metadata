// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 851
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B250 Offset: 0x250B351 VA: 0x250B250
	|-ContinuationResultTaskFromResultTask<ValueTuple<int, int>, Nullable<int>>..ctor
	|
	|-RVA: 0x250B4B0 Offset: 0x250B5B1 VA: 0x250B4B0
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0x250B710 Offset: 0x250B811 VA: 0x250B710
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250B3C0 Offset: 0x250B4C1 VA: 0x250B3C0
	|-ContinuationResultTaskFromResultTask<ValueTuple<int, int>, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x250B620 Offset: 0x250B721 VA: 0x250B620
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x250B880 Offset: 0x250B981 VA: 0x250B880
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	*/
}

