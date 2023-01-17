// Namespace: App
public class RawValueList // TypeDefIndex: 9212
{
	// Fields
	public int Count; // 0x10
	public ValueType[] Values; // 0x18

	// Properties
	public int Capacity { get; }

	// Methods

	// RVA: 0x2772500 Offset: 0x2772601 VA: 0x2772500
	public int get_Capacity() { }

	// RVA: 0x2772510 Offset: 0x2772611 VA: 0x2772510
	public void .ctor(int capacity) { }

	// RVA: 0x27725A0 Offset: 0x27726A1 VA: 0x27725A0
	public ValueType Get(int index) { }

	// RVA: 0x27725E0 Offset: 0x27726E1 VA: 0x27725E0
	public void Set(int index, in ValueType value) { }

	// RVA: 0x2772660 Offset: 0x2772761 VA: 0x2772660
	public void Add(ValueType value) { }

	// RVA: 0x27726E0 Offset: 0x27727E1 VA: 0x27726E0
	public void Clear() { }
}

