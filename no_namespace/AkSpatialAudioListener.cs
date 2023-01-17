// Namespace: 
public class AkSpatialAudioListener.SpatialAudioListenerList // TypeDefIndex: 8047
{
	// Fields
	private readonly List<AkSpatialAudioListener> listenerList; // 0x10

	// Properties
	public List<AkSpatialAudioListener> ListenerList { get; }

	// Methods

	// RVA: 0x1F5B2A0 Offset: 0x1F5B3A1 VA: 0x1F5B2A0
	public List<AkSpatialAudioListener> get_ListenerList() { }

	// RVA: 0x1F5B2B0 Offset: 0x1F5B3B1 VA: 0x1F5B2B0
	public bool Add(AkSpatialAudioListener listener) { }

	// RVA: 0x1F5B660 Offset: 0x1F5B761 VA: 0x1F5B660
	public bool Remove(AkSpatialAudioListener listener) { }

	// RVA: 0x1F5B3A0 Offset: 0x1F5B4A1 VA: 0x1F5B3A0
	private void Refresh() { }

	// RVA: 0x1F5B730 Offset: 0x1F5B831 VA: 0x1F5B730
	public void .ctor() { }
}

// Namespace: 
[RequireComponent] // RVA: 0x272BA0 Offset: 0x272CA1 VA: 0x272BA0
[RequireComponent] // RVA: 0x272BA0 Offset: 0x272CA1 VA: 0x272BA0
[DisallowMultipleComponent] // RVA: 0x272BA0 Offset: 0x272CA1 VA: 0x272BA0
[AddComponentMenu] // RVA: 0x272BA0 Offset: 0x272CA1 VA: 0x272BA0
public class AkSpatialAudioListener : MonoBehaviour // TypeDefIndex: 8048
{
	// Fields
	private static AkSpatialAudioListener s_SpatialAudioListener; // 0x0
	private static readonly AkSpatialAudioListener.SpatialAudioListenerList spatialAudioListeners; // 0x8
	private AkAudioListener AkAudioListener; // 0x18

	// Properties
	public static AkAudioListener TheSpatialAudioListener { get; }
	public static AkSpatialAudioListener.SpatialAudioListenerList SpatialAudioListeners { get; }

	// Methods

	// RVA: 0x20B76C0 Offset: 0x20B77C1 VA: 0x20B76C0
	public static AkAudioListener get_TheSpatialAudioListener() { }

	// RVA: 0x20D6AD0 Offset: 0x20D6BD1 VA: 0x20D6AD0
	public static AkSpatialAudioListener.SpatialAudioListenerList get_SpatialAudioListeners() { }

	// RVA: 0x20D6B40 Offset: 0x20D6C41 VA: 0x20D6B40
	private void Awake() { }

	// RVA: 0x20D6BB0 Offset: 0x20D6CB1 VA: 0x20D6BB0
	private void OnEnable() { }

	// RVA: 0x20D6C30 Offset: 0x20D6D31 VA: 0x20D6C30
	private void OnDisable() { }

	// RVA: 0x20D6CB0 Offset: 0x20D6DB1 VA: 0x20D6CB0
	public void .ctor() { }

	// RVA: 0x20D6CC0 Offset: 0x20D6DC1 VA: 0x20D6CC0
	private static void .cctor() { }
}

