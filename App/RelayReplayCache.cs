// Namespace: App
internal class RelayReplayCache // TypeDefIndex: 12938
{
	// Fields
	private bool m_IsValid; // 0x10
	private bool m_IsNoNeed; // 0x11
	private List<RelayServerMetaData> m_Data; // 0x18

	// Properties
	public bool IsValid { get; }
	public bool IsNoNeed { get; set; }

	// Methods

	// RVA: 0x24BBA50 Offset: 0x24BBB51 VA: 0x24BBA50
	public void .ctor() { }

	// RVA: 0x24BBB80 Offset: 0x24BBC81 VA: 0x24BBB80
	public void Create(List<RelayServerMetaData> searchResults) { }

	// RVA: 0x24BBD30 Offset: 0x24BBE31 VA: 0x24BBD30
	public void CopyTo(List<RelayServerMetaData> searchResults) { }

	// RVA: 0x24BBC10 Offset: 0x24BBD11 VA: 0x24BBC10
	private void Duplicate(List<RelayServerMetaData> src, List<RelayServerMetaData> dst) { }

	// RVA: 0x24BBFA0 Offset: 0x24BC0A1 VA: 0x24BBFA0
	public void Replace(RelayServerMetaData newMetaData) { }

	// RVA: 0x24BBB20 Offset: 0x24BBC21 VA: 0x24BBB20
	public void Clear() { }

	// RVA: 0x24BC0D0 Offset: 0x24BC1D1 VA: 0x24BC0D0
	public bool get_IsValid() { }

	// RVA: 0x24BC0E0 Offset: 0x24BC1E1 VA: 0x24BC0E0
	public bool get_IsNoNeed() { }

	// RVA: 0x24BC0F0 Offset: 0x24BC1F1 VA: 0x24BC0F0
	public void set_IsNoNeed(bool value) { }
}

