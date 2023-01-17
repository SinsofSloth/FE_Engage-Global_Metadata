// Namespace: 
[AddComponentMenu] // RVA: 0x271B30 Offset: 0x271C31 VA: 0x271B30
[RequireComponent] // RVA: 0x271B30 Offset: 0x271C31 VA: 0x271B30
public class AkEvent_Bridge : AkEvent // TypeDefIndex: 7815
{
	// Methods

	// RVA: 0x3174840 Offset: 0x3174941 VA: 0x3174840
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AkEvent.CallbackData // TypeDefIndex: 8016
{
	// Fields
	public CallbackFlags Flags; // 0x10
	public string FunctionName; // 0x18
	public GameObject GameObject; // 0x20

	// Methods

	// RVA: 0x24B35F0 Offset: 0x24B36F1 VA: 0x24B35F0
	public void CallFunction(AkEventCallbackMsg eventCallbackMsg) { }

	// RVA: 0x24B36B0 Offset: 0x24B37B1 VA: 0x24B36B0
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu] // RVA: 0x2723C0 Offset: 0x2724C1 VA: 0x2723C0
[RequireComponent] // RVA: 0x2723C0 Offset: 0x2724C1 VA: 0x2723C0
public class AkEvent : AkDragDropTriggerHandler // TypeDefIndex: 8017
{
	// Fields
	public AkActionOnEventType actionOnEventType; // 0x2C
	public AkCurveInterpolation curveInterpolation; // 0x30
	public bool enableActionOnEvent; // 0x34
	public Event data; // 0x38
	public bool useCallbacks; // 0x40
	public List<AkEvent.CallbackData> Callbacks; // 0x48
	public uint playingId; // 0x50
	public GameObject soundEmitterObject; // 0x58
	public float transitionDuration; // 0x60
	private AkEventCallbackMsg EventCallbackMsg; // 0x68
	[SerializeField] // RVA: 0x27EA90 Offset: 0x27EB91 VA: 0x27EA90
	[FormerlySerializedAsAttribute] // RVA: 0x27EA90 Offset: 0x27EB91 VA: 0x27EA90
	[HideInInspector] // RVA: 0x27EA90 Offset: 0x27EB91 VA: 0x27EA90
	private int eventIdInternal; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x27EAF0 Offset: 0x27EBF1 VA: 0x27EAF0
	[HideInInspector] // RVA: 0x27EAF0 Offset: 0x27EBF1 VA: 0x27EAF0
	[SerializeField] // RVA: 0x27EAF0 Offset: 0x27EBF1 VA: 0x27EAF0
	private byte[] valueGuidInternal; // 0x78
	[HideInInspector] // RVA: 0x27EB50 Offset: 0x27EC51 VA: 0x27EB50
	[SerializeField] // RVA: 0x27EB50 Offset: 0x27EC51 VA: 0x27EB50
	[FormerlySerializedAsAttribute] // RVA: 0x27EB50 Offset: 0x27EC51 VA: 0x27EB50
	private AkEventCallbackData m_callbackDataInternal; // 0x80

	// Properties
	protected override BaseType WwiseType { get; }
	[ObsoleteAttribute] // RVA: 0x2D4900 Offset: 0x2D4A01 VA: 0x2D4900
	public int eventID { get; }
	[ObsoleteAttribute] // RVA: 0x2D4940 Offset: 0x2D4A41 VA: 0x2D4940
	public byte[] valueGuid { get; }
	[ObsoleteAttribute] // RVA: 0x2D4980 Offset: 0x2D4A81 VA: 0x2D4980
	public AkEventCallbackData m_callbackData { get; }

	// Methods

	// RVA: 0x31724F0 Offset: 0x31725F1 VA: 0x31724F0 Slot: 9
	protected override BaseType get_WwiseType() { }

	// RVA: 0x3172500 Offset: 0x3172601 VA: 0x3172500 Slot: 6
	protected override void Start() { }

	// RVA: 0x31725B0 Offset: 0x31726B1 VA: 0x31725B0
	private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }

	// RVA: 0x3172680 Offset: 0x3172781 VA: 0x3172680 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x3172920 Offset: 0x3172A21 VA: 0x3172920
	public void Stop(int _transitionDuration) { }

	// RVA: 0x3172940 Offset: 0x3172A41 VA: 0x3172940
	public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation) { }

	// RVA: 0x3172960 Offset: 0x3172A61 VA: 0x3172960
	public int get_eventID() { }

	// RVA: 0x3172980 Offset: 0x3172A81 VA: 0x3172980
	public byte[] get_valueGuid() { }

	// RVA: 0x3172A40 Offset: 0x3172B41 VA: 0x3172A40
	public AkEventCallbackData get_m_callbackData() { }

	// RVA: 0x3172A50 Offset: 0x3172B51 VA: 0x3172A50
	public void .ctor() { }
}

