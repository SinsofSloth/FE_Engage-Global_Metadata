// Namespace: App
public class GmapSpot // TypeDefIndex: 10342
{
	// Fields
	private string m_GlobalFlagName; // 0x10
	private List<ChapterData> m_Chapters; // 0x18
	private GameObject m_GameObject; // 0x20
	private GmapSpotController m_Controller; // 0x28
	private GameObject m_MapObject; // 0x30
	private GmapSpot[] m_NextSpots; // 0x38
	private GmapMobUnit m_MobUnit; // 0x40
	private EncountIcon m_EncountIcon; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28DDC0 Offset: 0x28DEC1 VA: 0x28DDC0
	private bool <ReserveDispos>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28DDD0 Offset: 0x28DED1 VA: 0x28DDD0
	private bool <ReserveDeleteMob>k__BackingField; // 0x51

	// Properties
	public EncountMob SpotMob { get; set; }
	public bool ReserveDispos { get; set; }
	public bool ReserveDeleteMob { get; set; }
	public GmapSpot.State SpotState { get; set; }
	public Vector3 Position { get; }
	public GameObject SpotObject { get; set; }
	public ChapterData Chapter { get; }
	public string GmapSpotID { get; }

	// Methods

	// RVA: 0x2CECD00 Offset: 0x2CECE01 VA: 0x2CECD00
	public EncountMob get_SpotMob() { }

