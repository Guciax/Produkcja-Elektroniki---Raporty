using MST.MES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MST.MES.OrderStructureByOrderNo;

namespace Produkcja_Elektroniki___Raporty.DataLoader
{
    public class MergeData
    {
        public class DataMerger
        {
            public static void MergeData(ref Dictionary<string, OrderStructureByOrderNo.OneOrderData> inputDict,
                Dictionary<string, OrderStructureByOrderNo.Kitting> kitting,
                Dictionary<string, OrderStructureByOrderNo.SMT> smt = null,
                Dictionary<string, TestInfo> test = null,
                Dictionary<string, OrderStructureByOrderNo.VisualInspection> vi = null,
                Dictionary<string, ReworkInfo> rework = null)
            {

                foreach (var kittingEntry in kitting)
                {
                    if (!inputDict.ContainsKey(kittingEntry.Key))
                    {
                        inputDict.Add(kittingEntry.Key, new OneOrderData());
                    }
                    if (inputDict[kittingEntry.Key].kitting != null) continue;

                    inputDict[kittingEntry.Key].kitting = kittingEntry.Value;
                    inputDict[kittingEntry.Key].smt = new SMT();
                    inputDict[kittingEntry.Key].visualInspection = new VisualInspection();
                }


                if (smt != null)
                {
                    foreach (var smtEntry in smt)
                    {
                        if (!kitting.ContainsKey(smtEntry.Key)) continue;
                        if (!inputDict.ContainsKey(smtEntry.Key))
                        {
                            inputDict.Add(smtEntry.Key, new OneOrderData());
                        }

                        inputDict[smtEntry.Key].smt = smtEntry.Value;
                    }
                }

                if (test != null)
                {
                    foreach (var testEntry in test)
                    {
                        if (!kitting.ContainsKey(testEntry.Key)) continue;
                        if (!inputDict.ContainsKey(testEntry.Key))
                        {
                            inputDict.Add(testEntry.Key, new OneOrderData());
                        }

                        inputDict[testEntry.Key].test = testEntry.Value;
                    }
                }

                if (vi != null)
                {
                    foreach (var viEntry in vi)
                    {
                        if (!kitting.ContainsKey(viEntry.Key)) continue;
                        if (!inputDict.ContainsKey(viEntry.Key))
                        {
                            inputDict.Add(viEntry.Key, new OneOrderData());
                        }

                        inputDict[viEntry.Key].visualInspection = viEntry.Value;
                    }
                }

                if (rework != null)
                {
                    foreach (var reworkEntry in rework)
                    {
                        if (!kitting.ContainsKey(reworkEntry.Key)) continue;
                        if (!inputDict.ContainsKey(reworkEntry.Key))
                        {
                            inputDict.Add(reworkEntry.Key, new OneOrderData());
                        }

                        inputDict[reworkEntry.Key].rework = reworkEntry.Value;
                    }
                }
            }



        }
    }
}
