// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46E50 Offset: 0x46F51 VA: 0x46E50
public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 1712
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x32F9F00 Offset: 0x32FA001 VA: 0x32F9F00 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x32F9F10 Offset: 0x32FA011 VA: 0x32F9F10 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x32F9F20 Offset: 0x32FA021 VA: 0x32F9F20 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x32F9F30 Offset: 0x32FA031 VA: 0x32F9F30
	protected void .ctor() { }
}

