// Namespace: UnityEngine.Rendering
public sealed class DebugManager // TypeDefIndex: 4550
{
	// Fields
	private const string kEnableDebugBtn1 = "Enable Debug Button 1";
	private const string kEnableDebugBtn2 = "Enable Debug Button 2";
	private const string kDebugPreviousBtn = "Debug Previous";
	private const string kDebugNextBtn = "Debug Next";
	private const string kValidateBtn = "Debug Validate";
	private const string kPersistentBtn = "Debug Persistent";
	private const string kDPadVertical = "Debug Vertical";
	private const string kDPadHorizontal = "Debug Horizontal";
	private const string kMultiplierBtn = "Debug Multiplier";
	private const string kResetBtn = "Debug Reset";
	private const string kEnableDebug = "Enable Debug";
	private DebugActionDesc[] m_DebugActions; // 0x10
	private DebugActionState[] m_DebugActionStates; // 0x18
	private static readonly Lazy<DebugManager> s_Instance; // 0x0
	private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels; // 0x20
	private readonly List<DebugUI.Panel> m_Panels; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x3CA80 Offset: 0x3CB81 VA: 0x3CA80
	private Action<bool> onDisplayRuntimeUIChanged; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x3CA90 Offset: 0x3CB91 VA: 0x3CA90
	private Action onSetDirty; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x3CAA0 Offset: 0x3CBA1 VA: 0x3CAA0
	private Action resetData; // 0x40
	public bool refreshEditorRequested; // 0x48
	private GameObject m_Root; // 0x50
	private DebugUIHandlerCanvas m_RootUICanvas; // 0x58
	private GameObject m_PersistentRoot; // 0x60
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; // 0x68
	private bool m_EditorOpen; // 0x70

	// Properties
	public static DebugManager instance { get; }
	public ReadOnlyCollection<DebugUI.Panel> panels { get; }
	public bool displayEditorUI { get; }
	public bool displayRuntimeUI { get; set; }
	public bool displayPersistentRuntimeUI { get; set; }

	// Methods

	// RVA: 0x1B33040 Offset: 0x1B33141 VA: 0x1B33040
	private void RegisterActions() { }

	// RVA: 0x1B33780 Offset: 0x1B33881 VA: 0x1B33780
	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	// RVA: 0x1B338C0 Offset: 0x1B339C1 VA: 0x1B338C0
	private void SampleAction(int actionIndex) { }

	// RVA: 0x1B33BE0 Offset: 0x1B33CE1 VA: 0x1B33BE0
	private void UpdateAction(int actionIndex) { }

	// RVA: 0x1B33C40 Offset: 0x1B33D41 VA: 0x1B33C40
	internal void UpdateActions() { }

	// RVA: 0x1B33CE0 Offset: 0x1B33DE1 VA: 0x1B33CE0
	internal float GetAction(DebugAction action) { }

	// RVA: 0x1B33D20 Offset: 0x1B33E21 VA: 0x1B33D20
	private void RegisterInputs() { }

	// RVA: 0x1B2B280 Offset: 0x1B2B381 VA: 0x1B2B280
	public static DebugManager get_instance() { }

	// RVA: 0x1B33D30 Offset: 0x1B33E31 VA: 0x1B33D30
	private void UpdateReadOnlyCollection() { }

