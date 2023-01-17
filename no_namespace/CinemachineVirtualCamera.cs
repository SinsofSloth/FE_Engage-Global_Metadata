// Namespace: 
public sealed class CinemachineVirtualCamera.CreatePipelineDelegate : MulticastDelegate // TypeDefIndex: 5778
{
	// Methods

	// RVA: 0x1A8B630 Offset: 0x1A8B731 VA: 0x1A8B630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A7DBC0 Offset: 0x1A7DCC1 VA: 0x1A7DBC0 Slot: 13
	public virtual Transform Invoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom) { }

	// RVA: 0x1A8B650 Offset: 0x1A8B751 VA: 0x1A8B650 Slot: 14
	public virtual IAsyncResult BeginInvoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom, AsyncCallback callback, object object) { }

	// RVA: 0x1A8B680 Offset: 0x1A8B781 VA: 0x1A8B680 Slot: 15
	public virtual Transform EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class CinemachineVirtualCamera.DestroyPipelineDelegate : MulticastDelegate // TypeDefIndex: 5779
{
	// Methods

	// RVA: 0x1A8B690 Offset: 0x1A8B791 VA: 0x1A8B690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A7D6A0 Offset: 0x1A7D7A1 VA: 0x1A7D6A0 Slot: 13
	public virtual void Invoke(GameObject pipeline) { }

	// RVA: 0x1A8B6B0 Offset: 0x1A8B7B1 VA: 0x1A8B6B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject pipeline, AsyncCallback callback, object object) { }

	// RVA: 0x1A8B6E0 Offset: 0x1A8B7E1 VA: 0x1A8B6E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x1B260 Offset: 0x1B361 VA: 0x1B260
[Serializable]
private sealed class CinemachineVirtualCamera.<>c // TypeDefIndex: 5780
{
	// Fields
	public static readonly CinemachineVirtualCamera.<>c <>9; // 0x0
	public static Comparison<CinemachineComponentBase> <>9__41_0; // 0x8

	// Methods

	// RVA: 0x1A8B560 Offset: 0x1A8B661 VA: 0x1A8B560
	private static void .cctor() { }

	// RVA: 0x1A8B5D0 Offset: 0x1A8B6D1 VA: 0x1A8B5D0
	public void .ctor() { }

	// RVA: 0x1A8B5E0 Offset: 0x1A8B6E1 VA: 0x1A8B5E0
	internal int <UpdateComponentPipeline>b__41_0(CinemachineComponentBase c1, CinemachineComponentBase c2) { }
}

