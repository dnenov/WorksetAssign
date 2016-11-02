using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksetAssign
{
    internal static class WorksetAssign
    {
        internal static string tName = "Workset Assign";

        internal static void Assign(Document doc, WorksetId worksetId, string workset, Category cat, string category, ProgressBar progressBar, Label label, out string message)
        {
            List<Element> elements = recursiveElements(doc, cat);
            
            int converted = 0;
            int failed = 0;

            if (elements.Count() == 0)
            {
                message = "No elements of that Category were found.";
                return;
            }

            progressBar.Minimum = 0;
            progressBar.Maximum = elements.Count;
            
            using (Transaction t = new Transaction(doc, tName))
            {
                FailureHandlingOptions foptions = t.GetFailureHandlingOptions();
                FailureHandler fhandler = new FailureHandler();
                foptions.SetFailuresPreprocessor(fhandler);
                foptions.SetClearAfterRollback(true);
                t.SetFailureHandlingOptions(foptions);
                
                t.Start();

                foreach (Element el in elements)
                {
                    if (el.WorksetId.IntegerValue != worksetId.IntegerValue) //only convert if they are not in that workset
                    {
                        if(el.get_Parameter(BuiltInParameter.ELEM_PARTITION_PARAM).IsReadOnly)
                        {
                            failed++;
                            progressBar.Value++;
                            label.Text = String.Format("Completed {0} of {1}", progressBar.Value.ToString(), progressBar.Maximum.ToString());
                            label.Refresh();
                            continue;
                        }
                        try
                        {
                            el.get_Parameter(BuiltInParameter.ELEM_PARTITION_PARAM).Set(worksetId.IntegerValue);
                            converted++;
                        }
                        catch
                        {

                        }
                    }
                    progressBar.Value++;
                    label.Text = String.Format("Completed {0} of {1}", progressBar.Value.ToString(), progressBar.Maximum.ToString());
                    label.Refresh();
                }
                t.Commit();
            }
            if(failed == 0)
            {
                message = String.Format("{0} elements of {1} Category have been assinged to {2} Workset.",
                        converted.ToString(), category, workset);
            }
            else
            {
                message = String.Format("{0} elements of {1} Category have been assinged to {2} Workset.{3}{4}{5} elements were read-only and failed to be reasigned.",
                        converted.ToString(), category, workset, Environment.NewLine, Environment.NewLine, failed.ToString());
            }
        }

        private static List<Element> recursiveElements(Document doc, Category cat)
        {
            List<Element> elements = new List<Element>();
            List<Category> subCat = CategoriesMapper.getSubCategories(doc, cat);

            if (subCat != null)
            {
                foreach (Category subCategory in subCat)
                {
                    //The recursion
                    var subElem = recursiveElements(doc, subCategory);
                    elements.AddRange(subElem);
                }
            }

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            List<Element> thisElements = collector.OfCategoryId(cat.Id)
                .WhereElementIsNotElementType()
                .ToElements()
                .ToList();
            elements.AddRange(thisElements);

            return elements;
        }
    }

    public class FailureHandler : IFailuresPreprocessor
    {
        public FailureHandler()
        {
        }

        public FailureProcessingResult PreprocessFailures(
            FailuresAccessor failuresAccessor)
        {
            IList<FailureResolutionType> resolutionTypeList = new List<FailureResolutionType>();

            IList<FailureMessageAccessor> failureMessages = failuresAccessor.GetFailureMessages();

            if (failureMessages.Count == 0)
            {
                return FailureProcessingResult.Continue;
            }
            else
            {
                foreach (FailureMessageAccessor fma in failureMessages)
                {
                    // check how many resolutions types were attempted to try to prevent
                    // entering infinite loop
                    /*
                    resolutionTypeList = failuresAccessor.GetAttemptedResolutionTypes(fma);
                    FailureDefinitionId failId = fma.GetFailureDefinitionId();

                    string failureName = fma.ToString();

                    if(resolutionTypeList.Count >= 3)
                    {
                        return FailureProcessingResult.ProceedWithRollBack;
                    }
                    */
                    FailureSeverity fsav = fma.GetSeverity();

                    if (fsav == FailureSeverity.Warning)
                    {
                        failuresAccessor.DeleteWarning(fma);
                    }
                    else
                    {
                        failuresAccessor.ResolveFailure(fma);
                        return FailureProcessingResult.ProceedWithRollBack;
                    }
                }
                return FailureProcessingResult.Continue;
            }         
        }
    }
}
