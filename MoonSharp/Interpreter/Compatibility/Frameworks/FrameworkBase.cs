// Namespace: MoonSharp.Interpreter.Compatibility.Frameworks
public abstract class FrameworkBase // TypeDefIndex: 6261
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool StringContainsChar(string str, char chr);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool IsValueType(Type t);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Assembly GetAssembly(Type t);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type GetBaseType(Type t);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsGenericType(Type t);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool IsGenericTypeDefinition(Type t);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool IsEnum(Type t);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsNestedPublic(Type t);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsAbstract(Type t);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool IsInterface(Type t);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Attribute[] GetCustomAttributes(Type t, bool inherit);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Attribute[] GetCustomAttributes(Type t, Type at, bool inherit);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type[] GetInterfaces(Type t);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool IsInstanceOfType(Type t, object o);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(EventInfo ei);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRemoveMethod(EventInfo ei);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetGetMethod(PropertyInfo pi);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo GetSetMethod(PropertyInfo pi);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Type GetInterface(Type type, string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract PropertyInfo[] GetProperties(Type type);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract PropertyInfo GetProperty(Type type, string name);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Type[] GetNestedTypes(Type type);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract EventInfo[] GetEvents(Type type);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract ConstructorInfo[] GetConstructors(Type type);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Type[] GetAssemblyTypes(Assembly asm);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract MethodInfo[] GetMethods(Type type);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract FieldInfo[] GetFields(Type t);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract MethodInfo GetMethod(Type type, string name);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract Type[] GetGenericArguments(Type t);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsAssignableFrom(Type current, Type toCompare);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool IsDbNull(object o);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract MethodInfo GetMethod(Type resourcesType, string v, Type[] type);

	// RVA: 0x3312420 Offset: 0x3312521 VA: 0x3312420
	protected void .ctor() { }
}

