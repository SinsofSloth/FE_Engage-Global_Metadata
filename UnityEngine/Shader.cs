// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
[NativeHeaderAttribute] // RVA: 0x43CB10 Offset: 0x43CC11 VA: 0x43CB10
public sealed class Shader : Object // TypeDefIndex: 3459
{
	// Properties
	[ObsoleteAttribute] // RVA: 0x459A60 Offset: 0x459B61 VA: 0x459A60
	public static ShaderHardwareTier globalShaderHardwareTier { get; set; }
	[NativePropertyAttribute] // RVA: 0x459AA0 Offset: 0x459BA1 VA: 0x459AA0
	public int maximumLOD { get; set; }
	[NativePropertyAttribute] // RVA: 0x459AE0 Offset: 0x459BE1 VA: 0x459AE0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public static string globalRenderPipeline { get; set; }
	public int renderQueue { get; }
	internal DisableBatchingType disableBatching { get; }
	public int passCount { get; }

	// Methods

	// RVA: 0x31E6900 Offset: 0x31E6A01 VA: 0x31E6900
	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	// RVA: 0x31E6970 Offset: 0x31E6A71 VA: 0x31E6970
	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	// RVA: 0x31E69E0 Offset: 0x31E6AE1 VA: 0x31E69E0
	public static Shader Find(string name) { }

	[FreeFunctionAttribute] // RVA: 0x4486A0 Offset: 0x4487A1 VA: 0x4486A0
	// RVA: 0x31E6A60 Offset: 0x31E6B61 VA: 0x31E6A60
	internal static Shader FindBuiltin(string name) { }

	// RVA: 0x31E6AB0 Offset: 0x31E6BB1 VA: 0x31E6AB0
	public int get_maximumLOD() { }

	// RVA: 0x31E6B00 Offset: 0x31E6C01 VA: 0x31E6B00
	public void set_maximumLOD(int value) { }

	// RVA: 0x31E6B50 Offset: 0x31E6C51 VA: 0x31E6B50
	public static int get_globalMaximumLOD() { }

	// RVA: 0x31E6B90 Offset: 0x31E6C91 VA: 0x31E6B90
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0x4486E0 Offset: 0x4487E1 VA: 0x4486E0
	// RVA: 0x31E6BE0 Offset: 0x31E6CE1 VA: 0x31E6BE0
	public bool get_isSupported() { }

	// RVA: 0x31E6C30 Offset: 0x31E6D31 VA: 0x31E6C30
	public static string get_globalRenderPipeline() { }

	// RVA: 0x31E6C70 Offset: 0x31E6D71 VA: 0x31E6C70
	public static void set_globalRenderPipeline(string value) { }

	[FreeFunctionAttribute] // RVA: 0x448720 Offset: 0x448821 VA: 0x448720
	// RVA: 0x31E6CC0 Offset: 0x31E6DC1 VA: 0x31E6CC0
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x448760 Offset: 0x448861 VA: 0x448760
	// RVA: 0x31E6D10 Offset: 0x31E6E11 VA: 0x31E6D10
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x4487A0 Offset: 0x4488A1 VA: 0x4487A0
	// RVA: 0x31E6D60 Offset: 0x31E6E61 VA: 0x31E6D60
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x4487E0 Offset: 0x4488E1 VA: 0x4487E0
	// RVA: 0x31E6DB0 Offset: 0x31E6EB1 VA: 0x31E6DB0
	public int get_renderQueue() { }

	[FreeFunctionAttribute] // RVA: 0x448830 Offset: 0x448931 VA: 0x448830
	// RVA: 0x31E6E00 Offset: 0x31E6F01 VA: 0x31E6E00
	internal DisableBatchingType get_disableBatching() { }

	[FreeFunctionAttribute] // RVA: 0x448880 Offset: 0x448981 VA: 0x448880
	// RVA: 0x31E6E50 Offset: 0x31E6F51 VA: 0x31E6E50
	public static void WarmupAllShaders() { }

