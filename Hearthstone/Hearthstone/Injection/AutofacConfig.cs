using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Hearthstone.Collections;
using Hearthstone.Contracts;
using Hearthstone.Engine;
using Hearthstone.Engine.Contracts;
using Hearthstone.Engine.Factory;

namespace Hearthstone.Injection
{
    internal sealed class AutofacConfig: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Hearthstone")).AsImplementedInterfaces();
            builder.RegisterType<DeckCollection>().As<IDeckCollection>().SingleInstance();
            builder.RegisterType<PlayGame>().As<IPlayGame>().SingleInstance();
            
            builder.RegisterType<MainMenu>().As<IMainMenu>().SingleInstance();
            builder.RegisterType<CardFactory>().As<ICardFactory>().SingleInstance();
            builder.RegisterType<DeckCollectionManager>().As<IDeckCollectionManager>().SingleInstance();
            builder.RegisterType<Constants>().AsSelf().SingleInstance();



        }
    }
}
