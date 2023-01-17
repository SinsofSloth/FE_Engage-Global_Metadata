// Namespace: MoonSharp.Interpreter.Loaders
public class UnityAssetsScriptLoader : ScriptLoaderBase // TypeDefIndex: 6056
{
	// Fields
	private Dictionary<string, string> m_Resources; // 0x20
	public const string DEFAULT_PATH = "MoonSharp/Scripts";

	// Methods

	// RVA: 0x3351520 Offset: 0x3351621 VA: 0x3351520
	public void .ctor(string assetsPath) { }

	// RVA: 0x3351D90 Offset: 0x3351E91 VA: 0x3351D90
	public void .ctor(Dictionary<string, string> scriptToCodeMap) { }

	// RVA: 0x33515E0 Offset: 0x33516E1 VA: 0x33515E0
	private void LoadResourcesWithReflection(string assetsPath) { }

	// RVA: 0x3351E40 Offset: 0x3351F41 VA: 0x3351E40
	private string GetFileName(string filename) { }

	// RVA: 0x3351F10 Offset: 0x3352011 VA: 0x3351F10 Slot: 8
	public override object LoadFile(string file, Table globalContext) { }

	// RVA: 0x3352010 Offset: 0x3352111 VA: 0x3352010 Slot: 7
	public override bool ScriptFileExists(string file) { }

	// RVA: 0x3352080 Offset: 0x3352181 VA: 0x3352080
	public string[] GetLoadedScripts() { }
}

