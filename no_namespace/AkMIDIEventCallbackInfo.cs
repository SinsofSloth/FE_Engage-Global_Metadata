// Namespace: 
public class AkMIDIEventCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 7869
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public byte byChan { get; }
	public byte byParam1 { get; }
	public byte byParam2 { get; }
	public AkMIDIEventTypes byType { get; }
	public byte byOnOffNote { get; }
	public byte byVelocity { get; }
	public AkMIDICcTypes byCc { get; }
	public byte byCcValue { get; }
	public byte byValueLsb { get; }
	public byte byValueMsb { get; }
	public byte byAftertouchNote { get; }
	public byte byNoteAftertouchValue { get; }
	public byte byChanAftertouchValue { get; }
	public byte byProgramNum { get; }

	// Methods

	// RVA: 0x317CB20 Offset: 0x317CC21 VA: 0x317CB20
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317CC00 Offset: 0x317CD01 VA: 0x317CC00
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj) { }

	// RVA: 0x317CC60 Offset: 0x317CD61 VA: 0x317CC60 Slot: 5
	internal override void setCPtr(IntPtr cPtr) { }

	// RVA: 0x317CD40 Offset: 0x317CE41 VA: 0x317CD40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317CE30 Offset: 0x317CF31 VA: 0x317CE30 Slot: 6
	public override void Dispose() { }

	// RVA: 0x317CFC0 Offset: 0x317D0C1 VA: 0x317CFC0
	public byte get_byChan() { }

	// RVA: 0x317D030 Offset: 0x317D131 VA: 0x317D030
	public byte get_byParam1() { }

	// RVA: 0x317D0A0 Offset: 0x317D1A1 VA: 0x317D0A0
	public byte get_byParam2() { }

	// RVA: 0x317D110 Offset: 0x317D211 VA: 0x317D110
	public AkMIDIEventTypes get_byType() { }

	// RVA: 0x317D180 Offset: 0x317D281 VA: 0x317D180
	public byte get_byOnOffNote() { }

	// RVA: 0x317D1F0 Offset: 0x317D2F1 VA: 0x317D1F0
	public byte get_byVelocity() { }

	// RVA: 0x317D260 Offset: 0x317D361 VA: 0x317D260
	public AkMIDICcTypes get_byCc() { }

	// RVA: 0x317D2D0 Offset: 0x317D3D1 VA: 0x317D2D0
	public byte get_byCcValue() { }

	// RVA: 0x317D340 Offset: 0x317D441 VA: 0x317D340
	public byte get_byValueLsb() { }

	// RVA: 0x317D3B0 Offset: 0x317D4B1 VA: 0x317D3B0
	public byte get_byValueMsb() { }

	// RVA: 0x317D420 Offset: 0x317D521 VA: 0x317D420
	public byte get_byAftertouchNote() { }

	// RVA: 0x317D490 Offset: 0x317D591 VA: 0x317D490
	public byte get_byNoteAftertouchValue() { }

	// RVA: 0x317D500 Offset: 0x317D601 VA: 0x317D500
	public byte get_byChanAftertouchValue() { }

	// RVA: 0x317D570 Offset: 0x317D671 VA: 0x317D570
	public byte get_byProgramNum() { }

	// RVA: 0x317D5E0 Offset: 0x317D6E1 VA: 0x317D5E0
	public void .ctor() { }
}

