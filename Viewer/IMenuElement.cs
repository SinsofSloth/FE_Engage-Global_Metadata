// Namespace: Viewer
internal abstract class IMenuElement // TypeDefIndex: 8358
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F840 Offset: 0x27F941 VA: 0x27F840
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x27F850 Offset: 0x27F951 VA: 0x27F850
	private Color <FontColor>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27F860 Offset: 0x27F961 VA: 0x27F860
	private readonly bool <HasCallback>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x27F870 Offset: 0x27F971 VA: 0x27F870
	private string <Value>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x27F880 Offset: 0x27F981 VA: 0x27F880
	private int <Select>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x27F890 Offset: 0x27F991 VA: 0x27F890
	private bool <SubSelect>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x27F8A0 Offset: 0x27F9A1 VA: 0x27F8A0
	private int <LastSelect>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x27F8B0 Offset: 0x27F9B1 VA: 0x27F8B0
	private readonly float <SliderMin>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x27F8C0 Offset: 0x27F9C1 VA: 0x27F8C0
	private readonly float <SliderMax>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x27F8D0 Offset: 0x27F9D1 VA: 0x27F8D0
	private List<IMenuElement> <Items>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x27F8E0 Offset: 0x27F9E1 VA: 0x27F8E0
	private Vector2 <Scroll>k__BackingField; // 0x58
	private readonly int WindowSpace; // 0x60

	// Properties
	public virtual string Name { get; set; }
	protected virtual Color FontColor { get; set; }
	protected abstract IMenuElement.DisplayType DispType { get; }
	public abstract float Height { get; }
	protected virtual bool HasCallback { get; }
	internal virtual string Value { get; set; }
	protected int Select { get; set; }
	protected bool SubSelect { get; set; }
	protected int LastSelect { get; set; }
	protected virtual float SliderMin { get; }
	protected virtual float SliderMax { get; }
	protected virtual List<IMenuElement> Items { get; set; }
	private Vector2 Scroll { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7790 Offset: 0x2A7891 VA: 0x2A7790
	// RVA: 0x2C42A50 Offset: 0x2C42B51 VA: 0x2C42A50 Slot: 4
	public virtual string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A77A0 Offset: 0x2A78A1 VA: 0x2A77A0
	// RVA: 0x2C42A60 Offset: 0x2C42B61 VA: 0x2C42A60 Slot: 5
	public virtual void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A77B0 Offset: 0x2A78B1 VA: 0x2A77B0
	// RVA: 0x2C42A70 Offset: 0x2C42B71 VA: 0x2C42A70 Slot: 6
	protected virtual Color get_FontColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A77C0 Offset: 0x2A78C1 VA: 0x2A77C0
	// RVA: 0x2C42A80 Offset: 0x2C42B81 VA: 0x2C42A80 Slot: 7
	protected virtual void set_FontColor(Color value) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract IMenuElement.DisplayType get_DispType();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract float get_Height();

	[CompilerGeneratedAttribute] // RVA: 0x2A77D0 Offset: 0x2A78D1 VA: 0x2A77D0
	// RVA: 0x2C42AA0 Offset: 0x2C42BA1 VA: 0x2C42AA0 Slot: 10
	protected virtual bool get_HasCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A77E0 Offset: 0x2A78E1 VA: 0x2A77E0
	// RVA: 0x2C42AB0 Offset: 0x2C42BB1 VA: 0x2C42AB0 Slot: 11
	internal virtual string get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A77F0 Offset: 0x2A78F1 VA: 0x2A77F0
	// RVA: 0x2C42AC0 Offset: 0x2C42BC1 VA: 0x2C42AC0 Slot: 12
	internal virtual void set_Value(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7800 Offset: 0x2A7901 VA: 0x2A7800
	// RVA: 0x2C42AD0 Offset: 0x2C42BD1 VA: 0x2C42AD0
	protected int get_Select() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7810 Offset: 0x2A7911 VA: 0x2A7810
	// RVA: 0x2C42AE0 Offset: 0x2C42BE1 VA: 0x2C42AE0
	protected void set_Select(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7820 Offset: 0x2A7921 VA: 0x2A7820
	// RVA: 0x2C42AF0 Offset: 0x2C42BF1 VA: 0x2C42AF0
	protected bool get_SubSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7830 Offset: 0x2A7931 VA: 0x2A7830
	// RVA: 0x2C42B00 Offset: 0x2C42C01 VA: 0x2C42B00
	protected void set_SubSelect(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7840 Offset: 0x2A7941 VA: 0x2A7840
	// RVA: 0x2C42B10 Offset: 0x2C42C11 VA: 0x2C42B10
	protected int get_LastSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7850 Offset: 0x2A7951 VA: 0x2A7850
	// RVA: 0x2C42B20 Offset: 0x2C42C21 VA: 0x2C42B20
	protected void set_LastSelect(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7860 Offset: 0x2A7961 VA: 0x2A7860
	// RVA: 0x2C42B30 Offset: 0x2C42C31 VA: 0x2C42B30 Slot: 13
	protected virtual float get_SliderMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7870 Offset: 0x2A7971 VA: 0x2A7870
	// RVA: 0x2C42B40 Offset: 0x2C42C41 VA: 0x2C42B40 Slot: 14
	protected virtual float get_SliderMax() { }

	// RVA: 0x2C42B50 Offset: 0x2C42C51 VA: 0x2C42B50 Slot: 15
	public virtual bool Up() { }

	// RVA: 0x2C42C90 Offset: 0x2C42D91 VA: 0x2C42C90 Slot: 16
	public virtual bool Down() { }

	// RVA: 0x2C42DD0 Offset: 0x2C42ED1 VA: 0x2C42DD0 Slot: 17
	public virtual bool Right() { }

	// RVA: 0x2C42EF0 Offset: 0x2C42FF1 VA: 0x2C42EF0 Slot: 18
	public virtual bool Left() { }

	// RVA: 0x2C43010 Offset: 0x2C43111 VA: 0x2C43010
	public void PushA() { }

	// RVA: 0x2C43200 Offset: 0x2C43301 VA: 0x2C43200
	public void PushB() { }

	// RVA: 0x2C43330 Offset: 0x2C43431 VA: 0x2C43330
	public Type GetActiveMenuType() { }

	// RVA: 0x2C433E0 Offset: 0x2C434E1 VA: 0x2C433E0 Slot: 19
	public virtual void Tick() { }

	// RVA: 0x2C43500 Offset: 0x2C43601 VA: 0x2C43500 Slot: 20
	protected virtual void Update() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7880 Offset: 0x2A7981 VA: 0x2A7880
	// RVA: 0x2C43510 Offset: 0x2C43611 VA: 0x2C43510 Slot: 21
	protected virtual List<IMenuElement> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7890 Offset: 0x2A7991 VA: 0x2A7890
	// RVA: 0x2C43520 Offset: 0x2C43621 VA: 0x2C43520 Slot: 22
	protected virtual void set_Items(List<IMenuElement> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A78A0 Offset: 0x2A79A1 VA: 0x2A78A0
	// RVA: 0x2C43530 Offset: 0x2C43631 VA: 0x2C43530
	private Vector2 get_Scroll() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A78B0 Offset: 0x2A79B1 VA: 0x2A78B0
	// RVA: 0x2C43540 Offset: 0x2C43641 VA: 0x2C43540
	private void set_Scroll(Vector2 value) { }

	// RVA: 0x2C43550 Offset: 0x2C43651 VA: 0x2C43550
	public void Draw(int id, bool isForcus, int width = -1) { }

	// RVA: 0x2C43930 Offset: 0x2C43A31 VA: 0x2C43930
	private void DrawWindowImpl(bool isForcus, GUILayout.ScrollViewScope svs, int windowWidth, out float wihdowTop, out float windowBottom) { }

	// RVA: 0x2C44EB0 Offset: 0x2C44FB1 VA: 0x2C44EB0
	protected void .ctor() { }
}

