// Namespace: 
public class AkMIDIEvent.tNoteOnOff : IDisposable // TypeDefIndex: 7862
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byNote { get; set; }
	public byte byVelocity { get; set; }

	// Methods

	// RVA: 0x24B4E90 Offset: 0x24B4F91 VA: 0x24B4E90
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x24B4ED0 Offset: 0x24B4FD1 VA: 0x24B4ED0
	internal static IntPtr getCPtr(AkMIDIEvent.tNoteOnOff obj) { }

	// RVA: 0x24B4F30 Offset: 0x24B5031 VA: 0x24B4F30 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x24B4F60 Offset: 0x24B5061 VA: 0x24B4F60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24B4FD0 Offset: 0x24B50D1 VA: 0x24B4FD0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x24B5160 Offset: 0x24B5261 VA: 0x24B5160
	public void set_byNote(byte value) { }

	// RVA: 0x24B51E0 Offset: 0x24B52E1 VA: 0x24B51E0
	public byte get_byNote() { }

	// RVA: 0x24B5250 Offset: 0x24B5351 VA: 0x24B5250
	public void set_byVelocity(byte value) { }

	// RVA: 0x24B52D0 Offset: 0x24B53D1 VA: 0x24B52D0
	public byte get_byVelocity() { }

	// RVA: 0x24B5340 Offset: 0x24B5441 VA: 0x24B5340
	public void .ctor() { }
}

// Namespace: 
public class AkMIDIEvent.tPitchBend : IDisposable // TypeDefIndex: 7864
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byValueLsb { get; set; }
	public byte byValueMsb { get; set; }

	// Methods

	// RVA: 0x24B53D0 Offset: 0x24B54D1 VA: 0x24B53D0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x24B5410 Offset: 0x24B5511 VA: 0x24B5410
	internal static IntPtr getCPtr(AkMIDIEvent.tPitchBend obj) { }

	// RVA: 0x24B5470 Offset: 0x24B5571 VA: 0x24B5470 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x24B54A0 Offset: 0x24B55A1 VA: 0x24B54A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24B5510 Offset: 0x24B5611 VA: 0x24B5510 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x24B56A0 Offset: 0x24B57A1 VA: 0x24B56A0
	public void set_byValueLsb(byte value) { }

	// RVA: 0x24B5720 Offset: 0x24B5821 VA: 0x24B5720
	public byte get_byValueLsb() { }

	// RVA: 0x24B5790 Offset: 0x24B5891 VA: 0x24B5790
	public void set_byValueMsb(byte value) { }

	// RVA: 0x24B5810 Offset: 0x24B5911 VA: 0x24B5810
	public byte get_byValueMsb() { }

	// RVA: 0x24B5880 Offset: 0x24B5981 VA: 0x24B5880
	public void .ctor() { }
}

// Namespace: 
public class AkMIDIEvent.tChanAftertouch : IDisposable // TypeDefIndex: 7866
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byValue { get; set; }

	// Methods

	// RVA: 0x24B3FC0 Offset: 0x24B40C1 VA: 0x24B3FC0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x24B4000 Offset: 0x24B4101 VA: 0x24B4000
	internal static IntPtr getCPtr(AkMIDIEvent.tChanAftertouch obj) { }

	// RVA: 0x24B4060 Offset: 0x24B4161 VA: 0x24B4060 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x24B4090 Offset: 0x24B4191 VA: 0x24B4090 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24B4100 Offset: 0x24B4201 VA: 0x24B4100 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x24B4290 Offset: 0x24B4391 VA: 0x24B4290
	public void set_byValue(byte value) { }

	// RVA: 0x24B4310 Offset: 0x24B4411 VA: 0x24B4310
	public byte get_byValue() { }

	// RVA: 0x24B4380 Offset: 0x24B4481 VA: 0x24B4380
	public void .ctor() { }
}

