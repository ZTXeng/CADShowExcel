using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;

namespace CadMvvm
{
    public class CADApplication : IExtensionApplication
    {
        public void Initialize()
        {
            var r = new Ribbon();
            r.AddButton();
        }

        public void Terminate()
        {
        }
    }
}
