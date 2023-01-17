// Namespace: Combat
internal static class GranUtility // TypeDefIndex: 8496
{
	// Methods

	// RVA: 0x27BBE20 Offset: 0x27BBF21 VA: 0x27BBE20
	private static TR CalcAttackStance2(Character ghr, float distance, bool allrange) { }

	// RVA: 0x27BC1C0 Offset: 0x27BC2C1 VA: 0x27BC1C0
	public static TR CalcAttackStanceNN(Character ghr, Phase phase) { }

	// RVA: 0x27BC2C0 Offset: 0x27BC3C1 VA: 0x27BC2C0
	public static TR CalcAttackStanceFN(Character ghr, Phase phase) { }

	// RVA: 0x27BC310 Offset: 0x27BC411 VA: 0x27BC310
	public static TR CalcAttackStanceFF(Character ghr) { }

	// RVA: 0x27BC470 Offset: 0x27BC571 VA: 0x27BC470
	public static TR CalcAttackStanceNF(Character ghr) { }

	// RVA: 0x27BC4C0 Offset: 0x27BC5C1 VA: 0x27BC4C0
	public static TR CalcShootStance(Character grandew) { }

	// RVA: 0x27BC660 Offset: 0x27BC761 VA: 0x27BC660
	public static TR CalcWaitPosition(Character grandew, float distance = 1.5, float degree = 90) { }

	// RVA: 0x27BC6E0 Offset: 0x27BC7E1 VA: 0x27BC6E0
	public static TR CalcWaitPosition(Character master, Character grandew, Character enemy, float distance, float degree) { }

	// RVA: 0x27BC360 Offset: 0x27BC461 VA: 0x27BC360
	public static TR CalcDamageStance(Character grandew) { }

	// RVA: 0x27BC9B0 Offset: 0x27BCAB1 VA: 0x27BC9B0
	public static TR Calc見切りStance(Character grandew) { }

	// RVA: 0x27BC860 Offset: 0x27BC961 VA: 0x27BC860
	private static TR CalcPoint(FXZ target, FXZ dirToTarget, float rad, float distance) { }

	// RVA: 0x27BCB70 Offset: 0x27BCC71 VA: 0x27BCB70
	public static TR CalcNearAttackStance(Character grandew, float distance = 3) { }

	// RVA: 0x27BCE30 Offset: 0x27BCF31 VA: 0x27BCE30
	public static TR CalcNearDamageStance(Character grandew, float distance = 3) { }

	// RVA: 0x27BCF80 Offset: 0x27BD081 VA: 0x27BCF80
	public static FXZ CalcBehindAttackLine(FXZ plpos, FXZ enpos, float ratio, float distance = 3) { }

	// RVA: 0x27BD1E0 Offset: 0x27BD2E1 VA: 0x27BD1E0
	public static FXZ CalcBehindAttackLine2(FXZ plpos, FXZ enpos, float ratio, float angle, float distance) { }

	// RVA: 0x27BCCC0 Offset: 0x27BCDC1 VA: 0x27BCCC0
	public static FXZ CalcBehindAttackLine3(Character grandew, float ratio, float angle, float distance) { }

	// RVA: 0x27BD400 Offset: 0x27BD501 VA: 0x27BD400
	public static FXZ CalcBehindAttackLine4(Character grandew, FXZ plpos, FXZ enpos, float ratio, float angle, float distance) { }
}

