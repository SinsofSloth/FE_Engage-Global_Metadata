// Namespace: Combat
[ExtensionAttribute] // RVA: 0x274A60 Offset: 0x274B61 VA: 0x274A60
public static class AnimClipKeyReductionExM // TypeDefIndex: 8833
{
	// Methods

	// RVA: 0x20F2D80 Offset: 0x20F2E81 VA: 0x20F2D80
	private static float GetValueFromTime(Keyframe key1, Keyframe key2, float time) { }

	// RVA: 0x20F2EE0 Offset: 0x20F2FE1 VA: 0x20F2EE0
	private static bool IsInterpolationValue(Keyframe key1, Keyframe key2, Keyframe comp, float eps) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AD0E0 Offset: 0x2AD1E1 VA: 0x2AD0E0
	// RVA: 0x20F30E0 Offset: 0x20F31E1 VA: 0x20F30E0
	private static IEnumerable<int> GetDeleteKeyIndex(Keyframe[] keys, float eps) { }

	[ExtensionAttribute] // RVA: 0x2AD150 Offset: 0x2AD251 VA: 0x2AD150
	// RVA: 0x20F3170 Offset: 0x20F3271 VA: 0x20F3170
	public static void KeyReduction(AnimationCurve in_curve, float eps = 0.0001) { }
}

