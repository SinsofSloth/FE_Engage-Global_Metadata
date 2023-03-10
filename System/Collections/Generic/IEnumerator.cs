// Namespace: System.Collections.Generic
public interface IEnumerator<T> : IDisposable, IEnumerator // TypeDefIndex: 1433
{
	// Properties
	public abstract T Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Current();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerator<object>.get_Current
	*/
}

