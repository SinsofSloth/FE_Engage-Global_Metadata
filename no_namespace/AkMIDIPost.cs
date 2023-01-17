// Namespace: 
public class AkMIDIPost : AkMIDIEvent // TypeDefIndex: 7871
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint uOffset { get; set; }

	// Methods

	// RVA: 0x317D660 Offset: 0x317D761 VA: 0x317D660
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317D700 Offset: 0x317D801 VA: 0x317D700
	internal static IntPtr getCPtr(AkMIDIPost obj) { }

	// RVA: 0x317D760 Offset: 0x317D861 VA: 0x317D760 Slot: 5
	internal override void setCPtr(IntPtr cPtr) { }

	// RVA: 0x317D7F0 Offset: 0x317D8F1 VA: 0x317D7F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317D8E0 Offset: 0x317D9E1 VA: 0x317D8E0 Slot: 6
	public override void Dispose() { }

	// RVA: 0x317DA70 Offset: 0x317DB71 VA: 0x317DA70
	public void set_uOffset(uint value) { }

	// RVA: 0x317DAF0 Offset: 0x317DBF1 VA: 0x317DAF0
	public uint get_uOffset() { }

	// RVA: 0x317DB60 Offset: 0x317DC61 VA: 0x317DB60
	public AKRESULT PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts) { }

	// RVA: 0x317DC40 Offset: 0x317DD41 VA: 0x317DC40
	public void Clone(AkMIDIPost other) { }

	// RVA: 0x317DD00 Offset: 0x317DE01 VA: 0x317DD00
	public static int GetSizeOf() { }

	// RVA: 0x317DD70 Offset: 0x317DE71 VA: 0x317DD70
	public void .ctor() { }
}

