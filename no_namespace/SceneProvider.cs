// Namespace: 
private class SceneProvider.UnloadSceneOp : AsyncOperationBase<SceneInstance> // TypeDefIndex: 5599
{
	// Fields
	private SceneInstance m_Instance; // 0x90
	private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; // 0xA0

	// Properties
	protected override float Progress { get; }

	// Methods

	// RVA: 0x36369C0 Offset: 0x3636AC1 VA: 0x36369C0
	public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x363B100 Offset: 0x363B201 VA: 0x363B100 Slot: 28
	protected override void Execute() { }

	// RVA: 0x363B410 Offset: 0x363B511 VA: 0x363B410 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x363B330 Offset: 0x363B431 VA: 0x363B330
	private void UnloadSceneCompleted(AsyncOperation obj) { }

	// RVA: 0x363B2B0 Offset: 0x363B3B1 VA: 0x363B2B0
	private void UnloadSceneCompletedNoRelease(AsyncOperation obj) { }

	// RVA: 0x363B4A0 Offset: 0x363B5A1 VA: 0x363B4A0 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x3636960 Offset: 0x3636A61 VA: 0x3636960
	public void .ctor() { }
}

