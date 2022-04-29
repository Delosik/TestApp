using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSustem
{
    class TestHelper
    {
        public static DateTime questionStartTime { get; set; }
        public static DateTime questionFinishTime { get; set; }
        public static TimeSpan questionTimeDiff { get; set; }
        public static DateTime testStartTime { get; set; }
        public static DateTime testFininshTime { get; set; }
        public static TimeSpan testTimeDiff { get; set; }

        public static DateTime startTime { get; set; }
        public static DateTime finishTime { get; set; }

        public static int testId { get; set; }
        public static int questionId { get; set; }
        public static int currentQuestion { get; set; }
        public static int allCountQuestions { get; set; }



        public static int userId { get; set; }
        public static int pointsForQuestion { get; set; }
        public static int countRightAnswers { get; set; }
        public static int rightAnswer { get; set; }
    }
}
