// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x138B0 Offset: 0x139B1 VA: 0x138B0
public class ObservableVisibleTrigger : ObservableTriggerBase // TypeDefIndex: 6838
{
	// Fields
	private Subject<Unit> onBecameInvisible; // 0x48
	private Subject<Unit> onBecameVisible; // 0x50

	// Methods

	// RVA: 0x19EAE00 Offset: 0x19EAF01 VA: 0x19EAE00
	private void OnBecameInvisible() { }

	// RVA: 0x19E4A70 Offset: 0x19E4B71 VA: 0x19E4A70
	public IObservable<Unit> OnBecameInvisibleAsObservable() { }

	// RVA: 0x19EAF00 Offset: 0x19EB001 VA: 0x19EAF00
	private void OnBecameVisible() { }

	// RVA: 0x19E4CB0 Offset: 0x19E4DB1 VA: 0x19E4CB0
	public IObservable<Unit> OnBecameVisibleAsObservable() { }

	// RVA: 0x19EB000 Offset: 0x19EB101 VA: 0x19EB000 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19EB070 Offset: 0x19EB171 VA: 0x19EB070
	public void .ctor() { }
}

