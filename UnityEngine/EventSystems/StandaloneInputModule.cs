// Namespace: UnityEngine.EventSystems
[AddComponentMenu] // RVA: 0x438B0 Offset: 0x439B1 VA: 0x438B0
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 4424
{
	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	private PointerEventData m_InputPointerEvent; // 0x80
	[SerializeField] // RVA: 0x45A30 Offset: 0x45B31 VA: 0x45A30
	private string m_HorizontalAxis; // 0x88
	[SerializeField] // RVA: 0x45A40 Offset: 0x45B41 VA: 0x45A40
	private string m_VerticalAxis; // 0x90
	[SerializeField] // RVA: 0x45A50 Offset: 0x45B51 VA: 0x45A50
	private string m_SubmitButton; // 0x98
	[SerializeField] // RVA: 0x45A60 Offset: 0x45B61 VA: 0x45A60
	private string m_CancelButton; // 0xA0
	[SerializeField] // RVA: 0x45A70 Offset: 0x45B71 VA: 0x45A70
	private float m_InputActionsPerSecond; // 0xA8
	[SerializeField] // RVA: 0x45A80 Offset: 0x45B81 VA: 0x45A80
	private float m_RepeatDelay; // 0xAC
	[SerializeField] // RVA: 0x45A90 Offset: 0x45B91 VA: 0x45A90
	[FormerlySerializedAsAttribute] // RVA: 0x45A90 Offset: 0x45B91 VA: 0x45A90
	private bool m_ForceModuleActive; // 0xB0

	// Properties
	[ObsoleteAttribute] // RVA: 0x46940 Offset: 0x46A41 VA: 0x46940
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x46980 Offset: 0x46A81 VA: 0x46980
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x1BF3350 Offset: 0x1BF3451 VA: 0x1BF3350
	protected void .ctor() { }

	// RVA: 0x1BF3440 Offset: 0x1BF3541 VA: 0x1BF3440
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x1BF3450 Offset: 0x1BF3551 VA: 0x1BF3450
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x1BF3460 Offset: 0x1BF3561 VA: 0x1BF3460
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x1BF3470 Offset: 0x1BF3571 VA: 0x1BF3470
	public bool get_forceModuleActive() { }

	// RVA: 0x1BF3480 Offset: 0x1BF3581 VA: 0x1BF3480
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1BF3490 Offset: 0x1BF3591 VA: 0x1BF3490
	public float get_inputActionsPerSecond() { }

	// RVA: 0x1BF34A0 Offset: 0x1BF35A1 VA: 0x1BF34A0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x1BF34B0 Offset: 0x1BF35B1 VA: 0x1BF34B0
	public float get_repeatDelay() { }

	// RVA: 0x1BF34C0 Offset: 0x1BF35C1 VA: 0x1BF34C0
	public void set_repeatDelay(float value) { }

	// RVA: 0x1BF34D0 Offset: 0x1BF35D1 VA: 0x1BF34D0
	public string get_horizontalAxis() { }

	// RVA: 0x1BF34E0 Offset: 0x1BF35E1 VA: 0x1BF34E0
	public void set_horizontalAxis(string value) { }

	// RVA: 0x1BF34F0 Offset: 0x1BF35F1 VA: 0x1BF34F0
	public string get_verticalAxis() { }

	// RVA: 0x1BF3500 Offset: 0x1BF3601 VA: 0x1BF3500
	public void set_verticalAxis(string value) { }

	// RVA: 0x1BF3510 Offset: 0x1BF3611 VA: 0x1BF3510
	public string get_submitButton() { }

	// RVA: 0x1BF3520 Offset: 0x1BF3621 VA: 0x1BF3520
	public void set_submitButton(string value) { }

	// RVA: 0x1BF3530 Offset: 0x1BF3631 VA: 0x1BF3530
	public string get_cancelButton() { }

	// RVA: 0x1BF3540 Offset: 0x1BF3641 VA: 0x1BF3540
	public void set_cancelButton(string value) { }

	// RVA: 0x1BF3550 Offset: 0x1BF3651 VA: 0x1BF3550
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x1BF3560 Offset: 0x1BF3661 VA: 0x1BF3560 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x1BF3650 Offset: 0x1BF3751 VA: 0x1BF3650
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x1BF3AE0 Offset: 0x1BF3BE1 VA: 0x1BF3AE0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x1BF3B50 Offset: 0x1BF3C51 VA: 0x1BF3B50 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x1BF3CD0 Offset: 0x1BF3DD1 VA: 0x1BF3CD0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x1BF3DF0 Offset: 0x1BF3EF1 VA: 0x1BF3DF0 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1BF3E20 Offset: 0x1BF3F21 VA: 0x1BF3E20 Slot: 17
	public override void Process() { }

	// RVA: 0x1BF4040 Offset: 0x1BF4141 VA: 0x1BF4040
	private bool ProcessTouchEvents() { }

	// RVA: 0x1BF4690 Offset: 0x1BF4791 VA: 0x1BF4690
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1BF4450 Offset: 0x1BF4551 VA: 0x1BF4450
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x1BF4ED0 Offset: 0x1BF4FD1 VA: 0x1BF4ED0
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x1BF4220 Offset: 0x1BF4321 VA: 0x1BF4220
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x1BF4210 Offset: 0x1BF4311 VA: 0x1BF4210
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x466D0 Offset: 0x467D1 VA: 0x466D0
	// RVA: 0x1BF5220 Offset: 0x1BF5321 VA: 0x1BF5220 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x1BF4FD0 Offset: 0x1BF50D1 VA: 0x1BF4FD0
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x1BF3EC0 Offset: 0x1BF3FC1 VA: 0x1BF3EC0
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x1BF53A0 Offset: 0x1BF54A1 VA: 0x1BF53A0
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x1BF57F0 Offset: 0x1BF58F1 VA: 0x1BF57F0
	protected GameObject GetCurrentFocusedGameObject() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu] // RVA: 0x27AD50 Offset: 0x27AE51 VA: 0x27AD50
