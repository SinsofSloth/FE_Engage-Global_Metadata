// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry // TypeDefIndex: 4247
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x1A40CC0 Offset: 0x1A40DC1 VA: 0x1A40CC0
	protected void .ctor() { }

	// RVA: 0x1A40FE0 Offset: 0x1A410E1 VA: 0x1A40FE0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x1A410C0 Offset: 0x1A411C1 VA: 0x1A410C0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x1A411C0 Offset: 0x1A412C1 VA: 0x1A411C0
	private void CleanInvalidItems() { }

	// RVA: 0x1A414A0 Offset: 0x1A415A1 VA: 0x1A414A0
	private void PerformUpdate() { }

	// RVA: 0x1A41F80 Offset: 0x1A42081 VA: 0x1A41F80
	private static int ParentCount(Transform child) { }

	// RVA: 0x1A42050 Offset: 0x1A42151 VA: 0x1A42050
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x1A421B0 Offset: 0x1A422B1 VA: 0x1A421B0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1A42330 Offset: 0x1A42431 VA: 0x1A42330
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1A42290 Offset: 0x1A42391 VA: 0x1A42290
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1A42410 Offset: 0x1A42511 VA: 0x1A42410
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1A42560 Offset: 0x1A42661 VA: 0x1A42560
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1A42480 Offset: 0x1A42581 VA: 0x1A42480
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1A425D0 Offset: 0x1A426D1 VA: 0x1A425D0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1A42650 Offset: 0x1A42751 VA: 0x1A42650
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1A427C0 Offset: 0x1A428C1 VA: 0x1A427C0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1A42930 Offset: 0x1A42A31 VA: 0x1A42930
	public static bool IsRebuildingLayout() { }

	// RVA: 0x1A42990 Offset: 0x1A42A91 VA: 0x1A42990
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x1A429F0 Offset: 0x1A42AF1 VA: 0x1A429F0
	private static void .cctor() { }
}

