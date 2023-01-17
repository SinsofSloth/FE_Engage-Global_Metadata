// Namespace: 
private class HubPlayCamera.DemoTelop : ProcInst // TypeDefIndex: 10747
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294F60 Offset: 0x295061 VA: 0x294F60
	private readonly HubDemoData <Data>k__BackingField; // 0x70
	private GameObject Root; // 0x78
	private GameObject UIObject; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x294F70 Offset: 0x295071 VA: 0x294F70
	private ResourceHandle <UIHandle>k__BackingField; // 0x88
	private const string UIAssetPath = "UI/Common/WdwEventMessage/Prefabs/WdwEventMessage";
	private Animator m_animator; // 0x90

	// Properties
	public HubDemoData Data { get; }
	private ResourceHandle UIHandle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0CA0 Offset: 0x2C0DA1 VA: 0x2C0CA0
	// RVA: 0x1FB49B0 Offset: 0x1FB4AB1 VA: 0x1FB49B0
	public HubDemoData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0CB0 Offset: 0x2C0DB1 VA: 0x2C0CB0
	// RVA: 0x1FB49C0 Offset: 0x1FB4AC1 VA: 0x1FB49C0
	private ResourceHandle get_UIHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0CC0 Offset: 0x2C0DC1 VA: 0x2C0CC0
	// RVA: 0x1FB49D0 Offset: 0x1FB4AD1 VA: 0x1FB49D0
	private void set_UIHandle(ResourceHandle value) { }

	// RVA: 0x1FB49E0 Offset: 0x1FB4AE1 VA: 0x1FB49E0
	private void .ctor(HubDemoData data) { }

	// RVA: 0x1FB4A70 Offset: 0x1FB4B71 VA: 0x1FB4A70
	private bool IsLoading() { }

	// RVA: 0x1FB4AA0 Offset: 0x1FB4BA1 VA: 0x1FB4AA0
	private bool IsClosing() { }

	// RVA: 0x1FB4B00 Offset: 0x1FB4C01 VA: 0x1FB4B00
	private void Build() { }

	// RVA: 0x1FB4BE0 Offset: 0x1FB4CE1 VA: 0x1FB4BE0
	private void Open() { }

	// RVA: 0x1FB4CA0 Offset: 0x1FB4DA1 VA: 0x1FB4CA0
	private void Tick() { }

	// RVA: 0x1FB4EE0 Offset: 0x1FB4FE1 VA: 0x1FB4EE0
	private void Close() { }

	// RVA: 0x1FB4F90 Offset: 0x1FB5091 VA: 0x1FB4F90
	private void Exit() { }

	// RVA: 0x1FB5020 Offset: 0x1FB5121 VA: 0x1FB5020
	private ProcDesc[] CreateDefaultDesc() { }

	// RVA: 0x1FB5460 Offset: 0x1FB5561 VA: 0x1FB5460
	public static void CreateBind(ProcInst super, HubDemoData data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0CD0 Offset: 0x2C0DD1 VA: 0x2C0CD0
	// RVA: 0x1FB5550 Offset: 0x1FB5651 VA: 0x1FB5550
	private void <Build>b__14_0(GameObject prefab) { }
}

