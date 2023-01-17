// Namespace: 
public class AkImageSourceSettings : IDisposable // TypeDefIndex: 7856
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkImageSourceParams params_ { get; set; }

	// Methods

	// RVA: 0x3177F90 Offset: 0x3178091 VA: 0x3177F90
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3177FD0 Offset: 0x31780D1 VA: 0x3177FD0
	internal static IntPtr getCPtr(AkImageSourceSettings obj) { }

	// RVA: 0x3178030 Offset: 0x3178131 VA: 0x3178030 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3178060 Offset: 0x3178161 VA: 0x3178060 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31780D0 Offset: 0x31781D1 VA: 0x31780D0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3178260 Offset: 0x3178361 VA: 0x3178260
	public void .ctor() { }

	// RVA: 0x31782F0 Offset: 0x31783F1 VA: 0x31782F0
	public void .ctor(Vector3 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) { }

	// RVA: 0x31783C0 Offset: 0x31784C1 VA: 0x31783C0
	public void SetOneTexture(uint in_texture) { }

	// RVA: 0x3178440 Offset: 0x3178541 VA: 0x3178440
	public void SetName(string in_pName) { }

	// RVA: 0x31784C0 Offset: 0x31785C1 VA: 0x31784C0
	public void set_params_(AkImageSourceParams value) { }

	// RVA: 0x3178580 Offset: 0x3178681 VA: 0x3178580
	public AkImageSourceParams get_params_() { }
}

