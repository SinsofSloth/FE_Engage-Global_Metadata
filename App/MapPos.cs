// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x277F80 Offset: 0x278081 VA: 0x277F80
public struct MapPos : IDisposable // TypeDefIndex: 12204
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Methods

	// RVA: 0x278CE50 Offset: 0x278CF51 VA: 0x278CE50
	public void .ctor(MapPos other) { }

	// RVA: 0x278CE60 Offset: 0x278CF61 VA: 0x278CE60
	public void .ctor(int x, int z) { }

	// RVA: 0x278CE70 Offset: 0x278CF71 VA: 0x278CE70 Slot: 4
	public void Dispose() { }

	// RVA: 0x278CE80 Offset: 0x278CF81 VA: 0x278CE80
	public void Add(MapPos other) { }

	// RVA: 0x278CEA0 Offset: 0x278CFA1 VA: 0x278CEA0
	public void Add(int x, int z) { }

	// RVA: 0x278CEC0 Offset: 0x278CFC1 VA: 0x278CEC0
	public void AddX(int x) { }

	// RVA: 0x278CED0 Offset: 0x278CFD1 VA: 0x278CED0
	public void AddZ(int z) { }

	// RVA: 0x278CEE0 Offset: 0x278CFE1 VA: 0x278CEE0
	public void Sub(MapPos other) { }

	// RVA: 0x278CF00 Offset: 0x278D001 VA: 0x278CF00
	public void Sub(int x, int z) { }

	// RVA: 0x278CF20 Offset: 0x278D021 VA: 0x278CF20
	public void SubX(int x) { }

	// RVA: 0x278CF30 Offset: 0x278D031 VA: 0x278CF30
	public void SubZ(int z) { }

	// RVA: 0x278CF40 Offset: 0x278D041 VA: 0x278CF40
	public static MapPos op_Addition(MapPos lhs, MapPos rhs) { }

	// RVA: 0x278CF60 Offset: 0x278D061 VA: 0x278CF60
	public static MapPos op_Subtraction(MapPos lhs, MapPos rhs) { }

	// RVA: 0x278CF80 Offset: 0x278D081 VA: 0x278CF80
	public static bool op_Equality(MapPos lhs, MapPos rhs) { }

	// RVA: 0x278CFA0 Offset: 0x278D0A1 VA: 0x278CFA0
	public static bool op_Inequality(MapPos lhs, MapPos rhs) { }

	// RVA: 0x278CFC0 Offset: 0x278D0C1 VA: 0x278CFC0 Slot: 0
	public override bool Equals(object rhsObj) { }

	// RVA: 0x278D060 Offset: 0x278D161 VA: 0x278D060
	public bool Equals(MapPos rhs) { }

	// RVA: 0x278D090 Offset: 0x278D191 VA: 0x278D090 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x278D0A0 Offset: 0x278D1A1 VA: 0x278D0A0 Slot: 3
	public override string ToString() { }
}

