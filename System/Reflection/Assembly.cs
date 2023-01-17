// Namespace: System.Reflection
[ClassInterfaceAttribute] // RVA: 0x472200 Offset: 0x472301 VA: 0x472200
[ComVisibleAttribute] // RVA: 0x472200 Offset: 0x472301 VA: 0x472200
[ComDefaultInterfaceAttribute] // RVA: 0x472200 Offset: 0x472301 VA: 0x472200
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 555
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private Assembly.ResolveEventHolder resolve_event_holder; // 0x18
	private object _evidence; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	private bool fromByteArray; // 0x50
	private string assemblyName; // 0x58

	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[MonoTODOAttribute] // RVA: 0x47DDB0 Offset: 0x47DEB1 VA: 0x47DDB0
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x3566280 Offset: 0x3566381 VA: 0x3566280
	protected void .ctor() { }

	// RVA: 0x3566300 Offset: 0x3566401 VA: 0x3566300
	private string get_code_base(bool escaped) { }

	// RVA: 0x3566310 Offset: 0x3566411 VA: 0x3566310
	private string get_fullname() { }

	// RVA: 0x3566320 Offset: 0x3566421 VA: 0x3566320
	private string get_location() { }

	// RVA: 0x3566330 Offset: 0x3566431 VA: 0x3566330
	internal static string GetAotId() { }

	// RVA: 0x3566340 Offset: 0x3566441 VA: 0x3566340
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x3566350 Offset: 0x3566451 VA: 0x3566350 Slot: 7
	public virtual string get_CodeBase() { }

	// RVA: 0x3566360 Offset: 0x3566461 VA: 0x3566360 Slot: 8
	public virtual string get_FullName() { }

	// RVA: 0x3566370 Offset: 0x3566471 VA: 0x3566370 Slot: 9
	public virtual string get_Location() { }

	// RVA: 0x35663E0 Offset: 0x35664E1 VA: 0x35663E0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3566420 Offset: 0x3566521 VA: 0x3566420 Slot: 11
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x35664B0 Offset: 0x35665B1 VA: 0x35664B0 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3566540 Offset: 0x3566641 VA: 0x3566540
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x3566550 Offset: 0x3566651 VA: 0x3566550 Slot: 13
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x3566890 Offset: 0x3566991 VA: 0x3566890 Slot: 14
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x35668A0 Offset: 0x35669A1 VA: 0x35668A0 Slot: 15
	public virtual Type[] GetTypes() { }

	// RVA: 0x35668C0 Offset: 0x35669C1 VA: 0x35668C0 Slot: 16
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x35668E0 Offset: 0x35669E1 VA: 0x35668E0 Slot: 17
	public virtual Type GetType(string name) { }

	// RVA: 0x3566900 Offset: 0x3566A01 VA: 0x3566900
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x3566910 Offset: 0x3566A11 VA: 0x3566910 Slot: 18
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x3566950 Offset: 0x3566A51 VA: 0x3566950 Slot: 19
	public virtual AssemblyName GetName() { }

	// RVA: 0x3566970 Offset: 0x3566A71 VA: 0x3566970 Slot: 3
	public override string ToString() { }

	// RVA: 0x35669C0 Offset: 0x3566AC1 VA: 0x35669C0
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x3559B00 Offset: 0x3559C01 VA: 0x3559B00
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x3566A90 Offset: 0x3566B91 VA: 0x3566A90
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x47BD80 Offset: 0x47BE81 VA: 0x47BD80
	// RVA: 0x3566AA0 Offset: 0x3566BA1 VA: 0x3566AA0
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x3566AF0 Offset: 0x3566BF1 VA: 0x3566AF0
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x3566B70 Offset: 0x3566C71 VA: 0x3566B70 Slot: 20
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x3566B80 Offset: 0x3566C81 VA: 0x3566B80 Slot: 21
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x3566B90 Offset: 0x3566C91 VA: 0x3566B90
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x3566BE0 Offset: 0x3566CE1 VA: 0x3566BE0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x3566BF0 Offset: 0x3566CF1 VA: 0x3566BF0
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x3566C00 Offset: 0x3566D01 VA: 0x3566C00 Slot: 22
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x3566D10 Offset: 0x3566E11 VA: 0x3566D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3566D20 Offset: 0x3566E21 VA: 0x3566D20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3566DF0 Offset: 0x3566EF1 VA: 0x3566DF0
	private static Exception CreateNIE() { }

	// RVA: 0x3566E70 Offset: 0x3566F71 VA: 0x3566E70
	public bool get_IsFullyTrusted() { }

	// RVA: 0x3566E80 Offset: 0x3566F81 VA: 0x3566E80 Slot: 23
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x3566EB0 Offset: 0x3566FB1 VA: 0x3566EB0 Slot: 24
	public virtual Module GetModule(string name) { }

	// RVA: 0x3566EE0 Offset: 0x3566FE1 VA: 0x3566EE0 Slot: 25
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x355D1A0 Offset: 0x355D2A1 VA: 0x355D1A0
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x355DCF0 Offset: 0x355DDF1 VA: 0x355DCF0
	public static bool op_Inequality(Assembly left, Assembly right) { }
}

