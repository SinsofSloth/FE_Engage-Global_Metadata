// Namespace: App
public class Ut // TypeDefIndex: 14093
{
	// Fields
	private static uint FNV_OFFSET_BASIS_32; // 0x0
	private static uint FNV_PRIME_32; // 0x4
	private static readonly string[] s_ValueToString; // 0x8

	// Methods

	// RVA: 0x20AC0F0 Offset: 0x20AC1F1 VA: 0x20AC0F0
	public static Vector3 Mult(Vector3 a, Vector3 b) { }

	// RVA: 0x20AC100 Offset: 0x20AC201 VA: 0x20AC100
	public static Vector2 Mult(Vector2 a, Vector2 b) { }

	// RVA: 0x20AC110 Offset: 0x20AC211 VA: 0x20AC110
	public static float DegToRad(float deg) { }

	// RVA: 0x20AC130 Offset: 0x20AC231 VA: 0x20AC130
	public static Vector3 DegToRad(Vector3 rotate) { }

	// RVA: 0x20AC1D0 Offset: 0x20AC2D1 VA: 0x20AC1D0
	public static float RoundDeg(float deg) { }

	// RVA: 0x20AC220 Offset: 0x20AC321 VA: 0x20AC220
	public static float ClampAngle(float angle, float limit) { }

	// RVA: 0x20AC270 Offset: 0x20AC371 VA: 0x20AC270
	public static Vector3 ClampAngle(Vector3 angle, Vector3 limit) { }

	// RVA: 0x20AC420 Offset: 0x20AC521 VA: 0x20AC420
	public static Quaternion ClampAngle(Quaternion rotation, Vector3 limit) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T lhs, ref T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386D920 Offset: 0x386DA21 VA: 0x386D920
	|-Ut.Swap<GmapSpot>
	|-Ut.Swap<object>
	|-Ut.Swap<Unit>
	|
	|-RVA: 0x386D970 Offset: 0x386DA71 VA: 0x386D970
	|-Ut.Swap<AIOrder.UnitPriority>
	*/

	// RVA: 0x20AC630 Offset: 0x20AC731 VA: 0x20AC630
	public static float MSecToFrame(float msec) { }

	// RVA: 0x20AC650 Offset: 0x20AC751 VA: 0x20AC650
	public static float FrameToMSEc(float frame) { }

	// RVA: 0x20AC670 Offset: 0x20AC771 VA: 0x20AC670
	public static float GetFrameStep() { }

	// RVA: 0x20AC680 Offset: 0x20AC781 VA: 0x20AC680
	public static bool IsIntercect(int minX1, int minZ1, int maxX1, int maxZ1, int minX2, int minZ2, int maxX2, int maxZ2) { }

	// RVA: 0x20AC6B0 Offset: 0x20AC7B1 VA: 0x20AC6B0
	public static int GetFastInputScale() { }

	// RVA: 0x20AC8B0 Offset: 0x20AC9B1 VA: 0x20AC8B0
	public static int ChangeKeyValue(int value, int min, int max, int step = 1) { }

	// RVA: 0x20AD240 Offset: 0x20AD341 VA: 0x20AD240
	public static float ChangeKeyValue(float value, float min, float max, float step = 1) { }

	// RVA: 0x20AD2D0 Offset: 0x20AD3D1 VA: 0x20AD2D0
	public static bool ChangeKeyValue(bool value) { }

	// RVA: 0x20AC960 Offset: 0x20ACA61 VA: 0x20AC960
	private static double ChangeKeyValueImpl(double value, double min, double max, double step) { }

	// RVA: 0x20AD370 Offset: 0x20AD471 VA: 0x20AD370
	public static object ChangeKeyEnum(object obj) { }

	// RVA: 0x20ADA50 Offset: 0x20ADB51 VA: 0x20ADA50
	public static GameObject FindGameObject(string name, bool warning = True) { }

	// RVA: 0x20ADB00 Offset: 0x20ADC01 VA: 0x20ADB00
	public static GameObject TryCreateGameObject(string name, GameObject parent) { }

