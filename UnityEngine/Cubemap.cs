// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D440 Offset: 0x43D541 VA: 0x43D440
[ExcludeFromPresetAttribute] // RVA: 0x43D440 Offset: 0x43D541 VA: 0x43D440
public sealed class Cubemap : Texture // TypeDefIndex: 3517
{
	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }
	internal bool isPreProcessed { get; }
	public bool streamingMipmaps { get; }
	public int streamingMipmapsPriority { get; }
	public int requestedMipmapLevel { get; set; }
	internal bool loadAllMips { get; set; }
	public int desiredMipmapLevel { get; }
	public int loadingMipmapLevel { get; }
	public int loadedMipmapLevel { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x44CEB0 Offset: 0x44CFB1 VA: 0x44CEB0
	// RVA: 0x2F1BB00 Offset: 0x2F1BC01 VA: 0x2F1BB00
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0x44CEF0 Offset: 0x44CFF1 VA: 0x44CEF0
	// RVA: 0x2F1BB50 Offset: 0x2F1BC51 VA: 0x2F1BB50
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2F1BBD0 Offset: 0x2F1BCD1 VA: 0x2F1BBD0
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunctionAttribute] // RVA: 0x44CF30 Offset: 0x44D031 VA: 0x44CF30
	// RVA: 0x2F1BCA0 Offset: 0x2F1BDA1 VA: 0x2F1BCA0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x44CF80 Offset: 0x44D081 VA: 0x44CF80
	// RVA: 0x2F1BD00 Offset: 0x2F1BE01 VA: 0x2F1BD00
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

	// RVA: 0x2F1BD50 Offset: 0x2F1BE51 VA: 0x2F1BD50 Slot: 11
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0x44CFD0 Offset: 0x44D0D1 VA: 0x44CFD0
	// RVA: 0x2F1BDA0 Offset: 0x2F1BEA1 VA: 0x2F1BDA0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0x44D010 Offset: 0x44D111 VA: 0x44D010
	// RVA: 0x2F1BE90 Offset: 0x2F1BF91 VA: 0x2F1BE90
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0x44D050 Offset: 0x44D151 VA: 0x44D050
	// RVA: 0x2F1BF90 Offset: 0x2F1C091 VA: 0x2F1BF90
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	// RVA: 0x2F1BFE0 Offset: 0x2F1C0E1 VA: 0x2F1BFE0
	public void SmoothEdges() { }

	[FreeFunctionAttribute] // RVA: 0x44D090 Offset: 0x44D191 VA: 0x44D090
	// RVA: 0x2F1C030 Offset: 0x2F1C131 VA: 0x2F1C030
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	// RVA: 0x2F1C090 Offset: 0x2F1C191 VA: 0x2F1C090
	public Color[] GetPixels(CubemapFace face) { }

	[FreeFunctionAttribute] // RVA: 0x44D0E0 Offset: 0x44D1E1 VA: 0x44D0E0
	// RVA: 0x2F1C0F0 Offset: 0x2F1C1F1 VA: 0x2F1C0F0
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0x44D130 Offset: 0x44D231 VA: 0x44D130
	// RVA: 0x2F1C160 Offset: 0x2F1C261 VA: 0x2F1C160
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunctionAttribute] // RVA: 0x44D180 Offset: 0x44D281 VA: 0x44D180
	// RVA: 0x2F1C1F0 Offset: 0x2F1C2F1 VA: 0x2F1C1F0
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x2F1C280 Offset: 0x2F1C381 VA: 0x2F1C280
	public void SetPixels(Color[] colors, CubemapFace face) { }

	// RVA: 0x2F1C2E0 Offset: 0x2F1C3E1 VA: 0x2F1C2E0
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x2F1C330 Offset: 0x2F1C431 VA: 0x2F1C330
	internal bool get_isPreProcessed() { }

	// RVA: 0x2F1C380 Offset: 0x2F1C481 VA: 0x2F1C380
	public bool get_streamingMipmaps() { }

	// RVA: 0x2F1C3D0 Offset: 0x2F1C4D1 VA: 0x2F1C3D0
	public int get_streamingMipmapsPriority() { }

	[FreeFunctionAttribute] // RVA: 0x44D1D0 Offset: 0x44D2D1 VA: 0x44D1D0
	// RVA: 0x2F1C420 Offset: 0x2F1C521 VA: 0x2F1C420
	public int get_requestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44D220 Offset: 0x44D321 VA: 0x44D220
	// RVA: 0x2F1C470 Offset: 0x2F1C571 VA: 0x2F1C470
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0x44D270 Offset: 0x44D371 VA: 0x44D270
	// RVA: 0x2F1C4C0 Offset: 0x2F1C5C1 VA: 0x2F1C4C0
	internal bool get_loadAllMips() { }

	[FreeFunctionAttribute] // RVA: 0x44D2C0 Offset: 0x44D3C1 VA: 0x44D2C0
	// RVA: 0x2F1C510 Offset: 0x2F1C611 VA: 0x2F1C510
	internal void set_loadAllMips(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x44D310 Offset: 0x44D411 VA: 0x44D310
	// RVA: 0x2F1C560 Offset: 0x2F1C661 VA: 0x2F1C560
	public int get_desiredMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44D360 Offset: 0x44D461 VA: 0x44D360
	// RVA: 0x2F1C5B0 Offset: 0x2F1C6B1 VA: 0x2F1C5B0
	public int get_loadingMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44D3B0 Offset: 0x44D4B1 VA: 0x44D3B0
	// RVA: 0x2F1C600 Offset: 0x2F1C701 VA: 0x2F1C600
	public int get_loadedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44D400 Offset: 0x44D501 VA: 0x44D400
	// RVA: 0x2F1C650 Offset: 0x2F1C751 VA: 0x2F1C650
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0x44D450 Offset: 0x44D551 VA: 0x44D450
	// RVA: 0x2F1C6A0 Offset: 0x2F1C7A1 VA: 0x2F1C6A0
	public bool IsRequestedMipmapLevelLoaded() { }

	// RVA: 0x2F1C6F0 Offset: 0x2F1C7F1 VA: 0x2F1C6F0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44D4A0 Offset: 0x44D5A1 VA: 0x44D4A0
	// RVA: 0x2F1C740 Offset: 0x2F1C841 VA: 0x2F1C740
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2F1C840 Offset: 0x2F1C941 VA: 0x2F1C840
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x2F1CA20 Offset: 0x2F1CB21 VA: 0x2F1CA20
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2F1C8B0 Offset: 0x2F1C9B1 VA: 0x2F1C8B0
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2F1CC30 Offset: 0x2F1CD31 VA: 0x2F1CC30
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x2F1CC40 Offset: 0x2F1CD41 VA: 0x2F1CC40
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2F1CCC0 Offset: 0x2F1CDC1 VA: 0x2F1CCC0
	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D6E0 Offset: 0x229D7E1 VA: 0x229D6E0
	|-Cubemap.SetPixelData<object>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) { }

	// RVA: 0x2F1CDC0 Offset: 0x2F1CEC1 VA: 0x2F1CDC0
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	// RVA: 0x2F1CEA0 Offset: 0x2F1CFA1 VA: 0x2F1CEA0
	public Color GetPixel(CubemapFace face, int x, int y) { }

	// RVA: 0x2F1CF60 Offset: 0x2F1D061 VA: 0x2F1CF60
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2F1D000 Offset: 0x2F1D101 VA: 0x2F1D000
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x2F1D090 Offset: 0x2F1D191 VA: 0x2F1D090
	public void Apply() { }

	// RVA: 0x2F1CB50 Offset: 0x2F1CC51 VA: 0x2F1CB50
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2F1BE20 Offset: 0x2F1BF21 VA: 0x2F1BE20
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x2F1BF20 Offset: 0x2F1C021 VA: 0x2F1BF20
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }
}

