// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43E300 Offset: 0x43E401 VA: 0x43E300
[NativeHeaderAttribute] // RVA: 0x43E300 Offset: 0x43E401 VA: 0x43E300
[NativeHeaderAttribute] // RVA: 0x43E300 Offset: 0x43E401 VA: 0x43E300
public class AsyncOperation : YieldInstruction // TypeDefIndex: 3570
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { get; set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0x44EE10 Offset: 0x44EF11 VA: 0x44EE10
	[NativeMethodAttribute] // RVA: 0x44EE10 Offset: 0x44EF11 VA: 0x44EE10
	// RVA: 0x2F0A8E0 Offset: 0x2F0A9E1 VA: 0x2F0A8E0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0x44EE70 Offset: 0x44EF71 VA: 0x44EE70
	// RVA: 0x2F0A930 Offset: 0x2F0AA31 VA: 0x2F0A930
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x44EEB0 Offset: 0x44EFB1 VA: 0x44EEB0
	// RVA: 0x2F0A980 Offset: 0x2F0AA81 VA: 0x2F0A980
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0x44EEF0 Offset: 0x44EFF1 VA: 0x44EEF0
	// RVA: 0x2F0A9D0 Offset: 0x2F0AAD1 VA: 0x2F0A9D0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0x44EF30 Offset: 0x44F031 VA: 0x44EF30
	// RVA: 0x2F0AA20 Offset: 0x2F0AB21 VA: 0x2F0AA20
	public bool get_allowSceneActivation() { }

	[NativeMethodAttribute] // RVA: 0x44EF70 Offset: 0x44F071 VA: 0x44EF70
	// RVA: 0x2F0AA70 Offset: 0x2F0AB71 VA: 0x2F0AA70
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2F0AAC0 Offset: 0x2F0ABC1 VA: 0x2F0AAC0 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44EFB0 Offset: 0x44F0B1 VA: 0x44EFB0
	// RVA: 0x2F0AB60 Offset: 0x2F0AC61 VA: 0x2F0AB60
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2F0ABE0 Offset: 0x2F0ACE1 VA: 0x2F0ABE0
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2F0ACE0 Offset: 0x2F0ADE1 VA: 0x2F0ACE0
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2F0AD70 Offset: 0x2F0AE71 VA: 0x2F0AD70
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43E6B0 Offset: 0x43E7B1 VA: 0x43E6B0
[RequiredByNativeCodeAttribute] // RVA: 0x43E6B0 Offset: 0x43E7B1 VA: 0x43E6B0
public sealed class Coroutine : YieldInstruction // TypeDefIndex: 3588
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x2F1B9C0 Offset: 0x2F1BAC1 VA: 0x2F1B9C0
	private void .ctor() { }

	// RVA: 0x2F1B9D0 Offset: 0x2F1BAD1 VA: 0x2F1B9D0 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x44F210 Offset: 0x44F311 VA: 0x44F210
	// RVA: 0x2F1BA70 Offset: 0x2F1BB71 VA: 0x2F1BA70
	private static void ReleaseCoroutine(IntPtr ptr) { }
}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 3590
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0x2F1E9A0 Offset: 0x2F1EAA1 VA: 0x2F1E9A0 Slot: 5
	public object get_Current() { }

	// RVA: 0x2F1E9B0 Offset: 0x2F1EAB1 VA: 0x2F1E9B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2F1E9C0 Offset: 0x2F1EAC1 VA: 0x2F1E9C0 Slot: 8
	public virtual void Reset() { }

	// RVA: 0x2F1E9D0 Offset: 0x2F1EAD1 VA: 0x2F1E9D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43EC40 Offset: 0x43ED41 VA: 0x43EC40
public sealed class WaitForEndOfFrame : YieldInstruction // TypeDefIndex: 3618
{
	// Methods

	// RVA: 0x3852140 Offset: 0x3852241 VA: 0x3852140
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43EC60 Offset: 0x43ED61 VA: 0x43EC60
public sealed class WaitForSeconds : YieldInstruction // TypeDefIndex: 3620
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x3852170 Offset: 0x3852271 VA: 0x3852170
	public void .ctor(float seconds) { }
}

// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43EC70 Offset: 0x43ED71 VA: 0x43EC70
public class YieldInstruction // TypeDefIndex: 3622
{
	// Methods

	// RVA: 0x3852150 Offset: 0x3852251 VA: 0x3852150
	public void .ctor() { }
}

// Namespace: UnityEngine
[ObsoleteAttribute] // RVA: 0x844D0 Offset: 0x845D1 VA: 0x844D0
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4854
{
	// Fields
	private UnityWebRequest _uwr; // 0x10
	private AssetBundle _assetBundle; // 0x18
	private Dictionary<string, string> _responseHeaders; // 0x20

	// Properties
	public AssetBundle assetBundle { get; }
	public byte[] bytes { get; }
	public string error { get; }
	public bool isDone { get; }
	public float progress { get; }
	public Dictionary<string, string> responseHeaders { get; }
	public string text { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x1C64C80 Offset: 0x1C64D81 VA: 0x1C64C80
	public static WWW LoadFromCacheOrDownload(string url, int version) { }

	// RVA: 0x1C64CE0 Offset: 0x1C64DE1 VA: 0x1C64CE0
	public static WWW LoadFromCacheOrDownload(string url, int version, uint crc) { }

	// RVA: 0x1C64E50 Offset: 0x1C64F51 VA: 0x1C64E50
	public static WWW LoadFromCacheOrDownload(string url, Hash128 hash) { }

	// RVA: 0x1C64D40 Offset: 0x1C64E41 VA: 0x1C64D40
	public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc) { }

	// RVA: 0x1C64F10 Offset: 0x1C65011 VA: 0x1C64F10
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x1C64F80 Offset: 0x1C65081 VA: 0x1C64F80
	public void .ctor(string url, byte[] postData) { }

	// RVA: 0x1C650F0 Offset: 0x1C651F1 VA: 0x1C650F0
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x1C64E60 Offset: 0x1C64F61 VA: 0x1C64E60
	internal void .ctor(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x1C65380 Offset: 0x1C65481 VA: 0x1C65380
	public AssetBundle get_assetBundle() { }

	// RVA: 0x1C655B0 Offset: 0x1C656B1 VA: 0x1C655B0
	public byte[] get_bytes() { }

	// RVA: 0x1C65640 Offset: 0x1C65741 VA: 0x1C65640
	public string get_error() { }

	// RVA: 0x1C65750 Offset: 0x1C65851 VA: 0x1C65750
	public bool get_isDone() { }

	// RVA: 0x1C65760 Offset: 0x1C65861 VA: 0x1C65760
	public float get_progress() { }

	// RVA: 0x1C65790 Offset: 0x1C65891 VA: 0x1C65790
	public Dictionary<string, string> get_responseHeaders() { }

	// RVA: 0x1C65940 Offset: 0x1C65A41 VA: 0x1C65940
	public string get_text() { }

	// RVA: 0x1C659D0 Offset: 0x1C65AD1 VA: 0x1C659D0
	public string get_url() { }

	// RVA: 0x1C659E0 Offset: 0x1C65AE1 VA: 0x1C659E0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1C65A20 Offset: 0x1C65B21 VA: 0x1C65A20 Slot: 9
	public void Dispose() { }

	// RVA: 0x1C654B0 Offset: 0x1C655B1 VA: 0x1C654B0
	private bool WaitUntilDoneIfPossible() { }
}

