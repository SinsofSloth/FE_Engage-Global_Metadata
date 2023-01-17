// Namespace: App
public class VibrationFile // TypeDefIndex: 9167
{
	// Fields
	private RawFileHandle m_file; // 0x10
	private VibrationFileInfo m_info; // 0x18
	private VibrationFileParserContext m_context; // 0x38

	// Properties
	public VibrationFileParserContext Context { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x26C2260 Offset: 0x26C2361 VA: 0x26C2260
	public VibrationFileParserContext get_Context() { }

	// RVA: 0x26C2290 Offset: 0x26C2391 VA: 0x26C2290
	public int get_Length() { }

	// RVA: 0x26C22A0 Offset: 0x26C23A1 VA: 0x26C22A0
	public void .ctor() { }

	// RVA: 0x26C2340 Offset: 0x26C2441 VA: 0x26C2340
	public bool Load(string filePath) { }
}

