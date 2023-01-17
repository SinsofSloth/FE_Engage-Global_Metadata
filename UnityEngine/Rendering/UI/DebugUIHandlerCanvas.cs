// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 4701
{
	// Fields
	private int m_DebugTreeState; // 0x18
	private Dictionary<Type, Transform> m_PrefabsMap; // 0x20
	public Transform panelPrefab; // 0x28
	public List<DebugUIPrefabBundle> prefabs; // 0x30
	private List<DebugUIHandlerPanel> m_UIPanels; // 0x38
	private int m_SelectedPanel; // 0x40
	private DebugUIHandlerWidget m_SelectedWidget; // 0x48
	private string m_CurrentQueryPath; // 0x50

	// Methods

	// RVA: 0x1B38970 Offset: 0x1B38A71 VA: 0x1B38970
	private void OnEnable() { }

	// RVA: 0x1B38BB0 Offset: 0x1B38CB1 VA: 0x1B38BB0
	private void Update() { }

	// RVA: 0x1B34C20 Offset: 0x1B34D21 VA: 0x1B34C20
	internal void ResetAllHierarchy() { }

	// RVA: 0x1B39380 Offset: 0x1B39481 VA: 0x1B39380
	private void Rebuild() { }

	// RVA: 0x1B39BC0 Offset: 0x1B39CC1 VA: 0x1B39BC0
	private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler) { }

	// RVA: 0x1B3A3A0 Offset: 0x1B3A4A1 VA: 0x1B3A3A0
	private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) { }

	// RVA: 0x1B3A070 Offset: 0x1B3A171 VA: 0x1B3A070
	private void ActivatePanel(int index, bool tryAndKeepSelection = False) { }

	// RVA: 0x1B352C0 Offset: 0x1B353C1 VA: 0x1B352C0
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x1B3A600 Offset: 0x1B3A701 VA: 0x1B3A600
	private void SelectPreviousItem() { }

	// RVA: 0x1B3A520 Offset: 0x1B3A621 VA: 0x1B3A520
	private void SelectNextItem() { }

	// RVA: 0x1B3A6E0 Offset: 0x1B3A7E1 VA: 0x1B3A6E0
	private void ChangeSelectionValue(float multiplier) { }

	// RVA: 0x1B3A860 Offset: 0x1B3A961 VA: 0x1B3A860
	private void ActivateSelection() { }

	// RVA: 0x1B38D70 Offset: 0x1B38E71 VA: 0x1B38D70
	private void HandleInput() { }

	// RVA: 0x1B3A900 Offset: 0x1B3AA01 VA: 0x1B3A900
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DD50 Offset: 0x3DE51 VA: 0x3DD50
	// RVA: 0x1B3A910 Offset: 0x1B3AA11 VA: 0x1B3A910
	private bool <ActivatePanel>b__14_1(DebugUIHandlerWidget w) { }
}

