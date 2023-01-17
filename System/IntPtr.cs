// Namespace: System
[ComVisibleAttribute] // RVA: 0x471050 Offset: 0x471151 VA: 0x471050
[Serializable]
public struct IntPtr : ISerializable // TypeDefIndex: 371
{
	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47AFB0 Offset: 0x47B0B1 VA: 0x47AFB0
	// RVA: 0x3410E70 Offset: 0x3410F71 VA: 0x3410E70
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x47AFD0 Offset: 0x47B0D1 VA: 0x47AFD0
	// RVA: 0x3410E80 Offset: 0x3410F81 VA: 0x3410E80
	public void .ctor(long value) { }

	[ReliabilityContractAttribute] // RVA: 0x47AFF0 Offset: 0x47B0F1 VA: 0x47AFF0
	[CLSCompliantAttribute] // RVA: 0x47AFF0 Offset: 0x47B0F1 VA: 0x47AFF0
	// RVA: 0x3410E90 Offset: 0x3410F91 VA: 0x3410E90
	public void .ctor(void* value) { }

	// RVA: 0x3410EA0 Offset: 0x3410FA1 VA: 0x3410EA0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x47B040 Offset: 0x47B141 VA: 0x47B040
	// RVA: 0x3410F10 Offset: 0x3411011 VA: 0x3410F10
	public static int get_Size() { }

	// RVA: 0x3410F20 Offset: 0x3411021 VA: 0x3410F20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3410FE0 Offset: 0x34110E1 VA: 0x3410FE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3411070 Offset: 0x3411171 VA: 0x3411070 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x47B060 Offset: 0x47B161 VA: 0x47B060
	// RVA: 0x3410FD0 Offset: 0x34110D1 VA: 0x3410FD0
	public long ToInt64() { }

	[CLSCompliantAttribute] // RVA: 0x47B080 Offset: 0x47B181 VA: 0x47B080
	[ReliabilityContractAttribute] // RVA: 0x47B080 Offset: 0x47B181 VA: 0x47B080
	// RVA: 0x3411080 Offset: 0x3411181 VA: 0x3411080
	public void* ToPointer() { }

	// RVA: 0x3411090 Offset: 0x3411191 VA: 0x3411090 Slot: 3
	public override string ToString() { }

	// RVA: 0x34110D0 Offset: 0x34111D1 VA: 0x34110D0
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x47B0D0 Offset: 0x47B1D1 VA: 0x47B0D0
	// RVA: 0x3411110 Offset: 0x3411211 VA: 0x3411110
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x47B0F0 Offset: 0x47B1F1 VA: 0x47B0F0
	// RVA: 0x3411120 Offset: 0x3411221 VA: 0x3411120
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x47B110 Offset: 0x47B211 VA: 0x47B110
	// RVA: 0x3411130 Offset: 0x3411231 VA: 0x3411130
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x47B130 Offset: 0x47B231 VA: 0x47B130
	// RVA: 0x3411140 Offset: 0x3411241 VA: 0x3411140
	public static IntPtr op_Explicit(long value) { }

	[ReliabilityContractAttribute] // RVA: 0x47B150 Offset: 0x47B251 VA: 0x47B150
	[CLSCompliantAttribute] // RVA: 0x47B150 Offset: 0x47B251 VA: 0x47B150
	// RVA: 0x3411150 Offset: 0x3411251 VA: 0x3411150
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x3411160 Offset: 0x3411261 VA: 0x3411160
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0x3411170 Offset: 0x3411271 VA: 0x3411170
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x47B1A0 Offset: 0x47B2A1 VA: 0x47B1A0
	// RVA: 0x3411180 Offset: 0x3411281 VA: 0x3411180
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x47B1C0 Offset: 0x47B2C1 VA: 0x47B1C0
	// RVA: 0x3411190 Offset: 0x3411291 VA: 0x3411190
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[ReliabilityContractAttribute] // RVA: 0x47B1E0 Offset: 0x47B2E1 VA: 0x47B1E0
	// RVA: 0x34111A0 Offset: 0x34112A1 VA: 0x34111A0
	internal bool IsNull() { }
}

