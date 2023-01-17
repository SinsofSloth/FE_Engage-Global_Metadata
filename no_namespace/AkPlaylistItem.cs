// Namespace: 
public class AkPlaylistItem : IDisposable // TypeDefIndex: 7887
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioNodeID { get; set; }
	public int msDelay { get; set; }
	public IntPtr pCustomInfo { get; set; }

	// Methods

	// RVA: 0x317A6C0 Offset: 0x317A7C1 VA: 0x317A6C0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317A590 Offset: 0x317A691 VA: 0x317A590
	internal static IntPtr getCPtr(AkPlaylistItem obj) { }

	// RVA: 0x3185370 Offset: 0x3185471 VA: 0x3185370 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x31853A0 Offset: 0x31854A1 VA: 0x31853A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3185410 Offset: 0x3185511 VA: 0x3185410 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x31855A0 Offset: 0x31856A1 VA: 0x31855A0
	public void .ctor() { }

	// RVA: 0x3185630 Offset: 0x3185731 VA: 0x3185630
	public void .ctor(AkPlaylistItem in_rCopy) { }

	// RVA: 0x3185710 Offset: 0x3185811 VA: 0x3185710
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy) { }

	// RVA: 0x3185810 Offset: 0x3185911 VA: 0x3185810
	public bool IsEqualTo(AkPlaylistItem in_rCopy) { }

	// RVA: 0x31858D0 Offset: 0x31859D1 VA: 0x31858D0
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) { }

	// RVA: 0x3185970 Offset: 0x3185A71 VA: 0x3185970
	public void set_audioNodeID(uint value) { }

	// RVA: 0x31859F0 Offset: 0x3185AF1 VA: 0x31859F0
	public uint get_audioNodeID() { }

	// RVA: 0x3185A60 Offset: 0x3185B61 VA: 0x3185A60
	public void set_msDelay(int value) { }

	// RVA: 0x3185AE0 Offset: 0x3185BE1 VA: 0x3185AE0
	public int get_msDelay() { }

	// RVA: 0x3185B50 Offset: 0x3185C51 VA: 0x3185B50
	public void set_pCustomInfo(IntPtr value) { }

	// RVA: 0x3185BD0 Offset: 0x3185CD1 VA: 0x3185BD0
	public IntPtr get_pCustomInfo() { }
}

