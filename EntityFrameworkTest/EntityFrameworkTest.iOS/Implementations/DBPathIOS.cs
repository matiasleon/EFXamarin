
using System;
using System.IO;
using EntityFrameworkTest.Helpers;
using EntityFrameworkTest.iOS.Implementations;

[assembly: Xamarin.Forms.Dependency(typeof(DBPathIOS))]
namespace EntityFrameworkTest.iOS.Implementations
{
    public class DBPathIOS : IDbPathDevice
    {
        public string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "EFCore.db");
        }
    }
}