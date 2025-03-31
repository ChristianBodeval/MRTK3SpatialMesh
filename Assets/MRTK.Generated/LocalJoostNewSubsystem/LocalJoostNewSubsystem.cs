// TODO: [Optional] Add copyright and license statement(s).

using MixedReality.Toolkit;
using MixedReality.Toolkit.Subsystems;
using UnityEngine;
using UnityEngine.Scripting;

namespace LocalJoost.MRTK3.Subsystems
{
    [Preserve]
    [MRTKSubsystem(
        Name = "localjoost.mrtk3.subsystems",
        DisplayName = "LocalJoost NewSubsystem",
        Author = "LocalJoost",
        ProviderType = typeof(LocalJoostNewSubsystemProvider),
        SubsystemTypeOverride = typeof(LocalJoostNewSubsystem),
        ConfigType = typeof(BaseSubsystemConfig))]
    public class LocalJoostNewSubsystem : NewSubsystem
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void Register()
        {
            // Fetch subsystem metadata from the attribute.
            var cinfo = XRSubsystemHelpers.ConstructCinfo<LocalJoostNewSubsystem, NewSubsystemCinfo>();

            if (!LocalJoostNewSubsystem.Register(cinfo))
            {
                Debug.LogError($"Failed to register the {cinfo.Name} subsystem.");
            }
        }

        [Preserve]
        class LocalJoostNewSubsystemProvider : Provider
        {

            #region INewSubsystem implementation

            // TODO: Add the provider implementation.

            #endregion NewSubsystem implementation
        }
    }
}
