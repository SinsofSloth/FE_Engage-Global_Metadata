// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476DA0 Offset: 0x476EA1 VA: 0x476DA0
public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1359
{
	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();
}

