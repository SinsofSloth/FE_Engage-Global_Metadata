// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472DA0 Offset: 0x472EA1 VA: 0x472DA0
public static class Path // TypeDefIndex: 672
{
	// Fields
	[ObsoleteAttribute] // RVA: 0x4784C0 Offset: 0x4785C1 VA: 0x4784C0
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Properties
	internal static string DirectorySeparatorCharAsString { get; }
	internal static char[] TrimEndChars { get; }

	// Methods

	// RVA: 0x381C180 Offset: 0x381C281 VA: 0x381C180
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x381C4B0 Offset: 0x381C5B1 VA: 0x381C4B0
	public static string Combine(string path1, string path2) { }

	// RVA: 0x381C960 Offset: 0x381CA61 VA: 0x381C960
	internal static string CleanPath(string s) { }

	// RVA: 0x381CE90 Offset: 0x381CF91 VA: 0x381CE90
	public static string GetDirectoryName(string path) { }

	// RVA: 0x381D9E0 Offset: 0x381DAE1 VA: 0x381D9E0
	public static string GetExtension(string path) { }

	// RVA: 0x381DBA0 Offset: 0x381DCA1 VA: 0x381DBA0
	public static string GetFileName(string path) { }

	// RVA: 0x381DCC0 Offset: 0x381DDC1 VA: 0x381DCC0
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x381DD30 Offset: 0x381DE31 VA: 0x381DD30
	public static string GetFullPath(string path) { }

	// RVA: 0x381E740 Offset: 0x381E841 VA: 0x381E740
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x381E7B0 Offset: 0x381E8B1 VA: 0x381E7B0
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x381E890 Offset: 0x381E991 VA: 0x381E890
	internal static string GetFullPathName(string path) { }

	// RVA: 0x381EB80 Offset: 0x381EC81 VA: 0x381EB80
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x381DDB0 Offset: 0x381DEB1 VA: 0x381DDB0
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x381EE60 Offset: 0x381EF61 VA: 0x381EE60
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x381D220 Offset: 0x381D321 VA: 0x381D220
	public static string GetPathRoot(string path) { }

	// RVA: 0x381F960 Offset: 0x381FA61 VA: 0x381F960
	public static string GetTempFileName() { }

	// RVA: 0x381FD00 Offset: 0x381FE01 VA: 0x381FD00
	public static string GetTempPath() { }

	// RVA: 0x381FE20 Offset: 0x381FF21 VA: 0x381FE20
	private static string get_temp_path() { }

	// RVA: 0x381C760 Offset: 0x381C861 VA: 0x381C760
	public static bool IsPathRooted(string path) { }

	// RVA: 0x381FE30 Offset: 0x381FF31 VA: 0x381FE30
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x381C400 Offset: 0x381C501 VA: 0x381C400
	private static int findExtension(string path) { }

	// RVA: 0x381FED0 Offset: 0x381FFD1 VA: 0x381FED0
	private static void .cctor() { }

	// RVA: 0x3820150 Offset: 0x3820251 VA: 0x3820150
	private static string GetServerAndShare(string path) { }

	// RVA: 0x3820390 Offset: 0x3820491 VA: 0x3820390
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x381EF30 Offset: 0x381F031 VA: 0x381EF30
	private static string CanonicalizePath(string path) { }

	// RVA: 0x3820900 Offset: 0x3820A01 VA: 0x3820900
	public static string Combine(string[] paths) { }

	// RVA: 0x3820C50 Offset: 0x3820D51 VA: 0x3820C50
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x3820E20 Offset: 0x3820F21 VA: 0x3820E20
	internal static void Validate(string path) { }

	// RVA: 0x3820EA0 Offset: 0x3820FA1 VA: 0x3820EA0
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x3820FF0 Offset: 0x38210F1 VA: 0x3820FF0
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x3821060 Offset: 0x3821161 VA: 0x3821060
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x3821100 Offset: 0x3821201 VA: 0x3821100
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x3821290 Offset: 0x3821391 VA: 0x3821290
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x3821440 Offset: 0x3821541 VA: 0x3821440
	internal static string InternalCombine(string path1, string path2) { }
}

