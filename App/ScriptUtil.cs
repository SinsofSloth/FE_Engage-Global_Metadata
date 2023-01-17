// Namespace: App
public class ScriptUtil // TypeDefIndex: 10247
{
	// Fields
	protected static int MAX_CURSOR_STACK; // 0x0

	// Methods

	// RVA: 0x2326940 Offset: 0x2326A41 VA: 0x2326940
	protected static int GetInt(DynValue value) { }

	// RVA: 0x2326AA0 Offset: 0x2326BA1 VA: 0x2326AA0
	protected static float GetFloat(DynValue value) { }

	// RVA: 0x2326BF0 Offset: 0x2326CF1 VA: 0x2326BF0
	protected static string GetString(DynValue value) { }

	// RVA: 0x2326DA0 Offset: 0x2326EA1 VA: 0x2326DA0
	protected static bool GetBool(DynValue value) { }

	// RVA: 0x2326F00 Offset: 0x2327001 VA: 0x2326F00
	public static bool IsString(DynValue[] args, int index) { }

	// RVA: 0x2326F50 Offset: 0x2327051 VA: 0x2326F50
	public static DataType TryGetType(DynValue[] args, int index) { }

	// RVA: 0x2326FA0 Offset: 0x23270A1 VA: 0x2326FA0
	public static int TryGetInt(DynValue[] args, int index, int nothing = 0) { }

	// RVA: 0x2327050 Offset: 0x2327151 VA: 0x2327050
	public static float TryGetFloat(DynValue[] args, int index, float nothing = 0) { }

	// RVA: 0x2327110 Offset: 0x2327211 VA: 0x2327110
	public static int TryGetHash(DynValue[] args, int index, int nothing = 0) { }

	// RVA: 0x23271E0 Offset: 0x23272E1 VA: 0x23271E0
	public static string TryGetString(DynValue[] args, int index, string nothing) { }

	// RVA: 0x2327290 Offset: 0x2327391 VA: 0x2327290
	public static bool TryGetBool(DynValue[] args, int index, bool nothing = True) { }

	// RVA: 0x2327340 Offset: 0x2327441 VA: 0x2327340
	public static Force.Type TryGetForce(DynValue[] args, int index, Force.Type nothing = 7) { }

	// RVA: -1 Offset: -1
	public static T TryGetData<T>(DynValue[] args, int index, T nothing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201BDE0 Offset: 0x201BEE1 VA: 0x201BDE0
	|-ScriptUtil.TryGetData<ChapterData>
	|-ScriptUtil.TryGetData<GodData>
	|-ScriptUtil.TryGetData<ItemData>
	|-ScriptUtil.TryGetData<object>
	|-ScriptUtil.TryGetData<PersonData>
	*/

	// RVA: 0x23273F0 Offset: 0x23274F1 VA: 0x23273F0
	public static Unit TryGetUnit(DynValue[] args, int index, bool warning = True) { }

	// RVA: 0x23275E0 Offset: 0x23276E1 VA: 0x23275E0
	public static Unit TryMapGetUnit(DynValue[] args, int index, bool warning = True) { }

	// RVA: 0x2327680 Offset: 0x2327781 VA: 0x2327680
	public static GodUnit TryGetGodUnit(DynValue[] args, int index, bool warning = True) { }

	// RVA: 0x2327800 Offset: 0x2327901 VA: 0x2327800
	public static ItemData TryGetItem(DynValue[] args, int index, bool warning = True) { }

	// RVA: 0x2327950 Offset: 0x2327A51 VA: 0x2327950
	public static DynValue TryGetFunc(DynValue[] args, int index) { }

	// RVA: 0x2327A30 Offset: 0x2327B31 VA: 0x2327A30
	public static DynValue TryGetValue(DynValue[] args, int index) { }

	// RVA: 0x2327A70 Offset: 0x2327B71 VA: 0x2327A70
	public static DynValue[] TryGetArgs(DynValue[] args, int index) { }

	// RVA: -1 Offset: -1
	public static int TryGetIndex<T>(DynValue[] args, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201BF80 Offset: 0x201C081 VA: 0x201BF80
	|-ScriptUtil.TryGetIndex<object>
	|-ScriptUtil.TryGetIndex<PersonData>
	*/

	// RVA: -1 Offset: -1
	public static T TryGetUserData<T>(DynValue[] args, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201C0E0 Offset: 0x201C1E1 VA: 0x201C0E0
	|-ScriptUtil.TryGetUserData<object>
	|-ScriptUtil.TryGetUserData<ScriptMenu.EventMenu>
	|-ScriptUtil.TryGetUserData<ScriptMenu.EventMenuItem>
	*/

	// RVA: 0x2327BA0 Offset: 0x2327CA1 VA: 0x2327BA0
	public static GameObject TryGetGameObject(DynValue[] args, int index) { }

	// RVA: -1 Offset: -1
	public static T TryGetComponent<T>(DynValue[] args, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201B960 Offset: 0x201BA61 VA: 0x201B960
	|-ScriptUtil.TryGetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] TryGetComponents<T>(DynValue[] args, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201BBB0 Offset: 0x201BCB1 VA: 0x201BBB0
	|-ScriptUtil.TryGetComponents<object>
	*/

	// RVA: 0x2327D20 Offset: 0x2327E21 VA: 0x2327D20
	public static GameObject TryGetLocator(DynValue[] args, int index) { }

	// RVA: 0x2327FF0 Offset: 0x23280F1 VA: 0x2327FF0
	public static string GetFuncName(DynValue func) { }

	// RVA: 0x2328360 Offset: 0x2328461 VA: 0x2328360
	public static string GetScriptPath(string name) { }

	// RVA: 0x2328430 Offset: 0x2328531 VA: 0x2328430
	public static void Yield() { }

	// RVA: 0x23284F0 Offset: 0x23285F1 VA: 0x23284F0
	public static void Call(DynValue func, DynValue[] args) { }

	// RVA: 0x23285B0 Offset: 0x23286B1 VA: 0x23285B0
	public static void AddCoroutine(DynValue func, DynValue[] args) { }

	// RVA: 0x2328680 Offset: 0x2328781 VA: 0x2328680
	public static void JumpCoroutine(DynValue func, DynValue[] args) { }

	// RVA: 0x23289E0 Offset: 0x2328AE1 VA: 0x23289E0
	public static ProcInst GetSequence() { }

	// RVA: 0x2328A60 Offset: 0x2328B61 VA: 0x2328A60
	protected static ScriptUtil.MenuCondtion TryGetMenuCondition(DynValue[] args, int index) { }

	// RVA: 0x2328B40 Offset: 0x2328C41 VA: 0x2328B40
	protected static string GetCursorStackName(int index) { }

	// RVA: 0x2328C00 Offset: 0x2328D01 VA: 0x2328C00
	protected static void CreateCursorStack() { }

	// RVA: 0x2328770 Offset: 0x2328871 VA: 0x2328770
	protected static void ClearCursorStack() { }

	// RVA: 0x2328D40 Offset: 0x2328E41 VA: 0x2328D40
	protected static void ClearCursorStack(int index) { }

	// RVA: 0x2328FB0 Offset: 0x23290B1 VA: 0x2328FB0
	protected static int GetCursorStack(int index) { }

	// RVA: 0x2329190 Offset: 0x2329291 VA: 0x2329190
	protected static void SetCursorStack(int index, int value) { }

	// RVA: 0x2329430 Offset: 0x2329531 VA: 0x2329430
	public void .ctor() { }

	// RVA: 0x2329440 Offset: 0x2329541 VA: 0x2329440
	private static void .cctor() { }
}

