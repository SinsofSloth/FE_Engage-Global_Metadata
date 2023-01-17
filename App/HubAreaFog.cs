// Namespace: App
public abstract class HubAreaFog : MonoBehaviour // TypeDefIndex: 10662
{
	// Fields
	public Color m_color; // 0x18
	[RangeAttribute] // RVA: 0x2941C0 Offset: 0x2942C1 VA: 0x2941C0
	public float m_start; // 0x28
	[RangeAttribute] // RVA: 0x2941E0 Offset: 0x2942E1 VA: 0x2941E0
	public float m_end; // 0x2C
	public float m_time; // 0x30
	public int m_priority; // 0x34
	private InterpolatorFloat m_Ratio; // 0x38
	private static bool m_initialize; // 0x0
	private static bool m_update; // 0x1
	private static Color m_origColor; // 0x4
	private static float m_origStart; // 0x14
	private static float m_origEnd; // 0x18
	private static List<HubAreaFog> m_fogList; // 0x20

	// Methods

	// RVA: 0x3049E30 Offset: 0x3049F31 VA: 0x3049E30
	public static void Initialize() { }

	// RVA: 0x3049F30 Offset: 0x304A031 VA: 0x3049F30
	public static void UpdateAll() { }

	// RVA: 0x304A300 Offset: 0x304A401 VA: 0x304A300
	private void OnDestroy() { }

	// RVA: 0x304A3B0 Offset: 0x304A4B1 VA: 0x304A3B0
	private void Awake() { }

	// RVA: 0x304A440 Offset: 0x304A541 VA: 0x304A440
	private void Start() { }

	// RVA: 0x304A460 Offset: 0x304A561 VA: 0x304A460
	private void Update() { }

	// RVA: 0x304A640 Offset: 0x304A741 VA: 0x304A640
	private void LateUpdate() { }

	// RVA: 0x304A2F0 Offset: 0x304A3F1 VA: 0x304A2F0
	private float GetRatio() { }

	// RVA: 0x304A6B0 Offset: 0x304A7B1 VA: 0x304A6B0
	public void Active() { }

	// RVA: 0x304A6D0 Offset: 0x304A7D1 VA: 0x304A6D0
	public void Inactive() { }

	// RVA: 0x304A6F0 Offset: 0x304A7F1 VA: 0x304A6F0
	protected void .ctor() { }

	// RVA: 0x304A790 Offset: 0x304A891 VA: 0x304A790
	private static void .cctor() { }
}

