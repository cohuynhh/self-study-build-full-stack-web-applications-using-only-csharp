using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomQuizClient
{
    public class GeneralData
    {
        public static class CurrentQuiz
        {
            public static List<ClassroomQuizClient.DataModels.Questions.FullQuestion> Questions = null;
            public static ClassroomQuizClient.DataModels.Quizzes.FullQuiz Quiz = null;
        }


        public static System.Net.Http.HttpClient Http = new System.Net.Http.HttpClient() {  BaseAddress = new Uri("https://localhost:44373") };
    }
}
