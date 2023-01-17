// Namespace: 
[ReloadGroupAttribute] // RVA: 0x47F000 Offset: 0x47F101 VA: 0x47F000
[Serializable]
public sealed class PostProcessData.ShaderResources // TypeDefIndex: 5242
{
	// Fields
	[ReloadAttribute] // RVA: 0x4805C0 Offset: 0x4806C1 VA: 0x4805C0
	public Shader stopNanPS; // 0x10
	[ReloadAttribute] // RVA: 0x480600 Offset: 0x480701 VA: 0x480600
	public Shader subpixelMorphologicalAntialiasingPS; // 0x18
	[ReloadAttribute] // RVA: 0x480640 Offset: 0x480741 VA: 0x480640
	public Shader gaussianDepthOfFieldPS; // 0x20
	[ReloadAttribute] // RVA: 0x480680 Offset: 0x480781 VA: 0x480680
	public Shader bokehDepthOfFieldPS; // 0x28
	[ReloadAttribute] // RVA: 0x4806C0 Offset: 0x4807C1 VA: 0x4806C0
	public Shader cameraMotionBlurPS; // 0x30
	[ReloadAttribute] // RVA: 0x480700 Offset: 0x480801 VA: 0x480700
	public Shader paniniProjectionPS; // 0x38
	[ReloadAttribute] // RVA: 0x480740 Offset: 0x480841 VA: 0x480740
	public Shader lutBuilderLdrPS; // 0x40
	[ReloadAttribute] // RVA: 0x480780 Offset: 0x480881 VA: 0x480780
	public Shader lutBuilderHdrPS; // 0x48
	[ReloadAttribute] // RVA: 0x4807C0 Offset: 0x4808C1 VA: 0x4807C0
	public Shader bloomPS; // 0x50
	[ReloadAttribute] // RVA: 0x480800 Offset: 0x480901 VA: 0x480800
	public Shader uberPostPS; // 0x58
	[ReloadAttribute] // RVA: 0x480840 Offset: 0x480941 VA: 0x480840
	public Shader finalPostPassPS; // 0x60
	[ReloadAttribute] // RVA: 0x480880 Offset: 0x480981 VA: 0x480880
	public Shader customBlurPS; // 0x68
	[ReloadAttribute] // RVA: 0x4808C0 Offset: 0x4809C1 VA: 0x4808C0
	public Shader customFilterPS; // 0x70
	[ReloadAttribute] // RVA: 0x480900 Offset: 0x480A01 VA: 0x480900
	public Shader customUberPostPS; // 0x78

	// Methods

	// RVA: 0x2FA3D50 Offset: 0x2FA3E51 VA: 0x2FA3D50
	public void .ctor() { }
}

// Namespace: 
[ReloadGroupAttribute] // RVA: 0x47F010 Offset: 0x47F111 VA: 0x47F010
[Serializable]
public sealed class PostProcessData.TextureResources // TypeDefIndex: 5243
{
	// Fields
	[ReloadAttribute] // RVA: 0x480940 Offset: 0x480A41 VA: 0x480940
	public Texture2D[] blueNoise16LTex; // 0x10
	[ReloadAttribute] // RVA: 0x480990 Offset: 0x480A91 VA: 0x480990
	public Texture2D[] filmGrainTex; // 0x18
	[ReloadAttribute] // RVA: 0x480B20 Offset: 0x480C21 VA: 0x480B20
	public Texture2D smaaAreaTex; // 0x20
	[ReloadAttribute] // RVA: 0x480B60 Offset: 0x480C61 VA: 0x480B60
	public Texture2D smaaSearchTex; // 0x28

	// Methods

	// RVA: 0x2FA3D60 Offset: 0x2FA3E61 VA: 0x2FA3D60
	public void .ctor() { }
}

