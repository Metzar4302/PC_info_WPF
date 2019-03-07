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
        }
    }
}
