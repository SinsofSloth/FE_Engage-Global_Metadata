// Namespace: 
internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 490
{
	// Methods

	// RVA: 0x1C010A0 Offset: 0x1C011A1 VA: 0x1C010A0
	public void .ctor() { }
}

// Namespace: 
public enum ResourceManager.DiagnosticEventType // TypeDefIndex: 5540
{
	// Fields
	public int value__; // 0x0
	public const ResourceManager.DiagnosticEventType AsyncOperationFail = 0;
	public const ResourceManager.DiagnosticEventType AsyncOperationCreate = 1;
	public const ResourceManager.DiagnosticEventType AsyncOperationPercentComplete = 2;
	public const ResourceManager.DiagnosticEventType AsyncOperationComplete = 3;
	public const ResourceManager.DiagnosticEventType AsyncOperationReferenceCount = 4;
	public const ResourceManager.DiagnosticEventType AsyncOperationDestroy = 5;
}

// Namespace: 
private class ResourceManager.CompletedOperation<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 5542
{
	// Fields
	private bool m_Success; // 0x0
	private Exception m_Exception; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25005B0 Offset: 0x25006B1 VA: 0x25005B0
	|-ResourceManager.CompletedOperation<bool>..ctor
	|
	|-RVA: 0x2500820 Offset: 0x2500921 VA: 0x2500820
	|-ResourceManager.CompletedOperation<long>..ctor
	|
	|-RVA: 0x2500A90 Offset: 0x2500B91 VA: 0x2500A90
	|-ResourceManager.CompletedOperation<object>..ctor
	|
	|-RVA: 0x2500D00 Offset: 0x2500E01 VA: 0x2500D00
	|-ResourceManager.CompletedOperation<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25005D0 Offset: 0x25006D1 VA: 0x25005D0
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0x2500840 Offset: 0x2500941 VA: 0x2500840
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0x2500AB0 Offset: 0x2500BB1 VA: 0x2500AB0
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0x2500D20 Offset: 0x2500E21 VA: 0x2500D20
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2500690 Offset: 0x2500791 VA: 0x2500690
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0x2500900 Offset: 0x2500A01 VA: 0x2500900
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0x2500B70 Offset: 0x2500C71 VA: 0x2500B70
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0x2500DF0 Offset: 0x2500EF1 VA: 0x2500DF0
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2500700 Offset: 0x2500801 VA: 0x2500700
	|-ResourceManager.CompletedOperation<bool>.get_DebugName
	|
	|-RVA: 0x2500970 Offset: 0x2500A71 VA: 0x2500970
	|-ResourceManager.CompletedOperation<long>.get_DebugName
	|
	|-RVA: 0x2500BE0 Offset: 0x2500CE1 VA: 0x2500BE0
	|-ResourceManager.CompletedOperation<object>.get_DebugName
	|
	|-RVA: 0x2500E60 Offset: 0x2500F61 VA: 0x2500E60
	|-ResourceManager.CompletedOperation<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2500750 Offset: 0x2500851 VA: 0x2500750
	|-ResourceManager.CompletedOperation<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x25009C0 Offset: 0x2500AC1 VA: 0x25009C0
	|-ResourceManager.CompletedOperation<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x2500C30 Offset: 0x2500D31 VA: 0x2500C30
	|-ResourceManager.CompletedOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x2500EB0 Offset: 0x2500FB1 VA: 0x2500EB0
	|-ResourceManager.CompletedOperation<SceneInstance>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25007C0 Offset: 0x25008C1 VA: 0x25007C0
	|-ResourceManager.CompletedOperation<bool>.Execute
	|
	|-RVA: 0x2500A30 Offset: 0x2500B31 VA: 0x2500A30
	|-ResourceManager.CompletedOperation<long>.Execute
	|
	|-RVA: 0x2500CA0 Offset: 0x2500DA1 VA: 0x2500CA0
	|-ResourceManager.CompletedOperation<object>.Execute
	|
	|-RVA: 0x2500F20 Offset: 0x2501021 VA: 0x2500F20
	|-ResourceManager.CompletedOperation<SceneInstance>.Execute
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x72320 Offset: 0x72421 VA: 0x72320
private sealed class ResourceManager.<>c__DisplayClass89_0<TObject> // TypeDefIndex: 5544
{
	// Fields
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0
	public ResourceManager <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41540 Offset: 0x2B41641 VA: 0x2B41540
	|-ResourceManager.<>c__DisplayClass89_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ProvideResources>b__0(AsyncOperationHandle x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41550 Offset: 0x2B41651 VA: 0x2B41550
	|-ResourceManager.<>c__DisplayClass89_0<object>.<ProvideResources>b__0
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <ProvideResources>b__1(AsyncOperationHandle resultHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B415F0 Offset: 0x2B416F1 VA: 0x2B415F0
	|-ResourceManager.<>c__DisplayClass89_0<object>.<ProvideResources>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279330 Offset: 0x279431 VA: 0x279330
[Serializable]
private sealed class ResourceManager.<>c // TypeDefIndex: 13918
{
	// Fields
	public static readonly ResourceManager.<>c <>9; // 0x0
	public static Action<AsyncOperationHandle<IResourceLocator>> <>9__26_0; // 0x8

	// Methods

	// RVA: 0x1F47080 Offset: 0x1F47181 VA: 0x1F47080
	private static void .cctor() { }

	// RVA: 0x1F470F0 Offset: 0x1F471F1 VA: 0x1F470F0
	public void .ctor() { }

	// RVA: 0x1F47100 Offset: 0x1F47201 VA: 0x1F47100
	internal void <Initialize>b__26_0(AsyncOperationHandle<IResourceLocator> op) { }
}

