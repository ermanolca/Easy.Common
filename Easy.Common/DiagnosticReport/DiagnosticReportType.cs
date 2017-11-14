// ReSharper disable once CheckNamespace
namespace Easy.Common
{
    using System;

    /// <summary>
    /// Represents the different types of report which can 
    /// be generated by <see cref="DiagnosticReport"/>.
    /// <remarks>
    /// Reports can be mixed as: 
    /// <example>
    /// DiagnosticReportType.System | DiagnosticReportType.Process
    /// </example>
    /// </remarks>
    /// </summary>
    [Flags]
    public enum DiagnosticReportType
    {
        /// <summary>
        /// Includes details about the System.
        /// </summary>
        System = 1,

        /// <summary>
        /// Includes details about the Process.
        /// </summary>
        Process = 2,

        /// <summary>
        /// Includes details about the Drives.
        /// </summary>
        Drives = 4,

        /// <summary>
        /// Includes details about the referenced Assemblies.
        /// </summary>
        Assemblies = 8,

        /// <summary>
        /// Includes details about the Environment Variables.
        /// </summary>
        EnvironmentVariables = 16,

        /// <summary>
        /// Includes details about the Networks.
        /// </summary>
        Networks = 32,

        /// <summary>
        /// Generates the full report.
        /// </summary>
        Full = System | Process | Drives | Assemblies | EnvironmentVariables | Networks
    }
}