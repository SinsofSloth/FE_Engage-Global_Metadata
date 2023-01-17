// Namespace: RootMotion.FinalIK
public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 14471
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5700 Offset: 0x2A5801 VA: 0x2A5700
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x2A5740 Offset: 0x2A5841 VA: 0x2A5740
	public VRIK ik; // 0x20
	private float lastTime; // 0x28

	// Properties
	protected float deltaTime { get; }

	// Methods

	// RVA: 0x2362B40 Offset: 0x2362C41 VA: 0x2362B40
	protected float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnModifyOffset();

	// RVA: 0x2362B70 Offset: 0x2362C71 VA: 0x2362B70 Slot: 5
	protected virtual void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0B80 Offset: 0x2D0C81 VA: 0x2D0B80
	// RVA: 0x2362BF0 Offset: 0x2362CF1 VA: 0x2362BF0
	private IEnumerator Initiate() { }

	// RVA: 0x2362C70 Offset: 0x2362D71 VA: 0x2362C70
	private void ModifyOffset() { }

	// RVA: 0x2362D50 Offset: 0x2362E51 VA: 0x2362D50 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x2362E80 Offset: 0x2362F81 VA: 0x2362E80
	protected void .ctor() { }
}

