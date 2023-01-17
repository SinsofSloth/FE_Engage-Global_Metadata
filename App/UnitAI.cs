// Namespace: App
public class UnitAI // TypeDefIndex: 13505
{
	// Fields
	private const int Version = 7;
	private UnitAI.FlagField m_Flag; // 0x10
	private byte m_Band; // 0x18
	private byte m_Active; // 0x19
	private byte m_Priority; // 0x1A
	private byte m_HealRateA; // 0x1B
	private byte m_HealRateB; // 0x1C
	private byte m_BattleRateType; // 0x1D
	private byte m_ProhibitEngageAttack; // 0x1E
	private byte m_ProhibitRod; // 0x1F
	private byte m_ProhibitOverlap; // 0x20
	private byte m_RerewarpCount; // 0x21
	private byte m_RerewarpCountMax; // 0x22
	private byte m_RerewarpLastX; // 0x23
	private byte m_RerewarpLastZ; // 0x24
	private string m_RerewarpEventFlag; // 0x28
	private UnitAI.RandomFlagField m_RandomFlag; // 0x30
	private UnitAI.MoveLimitRange m_MoveLimit; // 0x38
	private byte m_VersusType; // 0x40
	private byte m_BulletPattern; // 0x41
	private string[] m_aSequence; // 0x48
	private AIValue[] m_aValue; // 0x50
	private Unit m_Unit; // 0x58
	private AIThink.Think m_VsThink; // 0x60

	// Properties
	public int Band { get; set; }
	public int Active { get; set; }
	public int Priority { get; set; }
	public int HealRateA { get; set; }
	public int HealRateB { get; set; }
	public UnitAI.BattleRate BattleRateType { get; set; }
	public int ProhibitEngageAttack { get; set; }
	public int ProhibitRod { get; set; }
	public int ProhibitOverlap { get; set; }
	public int RerewarpCount { get; set; }
	public int RerewarpCountMax { get; }
	public int RerewarpLastX { get; }
	public int RerewarpLastZ { get; }
	public string RerewarpEventFlag { get; }
	public UnitAI.MoveLimitRange MoveLimit { get; set; }
	public UnitAI.VersusTypes VersusType { get; set; }
	public int BulletPattern { get; set; }
	public AIThink.Think VsThink { get; set; }

	// Methods

	// RVA: 0x23C8610 Offset: 0x23C8711 VA: 0x23C8610
	public int get_Band() { }

	// RVA: 0x23C8620 Offset: 0x23C8721 VA: 0x23C8620
	public void set_Band(int value) { }

	// RVA: 0x23C8630 Offset: 0x23C8731 VA: 0x23C8630
	public int get_Active() { }

	// RVA: 0x23C8640 Offset: 0x23C8741 VA: 0x23C8640
	public void set_Active(int value) { }

	// RVA: 0x23C86C0 Offset: 0x23C87C1 VA: 0x23C86C0
	public int get_Priority() { }

	// RVA: 0x23C86D0 Offset: 0x23C87D1 VA: 0x23C86D0
	public void set_Priority(int value) { }

	// RVA: 0x23C86E0 Offset: 0x23C87E1 VA: 0x23C86E0
	public int get_HealRateA() { }

	// RVA: 0x23C86F0 Offset: 0x23C87F1 VA: 0x23C86F0
	public void set_HealRateA(int value) { }

	// RVA: 0x23C8700 Offset: 0x23C8801 VA: 0x23C8700
	public int get_HealRateB() { }

	// RVA: 0x23C8710 Offset: 0x23C8811 VA: 0x23C8710
	public void set_HealRateB(int value) { }

	// RVA: 0x23C8720 Offset: 0x23C8821 VA: 0x23C8720
	public UnitAI.BattleRate get_BattleRateType() { }

	// RVA: 0x23C8730 Offset: 0x23C8831 VA: 0x23C8730
	public void set_BattleRateType(UnitAI.BattleRate value) { }

	// RVA: 0x23C8740 Offset: 0x23C8841 VA: 0x23C8740
	public int get_ProhibitEngageAttack() { }

	// RVA: 0x23C8750 Offset: 0x23C8851 VA: 0x23C8750
	public void set_ProhibitEngageAttack(int value) { }

	// RVA: 0x23C8760 Offset: 0x23C8861 VA: 0x23C8760
	public int get_ProhibitRod() { }

	// RVA: 0x23C8770 Offset: 0x23C8871 VA: 0x23C8770
	public void set_ProhibitRod(int value) { }

	// RVA: 0x23C8780 Offset: 0x23C8881 VA: 0x23C8780
	public int get_ProhibitOverlap() { }

	// RVA: 0x23C8790 Offset: 0x23C8891 VA: 0x23C8790
	public void set_ProhibitOverlap(int value) { }

	// RVA: 0x23C87A0 Offset: 0x23C88A1 VA: 0x23C87A0
	public int get_RerewarpCount() { }

	// RVA: 0x23C87B0 Offset: 0x23C88B1 VA: 0x23C87B0
	public void set_RerewarpCount(int value) { }

	// RVA: 0x23C87C0 Offset: 0x23C88C1 VA: 0x23C87C0
	public int get_RerewarpCountMax() { }

	// RVA: 0x23C87D0 Offset: 0x23C88D1 VA: 0x23C87D0
	public int get_RerewarpLastX() { }

	// RVA: 0x23C87E0 Offset: 0x23C88E1 VA: 0x23C87E0
	public int get_RerewarpLastZ() { }

	// RVA: 0x23C87F0 Offset: 0x23C88F1 VA: 0x23C87F0
	public string get_RerewarpEventFlag() { }

