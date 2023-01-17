// Namespace: App
public class Identifier // TypeDefIndex: 13839
{
	// Fields
	private const int Version = 0;
	private ulong m_UserId0; // 0x10
	private ulong m_UserId1; // 0x18
	private ulong m_MakeTime; // 0x20

	// Methods

	// RVA: 0x2C44F10 Offset: 0x2C45011 VA: 0x2C44F10
	public void Create() { }

	// RVA: 0x2C44FD0 Offset: 0x2C450D1 VA: 0x2C44FD0
	public void Create(Random random) { }

	// RVA: 0x2C45200 Offset: 0x2C45301 VA: 0x2C45200
	public void Clear() { }

	// RVA: 0x2C45210 Offset: 0x2C45311 VA: 0x2C45210
	public void CopyFrom(Identifier src) { }

	// RVA: 0x2C45230 Offset: 0x2C45331 VA: 0x2C45230
	public bool IsValid() { }

	// RVA: 0x2C45250 Offset: 0x2C45351 VA: 0x2C45250
	public void Serialize(Stream stream) { }

	// RVA: 0x2C452B0 Offset: 0x2C453B1 VA: 0x2C452B0
	public void Deserialize(Stream stream) { }

	// RVA: 0x2C454E0 Offset: 0x2C455E1 VA: 0x2C454E0
	public static void DummyDeserialize(Stream stream) { }

	// RVA: 0x2C456E0 Offset: 0x2C457E1 VA: 0x2C456E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2C457B0 Offset: 0x2C458B1 VA: 0x2C457B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C457D0 Offset: 0x2C458D1 VA: 0x2C457D0
	public static bool op_Equality(Identifier lhs, Identifier rhs) { }

	// RVA: 0x2C45830 Offset: 0x2C45931 VA: 0x2C45830
	public static bool op_Inequality(Identifier lhs, Identifier rhs) { }

	// RVA: 0x2C45890 Offset: 0x2C45991 VA: 0x2C45890
	private ulong MakeUserId(uint v0, uint v1) { }

	// RVA: 0x2C45080 Offset: 0x2C45181 VA: 0x2C45080
	private ulong MakeUserId(Random random) { }

	// RVA: 0x2C44FA0 Offset: 0x2C450A1 VA: 0x2C44FA0
	private ulong MakeMakeTime(DateTime dt) { }

	// RVA: 0x2C450E0 Offset: 0x2C451E1 VA: 0x2C450E0
	private ulong MakeMakeTime(Random random) { }

	// RVA: 0x2C458A0 Offset: 0x2C459A1 VA: 0x2C458A0
	public void .ctor() { }
}

