// Namespace: System.Net
[Serializable]
internal sealed class EmptyWebProxy : IWebProxy // TypeDefIndex: 2505
{
	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x1ADB4C0 Offset: 0x1ADB5C1 VA: 0x1ADB4C0
	public void .ctor() { }

	// RVA: 0x1ADB4D0 Offset: 0x1ADB5D1 VA: 0x1ADB4D0 Slot: 4
	public Uri GetProxy(Uri uri) { }

	// RVA: 0x1ADB4E0 Offset: 0x1ADB5E1 VA: 0x1ADB4E0 Slot: 5
	public bool IsBypassed(Uri uri) { }

	// RVA: 0x1ADB4F0 Offset: 0x1ADB5F1 VA: 0x1ADB4F0 Slot: 6
	public ICredentials get_Credentials() { }
}

