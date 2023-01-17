// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class InstanceProvider : IInstanceProvider // TypeDefIndex: 5590
{
	// Fields
	private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle; // 0x10

	// Methods

	// RVA: 0x362DB30 Offset: 0x362DC31 VA: 0x362DB30 Slot: 4
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: 0x362DC20 Offset: 0x362DD21 VA: 0x362DC20 Slot: 5
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

	// RVA: 0x362DE70 Offset: 0x362DF71 VA: 0x362DE70
	public void .ctor() { }
}

