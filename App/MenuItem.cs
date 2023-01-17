// Namespace: App
public class MenuItem : IDisposable // TypeDefIndex: 8923
{
	// Fields
	protected DebugMenu m_Menu; // 0x10
	protected MenuItem.State m_State; // 0x18
	protected int m_Bind; // 0x1C

	// Methods

	// RVA: 0x2863B70 Offset: 0x2863C71 VA: 0x2863B70 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x2863BC0 Offset: 0x2863CC1 VA: 0x2863BC0 Slot: 6
	public virtual string GetNameEnglish() { }

	// RVA: 0x2863BD0 Offset: 0x2863CD1 VA: 0x2863BD0 Slot: 7
	public virtual string GetHelp() { }

	// RVA: 0x2863BE0 Offset: 0x2863CE1 VA: 0x2863BE0 Slot: 8
	public virtual string GetHelpEnglish() { }

	// RVA: 0x2863BF0 Offset: 0x2863CF1 VA: 0x2863BF0 Slot: 9
	public virtual float GetHelpWidth() { }

	// RVA: 0x2863D40 Offset: 0x2863E41 VA: 0x2863D40 Slot: 10
	public virtual float GetHelpHeight() { }

	// RVA: 0x2863D50 Offset: 0x2863E51 VA: 0x2863D50 Slot: 11
	public virtual MenuItem.Kind GetKind() { }

	// RVA: 0x2863D60 Offset: 0x2863E61 VA: 0x2863D60 Slot: 12
	public virtual MenuItem.Result ACall() { }

	// RVA: 0x2863D70 Offset: 0x2863E71 VA: 0x2863D70 Slot: 13
	public virtual MenuItem.Result BCall() { }

	// RVA: 0x2863D80 Offset: 0x2863E81 VA: 0x2863D80 Slot: 14
	public virtual MenuItem.Result XCall() { }

	// RVA: 0x2863D90 Offset: 0x2863E91 VA: 0x2863D90 Slot: 15
	public virtual MenuItem.Result YCall() { }

	// RVA: 0x2863DA0 Offset: 0x2863EA1 VA: 0x2863DA0 Slot: 16
	public virtual MenuItem.Result LCall() { }

	// RVA: 0x2863DB0 Offset: 0x2863EB1 VA: 0x2863DB0 Slot: 17
	public virtual MenuItem.Result RCall() { }

	// RVA: 0x2863DC0 Offset: 0x2863EC1 VA: 0x2863DC0 Slot: 18
	public virtual MenuItem.Result PlusCall() { }

	// RVA: 0x2863DD0 Offset: 0x2863ED1 VA: 0x2863DD0 Slot: 19
	public virtual MenuItem.Result MinusCall() { }

	// RVA: 0x2863DE0 Offset: 0x2863EE1 VA: 0x2863DE0 Slot: 20
	public virtual MenuItem.Result LeftCall() { }

	// RVA: 0x2863DF0 Offset: 0x2863EF1 VA: 0x2863DF0 Slot: 21
	public virtual MenuItem.Result RightCall() { }

	// RVA: 0x2863E00 Offset: 0x2863F01 VA: 0x2863E00 Slot: 22
	public virtual bool IsEnable() { }

	// RVA: 0x2863E10 Offset: 0x2863F11 VA: 0x2863E10 Slot: 23
	public virtual bool IsVisible() { }

	// RVA: 0x2863E20 Offset: 0x2863F21 VA: 0x2863E20 Slot: 24
	public virtual bool IsSelectable() { }

	// RVA: 0x2863E30 Offset: 0x2863F31 VA: 0x2863E30 Slot: 25
	public virtual float GetWidth() { }

	// RVA: 0x2863EE0 Offset: 0x2863FE1 VA: 0x2863EE0 Slot: 26
	public virtual float GetHeight() { }

	// RVA: 0x2863F70 Offset: 0x2864071 VA: 0x2863F70 Slot: 27
	public virtual Color GetFontColor() { }

	// RVA: 0x2863F80 Offset: 0x2864081 VA: 0x2863F80 Slot: 28
	public virtual Color GetBackColor() { }

	// RVA: 0x2863FF0 Offset: 0x28640F1 VA: 0x2863FF0 Slot: 29
	public virtual int GetColumnCount() { }

