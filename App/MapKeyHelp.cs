// Namespace: App
public class MapKeyHelp : SingletonProcInst<MapKeyHelp> // TypeDefIndex: 12171
{
	// Fields
	private const float ShowTime = 0.5;
	private MapKeyHelp.Mode m_Mode; // 0x74
	private int m_TemporaryHidingCount; // 0x78
	private MapKeyHelp.Types m_LastType; // 0x7C
	private MapKeyHelp.Types m_RequestType; // 0x80
	private float m_Progress; // 0x84

	// Methods

	// RVA: 0x2208060 Offset: 0x2208161 VA: 0x2208060
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x2208490 Offset: 0x2208591 VA: 0x2208490
	public static bool IsCreating() { }

	// RVA: 0x22084A0 Offset: 0x22085A1 VA: 0x22084A0
	public static void Destroy() { }

	// RVA: 0x2208560 Offset: 0x2208661 VA: 0x2208560
	public MapKeyHelp.Types GetRequestType() { }

	// RVA: 0x2208570 Offset: 0x2208671 VA: 0x2208570
	public void RequestToChange(MapKeyHelp.Types type) { }

	// RVA: 0x2208610 Offset: 0x2208711 VA: 0x2208610
	public void ShowImmediate() { }

	// RVA: 0x2208620 Offset: 0x2208721 VA: 0x2208620
	public void Hide() { }

	// RVA: 0x22086B0 Offset: 0x22087B1 VA: 0x22086B0
	public void BeginTemporaryHiding() { }

	// RVA: 0x22086F0 Offset: 0x22087F1 VA: 0x22086F0
	public void EndTemporaryHiding(bool isResetMeasuring = False) { }

	// RVA: 0x2208760 Offset: 0x2208861 VA: 0x2208760 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x22087F0 Offset: 0x22088F1 VA: 0x22087F0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2208880 Offset: 0x2208981 VA: 0x2208880
	private void Measure() { }

	// RVA: 0x2208960 Offset: 0x2208A61 VA: 0x2208960
	private void Setup(MapKeyHelp.Types type) { }

	// RVA: 0x2208410 Offset: 0x2208511 VA: 0x2208410
	public void .ctor() { }
}

