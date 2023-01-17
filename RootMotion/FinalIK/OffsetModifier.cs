// Namespace: RootMotion.FinalIK
public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 14469
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A53C0 Offset: 0x2A54C1 VA: 0x2A53C0
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x2A5400 Offset: 0x2A5501 VA: 0x2A5400
	public FullBodyBipedIK ik; // 0x20
	protected float lastTime; // 0x28

	// Properties
	protected float deltaTime { get; }

	// Methods

	// RVA: 0x2362740 Offset: 0x2362841 VA: 0x2362740
	protected float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnModifyOffset();

	// RVA: 0x2362770 Offset: 0x2362871 VA: 0x2362770 Slot: 5
	protected virtual void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D0AC0 Offset: 0x2D0BC1 VA: 0x2D0AC0
	// RVA: 0x23627F0 Offset: 0x23628F1 VA: 0x23627F0
	private IEnumerator Initiate() { }

	// RVA: 0x2362870 Offset: 0x2362971 VA: 0x2362870
	private void ModifyOffset() { }

	// RVA: 0x2362950 Offset: 0x2362A51 VA: 0x2362950
	protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits) { }

	// RVA: 0x2362A00 Offset: 0x2362B01 VA: 0x2362A00 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x2362B30 Offset: 0x2362C31 VA: 0x2362B30
	protected void .ctor() { }
}

