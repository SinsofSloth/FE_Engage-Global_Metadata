// Namespace: App
public class GameUserGmapData // TypeDefIndex: 13618
{
	// Fields
	private float m_GmapCameraDistance; // 0x10
	private OrderedDictionary m_Mobs; // 0x18
	private long m_LastUpdateDateTime; // 0x20
	private byte[] m_EncountCounters; // 0x28
	private readonly float EncountTimeHoursSpan; // 0x30
	private GmapMode.Mode m_Mode; // 0x34
	private string m_NowSpotGod; // 0x38
	private string m_NowSpotEvil; // 0x40
	private const int Version = 4;

	// Properties
	public GmapMode.Mode Mode { get; set; }
	public string NowSpotGod { get; set; }
	public string NowSpotEvil { get; set; }
	public float GmapCameraDistance { get; set; }

	// Methods

	// RVA: 0x28DA0F0 Offset: 0x28DA1F1 VA: 0x28DA0F0
	public void .ctor() { }

	// RVA: 0x28D2420 Offset: 0x28D2521 VA: 0x28D2420
	public void Reset() { }

	// RVA: 0x28DB9D0 Offset: 0x28DBAD1 VA: 0x28DB9D0
	public GmapMode.Mode get_Mode() { }

	// RVA: 0x28DB9E0 Offset: 0x28DBAE1 VA: 0x28DB9E0
	public void set_Mode(GmapMode.Mode value) { }

	// RVA: 0x28DB9F0 Offset: 0x28DBAF1 VA: 0x28DB9F0
	public string get_NowSpotGod() { }

	// RVA: 0x28DBA00 Offset: 0x28DBB01 VA: 0x28DBA00
	public void set_NowSpotGod(string value) { }

	// RVA: 0x28DBA10 Offset: 0x28DBB11 VA: 0x28DBA10
	public string get_NowSpotEvil() { }

	// RVA: 0x28DBA20 Offset: 0x28DBB21 VA: 0x28DBA20
	public void set_NowSpotEvil(string value) { }

	// RVA: 0x28DBA30 Offset: 0x28DBB31 VA: 0x28DBA30
	public float get_GmapCameraDistance() { }

	// RVA: 0x28DBA40 Offset: 0x28DBB41 VA: 0x28DBA40
	public void set_GmapCameraDistance(float value) { }

	// RVA: 0x28DBA50 Offset: 0x28DBB51 VA: 0x28DBA50
	public void AddMob(string spotId, EncountMob mob) { }

	// RVA: 0x28DBAB0 Offset: 0x28DBBB1 VA: 0x28DBAB0
	public EncountMob GetMob(string spotId) { }

	// RVA: 0x28DBB70 Offset: 0x28DBC71 VA: 0x28DBB70
	public void ClearMob(string spotId) { }

	// RVA: 0x28DBBB0 Offset: 0x28DBCB1 VA: 0x28DBBB0
	public GmapSpot[] PopMobList(int num) { }

	// RVA: 0x28D5F80 Offset: 0x28D6081 VA: 0x28D5F80
	public bool ExistsMob(string spotId) { }

	// RVA: 0x28DBE40 Offset: 0x28DBF41 VA: 0x28DBE40
	public int CountMob() { }

	// RVA: 0x28DBE50 Offset: 0x28DBF51 VA: 0x28DBE50
	public bool IsCheckDispos() { }

	// RVA: 0x28DC050 Offset: 0x28DC151 VA: 0x28DC050
	public int GetDisposCountFromDeltaHours(bool printLog = True) { }

	// RVA: 0x28DBED0 Offset: 0x28DBFD1 VA: 0x28DBED0
	public bool IsCheckDisposTime() { }

	// RVA: 0x28DC290 Offset: 0x28DC391 VA: 0x28DC290
	public void InitializeDisposTime() { }

	// RVA: 0x28D47B0 Offset: 0x28D48B1 VA: 0x28D47B0
	public void AddEncountCounter(GameUserGmapData.EncountCounterType type) { }

	// RVA: 0x28DBFF0 Offset: 0x28DC0F1 VA: 0x28DBFF0
	public int GetDisposEncountCount() { }

	// RVA: 0x28DC910 Offset: 0x28DCA11 VA: 0x28DC910
	public int ResetEncountCounter() { }

	// RVA: 0x28DC450 Offset: 0x28DC551 VA: 0x28DC450
	private int GetEncountCountMapClear(bool isUpdate = False) { }

	// RVA: 0x28DC5F0 Offset: 0x28DC6F1 VA: 0x28DC5F0
	private int GetEncountCountNetwork(bool isUpdate = False) { }

	// RVA: 0x28DC780 Offset: 0x28DC881 VA: 0x28DC780
	private int GetEncountCountMinigame(bool isUpdate = False) { }

	// RVA: 0x28DC170 Offset: 0x28DC271 VA: 0x28DC170
	private bool IsValidRealTime() { }

	// RVA: 0x28DC320 Offset: 0x28DC421 VA: 0x28DC320
	private bool IsValidCounter(GameUserGmapData.EncountCounterType type) { }

	// RVA: 0x28DC970 Offset: 0x28DCA71 VA: 0x28DC970
	public int GetEncountCounter(GameUserGmapData.EncountCounterType type) { }

	// RVA: 0x28DC9B0 Offset: 0x28DCAB1 VA: 0x28DC9B0
	public void SetEncountCounter(GameUserGmapData.EncountCounterType type, int value) { }

	// RVA: 0x28D70E0 Offset: 0x28D71E1 VA: 0x28D70E0
	public void Serialize(Stream stream) { }

	// RVA: 0x28D86D0 Offset: 0x28D87D1 VA: 0x28D86D0
	public void Deserialize(Stream stream) { }
}

