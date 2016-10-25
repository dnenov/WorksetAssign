#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Linq;
#endregion

namespace WorksetAssign
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            WindowHandle _hWndRevit = null;

            if (null == _hWndRevit)
            {
                Process process
                  = Process.GetCurrentProcess();

                IntPtr h = process.MainWindowHandle;
                _hWndRevit = new WindowHandle(h);
            }

            using (ElementToWorkest mapper = new ElementToWorkest(doc))
            {
                var result = mapper.ShowDialog(_hWndRevit);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    return Result.Succeeded;
                }
                else
                {
                    return Result.Cancelled;
                }
            }

        }
    }

    /// <summary>
    /// Retrieve Revit Windows thread in order to pass it to the form as it's owner
    /// </summary>
    public class WindowHandle : System.Windows.Forms.IWin32Window
    {
        IntPtr _hwnd;

        public WindowHandle(IntPtr h)
        {
            Debug.Assert(IntPtr.Zero != h,
              "expected non-null window handle");

            _hwnd = h;
        }

        public IntPtr Handle
        {
            get
            {
                return _hwnd;
            }
        }
    }
}
