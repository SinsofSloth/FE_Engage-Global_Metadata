// Namespace: App
public class MapInspectors : SingletonClass<MapInspectors> // TypeDefIndex: 12163
{
	// Fields
	private List<MapInspector> m_Inspectors; // 0x20
	private List<MapInspector>[] m_KindInspectors; // 0x28
	private static MapInspectors.MapInspectorSearch s_InspectorSearch; // 0x0

	// Properties
	public static List<MapInspector> Inspectors { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2200200 Offset: 0x2200301 VA: 0x2200200
	public static List<MapInspector> get_Inspectors() { }

	// RVA: 0x2200280 Offset: 0x2200381 VA: 0x2200280
	public static List<MapInspector> GetKindInspectors(MapInspector.Kind kind) { }

	// RVA: 0x2200330 Offset: 0x2200431 VA: 0x2200330
	public void .ctor() { }

	// RVA: 0x22004E0 Offset: 0x22005E1 VA: 0x22004E0
	private void ClearImpl() { }

	// RVA: 0x2200590 Offset: 0x2200691 VA: 0x2200590
	private void AddImpl(MapInspector inspector) { }

	// RVA: 0x2200620 Offset: 0x2200721 VA: 0x2200620
	public static MapInspector Add(MapInspector inspector) { }

	// RVA: 0x2200730 Offset: 0x2200831 VA: 0x2200730
	public static void Clear() { }

	// RVA: 0x22007C0 Offset: 0x22008C1 VA: 0x22007C0
	public static Stack<MapInspector> GetEnableInspectors(MapInspector.Kind kind, Unit unit, int arg1 = 0, int arg2 = 0, int arg3 = 0, int arg4 = 0) { }

	// RVA: 0x2200870 Offset: 0x2200971 VA: 0x2200870
	public static MapInspector GetEnableInspector(MapInspector.Kind kind, Unit unit, int arg1 = 0, int arg2 = 0, int arg3 = 0, int arg4 = 0) { }

	// RVA: 0x2200920 Offset: 0x2200A21 VA: 0x2200920
	public static PokeInspector GetPokeInspector(int x, int z) { }

	// RVA: 0x22009F0 Offset: 0x2200AF1 VA: 0x22009F0
	public static PokeInspector GetPokeInspector(MapInspector.Kind kind, int x, int z) { }

	// RVA: 0x2200A80 Offset: 0x2200B81 VA: 0x2200A80
	public static bool IsEnable(MapInspector.Kind kind, int x, int z) { }

	// RVA: 0x2200B70 Offset: 0x2200C71 VA: 0x2200B70
	public static bool IsEnable(MapInspector.Kind kind, Unit unit) { }

	// RVA: 0x2200C90 Offset: 0x2200D91 VA: 0x2200C90
	public static bool IsEnable(MapInspector.Kind kind, int x, int z, Unit unit) { }

	// RVA: 0x2200DC0 Offset: 0x2200EC1 VA: 0x2200DC0
	public static bool IsEnable(MapInspector.Kind kind, Unit from, Unit to) { }

	// RVA: 0x2200F10 Offset: 0x2201011 VA: 0x2200F10
	public static PokeInspector FindBreakable(int x, int z) { }

	// RVA: 0x2201180 Offset: 0x2201281 VA: 0x2201180
	public static bool IsBreakable(int x, int z) { }

	// RVA: 0x2201200 Offset: 0x2201301 VA: 0x2201200
	public static CannonInspector FindCannon(int x, int z) { }

	// RVA: -1 Offset: -1
	public static T TryCreateInspector<T>(int x, int z, int w, int h) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295CA60 Offset: 0x295CB61 VA: 0x295CA60
	|-MapInspectors.TryCreateInspector<DestroyInspector>
	|-MapInspectors.TryCreateInspector<DoorInspector>
	|-MapInspectors.TryCreateInspector<HelpSpotInspector>
	|-MapInspectors.TryCreateInspector<object>
	|-MapInspectors.TryCreateInspector<TboxInspector>
	|-MapInspectors.TryCreateInspector<TorchInspector>
	|-MapInspectors.TryCreateInspector<VisitInspector>
	*/

	// RVA: 0x2201470 Offset: 0x2201571 VA: 0x2201470
	private static CannonInspector TryCreateCannonInspector(int x, int z, int maxShells) { }

	// RVA: 0x2201760 Offset: 0x2201861 VA: 0x2201760
	private static void CalcLayerSize(ref int x, ref int z, ref int w, ref int h) { }

	// RVA: 0x22019A0 Offset: 0x2201AA1 VA: 0x22019A0
	public static void Regist() { }

	// RVA: 0x2201B30 Offset: 0x2201C31 VA: 0x2201B30 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2201B40 Offset: 0x2201C41 VA: 0x2201B40 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2201B50 Offset: 0x2201C51 VA: 0x2201B50 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2201B60 Offset: 0x2201C61 VA: 0x2201B60
	private static void .cctor() { }
}

