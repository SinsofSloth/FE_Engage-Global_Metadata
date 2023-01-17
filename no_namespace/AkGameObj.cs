// Namespace: 
[AddComponentMenu] // RVA: 0x271BC0 Offset: 0x271CC1 VA: 0x271BC0
[DisallowMultipleComponent] // RVA: 0x271BC0 Offset: 0x271CC1 VA: 0x271BC0
[ExecuteInEditMode] // RVA: 0x271BC0 Offset: 0x271CC1 VA: 0x271BC0
public class AkGameObj_Bridge : AkGameObj // TypeDefIndex: 7816
{
	// Methods

	// RVA: 0x3177590 Offset: 0x3177691 VA: 0x3177590
	public void .ctor() { }
}

// Namespace: 
[DefaultExecutionOrder] // RVA: 0x2725E0 Offset: 0x2726E1 VA: 0x2725E0
[AddComponentMenu] // RVA: 0x2725E0 Offset: 0x2726E1 VA: 0x2725E0
[DisallowMultipleComponent] // RVA: 0x2725E0 Offset: 0x2726E1 VA: 0x2725E0
[ExecuteInEditMode] // RVA: 0x2725E0 Offset: 0x2726E1 VA: 0x2725E0
public class AkGameObj : MonoBehaviour // TypeDefIndex: 8023
{
	// Fields
	[SerializeField] // RVA: 0x27EC00 Offset: 0x27ED01 VA: 0x27EC00
	private AkGameObjListenerList m_listeners; // 0x18
	public bool isEnvironmentAware; // 0x20
	[SerializeField] // RVA: 0x27EC10 Offset: 0x27ED11 VA: 0x27EC10
	private bool isStaticObject; // 0x21
	private Collider m_Collider; // 0x28
	private AkGameObjEnvironmentData m_envData; // 0x30
	private AkGameObjPositionData m_posData; // 0x38
	public AkGameObjPositionOffsetData m_positionOffsetData; // 0x40
	private bool isRegistered; // 0x48
	[SerializeField] // RVA: 0x27EC20 Offset: 0x27ED21 VA: 0x27EC20
	[HideInInspector] // RVA: 0x27EC20 Offset: 0x27ED21 VA: 0x27EC20
	private AkGameObjPosOffsetData m_posOffsetData; // 0x50
	private const int AK_NUM_LISTENERS = 8;
	[SerializeField] // RVA: 0x27EC60 Offset: 0x27ED61 VA: 0x27EC60
	[HideInInspector] // RVA: 0x27EC60 Offset: 0x27ED61 VA: 0x27EC60
	private int listenerMask; // 0x58

	// Properties
	public bool IsUsingDefaultListeners { get; }
	public List<AkAudioListener> ListenerList { get; }

	// Methods

	// RVA: 0x3171A00 Offset: 0x3171B01 VA: 0x3171A00
	public bool get_IsUsingDefaultListeners() { }

	// RVA: 0x3171A10 Offset: 0x3171B11 VA: 0x3171A10
	public List<AkAudioListener> get_ListenerList() { }

	// RVA: 0x3175830 Offset: 0x3175931 VA: 0x3175830
	internal void AddListener(AkAudioListener listener) { }

	// RVA: 0x3175840 Offset: 0x3175941 VA: 0x3175840
	internal void RemoveListener(AkAudioListener listener) { }

	// RVA: 0x3175850 Offset: 0x3175951 VA: 0x3175850
	public AKRESULT Register() { }

	// RVA: 0x3175900 Offset: 0x3175A01 VA: 0x3175900
	private void SetPosition() { }

	// RVA: 0x3175AB0 Offset: 0x3175BB1 VA: 0x3175AB0
	private void Awake() { }

	// RVA: 0x3176110 Offset: 0x3176211 VA: 0x3176110
	private void CheckStaticStatus() { }

	// RVA: 0x3176120 Offset: 0x3176221 VA: 0x3176120
	private void OnEnable() { }

	// RVA: 0x3176140 Offset: 0x3176241 VA: 0x3176140
	private void OnDestroy() { }

	// RVA: 0x31762D0 Offset: 0x31763D1 VA: 0x31762D0
	private void Update() { }

	// RVA: 0x3176350 Offset: 0x3176451 VA: 0x3176350 Slot: 4
	public virtual Vector3 GetPosition() { }

	// RVA: 0x31763E0 Offset: 0x31764E1 VA: 0x31763E0 Slot: 5
	public virtual Vector3 GetForward() { }

	// RVA: 0x3176400 Offset: 0x3176501 VA: 0x3176400 Slot: 6
	public virtual Vector3 GetUpward() { }

	// RVA: 0x3176420 Offset: 0x3176521 VA: 0x3176420
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x3176440 Offset: 0x3176541 VA: 0x3176440
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x31767F0 Offset: 0x31768F1 VA: 0x31767F0
	public void .ctor() { }
}

