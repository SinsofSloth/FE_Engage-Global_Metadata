// Namespace: App
public class SpriteAtlasManager // TypeDefIndex: 13925
{
	// Fields
	private TResourceHandle<SpriteAtlas> m_Handle; // 0x10
	private SpriteAtlas m_SpriteAtlas; // 0x18
	private readonly Dictionary<string, Sprite> m_CacheTable; // 0x20

	// Methods

	// RVA: 0x2919F50 Offset: 0x291A051 VA: 0x2919F50
	public void LoadAsync(string path) { }

	// RVA: 0x291A080 Offset: 0x291A181 VA: 0x291A080
	public bool IsLoading() { }

	// RVA: 0x291A0B0 Offset: 0x291A1B1 VA: 0x291A0B0
	public bool IsLoaded() { }

	// RVA: 0x291A130 Offset: 0x291A231 VA: 0x291A130
	public void Unload() { }

	// RVA: 0x291A370 Offset: 0x291A471 VA: 0x291A370
	public Sprite Get(string name) { }

	// RVA: 0x291A400 Offset: 0x291A501 VA: 0x291A400
	public Sprite TryGet(string name) { }

	// RVA: 0x291A190 Offset: 0x291A291 VA: 0x291A190
	public void ClearCache() { }

	// RVA: 0x291A500 Offset: 0x291A601 VA: 0x291A500
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD9A0 Offset: 0x2CDAA1 VA: 0x2CD9A0
	// RVA: 0x291A590 Offset: 0x291A691 VA: 0x291A590
	private void <LoadAsync>b__3_0(SpriteAtlas _) { }
}

