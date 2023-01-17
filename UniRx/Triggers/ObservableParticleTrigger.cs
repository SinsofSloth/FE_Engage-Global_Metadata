// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137A0 Offset: 0x138A1 VA: 0x137A0
public class ObservableParticleTrigger : ObservableTriggerBase // TypeDefIndex: 6818
{
	// Fields
	private Subject<GameObject> onParticleCollision; // 0x48
	private Subject<Unit> onParticleTrigger; // 0x50

	// Methods

	// RVA: 0x19DEC10 Offset: 0x19DED11 VA: 0x19DEC10
	private void OnParticleCollision(GameObject other) { }

	// RVA: 0x19DEC80 Offset: 0x19DED81 VA: 0x19DEC80
	public IObservable<GameObject> OnParticleCollisionAsObservable() { }

	// RVA: 0x19DED20 Offset: 0x19DEE21 VA: 0x19DED20
	private void OnParticleTrigger() { }

	// RVA: 0x19DEE20 Offset: 0x19DEF21 VA: 0x19DEE20
	public IObservable<Unit> OnParticleTriggerAsObservable() { }

	// RVA: 0x19DEEC0 Offset: 0x19DEFC1 VA: 0x19DEEC0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DEF40 Offset: 0x19DF041 VA: 0x19DEF40
	public void .ctor() { }
}

