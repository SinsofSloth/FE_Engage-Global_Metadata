// Namespace: App
public class HubMoveController // TypeDefIndex: 10744
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294C90 Offset: 0x294D91 VA: 0x294C90
	private bool <IsPause>k__BackingField; // 0x10
	private HubUnitController m_unit; // 0x18
	private List<HubMoveState> m_State; // 0x20
	private HubMoveState m_current; // 0x28
	private int m_ActiveIndex; // 0x30

	// Properties
	public bool IsPause { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0B90 Offset: 0x2C0C91 VA: 0x2C0B90
	// RVA: 0x2BEECA0 Offset: 0x2BEEDA1 VA: 0x2BEECA0
	public bool get_IsPause() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0BA0 Offset: 0x2C0CA1 VA: 0x2C0BA0
	// RVA: 0x2BEECB0 Offset: 0x2BEEDB1 VA: 0x2BEECB0
	public void set_IsPause(bool value) { }

	// RVA: 0x2BEECC0 Offset: 0x2BEEDC1 VA: 0x2BEECC0
	public void .ctor(HubUnitController unit, StructDataArrayList<HubMoveData> moveData) { }

	// RVA: 0x2BEF640 Offset: 0x2BEF741 VA: 0x2BEF640
	public void Update() { }

	// RVA: 0x2BEF770 Offset: 0x2BEF871 VA: 0x2BEF770
	public void Pause(bool force) { }

	// RVA: 0x2BEF810 Offset: 0x2BEF911 VA: 0x2BEF810
	public void Resume() { }

	// RVA: 0x2BEF580 Offset: 0x2BEF681 VA: 0x2BEF580
	private HubMoveState SelectState() { }

	// RVA: 0x2BEF310 Offset: 0x2BEF411 VA: 0x2BEF310
	private Vector3 TryGetPosition(string locatorName) { }

	// RVA: 0x2BEF3C0 Offset: 0x2BEF4C1 VA: 0x2BEF3C0
	private HubMoveState GetState(HubMoveData data) { }

	[ConditionalAttribute] // RVA: 0x2C0BB0 Offset: 0x2C0CB1 VA: 0x2C0BB0
	// RVA: 0x2BEF900 Offset: 0x2BEFA01 VA: 0x2BEF900
	public void OnDrawGizmos() { }
}

