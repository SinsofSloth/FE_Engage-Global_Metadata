// Namespace: App
[RequireComponent] // RVA: 0x276880 Offset: 0x276981 VA: 0x276880
[ExecuteAlways] // RVA: 0x276880 Offset: 0x276981 VA: 0x276880
[RequireComponent] // RVA: 0x276880 Offset: 0x276981 VA: 0x276880
[RequireComponent] // RVA: 0x276880 Offset: 0x276981 VA: 0x276880
public class GmapLineRenderer : MonoBehaviour // TypeDefIndex: 10270
{
	// Fields
	[SerializeField] // RVA: 0x28DCF0 Offset: 0x28DDF1 VA: 0x28DCF0
	private GmapLineRenderer.DrawType m_DrawType; // 0x18
	[HeaderAttribute] // RVA: 0x28DD00 Offset: 0x28DE01 VA: 0x28DD00
	public Material m_Material; // 0x20
	public float m_Step; // 0x28
	public float m_Size; // 0x2C
	public float m_AppearSpeed; // 0x30
	private MeshRenderer m_MeshRenderer; // 0x38
	private List<GmapLineRenderer.LinePoint> m_LinePoints; // 0x40
	private CinemachineSmoothPath m_SmoothPath; // 0x48
	private bool m_IsAppearing; // 0x50
	private float m_PathLength; // 0x54
	private float m_AppeardPathLength; // 0x58
	private LineRenderer m_LineRenderer; // 0x60
	private float m_LineStep; // 0x68
	private List<Vector3> m_LinePositionList; // 0x70
	private int m_LineAppearCountOld; // 0x78
	private int m_LineAppearCount; // 0x7C
	private int m_LineAppearSpeed; // 0x80

	// Methods

	// RVA: 0x28E8040 Offset: 0x28E8141 VA: 0x28E8040
	private void Awake() { }

	// RVA: 0x28E8070 Offset: 0x28E8171 VA: 0x28E8070
	public void TryInitialize() { }

	// RVA: 0x28E8280 Offset: 0x28E8381 VA: 0x28E8280
	private void Start() { }

	// RVA: 0x28E8290 Offset: 0x28E8391 VA: 0x28E8290
	private int GetLineAppearSpeed() { }

	// RVA: 0x28E82D0 Offset: 0x28E83D1 VA: 0x28E82D0
	public bool DrawLineTick(out Vector3 endPos) { }

	// RVA: 0x28E84E0 Offset: 0x28E85E1 VA: 0x28E84E0
	public void SetVisible(bool value) { }

	// RVA: 0x28E8580 Offset: 0x28E8681 VA: 0x28E8580
	public bool IsVisible() { }

	// RVA: 0x28E8620 Offset: 0x28E8721 VA: 0x28E8620
	public bool IsActiveEndpoints() { }

	// RVA: 0x28E8850 Offset: 0x28E8951 VA: 0x28E8850
	private void BuildPoinsts() { }

	// RVA: 0x28E8270 Offset: 0x28E8371 VA: 0x28E8270
	public void BuildLine() { }

	// RVA: 0x28E83E0 Offset: 0x28E84E1 VA: 0x28E83E0
	private void SetLineRendererLength(int length = -1) { }

	// RVA: 0x28E8A00 Offset: 0x28E8B01 VA: 0x28E8A00
	public void StartAppear() { }

	// RVA: 0x28E8A20 Offset: 0x28E8B21 VA: 0x28E8A20
	public void ClearDrawLine() { }

	// RVA: 0x28E8A30 Offset: 0x28E8B31 VA: 0x28E8A30
	public GmapSpot[] GetGmapSpots() { }

	// RVA: 0x28E8CC0 Offset: 0x28E8DC1 VA: 0x28E8CC0
	public void .ctor() { }
}

