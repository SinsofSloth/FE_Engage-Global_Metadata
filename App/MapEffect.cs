// Namespace: App
public class MapEffect : SingletonClass<MapEffect> // TypeDefIndex: 12000
{
	// Fields
	private static GameObject s_Root; // 0x0
	private MapEffect.LocationPool m_Pool; // 0x20

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x21B6BE0 Offset: 0x21B6CE1 VA: 0x21B6BE0
	public static GameObject FindRoot() { }

	// RVA: 0x21B6C50 Offset: 0x21B6D51 VA: 0x21B6C50
	public static GameObject TryCreateRoot() { }

	// RVA: 0x21B6DA0 Offset: 0x21B6EA1 VA: 0x21B6DA0
	public static void TryDeleteRoot() { }

	// RVA: 0x21B6F60 Offset: 0x21B7061 VA: 0x21B6F60 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x21B71F0 Offset: 0x21B72F1 VA: 0x21B71F0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x21B7450 Offset: 0x21B7551 VA: 0x21B7450 Slot: 8
	protected override void OnUpdate() { }

	// RVA: 0x21B77E0 Offset: 0x21B78E1 VA: 0x21B77E0
	public static bool Play(string name, Vector3 position) { }

	// RVA: 0x21B7A80 Offset: 0x21B7B81 VA: 0x21B7A80
	public static bool Play(string name, int x, int z) { }

	// RVA: 0x21B87D0 Offset: 0x21B88D1 VA: 0x21B87D0
	public static bool Play(EffectData data, int x, int z) { }

	// RVA: 0x21B9640 Offset: 0x21B9741 VA: 0x21B9640
	public static bool Play(EffectData data, Vector3 position) { }

	// RVA: 0x21B9710 Offset: 0x21B9811 VA: 0x21B9710
	public static bool Play(string name, UnitModel model) { }

	// RVA: 0x21B98A0 Offset: 0x21B99A1 VA: 0x21B98A0
	public static bool Play(string name, Unit unit) { }

	// RVA: 0x21B78B0 Offset: 0x21B79B1 VA: 0x21B78B0
	public static bool Play(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BB250 Offset: 0x21BB351 VA: 0x21BB250
	private static bool CanPlaying() { }

	// RVA: 0x21BB140 Offset: 0x21BB241 VA: 0x21BB140
	public static bool Play(EffectSequence seq, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21B9520 Offset: 0x21B9621 VA: 0x21B9520
	public static bool Play(EffectData data, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BB410 Offset: 0x21BB511 VA: 0x21BB410
	public static void Create(string name, int x, int z) { }

	// RVA: 0x21BB6D0 Offset: 0x21BB7D1 VA: 0x21BB6D0
	public static void Create(string name, Vector3 position) { }

	// RVA: 0x21BB5C0 Offset: 0x21BB6C1 VA: 0x21BB5C0
	public static void Create(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BB9F0 Offset: 0x21BBAF1 VA: 0x21BB9F0
	public static void Delete(string name, int x, int z) { }

	// RVA: 0x21BBF10 Offset: 0x21BC011 VA: 0x21BBF10
	public static void Delete(string name, Vector3 position) { }

	// RVA: 0x21BBFF0 Offset: 0x21BC0F1 VA: 0x21BBFF0
	public static void Delete(Vector3 position) { }

	// RVA: 0x21BC0C0 Offset: 0x21BC1C1 VA: 0x21BC0C0
	public static bool IsExist(string name, Vector3 position) { }

	// RVA: 0x21BB830 Offset: 0x21BB931 VA: 0x21BB830
	private void CreateImpl(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BBAF0 Offset: 0x21BBBF1 VA: 0x21BBAF0
	private void DeleteImpl(string name, Vector3 position) { }

	// RVA: 0x21BC1C0 Offset: 0x21BC2C1 VA: 0x21BC1C0
	private bool IsExistImpl(string name, Vector3 position) { }

	// RVA: 0x21BC6F0 Offset: 0x21BC7F1 VA: 0x21BC6F0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x21BC700 Offset: 0x21BC801 VA: 0x21BC700 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x21BC860 Offset: 0x21BC961 VA: 0x21BC860 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x21BD080 Offset: 0x21BD181 VA: 0x21BD080
	public void Resume() { }

	// RVA: 0x21BD190 Offset: 0x21BD291 VA: 0x21BD190
	public static void Shoot(string name, Vector3 start, Vector3 goal, float time, float delay, EffectShoot.Callback callback) { }

	// RVA: 0x21BD3E0 Offset: 0x21BD4E1 VA: 0x21BD3E0
	public void .ctor() { }

	// RVA: 0x21BD4A0 Offset: 0x21BD5A1 VA: 0x21BD4A0
	private static void .cctor() { }
}

