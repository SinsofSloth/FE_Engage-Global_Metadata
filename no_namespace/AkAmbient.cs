// Namespace: 
[AddComponentMenu] // RVA: 0x272000 Offset: 0x272101 VA: 0x272000
public class AkAmbient : AkEvent // TypeDefIndex: 8003
{
	// Fields
	public static Dictionary<uint, AkMultiPosEvent> multiPosEventTree; // 0x0
	public AkMultiPositionType MultiPositionType; // 0x88
	public MultiPositionTypeLabel multiPositionTypeLabel; // 0x8C
	public AkAmbientLargeModePositioner[] LargeModePositions; // 0x90
	private static uint EmitterPosCountMax; // 0x8
	private Vector3[] EmitterPosArray; // 0x98
	private Vector3[] EmitterFowardArray; // 0xA0
	private Vector3[] EmitterUpArray; // 0xA8
	private AkPositionArray PositionArray; // 0xB0
	private List<AkAmbientLargeModePositioner> ValidPositionList; // 0xB8
	[SerializeField] // RVA: 0x27E810 Offset: 0x27E911 VA: 0x27E810
	[HideInInspector] // RVA: 0x27E810 Offset: 0x27E911 VA: 0x27E810
	public List<Vector3> multiPositionArray; // 0xC0

	// Methods

	// RVA: 0x2ECC4D0 Offset: 0x2ECC5D1 VA: 0x2ECC4D0 Slot: 8
	public override void OnEnable() { }

	// RVA: 0x2ECC960 Offset: 0x2ECCA61 VA: 0x2ECC960 Slot: 6
	protected override void Start() { }

	// RVA: 0x2ECCE00 Offset: 0x2ECCF01 VA: 0x2ECCE00
	private void OnDisable() { }

	// RVA: 0x2ECCFF0 Offset: 0x2ECD0F1 VA: 0x2ECCFF0 Slot: 4
	public override void HandleEvent(GameObject in_gameObject) { }

	// RVA: 0x2ECD1F0 Offset: 0x2ECD2F1 VA: 0x2ECD1F0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x2ECD260 Offset: 0x2ECD361 VA: 0x2ECD260
	private void Update() { }

	// RVA: 0x2ECD4A0 Offset: 0x2ECD5A1 VA: 0x2ECD4A0
	public bool CalcLenearPoints(Vector3 inputPos, ref int emitterPosCount, ref Vector3[] outputPosArray, ref Vector3[] outputFowardArray, ref Vector3[] outputUpArray) { }

	// RVA: 0x2ECC7A0 Offset: 0x2ECC8A1 VA: 0x2ECC7A0
	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList) { }

	// RVA: 0x2ECCB10 Offset: 0x2ECCC11 VA: 0x2ECCB10
	private AkPositionArray BuildAkPositionArray() { }

	// RVA: 0x2ECDA80 Offset: 0x2ECDB81 VA: 0x2ECDA80
	public void .ctor() { }

	// RVA: 0x2ECDC10 Offset: 0x2ECDD11 VA: 0x2ECDC10
	private static void .cctor() { }
}