	// RVA: 0x20ADD00 Offset: 0x20ADE01 VA: 0x20ADD00
	public static GameObject CreateGameObject(string name, string parent) { }

	// RVA: 0x20ADE00 Offset: 0x20ADF01 VA: 0x20ADE00
	public static GameObject FindRootObject(string name) { }

	// RVA: 0x20ADF30 Offset: 0x20AE031 VA: 0x20ADF30
	public static GameObject TryCreateRootObject(string name) { }

	// RVA: -1 Offset: -1
	public static T CreateGameObject<T>(string parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031E90 Offset: 0x2031F91 VA: 0x2031E90
	|-Ut.CreateGameObject<object>
	*/

	// RVA: -1 Offset: -1
	public static T TryCreateComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386DA20 Offset: 0x386DB21 VA: 0x386DA20
	|-Ut.TryCreateComponent<object>
	|-Ut.TryCreateComponent<TalkCharacterController>
	*/

	// RVA: 0x20ADBE0 Offset: 0x20ADCE1 VA: 0x20ADBE0
	public static GameObject CreateGameObject(string name, GameObject parent) { }

	// RVA: -1 Offset: -1
	public static T CreateGameObject<T>(GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031F20 Offset: 0x2032021 VA: 0x2031F20
	|-Ut.CreateGameObject<object>
	|-Ut.CreateGameObject<SupportInfo>
	*/

	// RVA: 0x20AE010 Offset: 0x20AE111 VA: 0x20AE010
	public static GameObject CreateGameObjectByAsset(GameObject original, GameObject parent) { }

	// RVA: 0x20AE160 Offset: 0x20AE261 VA: 0x20AE160
	public static void DestroyGameObject(GameObject gameObject) { }

	// RVA: -1 Offset: -1
	public static void DestroyGameObject<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032060 Offset: 0x2032161 VA: 0x2032060
	|-Ut.DestroyGameObject<Character>
	|-Ut.DestroyGameObject<object>
	|-Ut.DestroyGameObject<PhotographAllMenuContent>
	*/

	// RVA: -1 Offset: -1
	public static void DestroyGameObject<T>(ref T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032170 Offset: 0x2032271 VA: 0x2032170
	|-Ut.DestroyGameObject<ClassChangeRoot>
	|-Ut.DestroyGameObject<ExpSetter>
	|-Ut.DestroyGameObject<FortuneTellingResultMenu>
	|-Ut.DestroyGameObject<InventoryRoot>
	|-Ut.DestroyGameObject<InvestmentNationDataMenu>
	|-Ut.DestroyGameObject<LevelUpWindowController>
	|-Ut.DestroyGameObject<object>
	|-Ut.DestroyGameObject<RingSelectRoot>
	|-Ut.DestroyGameObject<SkillEditRoot>
	|-Ut.DestroyGameObject<TradeRoot>
	|-Ut.DestroyGameObject<TroopListRoot>
	|-Ut.DestroyGameObject<UnitModel>
	|-Ut.DestroyGameObject<UnitSelectRoot>
	*/

	// RVA: 0x20AE220 Offset: 0x20AE321 VA: 0x20AE220
	public static void DestroyChildObject(GameObject gameObject) { }

	// RVA: 0x20AE370 Offset: 0x20AE471 VA: 0x20AE370
	public static bool SetLayerRecursively(Transform transform, int layer) { }

	// RVA: 0x20AE490 Offset: 0x20AE591 VA: 0x20AE490
	public static bool SetLayerRecursively(GameObject gameObject, int layer) { }

	// RVA: 0x20AE520 Offset: 0x20AE621 VA: 0x20AE520
	public static bool SetLayerRecursively(GameObject gameObject, string name) { }

	// RVA: 0x20AE620 Offset: 0x20AE721 VA: 0x20AE620
	public static GameObject CreateDebugTextObject(Transform parent, string name, int size = 20) { }

	// RVA: 0x20AE960 Offset: 0x20AEA61 VA: 0x20AE960
	public static string GetObjectFullPath(GameObject gameObject) { }

	// RVA: -1 Offset: -1
	public static string GetObjectFullPath<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386D650 Offset: 0x386D751 VA: 0x386D650
	|-Ut.GetObjectFullPath<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject FindChildGameObject<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032460 Offset: 0x2032561 VA: 0x2032460
	|-Ut.FindChildGameObject<Character>
	|-Ut.FindChildGameObject<MeshRenderer>
	|-Ut.FindChildGameObject<object>
	*/

	// RVA: 0x208FC10 Offset: 0x208FD11 VA: 0x208FC10
	public static GameObject FindChildGameObject(GameObject gameObject, string childName) { }

	// RVA: 0x20AEAF0 Offset: 0x20AEBF1 VA: 0x20AEAF0
	public static Transform FindChildTransform(Transform parent, string childName) { }

	// RVA: 0x20AEC70 Offset: 0x20AED71 VA: 0x20AEC70
	public static GameObject GetTopParentObject(GameObject gameObject) { }

	// RVA: 0x20AED60 Offset: 0x20AEE61 VA: 0x20AED60
	public static string GetUniqueObjectName(string name) { }

	// RVA: 0x20AEE90 Offset: 0x20AEF91 VA: 0x20AEE90
	public static string GetCurrentScenePath() { }

	// RVA: 0x20AEF50 Offset: 0x20AF051 VA: 0x20AEF50
	public static string GetCurrentSceneDir() { }

	// RVA: 0x20AF000 Offset: 0x20AF101 VA: 0x20AF000
	public static string GetCurrentSceneName() { }

	// RVA: 0x20AF0B0 Offset: 0x20AF1B1 VA: 0x20AF0B0
	public static string GetSceneName(GameObject gameObject) { }

	// RVA: 0x20AF150 Offset: 0x20AF251 VA: 0x20AF150
	public static string GetSceneName(Component component) { }

	// RVA: 0x20AF290 Offset: 0x20AF391 VA: 0x20AF290
	public static string GetPrefixless(string path) { }

	// RVA: -1 Offset: -1
	public static T FindChildComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032280 Offset: 0x2032381 VA: 0x2032280
	|-Ut.FindChildComponent<AnimalInsideMenuContent>
	|-Ut.FindChildComponent<AnimalOutsideMenuContent>
	|-Ut.FindChildComponent<Animator>
	|-Ut.FindChildComponent<Camera>
	|-Ut.FindChildComponent<Character>
	|-Ut.FindChildComponent<CharacterEyeDart>
	|-Ut.FindChildComponent<DishSelectMenuCategoryContent>
	|-Ut.FindChildComponent<EatUnitsSelectMenuRelianceContent>
	|-Ut.FindChildComponent<GmapSpotController>
	|-Ut.FindChildComponent<HubEnv>
	|-Ut.FindChildComponent<Image>
	|-Ut.FindChildComponent<LayoutElement>
	|-Ut.FindChildComponent<LookAtIK>
	|-Ut.FindChildComponent<object>
	|-Ut.FindChildComponent<TextMeshMessage>
	|-Ut.FindChildComponent<TextMeshProUGUI>
	|-Ut.FindChildComponent<UnitIcon>
	|-Ut.FindChildComponent<VersusViolationTypeMenuContent>
	*/

	// RVA: -1 Offset: -1
	public static T FindChildComponent<T>(GameObject gameObject, string childName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032320 Offset: 0x2032421 VA: 0x2032320
	|-Ut.FindChildComponent<Animator>
	|-Ut.FindChildComponent<CanvasGroup>
	|-Ut.FindChildComponent<CinemachineSmoothPath>
	|-Ut.FindChildComponent<HubAccess>
	|-Ut.FindChildComponent<Image>
	|-Ut.FindChildComponent<MVPRoot>
	|-Ut.FindChildComponent<MapTerrainInfoAlignment>
	|-Ut.FindChildComponent<object>
	|-Ut.FindChildComponent<PhotoAppearContent>
	|-Ut.FindChildComponent<PhotographCameraParameter>
	|-Ut.FindChildComponent<RectTransform>
	|-Ut.FindChildComponent<TalkCharacterController>
	|-Ut.FindChildComponent<TelopInstance>
	|-Ut.FindChildComponent<Text>
	|-Ut.FindChildComponent<TextMeshProUGUI>
	|-Ut.FindChildComponent<UnitIcon>
	|-Ut.FindChildComponent<UnitInfoCharaImageMaskOffset>
	|-Ut.FindChildComponent<WellItemSelectMenuContent>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindChildComponents<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2032440 Offset: 0x2032541 VA: 0x2032440
	|-Ut.FindChildComponents<BasicMenuItemContent>
	|-Ut.FindChildComponents<Character>
	|-Ut.FindChildComponents<Image>
	|-Ut.FindChildComponents<LookAtIK>
	|-Ut.FindChildComponents<object>
	|-Ut.FindChildComponents<SkinnedMeshRenderer>
	|-Ut.FindChildComponents<TextMeshProUGUI>
	|-Ut.FindChildComponents<UnitIcon>
	*/

	// RVA: 0x20AF340 Offset: 0x20AF441 VA: 0x20AF340
	public static Quaternion GetRotation(Vector3 start, Vector3 end) { }

	// RVA: -1 Offset: -1
	public static Quaternion GetRotation<T>(T start, T end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386D710 Offset: 0x386D811 VA: 0x386D710
	|-Ut.GetRotation<object>
	*/

	// RVA: 0x20AF3E0 Offset: 0x20AF4E1 VA: 0x20AF3E0
	public static AnimationClip GetCurrentAnimationClip(Animator animator, int layerIndex = 0) { }

	// RVA: 0x20AF480 Offset: 0x20AF581 VA: 0x20AF480
	public static long RoundKB(long size) { }

	// RVA: -1 Offset: -1
	public static void SetComponentEnable<T>(GameObject gameObject, bool enable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386D890 Offset: 0x386D991 VA: 0x386D890
	|-Ut.SetComponentEnable<Behaviour>
	|-Ut.SetComponentEnable<object>
	*/

	// RVA: 0x20AF490 Offset: 0x20AF591 VA: 0x20AF490
	public static void SetComponentEnable(GameObject gameObject, bool enable) { }

	// RVA: 0x20AF520 Offset: 0x20AF621 VA: 0x20AF520
	public static void DumpTransform(Transform transform, int depth = 0) { }

	// RVA: 0x20AF640 Offset: 0x20AF741 VA: 0x20AF640
	public static void ClearProperties(Type type, object obj) { }

	// RVA: 0x20AF700 Offset: 0x20AF801 VA: 0x20AF700
	public static void CopyProperties(Type type, object src, object dst) { }

	// RVA: 0x20AF7E0 Offset: 0x20AF8E1 VA: 0x20AF7E0
	public static string GetStreamingAssetsPath() { }

	// RVA: 0x20AF870 Offset: 0x20AF971 VA: 0x20AF870
	public static string GetStreamingAssetsPath(string path, bool platform = False) { }

	// RVA: 0x20AFAB0 Offset: 0x20AFBB1 VA: 0x20AFAB0
	public static void SaveMembers(object obj) { }

	// RVA: 0x20AFAC0 Offset: 0x20AFBC1 VA: 0x20AFAC0
	public static void LoadMembers(object obj) { }

	// RVA: 0x20AFAD0 Offset: 0x20AFBD1 VA: 0x20AFAD0
	public static List<MenuItem> GetMemberItems(object instance) { }

	// RVA: 0x20AFAE0 Offset: 0x20AFBE1 VA: 0x20AFAE0
	public static List<MenuItem> GetFieldItems(object instance) { }

	// RVA: 0x20AFAF0 Offset: 0x20AFBF1 VA: 0x20AFAF0
	public static List<MenuItem> GetPropetyItems(object instance) { }

	// RVA: 0x20AFB00 Offset: 0x20AFC01 VA: 0x20AFB00
	public static Material[] GetInstanceMaterials(Renderer render) { }

	// RVA: 0x20AFBA0 Offset: 0x20AFCA1 VA: 0x20AFBA0
	public static int Hash_FNV_1(byte[] bytes) { }

	// RVA: 0x20AFCF0 Offset: 0x20AFDF1 VA: 0x20AFCF0
	public static int Hash_FNV_1(byte[] bytes, int length) { }

	// RVA: 0x20AFDF0 Offset: 0x20AFEF1 VA: 0x20AFDF0
	public static int Hash_FNV_1(uint[] values) { }

	// RVA: 0x20AFF40 Offset: 0x20B0041 VA: 0x20AFF40
	public static int Hash_FNV_1(uint[] values, int length) { }

	// RVA: 0x20B0040 Offset: 0x20B0141 VA: 0x20B0040
	public static int Hash_FNV_1(string name) { }

	// RVA: 0x20B0140 Offset: 0x20B0241 VA: 0x20B0140
	public static int Hash_FNV_1(StringBuilder name) { }

	// RVA: 0x20B0240 Offset: 0x20B0341 VA: 0x20B0240
	public static int Hash_FNV_1(BitArray array) { }

	// RVA: 0x20B0440 Offset: 0x20B0541 VA: 0x20B0440
	public static string[] GetAllAssetPaths(string root, string[] extensions) { }

	// RVA: 0x20B0450 Offset: 0x20B0551 VA: 0x20B0450
	public static string ToAssetPath(string path) { }

	// RVA: 0x20B0530 Offset: 0x20B0631 VA: 0x20B0530
	public static string ToSystemPath(string path) { }

	// RVA: 0x20B0650 Offset: 0x20B0751 VA: 0x20B0650
	public static void UnityEditorSelectObject(GameObject gameObject) { }

	// RVA: 0x20B0660 Offset: 0x20B0761 VA: 0x20B0660
	public static void UnityEditorSelectObject(Component component) { }

	// RVA: 0x20B0670 Offset: 0x20B0771 VA: 0x20B0670
	public static void EachChildren(GameObject go, Ut.GameObjectFunction func) { }

	// RVA: 0x20B0770 Offset: 0x20B0871 VA: 0x20B0770
	public static void EachParents(GameObject go, Ut.GameObjectFunction func) { }

	// RVA: 0x20B0870 Offset: 0x20B0971 VA: 0x20B0870
	public static void SetOneShotParticle(GameObject go) { }

	// RVA: 0x20B09C0 Offset: 0x20B0AC1 VA: 0x20B09C0
	public static string ValueToString(int value) { }

	// RVA: 0x20B0AE0 Offset: 0x20B0BE1 VA: 0x20B0AE0
	public static void SetTextValue(TMP_Text tmp_text, int value) { }

	// RVA: 0x20B0CE0 Offset: 0x20B0DE1 VA: 0x20B0CE0
	public static string ToStringWithComma(int value) { }

	// RVA: 0x20B0DD0 Offset: 0x20B0ED1 VA: 0x20B0DD0
	public static string GetLanguageLabel(string label) { }

	// RVA: 0x20B0EF0 Offset: 0x20B0FF1 VA: 0x20B0EF0
	public static string GetShortName(string name, int length = 32) { }

	// RVA: 0x20B0FB0 Offset: 0x20B10B1 VA: 0x20B0FB0
	public static string GetSizeName(long size) { }

	// RVA: 0x20B1070 Offset: 0x20B1171 VA: 0x20B1070
	public static Texture2D CaptureTexture(int w, int h) { }

	// RVA: 0x20B1250 Offset: 0x20B1351 VA: 0x20B1250
	public static string GetTimeStamp() { }

	// RVA: 0x20B15B0 Offset: 0x20B16B1 VA: 0x20B15B0
	public static void ForceRebuildLayout(Component component) { }

	// RVA: 0x20B1640 Offset: 0x20B1741 VA: 0x20B1640
	public void .ctor() { }

	// RVA: 0x20B1650 Offset: 0x20B1751 VA: 0x20B1650
	private static void .cctor() { }
}

