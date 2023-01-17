// Namespace: 
public class AkPlaylist : AkPlaylistArray // TypeDefIndex: 7885
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Methods

	// RVA: 0x3183510 Offset: 0x3183611 VA: 0x3183510
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x31835F0 Offset: 0x31836F1 VA: 0x31835F0
	internal static IntPtr getCPtr(AkPlaylist obj) { }

	// RVA: 0x3183650 Offset: 0x3183751 VA: 0x3183650 Slot: 5
	internal override void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3183710 Offset: 0x3183811 VA: 0x3183710 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3183870 Offset: 0x3183971 VA: 0x3183870 Slot: 6
	public override void Dispose() { }

	// RVA: 0x3183B90 Offset: 0x3183C91 VA: 0x3183B90
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }

	// RVA: 0x3183C50 Offset: 0x3183D51 VA: 0x3183C50
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals) { }

	// RVA: 0x3183CF0 Offset: 0x3183DF1 VA: 0x3183CF0
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo) { }

	// RVA: 0x3183D80 Offset: 0x3183E81 VA: 0x3183D80
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay) { }

	// RVA: 0x3183E10 Offset: 0x3183F11 VA: 0x3183E10
	public AKRESULT Enqueue(uint in_audioNodeID) { }

	// RVA: 0x3183E90 Offset: 0x3183F91 VA: 0x3183E90
	public void .ctor() { }
}

