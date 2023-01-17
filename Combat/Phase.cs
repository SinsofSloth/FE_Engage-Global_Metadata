// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x273670 Offset: 0x273771 VA: 0x273670
public sealed class Phase // TypeDefIndex: 8501
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FE60 Offset: 0x27FF61 VA: 0x27FE60
	private static readonly Phase <Null>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x27FE70 Offset: 0x27FF71 VA: 0x27FE70
	private Phase <Prev>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x27FE80 Offset: 0x27FF81 VA: 0x27FE80
	private Phase <Next>k__BackingField; // 0x18
	public Phase.Kind kind; // 0x20
	public Phase.HitType hitType; // 0x24
	public Phase.Detail detail; // 0x28
	public int AttackSide; // 0x2C
	public int AttackHash; // 0x30
	public int DamageHash; // 0x34
	public SkillStack Skills; // 0x38
	public Decorators Decorators; // 0x40
	public int[] MaxHP; // 0x48
	public int[] HP; // 0x50
	public int[] Damage; // 0x58
	public int[] EngageCount; // 0x60

	// Properties
	public static Phase Null { get; }
	public bool IsStandingDie { get; }
	public Phase Prev { get; set; }
	public Phase Next { get; set; }
	public bool IsCritical { get; }
	public int DamageSide { get; }
	public float DamageRatio { get; set; }
	public int DamageEffectLevel { get; }
	public bool IsDamageHigh { get; }
	public int PrevContinuousAttack { get; }
	public int PrevContinuousDamage { get; }
	public bool IsComboFromPrev { get; }
	public bool IsComboToNext { get; }
	public bool IsFirstAttack { get; }
	public bool IsLastAttack { get; }
	public bool IsPlayerSideAttack { get; }
	public bool IsEnemySideAttack { get; }
	public Character Attacker { get; }
	public Character Damager { get; }
	public int ChainAttackCount { get; }

	// Methods

	// RVA: 0x236BBF0 Offset: 0x236BCF1 VA: 0x236BBF0
	public static bool op_Implicit(Phase a) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A89F0 Offset: 0x2A8AF1 VA: 0x2A89F0
	// RVA: 0x236BCE0 Offset: 0x236BDE1 VA: 0x236BCE0
	public static Phase get_Null() { }

	// RVA: 0x236BD50 Offset: 0x236BE51 VA: 0x236BD50
	public bool get_IsStandingDie() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8A00 Offset: 0x2A8B01 VA: 0x2A8A00
	// RVA: 0x236BD60 Offset: 0x236BE61 VA: 0x236BD60
	public Phase get_Prev() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8A10 Offset: 0x2A8B11 VA: 0x2A8A10
	// RVA: 0x236BD70 Offset: 0x236BE71 VA: 0x236BD70
	private void set_Prev(Phase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8A20 Offset: 0x2A8B21 VA: 0x2A8A20
	// RVA: 0x236BD80 Offset: 0x236BE81 VA: 0x236BD80
	public Phase get_Next() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8A30 Offset: 0x2A8B31 VA: 0x2A8A30
	// RVA: 0x236BD90 Offset: 0x236BE91 VA: 0x236BD90
	private void set_Next(Phase value) { }

	// RVA: 0x236BDA0 Offset: 0x236BEA1 VA: 0x236BDA0
	public void MakePair(Phase prev) { }

	// RVA: 0x236BDE0 Offset: 0x236BEE1 VA: 0x236BDE0
	public bool get_IsCritical() { }

	// RVA: 0x236BDF0 Offset: 0x236BEF1 VA: 0x236BDF0
	public int get_DamageSide() { }

	// RVA: 0x236BE00 Offset: 0x236BF01 VA: 0x236BE00
	public int GetGuardSide() { }

	// RVA: 0x236BEC0 Offset: 0x236BFC1 VA: 0x236BEC0
	public bool IsDeadSomeone() { }

	// RVA: 0x236BF50 Offset: 0x236C051 VA: 0x236BF50
	public int FindDieSide() { }

	// RVA: 0x236C060 Offset: 0x236C161 VA: 0x236C060
	public bool IsDeadDamager() { }

	// RVA: 0x236BFF0 Offset: 0x236C0F1 VA: 0x236BFF0
	public bool IsDead(int side) { }

	// RVA: 0x236C0F0 Offset: 0x236C1F1 VA: 0x236C0F0
	public bool IsSelfDamage() { }

	// RVA: 0x236C160 Offset: 0x236C261 VA: 0x236C160
	public bool IsSuicide() { }

	// RVA: 0x236C1D0 Offset: 0x236C2D1 VA: 0x236C1D0
	public bool IsHeal() { }

	// RVA: 0x236C1E0 Offset: 0x236C2E1 VA: 0x236C1E0
	public float get_DamageRatio() { }

	// RVA: 0x236C2B0 Offset: 0x236C3B1 VA: 0x236C2B0
	public void set_DamageRatio(float value) { }

	// RVA: 0x236C350 Offset: 0x236C451 VA: 0x236C350
	public int get_DamageEffectLevel() { }

	// RVA: 0x236C3A0 Offset: 0x236C4A1 VA: 0x236C3A0
	public bool get_IsDamageHigh() { }

	// RVA: 0x236C4D0 Offset: 0x236C5D1 VA: 0x236C4D0
	public int get_PrevContinuousAttack() { }

	// RVA: 0x236C500 Offset: 0x236C601 VA: 0x236C500
	public int get_PrevContinuousDamage() { }

	// RVA: 0x236C530 Offset: 0x236C631 VA: 0x236C530
	public bool get_IsComboFromPrev() { }

	// RVA: 0x236C560 Offset: 0x236C661 VA: 0x236C560
	public bool get_IsComboToNext() { }

	// RVA: 0x236C590 Offset: 0x236C691 VA: 0x236C590
	public bool get_IsFirstAttack() { }

	// RVA: 0x236C5A0 Offset: 0x236C6A1 VA: 0x236C5A0
	public bool get_IsLastAttack() { }

	// RVA: 0x236C5B0 Offset: 0x236C6B1 VA: 0x236C5B0
	public bool get_IsPlayerSideAttack() { }

	// RVA: 0x236C5C0 Offset: 0x236C6C1 VA: 0x236C5C0
	public bool get_IsEnemySideAttack() { }

	// RVA: 0x236C5D0 Offset: 0x236C6D1 VA: 0x236C5D0
	public Character get_Attacker() { }

	// RVA: 0x236C690 Offset: 0x236C791 VA: 0x236C690
	public Character get_Damager() { }

	// RVA: 0x236C750 Offset: 0x236C851 VA: 0x236C750
	public int get_ChainAttackCount() { }

	// RVA: 0x236C7D0 Offset: 0x236C8D1 VA: 0x236C7D0
	public void .ctor() { }

	// RVA: 0x236C8A0 Offset: 0x236C9A1 VA: 0x236C8A0
	private static void .cctor() { }
}

