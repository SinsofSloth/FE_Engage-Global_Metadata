// Namespace: 
public class AkRoomParams : IDisposable // TypeDefIndex: 7895
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 Up { get; set; }
	public Vector3 Front { get; set; }
	public uint ReverbAuxBus { get; set; }
	public float ReverbLevel { get; set; }
	public float WallOcclusion { get; set; }
	public float RoomGameObj_AuxSendLevelToSelf { get; set; }
	public bool RoomGameObj_KeepRegistered { get; set; }

	// Methods

	// RVA: 0x318D1D0 Offset: 0x318D2D1 VA: 0x318D1D0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x318D210 Offset: 0x318D311 VA: 0x318D210
	internal static IntPtr getCPtr(AkRoomParams obj) { }

	// RVA: 0x318D270 Offset: 0x318D371 VA: 0x318D270 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x318D2A0 Offset: 0x318D3A1 VA: 0x318D2A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x318D310 Offset: 0x318D411 VA: 0x318D310 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x318A890 Offset: 0x318A991 VA: 0x318A890
	public void .ctor() { }

	// RVA: 0x318D4A0 Offset: 0x318D5A1 VA: 0x318D4A0
	public void .ctor(AkRoomParams in_rhs) { }

	// RVA: 0x318A920 Offset: 0x318AA21 VA: 0x318A920
	public void set_Up(Vector3 value) { }

	// RVA: 0x318D580 Offset: 0x318D681 VA: 0x318D580
	public Vector3 get_Up() { }

	// RVA: 0x318A9C0 Offset: 0x318AAC1 VA: 0x318A9C0
	public void set_Front(Vector3 value) { }

	// RVA: 0x318D5F0 Offset: 0x318D6F1 VA: 0x318D5F0
	public Vector3 get_Front() { }

	// RVA: 0x318AA60 Offset: 0x318AB61 VA: 0x318AA60
	public void set_ReverbAuxBus(uint value) { }

	// RVA: 0x318D660 Offset: 0x318D761 VA: 0x318D660
	public uint get_ReverbAuxBus() { }

	// RVA: 0x318AAE0 Offset: 0x318ABE1 VA: 0x318AAE0
	public void set_ReverbLevel(float value) { }

	// RVA: 0x318D6D0 Offset: 0x318D7D1 VA: 0x318D6D0
	public float get_ReverbLevel() { }

	// RVA: 0x318AB60 Offset: 0x318AC61 VA: 0x318AB60
	public void set_WallOcclusion(float value) { }

	// RVA: 0x318D740 Offset: 0x318D841 VA: 0x318D740
	public float get_WallOcclusion() { }

	// RVA: 0x318ABE0 Offset: 0x318ACE1 VA: 0x318ABE0
	public void set_RoomGameObj_AuxSendLevelToSelf(float value) { }

	// RVA: 0x318D7B0 Offset: 0x318D8B1 VA: 0x318D7B0
	public float get_RoomGameObj_AuxSendLevelToSelf() { }

	// RVA: 0x318AC60 Offset: 0x318AD61 VA: 0x318AC60
	public void set_RoomGameObj_KeepRegistered(bool value) { }

	// RVA: 0x318D820 Offset: 0x318D921 VA: 0x318D820
	public bool get_RoomGameObj_KeepRegistered() { }
}

