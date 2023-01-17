// Namespace: Cinemachine
[HelpURLAttribute] // RVA: 0x1B850 Offset: 0x1B951 VA: 0x1B850
[DocumentationSortingAttribute] // RVA: 0x1B850 Offset: 0x1B951 VA: 0x1B850
[Serializable]
public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 5821
{
	// Fields
	[TooltipAttribute] // RVA: 0x21660 Offset: 0x21761 VA: 0x21660
	public CinemachineBlenderSettings.CustomBlend[] m_CustomBlends; // 0x18
	public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";

	// Methods

	// RVA: 0x1B88F90 Offset: 0x1B89091 VA: 0x1B88F90
	public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) { }

	// RVA: 0x1B891F0 Offset: 0x1B892F1 VA: 0x1B891F0
	public void .ctor() { }
}

