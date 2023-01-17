// Namespace: System.Diagnostics
[TypeConverterAttribute] // RVA: 0x2FE40 Offset: 0x2FF41 VA: 0x2FE40
public sealed class ProcessStartInfo // TypeDefIndex: 2284
{
	// Fields
	private string fileName; // 0x10
	private string arguments; // 0x18
	private string directory; // 0x20
	private string verb; // 0x28
	private ProcessWindowStyle windowStyle; // 0x30
	private bool errorDialog; // 0x34
	private IntPtr errorDialogParentHandle; // 0x38
	private bool useShellExecute; // 0x40
	private string userName; // 0x48
	private string domain; // 0x50
	private SecureString password; // 0x58
	private string passwordInClearText; // 0x60
	private bool loadUserProfile; // 0x68
	private bool redirectStandardInput; // 0x69
	private bool redirectStandardOutput; // 0x6A
	private bool redirectStandardError; // 0x6B
	private Encoding standardOutputEncoding; // 0x70
	private Encoding standardErrorEncoding; // 0x78
	private bool createNoWindow; // 0x80
	private WeakReference weakParentProcess; // 0x88
	internal StringDictionary environmentVariables; // 0x90
	private IDictionary<string, string> environment; // 0x98
	private static readonly string[] empty; // 0x0

