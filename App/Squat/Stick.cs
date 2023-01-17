// Namespace: App.Squat
public class Stick // TypeDefIndex: 14191
{
	// Fields
	private const float cStickEnablePower = 0.7;
	private const float cStickNeutralPower = 0.25;
	private const float cStickRotatePower = 0.25;
	private const float cRotateCountMaxSec = 1;
	private const float cRotationOKDir = 270;
	[CompilerGeneratedAttribute] // RVA: 0x29DC30 Offset: 0x29DD31 VA: 0x29DC30
	private bool <IsRight>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29DC40 Offset: 0x29DD41 VA: 0x29DC40
	private bool <IsNeutral>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x29DC50 Offset: 0x29DD51 VA: 0x29DC50
	private bool <IsEclypse>k__BackingField; // 0x12
	private float m_StickX; // 0x14
	private float m_StickY; // 0x18
	private float m_Power; // 0x1C
	private float m_DirNow; // 0x20
	private float m_DirPast; // 0x24
	private float m_TotalRotateDir; // 0x28
	private int m_RotCount; // 0x2C
	private int m_KeepRotCount; // 0x30
	private Stick.RotateDir m_Rot; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x29DC60 Offset: 0x29DD61 VA: 0x29DC60
	private bool <IsWatchClockwise>k__BackingField; // 0x38
	private List<int> m_DirLogger; // 0x40
	private float m_LoggerTimer; // 0x48

	// Properties
	public bool IsRight { get; set; }
	public bool IsNeutral { get; set; }
	private bool IsEclypse { get; set; }
	public bool IsWatchClockwise { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE0B0 Offset: 0x2CE1B1 VA: 0x2CE0B0
	// RVA: 0x291D670 Offset: 0x291D771 VA: 0x291D670
	public bool get_IsRight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE0C0 Offset: 0x2CE1C1 VA: 0x2CE0C0
	// RVA: 0x291D680 Offset: 0x291D781 VA: 0x291D680
	private void set_IsRight(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE0D0 Offset: 0x2CE1D1 VA: 0x2CE0D0
	// RVA: 0x291D690 Offset: 0x291D791 VA: 0x291D690
	public bool get_IsNeutral() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE0E0 Offset: 0x2CE1E1 VA: 0x2CE0E0
	// RVA: 0x291D6A0 Offset: 0x291D7A1 VA: 0x291D6A0
	private void set_IsNeutral(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE0F0 Offset: 0x2CE1F1 VA: 0x2CE0F0
	// RVA: 0x291D6B0 Offset: 0x291D7B1 VA: 0x291D6B0
	private bool get_IsEclypse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE100 Offset: 0x2CE201 VA: 0x2CE100
	// RVA: 0x291D6C0 Offset: 0x291D7C1 VA: 0x291D6C0
	private void set_IsEclypse(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE110 Offset: 0x2CE211 VA: 0x2CE110
	// RVA: 0x291D6D0 Offset: 0x291D7D1 VA: 0x291D6D0
	public bool get_IsWatchClockwise() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE120 Offset: 0x2CE221 VA: 0x2CE120
	// RVA: 0x291D6E0 Offset: 0x291D7E1 VA: 0x291D6E0
	public void set_IsWatchClockwise(bool value) { }

	// RVA: 0x291D6F0 Offset: 0x291D7F1 VA: 0x291D6F0
	public void .ctor() { }

	// RVA: 0x291D780 Offset: 0x291D881 VA: 0x291D780
	public void .ctor(bool setRight) { }

	// RVA: 0x291D830 Offset: 0x291D931 VA: 0x291D830
	public void Tick() { }

	// RVA: 0x291E030 Offset: 0x291E131 VA: 0x291E030
	public void ResetClockwise() { }

	// RVA: 0x291E0B0 Offset: 0x291E1B1 VA: 0x291E0B0
	public bool TriggerRight(bool CheckCall = False) { }

	// RVA: 0x291E0F0 Offset: 0x291E1F1 VA: 0x291E0F0
	public bool TriggerLeft(bool CheckCall = False) { }

	// RVA: 0x291E130 Offset: 0x291E231 VA: 0x291E130
	public bool TriggerUp(bool CheckCall = False) { }

	// RVA: 0x291E170 Offset: 0x291E271 VA: 0x291E170
	public bool TriggerDown(bool CheckCall = False) { }

	// RVA: 0x291E1B0 Offset: 0x291E2B1 VA: 0x291E1B0
	public bool CheckAnyTrigger() { }

	// RVA: 0x291E230 Offset: 0x291E331 VA: 0x291E230
	public bool IsClockwise() { }

	// RVA: 0x291E250 Offset: 0x291E351 VA: 0x291E250
	public bool IsUnClockwise() { }

	// RVA: 0x291E270 Offset: 0x291E371 VA: 0x291E270
	public bool IsEclypseStart() { }
}

