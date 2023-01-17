// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D3D0 Offset: 0x43D4D1 VA: 0x43D3D0
[UsedByNativeCodeAttribute] // RVA: 0x43D3D0 Offset: 0x43D4D1 VA: 0x43D3D0
[NativeHeaderAttribute] // RVA: 0x43D3D0 Offset: 0x43D4D1 VA: 0x43D3D0
public sealed class Texture2D : Texture // TypeDefIndex: 3516
{
	// Properties
	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0x459F00 Offset: 0x45A001 VA: 0x459F00
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x459F40 Offset: 0x45A041 VA: 0x459F40
	public static Texture2D blackTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x459F80 Offset: 0x45A081 VA: 0x459F80
	public static Texture2D redTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x459FC0 Offset: 0x45A0C1 VA: 0x459FC0
	public static Texture2D grayTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x45A000 Offset: 0x45A101 VA: 0x45A000
	public static Texture2D linearGrayTexture { get; }
	[StaticAccessorAttribute] // RVA: 0x45A040 Offset: 0x45A141 VA: 0x45A040
	public static Texture2D normalTexture { get; }
	public override bool isReadable { get; }
	[NativeConditionalAttribute] // RVA: 0x45A080 Offset: 0x45A181 VA: 0x45A080
	[NativeNameAttribute] // RVA: 0x45A080 Offset: 0x45A181 VA: 0x45A080
	public bool vtOnly { get; }
	internal bool isPreProcessed { get; }
	public bool streamingMipmaps { get; }
	public int streamingMipmapsPriority { get; }
	public int requestedMipmapLevel { get; set; }
	public int minimumMipmapLevel { get; set; }
	internal bool loadAllMips { get; set; }
	public int calculatedMipmapLevel { get; }
	public int desiredMipmapLevel { get; }
	public int loadingMipmapLevel { get; }
	public int loadedMipmapLevel { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x44C430 Offset: 0x44C531 VA: 0x44C430
	// RVA: 0x38415C0 Offset: 0x38416C1 VA: 0x38415C0
	public TextureFormat get_format() { }

	// RVA: 0x3841610 Offset: 0x3841711 VA: 0x3841610
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x3841650 Offset: 0x3841751 VA: 0x3841650
	public static Texture2D get_blackTexture() { }

	// RVA: 0x3841690 Offset: 0x3841791 VA: 0x3841690
	public static Texture2D get_redTexture() { }

	// RVA: 0x38416D0 Offset: 0x38417D1 VA: 0x38416D0
	public static Texture2D get_grayTexture() { }

	// RVA: 0x3841710 Offset: 0x3841811 VA: 0x3841710
	public static Texture2D get_linearGrayTexture() { }

	// RVA: 0x3841750 Offset: 0x3841851 VA: 0x3841750
	public static Texture2D get_normalTexture() { }

	// RVA: 0x3841790 Offset: 0x3841891 VA: 0x3841790
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0x44C470 Offset: 0x44C571 VA: 0x44C470
	// RVA: 0x38417E0 Offset: 0x38418E1 VA: 0x38417E0
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x3841870 Offset: 0x3841971 VA: 0x3841870
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x3841950 Offset: 0x3841A51 VA: 0x3841950 Slot: 11
	public override bool get_isReadable() { }

	// RVA: 0x38419A0 Offset: 0x3841AA1 VA: 0x38419A0
	public bool get_vtOnly() { }

	[NativeNameAttribute] // RVA: 0x44C4B0 Offset: 0x44C5B1 VA: 0x44C4B0
	// RVA: 0x38419F0 Offset: 0x3841AF1 VA: 0x38419F0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0x44C4F0 Offset: 0x44C5F1 VA: 0x44C4F0
	// RVA: 0x3841A50 Offset: 0x3841B51 VA: 0x3841A50
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0x44C530 Offset: 0x44C631 VA: 0x44C530
	// RVA: 0x3841AB0 Offset: 0x3841BB1 VA: 0x3841AB0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x44C570 Offset: 0x44C671 VA: 0x44C570
	// RVA: 0x3841BA0 Offset: 0x3841CA1 VA: 0x3841BA0
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x44C5B0 Offset: 0x44C6B1 VA: 0x44C5B0
	// RVA: 0x3841CA0 Offset: 0x3841DA1 VA: 0x3841CA0
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0x44C5F0 Offset: 0x44C6F1 VA: 0x44C5F0
	// RVA: 0x3841DA0 Offset: 0x3841EA1 VA: 0x3841DA0
	private bool ResizeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0x44C640 Offset: 0x44C741 VA: 0x44C640
	// RVA: 0x3841E10 Offset: 0x3841F11 VA: 0x3841E10
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0x44C690 Offset: 0x44C791 VA: 0x44C690
	// RVA: 0x3841F00 Offset: 0x3842001 VA: 0x3841F00
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0x44C6E0 Offset: 0x44C7E1 VA: 0x44C6E0
	// RVA: 0x3841FA0 Offset: 0x38420A1 VA: 0x3841FA0
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	[FreeFunctionAttribute] // RVA: 0x44C730 Offset: 0x44C831 VA: 0x44C730
	// RVA: 0x3842000 Offset: 0x3842101 VA: 0x3842000
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	[FreeFunctionAttribute] // RVA: 0x44C780 Offset: 0x44C881 VA: 0x44C780
	// RVA: 0x3842050 Offset: 0x3842151 VA: 0x3842050
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunctionAttribute] // RVA: 0x44C7D0 Offset: 0x44C8D1 VA: 0x44C7D0
	// RVA: 0x38420D0 Offset: 0x38421D1 VA: 0x38420D0
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x3842150 Offset: 0x3842251 VA: 0x3842150
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x38421A0 Offset: 0x38422A1 VA: 0x38421A0
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0x44C820 Offset: 0x44C921 VA: 0x44C820
	// RVA: 0x38421F0 Offset: 0x38422F1 VA: 0x38421F0
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, [Out] Rect[] rect) { }

	// RVA: 0x3842260 Offset: 0x3842361 VA: 0x3842260
	internal bool get_isPreProcessed() { }

	// RVA: 0x38422B0 Offset: 0x38423B1 VA: 0x38422B0
	public bool get_streamingMipmaps() { }

	// RVA: 0x3842300 Offset: 0x3842401 VA: 0x3842300
	public int get_streamingMipmapsPriority() { }

	[FreeFunctionAttribute] // RVA: 0x44C860 Offset: 0x44C961 VA: 0x44C860
	// RVA: 0x3842350 Offset: 0x3842451 VA: 0x3842350
	public int get_requestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44C8B0 Offset: 0x44C9B1 VA: 0x44C8B0
	// RVA: 0x38423A0 Offset: 0x38424A1 VA: 0x38423A0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x44C900 Offset: 0x44CA01 VA: 0x44C900
	// RVA: 0x38423F0 Offset: 0x38424F1 VA: 0x38423F0
	public int get_minimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44C950 Offset: 0x44CA51 VA: 0x44C950
	// RVA: 0x3842440 Offset: 0x3842541 VA: 0x3842440
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x44C9A0 Offset: 0x44CAA1 VA: 0x44C9A0
	// RVA: 0x3842490 Offset: 0x3842591 VA: 0x3842490
	internal bool get_loadAllMips() { }

	[FreeFunctionAttribute] // RVA: 0x44C9F0 Offset: 0x44CAF1 VA: 0x44C9F0
	// RVA: 0x38424E0 Offset: 0x38425E1 VA: 0x38424E0
	internal void set_loadAllMips(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x44CA40 Offset: 0x44CB41 VA: 0x44CA40
	// RVA: 0x3842530 Offset: 0x3842631 VA: 0x3842530
	public int get_calculatedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CA90 Offset: 0x44CB91 VA: 0x44CA90
	// RVA: 0x3842580 Offset: 0x3842681 VA: 0x3842580
	public int get_desiredMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CAE0 Offset: 0x44CBE1 VA: 0x44CAE0
	// RVA: 0x38425D0 Offset: 0x38426D1 VA: 0x38425D0
	public int get_loadingMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CB30 Offset: 0x44CC31 VA: 0x44CB30
	// RVA: 0x3842620 Offset: 0x3842721 VA: 0x3842620
	public int get_loadedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CB80 Offset: 0x44CC81 VA: 0x44CB80
	// RVA: 0x3842670 Offset: 0x3842771 VA: 0x3842670
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CBD0 Offset: 0x44CCD1 VA: 0x44CBD0
	// RVA: 0x38426C0 Offset: 0x38427C1 VA: 0x38426C0
	public bool IsRequestedMipmapLevelLoaded() { }

	[FreeFunctionAttribute] // RVA: 0x44CC20 Offset: 0x44CD21 VA: 0x44CC20
	// RVA: 0x3842710 Offset: 0x3842811 VA: 0x3842710
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44CC70 Offset: 0x44CD71 VA: 0x44CC70
	// RVA: 0x3842760 Offset: 0x3842861 VA: 0x3842760
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	[FreeFunctionAttribute] // RVA: 0x44CCC0 Offset: 0x44CDC1 VA: 0x44CCC0
	// RVA: 0x38427B0 Offset: 0x38428B1 VA: 0x38427B0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x44CD10 Offset: 0x44CE11 VA: 0x44CD10
	// RVA: 0x3842810 Offset: 0x3842911 VA: 0x3842810
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x44CD60 Offset: 0x44CE61 VA: 0x44CD60
	// RVA: 0x38428A0 Offset: 0x38429A1 VA: 0x38428A0
	public byte[] GetRawTextureData() { }

	[FreeFunctionAttribute] // RVA: 0x44CDB0 Offset: 0x44CEB1 VA: 0x44CDB0
	// RVA: 0x38428F0 Offset: 0x38429F1 VA: 0x38428F0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	// RVA: 0x3842970 Offset: 0x3842A71 VA: 0x3842970
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunctionAttribute] // RVA: 0x44CE00 Offset: 0x44CF01 VA: 0x44CE00
	// RVA: 0x38429F0 Offset: 0x3842AF1 VA: 0x38429F0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x3842A40 Offset: 0x3842B41 VA: 0x3842A40
	public Color32[] GetPixels32() { }

	[FreeFunctionAttribute] // RVA: 0x44CE50 Offset: 0x44CF51 VA: 0x44CE50
	// RVA: 0x3842A90 Offset: 0x3842B91 VA: 0x3842A90
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	// RVA: 0x3842B00 Offset: 0x3842C01 VA: 0x3842B00
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	// RVA: 0x3842B70 Offset: 0x3842C71 VA: 0x3842B70
	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	// RVA: 0x3842BD0 Offset: 0x3842CD1 VA: 0x3842BD0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x3842D00 Offset: 0x3842E01 VA: 0x3842D00
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3842DE0 Offset: 0x3842EE1 VA: 0x3842DE0
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3842EA0 Offset: 0x3842FA1 VA: 0x3842EA0
	public void .ctor(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	// RVA: 0x3842F30 Offset: 0x3843031 VA: 0x3842F30
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x3843090 Offset: 0x3843191 VA: 0x3843090
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x3843120 Offset: 0x3843221 VA: 0x3843120
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x38431B0 Offset: 0x38432B1 VA: 0x38431B0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x3843230 Offset: 0x3843331 VA: 0x3843230
	public void .ctor(int width, int height) { }

	// RVA: 0x38432E0 Offset: 0x38433E1 VA: 0x38432E0
	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	// RVA: 0x38433F0 Offset: 0x38434F1 VA: 0x38433F0
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x38434C0 Offset: 0x38435C1 VA: 0x38434C0
	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	// RVA: 0x38435A0 Offset: 0x38436A1 VA: 0x38435A0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x3843660 Offset: 0x3843761 VA: 0x3843660
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x3843720 Offset: 0x3843821 VA: 0x3843720
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x3843800 Offset: 0x3843901 VA: 0x3843800
	public void SetPixels(Color[] colors) { }

	// RVA: 0x38438D0 Offset: 0x38439D1 VA: 0x38438D0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x3843980 Offset: 0x3843A81 VA: 0x3843980
	public Color GetPixel(int x, int y, int mipLevel) { }

	// RVA: 0x3843A40 Offset: 0x3843B41 VA: 0x3843A40
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x3843AF0 Offset: 0x3843BF1 VA: 0x3843AF0
	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	// RVA: 0x3843BB0 Offset: 0x3843CB1 VA: 0x3843BB0
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: 0x3843D10 Offset: 0x3843E11 VA: 0x3843D10
	public void LoadRawTextureData(byte[] data) { }

	// RVA: -1 Offset: -1
	public void LoadRawTextureData<T>(NativeArray<T> data) { }

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026A60 Offset: 0x2026B61 VA: 0x2026A60
	|-Texture2D.SetPixelData<object>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetPixelData<T>(int mipLevel) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }

	// RVA: 0x3843E50 Offset: 0x3843F51 VA: 0x3843E50
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x3843EE0 Offset: 0x3843FE1 VA: 0x3843EE0
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x3843F70 Offset: 0x3844071 VA: 0x3843F70
	public void Apply() { }

	// RVA: 0x3843FF0 Offset: 0x38440F1 VA: 0x3843FF0
	public bool Resize(int width, int height) { }

	// RVA: 0x3844080 Offset: 0x3844181 VA: 0x3844080
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x3844130 Offset: 0x3844231 VA: 0x3844130
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	// RVA: 0x38441E0 Offset: 0x38442E1 VA: 0x38441E0
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44CEA0 Offset: 0x44CFA1 VA: 0x44CEA0
	// RVA: 0x38442C0 Offset: 0x38443C1 VA: 0x38442C0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x3844390 Offset: 0x3844491 VA: 0x3844390
	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	// RVA: 0x3844560 Offset: 0x3844661 VA: 0x3844560
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x38445C0 Offset: 0x38446C1 VA: 0x38445C0
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x3844620 Offset: 0x3844721 VA: 0x3844620
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x38446B0 Offset: 0x38447B1 VA: 0x38446B0
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x3844740 Offset: 0x3844841 VA: 0x3844740
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x38447E0 Offset: 0x38448E1 VA: 0x38447E0
	public Color[] GetPixels() { }

	// RVA: 0x3841B30 Offset: 0x3841C31 VA: 0x3841B30
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x3841C30 Offset: 0x3841D31 VA: 0x3841C30
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x3841D30 Offset: 0x3841E31 VA: 0x3841D30
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x3841E90 Offset: 0x3841F91 VA: 0x3841E90
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }
}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D490 Offset: 0x43D591 VA: 0x43D490
[ExcludeFromPresetAttribute] // RVA: 0x43D490 Offset: 0x43D591 VA: 0x43D490
public sealed class Texture3D : Texture // TypeDefIndex: 3518
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x3844FD0 Offset: 0x38450D1 VA: 0x3844FD0 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x44D4B0 Offset: 0x44D5B1 VA: 0x44D4B0
	// RVA: 0x3845020 Offset: 0x3845121 VA: 0x3845020
	private void SetPixelImpl(int image, int x, int y, int z, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x44D4F0 Offset: 0x44D5F1 VA: 0x44D4F0
	// RVA: 0x3845130 Offset: 0x3845231 VA: 0x3845130
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x38451D0 Offset: 0x38452D1 VA: 0x38451D0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunctionAttribute] // RVA: 0x44D530 Offset: 0x44D631 VA: 0x44D530
	// RVA: 0x38452C0 Offset: 0x38453C1 VA: 0x38452C0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x44D580 Offset: 0x44D681 VA: 0x44D580
	// RVA: 0x3845320 Offset: 0x3845421 VA: 0x3845320
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x3845380 Offset: 0x3845481 VA: 0x3845380
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44D5D0 Offset: 0x44D6D1 VA: 0x44D5D0
	// RVA: 0x3845460 Offset: 0x3845561 VA: 0x3845460
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3845510 Offset: 0x3845611 VA: 0x3845510
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x38456F0 Offset: 0x38457F1 VA: 0x38456F0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x3845890 Offset: 0x3845991 VA: 0x3845890
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x3845A30 Offset: 0x3845B31 VA: 0x3845A30
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x3845A40 Offset: 0x3845B41 VA: 0x3845A40
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x3845A50 Offset: 0x3845B51 VA: 0x3845A50
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x3845AE0 Offset: 0x3845BE1 VA: 0x3845AE0
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x3845B70 Offset: 0x3845C71 VA: 0x3845B70
	public void Apply() { }

	// RVA: 0x3845BF0 Offset: 0x3845CF1 VA: 0x3845BF0
	public void SetPixel(int x, int y, int z, Color color, int mipLevel) { }

	// RVA: 0x3845690 Offset: 0x3845791 VA: 0x3845690
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x38450B0 Offset: 0x38451B1 VA: 0x38450B0
	private void SetPixelImpl_Injected(int image, int x, int y, int z, ref Color color) { }
}

