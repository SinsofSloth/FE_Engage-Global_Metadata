// Namespace: App
public class UnitInfoWindowCharaUpdater : MonoBehaviour // TypeDefIndex: 14075
{
	// Fields
	private bool m_IsRequestToPlayBody; // 0x18
	private bool m_IsRequestToPlayFace; // 0x19
	private int m_BodyAnimHash; // 0x1C
	private float m_BodyAnimTransitionDuration; // 0x20
	private int m_FaceAnimHash; // 0x24
	private bool m_IsRequestToSetParam; // 0x28
	private int m_BodyParamHash; // 0x2C
	private bool m_BodyParamValue; // 0x30
	private bool m_IsRequestToWeapon; // 0x31
	private ItemData m_RequestWeapon; // 0x38
	private int m_AnimeChangeWaitCount; // 0x40
	private GameObject m_CameraObject; // 0x48
	private Image m_CharaImageSimple; // 0x50
	private float m_DefaultZoomCameraLocalHeight; // 0x58
	public GameObject m_HeadLookAtObj; // 0x60
	private bool m_IsRequestToOffset; // 0x68

	// Methods

	// RVA: 0x2435DB0 Offset: 0x2435EB1 VA: 0x2435DB0
	private void Update() { }

	// RVA: 0x2435E70 Offset: 0x2435F71 VA: 0x2435E70
	private bool TryUpdateOffset(Character chara) { }

	// RVA: 0x24361D0 Offset: 0x24362D1 VA: 0x24361D0
	private void LateUpdate() { }

	// RVA: 0x2431160 Offset: 0x2431261 VA: 0x2431160
	public bool IsBodyAnimEnd() { }

	// RVA: 0x2431150 Offset: 0x2431251 VA: 0x2431150
	public bool TrySameBodyAnimHash(int animHash) { }

	// RVA: 0x24312F0 Offset: 0x24313F1 VA: 0x24312F0
	public bool RequestToPlayBody(int bodyAnimHash, float transitionDuration = -1) { }

	// RVA: 0x2431EA0 Offset: 0x2431FA1 VA: 0x2431EA0
	public void PlayBodyForced() { }

	// RVA: 0x24328C0 Offset: 0x24329C1 VA: 0x24328C0
	public void RequestToPlayFace(int faceAnimHash, bool isForced = False) { }

	// RVA: 0x2433D50 Offset: 0x2433E51 VA: 0x2433D50
	public void RequestToShowWeapon(ItemData item) { }

	// RVA: 0x24328A0 Offset: 0x24329A1 VA: 0x24328A0
	public void RequestToSetParam(int bodyParamHash, bool value) { }

	// RVA: 0x2435020 Offset: 0x2435121 VA: 0x2435020
	public void SetCameraObject(GameObject cameraObject) { }

	// RVA: 0x24364D0 Offset: 0x24365D1 VA: 0x24364D0
	public void SetCharaImage(Image imageSimple) { }

	// RVA: 0x2434F90 Offset: 0x2435091 VA: 0x2434F90
	public void TrySetCameraAdjustY() { }

	// RVA: 0x24364E0 Offset: 0x24365E1 VA: 0x24364E0
	public void ResetAnimeRequest() { }

	// RVA: 0x2432B00 Offset: 0x2432C01 VA: 0x2432B00
	public void ShowImages() { }

	// RVA: 0x2434250 Offset: 0x2434351 VA: 0x2434250
	public void HideImages() { }

	// RVA: 0x2436510 Offset: 0x2436611 VA: 0x2436510
	public void .ctor() { }
}

