// Namespace: App
public class ResourceObject : MonoBehaviour // TypeDefIndex: 13924
{
	// Fields
	private ResourceGameObject m_Handle; // 0x18
	private ResourceObject.Callback m_StartCallback; // 0x20
	private ResourceObject.Callback m_TickCallback; // 0x28
	private ResourceObject.Callback m_EndCallback; // 0x30
	private ResourceObject.Coroutine m_Coroutine; // 0x38
	private ProcInst m_BindProc; // 0x40
	private BindHolder m_BindHolder; // 0x48
	private ResourceObject.Sequence m_Sequence; // 0x50
	private ResourceObject.Flags m_Flags; // 0x54
	private float m_DelayTime; // 0x58
	private float m_BindTime; // 0x5C
	private float m_LifeTime; // 0x60
	private string m_SoundLabel; // 0x68

	// Methods

	// RVA: 0x24D09F0 Offset: 0x24D0AF1 VA: 0x24D09F0
	private void Update() { }

	// RVA: 0x24D0C20 Offset: 0x24D0D21 VA: 0x24D0C20
	private void OnDestroy() { }

	// RVA: 0x24D0D00 Offset: 0x24D0E01 VA: 0x24D0D00
	private void Create() { }

	// RVA: 0x24D0C30 Offset: 0x24D0D31 VA: 0x24D0C30
	private void Release() { }

	// RVA: 0x24D0FA0 Offset: 0x24D10A1 VA: 0x24D0FA0
	private bool CanSkip() { }

	// RVA: 0x24D0A20 Offset: 0x24D0B21 VA: 0x24D0A20
	private bool Tick() { }

	// RVA: 0x24D10B0 Offset: 0x24D11B1 VA: 0x24D10B0
	private void TickBind() { }

	// RVA: 0x24D0FD0 Offset: 0x24D10D1 VA: 0x24D0FD0
	private bool IsTerminated() { }

	// RVA: -1 Offset: -1
	public void LoadAsync<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A000 Offset: 0x201A101 VA: 0x201A000
	|-ResourceObject.LoadAsync<GameObject>
	|-ResourceObject.LoadAsync<object>
	*/

	// RVA: 0x24D1440 Offset: 0x24D1541 VA: 0x24D1440
	public ResourceObject SetStartCallback(ResourceObject.Callback callback) { }

	// RVA: 0x24D1470 Offset: 0x24D1571 VA: 0x24D1470
	public ResourceObject SetTickCallback(ResourceObject.Callback callback) { }

	// RVA: 0x24D14A0 Offset: 0x24D15A1 VA: 0x24D14A0
	public ResourceObject SetEndCallback(ResourceObject.Callback callback) { }

	// RVA: 0x24D14D0 Offset: 0x24D15D1 VA: 0x24D14D0
	public ResourceObject SetCoroutine(ResourceObject.Coroutine coroutine) { }

	// RVA: 0x24D1500 Offset: 0x24D1601 VA: 0x24D1500
	public ResourceObject SetPosition(Vector3 position) { }

	// RVA: 0x24D1560 Offset: 0x24D1661 VA: 0x24D1560
	public ResourceObject SetPosition(float x, float y, float z) { }

	// RVA: 0x24D15C0 Offset: 0x24D16C1 VA: 0x24D15C0
	public ResourceObject SetRotation(Quaternion rotation) { }

	// RVA: 0x24D1620 Offset: 0x24D1721 VA: 0x24D1620
	public ResourceObject SetRotation(float x, float y, float z) { }

	// RVA: 0x24D1690 Offset: 0x24D1791 VA: 0x24D1690
	public ResourceObject SetScale(Vector3 scale) { }

	// RVA: 0x24D16F0 Offset: 0x24D17F1 VA: 0x24D16F0
	public ResourceObject SetScale(float scale) { }

	// RVA: 0x24D1740 Offset: 0x24D1841 VA: 0x24D1740
	public ResourceObject SetScale(float x, float y, float z) { }

	// RVA: 0x24D17A0 Offset: 0x24D18A1 VA: 0x24D17A0
	public ResourceObject SetSound(string soundLabel) { }

	// RVA: 0x24D17D0 Offset: 0x24D18D1 VA: 0x24D17D0
	public ResourceObject SetEndless(bool enable) { }

	// RVA: 0x24D17F0 Offset: 0x24D18F1 VA: 0x24D17F0
	public ResourceObject SetCanSkip(bool enable) { }

	// RVA: 0x24D1810 Offset: 0x24D1911 VA: 0x24D1810
	public ResourceObject SetLife(float time) { }

	// RVA: 0x24D1820 Offset: 0x24D1921 VA: 0x24D1820
	public bool IsEndless() { }

	// RVA: 0x24D11B0 Offset: 0x24D12B1 VA: 0x24D11B0
	public void Destroy() { }

	// RVA: 0x24D1830 Offset: 0x24D1931 VA: 0x24D1830
	public ResourceObject SetDelayTime(float time) { }

	// RVA: 0x24D0E30 Offset: 0x24D0F31 VA: 0x24D0E30
	public ResourceObject TryStartCallback() { }

	// RVA: 0x24D0EC0 Offset: 0x24D0FC1 VA: 0x24D0EC0
	public ResourceObject TryEndCallback() { }

	// RVA: 0x24D1840 Offset: 0x24D1941 VA: 0x24D1840
	public ResourceObject TryBind(ProcInst super) { }

	// RVA: 0x24D1910 Offset: 0x24D1A11 VA: 0x24D1910
	public ResourceObject TryBind(BindHolder binder) { }

	// RVA: 0x24D18A0 Offset: 0x24D19A1 VA: 0x24D18A0
	public ResourceObject TryBind(ProcInst super, float time) { }

	// RVA: 0x24D1970 Offset: 0x24D1A71 VA: 0x24D1970
	public ResourceObject TryBind(BindHolder binder, float time) { }

	// RVA: 0x24D0F20 Offset: 0x24D1021 VA: 0x24D0F20
	public ResourceObject TryUnbind() { }

	// RVA: 0x24D19E0 Offset: 0x24D1AE1 VA: 0x24D19E0
	private static ResourceObject CreateObjectImpl(Transform parent, string name, ProcInst super) { }

	// RVA: 0x24D1C10 Offset: 0x24D1D11 VA: 0x24D1C10
	public static ResourceObject CreateAsync(string path, GameObject parent, ProcInst super) { }

	// RVA: 0x24D1CC0 Offset: 0x24D1DC1 VA: 0x24D1CC0
	public static ResourceObject CreateAsync(string path, Transform parent, ProcInst super) { }

	// RVA: 0x24D1DC0 Offset: 0x24D1EC1 VA: 0x24D1DC0
	public static ResourceObject CreateAsync(string path, ProcInst super) { }

	// RVA: 0x24D1DD0 Offset: 0x24D1ED1 VA: 0x24D1DD0
	public static ResourceObject CreateAsync(string path) { }

	// RVA: 0x24D1DE0 Offset: 0x24D1EE1 VA: 0x24D1DE0
	public static GameObject op_Implicit(ResourceObject res) { }

	// RVA: 0x24D1DF0 Offset: 0x24D1EF1 VA: 0x24D1DF0
	public void .ctor() { }
}

