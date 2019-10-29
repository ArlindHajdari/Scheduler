namespace ScheduleManagementSystem
{
    public static class Log
    {   
        //Te dhenat per perdoruesin qe kycet ne sistem
        public static int? id;
        public static string role;
        public static string name;
        public static string surname;

        
        public static void LogOut()
        {
            id = null;
            role = null;
            name = null;
            surname = null;
        }
    }
}
