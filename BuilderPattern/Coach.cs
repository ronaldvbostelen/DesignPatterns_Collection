using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Coach
    {
        public IScheme FitnessScheme { get; private set; }
        private IWorkout workoutBuilder;
        public Coach()
        {
            workoutBuilder = new FitnessExercices();
        }

        public void NewFitnessScheme() => workoutBuilder.CreateNewWorkoutScheme();

        public void MakeFitnessScheme()
        {
            workoutBuilder.ScheduleWorkoutDay("Monday");
            workoutBuilder.AddBicycleManoeuvre();
            workoutBuilder.AddLunge();
            workoutBuilder.AddPullUp();
            workoutBuilder.ScheduleWorkoutDay("Wednesday");
            workoutBuilder.AddPullUp();
            workoutBuilder.AddLunge();
            workoutBuilder.AddSwissBallHamsteringCurl();
            workoutBuilder.AddTricepsDips();
            workoutBuilder.ScheduleWorkoutDay("Friday");
            workoutBuilder.AddPushUp();
            workoutBuilder.AddPushUp();
            workoutBuilder.AddSideBridge();
            workoutBuilder.AddSquat();

            FitnessScheme = workoutBuilder.GetScheme();
        }
    }
}
