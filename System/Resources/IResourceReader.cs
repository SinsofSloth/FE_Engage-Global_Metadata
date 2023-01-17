// Namespace: System.Resources
[ComVisibleAttribute] // RVA: 0x471500 Offset: 0x471601 VA: 0x471500
public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 486
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();
}

