// Namespace: UnityEngine.ResourceManagement.Util
public interface IAllocationStrategy // TypeDefIndex: 5564
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object New(Type type, int typeHash);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(int typeHash, object obj);
}

