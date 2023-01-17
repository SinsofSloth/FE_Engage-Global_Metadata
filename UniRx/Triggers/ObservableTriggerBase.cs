// Namespace: UniRx.Triggers
public abstract class ObservableTriggerBase : MonoBehaviour // TypeDefIndex: 6833
{
	// Fields
	private bool calledAwake; // 0x18
	private Subject<Unit> awake; // 0x20
	private bool calledStart; // 0x28
	private Subject<Unit> start; // 0x30
	private bool calledDestroy; // 0x38
	private Subject<Unit> onDestroy; // 0x40

	// Methods

	// RVA: 0x19E1110 Offset: 0x19E1211 VA: 0x19E1110
	private void Awake() { }

	// RVA: 0x19E1240 Offset: 0x19E1341 VA: 0x19E1240
	public IObservable<Unit> AwakeAsObservable() { }

	// RVA: 0x19E1400 Offset: 0x19E1501 VA: 0x19E1400
	private void Start() { }

	// RVA: 0x19E1530 Offset: 0x19E1631 VA: 0x19E1530
	public IObservable<Unit> StartAsObservable() { }

	// RVA: 0x19E16F0 Offset: 0x19E17F1 VA: 0x19E16F0
	private void OnDestroy() { }

	// RVA: 0x19E1820 Offset: 0x19E1921 VA: 0x19E1820
	public IObservable<Unit> OnDestroyAsObservable() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void RaiseOnCompletedOnDestroy();

	// RVA: 0x19DA5F0 Offset: 0x19DA6F1 VA: 0x19DA5F0
	protected void .ctor() { }
}

