// Namespace: Combat
public sealed class CharacterIdleSMB : StateMachineBehaviour // TypeDefIndex: 8612
{
	// Fields
	private bool initialized; // 0x18
	private bool available; // 0x19
	private Character CP; // 0x20
	private CharacterGameStatus GS; // 0x28
	[HeaderAttribute] // RVA: 0x282670 Offset: 0x282771 VA: 0x282670
	public AnimationCurve TransitionCurve; // 0x30
	private float m_Elapsed; // 0x38

	// Methods

	// RVA: 0x2B7C5F0 Offset: 0x2B7C6F1 VA: 0x2B7C5F0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2B7C7A0 Offset: 0x2B7C8A1 VA: 0x2B7C7A0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2B7C930 Offset: 0x2B7CA31 VA: 0x2B7C930 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2B7C820 Offset: 0x2B7C921 VA: 0x2B7C820
	private void SetDying(float overwrite) { }

	// RVA: 0x2B7C9C0 Offset: 0x2B7CAC1 VA: 0x2B7C9C0
	public void ForceDying() { }

	// RVA: 0x2B7C9E0 Offset: 0x2B7CAE1 VA: 0x2B7C9E0
	public void .ctor() { }
}

