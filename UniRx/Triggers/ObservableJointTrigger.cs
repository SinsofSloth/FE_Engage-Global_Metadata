// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13760 Offset: 0x13861 VA: 0x13760
public class ObservableJointTrigger : ObservableTriggerBase // TypeDefIndex: 6814
{
	// Fields
	private Subject<float> onJointBreak; // 0x48
	private Subject<Joint2D> onJointBreak2D; // 0x50

	// Methods

	// RVA: 0x19DD840 Offset: 0x19DD941 VA: 0x19DD840
	private void OnJointBreak(float breakForce) { }

	// RVA: 0x19DD8B0 Offset: 0x19DD9B1 VA: 0x19DD8B0
	public IObservable<float> OnJointBreakAsObservable() { }

	// RVA: 0x19DD950 Offset: 0x19DDA51 VA: 0x19DD950
	private void OnJointBreak2D(Joint2D brokenJoint) { }

	// RVA: 0x19DD9C0 Offset: 0x19DDAC1 VA: 0x19DD9C0
	public IObservable<Joint2D> OnJointBreak2DAsObservable() { }

	// RVA: 0x19DDA60 Offset: 0x19DDB61 VA: 0x19DDA60 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DDAE0 Offset: 0x19DDBE1 VA: 0x19DDAE0
	public void .ctor() { }
}

