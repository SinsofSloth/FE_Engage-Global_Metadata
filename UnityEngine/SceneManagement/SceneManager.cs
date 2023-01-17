// Namespace: UnityEngine.SceneManagement
[NativeHeaderAttribute] // RVA: 0x43FAB0 Offset: 0x43FBB1 VA: 0x43FAB0
[RequiredByNativeCodeAttribute] // RVA: 0x43FAB0 Offset: 0x43FBB1 VA: 0x43FAB0
public class SceneManager // TypeDefIndex: 3714
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x4444E0 Offset: 0x4445E1 VA: 0x4444E0
	[CompilerGeneratedAttribute] // RVA: 0x4444E0 Offset: 0x4445E1 VA: 0x4444E0
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x444520 Offset: 0x444621 VA: 0x444520
	[CompilerGeneratedAttribute] // RVA: 0x444520 Offset: 0x444621 VA: 0x444520
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x444560 Offset: 0x444661 VA: 0x444560
	[DebuggerBrowsableAttribute] // RVA: 0x444560 Offset: 0x444661 VA: 0x444560
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0x452B40 Offset: 0x452C41 VA: 0x452B40
	[NativeHeaderAttribute] // RVA: 0x452B40 Offset: 0x452C41 VA: 0x452B40
	[NativeMethodAttribute] // RVA: 0x452B40 Offset: 0x452C41 VA: 0x452B40
	// RVA: 0x31E2260 Offset: 0x31E2361 VA: 0x31E2260
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0x452BD0 Offset: 0x452CD1 VA: 0x452BD0
	// RVA: 0x31E22A0 Offset: 0x31E23A1 VA: 0x31E22A0
	public static Scene GetActiveScene() { }

	[NativeThrowsAttribute] // RVA: 0x452C10 Offset: 0x452D11 VA: 0x452C10
	[StaticAccessorAttribute] // RVA: 0x452C10 Offset: 0x452D11 VA: 0x452C10
	// RVA: 0x31E2390 Offset: 0x31E2491 VA: 0x31E2390
	public static bool SetActiveScene(Scene scene) { }

	[StaticAccessorAttribute] // RVA: 0x452C60 Offset: 0x452D61 VA: 0x452C60
	// RVA: 0x31E2480 Offset: 0x31E2581 VA: 0x31E2480
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0x452CA0 Offset: 0x452DA1 VA: 0x452CA0
	[StaticAccessorAttribute] // RVA: 0x452CA0 Offset: 0x452DA1 VA: 0x452CA0
	// RVA: 0x31E2580 Offset: 0x31E2681 VA: 0x31E2580
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0x452CF0 Offset: 0x452DF1 VA: 0x452CF0
	[StaticAccessorAttribute] // RVA: 0x452CF0 Offset: 0x452DF1 VA: 0x452CF0
	// RVA: 0x31E2680 Offset: 0x31E2781 VA: 0x31E2680
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x31E2780 Offset: 0x31E2881 VA: 0x31E2780
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0x452D40 Offset: 0x452E41 VA: 0x452D40
	[StaticAccessorAttribute] // RVA: 0x452D40 Offset: 0x452E41 VA: 0x452D40
	// RVA: 0x31E2990 Offset: 0x31E2A91 VA: 0x31E2990
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452D90 Offset: 0x452E91 VA: 0x452D90
	// RVA: 0x31E2A90 Offset: 0x31E2B91 VA: 0x31E2A90
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DA0 Offset: 0x452EA1 VA: 0x452DA0
	// RVA: 0x31E2B10 Offset: 0x31E2C11 VA: 0x31E2B10
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DB0 Offset: 0x452EB1 VA: 0x452DB0
	// RVA: 0x31E2C10 Offset: 0x31E2D11 VA: 0x31E2C10
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DC0 Offset: 0x452EC1 VA: 0x452DC0
	// RVA: 0x31E2D10 Offset: 0x31E2E11 VA: 0x31E2D10
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DD0 Offset: 0x452ED1 VA: 0x452DD0
	// RVA: 0x31E2E10 Offset: 0x31E2F11 VA: 0x31E2E10
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DE0 Offset: 0x452EE1 VA: 0x452DE0
	// RVA: 0x31E2F10 Offset: 0x31E3011 VA: 0x31E2F10
	public static void add_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x452DF0 Offset: 0x452EF1 VA: 0x452DF0
	// RVA: 0x31E3010 Offset: 0x31E3111 VA: 0x31E3010
	public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	// RVA: 0x31E3110 Offset: 0x31E3211 VA: 0x31E3110
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x31E3190 Offset: 0x31E3291 VA: 0x31E3190
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452E00 Offset: 0x452F01 VA: 0x452E00
	// RVA: 0x31E3280 Offset: 0x31E3381 VA: 0x31E3280
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452E10 Offset: 0x452F11 VA: 0x452E10
	// RVA: 0x31E3360 Offset: 0x31E3461 VA: 0x31E3360
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452E20 Offset: 0x452F21 VA: 0x452E20
	// RVA: 0x31E3430 Offset: 0x31E3531 VA: 0x31E3430
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x31E3510 Offset: 0x31E3611 VA: 0x31E3510
	private static void .cctor() { }

	// RVA: 0x31E2340 Offset: 0x31E2441 VA: 0x31E2340
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x31E2430 Offset: 0x31E2531 VA: 0x31E2430
	private static bool SetActiveScene_Injected(ref Scene scene) { }

	// RVA: 0x31E2530 Offset: 0x31E2631 VA: 0x31E2530
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x31E2630 Offset: 0x31E2731 VA: 0x31E2630
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x31E2730 Offset: 0x31E2831 VA: 0x31E2730
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x31E2A40 Offset: 0x31E2B41 VA: 0x31E2A40
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }
}