	[FreeFunctionAttribute] // RVA: 0x448890 Offset: 0x448991 VA: 0x448890
	// RVA: 0x31E6E90 Offset: 0x31E6F91 VA: 0x31E6E90
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0x4488D0 Offset: 0x4489D1 VA: 0x4488D0
	// RVA: 0x31E6EE0 Offset: 0x31E6FE1 VA: 0x31E6EE0
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448910 Offset: 0x448A11 VA: 0x448910
	// RVA: 0x31E6F30 Offset: 0x31E7031 VA: 0x31E6F30
	public static int PropertyToID(string name) { }

	// RVA: 0x31E6F80 Offset: 0x31E7081 VA: 0x31E6F80
	public Shader GetDependency(string name) { }

	[FreeFunctionAttribute] // RVA: 0x448960 Offset: 0x448A61 VA: 0x448960
	// RVA: 0x31E6FD0 Offset: 0x31E70D1 VA: 0x31E6FD0
	public int get_passCount() { }

	// RVA: 0x31E7020 Offset: 0x31E7121 VA: 0x31E7020
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0x4489B0 Offset: 0x448AB1 VA: 0x4489B0
	// RVA: 0x31E7110 Offset: 0x31E7211 VA: 0x31E7110
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0x448A00 Offset: 0x448B01 VA: 0x448A00
	// RVA: 0x31E7180 Offset: 0x31E7281 VA: 0x31E7180
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0x448A40 Offset: 0x448B41 VA: 0x448A40
	// RVA: 0x31E71D0 Offset: 0x31E72D1 VA: 0x31E71D0
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x448A80 Offset: 0x448B81 VA: 0x448A80
	// RVA: 0x31E7280 Offset: 0x31E7381 VA: 0x31E7280
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x448AC0 Offset: 0x448BC1 VA: 0x448AC0
	// RVA: 0x31E7320 Offset: 0x31E7421 VA: 0x31E7320
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0x448B00 Offset: 0x448C01 VA: 0x448B00
	// RVA: 0x31E7370 Offset: 0x31E7471 VA: 0x31E7370
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x448B40 Offset: 0x448C41 VA: 0x448B40
	// RVA: 0x31E73D0 Offset: 0x31E74D1 VA: 0x31E73D0
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x448B80 Offset: 0x448C81 VA: 0x448B80
	// RVA: 0x31E7420 Offset: 0x31E7521 VA: 0x31E7420
	private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x448BC0 Offset: 0x448CC1 VA: 0x448BC0
	// RVA: 0x31E7470 Offset: 0x31E7571 VA: 0x31E7470
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunctionAttribute] // RVA: 0x448C00 Offset: 0x448D01 VA: 0x448C00
	// RVA: 0x31E74E0 Offset: 0x31E75E1 VA: 0x31E74E0
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[FreeFunctionAttribute] // RVA: 0x448C40 Offset: 0x448D41 VA: 0x448C40
	// RVA: 0x31E7550 Offset: 0x31E7651 VA: 0x31E7550
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448C80 Offset: 0x448D81 VA: 0x448C80
	// RVA: 0x31E75A0 Offset: 0x31E76A1 VA: 0x31E75A0
	private static Vector4 GetGlobalVectorImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448CC0 Offset: 0x448DC1 VA: 0x448CC0
	// RVA: 0x31E7650 Offset: 0x31E7751 VA: 0x31E7650
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448D00 Offset: 0x448E01 VA: 0x448D00
	// RVA: 0x31E7730 Offset: 0x31E7831 VA: 0x31E7730
	private static Texture GetGlobalTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448D40 Offset: 0x448E41 VA: 0x448D40
	// RVA: 0x31E7780 Offset: 0x31E7881 VA: 0x31E7780
	private static void SetGlobalFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x448D80 Offset: 0x448E81 VA: 0x448D80
	// RVA: 0x31E77E0 Offset: 0x31E78E1 VA: 0x31E77E0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x448DC0 Offset: 0x448EC1 VA: 0x448DC0
	// RVA: 0x31E7840 Offset: 0x31E7941 VA: 0x31E7840
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0x448E00 Offset: 0x448F01 VA: 0x448E00
	// RVA: 0x31E78A0 Offset: 0x31E79A1 VA: 0x31E78A0
	private static float[] GetGlobalFloatArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448E40 Offset: 0x448F41 VA: 0x448E40
	// RVA: 0x31E78F0 Offset: 0x31E79F1 VA: 0x31E78F0
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448E80 Offset: 0x448F81 VA: 0x448E80
	// RVA: 0x31E7940 Offset: 0x31E7A41 VA: 0x31E7940
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448EC0 Offset: 0x448FC1 VA: 0x448EC0
	// RVA: 0x31E7990 Offset: 0x31E7A91 VA: 0x31E7990
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448F00 Offset: 0x449001 VA: 0x448F00
	// RVA: 0x31E79E0 Offset: 0x31E7AE1 VA: 0x31E79E0
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448F40 Offset: 0x449041 VA: 0x448F40
	// RVA: 0x31E7A30 Offset: 0x31E7B31 VA: 0x31E7A30
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x448F80 Offset: 0x449081 VA: 0x448F80
	// RVA: 0x31E7A80 Offset: 0x31E7B81 VA: 0x31E7A80
	private static void ExtractGlobalFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunctionAttribute] // RVA: 0x448FC0 Offset: 0x4490C1 VA: 0x448FC0
	// RVA: 0x31E7AD0 Offset: 0x31E7BD1 VA: 0x31E7AD0
	private static void ExtractGlobalVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunctionAttribute] // RVA: 0x449000 Offset: 0x449101 VA: 0x449000
	// RVA: 0x31E7B20 Offset: 0x31E7C21 VA: 0x31E7B20
	private static void ExtractGlobalMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	// RVA: 0x31E7B70 Offset: 0x31E7C71 VA: 0x31E7B70
	private static void SetGlobalFloatArray(int name, float[] values, int count) { }

	// RVA: 0x31E7C80 Offset: 0x31E7D81 VA: 0x31E7C80
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x31E7D90 Offset: 0x31E7E91 VA: 0x31E7D90
	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x31E7EA0 Offset: 0x31E7FA1 VA: 0x31E7EA0
	private static void ExtractGlobalFloatArray(int name, List<float> values) { }

	// RVA: 0x31E8040 Offset: 0x31E8141 VA: 0x31E8040
	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x31E81E0 Offset: 0x31E82E1 VA: 0x31E81E0
	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x31E8380 Offset: 0x31E8481 VA: 0x31E8380
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x31E8400 Offset: 0x31E8501 VA: 0x31E8400
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x31E8450 Offset: 0x31E8551 VA: 0x31E8450
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x31E84E0 Offset: 0x31E85E1 VA: 0x31E84E0
	public static void SetGlobalInt(int nameID, int value) { }

	// RVA: 0x31E8530 Offset: 0x31E8631 VA: 0x31E8530
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x31E85E0 Offset: 0x31E86E1 VA: 0x31E85E0
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x31E8640 Offset: 0x31E8741 VA: 0x31E8640
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x31E8700 Offset: 0x31E8801 VA: 0x31E8700
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x31E8760 Offset: 0x31E8861 VA: 0x31E8760
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x31E8810 Offset: 0x31E8911 VA: 0x31E8810
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x31E8880 Offset: 0x31E8981 VA: 0x31E8880
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x31E8900 Offset: 0x31E8A01 VA: 0x31E8900
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x31E8950 Offset: 0x31E8A51 VA: 0x31E8950
	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x31E89E0 Offset: 0x31E8AE1 VA: 0x31E89E0
	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x31E8A40 Offset: 0x31E8B41 VA: 0x31E8A40
	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x31E8AC0 Offset: 0x31E8BC1 VA: 0x31E8AC0
	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x31E8B10 Offset: 0x31E8C11 VA: 0x31E8B10
	public static void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	// RVA: 0x31E8B90 Offset: 0x31E8C91 VA: 0x31E8B90
	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	// RVA: 0x31E8BE0 Offset: 0x31E8CE1 VA: 0x31E8BE0
	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x31E8C80 Offset: 0x31E8D81 VA: 0x31E8C80
	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x31E8CF0 Offset: 0x31E8DF1 VA: 0x31E8CF0
	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x31E8D90 Offset: 0x31E8E91 VA: 0x31E8D90
	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x31E8E00 Offset: 0x31E8F01 VA: 0x31E8E00
	public static void SetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x31E8EA0 Offset: 0x31E8FA1 VA: 0x31E8EA0
	public static void SetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x31E8F20 Offset: 0x31E9021 VA: 0x31E8F20
	public static void SetGlobalFloatArray(string name, float[] values) { }

	// RVA: 0x31E8F80 Offset: 0x31E9081 VA: 0x31E8F80
	public static void SetGlobalFloatArray(int nameID, float[] values) { }

	// RVA: 0x31E8F90 Offset: 0x31E9091 VA: 0x31E8F90
	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x31E9030 Offset: 0x31E9131 VA: 0x31E9030
	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x31E90B0 Offset: 0x31E91B1 VA: 0x31E90B0
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x31E9110 Offset: 0x31E9211 VA: 0x31E9110
	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x31E9120 Offset: 0x31E9221 VA: 0x31E9120
	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x31E91C0 Offset: 0x31E92C1 VA: 0x31E91C0
	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x31E9240 Offset: 0x31E9341 VA: 0x31E9240
	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x31E92A0 Offset: 0x31E93A1 VA: 0x31E92A0
	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x31E92B0 Offset: 0x31E93B1 VA: 0x31E92B0
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x31E9330 Offset: 0x31E9431 VA: 0x31E9330
	public static float GetGlobalFloat(int nameID) { }

	// RVA: 0x31E9380 Offset: 0x31E9481 VA: 0x31E9380
	public static int GetGlobalInt(string name) { }

	// RVA: 0x31E9410 Offset: 0x31E9511 VA: 0x31E9410
	public static int GetGlobalInt(int nameID) { }

	// RVA: 0x31E9470 Offset: 0x31E9571 VA: 0x31E9470
	public static Vector4 GetGlobalVector(string name) { }

	// RVA: 0x31E9500 Offset: 0x31E9601 VA: 0x31E9500
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x31E9560 Offset: 0x31E9661 VA: 0x31E9560
	public static Color GetGlobalColor(string name) { }

	// RVA: 0x31E95F0 Offset: 0x31E96F1 VA: 0x31E95F0
	public static Color GetGlobalColor(int nameID) { }

	// RVA: 0x31E9660 Offset: 0x31E9761 VA: 0x31E9660
	public static Matrix4x4 GetGlobalMatrix(string name) { }

	// RVA: 0x31E9740 Offset: 0x31E9841 VA: 0x31E9740
	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	// RVA: 0x31E9800 Offset: 0x31E9901 VA: 0x31E9800
	public static Texture GetGlobalTexture(string name) { }

	// RVA: 0x31E9880 Offset: 0x31E9981 VA: 0x31E9880
	public static Texture GetGlobalTexture(int nameID) { }

	// RVA: 0x31E98D0 Offset: 0x31E99D1 VA: 0x31E98D0
	public static float[] GetGlobalFloatArray(string name) { }

	// RVA: 0x31E99A0 Offset: 0x31E9AA1 VA: 0x31E99A0
	public static float[] GetGlobalFloatArray(int nameID) { }

	// RVA: 0x31E9A40 Offset: 0x31E9B41 VA: 0x31E9A40
	public static Vector4[] GetGlobalVectorArray(string name) { }

	// RVA: 0x31E9B10 Offset: 0x31E9C11 VA: 0x31E9B10
	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	// RVA: 0x31E9BB0 Offset: 0x31E9CB1 VA: 0x31E9BB0
	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	// RVA: 0x31E9C80 Offset: 0x31E9D81 VA: 0x31E9C80
	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	// RVA: 0x31E9D20 Offset: 0x31E9E21 VA: 0x31E9D20
	public static void GetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x31E9D80 Offset: 0x31E9E81 VA: 0x31E9D80
	public static void GetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x31E9D90 Offset: 0x31E9E91 VA: 0x31E9D90
	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x31E9DF0 Offset: 0x31E9EF1 VA: 0x31E9DF0
	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x31E9E00 Offset: 0x31E9F01 VA: 0x31E9E00
	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x31E9E60 Offset: 0x31E9F61 VA: 0x31E9E60
	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x31E9E70 Offset: 0x31E9F71 VA: 0x31E9E70
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x449040 Offset: 0x449141 VA: 0x449040
	// RVA: 0x31E9EE0 Offset: 0x31E9FE1 VA: 0x31E9EE0
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449080 Offset: 0x449181 VA: 0x449080
	// RVA: 0x31E9F30 Offset: 0x31EA031 VA: 0x31E9F30
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x4490C0 Offset: 0x4491C1 VA: 0x4490C0
	// RVA: 0x31E9F80 Offset: 0x31EA081 VA: 0x31E9F80
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449100 Offset: 0x449201 VA: 0x449100
	// RVA: 0x31E9FD0 Offset: 0x31EA0D1 VA: 0x31E9FD0
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449140 Offset: 0x449241 VA: 0x449140
	// RVA: 0x31EA020 Offset: 0x31EA121 VA: 0x31EA020
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449180 Offset: 0x449281 VA: 0x449180
	// RVA: 0x31EA070 Offset: 0x31EA171 VA: 0x31EA070
	private static string[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x4491C0 Offset: 0x4492C1 VA: 0x4491C0
	// RVA: 0x31EA0C0 Offset: 0x31EA1C1 VA: 0x31EA0C0
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449200 Offset: 0x449301 VA: 0x449200
	// RVA: 0x31EA190 Offset: 0x31EA291 VA: 0x31EA190
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449240 Offset: 0x449341 VA: 0x449240
	// RVA: 0x31EA1E0 Offset: 0x31EA2E1 VA: 0x31EA1E0
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0x449280 Offset: 0x449381 VA: 0x449280
	// RVA: 0x31EA230 Offset: 0x31EA331 VA: 0x31EA230
	private static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex) { }

	// RVA: 0x31EA2A0 Offset: 0x31EA3A1 VA: 0x31EA2A0
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x31EA350 Offset: 0x31EA451 VA: 0x31EA350
	public int GetPropertyCount() { }

	// RVA: 0x31EA3A0 Offset: 0x31EA4A1 VA: 0x31EA3A0
	public int FindPropertyIndex(string propertyName) { }

	// RVA: 0x31EA3F0 Offset: 0x31EA4F1 VA: 0x31EA3F0
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x31EA450 Offset: 0x31EA551 VA: 0x31EA450
	public int GetPropertyNameId(int propertyIndex) { }

	// RVA: 0x31EA4B0 Offset: 0x31EA5B1 VA: 0x31EA4B0
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x31EA510 Offset: 0x31EA611 VA: 0x31EA510
	public string GetPropertyDescription(int propertyIndex) { }

	// RVA: 0x31EA570 Offset: 0x31EA671 VA: 0x31EA570
	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	// RVA: 0x31EA5D0 Offset: 0x31EA6D1 VA: 0x31EA5D0
	public string[] GetPropertyAttributes(int propertyIndex) { }

	// RVA: 0x31EA630 Offset: 0x31EA731 VA: 0x31EA630
	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	// RVA: 0x31EA750 Offset: 0x31EA851 VA: 0x31EA750
	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	// RVA: 0x31EA850 Offset: 0x31EA951 VA: 0x31EA850
	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	// RVA: 0x31EA990 Offset: 0x31EAA91 VA: 0x31EA990
	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	// RVA: 0x31EAA70 Offset: 0x31EAB71 VA: 0x31EAA70
	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	// RVA: 0x31EAB50 Offset: 0x31EAC51 VA: 0x31EAB50
	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex) { }

	// RVA: 0x31E7230 Offset: 0x31E7331 VA: 0x31E7230
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x31E72D0 Offset: 0x31E73D1 VA: 0x31E72D0
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x31E7600 Offset: 0x31E7701 VA: 0x31E7600
	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x31E76E0 Offset: 0x31E77E1 VA: 0x31E76E0
	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x31EA130 Offset: 0x31EA231 VA: 0x31EA130
	private static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret) { }
}

