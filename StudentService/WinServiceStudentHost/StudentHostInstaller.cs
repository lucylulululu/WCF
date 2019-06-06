using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceStudentHost
{
    [RunInstaller(true)]
    public partial class StudentHostInstaller : System.Configuration.Install.Installer
    {
        public StudentHostInstaller()
        {//Process
            ServiceProcessInstaller process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.NetworkService;              //Process
            ServiceInstaller service = new ServiceInstaller(); service.ServiceName = "StudentHostWindowService";
            service.DisplayName = "StudentHostWindowService";
            service.Description = "Student WCF Service Hosted Successfully.";
            service.StartType = ServiceStartMode.Automatic;

            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
