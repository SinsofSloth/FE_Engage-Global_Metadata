// Namespace: UnityEngine.ResourceManagement.Util
public interface IInitializableObject // TypeDefIndex: 5562
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(string id, string data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data);
}

