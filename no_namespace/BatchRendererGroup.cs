// Namespace: 
public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3926
{
	// Methods

	// RVA: 0x38529D0 Offset: 0x3852AD1 VA: 0x38529D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x38529F0 Offset: 0x3852AF1 VA: 0x38529F0 Slot: 13
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x3852F00 Offset: 0x3853001 VA: 0x3852F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x3852FA0 Offset: 0x38530A1 VA: 0x3852FA0 Slot: 15
	public virtual JobHandle EndInvoke(IAsyncResult result) { }
}

