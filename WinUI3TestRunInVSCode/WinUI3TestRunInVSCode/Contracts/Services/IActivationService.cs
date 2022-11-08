namespace WinUI3TestRunInVSCode.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
