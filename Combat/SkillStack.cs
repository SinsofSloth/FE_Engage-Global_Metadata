// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x2736E0 Offset: 0x2737E1 VA: 0x2736E0
public sealed class SkillStack // TypeDefIndex: 8505
{
	// Fields
	public List<SkillStack.Packet> list; // 0x10
	private int[] damages; // 0x18

	// Properties
	public string DebuggerDisplay { get; }

	// Methods

	// RVA: 0x27E2290 Offset: 0x27E2391 VA: 0x27E2290
	public string get_DebuggerDisplay() { }

	// RVA: 0x27E24E0 Offset: 0x27E25E1 VA: 0x27E24E0
	public IEnumerator<SkillStack.Packet> GetEnumerator() { }

	// RVA: 0x27E2580 Offset: 0x27E2681 VA: 0x27E2580
	public int Damages(int side) { }

	// RVA: 0x27E25D0 Offset: 0x27E26D1 VA: 0x27E25D0
	public bool HasDamage() { }

	// RVA: 0x27E2620 Offset: 0x27E2721 VA: 0x27E2620
	public void PushSkill(SkillData data, int fromSide, int toSide, int plDamage = 0, int enDamage = 0) { }

	// RVA: 0x27E2840 Offset: 0x27E2941 VA: 0x27E2840
	public void ClearDamages() { }

	// RVA: 0x27E28A0 Offset: 0x27E29A1 VA: 0x27E28A0
	public SkillStack CloneAndClearIfNotNull() { }

	// RVA: 0x27E2B70 Offset: 0x27E2C71 VA: 0x27E2B70
	public Phase CreatePhaseForPopup(Phase src) { }

	// RVA: 0x27E2CB0 Offset: 0x27E2DB1 VA: 0x27E2CB0
	public void PreloadForAssetLoader() { }

	// RVA: 0x27E2DC0 Offset: 0x27E2EC1 VA: 0x27E2DC0
	public float CalcFreezeDuration() { }

	// RVA: 0x27E2AA0 Offset: 0x27E2BA1 VA: 0x27E2AA0
	public void .ctor() { }
}

