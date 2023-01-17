// Namespace: App
public class MapImageDanger : MapImageCoreBit // TypeDefIndex: 12108
{
	// Fields
	private const int Version = 1;
	private MapImageCoreBit m_Rod; // 0x18
	private MapImageCoreBit m_AttackAll; // 0x20
	private MapImageCoreBit m_RodAll; // 0x28
	private MapImageCoreBit m_GunnerAll; // 0x30
	private bool m_IsUpdate; // 0x38
	private int m_UpdateIndex; // 0x3C
	private List<Unit> m_UpdateTargets; // 0x40
	private MapDnagerDeploy m_MapDnagerDeploy; // 0x48

	// Methods

	// RVA: 0x246B990 Offset: 0x246BA91 VA: 0x246B990
	private void ClearImage() { }

	// RVA: 0x246B9F0 Offset: 0x246BAF1 VA: 0x246B9F0
	private void ClearUpdate() { }

	// RVA: 0x246BA50 Offset: 0x246BB51 VA: 0x246BA50 Slot: 4
	public override void Clear() { }

	// RVA: 0x246BB00 Offset: 0x246BC01 VA: 0x246BB00
	public bool GetRod(int x, int z) { }

	// RVA: 0x246BB40 Offset: 0x246BC41 VA: 0x246BB40
	public bool GetAttackAll(int x, int z) { }

	// RVA: 0x246BB80 Offset: 0x246BC81 VA: 0x246BB80
	public bool GetRodAll(int x, int z) { }

	// RVA: 0x246BBC0 Offset: 0x246BCC1 VA: 0x246BBC0
	public bool GetGunnerAll(int x, int z) { }

	// RVA: 0x246BC00 Offset: 0x246BD01 VA: 0x246BC00
	public bool ExistsRod() { }

	// RVA: 0x246BC10 Offset: 0x246BD11 VA: 0x246BC10
	public bool ExistsAttackAll() { }

	// RVA: 0x246BC20 Offset: 0x246BD21 VA: 0x246BC20
	public bool ExistsRodAll() { }

	// RVA: 0x246BC30 Offset: 0x246BD31 VA: 0x246BC30
	public bool ExistsGunnerAll() { }

	// RVA: 0x246BC40 Offset: 0x246BD41 VA: 0x246BC40
	public void Update() { }

	// RVA: 0x246BEC0 Offset: 0x246BFC1 VA: 0x246BEC0
	private static bool IsUpdateTarget(Unit unit) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C7BE0 Offset: 0x2C7CE1 VA: 0x2C7BE0
	// RVA: 0x246C020 Offset: 0x246C121 VA: 0x246C020
	public IEnumerator Coroutine() { }

	// RVA: 0x246C0A0 Offset: 0x246C1A1 VA: 0x246C0A0
	public void Serialize(Stream stream) { }

	// RVA: 0x246C0B0 Offset: 0x246C1B1 VA: 0x246C0B0
	public void Deserialize(Stream stream) { }

	// RVA: 0x246C1D0 Offset: 0x246C2D1 VA: 0x246C1D0
	public void .ctor() { }
}

