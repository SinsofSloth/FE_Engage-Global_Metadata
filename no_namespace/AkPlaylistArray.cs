// Namespace: 
public class AkPlaylistArray : IDisposable // TypeDefIndex: 7886
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Methods

	// RVA: 0x31835B0 Offset: 0x31836B1 VA: 0x31835B0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3183F70 Offset: 0x3184071 VA: 0x3183F70
	internal static IntPtr getCPtr(AkPlaylistArray obj) { }

	// RVA: 0x31836E0 Offset: 0x31837E1 VA: 0x31836E0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3183800 Offset: 0x3183901 VA: 0x3183800 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3183A00 Offset: 0x3183B01 VA: 0x3183A00 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3183FD0 Offset: 0x31840D1 VA: 0x3183FD0
	public void .ctor() { }

	// RVA: 0x3184060 Offset: 0x3184161 VA: 0x3184060
	public AkIterator Begin() { }

	// RVA: 0x3184110 Offset: 0x3184211 VA: 0x3184110
	public AkIterator End() { }

	// RVA: 0x31841C0 Offset: 0x31842C1 VA: 0x31841C0
	public AkIterator FindEx(AkPlaylistItem in_Item) { }

	// RVA: 0x31842C0 Offset: 0x31843C1 VA: 0x31842C0
	public AkIterator Erase(AkIterator in_rIter) { }

	// RVA: 0x31843C0 Offset: 0x31844C1 VA: 0x31843C0
	public void Erase(uint in_uIndex) { }

	// RVA: 0x3184440 Offset: 0x3184541 VA: 0x3184440
	public AkIterator EraseSwap(AkIterator in_rIter) { }

	// RVA: 0x3184540 Offset: 0x3184641 VA: 0x3184540
	public bool IsGrowingAllowed() { }

	// RVA: 0x31845B0 Offset: 0x31846B1 VA: 0x31845B0
	public AKRESULT Reserve(uint in_ulReserve) { }

	// RVA: 0x3184630 Offset: 0x3184731 VA: 0x3184630
	public uint Reserved() { }

	// RVA: 0x31846A0 Offset: 0x31847A1 VA: 0x31846A0
	public void Term() { }

	// RVA: 0x3184710 Offset: 0x3184811 VA: 0x3184710
	public uint Length() { }

	// RVA: 0x3184780 Offset: 0x3184881 VA: 0x3184780
	public AkPlaylistItem Data() { }

	// RVA: 0x3184850 Offset: 0x3184951 VA: 0x3184850
	public bool IsEmpty() { }

	// RVA: 0x31848C0 Offset: 0x31849C1 VA: 0x31848C0
	public AkPlaylistItem Exists(AkPlaylistItem in_Item) { }

	// RVA: 0x31849E0 Offset: 0x3184AE1 VA: 0x31849E0
	public AkPlaylistItem AddLast() { }

	// RVA: 0x3184AB0 Offset: 0x3184BB1 VA: 0x3184AB0
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem) { }

	// RVA: 0x3184BD0 Offset: 0x3184CD1 VA: 0x3184BD0
	public AkPlaylistItem Last() { }

	// RVA: 0x3184C80 Offset: 0x3184D81 VA: 0x3184C80
	public void RemoveLast() { }

	// RVA: 0x3184CF0 Offset: 0x3184DF1 VA: 0x3184CF0
	public AKRESULT Remove(AkPlaylistItem in_rItem) { }

	// RVA: 0x3184DB0 Offset: 0x3184EB1 VA: 0x3184DB0
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem) { }

	// RVA: 0x3184E70 Offset: 0x3184F71 VA: 0x3184E70
	public void RemoveAll() { }

	// RVA: 0x3184EE0 Offset: 0x3184FE1 VA: 0x3184EE0
	public AkPlaylistItem ItemAtIndex(uint uiIndex) { }

	// RVA: 0x3184FA0 Offset: 0x31850A1 VA: 0x3184FA0
	public AkPlaylistItem Insert(uint in_uIndex) { }

	// RVA: 0x3185080 Offset: 0x3185181 VA: 0x3185080
	public bool GrowArray() { }

	// RVA: 0x31850F0 Offset: 0x31851F1 VA: 0x31850F0
	public bool GrowArray(uint in_uGrowBy) { }

	// RVA: 0x3185170 Offset: 0x3185271 VA: 0x3185170
	public bool Resize(uint in_uiSize) { }

	// RVA: 0x31851F0 Offset: 0x31852F1 VA: 0x31851F0
	public void Transfer(AkPlaylistArray in_rSource) { }

	// RVA: 0x31852B0 Offset: 0x31853B1 VA: 0x31852B0
	public AKRESULT Copy(AkPlaylistArray in_rSource) { }
}

