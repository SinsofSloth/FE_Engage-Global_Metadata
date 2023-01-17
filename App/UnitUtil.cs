// Namespace: App
public class UnitUtil // TypeDefIndex: 13551
{
	// Methods

	// RVA: 0x20A3030 Offset: 0x20A3131 VA: 0x20A3030
	public static void Initialize() { }

	// RVA: 0x20A3080 Offset: 0x20A3181 VA: 0x20A3080
	public static void ResetUnitForce() { }

	// RVA: 0x20A39E0 Offset: 0x20A3AE1 VA: 0x20A39E0
	public static Unit JoinUnit(string pid) { }

	// RVA: 0x20A3A70 Offset: 0x20A3B71 VA: 0x20A3A70
	public static Unit JoinUnit(PersonData person) { }

	// RVA: 0x20A3D10 Offset: 0x20A3E11 VA: 0x20A3D10
	public static void JoinMessage(ProcInst super, PersonData person1, PersonData person2, PersonData person3) { }

	// RVA: 0x20A3CF0 Offset: 0x20A3DF1 VA: 0x20A3CF0
	public static bool IsJoinedUnit(PersonData person) { }

	// RVA: 0x20A3F40 Offset: 0x20A4041 VA: 0x20A3F40
	public static void BandActivate(Unit unit) { }

	// RVA: 0x20A40F0 Offset: 0x20A41F1 VA: 0x20A40F0
	public static UnitItem RefineWeapon(Unit unit, int ownerItemIndex, int refineLevel) { }

	// RVA: 0x20A4230 Offset: 0x20A4331 VA: 0x20A4230
	public static UnitItem EvolveWeapon(Unit unit, int ownerItemIndex, string evolveIid) { }

	// RVA: 0x20A45A0 Offset: 0x20A46A1 VA: 0x20A45A0
	public static UnitItem EngraveWeapon(Unit unit, int ownerItemIndex, GodData godData) { }

	// RVA: 0x20A46E0 Offset: 0x20A47E1 VA: 0x20A46E0
	public static void ClearEngraveWeapon(Unit unit, int ownerItemIndex) { }

	// RVA: 0x20A46F0 Offset: 0x20A47F1 VA: 0x20A46F0
	public static void ItemDisposalForDead(Unit unit) { }

	// RVA: 0x20A48A0 Offset: 0x20A49A1 VA: 0x20A48A0
	public static bool IsAttackRange(Unit unit, UnitItem unitItem, int attackX, int attackZ, int attackSize, int targetX, int targetZ, int targetSize) { }

	// RVA: 0x20A5030 Offset: 0x20A5131 VA: 0x20A5030
	public static bool IsAttackRange(Unit unit, UnitItem unitItem, int range) { }

	// RVA: 0x20A51B0 Offset: 0x20A52B1 VA: 0x20A51B0
	public static bool CanChainAttack(Unit unit, Unit chain, Unit target, UnitItem unitItem) { }

	// RVA: 0x20A5540 Offset: 0x20A5641 VA: 0x20A5540
	public static bool CanAutoEquipWhenAddingItem(Unit unit) { }

	// RVA: 0x20A5590 Offset: 0x20A5691 VA: 0x20A5590
	public static bool CanAutoEquipWhenAddingItem(Unit unit, ItemData item) { }

	// RVA: 0x20A5AD0 Offset: 0x20A5BD1 VA: 0x20A5AD0
	public static bool CanAutoEquipWhenAddingItem(Unit unit, UnitItem unitItem) { }

	// RVA: 0x20A5AE0 Offset: 0x20A5BE1 VA: 0x20A5AE0
	public static int GetRoundGrow(int percent) { }

	// RVA: 0x20A5B10 Offset: 0x20A5C11 VA: 0x20A5B10
	private static PersonData GetVisionPersonImpl() { }

	// RVA: 0x20A5BA0 Offset: 0x20A5CA1 VA: 0x20A5BA0
	private static int GetVisionCountImpl(Unit owner) { }

	// RVA: 0x20A5FC0 Offset: 0x20A60C1 VA: 0x20A5FC0
	private static bool CanVisionCreateImpl(Unit owner, int x, int z) { }

	// RVA: 0x20A6180 Offset: 0x20A6281 VA: 0x20A6180
	public static void ForEachVision(Unit owner, Action<Unit> func) { }

	// RVA: 0x20A65C0 Offset: 0x20A66C1 VA: 0x20A65C0
	public static Unit GetVisionOwner(Unit visionUnit) { }

	// RVA: 0x20A6680 Offset: 0x20A6781 VA: 0x20A6680
	public static bool IsVisionUnit(Unit owner, Unit unit) { }

	// RVA: 0x20A6720 Offset: 0x20A6821 VA: 0x20A6720
	public static bool HasVisionUnit(Unit owner) { }

	// RVA: 0x20A6760 Offset: 0x20A6861 VA: 0x20A6760
	public static bool CanVisionCreate(Unit owner) { }

	// RVA: 0x20A6880 Offset: 0x20A6981 VA: 0x20A6880
	private static Vector2Int[] GetVisionOffsets() { }

	// RVA: 0x20A6960 Offset: 0x20A6A61 VA: 0x20A6960
	public static void ForEachCreatableVision(Unit owner, int ownerX, int ownerZ, Action<SkillData, int, int> func) { }

	// RVA: 0x20A6790 Offset: 0x20A6891 VA: 0x20A6790
	public static int GetCreatableVisionCount(Unit owner, int ownerX, int ownerZ) { }

	// RVA: 0x20A6BA0 Offset: 0x20A6CA1 VA: 0x20A6BA0
	public static void VisionCreate(Unit owner) { }

