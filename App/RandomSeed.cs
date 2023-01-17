// Namespace: App
public struct RandomSeed // TypeDefIndex: 13910
{
	// Fields
	private const int Version = 0;
	public uint Seed1; // 0x0
	public uint Seed2; // 0x4
	public uint Seed3; // 0x8
	public uint Seed4; // 0xC

	// Methods

	// RVA: 0x27690E0 Offset: 0x27691E1 VA: 0x27690E0
	public void Initialize() { }

	// RVA: 0x27691A0 Offset: 0x27692A1 VA: 0x27691A0
	public void Initialize(uint v) { }

	// RVA: 0x2769BC0 Offset: 0x2769CC1 VA: 0x2769BC0
	public void Serialize(Stream stream) { }

	// RVA: 0x2769EF0 Offset: 0x2769FF1 VA: 0x2769EF0
	public void Deserialize(Stream stream) { }

	// RVA: 0x2769200 Offset: 0x2769301 VA: 0x2769200
	public int Peek() { }

	// RVA: 0x2769260 Offset: 0x2769361 VA: 0x2769260
	public int GetValue() { }

	// RVA: 0x27692D0 Offset: 0x27693D1 VA: 0x27692D0
	public float GetFloat() { }

	[ConditionalAttribute] // RVA: 0x2CD900 Offset: 0x2CDA01 VA: 0x2CD900
	// RVA: 0x276A3B0 Offset: 0x276A4B1 VA: 0x276A3B0
	public void Dump() { }

	// RVA: 0x276A3C0 Offset: 0x276A4C1 VA: 0x276A3C0 Slot: 3
	public override string ToString() { }
}

