// Namespace: 
public class AkChannelEmitter : IDisposable // TypeDefIndex: 7839
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkTransform position { get; set; }
	public uint uInputChannels { get; set; }

	// Methods

	// RVA: 0x3168A90 Offset: 0x3168B91 VA: 0x3168A90
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3168AD0 Offset: 0x3168BD1 VA: 0x3168AD0
	internal static IntPtr getCPtr(AkChannelEmitter obj) { }

	// RVA: 0x3168B30 Offset: 0x3168C31 VA: 0x3168B30 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3168B60 Offset: 0x3168C61 VA: 0x3168B60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3168BD0 Offset: 0x3168CD1 VA: 0x3168BD0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3168D60 Offset: 0x3168E61 VA: 0x3168D60
	public void set_position(AkTransform value) { }

	// RVA: 0x3168DF0 Offset: 0x3168EF1 VA: 0x3168DF0
	public AkTransform get_position() { }

	// RVA: 0x3168ED0 Offset: 0x3168FD1 VA: 0x3168ED0
	public void set_uInputChannels(uint value) { }

	// RVA: 0x3168F50 Offset: 0x3169051 VA: 0x3168F50
	public uint get_uInputChannels() { }
}

