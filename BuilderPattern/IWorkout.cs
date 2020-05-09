namespace BuilderPattern
{
    public interface IWorkout
    {
        void CreateNewWorkoutScheme();
        void ScheduleWorkoutDay(string dayOfWeek);
        void AddPushUp();
        void AddSquat();
        void AddBicycleManoeuvre();
        void AddPullUp();
        void AddSwissBallHamsteringCurl();
        void AddTricepsDips();
        void AddLunge();
        void AddSideBridge();
        IScheme GetScheme();
    }
}