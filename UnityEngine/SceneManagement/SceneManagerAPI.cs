// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI // TypeDefIndex: 3713
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x4444A0 Offset: 0x4445A1 VA: 0x4444A0
	[DebuggerBrowsableAttribute] // RVA: 0x4444A0 Offset: 0x4445A1 VA: 0x4444A0
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; }

	// Methods

	// RVA: 0x31E2880 Offset: 0x31E2981 VA: 0x31E2880
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGeneratedAttribute] // RVA: 0x452B30 Offset: 0x452C31 VA: 0x452B30
	// RVA: 0x31E3560 Offset: 0x31E3661 VA: 0x31E3560
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x31E35D0 Offset: 0x31E36D1 VA: 0x31E35D0
	protected internal void .ctor() { }

	// RVA: 0x31E35E0 Offset: 0x31E36E1 VA: 0x31E35E0 Slot: 4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x31E36C0 Offset: 0x31E37C1 VA: 0x31E36C0 Slot: 5
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x31E36D0 Offset: 0x31E37D1 VA: 0x31E36D0
	private static void .cctor() { }
}

