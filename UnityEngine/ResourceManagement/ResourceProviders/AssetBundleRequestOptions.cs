// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class AssetBundleRequestOptions : ILocationSizeData // TypeDefIndex: 5576
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x72810 Offset: 0x72911 VA: 0x72810
	[SerializeField] // RVA: 0x72810 Offset: 0x72911 VA: 0x72810
	private string m_Hash; // 0x10
	[SerializeField] // RVA: 0x72860 Offset: 0x72961 VA: 0x72860
	[FormerlySerializedAsAttribute] // RVA: 0x72860 Offset: 0x72961 VA: 0x72860
	private uint m_Crc; // 0x18
	[SerializeField] // RVA: 0x728B0 Offset: 0x729B1 VA: 0x728B0
	[FormerlySerializedAsAttribute] // RVA: 0x728B0 Offset: 0x729B1 VA: 0x728B0
	private int m_Timeout; // 0x1C
	[SerializeField] // RVA: 0x72900 Offset: 0x72A01 VA: 0x72900
	[FormerlySerializedAsAttribute] // RVA: 0x72900 Offset: 0x72A01 VA: 0x72900
	private bool m_ChunkedTransfer; // 0x20
	[SerializeField] // RVA: 0x72950 Offset: 0x72A51 VA: 0x72950
	[FormerlySerializedAsAttribute] // RVA: 0x72950 Offset: 0x72A51 VA: 0x72950
	private int m_RedirectLimit; // 0x24
	[SerializeField] // RVA: 0x729A0 Offset: 0x72AA1 VA: 0x729A0
	[FormerlySerializedAsAttribute] // RVA: 0x729A0 Offset: 0x72AA1 VA: 0x729A0
	private int m_RetryCount; // 0x28
	[SerializeField] // RVA: 0x729F0 Offset: 0x72AF1 VA: 0x729F0
	private string m_BundleName; // 0x30
	[SerializeField] // RVA: 0x72A00 Offset: 0x72B01 VA: 0x72A00
	private long m_BundleSize; // 0x38
	[SerializeField] // RVA: 0x72A10 Offset: 0x72B11 VA: 0x72A10
	private bool m_UseCrcForCachedBundles; // 0x40
	[SerializeField] // RVA: 0x72A20 Offset: 0x72B21 VA: 0x72A20
	private bool m_UseUWRForLocalBundles; // 0x41
	[SerializeField] // RVA: 0x72A30 Offset: 0x72B31 VA: 0x72A30
	private bool m_ClearOtherCachedVersionsWhenLoaded; // 0x42

	// Properties
	public string Hash { get; set; }
	public uint Crc { get; set; }
	public int Timeout { get; set; }
	public bool ChunkedTransfer { get; set; }
	public int RedirectLimit { get; set; }
	public int RetryCount { get; set; }
	public string BundleName { get; set; }
	public long BundleSize { get; set; }
	public bool UseCrcForCachedBundle { get; set; }
	public bool UseUnityWebRequestForLocalBundles { get; set; }
	public bool ClearOtherCachedVersionsWhenLoaded { get; set; }

	// Methods

	// RVA: 0x3623D80 Offset: 0x3623E81 VA: 0x3623D80
	public string get_Hash() { }

	// RVA: 0x3623D90 Offset: 0x3623E91 VA: 0x3623D90
	public void set_Hash(string value) { }

	// RVA: 0x3623DA0 Offset: 0x3623EA1 VA: 0x3623DA0
	public uint get_Crc() { }

	// RVA: 0x3623DB0 Offset: 0x3623EB1 VA: 0x3623DB0
	public void set_Crc(uint value) { }

	// RVA: 0x3623DC0 Offset: 0x3623EC1 VA: 0x3623DC0
	public int get_Timeout() { }

	// RVA: 0x3623DD0 Offset: 0x3623ED1 VA: 0x3623DD0
	public void set_Timeout(int value) { }

	// RVA: 0x3623DE0 Offset: 0x3623EE1 VA: 0x3623DE0
	public bool get_ChunkedTransfer() { }

	// RVA: 0x3623DF0 Offset: 0x3623EF1 VA: 0x3623DF0
	public void set_ChunkedTransfer(bool value) { }

	// RVA: 0x3623E00 Offset: 0x3623F01 VA: 0x3623E00
	public int get_RedirectLimit() { }

	// RVA: 0x3623E10 Offset: 0x3623F11 VA: 0x3623E10
	public void set_RedirectLimit(int value) { }

	// RVA: 0x3623E20 Offset: 0x3623F21 VA: 0x3623E20
	public int get_RetryCount() { }

	// RVA: 0x3623E30 Offset: 0x3623F31 VA: 0x3623E30
	public void set_RetryCount(int value) { }

	// RVA: 0x3623E40 Offset: 0x3623F41 VA: 0x3623E40
	public string get_BundleName() { }

	// RVA: 0x3623E50 Offset: 0x3623F51 VA: 0x3623E50
	public void set_BundleName(string value) { }

	// RVA: 0x3623E60 Offset: 0x3623F61 VA: 0x3623E60
	public long get_BundleSize() { }

	// RVA: 0x3623E70 Offset: 0x3623F71 VA: 0x3623E70
	public void set_BundleSize(long value) { }

	// RVA: 0x3623E80 Offset: 0x3623F81 VA: 0x3623E80
	public bool get_UseCrcForCachedBundle() { }

	// RVA: 0x3623E90 Offset: 0x3623F91 VA: 0x3623E90
	public void set_UseCrcForCachedBundle(bool value) { }

	// RVA: 0x3623EA0 Offset: 0x3623FA1 VA: 0x3623EA0
	public bool get_UseUnityWebRequestForLocalBundles() { }

	// RVA: 0x3623EB0 Offset: 0x3623FB1 VA: 0x3623EB0
	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

	// RVA: 0x3623EC0 Offset: 0x3623FC1 VA: 0x3623EC0
	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	// RVA: 0x3623ED0 Offset: 0x3623FD1 VA: 0x3623ED0
	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	// RVA: 0x3623EE0 Offset: 0x3623FE1 VA: 0x3623EE0 Slot: 5
	public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	// RVA: 0x3624170 Offset: 0x3624271 VA: 0x3624170
	public void .ctor() { }
}

