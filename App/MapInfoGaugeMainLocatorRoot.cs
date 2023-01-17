// Namespace: App
public class MapInfoGaugeMainLocatorRoot : MapInfoBase // TypeDefIndex: 9015
{
	// Fields
	private GameObject m_MainLocatorRoot; // 0x20
	private MapInfoGaugeSubLocatorRoot[] m_SubLocatorRoots; // 0x28
	private MapInfoGaugeSubLocatorRoot m_SubLocatorRoot; // 0x30

	// Properties
	public MapInfoGaugeSubLocatorRoot SubLocatorRoot { get; }
	public bool IsComplete { get; set; }

	// Methods

	// RVA: 0x2481AD0 Offset: 0x2481BD1 VA: 0x2481AD0
	private void Awake() { }

	// RVA: 0x2481B60 Offset: 0x2481C61 VA: 0x2481B60
	public void UpdatePosition(Unit unit) { }

	// RVA: 0x2481F80 Offset: 0x2482081 VA: 0x2481F80
	public void UpdateParam(Unit unit) { }

	// RVA: 0x2481BA0 Offset: 0x2481CA1 VA: 0x2481BA0
	private bool IsSetPosition() { }

	// RVA: 0x2481FC0 Offset: 0x24820C1 VA: 0x2481FC0
	private bool IsSetParam() { }

	// RVA: 0x24820C0 Offset: 0x24821C1 VA: 0x24820C0
	private void SetIcon(Unit unit) { }

	// RVA: 0x24822F0 Offset: 0x24823F1 VA: 0x24822F0
	public void DeleteDisuseLocatorRoot(Unit unit) { }

	// RVA: 0x2482680 Offset: 0x2482781 VA: 0x2482680
	public MapInfoGaugeSubLocatorRoot get_SubLocatorRoot() { }

	// RVA: 0x2482690 Offset: 0x2482791 VA: 0x2482690
	public bool IsDisplayOutside(Unit unit, float width, float height, Camera camera) { }

	// RVA: 0x2484080 Offset: 0x2484181 VA: 0x2484080
	public void InitHpForecast() { }

	// RVA: 0x24840A0 Offset: 0x24841A1 VA: 0x24840A0
	public void SetHpForecast(int before, int after) { }

	// RVA: 0x24840C0 Offset: 0x24841C1 VA: 0x24840C0
	public void InitBreak() { }

	// RVA: 0x24840E0 Offset: 0x24841E1 VA: 0x24840E0
	public void SetBreak(bool isBreak) { }

	// RVA: 0x24840F0 Offset: 0x24841F1 VA: 0x24840F0
	public bool get_IsComplete() { }

	// RVA: 0x2484100 Offset: 0x2484201 VA: 0x2484100
	public void set_IsComplete(bool value) { }

	// RVA: 0x2484110 Offset: 0x2484211 VA: 0x2484110
	public void .ctor() { }
}

