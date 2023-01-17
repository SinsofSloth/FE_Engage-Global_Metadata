// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 4728
{
	// Fields
	[HideInInspector] // RVA: 0x3CF90 Offset: 0x3D091 VA: 0x3CF90
	public Color colorDefault; // 0x18
	[HideInInspector] // RVA: 0x3CFA0 Offset: 0x3D0A1 VA: 0x3CFA0
	public Color colorSelected; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x3CFB0 Offset: 0x3D0B1 VA: 0x3CFB0
	private DebugUIHandlerWidget <parentUIHandler>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x3CFC0 Offset: 0x3D0C1 VA: 0x3CFC0
	private DebugUIHandlerWidget <previousUIHandler>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x3CFD0 Offset: 0x3D0D1 VA: 0x3CFD0
	private DebugUIHandlerWidget <nextUIHandler>k__BackingField; // 0x48
	protected DebugUI.Widget m_Widget; // 0x50

	// Properties
	public DebugUIHandlerWidget parentUIHandler { get; set; }
	public DebugUIHandlerWidget previousUIHandler { get; set; }
	public DebugUIHandlerWidget nextUIHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3E140 Offset: 0x3E241 VA: 0x3E140
	// RVA: 0x1A0F0A0 Offset: 0x1A0F1A1 VA: 0x1A0F0A0
	public DebugUIHandlerWidget get_parentUIHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E150 Offset: 0x3E251 VA: 0x3E150
	// RVA: 0x1A0F0B0 Offset: 0x1A0F1B1 VA: 0x1A0F0B0
	public void set_parentUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E160 Offset: 0x3E261 VA: 0x3E160
	// RVA: 0x1A0F0C0 Offset: 0x1A0F1C1 VA: 0x1A0F0C0
	public DebugUIHandlerWidget get_previousUIHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E170 Offset: 0x3E271 VA: 0x3E170
	// RVA: 0x1A0F0D0 Offset: 0x1A0F1D1 VA: 0x1A0F0D0
	public void set_previousUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E180 Offset: 0x3E281 VA: 0x3E180
	// RVA: 0x1A0F0E0 Offset: 0x1A0F1E1 VA: 0x1A0F0E0
	public DebugUIHandlerWidget get_nextUIHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E190 Offset: 0x3E291 VA: 0x3E190
	// RVA: 0x1A0F0F0 Offset: 0x1A0F1F1 VA: 0x1A0F0F0
	public void set_nextUIHandler(DebugUIHandlerWidget value) { }

	// RVA: 0x1A0F100 Offset: 0x1A0F201 VA: 0x1A0F100 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x1A0F110 Offset: 0x1A0F211 VA: 0x1A0F110 Slot: 5
	internal virtual void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0F120 Offset: 0x1A0F221 VA: 0x1A0F120
	internal DebugUI.Widget GetWidget() { }

	// RVA: -1 Offset: -1
	protected T CastWidget<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229E940 Offset: 0x229EA41 VA: 0x229E940
	|-DebugUIHandlerWidget.CastWidget<object>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.BitField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.BoolField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Button>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.ColorField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Container>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.EnumField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.FloatField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Foldout>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.IntField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.UIntField>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Value>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Vector2Field>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Vector3Field>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Vector4Field>
	|-DebugUIHandlerWidget.CastWidget<DebugUI.Table.Row>
	*/

	// RVA: 0x1A0F130 Offset: 0x1A0F231 VA: 0x1A0F130 Slot: 6
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0F140 Offset: 0x1A0F241 VA: 0x1A0F140 Slot: 7
	public virtual void OnDeselection() { }

	// RVA: 0x1A0F150 Offset: 0x1A0F251 VA: 0x1A0F150 Slot: 8
	public virtual void OnAction() { }

	// RVA: 0x1A0F160 Offset: 0x1A0F261 VA: 0x1A0F160 Slot: 9
	public virtual void OnIncrement(bool fast) { }

	// RVA: 0x1A0F170 Offset: 0x1A0F271 VA: 0x1A0F170 Slot: 10
	public virtual void OnDecrement(bool fast) { }

	// RVA: 0x1A0F180 Offset: 0x1A0F281 VA: 0x1A0F180 Slot: 11
	public virtual DebugUIHandlerWidget Previous() { }

	// RVA: 0x1A09900 Offset: 0x1A09A01 VA: 0x1A09900 Slot: 12
	public virtual DebugUIHandlerWidget Next() { }

	// RVA: 0x1A09AE0 Offset: 0x1A09BE1 VA: 0x1A09AE0
	public void .ctor() { }
}

