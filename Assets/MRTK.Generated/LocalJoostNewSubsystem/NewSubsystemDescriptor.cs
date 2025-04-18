// TODO: [Optional] Add copyright and license statement(s).

using MixedReality.Toolkit;
using MixedReality.Toolkit.Subsystems;
using System;

namespace LocalJoost.MRTK3.Subsystems
{
    /// <summary>
    /// Encapsulates the parameters for creating a new <see cref="NewSubsystemDescriptor"/>.
    /// </summary>
    public class NewSubsystemCinfo : MRTKSubsystemCinfo
    {
        // TODO: Add subsystem specific properties.

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="other">The other <see cref="LocalJoostNewSubsystem"/> to compare against.</param>
        /// <returns>`True` if every field in <paramref name="other"/> is equal to this <see cref="NewSubsystem"/>, otherwise false.</returns>
        public override bool Equals(MRTKSubsystemCinfo other)
        {
            // TODO: Add comparison of subsystem specific property values.
            return base.Equals(other);
        }
    }

    /// <summary>
    /// Specifies a functionality description that may be registered for each implementation that provides the
    /// <see cref="NewSubsystem"/> interface.
    /// </summary>
    public class NewSubsystemDescriptor :
        MRTKSubsystemDescriptor<NewSubsystem, NewSubsystem.Provider>
    {
        /// <summary>
        /// Constructs a <c>NewSubsystemDescriptor</c> based on the given parameters.
        /// </summary>
        /// <param name=cinfo>The parameters required to initialize the descriptor.</param>
        NewSubsystemDescriptor(NewSubsystemCinfo cinfo) : base(cinfo)
        {
            // TODO: Initialize subsystem specific properties.
        }

        // TODO: Add subsystem specific properties.

        /// <summary>
        /// Creates a <c>NewSubsystemDescriptor</c> based on the given parameters validating that the
        /// <c>id</c> and <c>implentationType</c> properties are specified.
        /// </summary>
        /// <param name='cinfo'>The parameters required to initialize the descriptor.</param>
        /// <returns>
        /// The created <c>NewSubsystemDescriptor</c>.
        /// </returns>
        internal static NewSubsystemDescriptor Create(NewSubsystemCinfo cinfo)
        {
            // Validates cinfo.
            if (!XRSubsystemHelpers.CheckTypes<NewSubsystem, NewSubsystem.Provider>(
                    cinfo.Name,
                    cinfo.SubsystemTypeOverride,
                    cinfo.ProviderType))
            {
                throw new ArgumentException("Could not create NewSubsystemDescriptor.");
            }

            return new NewSubsystemDescriptor(cinfo);
        }
    }
}
