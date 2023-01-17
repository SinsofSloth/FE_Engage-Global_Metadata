// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C670 Offset: 0x43C771 VA: 0x43C670
[UsedByNativeCodeAttribute] // RVA: 0x43C670 Offset: 0x43C771 VA: 0x43C670
public sealed class LightmapData // TypeDefIndex: 3447
{
	// Fields
	internal Texture2D m_Light; // 0x10
	internal Texture2D m_Dir; // 0x18
	internal Texture2D m_ShadowMask; // 0x20

	// Properties
	public Texture2D lightmapColor { get; set; }
	public Texture2D lightmapDir { set; }
	public Texture2D shadowMask { get; set; }

	// Methods

	// RVA: 0x2F2A830 Offset: 0x2F2A931 VA: 0x2F2A830
	public Texture2D get_lightmapColor() { }

	// RVA: 0x2F2A840 Offset: 0x2F2A941 VA: 0x2F2A840
	public void set_lightmapColor(Texture2D value) { }

	// RVA: 0x2F2A850 Offset: 0x2F2A951 VA: 0x2F2A850
	public void set_lightmapDir(Texture2D value) { }

	// RVA: 0x2F2A860 Offset: 0x2F2A961 VA: 0x2F2A860
	public Texture2D get_shadowMask() { }

	// RVA: 0x2F2A870 Offset: 0x2F2A971 VA: 0x2F2A870
	public void set_shadowMask(Texture2D value) { }

	// RVA: 0x2F2A880 Offset: 0x2F2A981 VA: 0x2F2A880
	public void .ctor() { }
}

