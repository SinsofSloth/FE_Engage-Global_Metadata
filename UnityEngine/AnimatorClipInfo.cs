// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x34840 Offset: 0x34941 VA: 0x34840
[NativeHeaderAttribute] // RVA: 0x34840 Offset: 0x34941 VA: 0x34840
[UsedByNativeCodeAttribute] // RVA: 0x34840 Offset: 0x34941 VA: 0x34840
public struct AnimatorClipInfo // TypeDefIndex: 4094
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	// Properties
	public AnimationClip clip { get; }
	public float weight { get; }

	// Methods

	// RVA: 0x3EDB8A0 Offset: 0x3EDB9A1 VA: 0x3EDB8A0
	public AnimationClip get_clip() { }

	// RVA: 0x3EDB960 Offset: 0x3EDBA61 VA: 0x3EDB960
	public float get_weight() { }

	[FreeFunctionAttribute] // RVA: 0x36C70 Offset: 0x36D71 VA: 0x36C70
	// RVA: 0x3EDB910 Offset: 0x3EDBA11 VA: 0x3EDB910
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }
}

