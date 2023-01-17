// Namespace: System.Collections
[DefaultMemberAttribute] // RVA: 0x476D50 Offset: 0x476E51 VA: 0x476D50
[ComVisibleAttribute] // RVA: 0x476D50 Offset: 0x476E51 VA: 0x476D50
public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1358
{
	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object key);
}

