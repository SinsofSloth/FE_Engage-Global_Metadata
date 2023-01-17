// Namespace: 
public class AkDiffractionPathInfo : IDisposable // TypeDefIndex: 7846
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18
	public const uint kMaxNodes = 8;

	// Properties
	public AkTransform virtualPos { get; set; }
	public uint nodeCount { get; set; }
	public float diffraction { get; set; }
	public float totLength { get; set; }
	public float obstructionValue { get; set; }

	// Methods

	// RVA: 0x316F600 Offset: 0x316F701 VA: 0x316F600
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x316F640 Offset: 0x316F741 VA: 0x316F640
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj) { }

	// RVA: 0x316F6A0 Offset: 0x316F7A1 VA: 0x316F6A0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x316F6D0 Offset: 0x316F7D1 VA: 0x316F6D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x316F740 Offset: 0x316F841 VA: 0x316F740 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316F8D0 Offset: 0x316F9D1 VA: 0x316F8D0
	public void set_virtualPos(AkTransform value) { }

	// RVA: 0x316F960 Offset: 0x316FA61 VA: 0x316F960
	public AkTransform get_virtualPos() { }

	// RVA: 0x316FA40 Offset: 0x316FB41 VA: 0x316FA40
	public void set_nodeCount(uint value) { }

	// RVA: 0x316FAC0 Offset: 0x316FBC1 VA: 0x316FAC0
	public uint get_nodeCount() { }

	// RVA: 0x316FB30 Offset: 0x316FC31 VA: 0x316FB30
	public void set_diffraction(float value) { }

	// RVA: 0x316FBB0 Offset: 0x316FCB1 VA: 0x316FBB0
	public float get_diffraction() { }

	// RVA: 0x316FC20 Offset: 0x316FD21 VA: 0x316FC20
	public void set_totLength(float value) { }

	// RVA: 0x316FCA0 Offset: 0x316FDA1 VA: 0x316FCA0
	public float get_totLength() { }

	// RVA: 0x316FD10 Offset: 0x316FE11 VA: 0x316FD10
	public void set_obstructionValue(float value) { }

	// RVA: 0x316FD90 Offset: 0x316FE91 VA: 0x316FD90
	public float get_obstructionValue() { }

	// RVA: 0x316FE00 Offset: 0x316FF01 VA: 0x316FE00
	public static int GetSizeOf() { }

	// RVA: 0x316FE70 Offset: 0x316FF71 VA: 0x316FE70
	public Vector3 GetNodes(uint idx) { }

	// RVA: 0x316FEF0 Offset: 0x316FFF1 VA: 0x316FEF0
	public float GetAngles(uint idx) { }

	// RVA: 0x316FF70 Offset: 0x3170071 VA: 0x316FF70
	public ulong GetPortals(uint idx) { }

	// RVA: 0x316FFF0 Offset: 0x31700F1 VA: 0x316FFF0
	public ulong GetRooms(uint idx) { }

	// RVA: 0x3170070 Offset: 0x3170171 VA: 0x3170070
	public void Clone(AkDiffractionPathInfo other) { }

	// RVA: 0x3170130 Offset: 0x3170231 VA: 0x3170130
	public void .ctor() { }
}

