// Namespace: UnityEngine.U2D
[StaticAccessorAttribute] // RVA: 0x43F400 Offset: 0x43F501 VA: 0x43F400
[NativeHeaderAttribute] // RVA: 0x43F400 Offset: 0x43F501 VA: 0x43F400
[NativeHeaderAttribute] // RVA: 0x43F400 Offset: 0x43F501 VA: 0x43F400
public class SpriteAtlasManager // TypeDefIndex: 3664
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x443CA0 Offset: 0x443DA1 VA: 0x443CA0
	[CompilerGeneratedAttribute] // RVA: 0x443CA0 Offset: 0x443DA1 VA: 0x443CA0
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x443CE0 Offset: 0x443DE1 VA: 0x443CE0
	[CompilerGeneratedAttribute] // RVA: 0x443CE0 Offset: 0x443DE1 VA: 0x443CE0
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452120 Offset: 0x452221 VA: 0x452120
	// RVA: 0x31F0E70 Offset: 0x31F0F71 VA: 0x31F0E70
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute] // RVA: 0x452130 Offset: 0x452231 VA: 0x452130
	// RVA: 0x31F0FB0 Offset: 0x31F10B1 VA: 0x31F0FB0
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452140 Offset: 0x452241 VA: 0x452140
	// RVA: 0x31F10B0 Offset: 0x31F11B1 VA: 0x31F10B0
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452150 Offset: 0x452251 VA: 0x452150
	// RVA: 0x31F11B0 Offset: 0x31F12B1 VA: 0x31F11B0
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x31F1260 Offset: 0x31F1361 VA: 0x31F1260
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x31F12B0 Offset: 0x31F13B1 VA: 0x31F12B0
	private static void .cctor() { }
}

