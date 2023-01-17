// Namespace: 
public abstract class WindActor : MonoBehaviour // TypeDefIndex: 7767
{
	// Fields
	public WindActor.Kind m_Kind; // 0x18
	[RangeAttribute] // RVA: 0x27CBE0 Offset: 0x27CCE1 VA: 0x27CBE0
	[TooltipAttribute] // RVA: 0x27CBE0 Offset: 0x27CCE1 VA: 0x27CBE0
	[SerializeField] // RVA: 0x27CBE0 Offset: 0x27CCE1 VA: 0x27CBE0
	public float m_Power; // 0x1C
	[SerializeField] // RVA: 0x27CC50 Offset: 0x27CD51 VA: 0x27CC50
	[RangeAttribute] // RVA: 0x27CC50 Offset: 0x27CD51 VA: 0x27CC50
	[TooltipAttribute] // RVA: 0x27CC50 Offset: 0x27CD51 VA: 0x27CC50
	public float m_Radius; // 0x20
	[RangeAttribute] // RVA: 0x27CCC0 Offset: 0x27CDC1 VA: 0x27CCC0
	[TooltipAttribute] // RVA: 0x27CCC0 Offset: 0x27CDC1 VA: 0x27CCC0
	[SerializeField] // RVA: 0x27CCC0 Offset: 0x27CDC1 VA: 0x27CCC0
	public float m_Life; // 0x24
	[TooltipAttribute] // RVA: 0x27CD30 Offset: 0x27CE31 VA: 0x27CD30
	[SerializeField] // RVA: 0x27CD30 Offset: 0x27CE31 VA: 0x27CD30
	[RangeAttribute] // RVA: 0x27CD30 Offset: 0x27CE31 VA: 0x27CD30
	public float m_Speed; // 0x28
	[SerializeField] // RVA: 0x27CDA0 Offset: 0x27CEA1 VA: 0x27CDA0
	[TooltipAttribute] // RVA: 0x27CDA0 Offset: 0x27CEA1 VA: 0x27CDA0
	[RangeAttribute] // RVA: 0x27CDA0 Offset: 0x27CEA1 VA: 0x27CDA0
	public float m_Angle; // 0x2C
	[SerializeField] // RVA: 0x27CE10 Offset: 0x27CF11 VA: 0x27CE10
	[TooltipAttribute] // RVA: 0x27CE10 Offset: 0x27CF11 VA: 0x27CE10
	public Vector2 m_Range; // 0x30
	private float m_Time; // 0x38
	private WindActor.Func[] m_Funcs; // 0x40

	// Methods

	// RVA: 0x26D78E0 Offset: 0x26D79E1 VA: 0x26D78E0
	private Vector3 FuncNone(Vector3 pos) { }

	// RVA: 0x26D78F0 Offset: 0x26D79F1 VA: 0x26D78F0
	private Vector3 FuncDirectional(Vector3 pos) { }

	// RVA: 0x26D7AA0 Offset: 0x26D7BA1 VA: 0x26D7AA0
	private Vector3 FuncSphere(Vector3 pos) { }

	// RVA: 0x26D7C60 Offset: 0x26D7D61 VA: 0x26D7C60
	private void Awake() { }

	// RVA: 0x26D7E30 Offset: 0x26D7F31 VA: 0x26D7E30
	private void Start() { }

	// RVA: 0x26D7E40 Offset: 0x26D7F41 VA: 0x26D7E40
	private void Update() { }

	// RVA: 0x26D7F50 Offset: 0x26D8051 VA: 0x26D7F50
	public Vector3 Calculate(Vector3 pos) { }

	// RVA: 0x26D7F90 Offset: 0x26D8091 VA: 0x26D7F90
	private void OnDrawGizmos() { }

	// RVA: 0x26D8360 Offset: 0x26D8461 VA: 0x26D8360
	private void OnEnable() { }

	// RVA: 0x26D8490 Offset: 0x26D8591 VA: 0x26D8490
	private void OnDisable() { }

	// RVA: 0x26D80E0 Offset: 0x26D81E1 VA: 0x26D80E0
	public static void DrawWind(Vector3 pos, Vector3 dir, Color color) { }

	// RVA: 0x26D85C0 Offset: 0x26D86C1 VA: 0x26D85C0
	protected void .ctor() { }
}

