// Namespace: 
public class AkIterator : IDisposable // TypeDefIndex: 7859
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkPlaylistItem pItem { get; set; }

	// Methods

	// RVA: 0x317A200 Offset: 0x317A301 VA: 0x317A200
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317A240 Offset: 0x317A341 VA: 0x317A240
	internal static IntPtr getCPtr(AkIterator obj) { }

	// RVA: 0x317A2A0 Offset: 0x317A3A1 VA: 0x317A2A0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x317A2D0 Offset: 0x317A3D1 VA: 0x317A2D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317A340 Offset: 0x317A441 VA: 0x317A340 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x317A4D0 Offset: 0x317A5D1 VA: 0x317A4D0
	public void set_pItem(AkPlaylistItem value) { }

	// RVA: 0x317A5F0 Offset: 0x317A6F1 VA: 0x317A5F0
	public AkPlaylistItem get_pItem() { }

	// RVA: 0x317A700 Offset: 0x317A801 VA: 0x317A700
	public AkIterator NextIter() { }

	// RVA: 0x317A7B0 Offset: 0x317A8B1 VA: 0x317A7B0
	public AkIterator PrevIter() { }

	// RVA: 0x317A860 Offset: 0x317A961 VA: 0x317A860
	public AkPlaylistItem GetItem() { }

	// RVA: 0x317A910 Offset: 0x317AA11 VA: 0x317A910
	public bool IsEqualTo(AkIterator in_rOp) { }

	// RVA: 0x317A9D0 Offset: 0x317AAD1 VA: 0x317A9D0
	public bool IsDifferentFrom(AkIterator in_rOp) { }

	// RVA: 0x317AA90 Offset: 0x317AB91 VA: 0x317AA90
	public void .ctor() { }
}

