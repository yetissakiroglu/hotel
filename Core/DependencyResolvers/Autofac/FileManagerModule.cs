using Autofac;
using Core.Services.FileManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers.Autofac
{
    public class FileManagerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileManager>().As<IFileManager>();
        }
    }
}
