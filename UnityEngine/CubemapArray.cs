// Namespace: UnityEngine
[ExcludeFromPresetAttribute] // RVA: 0x43D520 Offset: 0x43D621 VA: 0x43D520
[NativeHeaderAttribute] // RVA: 0x43D520 Offset: 0x43D621 VA: 0x43D520
public sealed class CubemapArray : Texture // TypeDefIndex: 3520
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2F1D120 Offset: 0x2F1D221 VA: 0x2F1D120 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0x44D670 Offset: 0x44D771 VA: 0x44D670
	// RVA: 0x2F1D170 Offset: 0x2F1D271 VA: 0x2F1D170
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2F1D1F0 Offset: 0x2F1D2F1 VA: 0x2F1D1F0
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44D6B0 Offset: 0x44D7B1 VA: 0x44D6B0
	// RVA: 0x2F1D2C0 Offset: 0x2F1D3C1 VA: 0x2F1D2C0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x44D700 Offset: 0x44D801 VA: 0x44D700
	// RVA: 0x2F1D320 Offset: 0x2F1D421 VA: 0x2F1D320
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel) { }

	// RVA: 0x2F1D390 Offset: 0x2F1D491 VA: 0x2F1D390
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement) { }

	// RVA: 0x2F1D400 Offset: 0x2F1D501 VA: 0x2F1D400
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44D750 Offset: 0x44D851 VA: 0x44D750
	// RVA: 0x2F1D4B0 Offset: 0x2F1D5B1 VA: 0x2F1D4B0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2F1D560 Offset: 0x2F1D661 VA: 0x2F1D560
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2F1D6F0 Offset: 0x2F1D7F1 VA: 0x2F1D6F0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2F1D860 Offset: 0x2F1D961 VA: 0x2F1D860
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2F1D880 Offset: 0x2F1D981 VA: 0x2F1D880
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2F1D8A0 Offset: 0x2F1D9A1 VA: 0x2F1D8A0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2F1D940 Offset: 0x2F1DA41 VA: 0x2F1D940
	public void Apply() { }

	// RVA: 0x2F1D690 Offset: 0x2F1D791 VA: 0x2F1D690
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

