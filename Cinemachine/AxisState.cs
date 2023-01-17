// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B7D0 Offset: 0x1B8D1 VA: 0x1B7D0
[Serializable]
public struct AxisState // TypeDefIndex: 5811
{
	// Fields
	[TooltipAttribute] // RVA: 0x20F40 Offset: 0x21041 VA: 0x20F40
	[NoSaveDuringPlayAttribute] // RVA: 0x20F40 Offset: 0x21041 VA: 0x20F40
	public float Value; // 0x0
	[TooltipAttribute] // RVA: 0x20F90 Offset: 0x21091 VA: 0x20F90
	public AxisState.SpeedMode m_SpeedMode; // 0x4
	[TooltipAttribute] // RVA: 0x20FD0 Offset: 0x210D1 VA: 0x20FD0
	public float m_MaxSpeed; // 0x8
	[TooltipAttribute] // RVA: 0x21010 Offset: 0x21111 VA: 0x21010
	public float m_AccelTime; // 0xC
	[TooltipAttribute] // RVA: 0x21050 Offset: 0x21151 VA: 0x21050
	public float m_DecelTime; // 0x10
	[TooltipAttribute] // RVA: 0x21090 Offset: 0x21191 VA: 0x21090
	[FormerlySerializedAsAttribute] // RVA: 0x21090 Offset: 0x21191 VA: 0x21090
	public string m_InputAxisName; // 0x18
	[NoSaveDuringPlayAttribute] // RVA: 0x210F0 Offset: 0x211F1 VA: 0x210F0
	[TooltipAttribute] // RVA: 0x210F0 Offset: 0x211F1 VA: 0x210F0
	public float m_InputAxisValue; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x21140 Offset: 0x21241 VA: 0x21140
	[TooltipAttribute] // RVA: 0x21140 Offset: 0x21241 VA: 0x21140
	public bool m_InvertInput; // 0x24
	[TooltipAttribute] // RVA: 0x211A0 Offset: 0x212A1 VA: 0x211A0
	public float m_MinValue; // 0x28
	[TooltipAttribute] // RVA: 0x211E0 Offset: 0x212E1 VA: 0x211E0
	public float m_MaxValue; // 0x2C
	[TooltipAttribute] // RVA: 0x21220 Offset: 0x21321 VA: 0x21220
	public bool m_Wrap; // 0x30
	[TooltipAttribute] // RVA: 0x21260 Offset: 0x21361 VA: 0x21260
	public AxisState.Recentering m_Recentering; // 0x34
	private float mCurrentSpeed; // 0x50
	private const float Epsilon = 0.0001;
	private AxisState.IInputAxisProvider m_InputAxisProvider; // 0x58
	private int m_InputAxisIndex; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x212A0 Offset: 0x213A1 VA: 0x212A0
	private bool <ValueRangeLocked>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x212B0 Offset: 0x213B1 VA: 0x212B0
	private bool <HasRecentering>k__BackingField; // 0x65

	// Properties
	public bool HasInputProvider { get; }
	public bool ValueRangeLocked { get; set; }
	public bool HasRecentering { get; set; }

	// Methods

	// RVA: 0x1B80F30 Offset: 0x1B81031 VA: 0x1B80F30
	public void .ctor(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) { }

	// RVA: 0x1B81040 Offset: 0x1B81141 VA: 0x1B81040
	public void Validate() { }

	// RVA: 0x1B810C0 Offset: 0x1B811C1 VA: 0x1B810C0
	public void Reset() { }

	// RVA: 0x1B810D0 Offset: 0x1B811D1 VA: 0x1B810D0
	public void SetInputAxisProvider(int axis, AxisState.IInputAxisProvider provider) { }

	// RVA: 0x1B810E0 Offset: 0x1B811E1 VA: 0x1B810E0
	public bool get_HasInputProvider() { }

	// RVA: 0x1B810F0 Offset: 0x1B811F1 VA: 0x1B810F0
	public bool Update(float deltaTime) { }

	// RVA: 0x1B81790 Offset: 0x1B81891 VA: 0x1B81790
	private float ClampValue(float v) { }

	// RVA: 0x1B81510 Offset: 0x1B81611 VA: 0x1B81510
	private bool MaxSpeedUpdate(float input, float deltaTime) { }

	// RVA: 0x1B81800 Offset: 0x1B81901 VA: 0x1B81800
	private float GetMaxSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x23830 Offset: 0x23931 VA: 0x23830
	[IsReadOnlyAttribute] // RVA: 0x23830 Offset: 0x23931 VA: 0x23830
	// RVA: 0x1B81890 Offset: 0x1B81991 VA: 0x1B81890
	public bool get_ValueRangeLocked() { }

	[CompilerGeneratedAttribute] // RVA: 0x23870 Offset: 0x23971 VA: 0x23870
	// RVA: 0x1B818A0 Offset: 0x1B819A1 VA: 0x1B818A0
	public void set_ValueRangeLocked(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23880 Offset: 0x23981 VA: 0x23880
	[IsReadOnlyAttribute] // RVA: 0x23880 Offset: 0x23981 VA: 0x23880
	// RVA: 0x1B818B0 Offset: 0x1B819B1 VA: 0x1B818B0
	public bool get_HasRecentering() { }

	[CompilerGeneratedAttribute] // RVA: 0x238C0 Offset: 0x239C1 VA: 0x238C0
	// RVA: 0x1B818C0 Offset: 0x1B819C1 VA: 0x1B818C0
	public void set_HasRecentering(bool value) { }
}

