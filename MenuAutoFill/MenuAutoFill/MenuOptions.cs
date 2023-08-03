using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;


namespace MenuAutoFill
{
    public class MenuOptions
    {
        [CommandMethod("MenuOptions")]

        public void MenuOptionsApplication()
        {
            MenuOptionsForm mof = new MenuOptionsForm();
            mof.ShowDialog();
        }


    }
}
