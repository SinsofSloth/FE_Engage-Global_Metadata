// Namespace: 
public class AkImageSourceParams : IDisposable // TypeDefIndex: 7855
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 sourcePosition { get; set; }
	public float fDistanceScalingFactor { get; set; }
	public float fLevel { get; set; }
	public float fDiffraction { get; set; }
	public byte uDiffractionEmitterSide { get; set; }
	public byte uDiffractionListenerSide { get; set; }

	// Methods

	// RVA: 0x31775A0 Offset: 0x31776A1 VA: 0x31775A0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x31775E0 Offset: 0x31776E1 VA: 0x31775E0
	internal static IntPtr getCPtr(AkImageSourceParams obj) { }

	// RVA: 0x3177640 Offset: 0x3177741 VA: 0x3177640 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3177670 Offset: 0x3177771 VA: 0x3177670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31776E0 Offset: 0x31777E1 VA: 0x31776E0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3177870 Offset: 0x3177971 VA: 0x3177870
	public void .ctor() { }

	// RVA: 0x3177900 Offset: 0x3177A01 VA: 0x3177900
	public void .ctor(Vector3 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) { }

	// RVA: 0x31779D0 Offset: 0x3177AD1 VA: 0x31779D0
	public void set_sourcePosition(Vector3 value) { }

	// RVA: 0x3177A70 Offset: 0x3177B71 VA: 0x3177A70
	public Vector3 get_sourcePosition() { }

	// RVA: 0x3177AE0 Offset: 0x3177BE1 VA: 0x3177AE0
	public void set_fDistanceScalingFactor(float value) { }

	// RVA: 0x3177B60 Offset: 0x3177C61 VA: 0x3177B60
	public float get_fDistanceScalingFactor() { }

	// RVA: 0x3177BD0 Offset: 0x3177CD1 VA: 0x3177BD0
	public void set_fLevel(float value) { }

	// RVA: 0x3177C50 Offset: 0x3177D51 VA: 0x3177C50
	public float get_fLevel() { }

	// RVA: 0x3177CC0 Offset: 0x3177DC1 VA: 0x3177CC0
	public void set_fDiffraction(float value) { }

	// RVA: 0x3177D40 Offset: 0x3177E41 VA: 0x3177D40
	public float get_fDiffraction() { }

	// RVA: 0x3177DB0 Offset: 0x3177EB1 VA: 0x3177DB0
	public void set_uDiffractionEmitterSide(byte value) { }

	// RVA: 0x3177E30 Offset: 0x3177F31 VA: 0x3177E30
	public byte get_uDiffractionEmitterSide() { }

	// RVA: 0x3177EA0 Offset: 0x3177FA1 VA: 0x3177EA0
	public void set_uDiffractionListenerSide(byte value) { }

	// RVA: 0x3177F20 Offset: 0x3178021 VA: 0x3177F20
	public byte get_uDiffractionListenerSide() { }
}

