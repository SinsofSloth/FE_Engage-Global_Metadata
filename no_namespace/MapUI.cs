// Namespace: 
public class MapUI : SingletonMonoBehaviour<MapUI> // TypeDefIndex: 7644
{
	// Fields
	[SpaceAttribute] // RVA: 0x27BB10 Offset: 0x27BC11 VA: 0x27BB10
	[HeaderAttribute] // RVA: 0x27BB10 Offset: 0x27BC11 VA: 0x27BB10
	[SerializeField] // RVA: 0x27BB10 Offset: 0x27BC11 VA: 0x27BB10
	private AnimationCurve m_UpDownCurve; // 0x20
	[SerializeField] // RVA: 0x27BB70 Offset: 0x27BC71 VA: 0x27BB70
	private AnimationCurve m_ScaleCurve; // 0x28
	[HeaderAttribute] // RVA: 0x27BB80 Offset: 0x27BC81 VA: 0x27BB80
	[SerializeField] // RVA: 0x27BB80 Offset: 0x27BC81 VA: 0x27BB80
	[SpaceAttribute] // RVA: 0x27BB80 Offset: 0x27BC81 VA: 0x27BB80
	private float m_CannonIconOffset; // 0x30
	private float m_Time; // 0x34

	// Properties
	public float Time { get; }
	public float CannonIconOffset { get; }
	public AnimationCurve UpDownCurve { get; }
	public AnimationCurve ScaleCurve { get; }

	// Methods

	// RVA: 0x27555B0 Offset: 0x27556B1 VA: 0x27555B0
	private void Start() { }

	// RVA: 0x27555C0 Offset: 0x27556C1 VA: 0x27555C0
	private void Update() { }

	// RVA: 0x2755640 Offset: 0x2755741 VA: 0x2755640
	public static Camera GetCamera() { }

	// RVA: 0x2755730 Offset: 0x2755831 VA: 0x2755730
	public float get_Time() { }

	// RVA: 0x2755740 Offset: 0x2755841 VA: 0x2755740
	public float get_CannonIconOffset() { }

	// RVA: 0x2755750 Offset: 0x2755851 VA: 0x2755750
	public AnimationCurve get_UpDownCurve() { }

	// RVA: 0x2755760 Offset: 0x2755861 VA: 0x2755760
	public AnimationCurve get_ScaleCurve() { }

	// RVA: 0x2755770 Offset: 0x2755871 VA: 0x2755770
	public void .ctor() { }
}