	// Properties
	[TypeConverterAttribute] // RVA: 0x33CC0 Offset: 0x33DC1 VA: 0x33CC0
	[SettingsBindableAttribute] // RVA: 0x33CC0 Offset: 0x33DC1 VA: 0x33CC0
	[DefaultValueAttribute] // RVA: 0x33CC0 Offset: 0x33DC1 VA: 0x33CC0
	[MonitoringDescriptionAttribute] // RVA: 0x33CC0 Offset: 0x33DC1 VA: 0x33CC0
	[NotifyParentPropertyAttribute] // RVA: 0x33CC0 Offset: 0x33DC1 VA: 0x33CC0
	public string Arguments { get; }
	[NotifyParentPropertyAttribute] // RVA: 0x33D70 Offset: 0x33E71 VA: 0x33D70
	[MonitoringDescriptionAttribute] // RVA: 0x33D70 Offset: 0x33E71 VA: 0x33D70
	[DefaultValueAttribute] // RVA: 0x33D70 Offset: 0x33E71 VA: 0x33D70
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33D70 Offset: 0x33E71 VA: 0x33D70
	[EditorAttribute] // RVA: 0x33D70 Offset: 0x33E71 VA: 0x33D70
	public StringDictionary EnvironmentVariables { get; }
	[DefaultValueAttribute] // RVA: 0x33E20 Offset: 0x33F21 VA: 0x33E20
	[NotifyParentPropertyAttribute] // RVA: 0x33E20 Offset: 0x33F21 VA: 0x33E20
	[MonitoringDescriptionAttribute] // RVA: 0x33E20 Offset: 0x33F21 VA: 0x33E20
	public bool RedirectStandardInput { get; }
	[MonitoringDescriptionAttribute] // RVA: 0x33E90 Offset: 0x33F91 VA: 0x33E90
	[NotifyParentPropertyAttribute] // RVA: 0x33E90 Offset: 0x33F91 VA: 0x33E90
	[DefaultValueAttribute] // RVA: 0x33E90 Offset: 0x33F91 VA: 0x33E90
	public bool RedirectStandardOutput { get; }
	[DefaultValueAttribute] // RVA: 0x33F00 Offset: 0x34001 VA: 0x33F00
	[MonitoringDescriptionAttribute] // RVA: 0x33F00 Offset: 0x34001 VA: 0x33F00
	[NotifyParentPropertyAttribute] // RVA: 0x33F00 Offset: 0x34001 VA: 0x33F00
	public bool RedirectStandardError { get; }
	public Encoding StandardErrorEncoding { get; }
	public Encoding StandardOutputEncoding { get; }
	[DefaultValueAttribute] // RVA: 0x33F70 Offset: 0x34071 VA: 0x33F70
	[NotifyParentPropertyAttribute] // RVA: 0x33F70 Offset: 0x34071 VA: 0x33F70
	[MonitoringDescriptionAttribute] // RVA: 0x33F70 Offset: 0x34071 VA: 0x33F70
	public bool UseShellExecute { get; }
	[NotifyParentPropertyAttribute] // RVA: 0x33FE0 Offset: 0x340E1 VA: 0x33FE0
	public string UserName { get; }
	public SecureString Password { get; }
	[NotifyParentPropertyAttribute] // RVA: 0x34000 Offset: 0x34101 VA: 0x34000
	public string Domain { get; }
	[NotifyParentPropertyAttribute] // RVA: 0x34020 Offset: 0x34121 VA: 0x34020
	public bool LoadUserProfile { get; }
	[SettingsBindableAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	[TypeConverterAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	[NotifyParentPropertyAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	[EditorAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	[MonitoringDescriptionAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	[DefaultValueAttribute] // RVA: 0x34040 Offset: 0x34141 VA: 0x34040
	public string FileName { get; }
	[NotifyParentPropertyAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	[SettingsBindableAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	[EditorAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	[MonitoringDescriptionAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	[DefaultValueAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	[TypeConverterAttribute] // RVA: 0x34130 Offset: 0x34231 VA: 0x34130
	public string WorkingDirectory { get; }
	[DefaultValueAttribute] // RVA: 0x34220 Offset: 0x34321 VA: 0x34220
	[NotifyParentPropertyAttribute] // RVA: 0x34220 Offset: 0x34321 VA: 0x34220
	[MonitoringDescriptionAttribute] // RVA: 0x34220 Offset: 0x34321 VA: 0x34220
	public bool ErrorDialog { set; }
	internal bool HaveEnvVars { get; }

	// Methods

	// RVA: 0x1AD5B80 Offset: 0x1AD5C81 VA: 0x1AD5B80
	internal void .ctor(Process parent) { }

	// RVA: 0x1AD9250 Offset: 0x1AD9351 VA: 0x1AD9250
	public void .ctor(string fileName, string arguments) { }

	// RVA: 0x1AD9100 Offset: 0x1AD9201 VA: 0x1AD9100
	public string get_Arguments() { }

	// RVA: 0x1AD8C40 Offset: 0x1AD8D41 VA: 0x1AD8C40
	public StringDictionary get_EnvironmentVariables() { }

	// RVA: 0x1AD92B0 Offset: 0x1AD93B1 VA: 0x1AD92B0
	public bool get_RedirectStandardInput() { }

	// RVA: 0x1AD92C0 Offset: 0x1AD93C1 VA: 0x1AD92C0
	public bool get_RedirectStandardOutput() { }

	// RVA: 0x1AD92D0 Offset: 0x1AD93D1 VA: 0x1AD92D0
	public bool get_RedirectStandardError() { }

	// RVA: 0x1AD92E0 Offset: 0x1AD93E1 VA: 0x1AD92E0
	public Encoding get_StandardErrorEncoding() { }

	// RVA: 0x1AD92F0 Offset: 0x1AD93F1 VA: 0x1AD92F0
	public Encoding get_StandardOutputEncoding() { }

	// RVA: 0x1AD9300 Offset: 0x1AD9401 VA: 0x1AD9300
	public bool get_UseShellExecute() { }

	// RVA: 0x1AD87E0 Offset: 0x1AD88E1 VA: 0x1AD87E0
	public string get_UserName() { }

	// RVA: 0x1AD9310 Offset: 0x1AD9411 VA: 0x1AD9310
	public SecureString get_Password() { }

	// RVA: 0x1AD91E0 Offset: 0x1AD92E1 VA: 0x1AD91E0
	public string get_Domain() { }

	// RVA: 0x1AD9320 Offset: 0x1AD9421 VA: 0x1AD9320
	public bool get_LoadUserProfile() { }

	// RVA: 0x1AD69C0 Offset: 0x1AD6AC1 VA: 0x1AD69C0
	public string get_FileName() { }

	// RVA: 0x1AD9170 Offset: 0x1AD9271 VA: 0x1AD9170
	public string get_WorkingDirectory() { }

	// RVA: 0x1AD9330 Offset: 0x1AD9431 VA: 0x1AD9330
	public void set_ErrorDialog(bool value) { }

	// RVA: 0x1AD8C30 Offset: 0x1AD8D31 VA: 0x1AD8C30
	internal bool get_HaveEnvVars() { }

	// RVA: 0x1AD9340 Offset: 0x1AD9441 VA: 0x1AD9340
	private static void .cctor() { }
}

