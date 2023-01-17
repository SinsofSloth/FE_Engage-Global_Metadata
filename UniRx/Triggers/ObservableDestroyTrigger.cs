// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136E0 Offset: 0x137E1 VA: 0x136E0
public class ObservableDestroyTrigger : MonoBehaviour // TypeDefIndex: 6806
{
	// Fields
	private bool calledDestroy; // 0x18
	private Subject<Unit> onDestroy; // 0x20
	private CompositeDisposable disposablesOnDestroy; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x13DB0 Offset: 0x13EB1 VA: 0x13DB0
	private bool <IsMonitoredActivate>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x13DC0 Offset: 0x13EC1 VA: 0x13DC0
	private bool <IsActivated>k__BackingField; // 0x31

	// Properties
	[ObsoleteAttribute] // RVA: 0x18750 Offset: 0x18851 VA: 0x18750
	internal bool IsMonitoredActivate { get; set; }
	public bool IsActivated { get; set; }
	public bool IsCalledOnDestroy { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x177A0 Offset: 0x178A1 VA: 0x177A0
	// RVA: 0x19DB410 Offset: 0x19DB511 VA: 0x19DB410
	internal bool get_IsMonitoredActivate() { }

	[CompilerGeneratedAttribute] // RVA: 0x177B0 Offset: 0x178B1 VA: 0x177B0
	// RVA: 0x19DB420 Offset: 0x19DB521 VA: 0x19DB420
	internal void set_IsMonitoredActivate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x177C0 Offset: 0x178C1 VA: 0x177C0
	// RVA: 0x19DB430 Offset: 0x19DB531 VA: 0x19DB430
	public bool get_IsActivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x177D0 Offset: 0x178D1 VA: 0x177D0
	// RVA: 0x19DB440 Offset: 0x19DB541 VA: 0x19DB440
	private void set_IsActivated(bool value) { }

	// RVA: 0x19DB450 Offset: 0x19DB551 VA: 0x19DB450
	public bool get_IsCalledOnDestroy() { }

	// RVA: 0x19DB460 Offset: 0x19DB561 VA: 0x19DB460
	private void Awake() { }

	// RVA: 0x19DB470 Offset: 0x19DB571 VA: 0x19DB470
	private void OnDestroy() { }

	// RVA: 0x19DB5B0 Offset: 0x19DB6B1 VA: 0x19DB5B0
	public IObservable<Unit> OnDestroyAsObservable() { }

	// RVA: 0x19DB7A0 Offset: 0x19DB8A1 VA: 0x19DB7A0
	public void ForceRaiseOnDestroy() { }

	// RVA: 0x19DB7B0 Offset: 0x19DB8B1 VA: 0x19DB7B0
	public void AddDisposableOnDestroy(IDisposable disposable) { }

	// RVA: 0x19DB8B0 Offset: 0x19DB9B1 VA: 0x19DB8B0
	public void .ctor() { }
}

