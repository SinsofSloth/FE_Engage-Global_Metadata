// Namespace: Combat
public abstract class CharacterLying : MonoBehaviour // TypeDefIndex: 8663
{
	// Fields
	protected const float HumanCollideRadius = 0.8;
	private Character _cp; // 0x18
	private bool isRunning; // 0x20

	// Properties
	protected Character CP { get; }

	// Methods

	// RVA: 0x2B82510 Offset: 0x2B82611 VA: 0x2B82510
	protected Character get_CP() { }

	// RVA: 0x2B825D0 Offset: 0x2B826D1 VA: 0x2B825D0
	public void Run(int dieHash) { }

	// RVA: 0x2B82640 Offset: 0x2B82741 VA: 0x2B82640
	public void MakeDeadPose() { }

	// RVA: 0x2B82620 Offset: 0x2B82721 VA: 0x2B82620
	private void RunScheduler() { }

	// RVA: 0x2B82720 Offset: 0x2B82821 VA: 0x2B82720
	private void Update() { }

	// RVA: 0x2B82740 Offset: 0x2B82841 VA: 0x2B82740
	private void LateUpdate() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void MyStart(int dieHash);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void MakeMyDeadPose();

	// RVA: 0x2B82760 Offset: 0x2B82861 VA: 0x2B82760 Slot: 6
	protected virtual void MyUpdate() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void MyLateUpdate();

	// RVA: 0x2B82770 Offset: 0x2B82871 VA: 0x2B82770
	protected void .ctor() { }
}

