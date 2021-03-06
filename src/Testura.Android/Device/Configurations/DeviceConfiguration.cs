﻿using System.IO;
using System.Reflection;
using Testura.Android.Util;
using Testura.Android.Util.Extensions;

namespace Testura.Android.Device.Configurations
{
    /// <summary>
    /// Represents the device configuration.
    /// </summary>
    public class DeviceConfiguration
    {
        /// <summary>
        /// Name of the Testura helper APK file.
        /// </summary>
        public const string ServerApkName = "Testura.Android.Server.apk";

        /// <summary>
        /// Name of the Testura server APK file.
        /// </summary>
        public const string ServerUiAutomatorApkName = "Testura.Android.Server-UiAutomator.apk";

        /// <summary>
        /// Latest Testura server apk version
        /// </summary>
        public const string ServerApkVersion = "1.1";

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfiguration"/> class.
        /// </summary>
        public DeviceConfiguration()
        {
            AdbPath = string.Empty;
            Serial = string.Empty;
            Dependencies = DependencyHandling.InstallIfMissing;
            DependenciesDirectory = Path.Combine(Assembly.GetExecutingAssembly().GetDirectoryPath(), "Dependencies");
            Port = 9008;
            DumpTries = 5;
            DumpTimeout = 15;
        }

        /// <summary>
        /// Gets or sets the path to adb.exe.
        /// </summary>
        public string AdbPath { get; set; }

        /// <summary>
        /// Gets or sets the serial of device under test.
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we should push and install
        /// all required dependencies.
        /// </summary>
        public DependencyHandling Dependencies { get; set; }

        /// <summary>
        /// Gets or sets the directory to all dependencies (uiautomator stub, helper apk, etc).
        /// </summary>
        public string DependenciesDirectory { get; set; }

        /// <summary>
        /// Gets or sets the local port.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets how many times we should try to dump the UI before
        /// sending exception.
        /// </summary>
        public int DumpTries { get; set; }

        /// <summary>
        /// Gets or sets the dump timeout in seconds
        /// </summary>
        public int DumpTimeout { get; set; }
    }
}
