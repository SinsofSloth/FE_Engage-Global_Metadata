// Namespace: App
public class MapSight : SingletonClass<MapSight> // TypeDefIndex: 12210
{
	// Fields
	private MapImageSight m_ImagePlayer; // 0x20
	private MapImageSight m_ImageEnemy; // 0x28
	private MapImageSight m_ImageAlly; // 0x30
	private bool m_IsUsable; // 0x38

	// Properties
	public bool IsUsable { get; set; }
	protected override int Version { get; }
	public MapImageSight ImagePlayer { get; }
	public MapImageSight ImageEnemy { get; }
	public MapImageSight ImageAlly { get; }

	// Methods

	// RVA: 0x271C8F0 Offset: 0x271C9F1 VA: 0x271C8F0
	public bool get_IsUsable() { }

	// RVA: 0x271C900 Offset: 0x271CA01 VA: 0x271C900
	public void set_IsUsable(bool value) { }

	// RVA: 0x271C910 Offset: 0x271CA11 VA: 0x271C910
	public void .ctor() { }

	// RVA: 0x271CA30 Offset: 0x271CB31 VA: 0x271CA30
	public void Setup(ChapterData chapter) { }

	// RVA: 0x26FDD20 Offset: 0x26FDE21 VA: 0x26FDD20
	public void Update(Unit unit) { }

	// RVA: 0x27065A0 Offset: 0x27066A1 VA: 0x27065A0
	public void Update(Force.Type forceType) { }

	// RVA: 0x270BA10 Offset: 0x270BB11 VA: 0x270BA10
	public void UpdateAll() { }

	// RVA: 0x271CC80 Offset: 0x271CD81 VA: 0x271CC80
	private void UpdateProjection() { }

	// RVA: 0x271CA80 Offset: 0x271CB81 VA: 0x271CA80
	private void UpdateUnit() { }

	// RVA: 0x271CF50 Offset: 0x271D051 VA: 0x271CF50
	public bool IsIn(int x, int z) { }

	// RVA: 0x271D060 Offset: 0x271D161 VA: 0x271D060
	public bool IsIn(int x, int z, Force.Type forceType) { }

	// RVA: 0x271D0F0 Offset: 0x271D1F1 VA: 0x271D0F0
	public bool IsOut(int x, int z) { }

	// RVA: 0x271D110 Offset: 0x271D211 VA: 0x271D110
	public bool IsOut(int x, int z, Force.Type forceType) { }

	// RVA: 0x271D1A0 Offset: 0x271D2A1 VA: 0x271D1A0
	public MapImageSight GetSightImage(Unit unit) { }

	// RVA: 0x271CA40 Offset: 0x271CB41 VA: 0x271CA40
	public MapImageSight GetSightImage(Force.Type forceType) { }

	// RVA: 0x271D1E0 Offset: 0x271D2E1 VA: 0x271D1E0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x271D1F0 Offset: 0x271D2F1 VA: 0x271D1F0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x271D200 Offset: 0x271D301 VA: 0x271D200 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x271D210 Offset: 0x271D311 VA: 0x271D210
	public MapImageSight get_ImagePlayer() { }

	// RVA: 0x271D220 Offset: 0x271D321 VA: 0x271D220
	public MapImageSight get_ImageEnemy() { }

	// RVA: 0x271D230 Offset: 0x271D331 VA: 0x271D230
	public MapImageSight get_ImageAlly() { }

	// RVA: 0x271CDE0 Offset: 0x271CEE1 VA: 0x271CDE0
	public MapImageSight GetViewImage() { }

	// RVA: 0x271D240 Offset: 0x271D341 VA: 0x271D240
	public bool IsViewIn(int x, int z) { }

	// RVA: 0x271D2B0 Offset: 0x271D3B1 VA: 0x271D2B0
	public bool IsViewOut(int x, int z) { }
}

