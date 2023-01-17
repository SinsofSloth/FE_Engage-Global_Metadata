// Namespace: UnityEngine.Rendering
public abstract class VolumeParameter // TypeDefIndex: 4649
{
	// Fields
	public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
	[SerializeField] // RVA: 0x3CF40 Offset: 0x3D041 VA: 0x3CF40
	protected bool m_OverrideState; // 0x10

	// Properties
	public virtual bool overrideState { get; set; }

	// Methods

	// RVA: 0x354DDA0 Offset: 0x354DEA1 VA: 0x354DDA0 Slot: 4
	public virtual bool get_overrideState() { }

	// RVA: 0x354DDB0 Offset: 0x354DEB1 VA: 0x354DDB0 Slot: 5
	public virtual void set_overrideState(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

	// RVA: -1 Offset: -1
	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386E090 Offset: 0x386E191 VA: 0x386E090
	|-VolumeParameter.GetValue<bool>
	|
	|-RVA: 0x386E0F0 Offset: 0x386E1F1 VA: 0x386E0F0
	|-VolumeParameter.GetValue<Color>
	|
	|-RVA: 0x386E150 Offset: 0x386E251 VA: 0x386E150
	|-VolumeParameter.GetValue<int>
	|
	|-RVA: 0x386E1B0 Offset: 0x386E2B1 VA: 0x386E1B0
	|-VolumeParameter.GetValue<Int32Enum>
	|
	|-RVA: 0x386E210 Offset: 0x386E311 VA: 0x386E210
	|-VolumeParameter.GetValue<LayerMask>
	|
	|-RVA: 0x386E280 Offset: 0x386E381 VA: 0x386E280
	|-VolumeParameter.GetValue<object>
	|
	|-RVA: 0x386E2E0 Offset: 0x386E3E1 VA: 0x386E2E0
	|-VolumeParameter.GetValue<float>
	|
	|-RVA: 0x386E340 Offset: 0x386E441 VA: 0x386E340
	|-VolumeParameter.GetValue<Vector2>
	|
	|-RVA: 0x386E3A0 Offset: 0x386E4A1 VA: 0x386E3A0
	|-VolumeParameter.GetValue<Vector3>
	|
	|-RVA: 0x386E400 Offset: 0x386E501 VA: 0x386E400
	|-VolumeParameter.GetValue<Vector4>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetValue(VolumeParameter parameter);

	// RVA: 0x354DDC0 Offset: 0x354DEC1 VA: 0x354DDC0 Slot: 8
	protected internal virtual void OnEnable() { }

	// RVA: 0x354DDD0 Offset: 0x354DED1 VA: 0x354DDD0 Slot: 9
	protected internal virtual void OnDisable() { }

	// RVA: 0x354B830 Offset: 0x354B931 VA: 0x354B830
	public static bool IsObjectParameter(Type type) { }

	// RVA: 0x354DDE0 Offset: 0x354DEE1 VA: 0x354DDE0 Slot: 10
	public virtual void Release() { }

	// RVA: 0x354DDF0 Offset: 0x354DEF1 VA: 0x354DDF0
	protected void .ctor() { }
}

