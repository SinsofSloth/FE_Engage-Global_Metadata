// Namespace: 
public class AkObjectInfo : IDisposable // TypeDefIndex: 7881
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint objID { get; set; }
	public uint parentID { get; set; }
	public int iDepth { get; set; }

	// Methods

	// RVA: 0x3180D80 Offset: 0x3180E81 VA: 0x3180D80
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3180DC0 Offset: 0x3180EC1 VA: 0x3180DC0
	internal static IntPtr getCPtr(AkObjectInfo obj) { }

	// RVA: 0x3180E20 Offset: 0x3180F21 VA: 0x3180E20 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3180E50 Offset: 0x3180F51 VA: 0x3180E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3180EC0 Offset: 0x3180FC1 VA: 0x3180EC0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3181050 Offset: 0x3181151 VA: 0x3181050
	public void set_objID(uint value) { }

	// RVA: 0x31810D0 Offset: 0x31811D1 VA: 0x31810D0
	public uint get_objID() { }

	// RVA: 0x3181140 Offset: 0x3181241 VA: 0x3181140
	public void set_parentID(uint value) { }

	// RVA: 0x31811C0 Offset: 0x31812C1 VA: 0x31811C0
	public uint get_parentID() { }

	// RVA: 0x3181230 Offset: 0x3181331 VA: 0x3181230
	public void set_iDepth(int value) { }

	// RVA: 0x31812B0 Offset: 0x31813B1 VA: 0x31812B0
	public int get_iDepth() { }

	// RVA: 0x3181320 Offset: 0x3181421 VA: 0x3181320
	public void Clear() { }

	// RVA: 0x3181390 Offset: 0x3181491 VA: 0x3181390
	public static int GetSizeOf() { }

	// RVA: 0x3181400 Offset: 0x3181501 VA: 0x3181400
	public void Clone(AkObjectInfo other) { }

	// RVA: 0x31814C0 Offset: 0x31815C1 VA: 0x31814C0
	public void .ctor() { }
}

