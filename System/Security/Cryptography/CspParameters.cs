// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473D80 Offset: 0x473E81 VA: 0x473D80
public sealed class CspParameters // TypeDefIndex: 910
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x37DC1A0 Offset: 0x37DC2A1 VA: 0x37DC1A0
	public CspProviderFlags get_Flags() { }

	// RVA: 0x37DC1B0 Offset: 0x37DC2B1 VA: 0x37DC1B0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x37DC2A0 Offset: 0x37DC3A1 VA: 0x37DC2A0
	public void .ctor() { }

	// RVA: 0x37DC370 Offset: 0x37DC471 VA: 0x37DC370
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x37DC300 Offset: 0x37DC401 VA: 0x37DC300
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x37DC3D0 Offset: 0x37DC4D1 VA: 0x37DC3D0
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}

