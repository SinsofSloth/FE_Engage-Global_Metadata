// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D4E0 Offset: 0x43D5E1 VA: 0x43D4E0
public sealed class Texture2DArray : Texture // TypeDefIndex: 3519
{
	// Properties
	public static int allSlices { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x44D5E0 Offset: 0x44D6E1 VA: 0x44D5E0
	// RVA: 0x3844870 Offset: 0x3844971 VA: 0x3844870
	public static int get_allSlices() { }

	// RVA: 0x38448B0 Offset: 0x38449B1 VA: 0x38448B0 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0x44D620 Offset: 0x44D721 VA: 0x44D620
	// RVA: 0x3844900 Offset: 0x3844A01 VA: 0x3844900
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3844990 Offset: 0x3844A91 VA: 0x3844990
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3844A70 Offset: 0x3844B71 VA: 0x3844A70
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44D660 Offset: 0x44D761 VA: 0x44D660
	// RVA: 0x3844B50 Offset: 0x3844C51 VA: 0x3844B50
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x3844C00 Offset: 0x3844D01 VA: 0x3844C00
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x3844DE0 Offset: 0x3844EE1 VA: 0x3844DE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x3844F90 Offset: 0x3845091 VA: 0x3844F90
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x3844FB0 Offset: 0x38450B1 VA: 0x3844FB0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x3844D80 Offset: 0x3844E81 VA: 0x3844D80
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}

