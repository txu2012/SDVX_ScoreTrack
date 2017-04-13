﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVX_ScoreTracker
{
    public class CalculatorGrade
    {
        private float totalNotes;
        private long totalScore = 10000000;

        public long scoreCalc(float crits, float nears, float errors)
        {
            float critVal, errorVal, nearVal, curScore;

            totalNotes = crits + nears + errors;
            critVal = totalScore / totalNotes;
            nearVal = critVal / 2;
            errorVal = critVal;

            if (errors == 0 && nears == 0 && crits == 0)
            {
                curScore = 0;
            }
            else if (errors == 0 && nears == 0)
            {
                curScore = (float)totalScore;
            }
            else
            {
                curScore = (critVal * crits) + (nearVal * nears);
            }

            return Convert.ToInt64(curScore);
        }

        public string gradeCheck(float score)
        {
            string grade;
            if (score >= 9900000)
            {
                grade = "S";
            }
            else if (score >= 9800000 && score < 9900000)
            {
                grade = "AAA+";
            }
            else if (score >= 9700000 && score < 9800000)
            {
                grade = "AAA";
            }
            else if (score >= 9500000 && score < 9700000)
            {
                grade = "AA+";
            }
            else if (score >= 9300000 && score < 9500000)
            {
                grade = "AA";
            }
            else if (score >= 9000000 && score < 9300000)
            {
                grade = "A+";
            }
            else if (score >= 8700000 && score < 9000000)
            {
                grade = "A";
            }
            else if (score >= 8000000 && score < 8700000)
            {
                grade = "B";
            }
            else if (score >= 7000000 && score < 8000000)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
            return grade;
        }
    }
}