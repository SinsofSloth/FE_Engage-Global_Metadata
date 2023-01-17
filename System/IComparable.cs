// Namespace: System
[ComVisibleAttribute] // RVA: 0x470370 Offset: 0x470471 VA: 0x470370
public interface IComparable // TypeDefIndex: 248
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object obj);
}

// Namespace: System
public interface IComparable<T> // TypeDefIndex: 249
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparable<object>.CompareTo
	*/
}

