// Namespace: 
public class DebugUI.Container : DebugUI.Widget, DebugUI.IContainer // TypeDefIndex: 4556
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CAD0 Offset: 0x3CBD1 VA: 0x3CAD0
	private ObservableList<DebugUI.Widget> <children>k__BackingField; // 0x38

	// Properties
	public ObservableList<DebugUI.Widget> children { get; set; }
	public override DebugUI.Panel panel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D790 Offset: 0x3D891 VA: 0x3D790
	// RVA: 0x354F780 Offset: 0x354F881 VA: 0x354F780 Slot: 12
	public ObservableList<DebugUI.Widget> get_children() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D7A0 Offset: 0x3D8A1 VA: 0x3D7A0
	// RVA: 0x354F790 Offset: 0x354F891 VA: 0x354F790
	private void set_children(ObservableList<DebugUI.Widget> value) { }

	// RVA: 0x354F7A0 Offset: 0x354F8A1 VA: 0x354F7A0 Slot: 4
	public override DebugUI.Panel get_panel() { }

	// RVA: 0x354F7B0 Offset: 0x354F8B1 VA: 0x354F7B0 Slot: 5
	internal override void set_panel(DebugUI.Panel value) { }

	// RVA: 0x354FA00 Offset: 0x354FB01 VA: 0x354FA00
	public void .ctor() { }

	// RVA: 0x354FB90 Offset: 0x354FC91 VA: 0x354FB90
	public void .ctor(string displayName, ObservableList<DebugUI.Widget> children) { }

	// RVA: 0x354FCC0 Offset: 0x354FDC1 VA: 0x354FCC0 Slot: 11
	internal override void GenerateQueryPath() { }

	// RVA: 0x3550010 Offset: 0x3550111 VA: 0x3550010 Slot: 16
	protected virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x35502D0 Offset: 0x35503D1 VA: 0x35502D0 Slot: 17
	protected virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x3550330 Offset: 0x3550431 VA: 0x3550330 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
public class DebugUI.Foldout : DebugUI.Container, DebugUI.IValueField // TypeDefIndex: 4557
{
	// Fields
	public bool opened; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x3CAE0 Offset: 0x3CBE1 VA: 0x3CAE0
	private string[] <columnLabels>k__BackingField; // 0x48

	// Properties
	public bool isReadOnly { get; }
	public string[] columnLabels { get; set; }

	// Methods

	// RVA: 0x3550E30 Offset: 0x3550F31 VA: 0x3550E30
	public bool get_isReadOnly() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D7B0 Offset: 0x3D8B1 VA: 0x3D7B0
	// RVA: 0x3550E40 Offset: 0x3550F41 VA: 0x3550E40
	public string[] get_columnLabels() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D7C0 Offset: 0x3D8C1 VA: 0x3D7C0
	// RVA: 0x3550E50 Offset: 0x3550F51 VA: 0x3550E50
	public void set_columnLabels(string[] value) { }

	// RVA: 0x3550E60 Offset: 0x3550F61 VA: 0x3550E60
	public void .ctor() { }

	// RVA: 0x3550E70 Offset: 0x3550F71 VA: 0x3550E70
	public void .ctor(string displayName, ObservableList<DebugUI.Widget> children, string[] columnLabels) { }

	// RVA: 0x3550EA0 Offset: 0x3550FA1 VA: 0x3550EA0
	public bool GetValue() { }

	// RVA: 0x3550EB0 Offset: 0x3550FB1 VA: 0x3550EB0 Slot: 18
	private object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

	// RVA: 0x3550F10 Offset: 0x3551011 VA: 0x3550F10 Slot: 19
	public void SetValue(object value) { }

	// RVA: 0x3550FA0 Offset: 0x35510A1 VA: 0x3550FA0 Slot: 20
	public object ValidateValue(object value) { }

	// RVA: 0x3550FB0 Offset: 0x35510B1 VA: 0x3550FB0
	public void SetValue(bool value) { }
}

// Namespace: 
public class DebugUI.HBox : DebugUI.Container // TypeDefIndex: 4558
{
	// Methods

