﻿using System;
using System.IO;
using EntityFrameworkTest.Droid.Implementations;
using EntityFrameworkTest.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(DbPathAndroid))]
namespace EntityFrameworkTest.Droid.Implementations
{
    public class DbPathAndroid : IDbPathDevice
    {
        public string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "EFCore.db");
        }
    }
}