// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x5C720 Offset: 0x5C821 VA: 0x5C720
[RequiredByNativeCodeAttribute] // RVA: 0x5C720 Offset: 0x5C821 VA: 0x5C720
[NativeClassAttribute] // RVA: 0x5C720 Offset: 0x5C821 VA: 0x5C720
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 4048
{
	// Fields
	[NativeNameAttribute] // RVA: 0x5CBB0 Offset: 0x5CCB1 VA: 0x5CBB0
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x5CBF0 Offset: 0x5CCF1 VA: 0x5CBF0
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x5CC30 Offset: 0x5CD31 VA: 0x5CC30
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x5CC70 Offset: 0x5CD71 VA: 0x5CC70
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x5CCB0 Offset: 0x5CDB1 VA: 0x5CCB0
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x5CCF0 Offset: 0x5CDF1 VA: 0x5CCF0
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x5CD30 Offset: 0x5CE31 VA: 0x5CD30
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x5CD70 Offset: 0x5CE71 VA: 0x5CD70
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x5CDB0 Offset: 0x5CEB1 VA: 0x5CDB0
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x5CDF0 Offset: 0x5CEF1 VA: 0x5CDF0
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x5CE30 Offset: 0x5CF31 VA: 0x5CE30
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x1C5B370 Offset: 0x1C5B471 VA: 0x1C5B370
	private void CheckConsistency() { }

	// RVA: 0x1C5B410 Offset: 0x1C5B511 VA: 0x1C5B410
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x1C5B420 Offset: 0x1C5B521 VA: 0x1C5B420
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x1C5B480 Offset: 0x1C5B581 VA: 0x1C5B480
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x1C5B3C0 Offset: 0x1C5B4C1 VA: 0x1C5B3C0
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }
}

