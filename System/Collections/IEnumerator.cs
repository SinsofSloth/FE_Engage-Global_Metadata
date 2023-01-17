// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476E10 Offset: 0x476F11 VA: 0x476E10
[GuidAttribute] // RVA: 0x476E10 Offset: 0x476F11 VA: 0x476E10
public interface IEnumerator // TypeDefIndex: 1361
{
	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();
}

