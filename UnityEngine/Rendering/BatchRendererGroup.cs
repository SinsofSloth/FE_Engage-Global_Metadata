// Namespace: UnityEngine.Rendering
[NativeHeaderAttribute] // RVA: 0x440C20 Offset: 0x440D21 VA: 0x440C20
[NativeHeaderAttribute] // RVA: 0x440C20 Offset: 0x440D21 VA: 0x440C20
[RequiredByNativeCodeAttribute] // RVA: 0x440C20 Offset: 0x440D21 VA: 0x440C20
public class BatchRendererGroup // TypeDefIndex: 3927
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x454040 Offset: 0x454141 VA: 0x454040
	// RVA: 0x2F0B820 Offset: 0x2F0B921 VA: 0x2F0B820
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }
}

