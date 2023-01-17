// Namespace: 
public class AkAudioListener.BaseListenerList // TypeDefIndex: 8005
{
	// Fields
	private readonly List<ulong> listenerIdList; // 0x10
	private readonly List<AkAudioListener> listenerList; // 0x18

	// Properties
	public List<AkAudioListener> ListenerList { get; }

	// Methods

	// RVA: 0x24B0AC0 Offset: 0x24B0BC1 VA: 0x24B0AC0
	public List<AkAudioListener> get_ListenerList() { }

	// RVA: 0x24B0AD0 Offset: 0x24B0BD1 VA: 0x24B0AD0 Slot: 4
	public virtual bool Add(AkAudioListener listener) { }

	// RVA: 0x24B0BE0 Offset: 0x24B0CE1 VA: 0x24B0BE0 Slot: 5
	public virtual bool Remove(AkAudioListener listener) { }

	// RVA: 0x24B0CC0 Offset: 0x24B0DC1 VA: 0x24B0CC0
	public ulong[] GetListenerIds() { }

	// RVA: 0x24B0D20 Offset: 0x24B0E21 VA: 0x24B0D20
	public void .ctor() { }
}

// Namespace: 
public class AkAudioListener.DefaultListenerList : AkAudioListener.BaseListenerList // TypeDefIndex: 8006
{
	// Methods

	// RVA: 0x24B0E00 Offset: 0x24B0F01 VA: 0x24B0E00 Slot: 4
	public override bool Add(AkAudioListener listener) { }

	// RVA: 0x24B0ED0 Offset: 0x24B0FD1 VA: 0x24B0ED0 Slot: 5
	public override bool Remove(AkAudioListener listener) { }

	// RVA: 0x24B0FA0 Offset: 0x24B10A1 VA: 0x24B0FA0
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu] // RVA: 0x272040 Offset: 0x272141 VA: 0x272040
[DisallowMultipleComponent] // RVA: 0x272040 Offset: 0x272141 VA: 0x272040
[DefaultExecutionOrder] // RVA: 0x272040 Offset: 0x272141 VA: 0x272040
[RequireComponent] // RVA: 0x272040 Offset: 0x272141 VA: 0x272040
public class AkAudioListener : MonoBehaviour // TypeDefIndex: 8007
{
	// Fields
	private static readonly AkAudioListener.DefaultListenerList defaultListeners; // 0x0
	private ulong akGameObjectID; // 0x18
	private List<AkGameObj> EmittersToStartListeningTo; // 0x20
	private List<AkGameObj> EmittersToStopListeningTo; // 0x28
	public bool isDefaultListener; // 0x30
	[SerializeField] // RVA: 0x27E850 Offset: 0x27E951 VA: 0x27E850
	public int listenerId; // 0x34

	// Properties
	public static AkAudioListener.DefaultListenerList DefaultListeners { get; }

	// Methods

	// RVA: 0x2ECF920 Offset: 0x2ECFA21 VA: 0x2ECF920
	public static AkAudioListener.DefaultListenerList get_DefaultListeners() { }

	// RVA: 0x2ECF990 Offset: 0x2ECFA91 VA: 0x2ECF990
	public void StartListeningToEmitter(AkGameObj emitter) { }

	// RVA: 0x2ECFA20 Offset: 0x2ECFB21 VA: 0x2ECFA20
	public void StopListeningToEmitter(AkGameObj emitter) { }

	// RVA: 0x2ECFAB0 Offset: 0x2ECFBB1 VA: 0x2ECFAB0
	public void SetIsDefaultListener(bool isDefault) { }

	// RVA: 0x2ECFC40 Offset: 0x2ECFD41 VA: 0x2ECFC40
	private void Awake() { }

	// RVA: 0x2ECFD30 Offset: 0x2ECFE31 VA: 0x2ECFD30
	private void OnEnable() { }

	// RVA: 0x2ECFE20 Offset: 0x2ECFF21 VA: 0x2ECFE20
	private void OnDisable() { }

	// RVA: 0x2ECFF10 Offset: 0x2ED0011 VA: 0x2ECFF10
	private void Update() { }

	// RVA: 0x2ED0040 Offset: 0x2ED0141 VA: 0x2ED0040
	public ulong GetAkGameObjectID() { }

	// RVA: 0x2ED0050 Offset: 0x2ED0151 VA: 0x2ED0050
	public void Migrate14() { }

	// RVA: 0x2ED0110 Offset: 0x2ED0211 VA: 0x2ED0110
	public void .ctor() { }

	// RVA: 0x2ED01D0 Offset: 0x2ED02D1 VA: 0x2ED01D0
	private static void .cctor() { }
}

