﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectGitHub.Startup))]
namespace TestProjectGitHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);


            //test

           // '///lock;'kl;'
        }
    }
}
