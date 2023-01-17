// Namespace: 
public class AICannon.CannonData // TypeDefIndex: 9234
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286DB0 Offset: 0x286EB1 VA: 0x286DB0
	private readonly int <X>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286DC0 Offset: 0x286EC1 VA: 0x286DC0
	private readonly int <Z>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x286DD0 Offset: 0x286ED1 VA: 0x286DD0
	private readonly CannonInspector <Inspector>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x286DE0 Offset: 0x286EE1 VA: 0x286DE0
	private int <Occupant>k__BackingField; // 0x20

	// Properties
	public int X { get; }
	public int Z { get; }
	public CannonInspector Inspector { get; }
	public int Occupant { get; set; }

	// Methods

	// RVA: 0x2F2DCD0 Offset: 0x2F2DDD1 VA: 0x2F2DCD0
	public void .ctor(int x, int z, CannonInspector inspector) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE8C0 Offset: 0x2AE9C1 VA: 0x2AE8C0
	// RVA: 0x2F2E9C0 Offset: 0x2F2EAC1 VA: 0x2F2E9C0
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE8D0 Offset: 0x2AE9D1 VA: 0x2AE8D0
	// RVA: 0x2F2E9D0 Offset: 0x2F2EAD1 VA: 0x2F2E9D0
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE8E0 Offset: 0x2AE9E1 VA: 0x2AE8E0
	// RVA: 0x2F2E9E0 Offset: 0x2F2EAE1 VA: 0x2F2E9E0
	public CannonInspector get_Inspector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE8F0 Offset: 0x2AE9F1 VA: 0x2AE8F0
	// RVA: 0x2F2E9F0 Offset: 0x2F2EAF1 VA: 0x2F2E9F0
	public int get_Occupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE900 Offset: 0x2AEA01 VA: 0x2AE900
	// RVA: 0x2F2EA00 Offset: 0x2F2EB01 VA: 0x2F2EA00
	public void set_Occupant(int value) { }
}

// Namespace: 
private struct AICannon.CannonSkillScope : IDisposable // TypeDefIndex: 9236
{
	// Fields
	public Unit m_Actor; // 0x0
	public CannonInspector m_CannonInspector; // 0x8

	// Methods

	// RVA: 0x2F2EA10 Offset: 0x2F2EB11 VA: 0x2F2EA10
	public void .ctor(Unit actor, CannonInspector cannonInspector) { }

	// RVA: 0x2F2EA60 Offset: 0x2F2EB61 VA: 0x2F2EA60 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2752E0 Offset: 0x2753E1 VA: 0x2752E0
private sealed class AICannon.<>c__DisplayClass8_1 // TypeDefIndex: 9238
{
	// Fields
	public AICannon.CannonData cannon; // 0x10
	public int i; // 0x18
	public AICannon.<>c__DisplayClass8_0 CS$<>8__locals1; // 0x20
	public MapFor.RangeFunction <>9__0; // 0x28

	// Methods

	// RVA: 0x2F2DD30 Offset: 0x2F2DE31 VA: 0x2F2DD30
	public void .ctor() { }

	// RVA: 0x2F2DD40 Offset: 0x2F2DE41 VA: 0x2F2DD40
	internal void <Think>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275300 Offset: 0x275401 VA: 0x275300
private sealed class AICannon.<>c__DisplayClass12_0 // TypeDefIndex: 9240
{
	// Fields
	public List<AICannon.CannonData> cannons; // 0x10

	// Methods

	// RVA: 0x2F2DBB0 Offset: 0x2F2DCB1 VA: 0x2F2DBB0
	public void .ctor() { }

	// RVA: 0x2F2DBC0 Offset: 0x2F2DCC1 VA: 0x2F2DBC0
	internal void <EnumerateCannon>b__0(int x, int z) { }
}