	// RVA: 0x20A6DB0 Offset: 0x20A6EB1 VA: 0x20A6DB0
	public static bool CanVisionDelete(Unit owner) { }

	// RVA: 0x20A6DF0 Offset: 0x20A6EF1 VA: 0x20A6DF0
	public static void VisionDelete(Unit owner) { }

	// RVA: 0x20A6F50 Offset: 0x20A7051 VA: 0x20A6F50
	public static Unit GetSummonUnit(Unit owner) { }

	// RVA: 0x20A73B0 Offset: 0x20A74B1 VA: 0x20A73B0
	public static Unit SummonCreate(Unit owner, PersonData.Ranks rank, PersonData person) { }

	// RVA: 0x20A73C0 Offset: 0x20A74C1 VA: 0x20A73C0
	public static void SummonDelete(Unit owner) { }

	// RVA: 0x20A7560 Offset: 0x20A7661 VA: 0x20A7560
	private static void VisionDeleteImpl(Unit unit) { }

	// RVA: 0x20A7470 Offset: 0x20A7571 VA: 0x20A7470
	private static void SummonDeleteImpl(Unit unit) { }

	// RVA: 0x20A7650 Offset: 0x20A7751 VA: 0x20A7650
	public static void UnitUpdate() { }

	// RVA: 0x20A7E80 Offset: 0x20A7F81 VA: 0x20A7E80
	public static void ForceGathter(int x, int z, Force.Type[] types) { }

	// RVA: 0x20A81C0 Offset: 0x20A82C1 VA: 0x20A81C0
	private static bool GetFreePoint(Unit unit, ref int tx, ref int tz) { }

	// RVA: 0x20A84B0 Offset: 0x20A85B1 VA: 0x20A84B0
	public static bool TryAddReliance(Unit unitA, Unit unitB, string name) { }

	// RVA: 0x20A84F0 Offset: 0x20A85F1 VA: 0x20A84F0
	public static bool TryAddReliance(Unit unitA, Unit unitB, int value) { }

	// RVA: 0x20A85C0 Offset: 0x20A86C1 VA: 0x20A85C0
	public static bool TryAddExp(Unit unit, GodUnit godUnit, int exp) { }

	// RVA: 0x20A86E0 Offset: 0x20A87E1 VA: 0x20A86E0
	public static UnitUtil.DieType GetDieType(Unit unit) { }

	// RVA: 0x20A89E0 Offset: 0x20A8AE1 VA: 0x20A89E0
	private static bool TryGetExistMessage(out string mid, string label, string footer) { }

	// RVA: 0x20A8B10 Offset: 0x20A8C11 VA: 0x20A8B10
	private static string GetDieMessage(Unit unit, string ascii) { }

	// RVA: 0x20A8D50 Offset: 0x20A8E51 VA: 0x20A8D50
	public static string GetDieMessage(Unit unit) { }

	// RVA: 0x20A8DB0 Offset: 0x20A8EB1 VA: 0x20A8DB0
	public static string GetDieGodMessage(Unit unit) { }

	// RVA: 0x20A8F00 Offset: 0x20A9001 VA: 0x20A8F00
	public static string GetVoiceID(Unit unit) { }

	// RVA: 0x20A8F80 Offset: 0x20A9081 VA: 0x20A8F80
	public static bool IsSameUnit(Unit unit, Unit target) { }

	// RVA: 0x20A8FF0 Offset: 0x20A90F1 VA: 0x20A8FF0
	public static bool IsWeakness(Unit unit) { }

	// RVA: 0x20A9280 Offset: 0x20A9381 VA: 0x20A9280
	public static void ResetChapter(ChapterData chapter) { }

	// RVA: 0x20A9690 Offset: 0x20A9791 VA: 0x20A9690
	public static bool IsMultiChangeGod(Unit unit) { }

	// RVA: 0x20A96A0 Offset: 0x20A97A1 VA: 0x20A96A0
	private static bool IsOutOfView(Vector3 position) { }

	// RVA: 0x20A9780 Offset: 0x20A9881 VA: 0x20A9780
	public static bool TryMultiChangeGod(Unit unit) { }

	// RVA: 0x20A9790 Offset: 0x20A9891 VA: 0x20A9790
	private static string GetHelpKey(Unit unit) { }

	// RVA: 0x20A9820 Offset: 0x20A9921 VA: 0x20A9820
	public static void GodSaveEquip() { }

	// RVA: 0x20A9940 Offset: 0x20A9A41 VA: 0x20A9940
	public static void GodLoadEquip() { }

	// RVA: 0x20A9B20 Offset: 0x20A9C21 VA: 0x20A9B20
	public static int GetMoveFirstAdd(Unit unit) { }

	// RVA: 0x20A9C50 Offset: 0x20A9D51 VA: 0x20A9C50
	public static int GetMoveFirstAdd(Unit unit, int x, int z) { }

	// RVA: 0x20AA040 Offset: 0x20AA141 VA: 0x20AA040
	public static int GetMoveFirstAdd(JobData.MoveTypes moveType, int movePower, int x, int z) { }

	// RVA: 0x20AA220 Offset: 0x20AA321 VA: 0x20AA220
	public static int GetTotalItemCount(string iid) { }

	// RVA: 0x20AA2B0 Offset: 0x20AA3B1 VA: 0x20AA2B0
	public static int GetTotalItemCount(ItemData item) { }

	// RVA: 0x20AA550 Offset: 0x20AA651 VA: 0x20AA550
	public static void ClearEnhanceAll() { }

	// RVA: 0x20AA7B0 Offset: 0x20AA8B1 VA: 0x20AA7B0
	public void .ctor() { }
}

