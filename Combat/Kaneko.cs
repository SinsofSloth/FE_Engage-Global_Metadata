// Namespace: Combat
[ExtensionAttribute] // RVA: 0x2749E0 Offset: 0x274AE1 VA: 0x2749E0
public static class Kaneko // TypeDefIndex: 8831
{
	// Fields
	public const float Epsilon = 1.192093E-07;
	public static Kaneko.DummyDisposable s_DummyDisposable; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x2ACE70 Offset: 0x2ACF71 VA: 0x2ACE70
	// RVA: 0x2467230 Offset: 0x2467331 VA: 0x2467230
	public static Transform FindInChildren(Transform self, string name) { }

	[ExtensionAttribute] // RVA: 0x2ACE80 Offset: 0x2ACF81 VA: 0x2ACE80
	// RVA: 0x2467950 Offset: 0x2467A51 VA: 0x2467950
	public static Transform FindWordInChildren(Transform self, string keyword) { }

	[ExtensionAttribute] // RVA: 0x2ACE90 Offset: 0x2ACF91 VA: 0x2ACE90
	// RVA: 0x2467A80 Offset: 0x2467B81 VA: 0x2467A80
	public static void SetPositionAndForward(Transform t, Vector3 position, Vector3 forward) { }

	[ExtensionAttribute] // RVA: 0x2ACEA0 Offset: 0x2ACFA1 VA: 0x2ACEA0
	// RVA: 0x2467B00 Offset: 0x2467C01 VA: 0x2467B00
	public static Transform Ancestor(Transform t) { }

	// RVA: 0x2467BA0 Offset: 0x2467CA1 VA: 0x2467BA0
	public static void Startup() { }

	// RVA: 0x2467BB0 Offset: 0x2467CB1 VA: 0x2467BB0
	public static void Shutdown() { }

	[ExtensionAttribute] // RVA: 0x2ACEB0 Offset: 0x2ACFB1 VA: 0x2ACEB0
	// RVA: 0x2467BC0 Offset: 0x2467CC1 VA: 0x2467BC0
	public static void Destroy(Object obj) { }

	[ExtensionAttribute] // RVA: 0x2ACEC0 Offset: 0x2ACFC1 VA: 0x2ACEC0
	// RVA: 0x2467C80 Offset: 0x2467D81 VA: 0x2467C80
	public static void DestroyComponent(Component obj) { }

	[ExtensionAttribute] // RVA: 0x2ACED0 Offset: 0x2ACFD1 VA: 0x2ACED0
	// RVA: 0x2467D40 Offset: 0x2467E41 VA: 0x2467D40
	public static bool IsDestroyed(Object obj) { }

