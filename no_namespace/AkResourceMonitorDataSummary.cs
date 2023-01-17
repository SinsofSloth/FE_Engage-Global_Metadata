// Namespace: 
public class AkResourceMonitorDataSummary : IDisposable // TypeDefIndex: 7894
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float totalCPU { get; set; }
	public float pluginCPU { get; set; }
	public uint physicalVoices { get; set; }
	public uint virtualVoices { get; set; }
	public uint totalVoices { get; set; }
	public uint nbActiveEvents { get; set; }

	// Methods

	// RVA: 0x3189540 Offset: 0x3189641 VA: 0x3189540
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3189580 Offset: 0x3189681 VA: 0x3189580
	internal static IntPtr getCPtr(AkResourceMonitorDataSummary obj) { }

	// RVA: 0x31895E0 Offset: 0x31896E1 VA: 0x31895E0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3189610 Offset: 0x3189711 VA: 0x3189610 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3189680 Offset: 0x3189781 VA: 0x3189680 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3189810 Offset: 0x3189911 VA: 0x3189810
	public void set_totalCPU(float value) { }

	// RVA: 0x3189890 Offset: 0x3189991 VA: 0x3189890
	public float get_totalCPU() { }

	// RVA: 0x3189900 Offset: 0x3189A01 VA: 0x3189900
	public void set_pluginCPU(float value) { }

	// RVA: 0x3189980 Offset: 0x3189A81 VA: 0x3189980
	public float get_pluginCPU() { }

	// RVA: 0x31899F0 Offset: 0x3189AF1 VA: 0x31899F0
	public void set_physicalVoices(uint value) { }

	// RVA: 0x3189A70 Offset: 0x3189B71 VA: 0x3189A70
	public uint get_physicalVoices() { }

	// RVA: 0x3189AE0 Offset: 0x3189BE1 VA: 0x3189AE0
	public void set_virtualVoices(uint value) { }

	// RVA: 0x3189B60 Offset: 0x3189C61 VA: 0x3189B60
	public uint get_virtualVoices() { }

	// RVA: 0x3189BD0 Offset: 0x3189CD1 VA: 0x3189BD0
	public void set_totalVoices(uint value) { }

	// RVA: 0x3189C50 Offset: 0x3189D51 VA: 0x3189C50
	public uint get_totalVoices() { }

	// RVA: 0x3189CC0 Offset: 0x3189DC1 VA: 0x3189CC0
	public void set_nbActiveEvents(uint value) { }

	// RVA: 0x3189D40 Offset: 0x3189E41 VA: 0x3189D40
	public uint get_nbActiveEvents() { }

	// RVA: 0x3189DB0 Offset: 0x3189EB1 VA: 0x3189DB0
	public void .ctor() { }
}

