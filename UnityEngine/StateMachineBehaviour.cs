// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x34710 Offset: 0x34811 VA: 0x34710
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 4075
{
	// Methods

	// RVA: 0x3EE0790 Offset: 0x3EE0891 VA: 0x3EE0790 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3EE07A0 Offset: 0x3EE08A1 VA: 0x3EE07A0 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3EE07B0 Offset: 0x3EE08B1 VA: 0x3EE07B0 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3EE07C0 Offset: 0x3EE08C1 VA: 0x3EE07C0 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3EE07D0 Offset: 0x3EE08D1 VA: 0x3EE07D0 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3EE07E0 Offset: 0x3EE08E1 VA: 0x3EE07E0 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3EE07F0 Offset: 0x3EE08F1 VA: 0x3EE07F0 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3EE0800 Offset: 0x3EE0901 VA: 0x3EE0800 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0810 Offset: 0x3EE0911 VA: 0x3EE0810 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0820 Offset: 0x3EE0921 VA: 0x3EE0820 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0830 Offset: 0x3EE0931 VA: 0x3EE0830 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0840 Offset: 0x3EE0941 VA: 0x3EE0840 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0850 Offset: 0x3EE0951 VA: 0x3EE0850 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0860 Offset: 0x3EE0961 VA: 0x3EE0860 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x3EE0870 Offset: 0x3EE0971 VA: 0x3EE0870
	protected void .ctor() { }
}

