// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C8F0 Offset: 0x43C9F1 VA: 0x43C8F0
[NativeHeaderAttribute] // RVA: 0x43C8F0 Offset: 0x43C9F1 VA: 0x43C8F0
[NativeHeaderAttribute] // RVA: 0x43C8F0 Offset: 0x43C9F1 VA: 0x43C8F0
[NativeHeaderAttribute] // RVA: 0x43C8F0 Offset: 0x43C9F1 VA: 0x43C8F0
public sealed class MaterialPropertyBlock // TypeDefIndex: 3456
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[ThreadSafeAttribute] // RVA: 0x448030 Offset: 0x448131 VA: 0x448030
	[NativeNameAttribute] // RVA: 0x448030 Offset: 0x448131 VA: 0x448030
	// RVA: 0x347CB90 Offset: 0x347CC91 VA: 0x347CB90
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x448080 Offset: 0x448181 VA: 0x448080
	[ThreadSafeAttribute] // RVA: 0x448080 Offset: 0x448181 VA: 0x448080
	// RVA: 0x347CBF0 Offset: 0x347CCF1 VA: 0x347CBF0
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x4480D0 Offset: 0x4481D1 VA: 0x4480D0
	[ThreadSafeAttribute] // RVA: 0x4480D0 Offset: 0x4481D1 VA: 0x4480D0
	// RVA: 0x347CCC0 Offset: 0x347CDC1 VA: 0x347CCC0
	private void SetColorImpl(int name, Color value) { }

	[ThreadSafeAttribute] // RVA: 0x448120 Offset: 0x448221 VA: 0x448120
	[NativeNameAttribute] // RVA: 0x448120 Offset: 0x448221 VA: 0x448120
	// RVA: 0x347CD90 Offset: 0x347CE91 VA: 0x347CD90
	private void SetTextureImpl(int name, Texture value) { }

	[NativeMethodAttribute] // RVA: 0x448170 Offset: 0x448271 VA: 0x448170
	// RVA: 0x347CDF0 Offset: 0x347CEF1 VA: 0x347CDF0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x4481C0 Offset: 0x4482C1 VA: 0x4481C0
	// RVA: 0x347CE30 Offset: 0x347CF31 VA: 0x347CE30
	private static void DestroyImpl(IntPtr mpb) { }

	[ThreadSafeAttribute] // RVA: 0x448210 Offset: 0x448311 VA: 0x448210
	// RVA: 0x347CE80 Offset: 0x347CF81 VA: 0x347CE80
	private void Clear(bool keepMemory) { }

	// RVA: 0x347CED0 Offset: 0x347CFD1 VA: 0x347CED0
	public void Clear() { }

	// RVA: 0x347CF20 Offset: 0x347D021 VA: 0x347CF20
	public void .ctor() { }

	// RVA: 0x347CF70 Offset: 0x347D071 VA: 0x347CF70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x347CFE0 Offset: 0x347D0E1 VA: 0x347CFE0
	private void Dispose() { }

	// RVA: 0x347D0A0 Offset: 0x347D1A1 VA: 0x347D0A0
	public void SetFloat(string name, float value) { }

	// RVA: 0x347D110 Offset: 0x347D211 VA: 0x347D110
	public void SetInt(int nameID, int value) { }

	// RVA: 0x347D170 Offset: 0x347D271 VA: 0x347D170
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x347D210 Offset: 0x347D311 VA: 0x347D210
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x347D280 Offset: 0x347D381 VA: 0x347D280
	public void SetColor(string name, Color value) { }

	// RVA: 0x347D320 Offset: 0x347D421 VA: 0x347D320
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x347CC60 Offset: 0x347CD61 VA: 0x347CC60
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x347CD30 Offset: 0x347CE31 VA: 0x347CD30
	private void SetColorImpl_Injected(int name, ref Color value) { }
}

