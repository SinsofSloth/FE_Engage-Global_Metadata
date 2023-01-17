// Namespace: Combat
internal abstract class ActionGranBase : ActionDisposerHolder // TypeDefIndex: 8410
{
	// Fields
	protected const float AttackLineBehind = 2;
	protected const float DamageLineBehind = 2;
	protected const float BackstepDistance = 3.5;
	[CompilerGeneratedAttribute] // RVA: 0x27FD80 Offset: 0x27FE81 VA: 0x27FD80
	private readonly bool <IsSkyLandCombat>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x27FD90 Offset: 0x27FE91 VA: 0x27FD90
	private ActionGranBase.MoveAct <moveAct>k__BackingField; // 0x34
	private FXZ warpedGoal; // 0x38

	// Properties
	protected bool IsSkyLandCombat { get; }
	protected ActionGranBase.MoveAct moveAct { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A85B0 Offset: 0x2A86B1 VA: 0x2A85B0
	// RVA: 0x2EC69D0 Offset: 0x2EC6AD1 VA: 0x2EC69D0
	protected bool get_IsSkyLandCombat() { }

	// RVA: 0x2EC5C90 Offset: 0x2EC5D91 VA: 0x2EC5C90
	protected static bool MasterIsFarAndGrandewIsNear(Character ghr) { }

	// RVA: 0x2EC5E30 Offset: 0x2EC5F31 VA: 0x2EC5E30
	public void .ctor(Character ghr) { }

	// RVA: 0x2EC69E0 Offset: 0x2EC6AE1 VA: 0x2EC69E0
	private static bool isskyland() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A85C0 Offset: 0x2A86C1 VA: 0x2A85C0
	// RVA: 0x2EC6B20 Offset: 0x2EC6C21 VA: 0x2EC6B20
	protected ActionGranBase.MoveAct get_moveAct() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A85D0 Offset: 0x2A86D1 VA: 0x2A85D0
	// RVA: 0x2EC6B30 Offset: 0x2EC6C31 VA: 0x2EC6B30
	private void set_moveAct(ActionGranBase.MoveAct value) { }

	// RVA: 0x2EC66C0 Offset: 0x2EC67C1 VA: 0x2EC66C0
	protected float MoveTo(FXZ goal) { }

	// RVA: 0x2EC5FE0 Offset: 0x2EC60E1 VA: 0x2EC5FE0
	protected float RunTo(FXZ goal) { }

	// RVA: 0x2EC6B40 Offset: 0x2EC6C41 VA: 0x2EC6B40
	private float Warp(FXZ goal) { }

	// RVA: 0x2EC6140 Offset: 0x2EC6241 VA: 0x2EC6140
	protected void MoveEnd() { }

	// RVA: 0x2EC6BB0 Offset: 0x2EC6CB1 VA: 0x2EC6BB0
	protected int GetEvasionHash() { }

	// RVA: 0x2EC5CF0 Offset: 0x2EC5DF1 VA: 0x2EC5CF0
	protected static TR CalcAttackTR(Character ghr) { }

	// RVA: 0x2EC6F80 Offset: 0x2EC7081 VA: 0x2EC6F80
	private static TR CalcAttackNNTR(Character ghr) { }

	// RVA: 0x2EC6DB0 Offset: 0x2EC6EB1 VA: 0x2EC6DB0
	private static TR CalcAttackNFTR(Character ghr) { }

	// RVA: 0x2EC6BF0 Offset: 0x2EC6CF1 VA: 0x2EC6BF0
	private static TR CalcAttackFFTR(Character ghr) { }

	// RVA: 0x2EC6540 Offset: 0x2EC6641 VA: 0x2EC6540
	protected static TR CalcDamageTR(Character ghr) { }

	// RVA: 0x2EC71D0 Offset: 0x2EC72D1 VA: 0x2EC71D0
	public void AdjustGroundLevel(int side) { }
}

