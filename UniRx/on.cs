// Namespace: UniRx
public class ObservableYieldInstruction<T> : IEnumerator<T>, IEnumerator, IDisposable, ICustomYieldInstructionErrorHandler // TypeDefIndex: 6704
{
	// Fields
	private readonly IDisposable subscription; // 0x0
	private readonly CancellationToken cancel; // 0x0
	private bool reThrowOnError; // 0x0
	private T current; // 0x0
	private T result; // 0x0
	private bool moveNext; // 0x0
	private bool hasResult; // 0x0
	private Exception error; // 0x0

	// Properties
	public bool HasError { get; }
	public bool HasResult { get; }
	public bool IsCanceled { get; }
	public bool IsDone { get; }
	public T Result { get; }
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	public Exception Error { get; }
	private bool UniRx.ICustomYieldInstructionErrorHandler.IsReThrowOnError { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, bool reThrowOnError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E820 Offset: 0x370E921 VA: 0x370E820
	|-ObservableYieldInstruction<object>..ctor
	|
	|-RVA: 0x370ED70 Offset: 0x370EE71 VA: 0x370ED70
	|-ObservableYieldInstruction<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool get_HasError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E9E0 Offset: 0x370EAE1 VA: 0x370E9E0
	|-ObservableYieldInstruction<object>.get_HasError
	|
	|-RVA: 0x370EF30 Offset: 0x370F031 VA: 0x370EF30
	|-ObservableYieldInstruction<Unit>.get_HasError
	*/

	// RVA: -1 Offset: -1
	public bool get_HasResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E9F0 Offset: 0x370EAF1 VA: 0x370E9F0
	|-ObservableYieldInstruction<object>.get_HasResult
	|
	|-RVA: 0x370EF40 Offset: 0x370F041 VA: 0x370EF40
	|-ObservableYieldInstruction<Unit>.get_HasResult
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EA00 Offset: 0x370EB01 VA: 0x370EA00
	|-ObservableYieldInstruction<object>.get_IsCanceled
	|
	|-RVA: 0x370EF50 Offset: 0x370F051 VA: 0x370EF50
	|-ObservableYieldInstruction<Unit>.get_IsCanceled
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EA60 Offset: 0x370EB61 VA: 0x370EA60
	|-ObservableYieldInstruction<object>.get_IsDone
	|
	|-RVA: 0x370EFB0 Offset: 0x370F0B1 VA: 0x370EFB0
	|-ObservableYieldInstruction<Unit>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EAE0 Offset: 0x370EBE1 VA: 0x370EAE0
	|-ObservableYieldInstruction<object>.get_Result
	|
	|-RVA: 0x370F030 Offset: 0x370F131 VA: 0x370F030
	|-ObservableYieldInstruction<Unit>.get_Result
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EAF0 Offset: 0x370EBF1 VA: 0x370EAF0
	|-ObservableYieldInstruction<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x370F040 Offset: 0x370F141 VA: 0x370F040
	|-ObservableYieldInstruction<Unit>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EB00 Offset: 0x370EC01 VA: 0x370EB00
	|-ObservableYieldInstruction<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x370F050 Offset: 0x370F151 VA: 0x370F050
	|-ObservableYieldInstruction<Unit>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public Exception get_Error() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EB10 Offset: 0x370EC11 VA: 0x370EB10
	|-ObservableYieldInstruction<object>.get_Error
	|
	|-RVA: 0x370F0A0 Offset: 0x370F1A1 VA: 0x370F0A0
	|-ObservableYieldInstruction<Unit>.get_Error
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EB20 Offset: 0x370EC21 VA: 0x370EB20
	|-ObservableYieldInstruction<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x370F0B0 Offset: 0x370F1B1 VA: 0x370F0B0
	|-ObservableYieldInstruction<Unit>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool UniRx.ICustomYieldInstructionErrorHandler.get_IsReThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EC50 Offset: 0x370ED51 VA: 0x370EC50
	|-ObservableYieldInstruction<object>.UniRx.ICustomYieldInstructionErrorHandler.get_IsReThrowOnError
	|
	|-RVA: 0x370F1E0 Offset: 0x370F2E1 VA: 0x370F1E0
	|-ObservableYieldInstruction<Unit>.UniRx.ICustomYieldInstructionErrorHandler.get_IsReThrowOnError
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void UniRx.ICustomYieldInstructionErrorHandler.ForceDisableRethrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EC60 Offset: 0x370ED61 VA: 0x370EC60
	|-ObservableYieldInstruction<object>.UniRx.ICustomYieldInstructionErrorHandler.ForceDisableRethrowOnError
	|
	|-RVA: 0x370F1F0 Offset: 0x370F2F1 VA: 0x370F1F0
	|-ObservableYieldInstruction<Unit>.UniRx.ICustomYieldInstructionErrorHandler.ForceDisableRethrowOnError
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void UniRx.ICustomYieldInstructionErrorHandler.ForceEnableRethrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EC70 Offset: 0x370ED71 VA: 0x370EC70
	|-ObservableYieldInstruction<object>.UniRx.ICustomYieldInstructionErrorHandler.ForceEnableRethrowOnError
	|
	|-RVA: 0x370F200 Offset: 0x370F301 VA: 0x370F200
	|-ObservableYieldInstruction<Unit>.UniRx.ICustomYieldInstructionErrorHandler.ForceEnableRethrowOnError
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370EC80 Offset: 0x370ED81 VA: 0x370EC80
	|-ObservableYieldInstruction<object>.Dispose
	|
	|-RVA: 0x370F210 Offset: 0x370F311 VA: 0x370F210
	|-ObservableYieldInstruction<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370ED30 Offset: 0x370EE31 VA: 0x370ED30
	|-ObservableYieldInstruction<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x370F2C0 Offset: 0x370F3C1 VA: 0x370F2C0
	|-ObservableYieldInstruction<Unit>.System.Collections.IEnumerator.Reset
	*/
}

