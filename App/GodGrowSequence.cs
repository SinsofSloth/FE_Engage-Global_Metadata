// Namespace: App
public class GodGrowSequence : ProcInst // TypeDefIndex: 12996
{
	// Fields
	private GodUnit m_GodUnit; // 0x70
	private Unit m_Unit; // 0x78
	private int m_Exp; // 0x80
	private int m_Dirty; // 0x84
	private int m_OldLevel; // 0x88

	// Methods

	// RVA: 0x27A3760 Offset: 0x27A3861 VA: 0x27A3760
	public static void CreateBind(ProcInst super, GodUnit godUnit, int exp) { }

	// RVA: 0x27A3CE0 Offset: 0x27A3DE1 VA: 0x27A3CE0
	public static void CreateBind(ProcInst super, GodUnit godUnit, Unit unit, int exp) { }

	// RVA: 0x27A3CF0 Offset: 0x27A3DF1 VA: 0x27A3CF0
	public static void CreateBind(ProcInst super, GodUnit godUnit, Unit unit, int exp, int dirty) { }

	// RVA: 0x27A3770 Offset: 0x27A3871 VA: 0x27A3770
	private static void CreateBindImpl(ProcInst super, GodUnit godUnit, Unit unit, int exp, int dirty) { }

	// RVA: 0x27A3D00 Offset: 0x27A3E01 VA: 0x27A3D00
	private void .ctor(GodUnit godUnit, Unit unit, int exp, int dirty) { }

	// RVA: 0x27A3DD0 Offset: 0x27A3ED1 VA: 0x27A3DD0
	private void GainExp() { }

	// RVA: 0x27A3E80 Offset: 0x27A3F81 VA: 0x27A3E80
	private void GainDirty() { }

	// RVA: 0x27A3F80 Offset: 0x27A4081 VA: 0x27A3F80
	private void CheckNotifyLevelCapTalk() { }

	// RVA: 0x27A40E0 Offset: 0x27A41E1 VA: 0x27A40E0
	private void NotifyLevelCapTalk() { }

	// RVA: 0x27A4320 Offset: 0x27A4421 VA: 0x27A4320
	private void CheckLevelUp() { }

	// RVA: 0x27A4400 Offset: 0x27A4501 VA: 0x27A4400
	private void LevelUp() { }
}

