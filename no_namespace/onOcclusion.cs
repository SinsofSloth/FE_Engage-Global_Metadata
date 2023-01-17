// Namespace: 
public abstract class AkObstructionOcclusion : MonoBehaviour // TypeDefIndex: 8033
{
	// Fields
	private readonly List<AkAudioListener> listenersToRemove; // 0x18
	protected readonly List<AkAudioListener> currentListenerList; // 0x20
	private readonly Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObstructionOcclusionValues; // 0x28
	protected float fadeRate; // 0x30
	[TooltipAttribute] // RVA: 0x27ECD0 Offset: 0x27EDD1 VA: 0x27ECD0
	public float fadeTime; // 0x34
	[TooltipAttribute] // RVA: 0x27ED10 Offset: 0x27EE11 VA: 0x27ED10
	public LayerMask LayerMask; // 0x38
	[TooltipAttribute] // RVA: 0x27ED50 Offset: 0x27EE51 VA: 0x27ED50
	public float maxDistance; // 0x3C
	[TooltipAttribute] // RVA: 0x27ED90 Offset: 0x27EE91 VA: 0x27ED90
	public float refreshInterval; // 0x40
	private float refreshTime; // 0x44

	// Methods

	// RVA: 0x3171720 Offset: 0x3171821 VA: 0x3171720
	protected void InitIntervalsAndFadeRates() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void UpdateCurrentListenerList();

	// RVA: 0x31817C0 Offset: 0x31818C1 VA: 0x31817C0
	private void UpdateObstructionOcclusionValues() { }

	// RVA: 0x3181AC0 Offset: 0x3181BC1 VA: 0x3181AC0
	private void CastRays() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void SetObstructionOcclusion(KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair);

	// RVA: 0x3181D50 Offset: 0x3181E51 VA: 0x3181D50
	private void Update() { }

	// RVA: 0x3171C70 Offset: 0x3171D71 VA: 0x3171C70
	protected void .ctor() { }
}

