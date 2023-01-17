// Namespace: UnityEngine.UI
[RequireComponent] // RVA: 0x43090 Offset: 0x43191 VA: 0x43090
[AddComponentMenu] // RVA: 0x43090 Offset: 0x43191 VA: 0x43090
public class RawImage : MaskableGraphic // TypeDefIndex: 4330
{
	// Fields
	[SerializeField] // RVA: 0x45090 Offset: 0x45191 VA: 0x45090
	[FormerlySerializedAsAttribute] // RVA: 0x45090 Offset: 0x45191 VA: 0x45090
	private Texture m_Texture; // 0xD0
	[SerializeField] // RVA: 0x450E0 Offset: 0x451E1 VA: 0x450E0
	private Rect m_UVRect; // 0xD8

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x1B72210 Offset: 0x1B72311 VA: 0x1B72210
	protected void .ctor() { }

	// RVA: 0x1B72270 Offset: 0x1B72371 VA: 0x1B72270 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1B723F0 Offset: 0x1B724F1 VA: 0x1B723F0
	public Texture get_texture() { }

	// RVA: 0x1B72400 Offset: 0x1B72501 VA: 0x1B72400
	public void set_texture(Texture value) { }

	// RVA: 0x1B724E0 Offset: 0x1B725E1 VA: 0x1B724E0
	public Rect get_uvRect() { }

	// RVA: 0x1B724F0 Offset: 0x1B725F1 VA: 0x1B724F0
	public void set_uvRect(Rect value) { }

	// RVA: 0x1B72580 Offset: 0x1B72681 VA: 0x1B72580 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1B726F0 Offset: 0x1B727F1 VA: 0x1B726F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1B72B30 Offset: 0x1B72C31 VA: 0x1B72B30 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

