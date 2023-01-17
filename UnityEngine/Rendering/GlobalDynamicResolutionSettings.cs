// Namespace: UnityEngine.Rendering
[Serializable]
public struct GlobalDynamicResolutionSettings // TypeDefIndex: 4527
{
	// Fields
	public bool enabled; // 0x0
	public float maxPercentage; // 0x4
	public float minPercentage; // 0x8
	public DynamicResolutionType dynResType; // 0xC
	public DynamicResUpscaleFilter upsampleFilter; // 0xD
	public bool forceResolution; // 0xE
	public float forcedPercentage; // 0x10

	// Methods

	// RVA: 0x1A10870 Offset: 0x1A10971 VA: 0x1A10870
	public static GlobalDynamicResolutionSettings NewDefault() { }
}

