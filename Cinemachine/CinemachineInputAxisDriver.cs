// Namespace: Cinemachine
[Serializable]
public struct CinemachineInputAxisDriver // TypeDefIndex: 5832
{
	// Fields
	[TooltipAttribute] // RVA: 0x218A0 Offset: 0x219A1 VA: 0x218A0
	public float multiplier; // 0x0
	[TooltipAttribute] // RVA: 0x218E0 Offset: 0x219E1 VA: 0x218E0
	public float accelTime; // 0x4
	[TooltipAttribute] // RVA: 0x21920 Offset: 0x21A21 VA: 0x21920
	public float decelTime; // 0x8
	[TooltipAttribute] // RVA: 0x21960 Offset: 0x21A61 VA: 0x21960
	public string name; // 0x10
	[TooltipAttribute] // RVA: 0x219A0 Offset: 0x21AA1 VA: 0x219A0
	[NoSaveDuringPlayAttribute] // RVA: 0x219A0 Offset: 0x21AA1 VA: 0x219A0
	public float inputValue; // 0x18
	private float mCurrentSpeed; // 0x1C
	private const float Epsilon = 0.0001;

	// Methods

	// RVA: 0x1BA0F10 Offset: 0x1BA1011 VA: 0x1BA0F10
	public void Validate() { }

	// RVA: 0x1BA0F60 Offset: 0x1BA1061 VA: 0x1BA0F60
	public bool Update(float deltaTime, ref AxisBase axis) { }

	// RVA: 0x1BA1280 Offset: 0x1BA1381 VA: 0x1BA1280
	private float ClampValue(ref AxisBase axis, float v) { }

	// RVA: 0x1BA12F0 Offset: 0x1BA13F1 VA: 0x1BA12F0
	public bool Update(float deltaTime, ref AxisState axis) { }
}

