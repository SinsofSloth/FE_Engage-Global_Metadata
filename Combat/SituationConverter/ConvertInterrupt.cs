// Namespace: Combat.SituationConverter
public class ConvertInterrupt : BaseConverter // TypeDefIndex: 8882
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284B40 Offset: 0x284C41 VA: 0x284B40
	private CameraPosition <MainCamera>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284B50 Offset: 0x284C51 VA: 0x284B50
	[TupleElementNamesAttribute] // RVA: 0x284B50 Offset: 0x284C51 VA: 0x284B50
	private ValueTuple<bool, bool> <MainInverse>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x284C10 Offset: 0x284D11 VA: 0x284C10
	private CameraPosition <InterruptCamera>k__BackingField; // 0x20

	// Properties
	private CameraPosition MainCamera { get; set; }
	[TupleElementNamesAttribute] // RVA: 0x2D4D00 Offset: 0x2D4E01 VA: 0x2D4D00
	private ValueTuple<bool, bool> MainInverse { get; set; }
	private CameraPosition InterruptCamera { get; set; }

	// Methods

	// RVA: 0x23BD040 Offset: 0x23BD141 VA: 0x23BD040
	public void .ctor(CameraDataSet data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA40 Offset: 0x2ADB41 VA: 0x2ADA40
	// RVA: 0x23BD0E0 Offset: 0x23BD1E1 VA: 0x23BD0E0
	private CameraPosition get_MainCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA50 Offset: 0x2ADB51 VA: 0x2ADA50
	// RVA: 0x23BD0F0 Offset: 0x23BD1F1 VA: 0x23BD0F0
	private void set_MainCamera(CameraPosition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA60 Offset: 0x2ADB61 VA: 0x2ADA60
	// RVA: 0x23BD100 Offset: 0x23BD201 VA: 0x23BD100
	private ValueTuple<bool, bool> get_MainInverse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA70 Offset: 0x2ADB71 VA: 0x2ADA70
	// RVA: 0x23BD110 Offset: 0x23BD211 VA: 0x23BD110
	private void set_MainInverse(ValueTuple<bool, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA80 Offset: 0x2ADB81 VA: 0x2ADA80
	// RVA: 0x23BD120 Offset: 0x23BD221 VA: 0x23BD120
	private CameraPosition get_InterruptCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADA90 Offset: 0x2ADB91 VA: 0x2ADA90
	// RVA: 0x23BD130 Offset: 0x23BD231 VA: 0x23BD130
	private void set_InterruptCamera(CameraPosition value) { }

	// RVA: 0x23BD140 Offset: 0x23BD241 VA: 0x23BD140 Slot: 4
	public override CameraPosition Convert(CameraSituation situation, string arg) { }
}

