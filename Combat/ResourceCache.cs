// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274B10 Offset: 0x274C11 VA: 0x274B10
internal sealed class ResourceCache : SingletonMonoBehaviour<ResourceCache> // TypeDefIndex: 8844
{
	// Fields
	private Dictionary<string, ResourceHandle> dic; // 0x20

	// Methods

	// RVA: 0x24CCFD0 Offset: 0x24CD0D1 VA: 0x24CCFD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x24CD080 Offset: 0x24CD181 VA: 0x24CD080
	private void OnDestroy() { }

	// RVA: 0x24CD210 Offset: 0x24CD311 VA: 0x24CD210
	private ResourceHandle Create(string assetPath) { }

	// RVA: 0x24CD3A0 Offset: 0x24CD4A1 VA: 0x24CD3A0
	public static void LoadAsync(string assetPath, Action<Object> doneCallback) { }

	// RVA: 0x24CD570 Offset: 0x24CD671 VA: 0x24CD570
	public void .ctor() { }
}

