// Namespace: System
public static class Math // TypeDefIndex: 269
{
	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3.141592653589793;
	public const double E = 2.718281828459045;

	// Methods

	// RVA: 0x34E6270 Offset: 0x34E6371 VA: 0x34E6270
	public static double Acos(double d) { }

	// RVA: 0x34E6280 Offset: 0x34E6381 VA: 0x34E6280
	public static double Asin(double d) { }

	// RVA: 0x34E6290 Offset: 0x34E6391 VA: 0x34E6290
	public static double Atan(double d) { }

	// RVA: 0x34E62A0 Offset: 0x34E63A1 VA: 0x34E62A0
	public static double Atan2(double y, double x) { }

	// RVA: 0x34E62B0 Offset: 0x34E63B1 VA: 0x34E62B0
	public static double Ceiling(double a) { }

	// RVA: 0x34E62C0 Offset: 0x34E63C1 VA: 0x34E62C0
	public static double Cos(double d) { }

	// RVA: 0x34E62D0 Offset: 0x34E63D1 VA: 0x34E62D0
	public static double Cosh(double value) { }

	// RVA: 0x34E62E0 Offset: 0x34E63E1 VA: 0x34E62E0
	public static double Floor(double d) { }

	// RVA: 0x34E62F0 Offset: 0x34E63F1 VA: 0x34E62F0
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x34E6570 Offset: 0x34E6671 VA: 0x34E6570
	public static double Sin(double a) { }

	// RVA: 0x34E6580 Offset: 0x34E6681 VA: 0x34E6580
	public static double Tan(double a) { }

	// RVA: 0x34E6590 Offset: 0x34E6691 VA: 0x34E6590
	public static double Sinh(double value) { }

	// RVA: 0x34E65A0 Offset: 0x34E66A1 VA: 0x34E65A0
	public static double Tanh(double value) { }

	// RVA: 0x34E65B0 Offset: 0x34E66B1 VA: 0x34E65B0
	public static double Round(double a) { }

	// RVA: 0x34E6640 Offset: 0x34E6741 VA: 0x34E6640
	public static double Round(double value, int digits) { }

	// RVA: 0x34E6720 Offset: 0x34E6821 VA: 0x34E6720
	public static Decimal Round(Decimal d) { }

	// RVA: 0x34E64D0 Offset: 0x34E65D1 VA: 0x34E64D0
	private static double SplitFractionDouble(double* value) { }

	[ReliabilityContractAttribute] // RVA: 0x47A7A0 Offset: 0x47A8A1 VA: 0x47A7A0
	// RVA: 0x34E67A0 Offset: 0x34E68A1 VA: 0x34E67A0
	public static double Sqrt(double d) { }

	// RVA: 0x34E67C0 Offset: 0x34E68C1 VA: 0x34E67C0
	public static double Log(double d) { }

	// RVA: 0x34E67D0 Offset: 0x34E68D1 VA: 0x34E67D0
	public static double Exp(double d) { }

	// RVA: 0x34E67E0 Offset: 0x34E68E1 VA: 0x34E67E0
	public static double Pow(double x, double y) { }

	// RVA: 0x34E67F0 Offset: 0x34E68F1 VA: 0x34E67F0
	public static double IEEERemainder(double x, double y) { }

	// RVA: 0x34E6A90 Offset: 0x34E6B91 VA: 0x34E6A90
	public static int Abs(int value) { }

	// RVA: 0x34E6B70 Offset: 0x34E6C71 VA: 0x34E6B70
	private static int AbsHelper(int value) { }

	// RVA: 0x34E6BE0 Offset: 0x34E6CE1 VA: 0x34E6BE0
	public static float Abs(float value) { }

	// RVA: 0x34E6BF0 Offset: 0x34E6CF1 VA: 0x34E6BF0
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0x47A7C0 Offset: 0x47A8C1 VA: 0x47A7C0
	// RVA: 0x34E6C00 Offset: 0x34E6D01 VA: 0x34E6C00
	public static int Max(int val1, int val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A7E0 Offset: 0x47A8E1 VA: 0x47A7E0
	// RVA: 0x34E6C10 Offset: 0x34E6D11 VA: 0x34E6C10
	public static long Max(long val1, long val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A800 Offset: 0x47A901 VA: 0x47A800
	// RVA: 0x34E6C20 Offset: 0x34E6D21 VA: 0x34E6C20
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A820 Offset: 0x47A921 VA: 0x47A820
	// RVA: 0x34E6C70 Offset: 0x34E6D71 VA: 0x34E6C70
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A840 Offset: 0x47A941 VA: 0x47A840
	// RVA: 0x34E6D10 Offset: 0x34E6E11 VA: 0x34E6D10
	public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x47A860 Offset: 0x47A961 VA: 0x47A860
	[ReliabilityContractAttribute] // RVA: 0x47A860 Offset: 0x47A961 VA: 0x47A860
	// RVA: 0x34E6D20 Offset: 0x34E6E21 VA: 0x34E6D20
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A8B0 Offset: 0x47A9B1 VA: 0x47A8B0
	// RVA: 0x34E6D30 Offset: 0x34E6E31 VA: 0x34E6D30
	public static long Min(long val1, long val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A8D0 Offset: 0x47A9D1 VA: 0x47A8D0
	// RVA: 0x34E6D40 Offset: 0x34E6E41 VA: 0x34E6D40
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x47A8F0 Offset: 0x47A9F1 VA: 0x47A8F0
	// RVA: 0x34E6D90 Offset: 0x34E6E91 VA: 0x34E6D90
	public static double Min(double val1, double val2) { }

	// RVA: 0x34E6E30 Offset: 0x34E6F31 VA: 0x34E6E30
	public static double Log(double a, double newBase) { }

	// RVA: 0x34E64E0 Offset: 0x34E65E1 VA: 0x34E64E0
	public static int Sign(double value) { }

	// RVA: 0x34E6FA0 Offset: 0x34E70A1 VA: 0x34E6FA0
	private static void .cctor() { }
}

