// Namespace: 
[ExecuteInEditMode] // RVA: 0x271AE0 Offset: 0x271BE1 VA: 0x271AE0
[AddComponentMenu] // RVA: 0x271AE0 Offset: 0x271BE1 VA: 0x271AE0
public class AkBank_Bridge : AkBank // TypeDefIndex: 7814
{
	// Methods

	// RVA: 0x2ED3200 Offset: 0x2ED3301 VA: 0x2ED3200 Slot: 6
	protected override void Start() { }

	// RVA: 0x2ED3290 Offset: 0x2ED3391 VA: 0x2ED3290
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu] // RVA: 0x2720F0 Offset: 0x2721F1 VA: 0x2720F0
[ExecuteInEditMode] // RVA: 0x2720F0 Offset: 0x2721F1 VA: 0x2720F0
[DefaultExecutionOrder] // RVA: 0x2720F0 Offset: 0x2721F1 VA: 0x2720F0
public class AkBank : AkTriggerHandler // TypeDefIndex: 8008
{
	// Fields
	public Bank data; // 0x30
	public bool decodeBank; // 0x38
	public bool loadAsynchronous; // 0x39
	public bool saveDecodedBank; // 0x3A
	public List<int> unloadTriggerList; // 0x40
	[SerializeField] // RVA: 0x27E860 Offset: 0x27E961 VA: 0x27E860
	[FormerlySerializedAsAttribute] // RVA: 0x27E860 Offset: 0x27E961 VA: 0x27E860
	[HideInInspector] // RVA: 0x27E860 Offset: 0x27E961 VA: 0x27E860
	private string bankNameInternal; // 0x48
	[SerializeField] // RVA: 0x27E8C0 Offset: 0x27E9C1 VA: 0x27E8C0
	[HideInInspector] // RVA: 0x27E8C0 Offset: 0x27E9C1 VA: 0x27E8C0
	[FormerlySerializedAsAttribute] // RVA: 0x27E8C0 Offset: 0x27E9C1 VA: 0x27E8C0
	private byte[] valueGuidInternal; // 0x50

	// Properties
	[ObsoleteAttribute] // RVA: 0x2D4800 Offset: 0x2D4901 VA: 0x2D4800
	public string bankName { get; }
	[ObsoleteAttribute] // RVA: 0x2D4840 Offset: 0x2D4941 VA: 0x2D4840
	public byte[] valueGuid { get; }

	// Methods

	// RVA: 0x2ED1E00 Offset: 0x2ED1F01 VA: 0x2ED1E00 Slot: 5
	protected override void Awake() { }

	// RVA: 0x2ED1EA0 Offset: 0x2ED1FA1 VA: 0x2ED1EA0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2ED1F40 Offset: 0x2ED2041 VA: 0x2ED1F40 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x2ED1F30 Offset: 0x2ED2031 VA: 0x2ED1F30
	public void UnloadBank(GameObject in_gameObject) { }

	// RVA: 0x2ED1F70 Offset: 0x2ED2071 VA: 0x2ED1F70 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x2ED2010 Offset: 0x2ED2111 VA: 0x2ED2010
	public string get_bankName() { }

	// RVA: 0x2ED2080 Offset: 0x2ED2181 VA: 0x2ED2080
	public byte[] get_valueGuid() { }

	// RVA: 0x2ED2140 Offset: 0x2ED2241 VA: 0x2ED2140
	public void .ctor() { }
}

