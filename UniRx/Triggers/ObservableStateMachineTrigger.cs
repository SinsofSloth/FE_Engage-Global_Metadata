// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13830 Offset: 0x13931 VA: 0x13830
public class ObservableStateMachineTrigger : StateMachineBehaviour // TypeDefIndex: 6829
{
	// Fields
	private Subject<ObservableStateMachineTrigger.OnStateInfo> onStateExit; // 0x18
	private Subject<ObservableStateMachineTrigger.OnStateInfo> onStateEnter; // 0x20
	private Subject<ObservableStateMachineTrigger.OnStateInfo> onStateIK; // 0x28
	private Subject<ObservableStateMachineTrigger.OnStateInfo> onStateUpdate; // 0x30
	private Subject<ObservableStateMachineTrigger.OnStateMachineInfo> onStateMachineEnter; // 0x38
	private Subject<ObservableStateMachineTrigger.OnStateMachineInfo> onStateMachineExit; // 0x40

	// Methods

	// RVA: 0x19DFD90 Offset: 0x19DFE91 VA: 0x19DFD90 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x19DFE70 Offset: 0x19DFF71 VA: 0x19DFE70
	public IObservable<ObservableStateMachineTrigger.OnStateInfo> OnStateExitAsObservable() { }

	// RVA: 0x19DFF10 Offset: 0x19E0011 VA: 0x19DFF10 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x19DFFF0 Offset: 0x19E00F1 VA: 0x19DFFF0
	public IObservable<ObservableStateMachineTrigger.OnStateInfo> OnStateEnterAsObservable() { }

	// RVA: 0x19E0090 Offset: 0x19E0191 VA: 0x19E0090 Slot: 8
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x19E0170 Offset: 0x19E0271 VA: 0x19E0170
	public IObservable<ObservableStateMachineTrigger.OnStateInfo> OnStateIKAsObservable() { }

	// RVA: 0x19E0210 Offset: 0x19E0311 VA: 0x19E0210 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x19E02F0 Offset: 0x19E03F1 VA: 0x19E02F0
	public IObservable<ObservableStateMachineTrigger.OnStateInfo> OnStateUpdateAsObservable() { }

	// RVA: 0x19E0390 Offset: 0x19E0491 VA: 0x19E0390 Slot: 9
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x19E0450 Offset: 0x19E0551 VA: 0x19E0450
	public IObservable<ObservableStateMachineTrigger.OnStateMachineInfo> OnStateMachineEnterAsObservable() { }

	// RVA: 0x19E04F0 Offset: 0x19E05F1 VA: 0x19E04F0 Slot: 10
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x19E05B0 Offset: 0x19E06B1 VA: 0x19E05B0
	public IObservable<ObservableStateMachineTrigger.OnStateMachineInfo> OnStateMachineExitAsObservable() { }

	// RVA: 0x19E0650 Offset: 0x19E0751 VA: 0x19E0650
	public void .ctor() { }
}

