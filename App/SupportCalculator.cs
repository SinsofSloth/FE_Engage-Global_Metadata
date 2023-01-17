// Namespace: App
public class SupportCalculator // TypeDefIndex: 9546
{
	// Fields
	public const int Range = 1;
	public const int MaxShowUnits = 4;
	private Unit m_Unit; // 0x10
	private int m_X; // 0x18
	private int m_Z; // 0x1C
	private int m_Hit; // 0x20
	private int m_Avoid; // 0x24
	private int m_Critical; // 0x28
	private int m_Secure; // 0x2C
	private Unit[] m_ShowUnits; // 0x30
	private RelianceData.Level[] m_ShowUnitLevels; // 0x38
	private MapFor.RangeFunction m_RangeFunction; // 0x40

	// Properties
	public int Hit { get; }
	public int Avoid { get; }
	public int Critical { get; }
	public int Secure { get; }
	public Unit[] ShowUnits { get; }

	// Methods

	// RVA: 0x2928E90 Offset: 0x2928F91 VA: 0x2928E90
	public void .ctor() { }

	// RVA: 0x2928F90 Offset: 0x2929091 VA: 0x2928F90
	public void Clear() { }

	// RVA: 0x2929090 Offset: 0x2929191 VA: 0x2929090
	public void Setup(Unit unit, int x, int z) { }

	// RVA: 0x29290D0 Offset: 0x29291D1 VA: 0x29290D0
	public void RangeFunction(int x, int z, int range) { }

	// RVA: 0x2929320 Offset: 0x2929421 VA: 0x2929320
	public void Calc() { }

	// RVA: 0x2929460 Offset: 0x2929561 VA: 0x2929460
	public int get_Hit() { }

	// RVA: 0x2929470 Offset: 0x2929571 VA: 0x2929470
	public int get_Avoid() { }

	// RVA: 0x2929480 Offset: 0x2929581 VA: 0x2929480
	public int get_Critical() { }

	// RVA: 0x2929490 Offset: 0x2929591 VA: 0x2929490
	public int get_Secure() { }

	// RVA: 0x29294A0 Offset: 0x29295A1 VA: 0x29294A0
	public Unit[] get_ShowUnits() { }

	// RVA: 0x2929230 Offset: 0x2929331 VA: 0x2929230
	private void RegisterShowUnit(Unit unit, RelianceData.Level relianceLevel) { }

	// RVA: 0x29294B0 Offset: 0x29295B1 VA: 0x29294B0
	private void InsertShowUnit(int index, Unit unit, RelianceData.Level relianceLevel) { }
}

