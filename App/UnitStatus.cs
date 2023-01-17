// Namespace: App
public class UnitStatus : SingletonProcInst<UnitStatus> // TypeDefIndex: 11876
{
	// Fields
	private const string ResNameC = "UI/Common/UnitInfo/Prefabs/UnitStatus";
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x78
	private static GameObject m_GameObject; // 0x0

	// Methods

	// RVA: 0x2093AF0 Offset: 0x2093BF1 VA: 0x2093AF0
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x2093C50 Offset: 0x2093D51 VA: 0x2093C50
	private static void CreateImpl(ProcInst super, UnitStatus p) { }

	// RVA: 0x2093C90 Offset: 0x2093D91 VA: 0x2093C90
	private static ProcDesc[] CreateDescs(UnitStatus p) { }

	// RVA: 0x2093F70 Offset: 0x2094071 VA: 0x2093F70
	public void CreateAsync() { }

	// RVA: 0x2094040 Offset: 0x2094141 VA: 0x2094040
	public bool IsCreating() { }

	// RVA: 0x2094070 Offset: 0x2094171 VA: 0x2094070
	public void Prepare() { }

	// RVA: 0x20941A0 Offset: 0x20942A1 VA: 0x20941A0
	public void Tick() { }

	// RVA: 0x2094310 Offset: 0x2094411 VA: 0x2094310
	public static void StartJobIntro(Unit unit) { }

	// RVA: 0x20944C0 Offset: 0x20945C1 VA: 0x20944C0
	public static void StartUnitSelect(Unit unit, bool isSortie) { }

	// RVA: 0x2094680 Offset: 0x2094781 VA: 0x2094680
	public static void Close() { }

	// RVA: 0x2091EC0 Offset: 0x2091FC1 VA: 0x2091EC0
	public static void SetUnit(Unit unit) { }

	// RVA: 0x2094E40 Offset: 0x2094F41 VA: 0x2094E40
	public static void SetFront() { }

	// RVA: 0x2094EA0 Offset: 0x2094FA1 VA: 0x2094EA0
	public static GameObject GetGameObject() { }

	// RVA: 0x2093BD0 Offset: 0x2093CD1 VA: 0x2093BD0
	public void .ctor() { }
}

