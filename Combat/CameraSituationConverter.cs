// Namespace: Combat
public class CameraSituationConverter // TypeDefIndex: 8562
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x281E30 Offset: 0x281F31 VA: 0x281E30
	private readonly List<BaseConverter> <Converters>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x281E40 Offset: 0x281F41 VA: 0x281E40
	private readonly CameraDataSet <DataSet>k__BackingField; // 0x18

	// Properties
	private List<BaseConverter> Converters { get; }
	private CameraDataSet DataSet { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9B40 Offset: 0x2A9C41 VA: 0x2A9B40
	// RVA: 0x29A6710 Offset: 0x29A6811 VA: 0x29A6710
	private List<BaseConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B50 Offset: 0x2A9C51 VA: 0x2A9B50
	// RVA: 0x29A6720 Offset: 0x29A6821 VA: 0x29A6720
	private CameraDataSet get_DataSet() { }

	// RVA: 0x29A4240 Offset: 0x29A4341 VA: 0x29A4240
	public static CameraSituationConverter SetupConverter(CombatRecord record, CameraSwitch swt, CameraPositionData posData) { }

	// RVA: 0x29A6730 Offset: 0x29A6831 VA: 0x29A6730
	private void .ctor(CombatRecord record, CameraSwitch swt, CameraPositionData posData) { }

	// RVA: 0x29A3950 Offset: 0x29A3A51 VA: 0x29A3950
	public CameraPosition GetCameraPosition(CameraSituation situation, string arg) { }
}

