// Namespace: App
public class ItemUseSequence : ProcInst // TypeDefIndex: 13007
{
	// Fields
	private Unit m_Unit; // 0x70
	private UnitItem m_UseItem; // 0x78
	private ItemData m_ItemData; // 0x80
	private int m_TargetIndex; // 0x88
	private int m_GainExp; // 0x8C

	// Methods

	// RVA: 0x245D0C0 Offset: 0x245D1C1 VA: 0x245D0C0
	private void .ctor() { }

	// RVA: 0x245D1B0 Offset: 0x245D2B1 VA: 0x245D1B0
	private void Branch() { }

	// RVA: 0x245D260 Offset: 0x245D361 VA: 0x245D260
	private Unit GetTargetUnit() { }

	// RVA: 0x245D400 Offset: 0x245D501 VA: 0x245D400
	private void PlayEffect() { }

	// RVA: 0x245D5F0 Offset: 0x245D6F1 VA: 0x245D5F0
	private static void HealHp(Unit unit, int heal) { }

	// RVA: 0x245D880 Offset: 0x245D981 VA: 0x245D880
	private static bool TryActiveSkill(Unit unit, SkillData skill) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAC10 Offset: 0x2CAD11 VA: 0x2CAC10
	// RVA: 0x245D8D0 Offset: 0x245D9D1 VA: 0x245D8D0
	private IEnumerator HealHp() { }

	// RVA: 0x245D950 Offset: 0x245DA51 VA: 0x245D950
	private void ItemUse() { }

	// RVA: 0x245DAA0 Offset: 0x245DBA1 VA: 0x245DAA0
	private void GainExp() { }

	// RVA: 0x245DDA0 Offset: 0x245DEA1 VA: 0x245DDA0
	private ItemData.UseTypes GetUseType() { }

	// RVA: 0x245DCE0 Offset: 0x245DDE1 VA: 0x245DCE0
	private bool IsWeaponEnchant() { }

	// RVA: 0x245DE40 Offset: 0x245DF41 VA: 0x245DE40
	private void WeaponEnchant() { }

	// RVA: 0x245E080 Offset: 0x245E181 VA: 0x245E080
	private void ShowMessage() { }

	// RVA: 0x245E170 Offset: 0x245E271 VA: 0x245E170
	private bool TryExpend(UnitItem unitItem) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAC80 Offset: 0x2CAD81 VA: 0x2CAC80
	// RVA: 0x245E2C0 Offset: 0x245E3C1 VA: 0x245E2C0
	private IEnumerator Expend() { }

	// RVA: 0x245E340 Offset: 0x245E441 VA: 0x245E340
	private void ClassChange() { }

	// RVA: 0x245E410 Offset: 0x245E511 VA: 0x245E410
	private void ClassChangeRescue() { }

	// RVA: 0x245E590 Offset: 0x245E691 VA: 0x245E590
	private int GetHealHp(Unit target) { }

	// RVA: 0x245E630 Offset: 0x245E731 VA: 0x245E630
	private bool CanHealHp(Unit target) { }

	// RVA: 0x245DC60 Offset: 0x245DD61 VA: 0x245DC60
	private bool CanGain(Unit target) { }

	// RVA: 0x245E840 Offset: 0x245E941 VA: 0x245E840
	private void TryNextTarget() { }

	// RVA: 0x245E8D0 Offset: 0x245E9D1 VA: 0x245E8D0
	private void TryGrow() { }

	// RVA: 0x245E920 Offset: 0x245EA21 VA: 0x245E920
	public static void CreateBind(ProcInst super) { }
}

