namespace BuilderPattern
{
    public class FitnessExercices : IWorkout
    {
        private FitnessScheme fitnessScheme;
        private Day currentDay;

        public FitnessExercices()
        {
            CreateNewWorkoutScheme();
        }

        public void CreateNewWorkoutScheme() => fitnessScheme = new FitnessScheme();

        public void ScheduleWorkoutDay(string dayOfWeek)
        {
            currentDay = new Day(dayOfWeek);
            fitnessScheme.AddDay(currentDay);
        }
        
        public void AddPushUp() => currentDay.AddWorkout(new Workout("PushUp"));

        public void AddSquat() => currentDay.AddWorkout(new Workout("Squad"));

        public void AddBicycleManoeuvre() => currentDay.AddWorkout(new Workout("Bicycle Manoeuvre"));

        public void AddPullUp() => currentDay.AddWorkout(new Workout("Pull Up"));

        public void AddSwissBallHamsteringCurl() => currentDay.AddWorkout(new Workout("Swiss Ball Hamstering Curl"));

        public void AddTricepsDips() => currentDay.AddWorkout(new Workout("Triceps Dips"));

        public void AddLunge() => currentDay.AddWorkout(new Workout("Lunge"));

        public void AddSideBridge() => currentDay.AddWorkout(new Workout("Side Bridge"));
        public FitnessScheme GetScheme() => fitnessScheme;
    }
}