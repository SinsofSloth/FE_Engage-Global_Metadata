// Namespace: App
public class AIInterferenceSimulator : AISimulatorBase // TypeDefIndex: 9276
{
	// Fields
	private bool m_IsNotSuitable; // 0x34
	private int m_flag; // 0x38

	// Properties
	public bool IsNotSuitable { get; }
	public int Hit { get; }

	// Methods

	// RVA: 0x1CAC0A0 Offset: 0x1CAC1A1 VA: 0x1CAC0A0
	public bool get_IsNotSuitable() { }

	// RVA: 0x1CAC0B0 Offset: 0x1CAC1B1 VA: 0x1CAC0B0
	public int get_Hit() { }

	// RVA: 0x1CAC250 Offset: 0x1CAC351 VA: 0x1CAC250
	public void .ctor() { }

	// RVA: 0x1CAC280 Offset: 0x1CAC381 VA: 0x1CAC280
	public void Prepare(int flag = 0) { }

	// RVA: 0x1CAC290 Offset: 0x1CAC391 VA: 0x1CAC290
	public void Calculate(Unit offense, Unit defense, int x, int z, int range, int itemIndex, int defenseX = -1, int defenseZ = -1) { }

	// RVA: 0x1CAC350 Offset: 0x1CAC451 VA: 0x1CAC350
	private void CalculateBattleInfo(Unit offense, Unit defense, int x, int z, int range, int itemIndex, int defenseX, int defenseZ) { }

	// RVA: 0x1CAC520 Offset: 0x1CAC621 VA: 0x1CAC520
	private void CalculateScore() { }
}

