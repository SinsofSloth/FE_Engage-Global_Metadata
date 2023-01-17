// Namespace: App
public class RawValueStack // TypeDefIndex: 9214
{
	// Fields
	public int Count; // 0x10
	public ValueType[] Values; // 0x18

	// Properties
	public int Capacity { get; }

	// Methods

	// RVA: 0x2772720 Offset: 0x2772821 VA: 0x2772720
	public int get_Capacity() { }

	// RVA: 0x2772730 Offset: 0x2772831 VA: 0x2772730
	public void .ctor(int capacity) { }

	// RVA: 0x27727C0 Offset: 0x27728C1 VA: 0x27727C0
	public ValueType Get(int index) { }

	// RVA: 0x2772800 Offset: 0x2772901 VA: 0x2772800
	public void Set(int index, in ValueType value) { }

	// RVA: 0x2772880 Offset: 0x2772981 VA: 0x2772880
	public void Push(ValueType value) { }

	// RVA: 0x2772900 Offset: 0x2772A01 VA: 0x2772900
	public ValueType Pop() { }

	// RVA: 0x2772960 Offset: 0x2772A61 VA: 0x2772960
	public void Clear() { }
}

