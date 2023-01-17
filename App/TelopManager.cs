// Namespace: App
public class TelopManager : SingletonMonoBehaviour<TelopManager> // TypeDefIndex: 13416
{
	// Fields
	private static readonly Vector2 CanvasSize; // 0x0

	// Methods

	// RVA: 0x2C3D260 Offset: 0x2C3D361 VA: 0x2C3D260
	private ResourceObject CreateBindImpl(ProcInst super, string path) { }

	// RVA: 0x2C3D4A0 Offset: 0x2C3D5A1 VA: 0x2C3D4A0
	public static ResourceObject CreateBind(ProcInst super, string name) { }

	// RVA: 0x2C3D5C0 Offset: 0x2C3D6C1 VA: 0x2C3D5C0
	public static void TrySetText(GameObject rootObject, string objectName, string text) { }

	// RVA: 0x2C3D6C0 Offset: 0x2C3D7C1 VA: 0x2C3D6C0
	public static void TrySetText(GameObject rootObject, string text) { }

	// RVA: 0x2C3D770 Offset: 0x2C3D871 VA: 0x2C3D770
	public static void TrySetText(GameObject rootObject, string objectName, int value) { }

	// RVA: 0x2C3D890 Offset: 0x2C3D991 VA: 0x2C3D890
	public static void TrySetTextColor(GameObject rootObject, string objectName, Color color) { }

	// RVA: 0x2C3D9D0 Offset: 0x2C3DAD1 VA: 0x2C3D9D0
	public static void TrySetTextOutlineColor(GameObject rootObject, string objectName, Color color) { }

	// RVA: 0x2C3DB10 Offset: 0x2C3DC11 VA: 0x2C3DB10
	public static void TrySetImageSprite(GameObject rootObject, string objectName, Sprite sprite) { }

	// RVA: 0x2C3DC10 Offset: 0x2C3DD11 VA: 0x2C3DC10
	public static void TrySetImageColor(GameObject rootObject, string objectName, Color color) { }

	// RVA: 0x2C3DD50 Offset: 0x2C3DE51 VA: 0x2C3DD50
	public static void CreatePurpose(ProcInst parent, string textWin, string textLose) { }

	// RVA: 0x2C3DE80 Offset: 0x2C3DF81 VA: 0x2C3DE80
	public static void CreatePhaseChange(ProcInst super, Force.Type forceType, int nowTurn, int limitTurn) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CB780 Offset: 0x2CB881 VA: 0x2CB780
	// RVA: 0x2C3E180 Offset: 0x2C3E281 VA: 0x2C3E180
	private static IEnumerator Coroutine(GameObject go) { }

	// RVA: 0x2C3E200 Offset: 0x2C3E301 VA: 0x2C3E200
	public static void CreateComplete(ProcInst super) { }

	// RVA: 0x2C3E350 Offset: 0x2C3E451 VA: 0x2C3E350
	public static void CreateGameOver(ProcInst super) { }

	// RVA: 0x2C3E4A0 Offset: 0x2C3E5A1 VA: 0x2C3E4A0
	public static void CreateLevelUp(ProcInst super, int level, int nextLevel, Unit unit, bool isShowCharaImage) { }

	// RVA: 0x2C3E620 Offset: 0x2C3E721 VA: 0x2C3E620
	public static void CreateBondLevelUp(ProcInst super, Unit unit, GodUnit god, int level, int nextLevel, GodData godData) { }

	// RVA: 0x2C3E630 Offset: 0x2C3E731 VA: 0x2C3E630
	private static string GetBondLevelFacePath(Unit unit) { }

	// RVA: 0x2C3E830 Offset: 0x2C3E931 VA: 0x2C3E830
	private static string GetBondLevelFacePath(GodUnit god) { }

	// RVA: 0x2C3EAD0 Offset: 0x2C3EBD1 VA: 0x2C3EAD0
	private static string GetBondLevelFacePath(GodData data) { }

	// RVA: 0x2C3ED30 Offset: 0x2C3EE31 VA: 0x2C3ED30
	public static void CreateClassChange(ProcInst super, JobData before, JobData after) { }

	// RVA: 0x2C3EE60 Offset: 0x2C3EF61 VA: 0x2C3EE60
	public static void CreateEngage(ProcInst super) { }

	// RVA: 0x2C3EEE0 Offset: 0x2C3EFE1 VA: 0x2C3EEE0
	public static void CreateChapterTitle(ProcInst super, ChapterData chapter) { }

	// RVA: 0x2C3F070 Offset: 0x2C3F171 VA: 0x2C3F070
	public static void CreateNationLevelUp(ProcInst super, HubNationData nationData, int level, int nextLevel, ResourceObject.Callback endCallback) { }

	// RVA: 0x2C3F1C0 Offset: 0x2C3F2C1 VA: 0x2C3F1C0
	public static void CreateRelayResult(ProcInst super, string[] raids, bool isAwarded) { }

	// RVA: 0x2C3F1D0 Offset: 0x2C3F2D1 VA: 0x2C3F1D0
	public void .ctor() { }

	// RVA: 0x2C3F250 Offset: 0x2C3F351 VA: 0x2C3F250
	private static void .cctor() { }
}

