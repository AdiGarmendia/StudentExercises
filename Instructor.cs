using System;
using System.Collections.Generic;

namespace StudentExercises {
  public class Instructor {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }
    public string Specialty { get; set; }

    public void assignExercise (Exercise exercise, Student student) {
      student.Exercises.Add (exercise);
    }
    // Constructor
    public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort, string specialty) {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      Cohort = cohort;
      Specialty = specialty;
    }
  }
}