// Namespace: 
public class AkMIDIEvent : IDisposable // TypeDefIndex: 7868
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byChan { get; set; }
	public AkMIDIEvent.tGen Gen { get; set; }
	public AkMIDIEvent.tCc Cc { get; set; }
	public AkMIDIEvent.tNoteOnOff NoteOnOff { get; set; }
	public AkMIDIEvent.tPitchBend PitchBend { get; set; }
	public AkMIDIEvent.tNoteAftertouch NoteAftertouch { get; set; }
	public AkMIDIEvent.tChanAftertouch ChanAftertouch { get; set; }
	public AkMIDIEvent.tProgramChange ProgramChange { get; set; }
	public AkMIDIEventTypes byType { get; set; }
	public byte byOnOffNote { get; set; }
	public byte byVelocity { get; set; }
	public AkMIDICcTypes byCc { get; set; }
	public byte byCcValue { get; set; }
	public byte byValueLsb { get; set; }
	public byte byValueMsb { get; set; }
	public byte byAftertouchNote { get; set; }
	public byte byNoteAftertouchValue { get; set; }
	public byte byChanAftertouchValue { get; set; }
	public byte byProgramNum { get; set; }

	// Methods

	// RVA: 0x317B270 Offset: 0x317B371 VA: 0x317B270
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317B2B0 Offset: 0x317B3B1 VA: 0x317B2B0
	internal static IntPtr getCPtr(AkMIDIEvent obj) { }

	// RVA: 0x317B310 Offset: 0x317B411 VA: 0x317B310 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x317B340 Offset: 0x317B441 VA: 0x317B340 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317B3B0 Offset: 0x317B4B1 VA: 0x317B3B0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x317B540 Offset: 0x317B641 VA: 0x317B540
	public void set_byChan(byte value) { }

	// RVA: 0x317B5C0 Offset: 0x317B6C1 VA: 0x317B5C0
	public byte get_byChan() { }

	// RVA: 0x317B630 Offset: 0x317B731 VA: 0x317B630
	public void set_Gen(AkMIDIEvent.tGen value) { }

	// RVA: 0x317B6C0 Offset: 0x317B7C1 VA: 0x317B6C0
	public AkMIDIEvent.tGen get_Gen() { }

	// RVA: 0x317B7A0 Offset: 0x317B8A1 VA: 0x317B7A0
	public void set_Cc(AkMIDIEvent.tCc value) { }

	// RVA: 0x317B830 Offset: 0x317B931 VA: 0x317B830
	public AkMIDIEvent.tCc get_Cc() { }

	// RVA: 0x317B910 Offset: 0x317BA11 VA: 0x317B910
	public void set_NoteOnOff(AkMIDIEvent.tNoteOnOff value) { }

	// RVA: 0x317B9A0 Offset: 0x317BAA1 VA: 0x317B9A0
	public AkMIDIEvent.tNoteOnOff get_NoteOnOff() { }

	// RVA: 0x317BA80 Offset: 0x317BB81 VA: 0x317BA80
	public void set_PitchBend(AkMIDIEvent.tPitchBend value) { }

	// RVA: 0x317BB10 Offset: 0x317BC11 VA: 0x317BB10
	public AkMIDIEvent.tPitchBend get_PitchBend() { }

	// RVA: 0x317BBF0 Offset: 0x317BCF1 VA: 0x317BBF0
	public void set_NoteAftertouch(AkMIDIEvent.tNoteAftertouch value) { }

	// RVA: 0x317BC80 Offset: 0x317BD81 VA: 0x317BC80
	public AkMIDIEvent.tNoteAftertouch get_NoteAftertouch() { }

	// RVA: 0x317BD60 Offset: 0x317BE61 VA: 0x317BD60
	public void set_ChanAftertouch(AkMIDIEvent.tChanAftertouch value) { }

	// RVA: 0x317BDF0 Offset: 0x317BEF1 VA: 0x317BDF0
	public AkMIDIEvent.tChanAftertouch get_ChanAftertouch() { }

	// RVA: 0x317BED0 Offset: 0x317BFD1 VA: 0x317BED0
	public void set_ProgramChange(AkMIDIEvent.tProgramChange value) { }

	// RVA: 0x317BF60 Offset: 0x317C061 VA: 0x317BF60
	public AkMIDIEvent.tProgramChange get_ProgramChange() { }

	// RVA: 0x317C040 Offset: 0x317C141 VA: 0x317C040
	public void set_byType(AkMIDIEventTypes value) { }

	// RVA: 0x317C0C0 Offset: 0x317C1C1 VA: 0x317C0C0
	public AkMIDIEventTypes get_byType() { }

	// RVA: 0x317C130 Offset: 0x317C231 VA: 0x317C130
	public void set_byOnOffNote(byte value) { }

	// RVA: 0x317C1B0 Offset: 0x317C2B1 VA: 0x317C1B0
	public byte get_byOnOffNote() { }

	// RVA: 0x317C220 Offset: 0x317C321 VA: 0x317C220
	public void set_byVelocity(byte value) { }

	// RVA: 0x317C2A0 Offset: 0x317C3A1 VA: 0x317C2A0
	public byte get_byVelocity() { }

	// RVA: 0x317C310 Offset: 0x317C411 VA: 0x317C310
	public void set_byCc(AkMIDICcTypes value) { }

	// RVA: 0x317C390 Offset: 0x317C491 VA: 0x317C390
	public AkMIDICcTypes get_byCc() { }

	// RVA: 0x317C400 Offset: 0x317C501 VA: 0x317C400
	public void set_byCcValue(byte value) { }

	// RVA: 0x317C480 Offset: 0x317C581 VA: 0x317C480
	public byte get_byCcValue() { }

	// RVA: 0x317C4F0 Offset: 0x317C5F1 VA: 0x317C4F0
	public void set_byValueLsb(byte value) { }

	// RVA: 0x317C570 Offset: 0x317C671 VA: 0x317C570
	public byte get_byValueLsb() { }

	// RVA: 0x317C5E0 Offset: 0x317C6E1 VA: 0x317C5E0
	public void set_byValueMsb(byte value) { }

	// RVA: 0x317C660 Offset: 0x317C761 VA: 0x317C660
	public byte get_byValueMsb() { }

	// RVA: 0x317C6D0 Offset: 0x317C7D1 VA: 0x317C6D0
	public void set_byAftertouchNote(byte value) { }

	// RVA: 0x317C750 Offset: 0x317C851 VA: 0x317C750
	public byte get_byAftertouchNote() { }

	// RVA: 0x317C7C0 Offset: 0x317C8C1 VA: 0x317C7C0
	public void set_byNoteAftertouchValue(byte value) { }

	// RVA: 0x317C840 Offset: 0x317C941 VA: 0x317C840
	public byte get_byNoteAftertouchValue() { }

	// RVA: 0x317C8B0 Offset: 0x317C9B1 VA: 0x317C8B0
	public void set_byChanAftertouchValue(byte value) { }

	// RVA: 0x317C930 Offset: 0x317CA31 VA: 0x317C930
	public byte get_byChanAftertouchValue() { }

	// RVA: 0x317C9A0 Offset: 0x317CAA1 VA: 0x317C9A0
	public void set_byProgramNum(byte value) { }

	// RVA: 0x317CA20 Offset: 0x317CB21 VA: 0x317CA20
	public byte get_byProgramNum() { }

	// RVA: 0x317CA90 Offset: 0x317CB91 VA: 0x317CA90
	public void .ctor() { }
}

