// Namespace: UnityEngine.VFX
[NativeTypeAttribute] // RVA: 0x6A1F0 Offset: 0x6A2F1 VA: 0x6A1F0
[RequiredByNativeCodeAttribute] // RVA: 0x6A1F0 Offset: 0x6A2F1 VA: 0x6A1F0
public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 7573
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20

	// Methods

	// RVA: 0x1C6B7A0 Offset: 0x1C6B8A1 VA: 0x1C6B7A0
	private void .ctor(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	// RVA: 0x1C6B7F0 Offset: 0x1C6B8F1 VA: 0x1C6B7F0
	internal static IntPtr Internal_Create() { }

	// RVA: 0x1C6B830 Offset: 0x1C6B931 VA: 0x1C6B830
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	// RVA: 0x1C6B910 Offset: 0x1C6BA11 VA: 0x1C6B910
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	// RVA: 0x1C6B960 Offset: 0x1C6BA61 VA: 0x1C6B960
	private void Release() { }

	// RVA: 0x1C6BA50 Offset: 0x1C6BB51 VA: 0x1C6BA50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C6BB40 Offset: 0x1C6BC41 VA: 0x1C6BB40 Slot: 4
	public void Dispose() { }

	[NativeMethodAttribute] // RVA: 0x6A5E0 Offset: 0x6A6E1 VA: 0x6A5E0
	// RVA: 0x1C6BA00 Offset: 0x1C6BB01 VA: 0x1C6BA00
	internal static void Internal_Destroy(IntPtr ptr) { }
}

