// Namespace: UnityEngine.Rendering.Universal
[RequireComponent] // RVA: 0x47FCD0 Offset: 0x47FDD1 VA: 0x47FCD0
[DisallowMultipleComponent] // RVA: 0x47FCD0 Offset: 0x47FDD1 VA: 0x47FCD0
public class UniversalAdditionalLightData : MonoBehaviour // TypeDefIndex: 5352
{
	// Fields
	[SerializeField] // RVA: 0x482E30 Offset: 0x482F31 VA: 0x482E30
	[TooltipAttribute] // RVA: 0x482E30 Offset: 0x482F31 VA: 0x482E30
	private bool m_UsePipelineSettings; // 0x18
	[SerializeField] // RVA: 0x482E80 Offset: 0x482F81 VA: 0x482E80
	private float m_CustomIntensity; // 0x1C
	public static readonly int CustomMode_Default; // 0x0
	public static readonly int CustomMode_Batch; // 0x4
	[SerializeField] // RVA: 0x482E90 Offset: 0x482F91 VA: 0x482E90
	private int m_CustomMode; // 0x20

	// Properties
	public bool usePipelineSettings { get; set; }
	public float customIntensity { get; set; }
	public int customMode { get; set; }

	// Methods

	// RVA: 0x2F91AD0 Offset: 0x2F91BD1 VA: 0x2F91AD0
	public bool get_usePipelineSettings() { }

	// RVA: 0x2F91AE0 Offset: 0x2F91BE1 VA: 0x2F91AE0
	public void set_usePipelineSettings(bool value) { }

	// RVA: 0x2F91AF0 Offset: 0x2F91BF1 VA: 0x2F91AF0
	public float get_customIntensity() { }

	// RVA: 0x2F91B00 Offset: 0x2F91C01 VA: 0x2F91B00
	public void set_customIntensity(float value) { }

	// RVA: 0x2F91B10 Offset: 0x2F91C11 VA: 0x2F91B10
	public int get_customMode() { }

	// RVA: 0x2F91B20 Offset: 0x2F91C21 VA: 0x2F91B20
	public void set_customMode(int value) { }

	// RVA: 0x2F91B30 Offset: 0x2F91C31 VA: 0x2F91B30
	public void .ctor() { }

	// RVA: 0x2F91BC0 Offset: 0x2F91CC1 VA: 0x2F91BC0
	private static void .cctor() { }
}

