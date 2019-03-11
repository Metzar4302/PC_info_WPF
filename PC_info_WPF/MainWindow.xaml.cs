using System;
using System.Collections.Generic;
using System.Windows;
using System.Management;
using PC_info_WPF.Classes;

namespace PC_info_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Cpu_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Name"));
            Cpu_status_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Status"));
            //Cpu_temp_value.Text =
            Cpu_frequency_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CurrentClockSpeed")) + " Hz";
            Cpu_family_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Family"));
            Cpu_cur_volt_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CurrentVoltage"));
            Cpu_cpu_status_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CpuStatus"));
            Cpu_architecture_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Architecture"));
            Cpu_description_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Description"));
            Cpu_threadcount_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "ThreadCount"));
            Cpu_assetTag_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "AssetTag"));

            // ===================================================================================================================

            Fan_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Fan", "Name"));
            Fan_info_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Fan", "StatusInfo"));

            // ===================================================================================================================

            //Win32_Perf
            Perf_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Perf", "Name"));
            Perf_frequency_object_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Perf", "Frequency_Object"));

            //Win32_VideoController
            // ===================================================================================================================
            Video_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "Name"));
            Video_proc_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "VideoProcessor"));
            Video_protocols_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "ProtocolSupported"));

            //Win32_NetworkAdapter
            // ===================================================================================================================
            Network_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_NetworkAdapter", "Name"));
            Network_mac_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_NetworkAdapter", "MACAddress"));

            //Win32_PhysicalMemory
            // ===================================================================================================================
            Memory_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_PhysicalMemory", "Name"));
            Memory_manufacturer_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_PhysicalMemory", "Manufacturer"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows;
using System.Management;
using PC_info_WPF.Classes;

namespace PC_info_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Cpu_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Name"));
            Cpu_status_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Status"));
            //Cpu_temp_value.Text =
            Cpu_frequency_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CurrentClockSpeed")) + " Hz";
            Cpu_family_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Family"));
            Cpu_cur_volt_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CurrentVoltage"));
            Cpu_cpu_status_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "CpuStatus"));
            Cpu_architecture_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Architecture"));
            Cpu_description_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "Description"));
            Cpu_threadcount_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "ThreadCount"));
            Cpu_assetTag_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Processor", "AssetTag"));

            // ===================================================================================================================

            Fan_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Fan", "Name"));
            Fan_info_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Fan", "StatusInfo"));

            // ===================================================================================================================

            //Win32_Perf
            Perf_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Perf", "Name"));
            Perf_frequency_object_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_Perf", "Frequency_Object"));

            //Win32_VideoController
            // ===================================================================================================================
            Video_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "Name"));
            Video_proc_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "VideoProcessor"));
            Video_protocols_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_VideoController", "ProtocolSupported"));

            //Win32_NetworkAdapter
            // ===================================================================================================================
            Network_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_NetworkAdapter", "Name"));
            Network_mac_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_NetworkAdapter", "MACAddress"));

            //Win32_PhysicalMemory
            // ===================================================================================================================
            Memory_name_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_PhysicalMemory", "Name"));
            Memory_manufacturer_value.Text = Tools.ListToString(Tools.GetHardwareInfo("Win32_PhysicalMemory", "Manufacturer"));
        }
    }
}
