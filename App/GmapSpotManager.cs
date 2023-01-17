// Namespace: App
public class GmapSpotManager : SingletonClass<GmapSpotManager> // TypeDefIndex: 10355
{
	// Fields
	private GmapSpot[] m_SpotArray; // 0x20
	private static readonly int EncountMobMax; // 0x0
	private const string StateFlagNameM017 = "G_GmapSpot_半壊_M017";

	// Methods

	// RVA: 0x2CF4370 Offset: 0x2CF4471 VA: 0x2CF4370 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2CE60D0 Offset: 0x2CE61D1 VA: 0x2CE60D0
	public void AttachChapterToSpot() { }

	// RVA: 0x2CE83E0 Offset: 0x2CE84E1 VA: 0x2CE83E0
	public void AttachModels() { }

	// RVA: 0x2CF4380 Offset: 0x2CF4481 VA: 0x2CF4380
	private void AttachModelsChapter(GmapSpot spot) { }

	// RVA: 0x2CE8450 Offset: 0x2CE8551 VA: 0x2CE8450
	public void SetNextSpots(GmapPathCollection paths) { }

	// RVA: 0x2CE3B30 Offset: 0x2CE3C31 VA: 0x2CE3B30
	public GmapSpot CheckChange() { }

	// RVA: 0x2CE73F0 Offset: 0x2CE74F1 VA: 0x2CE73F0
	public GmapSpot FindSpotBySpotID(string spotID) { }

	// RVA: 0x2CF4620 Offset: 0x2CF4721 VA: 0x2CF4620
	public GmapSpot FindSpotByCID(string cid) { }

	// RVA: 0x2CF4730 Offset: 0x2CF4831 VA: 0x2CF4730
	public GmapSpot FindSpot(ChapterData chapter) { }

	// RVA: 0x2CEB5A0 Offset: 0x2CEB6A1 VA: 0x2CEB5A0
	public GmapSpot GetNewestSpot() { }

	// RVA: 0x2CEBBD0 Offset: 0x2CEBCD1 VA: 0x2CEBBD0
	public GmapSpot GetEncountSpotOne() { }

	// RVA: 0x2CF48A0 Offset: 0x2CF49A1 VA: 0x2CF48A0
	public int GetEncountCount(GmapMode.Mode mode, EncountUnitData.RareType rareType) { }

	// RVA: 0x2CEBCE0 Offset: 0x2CEBDE1 VA: 0x2CEBCE0
	public GmapSpot GetSubSpotOne() { }

	// RVA: 0x2CEC100 Offset: 0x2CEC201 VA: 0x2CEC100
	public List<GmapSpot> GetRoute(GmapSpot start, GmapSpot end) { }

	// RVA: 0x2CE92C0 Offset: 0x2CE93C1 VA: 0x2CE92C0
	public void PutMobUnits() { }

	// RVA: 0x2CF4AC0 Offset: 0x2CF4BC1 VA: 0x2CF4AC0
	public void UnloadMobUnits() { }

	// RVA: 0x2CF4B50 Offset: 0x2CF4C51 VA: 0x2CF4B50
	private int GetSettableSpotCount() { }

	// RVA: 0x2CF4C50 Offset: 0x2CF4D51 VA: 0x2CF4C50
	public int GetDisposCount() { }

	// RVA: 0x2CF4CF0 Offset: 0x2CF4DF1 VA: 0x2CF4CF0
	private int CalculateDisposCount() { }

	// RVA: 0x2CF4DA0 Offset: 0x2CF4EA1 VA: 0x2CF4DA0
	public void SetDispos() { }

	// RVA: 0x2CF5230 Offset: 0x2CF5331 VA: 0x2CF5230
	private static void ForEachImpl(Func<GmapSpot, bool> cond, Action<GmapSpot> func) { }

	// RVA: 0x2CF4750 Offset: 0x2CF4851 VA: 0x2CF4750
	public static void ForEach(Action<GmapSpot> func) { }

	// RVA: 0x2CF4510 Offset: 0x2CF4611 VA: 0x2CF4510
	public static void ForEachOnGmap(GmapMode.Mode mode, Action<GmapSpot> func) { }

	// RVA: 0x2CF49B0 Offset: 0x2CF4AB1 VA: 0x2CF49B0
	public static void ForEachAtChapter(GmapMode.Mode mode, Action<GmapSpot> func) { }

	// RVA: 0x2CF5390 Offset: 0x2CF5491 VA: 0x2CF5390
	public static void SetState(string cid, GmapSpot.State state) { }

	// RVA: 0x2CF5700 Offset: 0x2CF5801 VA: 0x2CF5700
	public static string GetKizunaScriptName() { }

	// RVA: 0x2CE82E0 Offset: 0x2CE83E1 VA: 0x2CE82E0
	public static void InitActiveSpots() { }

	// RVA: 0x2CE95A0 Offset: 0x2CE96A1 VA: 0x2CE95A0
	public static void UpdateStateM017Model() { }

	// RVA: 0x2CEC8B0 Offset: 0x2CEC9B1 VA: 0x2CEC8B0
	public static void SetStateM017Model() { }

	// RVA: 0x2CF5750 Offset: 0x2CF5851 VA: 0x2CF5750
	public static void OpenNextChapters(ChapterData chapter) { }

	// RVA: 0x2CF5940 Offset: 0x2CF5A41 VA: 0x2CF5940 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2CF59B0 Offset: 0x2CF5AB1 VA: 0x2CF59B0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2CF59C0 Offset: 0x2CF5AC1 VA: 0x2CF59C0
	public void .ctor() { }

	// RVA: 0x2CF5A40 Offset: 0x2CF5B41 VA: 0x2CF5A40
	private static void .cctor() { }
}

