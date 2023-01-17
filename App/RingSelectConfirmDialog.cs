// Namespace: App
public class RingSelectConfirmDialog : YesNoDialog // TypeDefIndex: 13230
{
	// Fields
	private static Unit m_unit; // 0x0
	private static GodUnit m_nextGod; // 0x8
	private static UnitRing m_nextRing; // 0x10

	// Methods

	// RVA: 0x26927D0 Offset: 0x26928D1 VA: 0x26927D0
	public static void CreateBindGod(ProcInst super, Unit unit, GodUnit nextGod) { }

	// RVA: 0x2692F90 Offset: 0x2693091 VA: 0x2692F90
	public static void CreateBindRing(ProcInst super, Unit unit, UnitRing nextRing) { }

	// RVA: 0x2692860 Offset: 0x2692961 VA: 0x2692860
	private static void CreateBind(ProcInst super, Unit unit, GodUnit nextGod, UnitRing nextRing) { }

	// RVA: 0x2693190 Offset: 0x2693291 VA: 0x2693190
	private static string CreateSetTitle(GodUnit nextGod) { }

	// RVA: 0x26936E0 Offset: 0x26937E1 VA: 0x26936E0
	private static string CreateSetTitle(UnitRing nextRing) { }

	// RVA: 0x2693A30 Offset: 0x2693B31 VA: 0x2693A30
	private static string CreateSetTitle(string nextName, string oldEquipUnitName, bool isArmlet) { }

	// RVA: 0x2693350 Offset: 0x2693451 VA: 0x2693350
	private static string CreateChangeTitle(Unit unit, GodUnit nextGod) { }

	// RVA: 0x2693790 Offset: 0x2693891 VA: 0x2693790
	private static string CreateChangeTitle(Unit unit, UnitRing nextRing) { }

	// RVA: 0x2693B80 Offset: 0x2693C81 VA: 0x2693B80
	private static string CreateChangeTitle(string removeName, string nextName, string oldEquipUnitName, bool isRemoveArmlet, bool isNextArmlet) { }

	// RVA: 0x2693020 Offset: 0x2693121 VA: 0x2693020
	private static string CreateRemoveTitle(GodUnit removeGod) { }

	// RVA: 0x2693660 Offset: 0x2693761 VA: 0x2693660
	private static string CreateRemoveTitle(UnitRing removeRing) { }

	// RVA: 0x2693D30 Offset: 0x2693E31 VA: 0x2693D30
	private static string CreateRemoveTitle(string removeName, bool isArmlet) { }

	// RVA: 0x26939B0 Offset: 0x2693AB1 VA: 0x26939B0
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x2693E10 Offset: 0x2693F11 VA: 0x2693E10
	private static void .cctor() { }
}