	// RVA: 0x3550FC0 Offset: 0x35510C1 VA: 0x3550FC0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.VBox : DebugUI.Container // TypeDefIndex: 4559
{
	// Methods

	// RVA: 0x35520C0 Offset: 0x35521C1 VA: 0x35520C0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Table.Row : DebugUI.Foldout // TypeDefIndex: 4560
{
	// Methods

	// RVA: 0x3553FC0 Offset: 0x35540C1 VA: 0x3553FC0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Table : DebugUI.Container // TypeDefIndex: 4561
{
	// Fields
	public bool isReadOnly; // 0x40
	private bool[] m_Header; // 0x48

	// Properties
	public bool[] VisibleColumns { get; }

	// Methods

	// RVA: 0x3551B70 Offset: 0x3551C71 VA: 0x3551B70
	public void .ctor() { }

	// RVA: 0x3551BD0 Offset: 0x3551CD1 VA: 0x3551BD0
	public void SetColumnVisibility(int index, bool visible) { }

	// RVA: 0x3551E70 Offset: 0x3551F71 VA: 0x3551E70
	public bool GetColumnVisibility(int index) { }

	// RVA: 0x3551C20 Offset: 0x3551D21 VA: 0x3551C20
	public bool[] get_VisibleColumns() { }

	// RVA: 0x3551ED0 Offset: 0x3551FD1 VA: 0x3551ED0 Slot: 16
	protected override void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x3551F40 Offset: 0x3552041 VA: 0x3551F40 Slot: 17
	protected override void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }
}

// Namespace: 
public abstract class DebugUI.Field<T> : DebugUI.Widget, DebugUI.IValueField // TypeDefIndex: 4562
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CAF0 Offset: 0x3CBF1 VA: 0x3CAF0
	private Func<T> <getter>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CB00 Offset: 0x3CC01 VA: 0x3CB00
	private Action<T> <setter>k__BackingField; // 0x0
	public Action<DebugUI.Field<T>, T> onValueChanged; // 0x0

	// Properties
	public Func<T> getter { get; set; }
	public Action<T> setter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D7D0 Offset: 0x3D8D1 VA: 0x3D7D0
	// RVA: -1 Offset: -1
	public Func<T> get_getter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1710 Offset: 0x33D1811 VA: 0x33D1710
	|-DebugUI.Field<bool>.get_getter
	|
	|-RVA: 0x33D1A90 Offset: 0x33D1B91 VA: 0x33D1A90
	|-DebugUI.Field<Color>.get_getter
	|
	|-RVA: 0x33D1E40 Offset: 0x33D1F41 VA: 0x33D1E40
	|-DebugUI.Field<int>.get_getter
	|
	|-RVA: 0x33D21A0 Offset: 0x33D22A1 VA: 0x33D21A0
	|-DebugUI.Field<object>.get_getter
	|
	|-RVA: 0x33D2460 Offset: 0x33D2561 VA: 0x33D2460
	|-DebugUI.Field<float>.get_getter
	|
	|-RVA: 0x33D27C0 Offset: 0x33D28C1 VA: 0x33D27C0
	|-DebugUI.Field<uint>.get_getter
	|
	|-RVA: 0x33D2B20 Offset: 0x33D2C21 VA: 0x33D2B20
	|-DebugUI.Field<Vector2>.get_getter
	|
	|-RVA: 0x33D2E90 Offset: 0x33D2F91 VA: 0x33D2E90
	|-DebugUI.Field<Vector3>.get_getter
	|
	|-RVA: 0x33D3240 Offset: 0x33D3341 VA: 0x33D3240
	|-DebugUI.Field<Vector4>.get_getter
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D7E0 Offset: 0x3D8E1 VA: 0x3D7E0
	// RVA: -1 Offset: -1
	public void set_getter(Func<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1720 Offset: 0x33D1821 VA: 0x33D1720
	|-DebugUI.Field<bool>.set_getter
	|
	|-RVA: 0x33D1AA0 Offset: 0x33D1BA1 VA: 0x33D1AA0
	|-DebugUI.Field<Color>.set_getter
	|
	|-RVA: 0x33D1E50 Offset: 0x33D1F51 VA: 0x33D1E50
	|-DebugUI.Field<int>.set_getter
	|
	|-RVA: 0x33D21B0 Offset: 0x33D22B1 VA: 0x33D21B0
	|-DebugUI.Field<object>.set_getter
	|
	|-RVA: 0x33D2470 Offset: 0x33D2571 VA: 0x33D2470
	|-DebugUI.Field<float>.set_getter
	|
	|-RVA: 0x33D27D0 Offset: 0x33D28D1 VA: 0x33D27D0
	|-DebugUI.Field<uint>.set_getter
	|
	|-RVA: 0x33D2B30 Offset: 0x33D2C31 VA: 0x33D2B30
	|-DebugUI.Field<Vector2>.set_getter
	|
	|-RVA: 0x33D2EA0 Offset: 0x33D2FA1 VA: 0x33D2EA0
	|-DebugUI.Field<Vector3>.set_getter
	|
	|-RVA: 0x33D3250 Offset: 0x33D3351 VA: 0x33D3250
	|-DebugUI.Field<Vector4>.set_getter
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D7F0 Offset: 0x3D8F1 VA: 0x3D7F0
	// RVA: -1 Offset: -1
	public Action<T> get_setter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1730 Offset: 0x33D1831 VA: 0x33D1730
	|-DebugUI.Field<bool>.get_setter
	|
	|-RVA: 0x33D1AB0 Offset: 0x33D1BB1 VA: 0x33D1AB0
	|-DebugUI.Field<Color>.get_setter
	|
	|-RVA: 0x33D1E60 Offset: 0x33D1F61 VA: 0x33D1E60
	|-DebugUI.Field<int>.get_setter
	|
	|-RVA: 0x33D21C0 Offset: 0x33D22C1 VA: 0x33D21C0
	|-DebugUI.Field<object>.get_setter
	|
	|-RVA: 0x33D2480 Offset: 0x33D2581 VA: 0x33D2480
	|-DebugUI.Field<float>.get_setter
	|
	|-RVA: 0x33D27E0 Offset: 0x33D28E1 VA: 0x33D27E0
	|-DebugUI.Field<uint>.get_setter
	|
	|-RVA: 0x33D2B40 Offset: 0x33D2C41 VA: 0x33D2B40
	|-DebugUI.Field<Vector2>.get_setter
	|
	|-RVA: 0x33D2EB0 Offset: 0x33D2FB1 VA: 0x33D2EB0
	|-DebugUI.Field<Vector3>.get_setter
	|
	|-RVA: 0x33D3260 Offset: 0x33D3361 VA: 0x33D3260
	|-DebugUI.Field<Vector4>.get_setter
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D800 Offset: 0x3D901 VA: 0x3D800
	// RVA: -1 Offset: -1
	public void set_setter(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1740 Offset: 0x33D1841 VA: 0x33D1740
	|-DebugUI.Field<bool>.set_setter
	|
	|-RVA: 0x33D1AC0 Offset: 0x33D1BC1 VA: 0x33D1AC0
	|-DebugUI.Field<Color>.set_setter
	|
	|-RVA: 0x33D1E70 Offset: 0x33D1F71 VA: 0x33D1E70
	|-DebugUI.Field<int>.set_setter
	|
	|-RVA: 0x33D21D0 Offset: 0x33D22D1 VA: 0x33D21D0
	|-DebugUI.Field<object>.set_setter
	|
	|-RVA: 0x33D2490 Offset: 0x33D2591 VA: 0x33D2490
	|-DebugUI.Field<float>.set_setter
	|
	|-RVA: 0x33D27F0 Offset: 0x33D28F1 VA: 0x33D27F0
	|-DebugUI.Field<uint>.set_setter
	|
	|-RVA: 0x33D2B50 Offset: 0x33D2C51 VA: 0x33D2B50
	|-DebugUI.Field<Vector2>.set_setter
	|
	|-RVA: 0x33D2EC0 Offset: 0x33D2FC1 VA: 0x33D2EC0
	|-DebugUI.Field<Vector3>.set_setter
	|
	|-RVA: 0x33D3270 Offset: 0x33D3371 VA: 0x33D3270
	|-DebugUI.Field<Vector4>.set_setter
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1750 Offset: 0x33D1851 VA: 0x33D1750
	|-DebugUI.Field<bool>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D1AD0 Offset: 0x33D1BD1 VA: 0x33D1AD0
	|-DebugUI.Field<Color>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D21E0 Offset: 0x33D22E1 VA: 0x33D21E0
	|-DebugUI.Field<Enum>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|-DebugUI.Field<object>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D1E80 Offset: 0x33D1F81 VA: 0x33D1E80
	|-DebugUI.Field<int>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D24A0 Offset: 0x33D25A1 VA: 0x33D24A0
	|-DebugUI.Field<float>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D2800 Offset: 0x33D2901 VA: 0x33D2800
	|-DebugUI.Field<uint>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D2B60 Offset: 0x33D2C61 VA: 0x33D2B60
	|-DebugUI.Field<Vector2>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D2ED0 Offset: 0x33D2FD1 VA: 0x33D2ED0
	|-DebugUI.Field<Vector3>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x33D3280 Offset: 0x33D3381 VA: 0x33D3280
	|-DebugUI.Field<Vector4>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T ValidateValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1820 Offset: 0x33D1921 VA: 0x33D1820
	|-DebugUI.Field<bool>.ValidateValue
	|
	|-RVA: 0x33D1BA0 Offset: 0x33D1CA1 VA: 0x33D1BA0
	|-DebugUI.Field<Color>.ValidateValue
	|
	|-RVA: 0x33D2260 Offset: 0x33D2361 VA: 0x33D2260
	|-DebugUI.Field<Enum>.ValidateValue
	|-DebugUI.Field<object>.ValidateValue
	|
	|-RVA: 0x33D1F40 Offset: 0x33D2041 VA: 0x33D1F40
	|-DebugUI.Field<int>.ValidateValue
	|
	|-RVA: 0x33D2560 Offset: 0x33D2661 VA: 0x33D2560
	|-DebugUI.Field<float>.ValidateValue
	|
	|-RVA: 0x33D28C0 Offset: 0x33D29C1 VA: 0x33D28C0
	|-DebugUI.Field<uint>.ValidateValue
	|
	|-RVA: 0x33D2C20 Offset: 0x33D2D21 VA: 0x33D2C20
	|-DebugUI.Field<Vector2>.ValidateValue
	|
	|-RVA: 0x33D2FA0 Offset: 0x33D30A1 VA: 0x33D2FA0
	|-DebugUI.Field<Vector3>.ValidateValue
	|
	|-RVA: 0x33D3350 Offset: 0x33D3451 VA: 0x33D3350
	|-DebugUI.Field<Vector4>.ValidateValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1830 Offset: 0x33D1931 VA: 0x33D1830
	|-DebugUI.Field<bool>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D1BB0 Offset: 0x33D1CB1 VA: 0x33D1BB0
	|-DebugUI.Field<Color>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D2270 Offset: 0x33D2371 VA: 0x33D2270
	|-DebugUI.Field<Enum>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|-DebugUI.Field<object>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D1F50 Offset: 0x33D2051 VA: 0x33D1F50
	|-DebugUI.Field<int>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D2570 Offset: 0x33D2671 VA: 0x33D2570
	|-DebugUI.Field<float>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D28D0 Offset: 0x33D29D1 VA: 0x33D28D0
	|-DebugUI.Field<uint>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D2C30 Offset: 0x33D2D31 VA: 0x33D2C30
	|-DebugUI.Field<Vector2>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D2FB0 Offset: 0x33D30B1 VA: 0x33D2FB0
	|-DebugUI.Field<Vector3>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x33D3360 Offset: 0x33D3461 VA: 0x33D3360
	|-DebugUI.Field<Vector4>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	*/

	// RVA: -1 Offset: -1
	public T GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1890 Offset: 0x33D1991 VA: 0x33D1890
	|-DebugUI.Field<bool>.GetValue
	|
	|-RVA: 0x33D1C20 Offset: 0x33D1D21 VA: 0x33D1C20
	|-DebugUI.Field<Color>.GetValue
	|
	|-RVA: 0x33D2290 Offset: 0x33D2391 VA: 0x33D2290
	|-DebugUI.Field<Enum>.GetValue
	|-DebugUI.Field<object>.GetValue
	|
	|-RVA: 0x33D1FB0 Offset: 0x33D20B1 VA: 0x33D1FB0
	|-DebugUI.Field<int>.GetValue
	|
	|-RVA: 0x33D25D0 Offset: 0x33D26D1 VA: 0x33D25D0
	|-DebugUI.Field<float>.GetValue
	|
	|-RVA: 0x33D2930 Offset: 0x33D2A31 VA: 0x33D2930
	|-DebugUI.Field<uint>.GetValue
	|
	|-RVA: 0x33D2C90 Offset: 0x33D2D91 VA: 0x33D2C90
	|-DebugUI.Field<Vector2>.GetValue
	|
	|-RVA: 0x33D3020 Offset: 0x33D3121 VA: 0x33D3020
	|-DebugUI.Field<Vector3>.GetValue
	|
	|-RVA: 0x33D33D0 Offset: 0x33D34D1 VA: 0x33D33D0
	|-DebugUI.Field<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D18D0 Offset: 0x33D19D1 VA: 0x33D18D0
	|-DebugUI.Field<bool>.SetValue
	|
	|-RVA: 0x33D1C60 Offset: 0x33D1D61 VA: 0x33D1C60
	|-DebugUI.Field<Color>.SetValue
	|
	|-RVA: 0x33D22D0 Offset: 0x33D23D1 VA: 0x33D22D0
	|-DebugUI.Field<Enum>.SetValue
	|-DebugUI.Field<object>.SetValue
	|
	|-RVA: 0x33D1FF0 Offset: 0x33D20F1 VA: 0x33D1FF0
	|-DebugUI.Field<int>.SetValue
	|
	|-RVA: 0x33D2610 Offset: 0x33D2711 VA: 0x33D2610
	|-DebugUI.Field<float>.SetValue
	|
	|-RVA: 0x33D2970 Offset: 0x33D2A71 VA: 0x33D2970
	|-DebugUI.Field<uint>.SetValue
	|
	|-RVA: 0x33D2CD0 Offset: 0x33D2DD1 VA: 0x33D2CD0
	|-DebugUI.Field<Vector2>.SetValue
	|
	|-RVA: 0x33D3060 Offset: 0x33D3161 VA: 0x33D3060
	|-DebugUI.Field<Vector3>.SetValue
	|
	|-RVA: 0x33D3410 Offset: 0x33D3511 VA: 0x33D3410
	|-DebugUI.Field<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1
	public void SetValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1970 Offset: 0x33D1A71 VA: 0x33D1970
	|-DebugUI.Field<bool>.SetValue
	|
	|-RVA: 0x33D1D10 Offset: 0x33D1E11 VA: 0x33D1D10
	|-DebugUI.Field<Color>.SetValue
	|
	|-RVA: 0x33D2090 Offset: 0x33D2191 VA: 0x33D2090
	|-DebugUI.Field<int>.SetValue
	|
	|-RVA: 0x33D2370 Offset: 0x33D2471 VA: 0x33D2370
	|-DebugUI.Field<object>.SetValue
	|
	|-RVA: 0x33D26B0 Offset: 0x33D27B1 VA: 0x33D26B0
	|-DebugUI.Field<float>.SetValue
	|
	|-RVA: 0x33D2A10 Offset: 0x33D2B11 VA: 0x33D2A10
	|-DebugUI.Field<uint>.SetValue
	|
	|-RVA: 0x33D2D70 Offset: 0x33D2E71 VA: 0x33D2D70
	|-DebugUI.Field<Vector2>.SetValue
	|
	|-RVA: 0x33D3110 Offset: 0x33D3211 VA: 0x33D3110
	|-DebugUI.Field<Vector3>.SetValue
	|
	|-RVA: 0x33D34C0 Offset: 0x33D35C1 VA: 0x33D34C0
	|-DebugUI.Field<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1A80 Offset: 0x33D1B81 VA: 0x33D1A80
	|-DebugUI.Field<bool>..ctor
	|
	|-RVA: 0x33D1E30 Offset: 0x33D1F31 VA: 0x33D1E30
	|-DebugUI.Field<Color>..ctor
	|
	|-RVA: 0x33D2450 Offset: 0x33D2551 VA: 0x33D2450
	|-DebugUI.Field<Enum>..ctor
	|-DebugUI.Field<object>..ctor
	|
	|-RVA: 0x33D2190 Offset: 0x33D2291 VA: 0x33D2190
	|-DebugUI.Field<int>..ctor
	|
	|-RVA: 0x33D27B0 Offset: 0x33D28B1 VA: 0x33D27B0
	|-DebugUI.Field<float>..ctor
	|
	|-RVA: 0x33D2B10 Offset: 0x33D2C11 VA: 0x33D2B10
	|-DebugUI.Field<uint>..ctor
	|
	|-RVA: 0x33D2E80 Offset: 0x33D2F81 VA: 0x33D2E80
	|-DebugUI.Field<Vector2>..ctor
	|
	|-RVA: 0x33D3230 Offset: 0x33D3331 VA: 0x33D3230
	|-DebugUI.Field<Vector3>..ctor
	|
	|-RVA: 0x33D35E0 Offset: 0x33D36E1 VA: 0x33D35E0
	|-DebugUI.Field<Vector4>..ctor
	*/
}

// Namespace: 
public class DebugUI.BoolField : DebugUI.Field<bool> // TypeDefIndex: 4563
{
	// Methods

	// RVA: 0x354F5D0 Offset: 0x354F6D1 VA: 0x354F5D0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.HistoryBoolField : DebugUI.BoolField // TypeDefIndex: 4564
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CB10 Offset: 0x3CC11 VA: 0x3CB10
	private Func<bool>[] <historyGetter>k__BackingField; // 0x50

	// Properties
	public Func<bool>[] historyGetter { get; set; }
	public int historyDepth { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D810 Offset: 0x3D911 VA: 0x3D810
	// RVA: 0x3551020 Offset: 0x3551121 VA: 0x3551020
	public Func<bool>[] get_historyGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D820 Offset: 0x3D921 VA: 0x3D820
	// RVA: 0x3551030 Offset: 0x3551131 VA: 0x3551030
	public void set_historyGetter(Func<bool>[] value) { }

	// RVA: 0x3551040 Offset: 0x3551141 VA: 0x3551040
	public int get_historyDepth() { }

	// RVA: 0x3551060 Offset: 0x3551161 VA: 0x3551060
	public bool GetHistoryValue(int historyIndex) { }

	// RVA: 0x35510E0 Offset: 0x35511E1 VA: 0x35510E0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.IntField : DebugUI.Field<int> // TypeDefIndex: 4565
{
	// Fields
	public Func<int> min; // 0x50
	public Func<int> max; // 0x58
	public int incStep; // 0x60
	public int intStepMult; // 0x64

	// Methods

	// RVA: 0x3551260 Offset: 0x3551361 VA: 0x3551260 Slot: 15
	public override int ValidateValue(int value) { }

	// RVA: 0x3551310 Offset: 0x3551411 VA: 0x3551310
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.UIntField : DebugUI.Field<uint> // TypeDefIndex: 4566
{
	// Fields
	public Func<uint> min; // 0x50
	public Func<uint> max; // 0x58
	public uint incStep; // 0x60
	public uint intStepMult; // 0x64

	// Methods

	// RVA: 0x3551FB0 Offset: 0x35520B1 VA: 0x3551FB0 Slot: 15
	public override uint ValidateValue(uint value) { }

	// RVA: 0x3552060 Offset: 0x3552161 VA: 0x3552060
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.FloatField : DebugUI.Field<float> // TypeDefIndex: 4567
{
	// Fields
	public Func<float> min; // 0x50
	public Func<float> max; // 0x58
	public float incStep; // 0x60
	public float incStepMult; // 0x64
	public int decimals; // 0x68

	// Methods

	// RVA: 0x3550D10 Offset: 0x3550E11 VA: 0x3550D10 Slot: 15
	public override float ValidateValue(float value) { }

	// RVA: 0x3550DC0 Offset: 0x3550EC1 VA: 0x3550DC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3B5E0 Offset: 0x3B6E1 VA: 0x3B5E0
[Serializable]
private sealed class DebugUI.EnumField.<>c // TypeDefIndex: 4568
{
	// Fields
	public static readonly DebugUI.EnumField.<>c <>9; // 0x0
	public static Func<string, GUIContent> <>9__16_0; // 0x8
	public static Func<GUIContent, string> <>9__17_0; // 0x10

	// Methods

	// RVA: 0x3553D70 Offset: 0x3553E71 VA: 0x3553D70
	private static void .cctor() { }

	// RVA: 0x3553DE0 Offset: 0x3553EE1 VA: 0x3553DE0
	public void .ctor() { }

	// RVA: 0x3553DF0 Offset: 0x3553EF1 VA: 0x3553DF0
	internal GUIContent <set_autoEnum>b__16_0(string x) { }

	// RVA: 0x3553E60 Offset: 0x3553F61 VA: 0x3553E60
	internal string <InitQuickSeparators>b__17_0(GUIContent x) { }
}

// Namespace: 
public class DebugUI.EnumField : DebugUI.Field<int> // TypeDefIndex: 4569
{
	// Fields
	public GUIContent[] enumNames; // 0x50
	public int[] enumValues; // 0x58
	internal int[] quickSeparators; // 0x60
	internal int[] indexes; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x3CB20 Offset: 0x3CC21 VA: 0x3CB20
	private Func<int> <getIndex>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x3CB30 Offset: 0x3CC31 VA: 0x3CB30
	private Action<int> <setIndex>k__BackingField; // 0x78

	// Properties
	public Func<int> getIndex { get; set; }
	public Action<int> setIndex { get; set; }
	public int currentIndex { get; set; }
	public Type autoEnum { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D830 Offset: 0x3D931 VA: 0x3D830
	// RVA: 0x35505A0 Offset: 0x35506A1 VA: 0x35505A0
	public Func<int> get_getIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D840 Offset: 0x3D941 VA: 0x3D840
	// RVA: 0x35505B0 Offset: 0x35506B1 VA: 0x35505B0
	public void set_getIndex(Func<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D850 Offset: 0x3D951 VA: 0x3D850
	// RVA: 0x35505C0 Offset: 0x35506C1 VA: 0x35505C0
	public Action<int> get_setIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D860 Offset: 0x3D961 VA: 0x3D860
	// RVA: 0x35505D0 Offset: 0x35506D1 VA: 0x35505D0
	public void set_setIndex(Action<int> value) { }

	// RVA: 0x35505E0 Offset: 0x35506E1 VA: 0x35505E0
	public int get_currentIndex() { }

	// RVA: 0x3550640 Offset: 0x3550741 VA: 0x3550640
	public void set_currentIndex(int value) { }

	// RVA: 0x35506A0 Offset: 0x35507A1 VA: 0x35506A0
	public void set_autoEnum(Type value) { }

	// RVA: 0x3550A60 Offset: 0x3550B61 VA: 0x3550A60
	internal void InitQuickSeparators() { }

	// RVA: 0x3550960 Offset: 0x3550A61 VA: 0x3550960
	internal void InitIndexes() { }

	// RVA: 0x3550CB0 Offset: 0x3550DB1 VA: 0x3550CB0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.HistoryEnumField : DebugUI.EnumField // TypeDefIndex: 4570
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CB40 Offset: 0x3CC41 VA: 0x3CB40
	private Func<int>[] <historyIndexGetter>k__BackingField; // 0x80

	// Properties
	public Func<int>[] historyIndexGetter { get; set; }
	public int historyDepth { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D870 Offset: 0x3D971 VA: 0x3D870
	// RVA: 0x3551140 Offset: 0x3551241 VA: 0x3551140
	public Func<int>[] get_historyIndexGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D880 Offset: 0x3D981 VA: 0x3D880
	// RVA: 0x3551150 Offset: 0x3551251 VA: 0x3551150
	public void set_historyIndexGetter(Func<int>[] value) { }

	// RVA: 0x3551160 Offset: 0x3551261 VA: 0x3551160
	public int get_historyDepth() { }

	// RVA: 0x3551180 Offset: 0x3551281 VA: 0x3551180
	public int GetHistoryValue(int historyIndex) { }

	// RVA: 0x3551200 Offset: 0x3551301 VA: 0x3551200
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3B5F0 Offset: 0x3B6F1 VA: 0x3B5F0
[Serializable]
private sealed class DebugUI.BitField.<>c // TypeDefIndex: 4571
{
	// Fields
	public static readonly DebugUI.BitField.<>c <>9; // 0x0
	public static Func<string, GUIContent> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x3553C80 Offset: 0x3553D81 VA: 0x3553C80
	private static void .cctor() { }

	// RVA: 0x3553CF0 Offset: 0x3553DF1 VA: 0x3553CF0
	public void .ctor() { }

	// RVA: 0x3553D00 Offset: 0x3553E01 VA: 0x3553D00
	internal GUIContent <set_enumType>b__10_0(string x) { }
}

// Namespace: 
public class DebugUI.BitField : DebugUI.Field<Enum> // TypeDefIndex: 4572
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CB50 Offset: 0x3CC51 VA: 0x3CB50
	private GUIContent[] <enumNames>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x3CB60 Offset: 0x3CC61 VA: 0x3CB60
	private int[] <enumValues>k__BackingField; // 0x58
	internal Type m_EnumType; // 0x60

	// Properties
	public GUIContent[] enumNames { get; set; }
	public int[] enumValues { get; set; }
	public Type enumType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D890 Offset: 0x3D991 VA: 0x3D890
	// RVA: 0x354F260 Offset: 0x354F361 VA: 0x354F260
	public GUIContent[] get_enumNames() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D8A0 Offset: 0x3D9A1 VA: 0x3D8A0
	// RVA: 0x354F270 Offset: 0x354F371 VA: 0x354F270
	private void set_enumNames(GUIContent[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D8B0 Offset: 0x3D9B1 VA: 0x3D8B0
	// RVA: 0x354F280 Offset: 0x354F381 VA: 0x354F280
	public int[] get_enumValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D8C0 Offset: 0x3D9C1 VA: 0x3D8C0
	// RVA: 0x354F290 Offset: 0x354F391 VA: 0x354F290
	private void set_enumValues(int[] value) { }

	// RVA: 0x354F2A0 Offset: 0x354F3A1 VA: 0x354F2A0
	public void set_enumType(Type value) { }

	// RVA: 0x354F560 Offset: 0x354F661 VA: 0x354F560
	public Type get_enumType() { }

	// RVA: 0x354F570 Offset: 0x354F671 VA: 0x354F570
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.ColorField : DebugUI.Field<Color> // TypeDefIndex: 4573
{
	// Fields
	public bool hdr; // 0x50
	public bool showAlpha; // 0x51
	public bool showPicker; // 0x52
	public float incStep; // 0x54
	public float incStepMult; // 0x58
	public int decimals; // 0x5C

	// Methods

	// RVA: 0x354F670 Offset: 0x354F771 VA: 0x354F670 Slot: 15
	public override Color ValidateValue(Color value) { }

	// RVA: 0x354F700 Offset: 0x354F801 VA: 0x354F700
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector2Field : DebugUI.Field<Vector2> // TypeDefIndex: 4574
{
	// Fields
	public float incStep; // 0x50
	public float incStepMult; // 0x54
	public int decimals; // 0x58

	// Methods

	// RVA: 0x3552210 Offset: 0x3552311 VA: 0x3552210
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector3Field : DebugUI.Field<Vector3> // TypeDefIndex: 4575
{
	// Fields
	public float incStep; // 0x50
	public float incStepMult; // 0x54
	public int decimals; // 0x58

	// Methods

	// RVA: 0x3552280 Offset: 0x3552381 VA: 0x3552280
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector4Field : DebugUI.Field<Vector4> // TypeDefIndex: 4576
{
	// Fields
	public float incStep; // 0x50
	public float incStepMult; // 0x54
	public int decimals; // 0x58

	// Methods

	// RVA: 0x35522F0 Offset: 0x35523F1 VA: 0x35522F0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3B600 Offset: 0x3B701 VA: 0x3B600
[Serializable]
private sealed class DebugUI.Panel.<>c // TypeDefIndex: 4577
{
	// Fields
	public static readonly DebugUI.Panel.<>c <>9; // 0x0
	public static Action<DebugUI.Panel> <>9__29_0; // 0x8

	// Methods

	// RVA: 0x3553F30 Offset: 0x3554031 VA: 0x3553F30
	private static void .cctor() { }

	// RVA: 0x3553FA0 Offset: 0x35540A1 VA: 0x3553FA0
	public void .ctor() { }

	// RVA: 0x3553FB0 Offset: 0x35540B1 VA: 0x3553FB0
	internal void <.ctor>b__29_0(DebugUI.Panel <p0>) { }
}

// Namespace: 
public class DebugUI.Panel : DebugUI.IContainer, IComparable<DebugUI.Panel> // TypeDefIndex: 4578
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CB70 Offset: 0x3CC71 VA: 0x3CB70
	private DebugUI.Flags <flags>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3CB80 Offset: 0x3CC81 VA: 0x3CB80
	private string <displayName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3CB90 Offset: 0x3CC91 VA: 0x3CB90
	private int <groupIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x3CBA0 Offset: 0x3CCA1 VA: 0x3CBA0
	private ObservableList<DebugUI.Widget> <children>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x3CBB0 Offset: 0x3CCB1 VA: 0x3CBB0
	private Action<DebugUI.Panel> onSetDirty; // 0x30

	// Properties
	public DebugUI.Flags flags { get; set; }
	public string displayName { get; set; }
	public int groupIndex { get; set; }
	public string queryPath { get; }
	public bool isEditorOnly { get; }
	public bool isRuntimeOnly { get; }
	public bool isInactiveInEditor { get; }
	public bool editorForceUpdate { get; }
	public ObservableList<DebugUI.Widget> children { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D8D0 Offset: 0x3D9D1 VA: 0x3D8D0
	// RVA: 0x3551370 Offset: 0x3551471 VA: 0x3551370
	public DebugUI.Flags get_flags() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D8E0 Offset: 0x3D9E1 VA: 0x3D8E0
	// RVA: 0x3551380 Offset: 0x3551481 VA: 0x3551380
	public void set_flags(DebugUI.Flags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D8F0 Offset: 0x3D9F1 VA: 0x3D8F0
	// RVA: 0x3551390 Offset: 0x3551491 VA: 0x3551390 Slot: 5
	public string get_displayName() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D900 Offset: 0x3DA01 VA: 0x3D900
	// RVA: 0x35513A0 Offset: 0x35514A1 VA: 0x35513A0 Slot: 6
	public void set_displayName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D910 Offset: 0x3DA11 VA: 0x3D910
	// RVA: 0x35513B0 Offset: 0x35514B1 VA: 0x35513B0
	public int get_groupIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D920 Offset: 0x3DA21 VA: 0x3D920
	// RVA: 0x35513C0 Offset: 0x35514C1 VA: 0x35513C0
	public void set_groupIndex(int value) { }

	// RVA: 0x35513D0 Offset: 0x35514D1 VA: 0x35513D0 Slot: 7
	public string get_queryPath() { }

	// RVA: 0x35513E0 Offset: 0x35514E1 VA: 0x35513E0
	public bool get_isEditorOnly() { }

	// RVA: 0x35513F0 Offset: 0x35514F1 VA: 0x35513F0
	public bool get_isRuntimeOnly() { }

	// RVA: 0x3551400 Offset: 0x3551501 VA: 0x3551400
	public bool get_isInactiveInEditor() { }

	// RVA: 0x3551440 Offset: 0x3551541 VA: 0x3551440
	public bool get_editorForceUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D930 Offset: 0x3DA31 VA: 0x3D930
	// RVA: 0x3551450 Offset: 0x3551551 VA: 0x3551450 Slot: 4
	public ObservableList<DebugUI.Widget> get_children() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D940 Offset: 0x3DA41 VA: 0x3D940
	// RVA: 0x3551460 Offset: 0x3551561 VA: 0x3551460
	private void set_children(ObservableList<DebugUI.Widget> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D950 Offset: 0x3DA51 VA: 0x3D950
	// RVA: 0x3551470 Offset: 0x3551571 VA: 0x3551470
	public void add_onSetDirty(Action<DebugUI.Panel> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D960 Offset: 0x3DA61 VA: 0x3D960
	// RVA: 0x3551520 Offset: 0x3551621 VA: 0x3551520
	public void remove_onSetDirty(Action<DebugUI.Panel> value) { }

	// RVA: 0x35515D0 Offset: 0x35516D1 VA: 0x35515D0
	public void .ctor() { }

	// RVA: 0x3551810 Offset: 0x3551911 VA: 0x3551810 Slot: 9
	protected virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x3551860 Offset: 0x3551961 VA: 0x3551860 Slot: 10
	protected virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x3550070 Offset: 0x3550171 VA: 0x3550070
	public void SetDirty() { }

	// RVA: 0x35518B0 Offset: 0x35519B1 VA: 0x35518B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3551B20 Offset: 0x3551C21 VA: 0x3551B20 Slot: 8
	private int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(DebugUI.Panel other) { }
}

// Namespace: 
[FlagsAttribute] // RVA: 0x3B610 Offset: 0x3B711 VA: 0x3B610
public enum DebugUI.Flags // TypeDefIndex: 4579
{
	// Fields
	public int value__; // 0x0
	public const DebugUI.Flags None = 0;
	public const DebugUI.Flags EditorOnly = 2;
	public const DebugUI.Flags RuntimeOnly = 4;
	public const DebugUI.Flags EditorForceUpdate = 8;
}

// Namespace: 
public abstract class DebugUI.Widget // TypeDefIndex: 4580
{
	// Fields
	protected DebugUI.Panel m_Panel; // 0x10
	protected DebugUI.IContainer m_Parent; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3CBC0 Offset: 0x3CCC1 VA: 0x3CBC0
	private DebugUI.Flags <flags>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x3CBD0 Offset: 0x3CCD1 VA: 0x3CBD0
	private string <displayName>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x3CBE0 Offset: 0x3CCE1 VA: 0x3CBE0
	private string <queryPath>k__BackingField; // 0x30

	// Properties
	public virtual DebugUI.Panel panel { get; set; }
	public virtual DebugUI.IContainer parent { get; set; }
	public DebugUI.Flags flags { get; set; }
	public string displayName { get; set; }
	public string queryPath { get; set; }
	public bool isEditorOnly { get; }
	public bool isRuntimeOnly { get; }
	public bool isInactiveInEditor { get; }

	// Methods

	// RVA: 0x3552360 Offset: 0x3552461 VA: 0x3552360 Slot: 4
	public virtual DebugUI.Panel get_panel() { }

	// RVA: 0x3552370 Offset: 0x3552471 VA: 0x3552370 Slot: 5
	internal virtual void set_panel(DebugUI.Panel value) { }

	// RVA: 0x3552380 Offset: 0x3552481 VA: 0x3552380 Slot: 6
	public virtual DebugUI.IContainer get_parent() { }

	// RVA: 0x3552390 Offset: 0x3552491 VA: 0x3552390 Slot: 7
	internal virtual void set_parent(DebugUI.IContainer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D970 Offset: 0x3DA71 VA: 0x3D970
	// RVA: 0x35523A0 Offset: 0x35524A1 VA: 0x35523A0
	public DebugUI.Flags get_flags() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D980 Offset: 0x3DA81 VA: 0x3D980
	// RVA: 0x35523B0 Offset: 0x35524B1 VA: 0x35523B0
	public void set_flags(DebugUI.Flags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D990 Offset: 0x3DA91 VA: 0x3D990
	// RVA: 0x35523C0 Offset: 0x35524C1 VA: 0x35523C0 Slot: 8
	public string get_displayName() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D9A0 Offset: 0x3DAA1 VA: 0x3D9A0
	// RVA: 0x35523D0 Offset: 0x35524D1 VA: 0x35523D0 Slot: 9
	public void set_displayName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D9B0 Offset: 0x3DAB1 VA: 0x3D9B0
	// RVA: 0x35523E0 Offset: 0x35524E1 VA: 0x35523E0 Slot: 10
	public string get_queryPath() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D9C0 Offset: 0x3DAC1 VA: 0x3D9C0
	// RVA: 0x35523F0 Offset: 0x35524F1 VA: 0x35523F0
	private void set_queryPath(string value) { }

	// RVA: 0x3552400 Offset: 0x3552501 VA: 0x3552400
	public bool get_isEditorOnly() { }

	// RVA: 0x3552410 Offset: 0x3552511 VA: 0x3552410
	public bool get_isRuntimeOnly() { }

	// RVA: 0x3552420 Offset: 0x3552521 VA: 0x3552420
	public bool get_isInactiveInEditor() { }

	// RVA: 0x354FF00 Offset: 0x3550001 VA: 0x354FF00 Slot: 11
	internal virtual void GenerateQueryPath() { }

	// RVA: 0x3552460 Offset: 0x3552561 VA: 0x3552460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354F660 Offset: 0x354F761 VA: 0x354F660
	protected void .ctor() { }
}

// Namespace: 
public interface DebugUI.IContainer // TypeDefIndex: 4581
{
	// Properties
	public abstract ObservableList<DebugUI.Widget> children { get; }
	public abstract string displayName { get; set; }
	public abstract string queryPath { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ObservableList<DebugUI.Widget> get_children();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_displayName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_displayName(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_queryPath();
}

// Namespace: 
public interface DebugUI.IValueField // TypeDefIndex: 4582
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object ValidateValue(object value);
}

// Namespace: 
public class DebugUI.Button : DebugUI.Widget // TypeDefIndex: 4583
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CBF0 Offset: 0x3CCF1 VA: 0x3CBF0
	private Action <action>k__BackingField; // 0x38

	// Properties
	public Action action { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D9D0 Offset: 0x3DAD1 VA: 0x3D9D0
	// RVA: 0x354F630 Offset: 0x354F731 VA: 0x354F630
	public Action get_action() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D9E0 Offset: 0x3DAE1 VA: 0x3D9E0
	// RVA: 0x354F640 Offset: 0x354F741 VA: 0x354F640
	public void set_action(Action value) { }

	// RVA: 0x354F650 Offset: 0x354F751 VA: 0x354F650
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Value : DebugUI.Widget // TypeDefIndex: 4584
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3CC00 Offset: 0x3CD01 VA: 0x3CC00
	private Func<object> <getter>k__BackingField; // 0x38
	public float refreshRate; // 0x40

	// Properties
	public Func<object> getter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D9F0 Offset: 0x3DAF1 VA: 0x3D9F0
	// RVA: 0x3552120 Offset: 0x3552221 VA: 0x3552120
	public Func<object> get_getter() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DA00 Offset: 0x3DB01 VA: 0x3DA00
	// RVA: 0x3552130 Offset: 0x3552231 VA: 0x3552130
	public void set_getter(Func<object> value) { }

	// RVA: 0x3552140 Offset: 0x3552241 VA: 0x3552140
	public void .ctor() { }

	// RVA: 0x35521B0 Offset: 0x35522B1 VA: 0x35521B0
	public object GetValue() { }
}

