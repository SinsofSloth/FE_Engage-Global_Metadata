// Namespace: 
private class ScriptSystem.CameraList : List<Camera> // TypeDefIndex: 10242
{
	// Properties
	public Camera Current { get; }

	// Methods

	// RVA: 0x20365F0 Offset: 0x20366F1 VA: 0x20365F0
	public void .ctor(string tag) { }

	// RVA: 0x2036790 Offset: 0x2036891 VA: 0x2036790
	public Camera get_Current() { }

	// RVA: 0x2036850 Offset: 0x2036951 VA: 0x2036850
	public Camera Find(string name) { }
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276850 Offset: 0x276951 VA: 0x276850
private enum ScriptSystem.DebugButton // TypeDefIndex: 10243
{
	// Fields
	public int value__; // 0x0
	public const ScriptSystem.DebugButton A = 1;
	public const ScriptSystem.DebugButton B = 2;
	public const ScriptSystem.DebugButton X = 4;
	public const ScriptSystem.DebugButton Y = 8;
	public const ScriptSystem.DebugButton L = 16;
	public const ScriptSystem.DebugButton R = 32;
	public const ScriptSystem.DebugButton Left = 64;
	public const ScriptSystem.DebugButton Up = 128;
	public const ScriptSystem.DebugButton Right = 256;
	public const ScriptSystem.DebugButton Down = 512;
	public const ScriptSystem.DebugButton Plus = 1024;
	public const ScriptSystem.DebugButton Minus = 2048;
}

