// Namespace: App.Talk3D
public class TalkUI : SingletonMonoBehaviour<TalkUI> // TypeDefIndex: 14170
{
	// Fields
	private const int EventPictureMax = 2;
	private const string FaceLocationName_Left = "Top";
	private const string FaceLocationName_Right = "Bottom";
	private TalkUI.SystemObjects m_SystemObjects; // 0x20
	private TalkUI.StandObjects m_StandObjects; // 0x28
	private TalkUI.FaceObjects m_FaceObjects; // 0x30
	private TalkUI.TalkObjects m_FocusTalkObjects; // 0x38
	private string m_ReserveFocusWindow; // 0x40
	private EventPictureController[] m_EventPictureController; // 0x48

	// Properties
	private Talk.TalkType TalkType { get; }

	// Methods

	// RVA: 0x2C3A390 Offset: 0x2C3A491 VA: 0x2C3A390
	private Talk.TalkType get_TalkType() { }

	// RVA: 0x2C3A410 Offset: 0x2C3A511 VA: 0x2C3A410 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2C3A820 Offset: 0x2C3A921 VA: 0x2C3A820
	private void OnDestroy() { }

	// RVA: 0x2C3A830 Offset: 0x2C3A931 VA: 0x2C3A830
	public void ResetUI() { }

	// RVA: 0x2C3A880 Offset: 0x2C3A981 VA: 0x2C3A880
	private void Update() { }

	// RVA: 0x2C2D950 Offset: 0x2C2DA51 VA: 0x2C2D950
	public void Show() { }

	// RVA: 0x2C2DB00 Offset: 0x2C2DC01 VA: 0x2C2DB00
	public void Hide() { }

	// RVA: 0x2C3A000 Offset: 0x2C3A101 VA: 0x2C3A000
	public void ShowWindowBg() { }

	// RVA: 0x2C3A0D0 Offset: 0x2C3A1D1 VA: 0x2C3A0D0
	public void HideWindowBg() { }

	// RVA: 0x2C38FA0 Offset: 0x2C390A1 VA: 0x2C38FA0
	public void SetTalkType(Talk.TalkType talkType, string namePlateRootObjectName = "Default") { }

	// RVA: 0x2C3A8A0 Offset: 0x2C3A9A1 VA: 0x2C3A8A0
	public void ReOpenWindow() { }

	// RVA: 0x2C369D0 Offset: 0x2C36AD1 VA: 0x2C369D0
	public bool AddLetterToFocusWindow(char chr) { }

	// RVA: 0x2C37780 Offset: 0x2C37881 VA: 0x2C37780
	public bool AddStringToFocusWindow(string str) { }

	// RVA: 0x2C33A60 Offset: 0x2C33B61 VA: 0x2C33A60
	public void ClearForcusWindowText() { }

	// RVA: 0x2C2A280 Offset: 0x2C2A381 VA: 0x2C2A280
	public void ShowKeyWaitIcon() { }

	// RVA: 0x2C2A3D0 Offset: 0x2C2A4D1 VA: 0x2C2A3D0
	public void HideKeyWaitIcon() { }

	// RVA: 0x2C3AAC0 Offset: 0x2C3ABC1 VA: 0x2C3AAC0
	public void SetupKeyHelp() { }

	// RVA: 0x2C3AAE0 Offset: 0x2C3ABE1 VA: 0x2C3AAE0
	public void SetupWaitIcon() { }

	// RVA: 0x2C36D70 Offset: 0x2C36E71 VA: 0x2C36D70
	public void SetTalkerName(string name, string locationName) { }

	// RVA: 0x2C39DA0 Offset: 0x2C39EA1 VA: 0x2C39DA0
	public void CloseTalkerName() { }

	// RVA: 0x2C3AB00 Offset: 0x2C3AC01 VA: 0x2C3AB00
	public void FadeInFace(string locationName) { }

	// RVA: 0x2C3AC30 Offset: 0x2C3AD31 VA: 0x2C3AC30
	public void FadeOutFace(string locationName) { }

	// RVA: 0x2C24540 Offset: 0x2C24641 VA: 0x2C24540
	public void SetFaceSlideRate(string locationName, float faceSlideRate) { }

	// RVA: 0x2C39DC0 Offset: 0x2C39EC1 VA: 0x2C39DC0
	public void ChangeFocus(string location) { }

	// RVA: 0x2C39F40 Offset: 0x2C3A041 VA: 0x2C39F40
	public void EnableFaceSilhouette(string locationName) { }

	// RVA: 0x2C24690 Offset: 0x2C24791 VA: 0x2C24690
	public void DisableFaceSilhouette(string locationName) { }

	// RVA: 0x2C33440 Offset: 0x2C33541 VA: 0x2C33440
	public void CloseAll() { }

	// RVA: 0x2C32FF0 Offset: 0x2C330F1 VA: 0x2C32FF0
	public bool IsPlayingAnimation() { }

	// RVA: 0x2C2F0C0 Offset: 0x2C2F1C1 VA: 0x2C2F0C0
	public void StartPageScroll() { }

	// RVA: 0x2C2F360 Offset: 0x2C2F461 VA: 0x2C2F360
	public bool IsPageScrolling() { }

	// RVA: 0x2C369B0 Offset: 0x2C36AB1 VA: 0x2C369B0
	public bool IsFocusWindowTextEmpty() { }

	// RVA: 0x2C36E60 Offset: 0x2C36F61 VA: 0x2C36E60
	public void AddToLog(string label, string talkerName) { }

	// RVA: 0x2C3AD60 Offset: 0x2C3AE61 VA: 0x2C3AD60
	public void ResetReserveFocus() { }

	// RVA: 0x2C3AD70 Offset: 0x2C3AE71 VA: 0x2C3AD70
	public void ReserveFocus(string locationName) { }

	// RVA: 0x2C33270 Offset: 0x2C33371 VA: 0x2C33270
	public void CheckReserveFocus() { }

	// RVA: 0x2C38BA0 Offset: 0x2C38CA1 VA: 0x2C38BA0
	public void ShowPicture(int eventPictureIndex, string textureName, string animName) { }

	// RVA: 0x2C38C60 Offset: 0x2C38D61 VA: 0x2C38C60
	public void HidePicture(int eventPictureIndex, string animName) { }

	// RVA: 0x2C3AD80 Offset: 0x2C3AE81 VA: 0x2C3AD80
	public GameObject GetNamePlateLocator(GameObject talkCharaControllerObject) { }

	// RVA: 0x2C3AED0 Offset: 0x2C3AFD1 VA: 0x2C3AED0
	public float CalcTotalWidth(string messStr) { }

	// RVA: 0x2C3AEF0 Offset: 0x2C3AFF1 VA: 0x2C3AEF0
	public void .ctor() { }
}

