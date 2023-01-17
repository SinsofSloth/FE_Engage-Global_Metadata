// Namespace: App
[RequireComponent] // RVA: 0x278100 Offset: 0x278201 VA: 0x278100
public class MiniMapPanelBase : MaskableGraphic // TypeDefIndex: 12354
{
	// Fields
	[SerializeField] // RVA: 0x299F70 Offset: 0x29A071 VA: 0x299F70
	public Texture2D m_Texture; // 0xD0
	private CanvasRenderer m_CanvasRenderer; // 0xD8
	protected Mesh m_Mesh; // 0xE0
	private Material[] m_Materials; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x299F80 Offset: 0x29A081 VA: 0x299F80
	private float <GridSize>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x299F90 Offset: 0x29A091 VA: 0x299F90
	private float <OffsetZ>k__BackingField; // 0xF4
	private bool m_IsAwaked; // 0xF8
	private int m_CustomOffsetZ; // 0xFC

	// Properties
	public Texture2D Texture { get; set; }
	public CanvasRenderer CanvasRenderer { get; }
	public float GridSize { get; set; }
	public float OffsetZ { get; set; }

	// Methods

	// RVA: 0x2275890 Offset: 0x2275991 VA: 0x2275890
	public Texture2D get_Texture() { }

	// RVA: 0x22758A0 Offset: 0x22759A1 VA: 0x22758A0
	public void set_Texture(Texture2D value) { }

	// RVA: 0x2275960 Offset: 0x2275A61 VA: 0x2275960
	public CanvasRenderer get_CanvasRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8210 Offset: 0x2C8311 VA: 0x2C8210
	// RVA: 0x2275A20 Offset: 0x2275B21 VA: 0x2275A20
	public void set_GridSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8220 Offset: 0x2C8321 VA: 0x2C8220
	// RVA: 0x2275A30 Offset: 0x2275B31 VA: 0x2275A30
	public float get_GridSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8230 Offset: 0x2C8331 VA: 0x2C8230
	// RVA: 0x2275A40 Offset: 0x2275B41 VA: 0x2275A40
	public void set_OffsetZ(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8240 Offset: 0x2C8341 VA: 0x2C8240
	// RVA: 0x2275A50 Offset: 0x2275B51 VA: 0x2275A50
	public float get_OffsetZ() { }

	// RVA: 0x2275A60 Offset: 0x2275B61 VA: 0x2275A60 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2275C70 Offset: 0x2275D71 VA: 0x2275C70
	protected Material[] GetMaterials() { }

	// RVA: 0x2275C80 Offset: 0x2275D81 VA: 0x2275C80 Slot: 65
	protected virtual Material[] GetSourceMaterials() { }

	// RVA: 0x2275D40 Offset: 0x2275E41 VA: 0x2275D40 Slot: 66
	protected virtual Material[] GetMapPanelMaterials() { }

	// RVA: 0x2275E00 Offset: 0x2275F01 VA: 0x2275E00
	private MapImage GetMapImage() { }

	// RVA: 0x2275E80 Offset: 0x2275F81 VA: 0x2275E80 Slot: 67
	protected virtual void Update() { }

	// RVA: 0x2275EA0 Offset: 0x2275FA1 VA: 0x2275EA0
	private void LateUpdate() { }

	// RVA: 0x2275FA0 Offset: 0x22760A1 VA: 0x2275FA0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2275FB0 Offset: 0x22760B1 VA: 0x2275FB0 Slot: 68
	public virtual void CreatePanelMesh() { }

	// RVA: 0x2275FC0 Offset: 0x22760C1 VA: 0x2275FC0
	protected void SetMeshToRenderer() { }

	// RVA: 0x22741D0 Offset: 0x22742D1 VA: 0x22741D0
	public void UpdateMapSize() { }

	// RVA: 0x22761F0 Offset: 0x22762F1 VA: 0x22761F0
	public void .ctor() { }
}

