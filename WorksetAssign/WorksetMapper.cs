using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace WorksetAssign
{
    internal static class WorksetMapper
    {
        internal static SortedDictionary<string, WorksetId> getMapper(Document doc)
        {
            SortedDictionary<string, WorksetId> mapper = new SortedDictionary<string, WorksetId>();
            FilteredWorksetCollector worksetCollector = new FilteredWorksetCollector(doc);
            List<Workset> worksets = worksetCollector.OfKind(WorksetKind.UserWorkset).ToList();

            foreach (Workset workset in worksets)
            {
                mapper.Add(workset.Name, workset.Id);
            }

            return mapper;
        }
    }
}
