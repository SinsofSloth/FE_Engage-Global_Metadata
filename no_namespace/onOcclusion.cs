// Namespace: 
[AddComponentMenu] // RVA: 0x2721F0 Offset: 0x2722F1 VA: 0x2721F0
[RequireComponent] // RVA: 0x2721F0 Offset: 0x2722F1 VA: 0x2721F0
public class AkEmitterObstructionOcclusion : AkObstructionOcclusion // TypeDefIndex: 8010
{
	// Fields
	private AkGameObj m_gameObj; // 0x48

	// Methods

	// RVA: 0x3171690 Offset: 0x3171791 VA: 0x3171690
	private void Awake() { }

	// RVA: 0x3171760 Offset: 0x3171861 VA: 0x3171760 Slot: 4
	protected override void UpdateCurrentListenerList() { }

	// RVA: 0x3171A20 Offset: 0x3171B21 VA: 0x3171A20 Slot: 5
	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair) { }

	// RVA: 0x3171C60 Offset: 0x3171D61 VA: 0x3171C60
	public void .ctor() { }
}

// Namespace: 
protected class AkObstructionOcclusion.ObstructionOcclusionValue // TypeDefIndex: 8032
{
	// Fields
	public float currentValue; // 0x10
	public float targetValue; // 0x14

	// Methods

	// RVA: 0x24B5FE0 Offset: 0x24B60E1 VA: 0x24B5FE0
	public bool Update(float fadeRate) { }

	// RVA: 0x24B6070 Offset: 0x24B6171 VA: 0x24B6070
	public void .ctor() { }
}