public class StandaloneInputModule18 : PointerInputModule // TypeDefIndex: 15051
{
	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	[SerializeField] // RVA: 0x2A64A0 Offset: 0x2A65A1 VA: 0x2A64A0
	private string m_HorizontalAxis; // 0x80
	[SerializeField] // RVA: 0x2A64B0 Offset: 0x2A65B1 VA: 0x2A64B0
	private string m_VerticalAxis; // 0x88
	[SerializeField] // RVA: 0x2A64C0 Offset: 0x2A65C1 VA: 0x2A64C0
	private string m_SubmitButton; // 0x90
	[SerializeField] // RVA: 0x2A64D0 Offset: 0x2A65D1 VA: 0x2A64D0
	private string m_CancelButton; // 0x98
	[SerializeField] // RVA: 0x2A64E0 Offset: 0x2A65E1 VA: 0x2A64E0
	private float m_InputActionsPerSecond; // 0xA0
	[SerializeField] // RVA: 0x2A64F0 Offset: 0x2A65F1 VA: 0x2A64F0
	private float m_RepeatDelay; // 0xA4
	[SerializeField] // RVA: 0x2A6500 Offset: 0x2A6601 VA: 0x2A6500
	[FormerlySerializedAsAttribute] // RVA: 0x2A6500 Offset: 0x2A6601 VA: 0x2A6500
	private bool m_ForceModuleActive; // 0xA8

	// Properties
	[ObsoleteAttribute] // RVA: 0x2D4FB0 Offset: 0x2D50B1 VA: 0x2D4FB0
	public StandaloneInputModule18.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x2D4FF0 Offset: 0x2D50F1 VA: 0x2D4FF0
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x291AC70 Offset: 0x291AD71 VA: 0x291AC70
	protected void .ctor() { }

	// RVA: 0x291AD60 Offset: 0x291AE61 VA: 0x291AD60
	public StandaloneInputModule18.InputMode get_inputMode() { }

