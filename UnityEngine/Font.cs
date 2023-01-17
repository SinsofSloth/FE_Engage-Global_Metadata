// Namespace: UnityEngine
[StaticAccessorAttribute] // RVA: 0x48C930 Offset: 0x48CA31 VA: 0x48C930
[NativeHeaderAttribute] // RVA: 0x48C930 Offset: 0x48CA31 VA: 0x48C930
[NativeClassAttribute] // RVA: 0x48C930 Offset: 0x48CA31 VA: 0x48C930
[NativeHeaderAttribute] // RVA: 0x48C930 Offset: 0x48CA31 VA: 0x48C930
public sealed class Font : Object // TypeDefIndex: 4071
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x48CB00 Offset: 0x48CC01 VA: 0x48CB00
	[CompilerGeneratedAttribute] // RVA: 0x48CB00 Offset: 0x48CC01 VA: 0x48CB00
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x48CB40 Offset: 0x48CC41 VA: 0x48CB40
	[DebuggerBrowsableAttribute] // RVA: 0x48CB40 Offset: 0x48CC41 VA: 0x48CB40
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x48CC30 Offset: 0x48CD31 VA: 0x48CC30
	// RVA: 0x3F08DC0 Offset: 0x3F08EC1 VA: 0x3F08DC0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x48CC40 Offset: 0x48CD41 VA: 0x48CC40
	// RVA: 0x3F08E80 Offset: 0x3F08F81 VA: 0x3F08E80
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x3F08F40 Offset: 0x3F09041 VA: 0x3F08F40
	public Material get_material() { }

	// RVA: 0x3F08F90 Offset: 0x3F09091 VA: 0x3F08F90
	public bool get_dynamic() { }

	// RVA: 0x3F08FE0 Offset: 0x3F090E1 VA: 0x3F08FE0
	public int get_fontSize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x48CC50 Offset: 0x48CD51 VA: 0x48CC50
	// RVA: 0x3F09030 Offset: 0x3F09131 VA: 0x3F09030
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x3F092E0 Offset: 0x3F093E1 VA: 0x3F092E0
	public bool HasCharacter(char c) { }

	// RVA: 0x3F09330 Offset: 0x3F09431 VA: 0x3F09330
	private bool HasCharacter(int c) { }

	[FreeFunctionAttribute] // RVA: 0x48CC60 Offset: 0x48CD61 VA: 0x48CC60
	// RVA: 0x3F09380 Offset: 0x3F09481 VA: 0x3F09380
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[ExcludeFromDocsAttribute] // RVA: 0x48CCB0 Offset: 0x48CDB1 VA: 0x48CCB0
	// RVA: 0x3F093F0 Offset: 0x3F094F1 VA: 0x3F093F0
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }
}

