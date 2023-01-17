// Namespace: 
public class MoviePlayerBase.KeyHelp // TypeDefIndex: 12703
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private KeyHelpController m_KeyHelpController; // 0x18
	private bool m_IsShow; // 0x20
	private float m_DispTimer; // 0x24

	// Methods

	// RVA: 0x26DA990 Offset: 0x26DAA91 VA: 0x26DA990
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x26DAA20 Offset: 0x26DAB21 VA: 0x26DAA20
	public void Show() { }

	// RVA: 0x26DAA90 Offset: 0x26DAB91 VA: 0x26DAA90
	public void Hide() { }

	// RVA: 0x26DAAB0 Offset: 0x26DABB1 VA: 0x26DAAB0
	public void Tick() { }
}

// Namespace: 
public class MoviePlayerBase.Caption // TypeDefIndex: 12704
{
	// Fields
	private TextMeshProUGUI m_Text; // 0x10
	private float m_Time; // 0x18
	private float m_Duration; // 0x1C
	private bool m_IsShow; // 0x20
	private bool m_IsShowOld; // 0x21

	// Methods

	// RVA: 0x26DA640 Offset: 0x26DA741 VA: 0x26DA640
	public void .ctor(TextMeshProUGUI text) { }

	// RVA: 0x26DA740 Offset: 0x26DA841 VA: 0x26DA740 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26DA750 Offset: 0x26DA851 VA: 0x26DA750
	public void Reset() { }

	// RVA: 0x26DA760 Offset: 0x26DA861 VA: 0x26DA760
	public void SetText(string mid, int msec) { }

	// RVA: 0x26DA6D0 Offset: 0x26DA7D1 VA: 0x26DA6D0
	public void ClearText() { }

	// RVA: 0x26DA820 Offset: 0x26DA921 VA: 0x26DA820
	public bool IsShow() { }

	// RVA: 0x26DA830 Offset: 0x26DA931 VA: 0x26DA830
	public void Show() { }

	// RVA: 0x26DA840 Offset: 0x26DA941 VA: 0x26DA840
	public void Hide() { }

	// RVA: 0x26DA850 Offset: 0x26DA951 VA: 0x26DA850
	public void SwitchShow() { }

	// RVA: 0x26DA860 Offset: 0x26DA961 VA: 0x26DA860
	public void Tick() { }
}

// Namespace: 
public class MoviePlayerBase.TitleLogo : IDisposable // TypeDefIndex: 12705
{
	// Fields
	private Image m_Image; // 0x10
	private Animator m_Animator; // 0x18
	private float m_Time; // 0x20
	private float m_Duration; // 0x24
	private TResourceHandle<Sprite> m_TextureResourceHandle; // 0x28

	// Methods

	// RVA: 0x26DAB60 Offset: 0x26DAC61 VA: 0x26DAB60
	public void .ctor(Image image, Animator animator) { }

	// RVA: 0x26DAE00 Offset: 0x26DAF01 VA: 0x26DAE00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26DAE70 Offset: 0x26DAF71 VA: 0x26DAE70 Slot: 4
	public void Dispose() { }

	// RVA: 0x26DAE80 Offset: 0x26DAF81 VA: 0x26DAE80
	public void Reset() { }

	// RVA: 0x26DAE90 Offset: 0x26DAF91 VA: 0x26DAE90
	public void Show(int msec) { }

	// RVA: 0x26DADD0 Offset: 0x26DAED1 VA: 0x26DADD0
	public void Hide() { }

	// RVA: 0x26DAF20 Offset: 0x26DB021 VA: 0x26DAF20
	public void Tick() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9F80 Offset: 0x2CA081 VA: 0x2C9F80
	// RVA: 0x26DAFC0 Offset: 0x26DB0C1 VA: 0x26DAFC0
	private void <.ctor>b__5_0(Sprite sprite) { }
}

