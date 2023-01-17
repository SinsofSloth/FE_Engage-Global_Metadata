// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class AssetBundleLocalResource : IAssetBundleResource // TypeDefIndex: 15064
{
	// Fields
	internal AssetBundle m_AssetBundle; // 0x10
	internal AsyncOperation m_RequestOperation; // 0x18
	internal Func<float> m_ProgressHandler; // 0x20
	internal Func<bool> m_WaitForCompletionHandler; // 0x28
	internal Action<AsyncOperation> m_CompleteHandler; // 0x30
	internal ProvideHandle m_ProvideHandle; // 0x38
	internal string m_Key; // 0x50
	internal float m_Time; // 0x58
	internal bool m_Completed; // 0x5C

	// Methods

	// RVA: 0x260B420 Offset: 0x260B521 VA: 0x260B420 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x260B510 Offset: 0x260B611 VA: 0x260B510
	internal void .ctor() { }

	// RVA: 0x260B6A0 Offset: 0x260B7A1 VA: 0x260B6A0
	private float PercentComplete() { }

	// RVA: 0x260B6C0 Offset: 0x260B7C1 VA: 0x260B6C0
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x260B7F0 Offset: 0x260B8F1 VA: 0x260B7F0
	private bool WaitForCompletionHandler() { }

	// RVA: 0x260B840 Offset: 0x260B941 VA: 0x260B840
	internal void Load(string key, ProvideHandle provideHandle) { }

	// RVA: 0x260B910 Offset: 0x260BA11 VA: 0x260B910
	internal void Unload() { }
}

