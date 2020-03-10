using System;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            Exercise MartinsAquarium = new Exercise ("Martin's Aquarium", "HTML");
            Exercise Glassdale = new Exercise ("Glassdale", "Javascript");
            Exercise KandyKorner = new Exercise ("Kandy Korner", "Javascript");
            Exercise Nutshell = new Exercise ("Nutshell", "React.js");

            Cohort Cohort36 = new Cohort ("Cohort 36");
            Cohort Cohort37 = new Cohort ("Cohort 37");
            Cohort Cohort38 = new Cohort ("Cohort 38");
            Cohort Cohort39 = new Cohort ("Cohort 39");

            Student AdrianGarmendia = new Student ("Adrian", "Garmendia", "Adrian Garmendia", Cohort37);
            Cohort37.addStudent (AdrianGarmendia);
            Student HoldenParker = new Student ("Holden", "Parker", "Holden Parker", Cohort37);
            Cohort37.addStudent (HoldenParker);
            Student YoMomma = new Student ("Yo", "Momma", "Yo Momma", Cohort37);
            Cohort37.addStudent (YoMomma);
            Student WhoDat = new Student ("Who", "Dat", "Who Dat", Cohort37);
            Cohort37.addStudent (WhoDat);
            Student SpencerTruett = new Student ("Spencer", "Truett", "Spencer Truett", Cohort37);
            Cohort37.addStudent (SpencerTruett);
            Student SuperFly = new Student ("Super", "Fly", "Super Fly", Cohort36);
            Cohort36.addStudent (SuperFly);

            Instructor SteveBrownlee = new Instructor ("Steve", "Brownlee", "coach", Cohort37, "Dad Jokes");
            Instructor MoSilvera = new Instructor ("Mo", "Silvera", "Mo", Cohort37, "Management");
            Instructor LeahHoefling = new Instructor ("Leah", "Hoefling", "Leah", Cohort37, "Lemurs");
            Instructor AdamSheaffer = new Instructor ("Adam", "Sheaffer", "adamsheaf", Cohort37, "stuff");
            Instructor RoseWisotzky = new Instructor ("Rose", "Wisotzky", "Rose Wisotzky", Cohort37, "stuff");
            Instructor BrendaLong = new Instructor ("Brenda", "Long", "bjlong", Cohort37, "stuff");

            SteveBrownlee.assignExercise (Nutshell, SpencerTruett);
            SteveBrownlee.assignExercise (KandyKorner, SuperFly);
            SteveBrownlee.assignExercise (MartinsAquarium, HoldenParker);
            SteveBrownlee.assignExercise (Glassdale, WhoDat);
            SteveBrownlee.assignExercise (Glassdale, YoMomma);
            SteveBrownlee.assignExercise (Nutshell, AdrianGarmendia);

            foreach (Student student in Cohort37.Students) {
                student.Description ();
            }

            foreach (Student student in Cohort36.Students) {
                student.Description ();
            }

        }
    }
}