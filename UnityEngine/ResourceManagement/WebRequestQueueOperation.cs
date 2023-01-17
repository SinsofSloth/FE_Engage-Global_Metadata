// Namespace: UnityEngine.ResourceManagement
internal class WebRequestQueueOperation // TypeDefIndex: 5547
{
	// Fields
	public UnityWebRequestAsyncOperation Result; // 0x10
	public Action<UnityWebRequestAsyncOperation> OnComplete; // 0x18
	internal UnityWebRequest m_WebRequest; // 0x20

	// Properties
	public bool IsDone { get; }

	// Methods

	// RVA: 0x3625F60 Offset: 0x3626061 VA: 0x3625F60
	public bool get_IsDone() { }

	// RVA: 0x3637DB0 Offset: 0x3637EB1 VA: 0x3637DB0
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x3638040 Offset: 0x3638141 VA: 0x3638040
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }
}

