// Namespace: UnityEngine.UI
public class GraphicRegistry // TypeDefIndex: 4271
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x1A55790 Offset: 0x1A55891 VA: 0x1A55790
	protected void .ctor() { }

	// RVA: 0x1A55960 Offset: 0x1A55A61 VA: 0x1A55960
	public static GraphicRegistry get_instance() { }

	// RVA: 0x1A50EE0 Offset: 0x1A50FE1 VA: 0x1A50EE0
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1A500C0 Offset: 0x1A501C1 VA: 0x1A500C0
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1A50A60 Offset: 0x1A50B61 VA: 0x1A50A60
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1A4FF30 Offset: 0x1A50031 VA: 0x1A4FF30
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1A55A40 Offset: 0x1A55B41 VA: 0x1A55A40
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1A54F70 Offset: 0x1A55071 VA: 0x1A54F70
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1A55B10 Offset: 0x1A55C11 VA: 0x1A55B10
	private static void .cctor() { }
}

