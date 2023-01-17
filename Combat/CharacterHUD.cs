// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273DF0 Offset: 0x273EF1 VA: 0x273DF0
public sealed class CharacterHUD : MonoBehaviour // TypeDefIndex: 8607
{
	// Fields
	private Character _cp; // 0x18
	private CombatGaugeController CombatGaugeController; // 0x20

	// Properties
	private Character CP { get; }

	// Methods

	// RVA: 0x2B792E0 Offset: 0x2B793E1 VA: 0x2B792E0
	private Character get_CP() { }

	// RVA: 0x2B793A0 Offset: 0x2B794A1 VA: 0x2B793A0
	public void In() { }

	// RVA: 0x2B797A0 Offset: 0x2B798A1 VA: 0x2B797A0
	private void OnDestroy() { }

	// RVA: 0x2B79150 Offset: 0x2B79251 VA: 0x2B79150
	public void TryUpdateValues(int hp, int maxhp, int engageCount) { }

	// RVA: 0x2B79880 Offset: 0x2B79981 VA: 0x2B79880
	public void PushShowSkill(SkillData skillData) { }

	// RVA: 0x2B798A0 Offset: 0x2B799A1 VA: 0x2B798A0
	public void Out(float ntime = 0) { }

	// RVA: 0x2B798C0 Offset: 0x2B799C1 VA: 0x2B798C0
	public void .ctor() { }
}

