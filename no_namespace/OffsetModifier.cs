// Namespace: 
[Serializable]
public class OffsetModifier.OffsetLimits // TypeDefIndex: 14467
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5440 Offset: 0x2A5541 VA: 0x2A5440
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A5480 Offset: 0x2A5581 VA: 0x2A5480
	public float spring; // 0x14
	[TooltipAttribute] // RVA: 0x2A54C0 Offset: 0x2A55C1 VA: 0x2A54C0
	public bool x; // 0x18
	[TooltipAttribute] // RVA: 0x2A5500 Offset: 0x2A5601 VA: 0x2A5500
	public bool y; // 0x19
	[TooltipAttribute] // RVA: 0x2A5540 Offset: 0x2A5641 VA: 0x2A5540
	public bool z; // 0x1A
	[TooltipAttribute] // RVA: 0x2A5580 Offset: 0x2A5681 VA: 0x2A5580
	public float minX; // 0x1C
	[TooltipAttribute] // RVA: 0x2A55C0 Offset: 0x2A56C1 VA: 0x2A55C0
	public float maxX; // 0x20
	[TooltipAttribute] // RVA: 0x2A5600 Offset: 0x2A5701 VA: 0x2A5600
	public float minY; // 0x24
	[TooltipAttribute] // RVA: 0x2A5640 Offset: 0x2A5741 VA: 0x2A5640
	public float maxY; // 0x28
	[TooltipAttribute] // RVA: 0x2A5680 Offset: 0x2A5781 VA: 0x2A5680
	public float minZ; // 0x2C
	[TooltipAttribute] // RVA: 0x2A56C0 Offset: 0x2A57C1 VA: 0x2A56C0
	public float maxZ; // 0x30

	// Methods

	// RVA: 0x1F1B9B0 Offset: 0x1F1BAB1 VA: 0x1F1B9B0
	public void Apply(IKEffector e, Quaternion rootRotation) { }

	// RVA: 0x1F1BBE0 Offset: 0x1F1BCE1 VA: 0x1F1BBE0
	private float SpringAxis(float value, float min, float max) { }

	// RVA: 0x1F1BC80 Offset: 0x1F1BD81 VA: 0x1F1BC80
	private float Spring(float value, float limit, bool negative) { }

	// RVA: 0x1F1BCE0 Offset: 0x1F1BDE1 VA: 0x1F1BCE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A2E0 Offset: 0x27A3E1 VA: 0x27A2E0
private sealed class OffsetModifier.<Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 14468
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public OffsetModifier <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2D0B30 Offset: 0x2D0C31 VA: 0x2D0B30
	// RVA: 0x1F1B7B0 Offset: 0x1F1B8B1 VA: 0x1F1B7B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0B40 Offset: 0x2D0C41 VA: 0x2D0B40
	// RVA: 0x1F1B7E0 Offset: 0x1F1B8E1 VA: 0x1F1B7E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F1B7F0 Offset: 0x1F1B8F1 VA: 0x1F1B7F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0B50 Offset: 0x2D0C51 VA: 0x2D0B50
	// RVA: 0x1F1B950 Offset: 0x1F1BA51 VA: 0x1F1B950 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0B60 Offset: 0x2D0C61 VA: 0x2D0B60
	// RVA: 0x1F1B960 Offset: 0x1F1BA61 VA: 0x1F1B960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2D0B70 Offset: 0x2D0C71 VA: 0x2D0B70
	// RVA: 0x1F1B9A0 Offset: 0x1F1BAA1 VA: 0x1F1B9A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

