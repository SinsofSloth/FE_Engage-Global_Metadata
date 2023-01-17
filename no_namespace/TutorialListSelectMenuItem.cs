// Namespace: 
public class TutorialListSelectMenuItem : BasicMenuItem // TypeDefIndex: 7712
{
	// Fields
	private string m_TutorialID; // 0x68
	private List<TutorialData> m_TutorialData; // 0x70
	private SpriteAtlas m_MainSpriteAtlas; // 0x78
	private SpriteAtlas m_SubSpriteAtlas; // 0x80
	private TutorialListRoot m_Root; // 0x88
	private bool m_IsUnread; // 0x90
	private const int FirstPage = 0;
	private int m_Page; // 0x94

	// Properties
	public bool IsUnread { get; }

	// Methods

	// RVA: 0x2880080 Offset: 0x2880181 VA: 0x2880080
	public void .ctor(string tutorialID, TutorialListRoot root) { }

	// RVA: 0x2880910 Offset: 0x2880A11 VA: 0x2880910 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2880A30 Offset: 0x2880B31 VA: 0x2880A30 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2880A40 Offset: 0x2880B41 VA: 0x2880A40 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x28811D0 Offset: 0x28812D1 VA: 0x28811D0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x2881240 Offset: 0x2881341 VA: 0x2881240 Slot: 9
	public override void Tick() { }

	// RVA: 0x28814A0 Offset: 0x28815A1 VA: 0x28814A0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x28814E0 Offset: 0x28815E1 VA: 0x28814E0 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x2880B90 Offset: 0x2880C91 VA: 0x2880B90
	private void InitParam() { }

	// RVA: 0x2880920 Offset: 0x2880A21 VA: 0x2880920
	private void InitColor() { }

	// RVA: 0x2880820 Offset: 0x2880921 VA: 0x2880820
	protected void UpdateText() { }

	// RVA: 0x2881500 Offset: 0x2881601 VA: 0x2881500
	private void TurnTutorial() { }

	// RVA: 0x28812D0 Offset: 0x28813D1 VA: 0x28812D0
	private void SetTutorialImage() { }

	// RVA: 0x2880BB0 Offset: 0x2880CB1 VA: 0x2880BB0
	private void SetTutorialText() { }

	// RVA: 0x2880DC0 Offset: 0x2880EC1 VA: 0x2880DC0
	private void SetArrow() { }

	// RVA: 0x2881CC0 Offset: 0x2881DC1 VA: 0x2881CC0
	public bool get_IsUnread() { }
}

