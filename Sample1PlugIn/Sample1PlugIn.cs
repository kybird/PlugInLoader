﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoTechnologies.PlugIn
{
    public class Sample1PlugIn : PlugIn
    {
        public Sample1PlugIn()
        {
            System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();

            Console.WriteLine("Reading config file for " + reader.GetValue("Alias", typeof(string)));
        }


        public override string Name
        {
            get
            {
                return this.GetType().Name;
            }
           
        }

        public override void Initialize()
        {
            Console.WriteLine(Name + " Initializing...");
        }

        public override void Shutdown()
        {
            Console.WriteLine(Name + " Shutdown...");
        }

        public override void Execute()
        {
            Console.WriteLine(Name + " Execute...");
        }

     
    }
}