	// RVA: 0x1B33DC0 Offset: 0x1B33EC1 VA: 0x1B33DC0
	public ReadOnlyCollection<DebugUI.Panel> get_panels() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D6F0 Offset: 0x3D7F1 VA: 0x3D6F0
	// RVA: 0x1B33E60 Offset: 0x1B33F61 VA: 0x1B33E60
	public void add_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D700 Offset: 0x3D801 VA: 0x3D700
	// RVA: 0x1B33F10 Offset: 0x1B34011 VA: 0x1B33F10
	public void remove_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D710 Offset: 0x3D811 VA: 0x3D710
	// RVA: 0x1B33FC0 Offset: 0x1B340C1 VA: 0x1B33FC0
	public void add_onSetDirty(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D720 Offset: 0x3D821 VA: 0x3D720
	// RVA: 0x1B34070 Offset: 0x1B34171 VA: 0x1B34070
	public void remove_onSetDirty(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D730 Offset: 0x3D831 VA: 0x3D730
	// RVA: 0x1B34120 Offset: 0x1B34221 VA: 0x1B34120
	private void add_resetData(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D740 Offset: 0x3D841 VA: 0x3D740
	// RVA: 0x1B341D0 Offset: 0x1B342D1 VA: 0x1B341D0
	private void remove_resetData(Action value) { }

	// RVA: 0x1B34280 Offset: 0x1B34381 VA: 0x1B34280
	public bool get_displayEditorUI() { }

	// RVA: 0x1B34290 Offset: 0x1B34391 VA: 0x1B34290
	public void ToggleEditorUI(bool open) { }

	// RVA: 0x1B342A0 Offset: 0x1B343A1 VA: 0x1B342A0
	public bool get_displayRuntimeUI() { }

	// RVA: 0x1B34340 Offset: 0x1B34441 VA: 0x1B34340
	public void set_displayRuntimeUI(bool value) { }

	// RVA: 0x1B34530 Offset: 0x1B34631 VA: 0x1B34530
	public bool get_displayPersistentRuntimeUI() { }

	// RVA: 0x1B345D0 Offset: 0x1B346D1 VA: 0x1B345D0
	public void set_displayPersistentRuntimeUI(bool value) { }

	// RVA: 0x1B34810 Offset: 0x1B34911 VA: 0x1B34810
	private void .ctor() { }

	// RVA: 0x1B34AA0 Offset: 0x1B34BA1 VA: 0x1B34AA0
	public void RefreshEditor() { }

	// RVA: 0x1B34AB0 Offset: 0x1B34BB1 VA: 0x1B34AB0
	public void Reset() { }

	// RVA: 0x1B34B70 Offset: 0x1B34C71 VA: 0x1B34B70
	public void ReDrawOnScreenDebug() { }

	// RVA: 0x1B34EE0 Offset: 0x1B34FE1 VA: 0x1B34EE0
	public void RegisterData(IDebugData data) { }

	// RVA: 0x1B35010 Offset: 0x1B35111 VA: 0x1B35010
	public void UnregisterData(IDebugData data) { }

	// RVA: 0x1B35140 Offset: 0x1B35241 VA: 0x1B35140
	public int GetState() { }

	// RVA: 0x1B35260 Offset: 0x1B35361 VA: 0x1B35260
	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	// RVA: 0x1B352B0 Offset: 0x1B353B1 VA: 0x1B352B0
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x1B34600 Offset: 0x1B34701 VA: 0x1B34600
	private void CheckPersistentCanvas() { }

	// RVA: 0x1B35470 Offset: 0x1B35571 VA: 0x1B35470
	internal void TogglePersistent(DebugUI.Widget widget) { }

	// RVA: 0x1B35570 Offset: 0x1B35671 VA: 0x1B35570
	private void OnPanelDirty(DebugUI.Panel panel) { }

	// RVA: 0x1B2B300 Offset: 0x1B2B401 VA: 0x1B2B300
	public DebugUI.Panel GetPanel(string displayName, bool createIfNull = False, int groupIndex = 0, bool overrideIfExist = False) { }

	// RVA: 0x1B35660 Offset: 0x1B35761 VA: 0x1B35660
	public void RemovePanel(string displayName) { }

	// RVA: 0x1B35580 Offset: 0x1B35681 VA: 0x1B35580
	public void RemovePanel(DebugUI.Panel panel) { }

	// RVA: 0x1B35830 Offset: 0x1B35931 VA: 0x1B35830
	public DebugUI.Widget GetItem(string queryPath) { }

	// RVA: 0x1B35990 Offset: 0x1B35A91 VA: 0x1B35990
	private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container) { }

	// RVA: 0x1B35CC0 Offset: 0x1B35DC1 VA: 0x1B35CC0
	private static void .cctor() { }
}

