// Namespace: MoonSharp.Interpreter.Loaders
public class EmbeddedResourcesScriptLoader : ScriptLoaderBase // TypeDefIndex: 6050
{
	// Fields
	private Assembly m_ResourceAssembly; // 0x20
	private HashSet<string> m_ResourceNames; // 0x28
	private string m_Namespace; // 0x30

	// Methods

	// RVA: 0x3305C30 Offset: 0x3305D31 VA: 0x3305C30
	public void .ctor(Assembly resourceAssembly) { }

	// RVA: 0x3305DB0 Offset: 0x3305EB1 VA: 0x3305DB0
	private string FileNameToResource(string file) { }

	// RVA: 0x3305E40 Offset: 0x3305F41 VA: 0x3305E40 Slot: 7
	public override bool ScriptFileExists(string name) { }

	// RVA: 0x3305F10 Offset: 0x3306011 VA: 0x3305F10 Slot: 8
	public override object LoadFile(string file, Table globalContext) { }
}

