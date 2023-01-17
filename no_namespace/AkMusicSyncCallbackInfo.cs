// Namespace: 
public class AkMusicSyncCallbackInfo : AkCallbackInfo // TypeDefIndex: 7880
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; }
	public int segmentInfo_iCurrentPosition { get; }
	public int segmentInfo_iPreEntryDuration { get; }
	public int segmentInfo_iActiveDuration { get; }
	public int segmentInfo_iPostExitDuration { get; }
	public int segmentInfo_iRemainingLookAheadTime { get; }
	public float segmentInfo_fBeatDuration { get; }
	public float segmentInfo_fBarDuration { get; }
	public float segmentInfo_fGridDuration { get; }
	public float segmentInfo_fGridOffset { get; }
	public AkCallbackType musicSyncType { get; }
	public string userCueName { get; }

	// Methods

	// RVA: 0x31803A0 Offset: 0x31804A1 VA: 0x31803A0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3180440 Offset: 0x3180541 VA: 0x3180440
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj) { }

	// RVA: 0x31804A0 Offset: 0x31805A1 VA: 0x31804A0 Slot: 5
	internal override void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3180530 Offset: 0x3180631 VA: 0x3180530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31805A0 Offset: 0x31806A1 VA: 0x31805A0 Slot: 6
	public override void Dispose() { }

	// RVA: 0x3180730 Offset: 0x3180831 VA: 0x3180730
	public uint get_playingID() { }

	// RVA: 0x31807A0 Offset: 0x31808A1 VA: 0x31807A0
	public int get_segmentInfo_iCurrentPosition() { }

	// RVA: 0x3180810 Offset: 0x3180911 VA: 0x3180810
	public int get_segmentInfo_iPreEntryDuration() { }

	// RVA: 0x3180880 Offset: 0x3180981 VA: 0x3180880
	public int get_segmentInfo_iActiveDuration() { }

	// RVA: 0x31808F0 Offset: 0x31809F1 VA: 0x31808F0
	public int get_segmentInfo_iPostExitDuration() { }

	// RVA: 0x3180960 Offset: 0x3180A61 VA: 0x3180960
	public int get_segmentInfo_iRemainingLookAheadTime() { }

	// RVA: 0x31809D0 Offset: 0x3180AD1 VA: 0x31809D0
	public float get_segmentInfo_fBeatDuration() { }

	// RVA: 0x3180A40 Offset: 0x3180B41 VA: 0x3180A40
	public float get_segmentInfo_fBarDuration() { }

	// RVA: 0x3180AB0 Offset: 0x3180BB1 VA: 0x3180AB0
	public float get_segmentInfo_fGridDuration() { }

	// RVA: 0x3180B20 Offset: 0x3180C21 VA: 0x3180B20
	public float get_segmentInfo_fGridOffset() { }

	// RVA: 0x3180B90 Offset: 0x3180C91 VA: 0x3180B90
	public AkCallbackType get_musicSyncType() { }

	// RVA: 0x3180C00 Offset: 0x3180D01 VA: 0x3180C00
	public string get_userCueName() { }

	// RVA: 0x3180CB0 Offset: 0x3180DB1 VA: 0x3180CB0
	public void .ctor() { }
}

