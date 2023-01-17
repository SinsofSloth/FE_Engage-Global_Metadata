// Namespace: App
public class UnitInfoParamManager : SingletonClass<UnitInfoParamManager> // TypeDefIndex: 11854
{
	// Fields
	private Unit m_CalcUnit; // 0x20
	private BattleInfoParam m_BattleInfoParam; // 0x28
	private Unit m_CalcUnitNoGod; // 0x30
	private BattleInfoParam m_BattleInfoParamNoGod; // 0x38
	private Unit m_CalcUnitNoEffect; // 0x40
	private BattleInfoParam m_BattleInfoParamNoEffect; // 0x48
	private Unit m_CalcUnitNoHub; // 0x50
	private BattleInfoParam m_BattleInfoParamNoHub; // 0x58
	private BattleInfo m_BattleInfo; // 0x60
	private Unit m_OldRingOwner; // 0x68
	private UnitParamDetail[] m_param; // 0x70

	// Methods

	// RVA: 0x23F4F70 Offset: 0x23F5071 VA: 0x23F4F70
	public void .ctor() { }

	// RVA: 0x23F5280 Offset: 0x23F5381 VA: 0x23F5280
	public void CopyValue(UnitParamDetail.ValueDetail type, out int[] value) { }

	// RVA: 0x23F5370 Offset: 0x23F5471 VA: 0x23F5370
	private void MargeMaxEnhanceFactors(UnitEnhanceFactors factors, Unit unit) { }

	// RVA: 0x23F54A0 Offset: 0x23F55A1 VA: 0x23F54A0
	public void SetUnit(Unit unit, int x, int z, bool isDiffCollect, BattleInfo.Flags f = 0, bool isGodChange = False, GodUnit god, UnitRing ring) { }

	// RVA: 0x23FB8B0 Offset: 0x23FB9B1 VA: 0x23FB8B0
	public void ClearUnit(GodUnit god, UnitRing ring) { }

	// RVA: 0x23FB920 Offset: 0x23FBA21 VA: 0x23FB920
	public UnitParamDetail GetParam(UnitInfoParamManager.ValueType type) { }

	// RVA: 0x23FB960 Offset: 0x23FBA61 VA: 0x23FB960
	public UnitParamDetail GetParam(CapabilityDefinition.Type type) { }

	// RVA: 0x23FB9C0 Offset: 0x23FBAC1 VA: 0x23FB9C0
	public static CapabilityDefinition.Type ToGrowCapabilityType(UnitInfoParamManager.ValueType type) { }

	// RVA: 0x23FB9E0 Offset: 0x23FBAE1 VA: 0x23FB9E0
	public static UnitInfoParamManager.ValueType ToValueType(CapabilityDefinition.Type type) { }

	// RVA: 0x23FBA00 Offset: 0x23FBB01 VA: 0x23FBA00
	public Unit GetCalcUnit() { }

	// RVA: 0x23FBA10 Offset: 0x23FBB11 VA: 0x23FBA10
	public Unit GetCalcNoGod() { }

	// RVA: 0x23FBA20 Offset: 0x23FBB21 VA: 0x23FBA20
	public Unit GetCalcNoEnhance() { }

	// RVA: 0x23FA9B0 Offset: 0x23FAAB1 VA: 0x23FA9B0
	private int GetCapabilityRating(Unit unit, BattleInfoParam info) { }
}

