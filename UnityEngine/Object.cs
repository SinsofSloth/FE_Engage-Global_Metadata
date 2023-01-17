// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43EB90 Offset: 0x43EC91 VA: 0x43EB90
[NativeHeaderAttribute] // RVA: 0x43EB90 Offset: 0x43EC91 VA: 0x43EB90
[NativeHeaderAttribute] // RVA: 0x43EB90 Offset: 0x43EC91 VA: 0x43EB90
[RequiredByNativeCodeAttribute] // RVA: 0x43EB90 Offset: 0x43EC91 VA: 0x43EB90
public class Object // TypeDefIndex: 3615
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x348C4F0 Offset: 0x348C5F1 VA: 0x348C4F0
	public int GetInstanceID() { }

	// RVA: 0x348C690 Offset: 0x348C791 VA: 0x348C690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x348C6A0 Offset: 0x348C7A1 VA: 0x348C6A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x348C980 Offset: 0x348CA81 VA: 0x348C980
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x348C870 Offset: 0x348C971 VA: 0x348C870
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x348CAD0 Offset: 0x348CBD1 VA: 0x348CAD0
	private void EnsureRunningOnMainThread() { }

	// RVA: 0x348CA80 Offset: 0x348CB81 VA: 0x348CA80
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x348CBF0 Offset: 0x348CCF1 VA: 0x348CBF0
	private IntPtr GetCachedPtr() { }

	// RVA: 0x34874F0 Offset: 0x34875F1 VA: 0x34874F0
	public string get_name() { }

	// RVA: 0x348CC50 Offset: 0x348CD51 VA: 0x348CC50
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0x4501E0 Offset: 0x4502E1 VA: 0x4501E0
	// RVA: 0x348CD40 Offset: 0x348CE41 VA: 0x348CD40
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450200 Offset: 0x450301 VA: 0x450200
	// RVA: 0x348D180 Offset: 0x348D281 VA: 0x348D180
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450220 Offset: 0x450321 VA: 0x450220
	// RVA: 0x348D610 Offset: 0x348D711 VA: 0x348D610
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450240 Offset: 0x450341 VA: 0x450240
	// RVA: 0x348D860 Offset: 0x348D961 VA: 0x348D860
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450260 Offset: 0x450361 VA: 0x450260
	// RVA: 0x348D8E0 Offset: 0x348D9E1 VA: 0x348D8E0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969800 Offset: 0x2969901 VA: 0x2969800
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<MapInfoIconLocatorRoot>
	|-Object.Instantiate<Material>
	|-Object.Instantiate<object>
	|-Object.Instantiate<Transform>
	|-Object.Instantiate<VolumeComponent>
	|-Object.Instantiate<Dropdown.DropdownItem>
	|-Object.Instantiate<TMP_Dropdown.DropdownItem>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969AA0 Offset: 0x2969BA1 VA: 0x2969AA0
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969BB0 Offset: 0x2969CB1 VA: 0x2969BB0
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969940 Offset: 0x2969A41 VA: 0x2969940
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	|-Object.Instantiate<Text>
	|-Object.Instantiate<Toggle>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29699D0 Offset: 0x2969AD1 VA: 0x29699D0
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	|-Object.Instantiate<RectTransform>
	|-Object.Instantiate<Transform>
	*/

	[NativeMethodAttribute] // RVA: 0x450280 Offset: 0x450381 VA: 0x450280
	// RVA: 0x348DC50 Offset: 0x348DD51 VA: 0x348DC50
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4502D0 Offset: 0x4503D1 VA: 0x4502D0
	// RVA: 0x348DCA0 Offset: 0x348DDA1 VA: 0x348DCA0
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0x4502E0 Offset: 0x4503E1 VA: 0x4502E0
	// RVA: 0x348DD40 Offset: 0x348DE41 VA: 0x348DD40
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x450330 Offset: 0x450431 VA: 0x450330
	// RVA: 0x348DD90 Offset: 0x348DE91 VA: 0x348DD90
	public static void DestroyImmediate(Object obj) { }

	// RVA: 0x348DE30 Offset: 0x348DF31 VA: 0x348DE30
	public static Object[] FindObjectsOfType(Type type) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450340 Offset: 0x450441 VA: 0x450340
	[FreeFunctionAttribute] // RVA: 0x450340 Offset: 0x450441 VA: 0x450340
	// RVA: 0x348DED0 Offset: 0x348DFD1 VA: 0x348DED0
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[FreeFunctionAttribute] // RVA: 0x450390 Offset: 0x450491 VA: 0x450390
	// RVA: 0x348DF20 Offset: 0x348E021 VA: 0x348DF20
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x348DF70 Offset: 0x348E071 VA: 0x348DF70
	public HideFlags get_hideFlags() { }

	// RVA: 0x348DFC0 Offset: 0x348E0C1 VA: 0x348DFC0
	public void set_hideFlags(HideFlags value) { }

	[ObsoleteAttribute] // RVA: 0x4503E0 Offset: 0x4504E1 VA: 0x4503E0
	// RVA: 0x348E010 Offset: 0x348E111 VA: 0x348E010
	public static void DestroyObject(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x450420 Offset: 0x450521 VA: 0x450420
	[ObsoleteAttribute] // RVA: 0x450420 Offset: 0x450521 VA: 0x450420
	// RVA: 0x348E0C0 Offset: 0x348E1C1 VA: 0x348E0C0
	public static void DestroyObject(Object obj) { }

	[ObsoleteAttribute] // RVA: 0x450470 Offset: 0x450571 VA: 0x450470
	// RVA: 0x348E160 Offset: 0x348E261 VA: 0x348E160
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[ObsoleteAttribute] // RVA: 0x4504B0 Offset: 0x4505B1 VA: 0x4504B0
	[FreeFunctionAttribute] // RVA: 0x4504B0 Offset: 0x4505B1 VA: 0x4504B0
	// RVA: 0x348E250 Offset: 0x348E351 VA: 0x348E250
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969660 Offset: 0x2969761 VA: 0x2969660
	|-Object.FindObjectsOfType<CameraControllerUnitDetail>
	|-Object.FindObjectsOfType<EventSystem>
	|-Object.FindObjectsOfType<GrassManager>
	|-Object.FindObjectsOfType<LODGroup>
	|-Object.FindObjectsOfType<MainThreadDispatcher>
	|-Object.FindObjectsOfType<object>
	|-Object.FindObjectsOfType<ReflectionProbe>
	|-Object.FindObjectsOfType<Renderer>
	|-Object.FindObjectsOfType<Transform>
	|-Object.FindObjectsOfType<Volume>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969730 Offset: 0x2969831 VA: 0x2969730
	|-Object.FindObjectsOfType<HubConditionController>
	|-Object.FindObjectsOfType<HubMaterialSelector>
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969440 Offset: 0x2969541 VA: 0x2969440
	|-Object.FindObjectOfType<DebugUIHandlerPersistentCanvas>
	|-Object.FindObjectOfType<EffectCatalog>
	|-Object.FindObjectOfType<EventSystem>
	|-Object.FindObjectOfType<FieldGrid>
	|-Object.FindObjectOfType<FieldLoader>
	|-Object.FindObjectOfType<HubAccessoryRoomCamera>
	|-Object.FindObjectOfType<HubSkySelector>
	|-Object.FindObjectOfType<InstanceCache>
	|-Object.FindObjectOfType<MainThreadDispatcher>
	|-Object.FindObjectOfType<object>
	|-Object.FindObjectOfType<SkyScroller>
	|-Object.FindObjectOfType<SpringJobScheduler>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969550 Offset: 0x2969651 VA: 0x2969550
	|-Object.FindObjectOfType<object>
	*/

	[ObsoleteAttribute] // RVA: 0x450510 Offset: 0x450611 VA: 0x450510
	// RVA: 0x348E2A0 Offset: 0x348E3A1 VA: 0x348E2A0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x348D070 Offset: 0x348D171 VA: 0x348D070
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450550 Offset: 0x450651 VA: 0x450550
	// RVA: 0x348E2B0 Offset: 0x348E3B1 VA: 0x348E2B0
	public static Object FindObjectOfType(Type type) { }

	[TypeInferenceRuleAttribute] // RVA: 0x450570 Offset: 0x450671 VA: 0x450570
	// RVA: 0x348E370 Offset: 0x348E471 VA: 0x348E370
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x348E440 Offset: 0x348E541 VA: 0x348E440 Slot: 3
	public override string ToString() { }

	// RVA: 0x3487070 Offset: 0x3487171 VA: 0x3487070
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x348E530 Offset: 0x348E631 VA: 0x348E530
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0x450590 Offset: 0x450691 VA: 0x450590
	// RVA: 0x348C650 Offset: 0x348C751 VA: 0x348C650
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethodAttribute] // RVA: 0x4505E0 Offset: 0x4506E1 VA: 0x4505E0
	// RVA: 0x348CBB0 Offset: 0x348CCB1 VA: 0x348CBB0
	private static bool CurrentThreadIsMainThread() { }

	[FreeFunctionAttribute] // RVA: 0x450630 Offset: 0x450731 VA: 0x450630
	// RVA: 0x348D810 Offset: 0x348D911 VA: 0x348D810
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0x450670 Offset: 0x450771 VA: 0x450670
	// RVA: 0x348DBF0 Offset: 0x348DCF1 VA: 0x348DBF0
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0x4506B0 Offset: 0x4507B1 VA: 0x4506B0
	// RVA: 0x348D0C0 Offset: 0x348D1C1 VA: 0x348D0C0
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0x4506F0 Offset: 0x4507F1 VA: 0x4506F0
	// RVA: 0x348D540 Offset: 0x348D641 VA: 0x348D540
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0x450730 Offset: 0x450831 VA: 0x450730
	// RVA: 0x348E4E0 Offset: 0x348E5E1 VA: 0x348E4E0
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0x450770 Offset: 0x450871 VA: 0x450770
	// RVA: 0x348CC00 Offset: 0x348CD01 VA: 0x348CC00
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0x4507B0 Offset: 0x4508B1 VA: 0x4507B0
	// RVA: 0x348E680 Offset: 0x348E781 VA: 0x348E680
	internal static bool IsPersistent(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0x4507F0 Offset: 0x4508F1 VA: 0x4507F0
	// RVA: 0x348CCF0 Offset: 0x348CDF1 VA: 0x348CCF0
	private static void SetName(Object obj, string name) { }

	[NativeMethodAttribute] // RVA: 0x450830 Offset: 0x450931 VA: 0x450830
	// RVA: 0x348E6D0 Offset: 0x348E7D1 VA: 0x348E6D0
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x450880 Offset: 0x450981 VA: 0x450880
	[FreeFunctionAttribute] // RVA: 0x450880 Offset: 0x450981 VA: 0x450880
	// RVA: 0x348E720 Offset: 0x348E821 VA: 0x348E720
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4508D0 Offset: 0x4509D1 VA: 0x4508D0
	[FreeFunctionAttribute] // RVA: 0x4508D0 Offset: 0x4509D1 VA: 0x4508D0
	// RVA: 0x348E770 Offset: 0x348E871 VA: 0x348E770
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	// RVA: 0x34777B0 Offset: 0x34778B1 VA: 0x34777B0
	public void .ctor() { }

	// RVA: 0x348E7C0 Offset: 0x348E8C1 VA: 0x348E7C0
	private static void .cctor() { }

	// RVA: 0x348E5B0 Offset: 0x348E6B1 VA: 0x348E5B0
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x348E610 Offset: 0x348E711 VA: 0x348E610
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }
}

