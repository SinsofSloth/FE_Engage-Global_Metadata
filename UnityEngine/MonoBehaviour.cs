// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43E910 Offset: 0x43EA11 VA: 0x43E910
[NativeHeaderAttribute] // RVA: 0x43E910 Offset: 0x43EA11 VA: 0x43E910
[ExtensionOfNativeClassAttribute] // RVA: 0x43E910 Offset: 0x43EA11 VA: 0x43E910
[RequiredByNativeCodeAttribute] // RVA: 0x43E910 Offset: 0x43EA11 VA: 0x43E910
public class MonoBehaviour : Behaviour // TypeDefIndex: 3597
{
	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x348B5A0 Offset: 0x348B6A1 VA: 0x348B5A0
	public bool IsInvoking() { }

	// RVA: 0x348B640 Offset: 0x348B741 VA: 0x348B640
	public void CancelInvoke() { }

	// RVA: 0x348B6E0 Offset: 0x348B7E1 VA: 0x348B6E0
	public void Invoke(string methodName, float time) { }

	// RVA: 0x348B7C0 Offset: 0x348B8C1 VA: 0x348B7C0
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x348B890 Offset: 0x348B991 VA: 0x348B890
	public void CancelInvoke(string methodName) { }

	// RVA: 0x348B930 Offset: 0x348BA31 VA: 0x348B930
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FF80 Offset: 0x450081 VA: 0x44FF80
	// RVA: 0x348B9D0 Offset: 0x348BAD1 VA: 0x348B9D0
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x348B9E0 Offset: 0x348BAE1 VA: 0x348B9E0
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x348BBA0 Offset: 0x348BCA1 VA: 0x348BBA0
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0x44FF90 Offset: 0x450091 VA: 0x44FF90
	// RVA: 0x348BCF0 Offset: 0x348BDF1 VA: 0x348BCF0
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x348BD00 Offset: 0x348BE01 VA: 0x348BD00
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x348BE50 Offset: 0x348BF51 VA: 0x348BE50
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x348BFA0 Offset: 0x348C0A1 VA: 0x348BFA0
	public void StopCoroutine(string methodName) { }

	// RVA: 0x348BFF0 Offset: 0x348C0F1 VA: 0x348BFF0
	public void StopAllCoroutines() { }

	// RVA: 0x348C040 Offset: 0x348C141 VA: 0x348C040
	public bool get_useGUILayout() { }

	// RVA: 0x348C090 Offset: 0x348C191 VA: 0x348C090
	public void set_useGUILayout(bool value) { }

	// RVA: 0x348C0E0 Offset: 0x348C1E1 VA: 0x348C0E0
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0x44FFD0 Offset: 0x4500D1 VA: 0x44FFD0
	// RVA: 0x348B690 Offset: 0x348B791 VA: 0x348B690
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x450010 Offset: 0x450111 VA: 0x450010
	// RVA: 0x348B5F0 Offset: 0x348B6F1 VA: 0x348B5F0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x450050 Offset: 0x450151 VA: 0x450050
	// RVA: 0x348B750 Offset: 0x348B851 VA: 0x348B750
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0x450060 Offset: 0x450161 VA: 0x450060
	// RVA: 0x348B8E0 Offset: 0x348B9E1 VA: 0x348B8E0
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x450070 Offset: 0x450171 VA: 0x450070
	// RVA: 0x348B980 Offset: 0x348BA81 VA: 0x348B980
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x450080 Offset: 0x450181 VA: 0x450080
	// RVA: 0x348BAF0 Offset: 0x348BBF1 VA: 0x348BAF0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x348BB40 Offset: 0x348BC41 VA: 0x348BB40
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x348BCA0 Offset: 0x348BDA1 VA: 0x348BCA0
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x348BF50 Offset: 0x348C051 VA: 0x348BF50
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x348BE00 Offset: 0x348BF01 VA: 0x348BE00
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x348C150 Offset: 0x348C251 VA: 0x348C150
	internal string GetScriptClassName() { }

	// RVA: 0x348C1A0 Offset: 0x348C2A1 VA: 0x348C1A0
	public void .ctor() { }
}

