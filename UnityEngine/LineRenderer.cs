// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C890 Offset: 0x43C991 VA: 0x43C890
[NativeHeaderAttribute] // RVA: 0x43C890 Offset: 0x43C991 VA: 0x43C890
public sealed class LineRenderer : Renderer // TypeDefIndex: 3455
{
	// Properties
	[ObsoleteAttribute] // RVA: 0x459860 Offset: 0x459961 VA: 0x459860
	public int numPositions { get; set; }
	public float startWidth { get; set; }
	public float endWidth { get; set; }
	public float widthMultiplier { get; set; }
	public int numCornerVertices { get; set; }
	public int numCapVertices { get; set; }
	public bool useWorldSpace { get; set; }
	public bool loop { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	[NativePropertyAttribute] // RVA: 0x4598A0 Offset: 0x4599A1 VA: 0x4598A0
	public int positionCount { get; set; }
	public float shadowBias { get; set; }
	public bool generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x447E30 Offset: 0x447F31 VA: 0x447E30
	// RVA: 0x2F2C530 Offset: 0x2F2C631 VA: 0x2F2C530
	public void SetWidth(float start, float end) { }

	[ObsoleteAttribute] // RVA: 0x447E70 Offset: 0x447F71 VA: 0x447E70
	// RVA: 0x2F2C650 Offset: 0x2F2C751 VA: 0x2F2C650
	public void SetColors(Color start, Color end) { }

	[ObsoleteAttribute] // RVA: 0x447EB0 Offset: 0x447FB1 VA: 0x447EB0
	// RVA: 0x2F2C7C0 Offset: 0x2F2C8C1 VA: 0x2F2C7C0
	public void SetVertexCount(int count) { }

	// RVA: 0x2F2C860 Offset: 0x2F2C961 VA: 0x2F2C860
	public int get_numPositions() { }

	// RVA: 0x2F2C900 Offset: 0x2F2CA01 VA: 0x2F2C900
	public void set_numPositions(int value) { }

	// RVA: 0x2F2C950 Offset: 0x2F2CA51 VA: 0x2F2C950
	public float get_startWidth() { }

	// RVA: 0x2F2C5B0 Offset: 0x2F2C6B1 VA: 0x2F2C5B0
	public void set_startWidth(float value) { }

	// RVA: 0x2F2C9A0 Offset: 0x2F2CAA1 VA: 0x2F2C9A0
	public float get_endWidth() { }

	// RVA: 0x2F2C600 Offset: 0x2F2C701 VA: 0x2F2C600
	public void set_endWidth(float value) { }

	// RVA: 0x2F2C9F0 Offset: 0x2F2CAF1 VA: 0x2F2C9F0
	public float get_widthMultiplier() { }

	// RVA: 0x2F2CA40 Offset: 0x2F2CB41 VA: 0x2F2CA40
	public void set_widthMultiplier(float value) { }

	// RVA: 0x2F2CA90 Offset: 0x2F2CB91 VA: 0x2F2CA90
	public int get_numCornerVertices() { }

	// RVA: 0x2F2CAE0 Offset: 0x2F2CBE1 VA: 0x2F2CAE0
	public void set_numCornerVertices(int value) { }

	// RVA: 0x2F2CB30 Offset: 0x2F2CC31 VA: 0x2F2CB30
	public int get_numCapVertices() { }

	// RVA: 0x2F2CB80 Offset: 0x2F2CC81 VA: 0x2F2CB80
	public void set_numCapVertices(int value) { }

	// RVA: 0x2F2CBD0 Offset: 0x2F2CCD1 VA: 0x2F2CBD0
	public bool get_useWorldSpace() { }

	// RVA: 0x2F2CC20 Offset: 0x2F2CD21 VA: 0x2F2CC20
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x2F2CC70 Offset: 0x2F2CD71 VA: 0x2F2CC70
	public bool get_loop() { }

	// RVA: 0x2F2CCC0 Offset: 0x2F2CDC1 VA: 0x2F2CCC0
	public void set_loop(bool value) { }

	// RVA: 0x2F2CD10 Offset: 0x2F2CE11 VA: 0x2F2CD10
	public Color get_startColor() { }

	// RVA: 0x2F2C700 Offset: 0x2F2C801 VA: 0x2F2C700
	public void set_startColor(Color value) { }

	// RVA: 0x2F2CE10 Offset: 0x2F2CF11 VA: 0x2F2CE10
	public Color get_endColor() { }

	// RVA: 0x2F2C760 Offset: 0x2F2C861 VA: 0x2F2C760
	public void set_endColor(Color value) { }

	// RVA: 0x2F2C8B0 Offset: 0x2F2C9B1 VA: 0x2F2C8B0
	public int get_positionCount() { }

	// RVA: 0x2F2C810 Offset: 0x2F2C911 VA: 0x2F2C810
	public void set_positionCount(int value) { }

	// RVA: 0x2F2CF10 Offset: 0x2F2D011 VA: 0x2F2CF10
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x2F2CFE0 Offset: 0x2F2D0E1 VA: 0x2F2CFE0
	public Vector3 GetPosition(int index) { }

	// RVA: 0x2F2D0B0 Offset: 0x2F2D1B1 VA: 0x2F2D0B0
	public float get_shadowBias() { }

	// RVA: 0x2F2D100 Offset: 0x2F2D201 VA: 0x2F2D100
	public void set_shadowBias(float value) { }

	// RVA: 0x2F2D150 Offset: 0x2F2D251 VA: 0x2F2D150
	public bool get_generateLightingData() { }

	// RVA: 0x2F2D1A0 Offset: 0x2F2D2A1 VA: 0x2F2D1A0
	public void set_generateLightingData(bool value) { }

	// RVA: 0x2F2D1F0 Offset: 0x2F2D2F1 VA: 0x2F2D1F0
	public LineTextureMode get_textureMode() { }

	// RVA: 0x2F2D240 Offset: 0x2F2D341 VA: 0x2F2D240
	public void set_textureMode(LineTextureMode value) { }

	// RVA: 0x2F2D290 Offset: 0x2F2D391 VA: 0x2F2D290
	public LineAlignment get_alignment() { }

	// RVA: 0x2F2D2E0 Offset: 0x2F2D3E1 VA: 0x2F2D2E0
	public void set_alignment(LineAlignment value) { }

	// RVA: 0x2F2D330 Offset: 0x2F2D431 VA: 0x2F2D330
	public void Simplify(float tolerance) { }

	// RVA: 0x2F2D380 Offset: 0x2F2D481 VA: 0x2F2D380
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x2F2D410 Offset: 0x2F2D511 VA: 0x2F2D410
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x2F2D480 Offset: 0x2F2D581 VA: 0x2F2D480
	public AnimationCurve get_widthCurve() { }

	// RVA: 0x2F2D520 Offset: 0x2F2D621 VA: 0x2F2D520
	public void set_widthCurve(AnimationCurve value) { }

	// RVA: 0x2F2D5C0 Offset: 0x2F2D6C1 VA: 0x2F2D5C0
	public Gradient get_colorGradient() { }

	// RVA: 0x2F2D660 Offset: 0x2F2D761 VA: 0x2F2D660
	public void set_colorGradient(Gradient value) { }

	// RVA: 0x2F2D4D0 Offset: 0x2F2D5D1 VA: 0x2F2D4D0
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0x2F2D570 Offset: 0x2F2D671 VA: 0x2F2D570
	private void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0x2F2D610 Offset: 0x2F2D711 VA: 0x2F2D610
	private Gradient GetColorGradientCopy() { }

	// RVA: 0x2F2D6B0 Offset: 0x2F2D7B1 VA: 0x2F2D6B0
	private void SetColorGradient(Gradient curve) { }

	[FreeFunctionAttribute] // RVA: 0x447EF0 Offset: 0x447FF1 VA: 0x447EF0
	// RVA: 0x2F2D700 Offset: 0x2F2D801 VA: 0x2F2D700
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x447F40 Offset: 0x448041 VA: 0x447F40
	// RVA: 0x2F2D750 Offset: 0x2F2D851 VA: 0x2F2D750
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x2F2D7A0 Offset: 0x2F2D8A1 VA: 0x2F2D7A0
	public void SetPositions(NativeArray<Vector3> positions) { }

	// RVA: 0x2F2D8B0 Offset: 0x2F2D9B1 VA: 0x2F2D8B0
	public void SetPositions(NativeSlice<Vector3> positions) { }

	// RVA: 0x2F2D990 Offset: 0x2F2DA91 VA: 0x2F2D990
	public int GetPositions([Out] NativeArray<Vector3> positions) { }

	// RVA: 0x2F2DAA0 Offset: 0x2F2DBA1 VA: 0x2F2DAA0
	public int GetPositions([Out] NativeSlice<Vector3> positions) { }

	[FreeFunctionAttribute] // RVA: 0x447F90 Offset: 0x448091 VA: 0x447F90
	// RVA: 0x2F2D850 Offset: 0x2F2D951 VA: 0x2F2D850
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	[FreeFunctionAttribute] // RVA: 0x447FE0 Offset: 0x4480E1 VA: 0x447FE0
	// RVA: 0x2F2DA40 Offset: 0x2F2DB41 VA: 0x2F2DA40
	private int GetPositionsWithNativeContainer(IntPtr positions, int length) { }

	// RVA: 0x2F2DB80 Offset: 0x2F2DC81 VA: 0x2F2DB80
	public void .ctor() { }

	// RVA: 0x2F2CD70 Offset: 0x2F2CE71 VA: 0x2F2CD70
	private void get_startColor_Injected(out Color ret) { }

	// RVA: 0x2F2CDC0 Offset: 0x2F2CEC1 VA: 0x2F2CDC0
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x2F2CE70 Offset: 0x2F2CF71 VA: 0x2F2CE70
	private void get_endColor_Injected(out Color ret) { }

	// RVA: 0x2F2CEC0 Offset: 0x2F2CFC1 VA: 0x2F2CEC0
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x2F2CF80 Offset: 0x2F2D081 VA: 0x2F2CF80
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x2F2D050 Offset: 0x2F2D151 VA: 0x2F2D050
	private void GetPosition_Injected(int index, out Vector3 ret) { }
}