	// RVA: -1 Offset: -1
	public static T SelectOne<T>(T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A900 Offset: 0x295AA01 VA: 0x295A900
	|-Kaneko.SelectOne<object>
	|-Kaneko.SelectOne<string>
	*/

	// RVA: -1 Offset: -1
	public static T SelectOne<T>(Random rand, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A950 Offset: 0x295AA51 VA: 0x295A950
	|-Kaneko.SelectOne<object>
	|-Kaneko.SelectOne<PrefetchedSignal>
	*/

	// RVA: -1 Offset: -1
	public static T SelectAnotherOne<T>(T last, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A580 Offset: 0x295A681 VA: 0x295A580
	|-Kaneko.SelectAnotherOne<object>
	*/

	// RVA: 0x2467DC0 Offset: 0x2467EC1 VA: 0x2467DC0
	public static string SelectOne(string arg) { }

	[ExtensionAttribute] // RVA: 0x2ACEE0 Offset: 0x2ACFE1 VA: 0x2ACEE0
	// RVA: 0x2467EC0 Offset: 0x2467FC1 VA: 0x2467EC0
	public static string InBetween(string s, char lc, char rc) { }

	[ExtensionAttribute] // RVA: 0x2ACEF0 Offset: 0x2ACFF1 VA: 0x2ACEF0
	// RVA: -1 Offset: -1
	public static void ShuffleSelf<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A9A0 Offset: 0x295AAA1 VA: 0x295A9A0
	|-Kaneko.ShuffleSelf<int>
	|
	|-RVA: 0x295AB20 Offset: 0x295AC21 VA: 0x295AB20
	|-Kaneko.ShuffleSelf<object>
	*/

	[ExtensionAttribute] // RVA: 0x2ACF00 Offset: 0x2AD001 VA: 0x2ACF00
	// RVA: -1 Offset: -1
	public static void ShuffleSelf<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295AA40 Offset: 0x295AB41 VA: 0x295AA40
	|-Kaneko.ShuffleSelf<object>
	*/

	// RVA: 0x2467F70 Offset: 0x2468071 VA: 0x2467F70
	public static List<string> LineToList(string line) { }

	// RVA: 0x24680F0 Offset: 0x24681F1 VA: 0x24680F0
	public static string ListToLine(List<string> list) { }

	[ExtensionAttribute] // RVA: 0x2ACF10 Offset: 0x2AD011 VA: 0x2ACF10
	// RVA: 0x2468450 Offset: 0x2468551 VA: 0x2468450
	public static void EachChildren(Transform self, Func<Transform, bool> callback) { }

	// RVA: 0x2468540 Offset: 0x2468641 VA: 0x2468540
	public static float Hermite(float v0, float t0, float v1, float t1, float s) { }

	// RVA: 0x2468580 Offset: 0x2468681 VA: 0x2468580
	public static Vector3 Hermite(in Vector3 v0, in Vector3 t0, in Vector3 v1, in Vector3 t1, float s) { }

	// RVA: 0x2468620 Offset: 0x2468721 VA: 0x2468620
	public static Vector3 Lerp(in Vector3 v0, in Vector3 t0, in Vector3 v1, in Vector3 t1, float s) { }

	// RVA: 0x2468660 Offset: 0x2468761 VA: 0x2468660
	public static Vector3 CatmullRom(in Vector3 p0, in Vector3 p1, in Vector3 p2, in Vector3 p3, float s) { }

	// RVA: 0x24687B0 Offset: 0x24688B1 VA: 0x24687B0
	public static float Sigmoid(float x, float a) { }

	// RVA: 0x2468830 Offset: 0x2468931 VA: 0x2468830
	public static Quaternion QuaternionFromNormal(in Vector3 Yaxis) { }

	[ExtensionAttribute] // RVA: 0x2ACF20 Offset: 0x2AD021 VA: 0x2ACF20
	// RVA: -1 Offset: -1
	public static Subject<T> CompleteDispose<T>(Subject<T> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A190 Offset: 0x295A291 VA: 0x295A190
	|-Kaneko.CompleteDispose<ValueTuple<Character, GameObject>>
	|-Kaneko.CompleteDispose<ValueTuple<object, object>>
	|
	|-RVA: 0x295A1C0 Offset: 0x295A2C1 VA: 0x295A1C0
	|-Kaneko.CompleteDispose<ValueTuple<float, int>>
	|
	|-RVA: 0x295A1F0 Offset: 0x295A2F1 VA: 0x295A1F0
	|-Kaneko.CompleteDispose<ValueTuple<float, Int32Enum>>
	|-Kaneko.CompleteDispose<ValueTuple<float, WeaponStyle>>
	|
	|-RVA: 0x295A250 Offset: 0x295A351 VA: 0x295A250
	|-Kaneko.CompleteDispose<AnimationEvent>
	|-Kaneko.CompleteDispose<Character>
	|-Kaneko.CompleteDispose<object>
	|-Kaneko.CompleteDispose<Phase>
	|-Kaneko.CompleteDispose<PhaseArray>
	|
	|-RVA: 0x295A220 Offset: 0x295A321 VA: 0x295A220
	|-Kaneko.CompleteDispose<int>
	|
	|-RVA: 0x295A280 Offset: 0x295A381 VA: 0x295A280
	|-Kaneko.CompleteDispose<Unit>
	*/

	// RVA: 0x2468900 Offset: 0x2468A01 VA: 0x2468900
	public static IDisposable DoLater(float delayTime, Action func) { }

	// RVA: 0x2468AD0 Offset: 0x2468BD1 VA: 0x2468AD0
	public static IDisposable DoLaterInRealtime(float delayTime, Action func) { }

	// RVA: 0x2468CE0 Offset: 0x2468DE1 VA: 0x2468CE0
	public static IDisposable DoAt(float worldTime, Action func) { }

	[ExtensionAttribute] // RVA: 0x2ACF30 Offset: 0x2AD031 VA: 0x2ACF30
	// RVA: 0x2468D70 Offset: 0x2468E71 VA: 0x2468D70
	public static IDisposable DoOnceOnLateUpdate(Character CP, Action func) { }

	// RVA: 0x2464DB0 Offset: 0x2464EB1 VA: 0x2464DB0
	public static IDisposable Coroutine(Func<IEnumerator> func) { }

	[ExtensionAttribute] // RVA: 0x2ACF40 Offset: 0x2AD041 VA: 0x2ACF40
	// RVA: 0x2468F60 Offset: 0x2469061 VA: 0x2468F60
	public static float fixedTime(AnimatorStateInfo stateInfo) { }

	[ExtensionAttribute] // RVA: 0x2ACF50 Offset: 0x2AD051 VA: 0x2ACF50
	// RVA: 0x2469070 Offset: 0x2469171 VA: 0x2469070
	public static float fixedLength(AnimatorStateInfo stateInfo) { }

	[ExtensionAttribute] // RVA: 0x2ACF60 Offset: 0x2AD061 VA: 0x2ACF60
	// RVA: 0x24690E0 Offset: 0x24691E1 VA: 0x24690E0
	public static float timeLength(AnimationCurve c) { }

	[ExtensionAttribute] // RVA: 0x2ACF70 Offset: 0x2AD071 VA: 0x2ACF70
	// RVA: 0x24680E0 Offset: 0x24681E1 VA: 0x24680E0
	public static bool IsNull(string s) { }

	[ExtensionAttribute] // RVA: 0x2ACF80 Offset: 0x2AD081 VA: 0x2ACF80
	// RVA: 0x2469170 Offset: 0x2469271 VA: 0x2469170
	public static bool IsNotNull(string s) { }

	[ExtensionAttribute] // RVA: 0x2ACF90 Offset: 0x2AD091 VA: 0x2ACF90
	// RVA: -1 Offset: -1
	public static bool IsNull<T>(IReadOnlyCollection<T> c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A4E0 Offset: 0x295A5E1 VA: 0x295A4E0
	|-Kaneko.IsNull<MagicSignal>
	|-Kaneko.IsNull<object>
	|-Kaneko.IsNull<string>
	*/

	[ExtensionAttribute] // RVA: 0x2ACFA0 Offset: 0x2AD0A1 VA: 0x2ACFA0
	// RVA: -1 Offset: -1
	public static bool IsNotNull<T>(IReadOnlyCollection<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A450 Offset: 0x295A551 VA: 0x295A450
	|-Kaneko.IsNotNull<object>
	|-Kaneko.IsNotNull<string>
	*/

	[ExtensionAttribute] // RVA: 0x2ACFB0 Offset: 0x2AD0B1 VA: 0x2ACFB0
	// RVA: 0x24691F0 Offset: 0x24692F1 VA: 0x24691F0
	public static string GetOnlyOne(List<string> l) { }

	[ExtensionAttribute] // RVA: 0x2ACFC0 Offset: 0x2AD0C1 VA: 0x2ACFC0
	// RVA: 0x2469280 Offset: 0x2469381 VA: 0x2469280
	public static bool IsZero(in Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x2ACFD0 Offset: 0x2AD0D1 VA: 0x2ACFD0
	// RVA: 0x24692F0 Offset: 0x24693F1 VA: 0x24692F0
	public static bool IsNotZero(in Vector3 v) { }

	// RVA: 0x24693C0 Offset: 0x24694C1 VA: 0x24693C0
	public static void CallEditorStaticFunction(string className, string funcName, object[] args) { }

	[ExtensionAttribute] // RVA: 0x2ACFE0 Offset: 0x2AD0E1 VA: 0x2ACFE0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Component t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A2B0 Offset: 0x295A3B1 VA: 0x295A2B0
	|-Kaneko.GetOrAddComponent<MeshFilter>
	|-Kaneko.GetOrAddComponent<MeshRenderer>
	|-Kaneko.GetOrAddComponent<object>
	|-Kaneko.GetOrAddComponent<RectTransform>
	*/

	[ExtensionAttribute] // RVA: 0x2ACFF0 Offset: 0x2AD0F1 VA: 0x2ACFF0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A380 Offset: 0x295A481 VA: 0x295A380
	|-Kaneko.GetOrAddComponent<MagicFlying>
	|-Kaneko.GetOrAddComponent<object>
	*/

	// RVA: 0x24695A0 Offset: 0x24696A1 VA: 0x24695A0
	public static int GetManhattanDistance(int x0, int y0, int x1, int y1) { }

	[ExtensionAttribute] // RVA: 0x2AD000 Offset: 0x2AD101 VA: 0x2AD000
	// RVA: 0x24695F0 Offset: 0x24696F1 VA: 0x24695F0
	public static void SetSpeed(SimpleAnimation ani, float speed) { }

	[ExtensionAttribute] // RVA: 0x2AD010 Offset: 0x2AD111 VA: 0x2AD010
	// RVA: 0x2469970 Offset: 0x2469A71 VA: 0x2469970
	public static float GetFixedTime(SimpleAnimation ani) { }

	[ExtensionAttribute] // RVA: 0x2AD020 Offset: 0x2AD121 VA: 0x2AD020
	// RVA: 0x2469CB0 Offset: 0x2469DB1 VA: 0x2469CB0
	public static float GetNormalizedTime(SimpleAnimation ani) { }

	[ExtensionAttribute] // RVA: 0x2AD030 Offset: 0x2AD131 VA: 0x2AD030
	// RVA: 0x246A0C0 Offset: 0x246A1C1 VA: 0x246A0C0
	public static float GetLength(SimpleAnimation ani) { }

	// RVA: 0x246A460 Offset: 0x246A561 VA: 0x246A460
	public static float RoundupTime(float time) { }

	// RVA: 0x246A490 Offset: 0x246A591 VA: 0x246A490
	public static float RounddownTime(float time) { }

	// RVA: 0x246A4D0 Offset: 0x246A5D1 VA: 0x246A4D0
	public static IDisposable EveryUpdateWhileTrue(Func<bool> func) { }

	[ExtensionAttribute] // RVA: 0x2AD040 Offset: 0x2AD141 VA: 0x2AD040
	// RVA: 0x246A630 Offset: 0x246A731 VA: 0x246A630
	public static IDisposable ManualTween(Character chr, float duration, Func<float, bool> onTick, Action onFinish) { }

	[ExtensionAttribute] // RVA: 0x2AD050 Offset: 0x2AD151 VA: 0x2AD050
	// RVA: 0x246A880 Offset: 0x246A981 VA: 0x246A880
	public static IDisposable DoLater(Character chr, float delayTime, Action func) { }

	[ConditionalAttribute] // RVA: 0x2AD060 Offset: 0x2AD161 VA: 0x2AD060
	// RVA: 0x246AAC0 Offset: 0x246ABC1 VA: 0x246AAC0
	public static void Assert(bool exp, string msg = "", string filename = "", int line = 0, string funcname = "") { }

	[ConditionalAttribute] // RVA: 0x2AD0A0 Offset: 0x2AD1A1 VA: 0x2AD0A0
	// RVA: 0x246AAD0 Offset: 0x246ABD1 VA: 0x246AAD0
	public static void Assert(string msg = "", string filename = "", int line = 0, string funcname = "") { }

	// RVA: 0x246AAE0 Offset: 0x246ABE1 VA: 0x246AAE0
	public static Vector3 LimitGroundNormal(Vector3 nrm) { }

	// RVA: 0x246AB80 Offset: 0x246AC81 VA: 0x246AB80
	public static void GUIFitToScreen() { }

	// RVA: 0x246AC70 Offset: 0x246AD71 VA: 0x246AC70
	public static void GUIReset() { }

	// RVA: 0x246AD30 Offset: 0x246AE31 VA: 0x246AD30
	public static float GetFov(Component cam) { }

	// RVA: 0x246AFA0 Offset: 0x246B0A1 VA: 0x246AFA0
	private static void .cctor() { }
}

