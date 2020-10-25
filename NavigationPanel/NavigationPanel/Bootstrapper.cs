using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Core;
using NavigationPanel;
using Prism.Modularity;
using Prism.Unity;

namespace NavigationPanel
{
    public class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            DirectoryModuleCatalog moduleCatalog = new DirectoryModuleCatalog();
            moduleCatalog.ModulePath = FileDirectoryUtil.GetAssemblyDirectory();
            return moduleCatalog;
        }
    }
}
