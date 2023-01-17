// Namespace: App
[ExecuteAlways] // RVA: 0x279480 Offset: 0x279581 VA: 0x279480
public abstract class MapProjection : SingletonMonoBehaviour<MapProjection> // TypeDefIndex: 14039
{
	// Fields
	public Texture m_Texture; // 0x20
	[RangeAttribute] // RVA: 0x29D400 Offset: 0x29D501 VA: 0x29D400
	public float m_OffsetX; // 0x28
	[RangeAttribute] // RVA: 0x29D420 Offset: 0x29D521 VA: 0x29D420
	public float m_OffsetY; // 0x2C
	[RangeAttribute] // RVA: 0x29D440 Offset: 0x29D541 VA: 0x29D440
	public float m_SpeedX; // 0x30
	[RangeAttribute] // RVA: 0x29D460 Offset: 0x29D561 VA: 0x29D460
	public float m_SpeedY; // 0x34
	[RangeAttribute] // RVA: 0x29D480 Offset: 0x29D581 VA: 0x29D480
	public float m_Scale; // 0x38
	[RangeAttribute] // RVA: 0x29D4A0 Offset: 0x29D5A1 VA: 0x29D4A0
	public float m_Alpha; // 0x3C
	[HeaderAttribute] // RVA: 0x29D4C0 Offset: 0x29D5C1 VA: 0x29D4C0
	public Color32 m_SightSideColor; // 0x40
	public Color32 m_SightDarkColor; // 0x44
	public Color32 m_SightMaskColor; // 0x48
	private Texture2D m_SightTexture; // 0x50
	private Color32[] m_SightColors; // 0x58
	private MapImageSight m_SightImage; // 0x60
	private int m_SightWidth; // 0x68
	private int m_SightHeight; // 0x6C
	private int m_MapProjectionTex; // 0x70
	private int m_MapProjectionScale; // 0x74
	private int m_MapProjectionAlpha; // 0x78
	private int m_MapProjectionOffset; // 0x7C
	private int m_MapProjectionSpeed; // 0x80

	// Methods

	// RVA: 0x278D5B0 Offset: 0x278D6B1 VA: 0x278D5B0
	private bool IsUsable() { }

	// RVA: 0x278D640 Offset: 0x278D741 VA: 0x278D640
	private void OnEnable() { }

	// RVA: 0x278D820 Offset: 0x278D921 VA: 0x278D820
	private void OnDisable() { }

	// RVA: 0x278D9D0 Offset: 0x278DAD1 VA: 0x278D9D0
	private FilterMode GetSightFilter() { }

	// RVA: 0x278DA90 Offset: 0x278DB91 VA: 0x278DA90
	private int GetSightSize() { }

	// RVA: 0x278DB80 Offset: 0x278DC81 VA: 0x278DB80
	private int GetSightScale() { }

	// RVA: 0x278DAB0 Offset: 0x278DBB1 VA: 0x278DAB0
	private int GetSightShift() { }

	// RVA: 0x278DBA0 Offset: 0x278DCA1 VA: 0x278DBA0
	private bool IsChangedSightTexture() { }

	// RVA: 0x278DC20 Offset: 0x278DD21 VA: 0x278DC20
	private Texture2D TryCreateSightTexture() { }

	// RVA: 0x278DDD0 Offset: 0x278DED1 VA: 0x278DDD0
	private void ClearSightTexture() { }

	// RVA: 0x278DE40 Offset: 0x278DF41 VA: 0x278DE40
	private void TryDeleteSightTexture() { }

	// RVA: 0x278DF00 Offset: 0x278E001 VA: 0x278DF00
	public void UpdateSightTexture(MapImageSight image, int w = 32, int h = 32) { }

	// RVA: 0x278D8D0 Offset: 0x278D9D1 VA: 0x278D8D0
	public void Commit(Texture texture, float scale = 1, float alpha = 0, float offsetX = 0, float offsetY = 0, float speedX = 0, float speedY = 0) { }

	// RVA: 0x278E120 Offset: 0x278E221 VA: 0x278E120
	public void Commit(ViewMode.Mode mode) { }

	// RVA: 0x278D6D0 Offset: 0x278D7D1 VA: 0x278D6D0
	public void Commit() { }

	// RVA: 0x278E250 Offset: 0x278E351 VA: 0x278E250
	protected void .ctor() { }
}

