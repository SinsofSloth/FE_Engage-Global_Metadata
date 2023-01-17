// Namespace: 
public class AkSpatialAudioInitSettings : IDisposable // TypeDefIndex: 7900
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxSoundPropagationDepth { get; set; }
	public uint uDiffractionFlags { get; set; }
	public float fDiffractionShadowAttenFactor { get; set; }
	public float fDiffractionShadowDegrees { get; set; }
	public float fMovementThreshold { get; set; }
	public uint uNumberOfPrimaryRays { get; set; }
	public uint uMaxReflectionOrder { get; set; }
	public float fMaxPathLength { get; set; }
	public bool bEnableDiffractionOnReflection { get; set; }
	public bool bEnableDirectPathDiffraction { get; set; }
	public bool bEnableTransmission { get; set; }

	// Methods

	// RVA: 0x20D5D60 Offset: 0x20D5E61 VA: 0x20D5D60
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20CC4F0 Offset: 0x20CC5F1 VA: 0x20CC4F0
	internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj) { }

	// RVA: 0x20D5DA0 Offset: 0x20D5EA1 VA: 0x20D5DA0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20D5DD0 Offset: 0x20D5ED1 VA: 0x20D5DD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20D5E40 Offset: 0x20D5F41 VA: 0x20D5E40 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20D5FC0 Offset: 0x20D60C1 VA: 0x20D5FC0
	public void .ctor() { }

	// RVA: 0x20D6050 Offset: 0x20D6151 VA: 0x20D6050
	public void set_uMaxSoundPropagationDepth(uint value) { }

	// RVA: 0x20D60D0 Offset: 0x20D61D1 VA: 0x20D60D0
	public uint get_uMaxSoundPropagationDepth() { }

	// RVA: 0x20D6140 Offset: 0x20D6241 VA: 0x20D6140
	public void set_uDiffractionFlags(uint value) { }

	// RVA: 0x20D61C0 Offset: 0x20D62C1 VA: 0x20D61C0
	public uint get_uDiffractionFlags() { }

	// RVA: 0x20D6230 Offset: 0x20D6331 VA: 0x20D6230
	public void set_fDiffractionShadowAttenFactor(float value) { }

	// RVA: 0x20D62B0 Offset: 0x20D63B1 VA: 0x20D62B0
	public float get_fDiffractionShadowAttenFactor() { }

	// RVA: 0x20D6320 Offset: 0x20D6421 VA: 0x20D6320
	public void set_fDiffractionShadowDegrees(float value) { }

	// RVA: 0x20D63A0 Offset: 0x20D64A1 VA: 0x20D63A0
	public float get_fDiffractionShadowDegrees() { }

	// RVA: 0x20D6410 Offset: 0x20D6511 VA: 0x20D6410
	public void set_fMovementThreshold(float value) { }

	// RVA: 0x20D6490 Offset: 0x20D6591 VA: 0x20D6490
	public float get_fMovementThreshold() { }

	// RVA: 0x20D6500 Offset: 0x20D6601 VA: 0x20D6500
	public void set_uNumberOfPrimaryRays(uint value) { }

	// RVA: 0x20D6580 Offset: 0x20D6681 VA: 0x20D6580
	public uint get_uNumberOfPrimaryRays() { }

	// RVA: 0x20D65F0 Offset: 0x20D66F1 VA: 0x20D65F0
	public void set_uMaxReflectionOrder(uint value) { }

	// RVA: 0x20D6670 Offset: 0x20D6771 VA: 0x20D6670
	public uint get_uMaxReflectionOrder() { }

	// RVA: 0x20D66E0 Offset: 0x20D67E1 VA: 0x20D66E0
	public void set_fMaxPathLength(float value) { }

	// RVA: 0x20D6760 Offset: 0x20D6861 VA: 0x20D6760
	public float get_fMaxPathLength() { }

	// RVA: 0x20D67D0 Offset: 0x20D68D1 VA: 0x20D67D0
	public void set_bEnableDiffractionOnReflection(bool value) { }

	// RVA: 0x20D6850 Offset: 0x20D6951 VA: 0x20D6850
	public bool get_bEnableDiffractionOnReflection() { }

	// RVA: 0x20D68D0 Offset: 0x20D69D1 VA: 0x20D68D0
	public void set_bEnableDirectPathDiffraction(bool value) { }

	// RVA: 0x20D6950 Offset: 0x20D6A51 VA: 0x20D6950
	public bool get_bEnableDirectPathDiffraction() { }

	// RVA: 0x20D69D0 Offset: 0x20D6AD1 VA: 0x20D69D0
	public void set_bEnableTransmission(bool value) { }

	// RVA: 0x20D6A50 Offset: 0x20D6B51 VA: 0x20D6A50
	public bool get_bEnableTransmission() { }
}