	// RVA: 0x2CF0690 Offset: 0x2CF0791 VA: 0x2CF0690
	public void set_SpotMob(EncountMob value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDDB0 Offset: 0x2BDEB1 VA: 0x2BDDB0
	// RVA: 0x2CF07E0 Offset: 0x2CF08E1 VA: 0x2CF07E0
	public bool get_ReserveDispos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDDC0 Offset: 0x2BDEC1 VA: 0x2BDDC0
	// RVA: 0x2CF07F0 Offset: 0x2CF08F1 VA: 0x2CF07F0
	public void set_ReserveDispos(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDDD0 Offset: 0x2BDED1 VA: 0x2BDDD0
	// RVA: 0x2CF0800 Offset: 0x2CF0901 VA: 0x2CF0800
	public bool get_ReserveDeleteMob() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDDE0 Offset: 0x2BDEE1 VA: 0x2BDDE0
	// RVA: 0x2CF0810 Offset: 0x2CF0911 VA: 0x2CF0810
	public void set_ReserveDeleteMob(bool value) { }

	// RVA: 0x2CF0820 Offset: 0x2CF0921 VA: 0x2CF0820
	public void .ctor(ChapterData chapter) { }

	// RVA: 0x2CE3C80 Offset: 0x2CE3D81 VA: 0x2CE3C80
	public GmapSpot.State get_SpotState() { }

	// RVA: 0x2CF0930 Offset: 0x2CF0A31 VA: 0x2CF0930
	public void set_SpotState(GmapSpot.State value) { }

	// RVA: 0x2CF0B00 Offset: 0x2CF0C01 VA: 0x2CF0B00
	private void SetupSpotController() { }

	// RVA: 0x2CF1020 Offset: 0x2CF1121 VA: 0x2CF1020
	public void SetupMapObject(GameObject mapObject) { }

	// RVA: 0x2CF1030 Offset: 0x2CF1131 VA: 0x2CF1030
	public bool SetNextSpot(Vector3 nextSpotPos, string nextSpotId) { }

	// RVA: 0x2CEB2E0 Offset: 0x2CEB3E1 VA: 0x2CEB2E0
	public GmapSpot CheckNextSpot(GmapSpot.Direction dir) { }

	// RVA: 0x2CF1320 Offset: 0x2CF1421 VA: 0x2CF1320
	public bool ExistsEncountMob() { }

	// RVA: 0x2CF13A0 Offset: 0x2CF14A1 VA: 0x2CF13A0
	public bool ExistsTraining() { }

	// RVA: 0x2CF1480 Offset: 0x2CF1581 VA: 0x2CF1480
	public void AddChapter(ChapterData chapter) { }

	// RVA: 0x2CE3670 Offset: 0x2CE3771 VA: 0x2CE3670
	public string TryGetRootName(GmapSpot nextSpot) { }

	// RVA: 0x2CF14E0 Offset: 0x2CF15E1 VA: 0x2CF14E0
	public bool CheckChange() { }

	// RVA: 0x2CF1510 Offset: 0x2CF1611 VA: 0x2CF1510
	public bool CheckAccess(Vector3 pos) { }

	// RVA: 0x2CE9440 Offset: 0x2CE9541 VA: 0x2CE9440
	public Vector3 get_Position() { }

	// RVA: 0x2CF1590 Offset: 0x2CF1691 VA: 0x2CF1590
	public List<GmapSpot> NextSpots() { }

	// RVA: 0x2CEE610 Offset: 0x2CEE711 VA: 0x2CEE610
	public GmapSpot.Direction GetDirectionToSpot(GmapSpot spot) { }

	// RVA: 0x2CF1770 Offset: 0x2CF1871 VA: 0x2CF1770
	public void FixChange() { }

	// RVA: 0x2CF1850 Offset: 0x2CF1951 VA: 0x2CF1850
	public void SetEnable() { }

	// RVA: 0x2CF1900 Offset: 0x2CF1A01 VA: 0x2CF1900
	public bool StartAppear() { }

	// RVA: 0x2CF1B70 Offset: 0x2CF1C71 VA: 0x2CF1B70
	public bool FixChangeTick() { }

	// RVA: 0x2CF17F0 Offset: 0x2CF18F1 VA: 0x2CF17F0
	public void UpdateVisible() { }

	// RVA: 0x2CF1EC0 Offset: 0x2CF1FC1 VA: 0x2CF1EC0
	public void SetMapObjectEnable(bool value) { }

	// RVA: 0x2CF1F60 Offset: 0x2CF2061 VA: 0x2CF1F60
	public GameObject get_SpotObject() { }

	// RVA: 0x2CF2040 Offset: 0x2CF2141 VA: 0x2CF2040
	public void set_SpotObject(GameObject value) { }

	// RVA: 0x2CEBE80 Offset: 0x2CEBF81 VA: 0x2CEBE80
	public ChapterData get_Chapter() { }

	// RVA: 0x2CE3D60 Offset: 0x2CE3E61 VA: 0x2CE3D60
	public string get_GmapSpotID() { }

	// RVA: 0x2CF2100 Offset: 0x2CF2201 VA: 0x2CF2100
	public bool IsEqualCID(string cid) { }

	// RVA: 0x2CF2130 Offset: 0x2CF2231 VA: 0x2CF2130
	public bool IsCompleted() { }

	// RVA: 0x2CF2230 Offset: 0x2CF2331 VA: 0x2CF2230
	public bool IsCompletedOpenCondSpot() { }

	// RVA: 0x2CF23C0 Offset: 0x2CF24C1 VA: 0x2CF23C0
	public bool Dispos() { }

	// RVA: 0x2CF2400 Offset: 0x2CF2501 VA: 0x2CF2400
	public bool IsDispos(bool ignoreExistMob = False) { }

	// RVA: 0x2CF2750 Offset: 0x2CF2851 VA: 0x2CF2750
	private bool TransformDispos() { }

	// RVA: 0x2CF2B30 Offset: 0x2CF2C31 VA: 0x2CF2B30
	public void DeleteDispos() { }

	// RVA: 0x2CF2D40 Offset: 0x2CF2E41 VA: 0x2CF2D40
	public void UnloadMobUnit() { }

	// RVA: 0x2CF2BF0 Offset: 0x2CF2CF1 VA: 0x2CF2BF0
	private void DestroyIcon() { }

	// RVA: 0x2CF2D90 Offset: 0x2CF2E91 VA: 0x2CF2D90
	public void CreateMobUnitFromSpotMob() { }

	// RVA: 0x2CF2EC0 Offset: 0x2CF2FC1 VA: 0x2CF2EC0
	public string GetPlaceName() { }

	// RVA: 0x2CF2FB0 Offset: 0x2CF30B1 VA: 0x2CF2FB0
	public static JobData GetJob(Random random, int level, string ejid) { }

	// RVA: 0x2CF3050 Offset: 0x2CF3151 VA: 0x2CF3050
	public static JobData GetJob(Random random, int level, EncountJobData encountJob) { }

	// RVA: 0x2CF3230 Offset: 0x2CF3331 VA: 0x2CF3230
	private static string GetPidPrefix(GmapSpot.EncountPersonType type) { }

	// RVA: 0x2CF3360 Offset: 0x2CF3461 VA: 0x2CF3360
	public static PersonData GetPerson(Random random, JobData job, string pidPrefix) { }

	// RVA: 0x2CF3540 Offset: 0x2CF3641 VA: 0x2CF3540
	private static PersonData GetRarePerson(Random random, JobData job, EncountUnitData.RareType rareType) { }

	// RVA: 0x2CF3760 Offset: 0x2CF3861 VA: 0x2CF3760
	public static PersonData GetPerson(Random random, JobData job, GmapSpot.EncountPersonType type, EncountUnitData.RareType rareType = 0) { }

	// RVA: 0x2CF1280 Offset: 0x2CF1381 VA: 0x2CF1280
	private static int GetGmapDirection(float degree) { }
}