	// RVA: 0x2864000 Offset: 0x2864101 VA: 0x2864000 Slot: 30
	public virtual float GetColumnWidth(int i) { }

	// RVA: 0x2864100 Offset: 0x2864201 VA: 0x2864100 Slot: 31
	public virtual float GetColumnWidth0() { }

	// RVA: 0x2864130 Offset: 0x2864231 VA: 0x2864130 Slot: 32
	public virtual float GetColumnWidth1() { }

	// RVA: 0x2864160 Offset: 0x2864261 VA: 0x2864160 Slot: 33
	public virtual float GetColumnWidth2() { }

	// RVA: 0x2864190 Offset: 0x2864291 VA: 0x2864190 Slot: 34
	public virtual float GetColumnWidth3() { }

	// RVA: 0x28641C0 Offset: 0x28642C1 VA: 0x28641C0 Slot: 35
	public virtual float GetColumnWidth4() { }

	// RVA: 0x28641F0 Offset: 0x28642F1 VA: 0x28641F0 Slot: 36
	public virtual float GetColumnHeight(int i) { }

	// RVA: 0x28642F0 Offset: 0x28643F1 VA: 0x28642F0 Slot: 37
	public virtual float GetColumnHeight0() { }

	// RVA: 0x2864320 Offset: 0x2864421 VA: 0x2864320 Slot: 38
	public virtual float GetColumnHeight1() { }

	// RVA: 0x2864350 Offset: 0x2864451 VA: 0x2864350 Slot: 39
	public virtual float GetColumnHeight2() { }

	// RVA: 0x2864380 Offset: 0x2864481 VA: 0x2864380 Slot: 40
	public virtual float GetColumnHeight3() { }

	// RVA: 0x28643B0 Offset: 0x28644B1 VA: 0x28643B0 Slot: 41
	public virtual float GetColumnHeight4() { }

	// RVA: 0x28643E0 Offset: 0x28644E1 VA: 0x28643E0 Slot: 42
	public virtual string GetColumnName0() { }

	// RVA: 0x28643F0 Offset: 0x28644F1 VA: 0x28643F0 Slot: 43
	public virtual string GetColumnName1() { }

	// RVA: 0x2864440 Offset: 0x2864541 VA: 0x2864440 Slot: 44
	public virtual string GetColumnName2() { }

	// RVA: 0x2864490 Offset: 0x2864591 VA: 0x2864490 Slot: 45
	public virtual string GetColumnName3() { }

	// RVA: 0x28644E0 Offset: 0x28645E1 VA: 0x28644E0 Slot: 46
	public virtual string GetColumnName4() { }

	// RVA: 0x2864530 Offset: 0x2864631 VA: 0x2864530 Slot: 47
	public virtual string GetColumnEnglish0() { }

	// RVA: 0x2864540 Offset: 0x2864641 VA: 0x2864540 Slot: 48
	public virtual string GetColumnEnglish1() { }

	// RVA: 0x2864550 Offset: 0x2864651 VA: 0x2864550 Slot: 49
	public virtual string GetColumnEnglish2() { }

	// RVA: 0x2864560 Offset: 0x2864661 VA: 0x2864560 Slot: 50
	public virtual string GetColumnEnglish3() { }

	// RVA: 0x2864570 Offset: 0x2864671 VA: 0x2864570 Slot: 51
	public virtual string GetColumnEnglish4() { }

	// RVA: 0x2864580 Offset: 0x2864681 VA: 0x2864580 Slot: 52
	public virtual MenuItem.Align GetColumnAlign(int i) { }

	// RVA: 0x2864600 Offset: 0x2864701 VA: 0x2864600 Slot: 53
	public virtual MenuItem.Align GetColumnAlign0() { }

	// RVA: 0x2864610 Offset: 0x2864711 VA: 0x2864610 Slot: 54
	public virtual MenuItem.Align GetColumnAlign1() { }

	// RVA: 0x2864620 Offset: 0x2864721 VA: 0x2864620 Slot: 55
	public virtual MenuItem.Align GetColumnAlign2() { }

	// RVA: 0x2864630 Offset: 0x2864731 VA: 0x2864630 Slot: 56
	public virtual MenuItem.Align GetColumnAlign3() { }