	// RVA: 0x291AD70 Offset: 0x291AE71 VA: 0x291AD70
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x291AD80 Offset: 0x291AE81 VA: 0x291AD80
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x291AD90 Offset: 0x291AE91 VA: 0x291AD90
	public bool get_forceModuleActive() { }

	// RVA: 0x291ADA0 Offset: 0x291AEA1 VA: 0x291ADA0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x291ADB0 Offset: 0x291AEB1 VA: 0x291ADB0
	public float get_inputActionsPerSecond() { }

	// RVA: 0x291ADC0 Offset: 0x291AEC1 VA: 0x291ADC0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x291ADD0 Offset: 0x291AED1 VA: 0x291ADD0
	public float get_repeatDelay() { }

	// RVA: 0x291ADE0 Offset: 0x291AEE1 VA: 0x291ADE0
	public void set_repeatDelay(float value) { }

	// RVA: 0x291ADF0 Offset: 0x291AEF1 VA: 0x291ADF0
	public string get_horizontalAxis() { }

	// RVA: 0x291AE00 Offset: 0x291AF01 VA: 0x291AE00
	public void set_horizontalAxis(string value) { }

	// RVA: 0x291AE10 Offset: 0x291AF11 VA: 0x291AE10
	public string get_verticalAxis() { }

	// RVA: 0x291AE20 Offset: 0x291AF21 VA: 0x291AE20
	public void set_verticalAxis(string value) { }

	// RVA: 0x291AE30 Offset: 0x291AF31 VA: 0x291AE30
	public string get_submitButton() { }

	// RVA: 0x291AE40 Offset: 0x291AF41 VA: 0x291AE40
	public void set_submitButton(string value) { }

	// RVA: 0x291AE50 Offset: 0x291AF51 VA: 0x291AE50
	public string get_cancelButton() { }

	// RVA: 0x291AE60 Offset: 0x291AF61 VA: 0x291AE60
	public void set_cancelButton(string value) { }

	// RVA: 0x291AE70 Offset: 0x291AF71 VA: 0x291AE70
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x291AEA0 Offset: 0x291AFA1 VA: 0x291AEA0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x291AF10 Offset: 0x291B011 VA: 0x291AF10 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x291AF80 Offset: 0x291B081 VA: 0x291AF80 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x291B6F0 Offset: 0x291B7F1 VA: 0x291B6F0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x291B820 Offset: 0x291B921 VA: 0x291B820 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x291B850 Offset: 0x291B951 VA: 0x291B850 Slot: 17
	public override void Process() { }

	// RVA: 0x291BF20 Offset: 0x291C021 VA: 0x291BF20
	private bool ProcessTouchEvents() { }

	// RVA: 0x291C100 Offset: 0x291C201 VA: 0x291C100
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x291BD10 Offset: 0x291BE11 VA: 0x291BD10
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x291C940 Offset: 0x291CA41 VA: 0x291C940
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x291BA80 Offset: 0x291BB81 VA: 0x291BA80
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x291C0F0 Offset: 0x291C1F1 VA: 0x291C0F0
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x2D2350 Offset: 0x2D2451 VA: 0x2D2350
	// RVA: 0x291CBE0 Offset: 0x291CCE1 VA: 0x291CBE0 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x291C980 Offset: 0x291CA81 VA: 0x291C980
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x291B900 Offset: 0x291BA01 VA: 0x291B900
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x291CBF0 Offset: 0x291CCF1 VA: 0x291CBF0
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x291D380 Offset: 0x291D481 VA: 0x291D380
	protected GameObject GetCurrentFocusedGameObject() { }

	// RVA: 0x291B090 Offset: 0x291B191 VA: 0x291B090
	private static bool A() { }

	// RVA: 0x291B1D0 Offset: 0x291B2D1 VA: 0x291B1D0
	private static bool B() { }

	// RVA: 0x291B310 Offset: 0x291B411 VA: 0x291B310
	private static float X() { }

	// RVA: 0x291B500 Offset: 0x291B601 VA: 0x291B500
	private static float Y() { }
}

