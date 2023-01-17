// Namespace: 
public class AkCallbackSerializer : IDisposable // TypeDefIndex: 7835
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Methods

	// RVA: 0x31677D0 Offset: 0x31678D1 VA: 0x31677D0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3167810 Offset: 0x3167911 VA: 0x3167810
	internal static IntPtr getCPtr(AkCallbackSerializer obj) { }

	// RVA: 0x3167870 Offset: 0x3167971 VA: 0x3167870 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x31678A0 Offset: 0x31679A1 VA: 0x31678A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3167910 Offset: 0x3167A11 VA: 0x3167910 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3167AA0 Offset: 0x3167BA1 VA: 0x3167AA0
	public static AKRESULT Init(IntPtr in_pMemory, uint in_uSize) { }

	// RVA: 0x3167B20 Offset: 0x3167C21 VA: 0x3167B20
	public static void Term() { }

	// RVA: 0x3167B90 Offset: 0x3167C91 VA: 0x3167B90
	public static IntPtr Lock() { }

	// RVA: 0x3167C00 Offset: 0x3167D01 VA: 0x3167C00
	public static void Unlock() { }

	// RVA: 0x3167C70 Offset: 0x3167D71 VA: 0x3167C70
	public static void SetLocalOutput(uint in_uErrorLevel) { }

	// RVA: 0x3167CE0 Offset: 0x3167DE1 VA: 0x3167CE0
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie) { }

	// RVA: 0x3167D80 Offset: 0x3167E81 VA: 0x3167D80
	public void .ctor() { }
}

