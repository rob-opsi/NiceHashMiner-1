﻿using NHM.Common.Device;
using NHM.DeviceDetection.WMI;
using System;
using System.Collections.Generic;

namespace NHM.DeviceDetection
{
    public class DeviceDetectionResult
    {
        // WMI VideoControllers
        public IReadOnlyList<VideoControllerData> AvailableVideoControllers { get; internal set; }
        public Version NvidiaDriverWMI { get; internal set; }

        // CPU
        public CPUDevice CPU { get; internal set; }

        // NVIDIA
        public IReadOnlyList<CUDADevice> CUDADevices { get; internal set; }
        public bool IsDCHDriver { get; internal set; }
        public Version NvidiaDriver { get; internal set; }
        public Version AmdDriver { get; internal set; }

        public bool IsNvidiaNVMLLoadedError { get; internal set; }
        public bool IsNvidiaNVMLInitializedError { get; internal set; }
        public IReadOnlyList<CUDADevice> UnsupportedCUDADevices { get; internal set; }

        // AMD
        public IReadOnlyList<AMDDevice> AMDDevices { get; internal set; }
        public bool IsOpenClFallback { get; internal set; }

        public bool AMDDriverObsolete { get; internal set; }
        public bool NVIDIADriverObsolete { get; internal set; }

        public static Version MinimumAMDDriver
        {
            get
            {
                return NHM.DeviceDetection.AMD.AmdDriver.MinimumVersion.AdrenalinFormat;
            }
        }

        public static Version MinimumAMDDriverWDS
        {
            get
            {
                return NHM.DeviceDetection.AMD.AmdDriver.MinimumVersion.DriveStoreFormat;
            }
        }

        public static Version MinimumNVIDIADriver
        {
            get
            {
                return NHM.DeviceDetection.NVIDIA.NvidiaSmiDriver.MinimumVersion;
            }
        }

        // FAKE
        public IReadOnlyList<FakeDevice> FAKEDevices { get; internal set; }
    }
}
