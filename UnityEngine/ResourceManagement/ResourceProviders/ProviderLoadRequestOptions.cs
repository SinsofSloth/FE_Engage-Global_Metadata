// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class ProviderLoadRequestOptions // TypeDefIndex: 5597
{
	// Fields
	[SerializeField] // RVA: 0x72A40 Offset: 0x72B41 VA: 0x72A40
	private bool m_IgnoreFailures; // 0x10
	private int m_WebRequestTimeout; // 0x14

	// Properties
	public bool IgnoreFailures { get; set; }
	public int WebRequestTimeout { get; set; }

	// Methods

	// RVA: 0x3630CD0 Offset: 0x3630DD1 VA: 0x3630CD0
	public ProviderLoadRequestOptions Copy() { }

	// RVA: 0x3630D60 Offset: 0x3630E61 VA: 0x3630D60
	public bool get_IgnoreFailures() { }

	// RVA: 0x3630D70 Offset: 0x3630E71 VA: 0x3630D70
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x3630D80 Offset: 0x3630E81 VA: 0x3630D80
	public int get_WebRequestTimeout() { }

	// RVA: 0x3630D90 Offset: 0x3630E91 VA: 0x3630D90
	public void set_WebRequestTimeout(int value) { }

	// RVA: 0x3630DA0 Offset: 0x3630EA1 VA: 0x3630DA0
	public void .ctor() { }
}