	// RVA: 0x2864640 Offset: 0x2864741 VA: 0x2864640 Slot: 57
	public virtual MenuItem.Align GetColumnAlign4() { }

	// RVA: 0x2864650 Offset: 0x2864751 VA: 0x2864650 Slot: 58
	public virtual Color GetColumnColor(int i) { }

	// RVA: 0x28646E0 Offset: 0x28647E1 VA: 0x28646E0 Slot: 59
	public virtual Color GetColumnColor0() { }

	// RVA: 0x28646F0 Offset: 0x28647F1 VA: 0x28646F0 Slot: 60
	public virtual Color GetColumnColor1() { }

	// RVA: 0x2864700 Offset: 0x2864801 VA: 0x2864700 Slot: 61
	public virtual Color GetColumnColor2() { }

	// RVA: 0x2864710 Offset: 0x2864811 VA: 0x2864710 Slot: 62
	public virtual Color GetColumnColor3() { }

	// RVA: 0x2864720 Offset: 0x2864821 VA: 0x2864720 Slot: 63
	public virtual Color GetColumnColor4() { }

	// RVA: 0x2864730 Offset: 0x2864831 VA: 0x2864730 Slot: 64
	public virtual Color GetDisableColor() { }

	// RVA: 0x2864770 Offset: 0x2864871 VA: 0x2864770 Slot: 65
	public virtual float GetMarginWidth() { }

	// RVA: 0x2864780 Offset: 0x2864881 VA: 0x2864780 Slot: 66
	public virtual float GetMarginHeight() { }

	// RVA: 0x2864790 Offset: 0x2864891 VA: 0x2864790 Slot: 67
	public virtual int GetKey(int index) { }

	// RVA: 0x28647A0 Offset: 0x28648A1 VA: 0x28647A0
	public DebugMenu GetMenu() { }

	// RVA: 0x28640D0 Offset: 0x28641D1 VA: 0x28640D0
	public float GetTextWidth(int i) { }

	// RVA: 0x28642C0 Offset: 0x28643C1 VA: 0x28642C0
	public float GetTextHeight(int i) { }

	// RVA: 0x28649D0 Offset: 0x2864AD1 VA: 0x28649D0
	public void SetMenu(DebugMenu menu) { }

	// RVA: 0x28649E0 Offset: 0x2864AE1 VA: 0x28649E0
	public MenuItem.State GetState() { }

	// RVA: 0x28649F0 Offset: 0x2864AF1 VA: 0x28649F0
	public void SetState(MenuItem.State state) { }

	// RVA: 0x2864A00 Offset: 0x2864B01 VA: 0x2864A00
	public int GetBind() { }

	// RVA: 0x2864A10 Offset: 0x2864B11 VA: 0x2864A10
	public void SetBind(int bind) { }

	// RVA: 0x2864A20 Offset: 0x2864B21 VA: 0x2864A20
	public ProcInst GetRoot() { }

	// RVA: 0x2864AB0 Offset: 0x2864BB1 VA: 0x2864AB0 Slot: 68
	public virtual void OnTick() { }

	// RVA: 0x2864AC0 Offset: 0x2864BC1 VA: 0x2864AC0 Slot: 69
	public virtual void OnSelect() { }

	// RVA: 0x2864AD0 Offset: 0x2864BD1 VA: 0x2864AD0 Slot: 70
	public virtual void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x2864AE0 Offset: 0x2864BE1 VA: 0x2864AE0
	public DebugMenu CreateMenuBind() { }

	// RVA: 0x2864B50 Offset: 0x2864C51 VA: 0x2864B50 Slot: 71
	public virtual void Dispose() { }

	// RVA: 0x28647B0 Offset: 0x28648B1 VA: 0x28647B0
	public string GetLangName(int i) { }

	// RVA: 0x2863C30 Offset: 0x2863D31 VA: 0x2863C30
	public string GetLangHelp() { }

	// RVA: 0x2864B60 Offset: 0x2864C61 VA: 0x2864B60
	public static DebugMenu op_Implicit(MenuItem p) { }

	// RVA: 0x2864B70 Offset: 0x2864C71 VA: 0x2864B70
	public void .ctor() { }
}

