using Autofac;
using Hearthstone.Engine.Contracts;
using Hearthstone.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone
{
    public class Program
    {
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacConfig());

            var container = builder.Build();
            var mainMenu = container.Resolve<IMainMenu>();
            mainMenu.Run();

        }
    }
}
