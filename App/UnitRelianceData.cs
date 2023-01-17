// Namespace: App
public class UnitRelianceData // TypeDefIndex: 13542
{
	// Fields
	private const int Version = 1;
	private RelianceExpData m_RelianceExp; // 0x10
	private RelianceData.Level m_Level; // 0x18
	private sbyte m_Exp; // 0x1C
	private sbyte m_Score; // 0x1D

	// Properties
	public RelianceData.Level Level { get; }
	public int Exp { get; set; }
	public int Score { get; set; }

	// Methods

	// RVA: 0x2089880 Offset: 0x2089981 VA: 0x2089880
	public void .ctor(RelianceExpData relianceExp) { }

	// RVA: 0x208C600 Offset: 0x208C701 VA: 0x208C600
	public void Reset() { }

	// RVA: 0x2089A10 Offset: 0x2089B11 VA: 0x2089A10
	public void ResetMapBegin() { }

	// RVA: 0x208A180 Offset: 0x208A281 VA: 0x208A180
	public void AddExp(int value) { }

	// RVA: 0x208A860 Offset: 0x208A961 VA: 0x208A860
	public void AddScore(int value) { }

	// RVA: 0x208AB10 Offset: 0x208AC11 VA: 0x208AB10
	public bool CanLevelUp() { }

	// RVA: 0x208AC90 Offset: 0x208AD91 VA: 0x208AC90
	public void LevelUp() { }

	// RVA: 0x208B1C0 Offset: 0x208B2C1 VA: 0x208B1C0
	public void SetLevelAPlus() { }

	// RVA: 0x208B6E0 Offset: 0x208B7E1 VA: 0x208B6E0
	public void Serialize(Stream stream) { }

	// RVA: 0x208C230 Offset: 0x208C331 VA: 0x208C230
	public void Deserialize(Stream stream) { }

	// RVA: 0x208C720 Offset: 0x208C821 VA: 0x208C720
	public RelianceData.Level get_Level() { }

	// RVA: 0x208C730 Offset: 0x208C831 VA: 0x208C730
	public int get_Exp() { }

	// RVA: 0x208C740 Offset: 0x208C841 VA: 0x208C740
	public void set_Exp(int value) { }

	// RVA: 0x208C7D0 Offset: 0x208C8D1 VA: 0x208C7D0
	public int get_Score() { }

	// RVA: 0x208C7E0 Offset: 0x208C8E1 VA: 0x208C7E0
	public void set_Score(int value) { }

	// RVA: 0x208C6C0 Offset: 0x208C7C1 VA: 0x208C6C0
	private int GetNextLevelExp(RelianceData.Level currentLevel) { }

	// RVA: 0x208C820 Offset: 0x208C921 VA: 0x208C820
	public int GetClampExp() { }

	// RVA: 0x208C610 Offset: 0x208C711 VA: 0x208C610
	private sbyte ClampExp(int newExp) { }

	// RVA: 0x208C690 Offset: 0x208C791 VA: 0x208C690
	private sbyte ClampScore(int newScore) { }
}

