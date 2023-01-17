// Namespace: Combat
public sealed class CombatViewerSettings : ScriptableObject // TypeDefIndex: 8715
{
	// Fields
	public List<CombatViewerSettings.ViewerPhase> ViewerPhaseArray; // 0x18
	public bool EternalCombat; // 0x20
	public bool ForceCrosscut; // 0x21
	public bool ForceBulletCamera; // 0x22
	public bool EnemyIsBoss; // 0x23
	public CameraPosition StartCamera; // 0x24
	public CameraSituationConverter.CameraLocateStyle CameraStyle; // 0x28
	public bool AttendanceEnemy; // 0x2C
	public bool AttendancePEmblem; // 0x2D
	public bool AttendanceEEmblem; // 0x2E
	public int AttendancePChain; // 0x30
	public int AttendanceEChain; // 0x34
	public int MapDistance; // 0x38
	public bool RepeatDemo; // 0x3C
	public bool FakeDead; // 0x3D
	public bool SpeedUp; // 0x3E

	// Methods

	// RVA: 0x2576070 Offset: 0x2576171 VA: 0x2576070
	public void ClearPhaseArray() { }

	// RVA: 0x25760F0 Offset: 0x25761F1 VA: 0x25760F0
	public void Random(int maxside) { }

	// RVA: 0x25766E0 Offset: 0x25767E1 VA: 0x25766E0
	public void Swap() { }

	// RVA: 0x2576830 Offset: 0x2576931 VA: 0x2576830
	public void Duplicate() { }

	// RVA: 0x2576B60 Offset: 0x2576C61 VA: 0x2576B60
	public void ReplaceDamageSide(string[] alter) { }

	// RVA: 0x2576D60 Offset: 0x2576E61 VA: 0x2576D60
	public void .ctor() { }
}

