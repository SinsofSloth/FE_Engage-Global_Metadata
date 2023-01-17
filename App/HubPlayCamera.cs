// Namespace: App
internal class HubPlayCamera : ProcInst // TypeDefIndex: 10749
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294F40 Offset: 0x295041 VA: 0x294F40
	private readonly HubDemoData <Data>k__BackingField; // 0x70
	private GameObject CameraObject; // 0x78
	private GameObject MainCamera; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x294F50 Offset: 0x295051 VA: 0x294F50
	private ResourceHandle <CameraHandle>k__BackingField; // 0x88
	private const string AssetPath = "Hub/Cameras/";
	private const string DisableLodCrossFadeTag = "DisableLodCrossFadeInDemo";
	private List<float> m_distance; // 0x90

	// Properties
	private HubDemoData Data { get; }
	private ResourceHandle CameraHandle { get; set; }
	private HubPlayerController Player { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0BF0 Offset: 0x2C0CF1 VA: 0x2C0BF0
	// RVA: 0x28AE6A0 Offset: 0x28AE7A1 VA: 0x28AE6A0
	private HubDemoData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0C00 Offset: 0x2C0D01 VA: 0x2C0C00
	// RVA: 0x28AE6B0 Offset: 0x28AE7B1 VA: 0x28AE6B0
	private ResourceHandle get_CameraHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0C10 Offset: 0x2C0D11 VA: 0x2C0C10
	// RVA: 0x28AE6C0 Offset: 0x28AE7C1 VA: 0x28AE6C0
	private void set_CameraHandle(ResourceHandle value) { }

	// RVA: 0x28AE6D0 Offset: 0x28AE7D1 VA: 0x28AE6D0
	private HubPlayerController get_Player() { }

	// RVA: 0x28AE7F0 Offset: 0x28AE8F1 VA: 0x28AE7F0
	private void .ctor(HubDemoData data) { }

	// RVA: 0x28AE8D0 Offset: 0x28AE9D1 VA: 0x28AE8D0
	private void Init() { }

	// RVA: 0x28AF0A0 Offset: 0x28AF1A1 VA: 0x28AF0A0
	private bool IsLoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C0C20 Offset: 0x2C0D21 VA: 0x2C0C20
	// RVA: 0x28AF0D0 Offset: 0x28AF1D1 VA: 0x28AF0D0
	private IEnumerator Main() { }

	// RVA: 0x28AF150 Offset: 0x28AF251 VA: 0x28AF150
	private void Exit() { }

	// RVA: 0x28AF8D0 Offset: 0x28AF9D1 VA: 0x28AF8D0
	private void OpenMessage() { }

	// RVA: 0x28AF8E0 Offset: 0x28AF9E1 VA: 0x28AF8E0
	private void OpenTutorial() { }

	// RVA: 0x28AF970 Offset: 0x28AFA71 VA: 0x28AF970
	private void End() { }

	// RVA: 0x28AFA30 Offset: 0x28AFB31 VA: 0x28AFA30
	public static void CreateBind(ProcInst super, HubDemoData data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0C90 Offset: 0x2C0D91 VA: 0x2C0C90
	// RVA: 0x28B0280 Offset: 0x28B0381 VA: 0x28B0280
	private void <Init>b__17_0(GameObject prefab) { }
}

