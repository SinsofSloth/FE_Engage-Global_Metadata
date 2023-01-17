// Namespace: 
private class AdhocAssetLoader.Asset : IDisposable // TypeDefIndex: 8793
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2847B0 Offset: 0x2848B1 VA: 0x2847B0
	private int <NameHash>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2847C0 Offset: 0x2848C1 VA: 0x2847C0
	private string <AddressablePath>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2847D0 Offset: 0x2848D1 VA: 0x2847D0
	private GameObject <Prefab>k__BackingField; // 0x20
	private TResourceHandle<GameObject> m_FileHandle; // 0x28

	// Properties
	public int NameHash { get; set; }
	public string AddressablePath { get; set; }
	public GameObject Prefab { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACCC0 Offset: 0x2ACDC1 VA: 0x2ACCC0
	// RVA: 0x24AF7A0 Offset: 0x24AF8A1 VA: 0x24AF7A0
	public int get_NameHash() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACCD0 Offset: 0x2ACDD1 VA: 0x2ACCD0
	// RVA: 0x24AF7B0 Offset: 0x24AF8B1 VA: 0x24AF7B0
	private void set_NameHash(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACCE0 Offset: 0x2ACDE1 VA: 0x2ACCE0
	// RVA: 0x24AF7C0 Offset: 0x24AF8C1 VA: 0x24AF7C0
	public string get_AddressablePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACCF0 Offset: 0x2ACDF1 VA: 0x2ACCF0
	// RVA: 0x24AF7D0 Offset: 0x24AF8D1 VA: 0x24AF7D0
	private void set_AddressablePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACD00 Offset: 0x2ACE01 VA: 0x2ACD00
	// RVA: 0x24AF7E0 Offset: 0x24AF8E1 VA: 0x24AF7E0
	public GameObject get_Prefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACD10 Offset: 0x2ACE11 VA: 0x2ACD10
	// RVA: 0x24AF7F0 Offset: 0x24AF8F1 VA: 0x24AF7F0
	private void set_Prefab(GameObject value) { }

	// RVA: 0x24AF800 Offset: 0x24AF901 VA: 0x24AF800
	public bool Is(int hash) { }

	// RVA: 0x24AF810 Offset: 0x24AF911 VA: 0x24AF810
	public void .ctor(string name, int hash) { }

	// RVA: 0x24AF8D0 Offset: 0x24AF9D1 VA: 0x24AF8D0
	public void Load() { }

	// RVA: 0x24AF930 Offset: 0x24AFA31 VA: 0x24AF930
	public bool IsReady() { }

	// RVA: 0x24AFA00 Offset: 0x24AFB01 VA: 0x24AFA00 Slot: 4
	public void Dispose() { }
}

