// Namespace: App
public class HubResource : SingletonClass<HubResource> // TypeDefIndex: 10779
{
	// Fields
	private Dictionary<string, ResourceHandle> resources; // 0x20

	// Methods

	// RVA: -1 Offset: -1
	public T Get<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B8410 Offset: 0x22B8511 VA: 0x22B8410
	|-HubResource.Get<object>
	*/

	// RVA: 0x28BEC50 Offset: 0x28BED51 VA: 0x28BEC50
	public GameObject Get(string name) { }

	// RVA: 0x28C2C00 Offset: 0x28C2D01 VA: 0x28C2C00
	public bool IsLoading() { }

	// RVA: 0x28C2D70 Offset: 0x28C2E71 VA: 0x28C2D70 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x28C2F70 Offset: 0x28C3071 VA: 0x28C2F70 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x28C2E60 Offset: 0x28C2F61 VA: 0x28C2E60
	private void Add(string path) { }

	// RVA: 0x28C30B0 Offset: 0x28C31B1 VA: 0x28C30B0
	public void .ctor() { }
}

