// Namespace: App
public abstract class EventPictureController : MonoBehaviour // TypeDefIndex: 10228
{
	// Fields
	private const string AssetRootPath = "Event/PuppetDemo/Textures/Pictures/";
	private RawImage m_Image; // 0x18
	private Animation m_Animation; // 0x20
	private ResourceHandle m_PictureTextureHandle; // 0x28

	// Methods

	// RVA: 0x27FA740 Offset: 0x27FA841 VA: 0x27FA740
	public void .ctor() { }

	// RVA: 0x27FA750 Offset: 0x27FA851 VA: 0x27FA750
	protected void Awake() { }

	// RVA: 0x27FA840 Offset: 0x27FA941 VA: 0x27FA840
	private bool IsSkip() { }

	// RVA: 0x27F8D40 Offset: 0x27F8E41 VA: 0x27F8D40
	public bool IsLoadingTexture() { }

	// RVA: 0x27F69E0 Offset: 0x27F6AE1 VA: 0x27F69E0
	public void Show(string textureName, string animName, bool isFemale) { }

	// RVA: 0x27F6C80 Offset: 0x27F6D81 VA: 0x27F6C80
	public void Hide(string animName) { }
}

