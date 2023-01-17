// Namespace: 
public class AkAudioSettings : IDisposable // TypeDefIndex: 7828
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumSamplesPerFrame { get; set; }
	public uint uNumSamplesPerSecond { get; set; }

	// Methods

	// RVA: 0x2ED0250 Offset: 0x2ED0351 VA: 0x2ED0250
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ED0290 Offset: 0x2ED0391 VA: 0x2ED0290
	internal static IntPtr getCPtr(AkAudioSettings obj) { }

	// RVA: 0x2ED02F0 Offset: 0x2ED03F1 VA: 0x2ED02F0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ED0320 Offset: 0x2ED0421 VA: 0x2ED0320 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED0390 Offset: 0x2ED0491 VA: 0x2ED0390 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ED0520 Offset: 0x2ED0621 VA: 0x2ED0520
	public void set_uNumSamplesPerFrame(uint value) { }

	// RVA: 0x2ED05A0 Offset: 0x2ED06A1 VA: 0x2ED05A0
	public uint get_uNumSamplesPerFrame() { }

	// RVA: 0x2ED0610 Offset: 0x2ED0711 VA: 0x2ED0610
	public void set_uNumSamplesPerSecond(uint value) { }

	// RVA: 0x2ED0690 Offset: 0x2ED0791 VA: 0x2ED0690
	public uint get_uNumSamplesPerSecond() { }

	// RVA: 0x2ED0700 Offset: 0x2ED0801 VA: 0x2ED0700
	public void .ctor() { }
}

