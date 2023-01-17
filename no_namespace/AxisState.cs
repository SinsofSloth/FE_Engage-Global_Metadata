// Namespace: 
public enum AxisState.SpeedMode // TypeDefIndex: 5808
{
	// Fields
	public int value__; // 0x0
	public const AxisState.SpeedMode MaxSpeed = 0;
	public const AxisState.SpeedMode InputValueGain = 1;
}

// Namespace: 
public interface AxisState.IInputAxisProvider // TypeDefIndex: 5809
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetAxisValue(int axis);
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B7F0 Offset: 0x1B8F1 VA: 0x1B7F0
[Serializable]
public struct AxisState.Recentering // TypeDefIndex: 5810
{
	// Fields
	[TooltipAttribute] // RVA: 0x212C0 Offset: 0x213C1 VA: 0x212C0
	public bool m_enabled; // 0x0
	[TooltipAttribute] // RVA: 0x21300 Offset: 0x21401 VA: 0x21300
	public float m_WaitTime; // 0x4
	[TooltipAttribute] // RVA: 0x21340 Offset: 0x21441 VA: 0x21340
	public float m_RecenteringTime; // 0x8
	private float mLastAxisInputTime; // 0xC
	private float mRecenteringVelocity; // 0x10
	[SerializeField] // RVA: 0x21380 Offset: 0x21481 VA: 0x21380
	[FormerlySerializedAsAttribute] // RVA: 0x21380 Offset: 0x21481 VA: 0x21380
	[HideInInspector] // RVA: 0x21380 Offset: 0x21481 VA: 0x21380
	private int m_LegacyHeadingDefinition; // 0x14
	[SerializeField] // RVA: 0x213E0 Offset: 0x214E1 VA: 0x213E0
	[HideInInspector] // RVA: 0x213E0 Offset: 0x214E1 VA: 0x213E0
	[FormerlySerializedAsAttribute] // RVA: 0x213E0 Offset: 0x214E1 VA: 0x213E0
	private int m_LegacyVelocityFilterStrength; // 0x18

	// Methods

	// RVA: 0x1A87B30 Offset: 0x1A87C31 VA: 0x1A87B30
	public void .ctor(bool enabled, float waitTime, float recenteringTime) { }

	// RVA: 0x1A87B50 Offset: 0x1A87C51 VA: 0x1A87B50
	public void Validate() { }

	// RVA: 0x1A87BA0 Offset: 0x1A87CA1 VA: 0x1A87BA0
	public void CopyStateFrom(ref AxisState.Recentering other) { }

	// RVA: 0x1A87BC0 Offset: 0x1A87CC1 VA: 0x1A87BC0
	public void CancelRecentering() { }

	// RVA: 0x1A87C40 Offset: 0x1A87D41 VA: 0x1A87C40
	public void RecenterNow() { }

	// RVA: 0x1A87C50 Offset: 0x1A87D51 VA: 0x1A87C50
	public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) { }

	// RVA: 0x1A87E30 Offset: 0x1A87F31 VA: 0x1A87E30
	internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) { }
}

