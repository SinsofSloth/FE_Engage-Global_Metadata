// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x274800 Offset: 0x274901 VA: 0x274800
public sealed class AdhocAssetLoader : SingletonMonoBehaviour<AdhocAssetLoader> // TypeDefIndex: 8794
{
	// Fields
	private List<AdhocAssetLoader.Asset> assets; // 0x20

	// Properties
	public GameObject Item { get; }

	// Methods

	// RVA: 0x2ECA040 Offset: 0x2ECA141 VA: 0x2ECA040
	private void OnDestroy() { }

	// RVA: 0x2ECA150 Offset: 0x2ECA251 VA: 0x2ECA150
	public GameObject get_Item(string path) { }

	// RVA: 0x2ECA230 Offset: 0x2ECA331 VA: 0x2ECA230
	public void Add(string name) { }

	// RVA: 0x2ECA450 Offset: 0x2ECA551 VA: 0x2ECA450
	public void Preload() { }

	// RVA: 0x2ECA560 Offset: 0x2ECA661 VA: 0x2ECA560
	public bool IsReady() { }

	// RVA: 0x2ECA620 Offset: 0x2ECA721 VA: 0x2ECA620
	public void .ctor() { }
}

