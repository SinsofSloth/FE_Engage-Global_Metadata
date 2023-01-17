// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43CC30 Offset: 0x43CD31 VA: 0x43CC30
[NativeHeaderAttribute] // RVA: 0x43CC30 Offset: 0x43CD31 VA: 0x43CC30
public class Material : Object // TypeDefIndex: 3460
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { get; set; }
	public int renderQueue { get; set; }
	internal int rawRenderQueue { get; }
	public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
	public bool doubleSidedGI { get; set; }
	[NativePropertyAttribute] // RVA: 0x459B20 Offset: 0x459C21 VA: 0x459B20
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x4492C0 Offset: 0x4493C1 VA: 0x4492C0
	// RVA: 0x34774B0 Offset: 0x34775B1 VA: 0x34774B0
	public static Material Create(string scriptContents) { }

	[FreeFunctionAttribute] // RVA: 0x449300 Offset: 0x449401 VA: 0x449300
	// RVA: 0x3477620 Offset: 0x3477721 VA: 0x3477620
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x449340 Offset: 0x449441 VA: 0x449340
	// RVA: 0x3477670 Offset: 0x3477771 VA: 0x3477670
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x449380 Offset: 0x449481 VA: 0x449380
	// RVA: 0x34776C0 Offset: 0x34777C1 VA: 0x34776C0
	private static void CreateWithString(Material self) { }

	// RVA: 0x3477710 Offset: 0x3477811 VA: 0x3477710
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4493C0 Offset: 0x4494C1 VA: 0x4493C0
	// RVA: 0x34777C0 Offset: 0x34778C1 VA: 0x34777C0
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x4493D0 Offset: 0x4494D1 VA: 0x4493D0
	[ObsoleteAttribute] // RVA: 0x4493D0 Offset: 0x4494D1 VA: 0x4493D0
	// RVA: 0x3477580 Offset: 0x3477681 VA: 0x3477580
	public void .ctor(string contents) { }

	// RVA: 0x3477860 Offset: 0x3477961 VA: 0x3477860
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x34778A0 Offset: 0x34779A1 VA: 0x34778A0
	internal static Material GetDefaultParticleMaterial() { }

	// RVA: 0x34778E0 Offset: 0x34779E1 VA: 0x34778E0
	internal static Material GetDefaultLineMaterial() { }

	// RVA: 0x3477920 Offset: 0x3477A21 VA: 0x3477920
	public Shader get_shader() { }

	// RVA: 0x3477970 Offset: 0x3477A71 VA: 0x3477970
	public void set_shader(Shader value) { }

	// RVA: 0x34779C0 Offset: 0x3477AC1 VA: 0x34779C0
	public Color get_color() { }

	// RVA: 0x3477BF0 Offset: 0x3477CF1 VA: 0x3477BF0
	public void set_color(Color value) { }

	// RVA: 0x3477E10 Offset: 0x3477F11 VA: 0x3477E10
	public Texture get_mainTexture() { }

	// RVA: 0x3477FB0 Offset: 0x34780B1 VA: 0x3477FB0
	public void set_mainTexture(Texture value) { }

	// RVA: 0x3478170 Offset: 0x3478271 VA: 0x3478170
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0x3478350 Offset: 0x3478451 VA: 0x3478350
	public void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0x3478520 Offset: 0x3478621 VA: 0x3478520
	public Vector2 get_mainTextureScale() { }

	// RVA: 0x3478700 Offset: 0x3478801 VA: 0x3478700
	public void set_mainTextureScale(Vector2 value) { }

	[NativeNameAttribute] // RVA: 0x449430 Offset: 0x449531 VA: 0x449430
	// RVA: 0x3477AB0 Offset: 0x3477BB1 VA: 0x3477AB0
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x449470 Offset: 0x449571 VA: 0x449470
	// RVA: 0x34788D0 Offset: 0x34789D1 VA: 0x34788D0
	public bool HasProperty(int nameID) { }

	// RVA: 0x3478920 Offset: 0x3478A21 VA: 0x3478920
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x4494B0 Offset: 0x4495B1 VA: 0x4494B0
	// RVA: 0x3478980 Offset: 0x3478A81 VA: 0x3478980
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x4494F0 Offset: 0x4495F1 VA: 0x4494F0
	// RVA: 0x34789D0 Offset: 0x3478AD1 VA: 0x34789D0
	public void set_renderQueue(int value) { }

	[NativeNameAttribute] // RVA: 0x449530 Offset: 0x449631 VA: 0x449530
	// RVA: 0x3478A20 Offset: 0x3478B21 VA: 0x3478A20
	internal int get_rawRenderQueue() { }

	// RVA: 0x3478A70 Offset: 0x3478B71 VA: 0x3478A70
	public void EnableKeyword(string keyword) { }

	// RVA: 0x3478AC0 Offset: 0x3478BC1 VA: 0x3478AC0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x3478B10 Offset: 0x3478C11 VA: 0x3478B10
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x3478B60 Offset: 0x3478C61 VA: 0x3478B60
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	// RVA: 0x3478BB0 Offset: 0x3478CB1 VA: 0x3478BB0
	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	// RVA: 0x3478C00 Offset: 0x3478D01 VA: 0x3478C00
	public bool get_doubleSidedGI() { }

	// RVA: 0x3478C50 Offset: 0x3478D51 VA: 0x3478C50
	public void set_doubleSidedGI(bool value) { }

	// RVA: 0x3478CA0 Offset: 0x3478DA1 VA: 0x3478CA0
	public bool get_enableInstancing() { }

	// RVA: 0x3478CF0 Offset: 0x3478DF1 VA: 0x3478CF0
	public void set_enableInstancing(bool value) { }

	[NativeNameAttribute] // RVA: 0x449570 Offset: 0x449671 VA: 0x449570
	// RVA: 0x3478D40 Offset: 0x3478E41 VA: 0x3478D40
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x4495B0 Offset: 0x4496B1 VA: 0x4495B0
	// RVA: 0x3478D90 Offset: 0x3478E91 VA: 0x3478D90
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0x449600 Offset: 0x449701 VA: 0x449600
	// RVA: 0x3478DF0 Offset: 0x3478EF1 VA: 0x3478DF0
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x3478E40 Offset: 0x3478F41 VA: 0x3478E40
	public string GetPassName(int pass) { }

	// RVA: 0x3478E90 Offset: 0x3478F91 VA: 0x3478E90
	public int FindPass(string passName) { }

	// RVA: 0x3478EE0 Offset: 0x3478FE1 VA: 0x3478EE0
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x449650 Offset: 0x449751 VA: 0x449650
	// RVA: 0x3478F40 Offset: 0x3479041 VA: 0x3478F40
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x3478FB0 Offset: 0x34790B1 VA: 0x3478FB0
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x3479020 Offset: 0x3479121 VA: 0x3479020
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x449690 Offset: 0x449791 VA: 0x449690
	[NativeThrowsAttribute] // RVA: 0x449690 Offset: 0x449791 VA: 0x449690
	// RVA: 0x34790C0 Offset: 0x34791C1 VA: 0x34790C0
	public void Lerp(Material start, Material end, float t) { }

	[FreeFunctionAttribute] // RVA: 0x4496F0 Offset: 0x4497F1 VA: 0x4496F0
	// RVA: 0x3479130 Offset: 0x3479231 VA: 0x3479130
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x449740 Offset: 0x449841 VA: 0x449740
	// RVA: 0x3479180 Offset: 0x3479281 VA: 0x3479180
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x449790 Offset: 0x449891 VA: 0x449790
	// RVA: 0x34791D0 Offset: 0x34792D1 VA: 0x34791D0
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x4497E0 Offset: 0x4498E1 VA: 0x4497E0
	// RVA: 0x3479220 Offset: 0x3479321 VA: 0x3479220
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x3479270 Offset: 0x3479371 VA: 0x3479270
	public string[] get_shaderKeywords() { }

	// RVA: 0x34792C0 Offset: 0x34793C1 VA: 0x34792C0
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x3479310 Offset: 0x3479411 VA: 0x3479310
	public int ComputeCRC() { }

	[FreeFunctionAttribute] // RVA: 0x449830 Offset: 0x449931 VA: 0x449830
	// RVA: 0x3479360 Offset: 0x3479461 VA: 0x3479360
	public string[] GetTexturePropertyNames() { }

	[FreeFunctionAttribute] // RVA: 0x449880 Offset: 0x449981 VA: 0x449880
	// RVA: 0x34793B0 Offset: 0x34794B1 VA: 0x34793B0
	public int[] GetTexturePropertyNameIDs() { }

	[FreeFunctionAttribute] // RVA: 0x4498D0 Offset: 0x4499D1 VA: 0x4498D0
	// RVA: 0x3479400 Offset: 0x3479501 VA: 0x3479400
	private void GetTexturePropertyNamesInternal(object outNames) { }

	[FreeFunctionAttribute] // RVA: 0x449920 Offset: 0x449A21 VA: 0x449920
	// RVA: 0x3479450 Offset: 0x3479551 VA: 0x3479450
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	// RVA: 0x34794A0 Offset: 0x34795A1 VA: 0x34794A0
	public void GetTexturePropertyNames(List<string> outNames) { }

	// RVA: 0x3479540 Offset: 0x3479641 VA: 0x3479540
	public void GetTexturePropertyNameIDs(List<int> outNames) { }

	[NativeNameAttribute] // RVA: 0x449970 Offset: 0x449A71 VA: 0x449970
	// RVA: 0x34795E0 Offset: 0x34796E1 VA: 0x34795E0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x4499B0 Offset: 0x449AB1 VA: 0x4499B0
	// RVA: 0x3479640 Offset: 0x3479741 VA: 0x3479640
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x4499F0 Offset: 0x449AF1 VA: 0x4499F0
	// RVA: 0x3479710 Offset: 0x3479811 VA: 0x3479710
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x449A30 Offset: 0x449B31 VA: 0x449A30
	// RVA: 0x34797D0 Offset: 0x34798D1 VA: 0x34797D0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x449A70 Offset: 0x449B71 VA: 0x449A70
	// RVA: 0x3479830 Offset: 0x3479931 VA: 0x3479830
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[NativeNameAttribute] // RVA: 0x449AB0 Offset: 0x449BB1 VA: 0x449AB0
	// RVA: 0x34798A0 Offset: 0x34799A1 VA: 0x34798A0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x449AF0 Offset: 0x449BF1 VA: 0x449AF0
	// RVA: 0x3479900 Offset: 0x3479A01 VA: 0x3479900
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[NativeNameAttribute] // RVA: 0x449B30 Offset: 0x449C31 VA: 0x449B30
	// RVA: 0x3479960 Offset: 0x3479A61 VA: 0x3479960
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[NativeNameAttribute] // RVA: 0x449B70 Offset: 0x449C71 VA: 0x449B70
	// RVA: 0x34799D0 Offset: 0x3479AD1 VA: 0x34799D0
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[NativeNameAttribute] // RVA: 0x449BB0 Offset: 0x449CB1 VA: 0x449BB0
	// RVA: 0x3479A40 Offset: 0x3479B41 VA: 0x3479A40
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x449BF0 Offset: 0x449CF1 VA: 0x449BF0
	// RVA: 0x3479A90 Offset: 0x3479B91 VA: 0x3479A90
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x449C30 Offset: 0x449D31 VA: 0x449C30
	// RVA: 0x3479B60 Offset: 0x3479C61 VA: 0x3479B60
	private Matrix4x4 GetMatrixImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x449C70 Offset: 0x449D71 VA: 0x449C70
	// RVA: 0x3479C60 Offset: 0x3479D61 VA: 0x3479C60
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449CB0 Offset: 0x449DB1 VA: 0x449CB0
	// RVA: 0x3479CB0 Offset: 0x3479DB1 VA: 0x3479CB0
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x449D00 Offset: 0x449E01 VA: 0x449D00
	// RVA: 0x3479D20 Offset: 0x3479E21 VA: 0x3479D20
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x449D50 Offset: 0x449E51 VA: 0x449D50
	// RVA: 0x3479D90 Offset: 0x3479E91 VA: 0x3479D90
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x449DA0 Offset: 0x449EA1 VA: 0x449DA0
	// RVA: 0x3479E00 Offset: 0x3479F01 VA: 0x3479E00
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x449DF0 Offset: 0x449EF1 VA: 0x449DF0
	// RVA: 0x3479E70 Offset: 0x3479F71 VA: 0x3479E70
	private float[] GetFloatArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449E40 Offset: 0x449F41 VA: 0x449E40
	// RVA: 0x3479EC0 Offset: 0x3479FC1 VA: 0x3479EC0
	private Vector4[] GetVectorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449E90 Offset: 0x449F91 VA: 0x449E90
	// RVA: 0x3479F10 Offset: 0x347A011 VA: 0x3479F10
	private Color[] GetColorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449EE0 Offset: 0x449FE1 VA: 0x449EE0
	// RVA: 0x3479F60 Offset: 0x347A061 VA: 0x3479F60
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449F30 Offset: 0x44A031 VA: 0x449F30
	// RVA: 0x3479FB0 Offset: 0x347A0B1 VA: 0x3479FB0
	private int GetFloatArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449F80 Offset: 0x44A081 VA: 0x449F80
	// RVA: 0x347A000 Offset: 0x347A101 VA: 0x347A000
	private int GetVectorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x449FD0 Offset: 0x44A0D1 VA: 0x449FD0
	// RVA: 0x347A050 Offset: 0x347A151 VA: 0x347A050
	private int GetColorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x44A020 Offset: 0x44A121 VA: 0x44A020
	// RVA: 0x347A0A0 Offset: 0x347A1A1 VA: 0x347A0A0
	private int GetMatrixArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x44A070 Offset: 0x44A171 VA: 0x44A070
	// RVA: 0x347A0F0 Offset: 0x347A1F1 VA: 0x347A0F0
	private void ExtractFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunctionAttribute] // RVA: 0x44A0C0 Offset: 0x44A1C1 VA: 0x44A0C0
	// RVA: 0x347A150 Offset: 0x347A251 VA: 0x347A150
	private void ExtractVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunctionAttribute] // RVA: 0x44A110 Offset: 0x44A211 VA: 0x44A110
	// RVA: 0x347A1B0 Offset: 0x347A2B1 VA: 0x347A1B0
	private void ExtractColorArrayImpl(int name, [Out] Color[] val) { }

	[FreeFunctionAttribute] // RVA: 0x44A160 Offset: 0x44A261 VA: 0x44A160
	// RVA: 0x347A210 Offset: 0x347A311 VA: 0x347A210
	private void ExtractMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	[NativeNameAttribute] // RVA: 0x44A1B0 Offset: 0x44A2B1 VA: 0x44A1B0
	// RVA: 0x347A270 Offset: 0x347A371 VA: 0x347A270
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x44A1F0 Offset: 0x44A2F1 VA: 0x44A1F0
	// RVA: 0x347A340 Offset: 0x347A441 VA: 0x347A340
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x44A230 Offset: 0x44A331 VA: 0x44A230
	// RVA: 0x347A400 Offset: 0x347A501 VA: 0x347A400
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x347A4C0 Offset: 0x347A5C1 VA: 0x347A4C0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x347A5E0 Offset: 0x347A6E1 VA: 0x347A5E0
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x347A700 Offset: 0x347A801 VA: 0x347A700
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x347A820 Offset: 0x347A921 VA: 0x347A820
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x347A940 Offset: 0x347AA41 VA: 0x347A940
	private void ExtractFloatArray(int name, List<float> values) { }

	// RVA: 0x347AB60 Offset: 0x347AC61 VA: 0x347AB60
	private void ExtractVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x347AD30 Offset: 0x347AE31 VA: 0x347AD30
	private void ExtractColorArray(int name, List<Color> values) { }

	// RVA: 0x347AF00 Offset: 0x347B001 VA: 0x347AF00
	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x347B0D0 Offset: 0x347B1D1 VA: 0x347B0D0
	public void SetFloat(string name, float value) { }

	// RVA: 0x347B140 Offset: 0x347B241 VA: 0x347B140
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x347B1A0 Offset: 0x347B2A1 VA: 0x347B1A0
	public void SetInt(string name, int value) { }

	// RVA: 0x347B210 Offset: 0x347B311 VA: 0x347B210
	public void SetInt(int nameID, int value) { }

	// RVA: 0x3477D70 Offset: 0x3477E71 VA: 0x3477D70
	public void SetColor(string name, Color value) { }

	// RVA: 0x3477D00 Offset: 0x3477E01 VA: 0x3477D00
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x347B270 Offset: 0x347B371 VA: 0x347B270
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x347B320 Offset: 0x347B421 VA: 0x347B320
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x347B390 Offset: 0x347B491 VA: 0x347B390
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x347B420 Offset: 0x347B521 VA: 0x347B420
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x3478100 Offset: 0x3478201 VA: 0x3478100
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x34780A0 Offset: 0x34781A1 VA: 0x34780A0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x347B4A0 Offset: 0x347B5A1 VA: 0x347B4A0
	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x347B520 Offset: 0x347B621 VA: 0x347B520
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x347B590 Offset: 0x347B691 VA: 0x347B590
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x347B600 Offset: 0x347B701 VA: 0x347B600
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x347B660 Offset: 0x347B761 VA: 0x347B660
	public void SetBuffer(string name, GraphicsBuffer value) { }

	// RVA: 0x347B6D0 Offset: 0x347B7D1 VA: 0x347B6D0
	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	// RVA: 0x347B730 Offset: 0x347B831 VA: 0x347B730
	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x347B7B0 Offset: 0x347B8B1 VA: 0x347B7B0
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x347B820 Offset: 0x347B921 VA: 0x347B820
	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x347B8A0 Offset: 0x347B9A1 VA: 0x347B8A0
	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x347B910 Offset: 0x347BA11 VA: 0x347B910
	public void SetFloatArray(string name, List<float> values) { }

	// RVA: 0x347B9B0 Offset: 0x347BAB1 VA: 0x347B9B0
	public void SetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x347BA40 Offset: 0x347BB41 VA: 0x347BA40
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x347BA80 Offset: 0x347BB81 VA: 0x347BA80
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x347BA90 Offset: 0x347BB91 VA: 0x347BA90
	public void SetColorArray(string name, List<Color> values) { }

	// RVA: 0x347BB30 Offset: 0x347BC31 VA: 0x347BB30
	public void SetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x347BBC0 Offset: 0x347BCC1 VA: 0x347BBC0
	public void SetColorArray(string name, Color[] values) { }

	// RVA: 0x347BC00 Offset: 0x347BD01 VA: 0x347BC00
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x347BC10 Offset: 0x347BD11 VA: 0x347BC10
	public void SetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x347BCB0 Offset: 0x347BDB1 VA: 0x347BCB0
	public void SetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x347BD40 Offset: 0x347BE41 VA: 0x347BD40
	public void SetVectorArray(string name, Vector4[] values) { }

	// RVA: 0x347BD80 Offset: 0x347BE81 VA: 0x347BD80
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x347BD90 Offset: 0x347BE91 VA: 0x347BD90
	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x347BE30 Offset: 0x347BF31 VA: 0x347BE30
	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x347BEC0 Offset: 0x347BFC1 VA: 0x347BEC0
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x347BF00 Offset: 0x347C001 VA: 0x347BF00
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x347BF10 Offset: 0x347C011 VA: 0x347BF10
	public float GetFloat(string name) { }

	// RVA: 0x347BF70 Offset: 0x347C071 VA: 0x347BF70
	public float GetFloat(int nameID) { }

	// RVA: 0x347BFC0 Offset: 0x347C0C1 VA: 0x347BFC0
	public int GetInt(string name) { }

	// RVA: 0x347C040 Offset: 0x347C141 VA: 0x347C040
	public int GetInt(int nameID) { }

	// RVA: 0x3477B70 Offset: 0x3477C71 VA: 0x3477B70
	public Color GetColor(string name) { }

	// RVA: 0x3477B00 Offset: 0x3477C01 VA: 0x3477B00
	public Color GetColor(int nameID) { }

	// RVA: 0x347C0B0 Offset: 0x347C1B1 VA: 0x347C0B0
	public Vector4 GetVector(string name) { }

	// RVA: 0x347C130 Offset: 0x347C231 VA: 0x347C130
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x347C1B0 Offset: 0x347C2B1 VA: 0x347C1B0
	public Matrix4x4 GetMatrix(string name) { }

	// RVA: 0x347C280 Offset: 0x347C381 VA: 0x347C280
	public Matrix4x4 GetMatrix(int nameID) { }

	// RVA: 0x3477F50 Offset: 0x3478051 VA: 0x3477F50
	public Texture GetTexture(string name) { }

	// RVA: 0x3477F00 Offset: 0x3478001 VA: 0x3477F00
	public Texture GetTexture(int nameID) { }

	// RVA: 0x347C340 Offset: 0x347C441 VA: 0x347C340
	public float[] GetFloatArray(string name) { }

	// RVA: 0x347C3F0 Offset: 0x347C4F1 VA: 0x347C3F0
	public float[] GetFloatArray(int nameID) { }

	// RVA: 0x347C4A0 Offset: 0x347C5A1 VA: 0x347C4A0
	public Color[] GetColorArray(string name) { }

	// RVA: 0x347C550 Offset: 0x347C651 VA: 0x347C550
	public Color[] GetColorArray(int nameID) { }

	// RVA: 0x347C600 Offset: 0x347C701 VA: 0x347C600
	public Vector4[] GetVectorArray(string name) { }

	// RVA: 0x347C6B0 Offset: 0x347C7B1 VA: 0x347C6B0
	public Vector4[] GetVectorArray(int nameID) { }

	// RVA: 0x347C760 Offset: 0x347C861 VA: 0x347C760
	public Matrix4x4[] GetMatrixArray(string name) { }

	// RVA: 0x347C810 Offset: 0x347C911 VA: 0x347C810
	public Matrix4x4[] GetMatrixArray(int nameID) { }

	// RVA: 0x347C8C0 Offset: 0x347C9C1 VA: 0x347C8C0
	public void GetFloatArray(string name, List<float> values) { }

	// RVA: 0x347C900 Offset: 0x347CA01 VA: 0x347C900
	public void GetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x347C910 Offset: 0x347CA11 VA: 0x347C910
	public void GetColorArray(string name, List<Color> values) { }

	// RVA: 0x347C950 Offset: 0x347CA51 VA: 0x347C950
	public void GetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x347C960 Offset: 0x347CA61 VA: 0x347C960
	public void GetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x347C9A0 Offset: 0x347CAA1 VA: 0x347C9A0
	public void GetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x347C9B0 Offset: 0x347CAB1 VA: 0x347C9B0
	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x347C9F0 Offset: 0x347CAF1 VA: 0x347C9F0
	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x34784A0 Offset: 0x34785A1 VA: 0x34784A0
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x3478440 Offset: 0x3478541 VA: 0x3478440
	public void SetTextureOffset(int nameID, Vector2 value) { }

	// RVA: 0x3478850 Offset: 0x3478951 VA: 0x3478850
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x34787F0 Offset: 0x34788F1 VA: 0x34787F0
	public void SetTextureScale(int nameID, Vector2 value) { }

	// RVA: 0x34782D0 Offset: 0x34783D1 VA: 0x34782D0
	public Vector2 GetTextureOffset(string name) { }

	// RVA: 0x3478260 Offset: 0x3478361 VA: 0x3478260
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x3478680 Offset: 0x3478781 VA: 0x3478680
	public Vector2 GetTextureScale(string name) { }

	// RVA: 0x3478610 Offset: 0x3478711 VA: 0x3478610
	public Vector2 GetTextureScale(int nameID) { }

	// RVA: 0x34796B0 Offset: 0x34797B1 VA: 0x34796B0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x3479770 Offset: 0x3479871 VA: 0x3479770
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x3479B00 Offset: 0x3479C01 VA: 0x3479B00
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x3479C00 Offset: 0x3479D01 VA: 0x3479C00
	private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x347A2E0 Offset: 0x347A3E1 VA: 0x347A2E0
	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x347A3A0 Offset: 0x347A4A1 VA: 0x347A3A0
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x347A460 Offset: 0x347A561 VA: 0x347A460
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }
}

