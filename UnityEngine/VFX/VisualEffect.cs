// Namespace: UnityEngine.VFX
[RequireComponent] // RVA: 0x6A4B0 Offset: 0x6A5B1 VA: 0x6A4B0
[NativeHeaderAttribute] // RVA: 0x6A4B0 Offset: 0x6A5B1 VA: 0x6A4B0
[NativeHeaderAttribute] // RVA: 0x6A4B0 Offset: 0x6A5B1 VA: 0x6A4B0
public class VisualEffect : Behaviour // TypeDefIndex: 7581
{
	// Fields
	private VFXEventAttribute m_cachedEventAttribute; // 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; // 0x20

	// Properties
	public VisualEffectAsset visualEffectAsset { get; }

	// Methods

	// RVA: 0x1C6C0B0 Offset: 0x1C6C1B1 VA: 0x1C6C0B0
	public VisualEffectAsset get_visualEffectAsset() { }

	// RVA: 0x1C6C100 Offset: 0x1C6C201 VA: 0x1C6C100
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6A690 Offset: 0x6A791 VA: 0x6A690
	// RVA: 0x1C6C1E0 Offset: 0x1C6C2E1 VA: 0x1C6C1E0
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6A6A0 Offset: 0x6A7A1 VA: 0x6A6A0
	// RVA: 0x1C6C250 Offset: 0x1C6C351 VA: 0x1C6C250
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }
}

