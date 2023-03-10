// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B9C0 Offset: 0x1BAC1 VA: 0x1B9C0
[Serializable]
public struct NoiseSettings.NoiseParams // TypeDefIndex: 5854
{
	// Fields
	[TooltipAttribute] // RVA: 0x22080 Offset: 0x22181 VA: 0x22080
	public float Frequency; // 0x0
	[TooltipAttribute] // RVA: 0x220C0 Offset: 0x221C1 VA: 0x220C0
	public float Amplitude; // 0x4
	[TooltipAttribute] // RVA: 0x22100 Offset: 0x22201 VA: 0x22100
	public bool Constant; // 0x8

	// Methods

	// RVA: 0x1A8B700 Offset: 0x1A8B801 VA: 0x1A8B700
	public float GetValueAt(float time, float timeOffset) { }
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B9E0 Offset: 0x1BAE1 VA: 0x1B9E0
[Serializable]
public struct NoiseSettings.TransformNoiseParams // TypeDefIndex: 5855
{
	// Fields
	[TooltipAttribute] // RVA: 0x22140 Offset: 0x22241 VA: 0x22140
	public NoiseSettings.NoiseParams X; // 0x0
	[TooltipAttribute] // RVA: 0x22180 Offset: 0x22281 VA: 0x22180
	public NoiseSettings.NoiseParams Y; // 0xC
	[TooltipAttribute] // RVA: 0x221C0 Offset: 0x222C1 VA: 0x221C0
	public NoiseSettings.NoiseParams Z; // 0x18

	// Methods

	// RVA: 0x1A82B90 Offset: 0x1A82C91 VA: 0x1A82B90
	public Vector3 GetValueAt(float time, Vector3 timeOffsets) { }
}

