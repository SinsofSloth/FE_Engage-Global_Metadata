// Namespace: 
public class MaterialBehaviour : MonoBehaviour // TypeDefIndex: 7780
{
	// Fields
	[TooltipAttribute] // RVA: 0x27CE70 Offset: 0x27CF71 VA: 0x27CE70
	[SerializeField] // RVA: 0x27CE70 Offset: 0x27CF71 VA: 0x27CE70
	public float m_Speed; // 0x18
	[SerializeField] // RVA: 0x27CEC0 Offset: 0x27CFC1 VA: 0x27CEC0
	[TooltipAttribute] // RVA: 0x27CEC0 Offset: 0x27CFC1 VA: 0x27CEC0
	public bool m_Random; // 0x1C
	private MaterialPropertyBlock m_Props; // 0x20
	private MeshRenderer m_Render; // 0x28
	private float m_Elapsed; // 0x30
	private static float TIME_HOUR; // 0x0
	private static float TIME_DAY; // 0x4
	private static float TIME_MONTH; // 0x8
	protected MaterialBehaviour.TextureInfo MainTex; // 0x38
	protected MaterialBehaviour.TextureInfo BumpMap; // 0x40
	protected MaterialBehaviour.TextureInfo MultiMap; // 0x48

	// Properties
	protected float Elapsed { get; }
	protected MeshRenderer Render { get; }

	// Methods

	// RVA: 0x285A540 Offset: 0x285A641 VA: 0x285A540
	protected float get_Elapsed() { }

	// RVA: 0x285A550 Offset: 0x285A651 VA: 0x285A550
	protected MeshRenderer get_Render() { }

	// RVA: 0x285A560 Offset: 0x285A661 VA: 0x285A560
	protected void Initialize() { }

	// RVA: 0x285AA20 Offset: 0x285AB21 VA: 0x285AA20
	protected void UpdateTime() { }

	// RVA: 0x285AAF0 Offset: 0x285ABF1 VA: 0x285AAF0
	private static void SetTilingImpl(MeshRenderer render, MaterialPropertyBlock property, MaterialBehaviour.TextureInfo info, Vector2 tiling) { }

	// RVA: 0x285AC20 Offset: 0x285AD21 VA: 0x285AC20
	private static void SetOffsetImpl(MeshRenderer render, MaterialPropertyBlock property, MaterialBehaviour.TextureInfo info, Vector2 offset) { }

	// RVA: 0x285AD50 Offset: 0x285AE51 VA: 0x285AD50
	protected void SetMainTexOffset(Vector2 offset) { }

	// RVA: 0x285ADE0 Offset: 0x285AEE1 VA: 0x285ADE0
	protected void SetBumpMapOffset(Vector2 offset) { }

	// RVA: 0x285AE70 Offset: 0x285AF71 VA: 0x285AE70
	protected void SetMultiMapOffset(Vector2 offset) { }

	// RVA: 0x285AF00 Offset: 0x285B001 VA: 0x285AF00
	protected void SetTextureOffset(Vector2 offset) { }

	// RVA: 0x285AFC0 Offset: 0x285B0C1 VA: 0x285AFC0
	protected void SetVector(string name, Vector3 value) { }

	// RVA: 0x285B0F0 Offset: 0x285B1F1 VA: 0x285B0F0
	protected void SetFloat(string name, float value) { }

	// RVA: 0x285A9C0 Offset: 0x285AAC1 VA: 0x285A9C0
	protected float GetPerlinNoise() { }

	// RVA: 0x285B1E0 Offset: 0x285B2E1 VA: 0x285B1E0
	public void .ctor() { }

	// RVA: 0x285B1F0 Offset: 0x285B2F1 VA: 0x285B1F0
	private static void .cctor() { }
}

