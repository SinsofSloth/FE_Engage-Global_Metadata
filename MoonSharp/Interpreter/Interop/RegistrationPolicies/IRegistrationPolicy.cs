// Namespace: MoonSharp.Interpreter.Interop.RegistrationPolicies
public interface IRegistrationPolicy // TypeDefIndex: 6144
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool AllowTypeAutoRegistration(Type type);
}

