// Namespace: UnityEngine.AddressableAssets.Utility
internal class ResourceManagerDiagnostics : IDisposable // TypeDefIndex: 7301
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo; // 0x18

	// Methods

	// RVA: 0x309A5A0 Offset: 0x309A6A1 VA: 0x309A5A0
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x309F500 Offset: 0x309F601 VA: 0x309F500
	internal int SumDependencyNameHashCodes(AsyncOperationHandle handle) { }

	// RVA: 0x309F6F0 Offset: 0x309F7F1 VA: 0x309F6F0
	internal int CalculateHashCode(AsyncOperationHandle handle) { }

	// RVA: 0x309F7E0 Offset: 0x309F8E1 VA: 0x309F7E0
	private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext) { }

	// RVA: 0x309B7A0 Offset: 0x309B8A1 VA: 0x309B7A0 Slot: 4
	public void Dispose() { }
}

