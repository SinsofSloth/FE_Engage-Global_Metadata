// Namespace: 
public class AkPositioningInfo : IDisposable // TypeDefIndex: 7889
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fCenterPct { get; set; }
	public AkSpeakerPanningType pannerType { get; set; }
	public Ak3DPositionType e3dPositioningType { get; set; }
	public bool bHoldEmitterPosAndOrient { get; set; }
	public Ak3DSpatializationMode e3DSpatializationMode { get; set; }
	public bool bEnableAttenuation { get; set; }
	public bool bUseConeAttenuation { get; set; }
	public float fInnerAngle { get; set; }
	public float fOuterAngle { get; set; }
	public float fConeMaxAttenuation { get; set; }
	public float LPFCone { get; set; }
	public float HPFCone { get; set; }
	public float fMaxDistance { get; set; }
	public float fVolDryAtMaxDist { get; set; }
	public float fVolAuxGameDefAtMaxDist { get; set; }
	public float fVolAuxUserDefAtMaxDist { get; set; }
	public float LPFValueAtMaxDist { get; set; }
	public float HPFValueAtMaxDist { get; set; }

	// Methods

	// RVA: 0x3186220 Offset: 0x3186321 VA: 0x3186220
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3186260 Offset: 0x3186361 VA: 0x3186260
	internal static IntPtr getCPtr(AkPositioningInfo obj) { }

	// RVA: 0x31862C0 Offset: 0x31863C1 VA: 0x31862C0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x31862F0 Offset: 0x31863F1 VA: 0x31862F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3186360 Offset: 0x3186461 VA: 0x3186360 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x31864F0 Offset: 0x31865F1 VA: 0x31864F0
	public void set_fCenterPct(float value) { }

	// RVA: 0x3186570 Offset: 0x3186671 VA: 0x3186570
	public float get_fCenterPct() { }

	// RVA: 0x31865E0 Offset: 0x31866E1 VA: 0x31865E0
	public void set_pannerType(AkSpeakerPanningType value) { }

	// RVA: 0x3186660 Offset: 0x3186761 VA: 0x3186660
	public AkSpeakerPanningType get_pannerType() { }

	// RVA: 0x31866D0 Offset: 0x31867D1 VA: 0x31866D0
	public void set_e3dPositioningType(Ak3DPositionType value) { }

	// RVA: 0x3186750 Offset: 0x3186851 VA: 0x3186750
	public Ak3DPositionType get_e3dPositioningType() { }

	// RVA: 0x31867C0 Offset: 0x31868C1 VA: 0x31867C0
	public void set_bHoldEmitterPosAndOrient(bool value) { }

	// RVA: 0x3186840 Offset: 0x3186941 VA: 0x3186840
	public bool get_bHoldEmitterPosAndOrient() { }

	// RVA: 0x31868B0 Offset: 0x31869B1 VA: 0x31868B0
	public void set_e3DSpatializationMode(Ak3DSpatializationMode value) { }

	// RVA: 0x3186930 Offset: 0x3186A31 VA: 0x3186930
	public Ak3DSpatializationMode get_e3DSpatializationMode() { }

	// RVA: 0x31869A0 Offset: 0x3186AA1 VA: 0x31869A0
	public void set_bEnableAttenuation(bool value) { }

	// RVA: 0x3186A20 Offset: 0x3186B21 VA: 0x3186A20
	public bool get_bEnableAttenuation() { }

	// RVA: 0x3186A90 Offset: 0x3186B91 VA: 0x3186A90
	public void set_bUseConeAttenuation(bool value) { }

	// RVA: 0x3186B10 Offset: 0x3186C11 VA: 0x3186B10
	public bool get_bUseConeAttenuation() { }

	// RVA: 0x3186B80 Offset: 0x3186C81 VA: 0x3186B80
	public void set_fInnerAngle(float value) { }

	// RVA: 0x3186C00 Offset: 0x3186D01 VA: 0x3186C00
	public float get_fInnerAngle() { }

	// RVA: 0x3186C70 Offset: 0x3186D71 VA: 0x3186C70
	public void set_fOuterAngle(float value) { }

	// RVA: 0x3186CF0 Offset: 0x3186DF1 VA: 0x3186CF0
	public float get_fOuterAngle() { }

	// RVA: 0x3186D60 Offset: 0x3186E61 VA: 0x3186D60
	public void set_fConeMaxAttenuation(float value) { }

	// RVA: 0x3186DE0 Offset: 0x3186EE1 VA: 0x3186DE0
	public float get_fConeMaxAttenuation() { }

	// RVA: 0x3186E50 Offset: 0x3186F51 VA: 0x3186E50
	public void set_LPFCone(float value) { }

	// RVA: 0x3186ED0 Offset: 0x3186FD1 VA: 0x3186ED0
	public float get_LPFCone() { }

	// RVA: 0x3186F40 Offset: 0x3187041 VA: 0x3186F40
	public void set_HPFCone(float value) { }

	// RVA: 0x3186FC0 Offset: 0x31870C1 VA: 0x3186FC0
	public float get_HPFCone() { }

	// RVA: 0x3187030 Offset: 0x3187131 VA: 0x3187030
	public void set_fMaxDistance(float value) { }

	// RVA: 0x31870B0 Offset: 0x31871B1 VA: 0x31870B0
	public float get_fMaxDistance() { }

	// RVA: 0x3187120 Offset: 0x3187221 VA: 0x3187120
	public void set_fVolDryAtMaxDist(float value) { }

	// RVA: 0x31871A0 Offset: 0x31872A1 VA: 0x31871A0
	public float get_fVolDryAtMaxDist() { }

	// RVA: 0x3187210 Offset: 0x3187311 VA: 0x3187210
	public void set_fVolAuxGameDefAtMaxDist(float value) { }

	// RVA: 0x3187290 Offset: 0x3187391 VA: 0x3187290
	public float get_fVolAuxGameDefAtMaxDist() { }

	// RVA: 0x3187300 Offset: 0x3187401 VA: 0x3187300
	public void set_fVolAuxUserDefAtMaxDist(float value) { }

	// RVA: 0x3187380 Offset: 0x3187481 VA: 0x3187380
	public float get_fVolAuxUserDefAtMaxDist() { }

	// RVA: 0x31873F0 Offset: 0x31874F1 VA: 0x31873F0
	public void set_LPFValueAtMaxDist(float value) { }

	// RVA: 0x3187470 Offset: 0x3187571 VA: 0x3187470
	public float get_LPFValueAtMaxDist() { }

	// RVA: 0x31874E0 Offset: 0x31875E1 VA: 0x31874E0
	public void set_HPFValueAtMaxDist(float value) { }

	// RVA: 0x3187560 Offset: 0x3187661 VA: 0x3187560
	public float get_HPFValueAtMaxDist() { }

	// RVA: 0x31875D0 Offset: 0x31876D1 VA: 0x31875D0
	public void .ctor() { }
}

