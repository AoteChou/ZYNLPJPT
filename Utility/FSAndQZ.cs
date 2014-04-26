using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJPT.Utility
{
    public class FSAndQZ
    {
        public FSAndQZ()
        {
            fsList = new List<int>();
            qzList = new List<float>();
        }
        private List<int> fsList;//分数

        public List<int> FsList
        {
            get { return fsList; }
            set { fsList = value; }
        }
        private List<float> qzList;//权重

        public List<float> QzList
        {
            get { return qzList; }
            set { qzList = value; }
        }

        public int getweightedaverage() {
            float numerator=0;
            float denominator=0;
            if (qzList.Count == 0) {
                return 0;
            }
            for (int i=0;i<qzList.Count;i++) {
                numerator += fsList[i] * qzList[i];
                denominator += qzList[i];
            }
            return (int)Math.Round(numerator/denominator);
        }
    }
}