#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace RAB_Challenge_06chatbot
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

            // Create a new panel and add it to the Add-Ins tab
            RibbonPanel panel = uiapp.CreateRibbonPanel("Revit Add-in Bootcamp", "Revit Tools");

            // Create the push buttons and add them to the panel
            PushButton tool1Button = panel.AddItem(new PushButtonData("Tool 1", "Tool 1", Assembly.GetExecutingAssembly().Location, "RAB_Challenge_06chatbot.PushButton1")) as PushButton;
            PushButton tool2Button = panel.AddItem(new PushButtonData("Tool 2", "Tool 2", Assembly.GetExecutingAssembly().Location, "RAB_Challenge_06chatbot.PushButton2")) as PushButton;
            // Create the push buttons and add them to the panel
            PushButton tool3Button = panel.AddItem(new PushButtonData("Tool 3", "Tool 3", Assembly.GetExecutingAssembly().Location, "RAB_Challenge_06chatbot.PushButton1")) as PushButton;
            PushButton tool4Button = panel.AddItem(new PushButtonData("Tool 4", "Tool 4", Assembly.GetExecutingAssembly().Location, "RAB_Challenge_06chatbot.PushButton2")) as PushButton;

            return Result.Succeeded;
        }
    }
}