	// RVA: 0x23C8800 Offset: 0x23C8901 VA: 0x23C8800
	public UnitAI.MoveLimitRange get_MoveLimit() { }

	// RVA: 0x23C8810 Offset: 0x23C8911 VA: 0x23C8810
	public void set_MoveLimit(UnitAI.MoveLimitRange value) { }

	// RVA: 0x23C8820 Offset: 0x23C8921 VA: 0x23C8820
	public UnitAI.VersusTypes get_VersusType() { }

	// RVA: 0x23C8830 Offset: 0x23C8931 VA: 0x23C8830
	public void set_VersusType(UnitAI.VersusTypes value) { }

	// RVA: 0x23C8840 Offset: 0x23C8941 VA: 0x23C8840
	public int get_BulletPattern() { }

	// RVA: 0x23C8850 Offset: 0x23C8951 VA: 0x23C8850
	public void set_BulletPattern(int value) { }

	// RVA: 0x23C8860 Offset: 0x23C8961 VA: 0x23C8860
	public AIThink.Think get_VsThink() { }

	// RVA: 0x23C8870 Offset: 0x23C8971 VA: 0x23C8870
	public void set_VsThink(AIThink.Think value) { }

	// RVA: 0x23C8880 Offset: 0x23C8981 VA: 0x23C8880
	public bool IsActive() { }

	// RVA: 0x23C8890 Offset: 0x23C8991 VA: 0x23C8890
	public bool CheckFlag(UnitAI.Flag flag) { }

	// RVA: 0x23C88A0 Offset: 0x23C89A1 VA: 0x23C88A0
	public bool NotFlag(UnitAI.Flag flag) { }

	// RVA: 0x23C88B0 Offset: 0x23C89B1 VA: 0x23C88B0
	public void SetFlag(UnitAI.Flag flag) { }

	// RVA: 0x23C88C0 Offset: 0x23C89C1 VA: 0x23C88C0
	public void ClearFlag(UnitAI.Flag flag) { }

	// RVA: 0x23C88D0 Offset: 0x23C89D1 VA: 0x23C88D0
	public int MaskFlag(UnitAI.Flag flag) { }

	// RVA: 0x23C88E0 Offset: 0x23C89E1 VA: 0x23C88E0
	public string GetSequence(AIValue.Order order) { }

	// RVA: 0x23C8920 Offset: 0x23C8A21 VA: 0x23C8920
	public int GetSequenceByIndex(AIValue.Order order) { }

	// RVA: 0x23C89D0 Offset: 0x23C8AD1 VA: 0x23C89D0
	public void SetSequence(AIValue.Order order, string name) { }

	// RVA: 0x23C8B50 Offset: 0x23C8C51 VA: 0x23C8B50
	public void SetSequence(AIValue.Order order, int v) { }

	// RVA: 0x23C8BF0 Offset: 0x23C8CF1 VA: 0x23C8BF0
	public AIValue GetValue(AIValue.Order order, int index) { }

	// RVA: 0x23C8C40 Offset: 0x23C8D41 VA: 0x23C8C40
	public void SetValue(AIValue.Order order, int index, int value) { }

	// RVA: 0x23C8D30 Offset: 0x23C8E31 VA: 0x23C8D30
	public void SetValue(AIValue.Order order, int index, int x, int z) { }

	// RVA: 0x23C8DE0 Offset: 0x23C8EE1 VA: 0x23C8DE0
	public string SetValue(AIValue.Order order, int index, string str) { }

	// RVA: 0x23C8E90 Offset: 0x23C8F91 VA: 0x23C8E90
	public void SetValue(AIValue.Order order, int index, AIValue value) { }

	// RVA: 0x23C8EE0 Offset: 0x23C8FE1 VA: 0x23C8EE0
	public void SetValues(AIValue.Order order, string str) { }

	// RVA: 0x23C90C0 Offset: 0x23C91C1 VA: 0x23C90C0
	public void ResetRandomFlag(byte value) { }

	// RVA: 0x23C90D0 Offset: 0x23C91D1 VA: 0x23C90D0
	public UnitAI.RandomFlagField GetRandomFlag() { }

	// RVA: 0x23C90E0 Offset: 0x23C91E1 VA: 0x23C90E0
	public void SetRerewarp(int countMax, int lastX, int lastZ, string eventFlag) { }

	// RVA: 0x23C9150 Offset: 0x23C9251 VA: 0x23C9150
	public void .ctor(Unit unit) { }

	// RVA: 0x23C9360 Offset: 0x23C9461 VA: 0x23C9360
	public void Clear() { }

	// RVA: 0x23C9750 Offset: 0x23C9851 VA: 0x23C9750
	public void Copy(UnitAI from) { }

	// RVA: 0x23C99C0 Offset: 0x23C9AC1 VA: 0x23C99C0
	public bool CanUseEngageAttack() { }

	// RVA: 0x23C9A30 Offset: 0x23C9B31 VA: 0x23C9A30
	public void SetupSummon() { }

	// RVA: 0x23C9B80 Offset: 0x23C9C81 VA: 0x23C9B80
	public void SetupVersus() { }

	// RVA: 0x23C9E40 Offset: 0x23C9F41 VA: 0x23C9E40
	public void SetUnitForVersus(Unit unit) { }

	// RVA: 0x23C9E50 Offset: 0x23C9F51 VA: 0x23C9E50
	public void Serialize(Stream stream) { }

	// RVA: 0x23CA050 Offset: 0x23CA151 VA: 0x23CA050
	public void Deserialize(Stream stream) { }

	// RVA: 0x23C8C30 Offset: 0x23C8D31 VA: 0x23C8C30
	private int GetValueIndex(AIValue.Order order, int index) { }
}

