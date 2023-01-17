// Namespace: App
public abstract class DragonRideTargetGroup : MonoBehaviour // TypeDefIndex: 10547
{
	// Fields
	private const string cTargetPrefabPath = "Hub/Prefabs/DragonRide/Target";
	[CompilerGeneratedAttribute] // RVA: 0x28F560 Offset: 0x28F661 VA: 0x28F560
	private bool <IsSearchGroup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28F570 Offset: 0x28F671 VA: 0x28F570
	private bool <IsExecuteChain>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x28F580 Offset: 0x28F681 VA: 0x28F580
	private bool <IsEventMode>k__BackingField; // 0x1A
	[CompilerGeneratedAttribute] // RVA: 0x28F590 Offset: 0x28F691 VA: 0x28F590
	private bool <IsVisible>k__BackingField; // 0x1B
	private BillboardTypes m_BillboardType; // 0x1C
	private int m_MapWidth; // 0x20
	private int m_MapHeight; // 0x24
	private int[,] m_Map; // 0x28
	private GameObject[,] m_Children; // 0x30
	private float m_ChainIntervalTimer; // 0x38
	private GameObject m_GameCamera; // 0x40
	private DragonRideCamera m_CameraScript; // 0x48
	private DragonRideConfig m_Config; // 0x50
	public Vector2 m_TargetSpace; // 0x58
	private List<DragonRideTargetGroup.ChainSEManager> m_ChainPlayer; // 0x60
	private List<DragonRideTargetGroup.ChainParam> m_ChainChecker; // 0x68

	// Properties
	public bool IsSearchGroup { get; set; }
	public bool IsExecuteChain { get; set; }
	public bool IsEventMode { get; set; }
	public bool IsVisible { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF240 Offset: 0x2BF341 VA: 0x2BF240
	// RVA: 0x2DDB390 Offset: 0x2DDB491 VA: 0x2DDB390
	public bool get_IsSearchGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF250 Offset: 0x2BF351 VA: 0x2BF250
	// RVA: 0x2DDB3A0 Offset: 0x2DDB4A1 VA: 0x2DDB3A0
	public void set_IsSearchGroup(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF260 Offset: 0x2BF361 VA: 0x2BF260
	// RVA: 0x2DDB3B0 Offset: 0x2DDB4B1 VA: 0x2DDB3B0
	public bool get_IsExecuteChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF270 Offset: 0x2BF371 VA: 0x2BF270
	// RVA: 0x2DDB3C0 Offset: 0x2DDB4C1 VA: 0x2DDB3C0
	public void set_IsExecuteChain(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF280 Offset: 0x2BF381 VA: 0x2BF280
	// RVA: 0x2DDB3D0 Offset: 0x2DDB4D1 VA: 0x2DDB3D0
	public bool get_IsEventMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF290 Offset: 0x2BF391 VA: 0x2BF290
	// RVA: 0x2DDB3E0 Offset: 0x2DDB4E1 VA: 0x2DDB3E0
	private void set_IsEventMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF2A0 Offset: 0x2BF3A1 VA: 0x2BF2A0
	// RVA: 0x2DDB3F0 Offset: 0x2DDB4F1 VA: 0x2DDB3F0
	public bool get_IsVisible() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF2B0 Offset: 0x2BF3B1 VA: 0x2BF2B0
	// RVA: 0x2DDB400 Offset: 0x2DDB501 VA: 0x2DDB400
	private void set_IsVisible(bool value) { }

	// RVA: 0x2DDB410 Offset: 0x2DDB511 VA: 0x2DDB410
	public void Start() { }

	// RVA: 0x2DDB420 Offset: 0x2DDB521 VA: 0x2DDB420
	public void Update() { }

	// RVA: 0x2DDB430 Offset: 0x2DDB531 VA: 0x2DDB430
	public void Initialize(ref DragonRideCamera cameraScript, string id, string courseId, string groupName, string locatorName, BillboardTypes type, int[,] setMap) { }

	// RVA: 0x2DC98B0 Offset: 0x2DC99B1 VA: 0x2DC98B0
	public void PostUpdate() { }

	// RVA: 0x2DCA000 Offset: 0x2DCA101 VA: 0x2DCA000
	public void SetEventMode(bool flag) { }

	// RVA: 0x2DC63B0 Offset: 0x2DC64B1 VA: 0x2DC63B0
	public void Show() { }

	// RVA: 0x2DC6F10 Offset: 0x2DC7011 VA: 0x2DC6F10
	public void Hide() { }

	// RVA: 0x2DC57A0 Offset: 0x2DC58A1 VA: 0x2DC57A0
	public void Destroy() { }

	// RVA: 0x2DDBED0 Offset: 0x2DDBFD1 VA: 0x2DDBED0
	private DragonRideTarget GetChildScript(int h, int w) { }

	// RVA: 0x2DDC000 Offset: 0x2DDC101 VA: 0x2DDC000
	private void ExecuteChild(int h, int w, int flag, string rootID) { }

	// RVA: 0x2DDBD40 Offset: 0x2DDBE41 VA: 0x2DDBD40
	private bool CheckStartChain() { }

	// RVA: 0x2DDB780 Offset: 0x2DDB881 VA: 0x2DDB780
	private void UpdateChain() { }

	// RVA: 0x2DDB650 Offset: 0x2DDB751 VA: 0x2DDB650
	private void SetChainExecute() { }

	// RVA: 0x2DC9D30 Offset: 0x2DC9E31 VA: 0x2DC9D30
	public float GetNearestTarget(ref Vector3 returnPos, Vector3 cameraPos, Vector3 cameraForward, float enableRate) { }

	// RVA: 0x2DDC3A0 Offset: 0x2DDC4A1 VA: 0x2DDC3A0
	public void DestroyBombTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate) { }

	// RVA: 0x2DDC630 Offset: 0x2DDC731 VA: 0x2DDC630
	public void DestroySpecialTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate) { }

	// RVA: 0x2DDC3B0 Offset: 0x2DDC4B1 VA: 0x2DDC3B0
	private void ExecuteSelectTypeTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate, DragonRideTarget.TargetType select) { }

	// RVA: 0x2DC9AA0 Offset: 0x2DC9BA1 VA: 0x2DC9AA0
	public bool CheckEnableBombTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate) { }

	// RVA: 0x2DC9AB0 Offset: 0x2DC9BB1 VA: 0x2DC9AB0
	public bool CheckEnableSpecialTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate) { }

	// RVA: 0x2DDC640 Offset: 0x2DDC741 VA: 0x2DDC640
	private bool CheckEnableSelectTypeTarget(Vector3 cameraPos, Vector3 cameraForward, float enableRate, DragonRideTarget.TargetType select) { }

	// RVA: 0x2DC9AC0 Offset: 0x2DC9BC1 VA: 0x2DC9AC0
	public void SetEnableSelectTypeTargetList(Vector3 cameraPos, Vector3 cameraForward, float enableRate, DragonRideTarget.TargetType select, ref List<Vector3> refList) { }

	// RVA: 0x2DDC860 Offset: 0x2DDC961 VA: 0x2DDC860
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF2C0 Offset: 0x2BF3C1 VA: 0x2BF2C0
	// RVA: 0x2DDC120 Offset: 0x2DDC221 VA: 0x2DDC120
	private void <UpdateChain>g__TryAddChainCheckList|42_0(ref DragonRideTarget targetRef) { }
}

