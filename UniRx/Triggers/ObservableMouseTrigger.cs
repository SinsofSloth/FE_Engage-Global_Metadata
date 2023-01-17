// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13780 Offset: 0x13881 VA: 0x13780
public class ObservableMouseTrigger : ObservableTriggerBase // TypeDefIndex: 6816
{
	// Fields
	private Subject<Unit> onMouseDown; // 0x48
	private Subject<Unit> onMouseDrag; // 0x50
	private Subject<Unit> onMouseEnter; // 0x58
	private Subject<Unit> onMouseExit; // 0x60
	private Subject<Unit> onMouseOver; // 0x68
	private Subject<Unit> onMouseUp; // 0x70
	private Subject<Unit> onMouseUpAsButton; // 0x78

	// Methods

	// RVA: 0x19DDE60 Offset: 0x19DDF61 VA: 0x19DDE60
	private void OnMouseDown() { }

	// RVA: 0x19DDF60 Offset: 0x19DE061 VA: 0x19DDF60
	public IObservable<Unit> OnMouseDownAsObservable() { }

	// RVA: 0x19DE000 Offset: 0x19DE101 VA: 0x19DE000
	private void OnMouseDrag() { }

	// RVA: 0x19DE100 Offset: 0x19DE201 VA: 0x19DE100
	public IObservable<Unit> OnMouseDragAsObservable() { }

	// RVA: 0x19DE1A0 Offset: 0x19DE2A1 VA: 0x19DE1A0
	private void OnMouseEnter() { }

	// RVA: 0x19DE2A0 Offset: 0x19DE3A1 VA: 0x19DE2A0
	public IObservable<Unit> OnMouseEnterAsObservable() { }

	// RVA: 0x19DE340 Offset: 0x19DE441 VA: 0x19DE340
	private void OnMouseExit() { }

	// RVA: 0x19DE440 Offset: 0x19DE541 VA: 0x19DE440
	public IObservable<Unit> OnMouseExitAsObservable() { }

	// RVA: 0x19DE4E0 Offset: 0x19DE5E1 VA: 0x19DE4E0
	private void OnMouseOver() { }

	// RVA: 0x19DE5E0 Offset: 0x19DE6E1 VA: 0x19DE5E0
	public IObservable<Unit> OnMouseOverAsObservable() { }

	// RVA: 0x19DE680 Offset: 0x19DE781 VA: 0x19DE680
	private void OnMouseUp() { }

	// RVA: 0x19DE780 Offset: 0x19DE881 VA: 0x19DE780
	public IObservable<Unit> OnMouseUpAsObservable() { }

	// RVA: 0x19DE820 Offset: 0x19DE921 VA: 0x19DE820
	private void OnMouseUpAsButton() { }

	// RVA: 0x19DE920 Offset: 0x19DEA21 VA: 0x19DE920
	public IObservable<Unit> OnMouseUpAsButtonAsObservable() { }

	// RVA: 0x19DE9C0 Offset: 0x19DEAC1 VA: 0x19DE9C0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DEA80 Offset: 0x19DEB81 VA: 0x19DEA80
	public void .ctor() { }
}

