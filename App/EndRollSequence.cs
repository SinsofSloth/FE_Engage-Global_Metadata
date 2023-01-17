// Namespace: App
internal class EndRollSequence : SingletonProcInst<EndRollSequence> // TypeDefIndex: 12982
{
	// Fields
	private const string PrefabPath = "UI/Ending/Prefabs/CreditRoot";
	private string m_BgmHeader; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x29B8F0 Offset: 0x29B9F1 VA: 0x29B8F0
	private bool <IsSkipped>k__BackingField; // 0x80
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x88
	private GameObject m_Canvas; // 0x90
	private EndRollSetter m_Setter; // 0x98

	// Properties
	private bool IsSkipped { get; set; }

	// Methods

	// RVA: 0x25FDEF0 Offset: 0x25FDFF1 VA: 0x25FDEF0
	public static void CreateBind(ProcInst super, string bgmHeader) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA5D0 Offset: 0x2CA6D1 VA: 0x2CA5D0
	// RVA: 0x25FE790 Offset: 0x25FE891 VA: 0x25FE790
	private bool get_IsSkipped() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA5E0 Offset: 0x2CA6E1 VA: 0x2CA5E0
	// RVA: 0x25FE7A0 Offset: 0x25FE8A1 VA: 0x25FE7A0
	private void set_IsSkipped(bool value) { }

	// RVA: 0x25FE7B0 Offset: 0x25FE8B1 VA: 0x25FE7B0
	private void LoadScene() { }

	// RVA: 0x25FE8C0 Offset: 0x25FE9C1 VA: 0x25FE8C0
	private bool IsLoading() { }

	// RVA: 0x25FE8F0 Offset: 0x25FE9F1 VA: 0x25FE8F0
	private void Setup1() { }

	// RVA: 0x25FEAF0 Offset: 0x25FEBF1 VA: 0x25FEAF0
	private void Setup2() { }

	// RVA: 0x25FEE30 Offset: 0x25FEF31 VA: 0x25FEE30
	private void Unload() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA5F0 Offset: 0x2CA6F1 VA: 0x2CA5F0
	// RVA: 0x25FF040 Offset: 0x25FF141 VA: 0x25FF040
	private IEnumerator Tick1() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CA660 Offset: 0x2CA761 VA: 0x2CA660
	// RVA: 0x25FF0C0 Offset: 0x25FF1C1 VA: 0x25FF0C0
	private IEnumerator Tick2() { }

	// RVA: 0x25FF140 Offset: 0x25FF241 VA: 0x25FF140
	private void EnableControllerSupport() { }

	// RVA: 0x25FF1A0 Offset: 0x25FF2A1 VA: 0x25FF1A0
	private void DisableControllerSupport() { }

	// RVA: 0x25FE710 Offset: 0x25FE811 VA: 0x25FE710
	public void .ctor() { }
}

