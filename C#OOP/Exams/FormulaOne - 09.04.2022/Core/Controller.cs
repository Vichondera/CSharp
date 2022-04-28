namespace Formula1.Core.Contracts
{
    using System;
    using System.Text;

    public class Controller : IController
    {
         
        // You need to keep track of some things, this is why you need some private fields in your controller class:
        // pilotRepository - PilotRepository
        // raceRepository - RaceRepository
        // carRepository - FormulaOneCarRepository
        public string AddCarToPilot(string pilotName, string carModel)
        {
            
            // Adds a car with the given car model to a pilot with the given name.
            // After successfully adding a car to a pilot,
            // remove the car from the FormulaOneCarRepository:

            // If the pilot does not exist, or the pilot already has a car,
            // throw new InvalidOperationException $"Pilot {pilotFullName} does not exist or has a car.";

            // If the car model does not exist,
            // throw new NullReferenceException $"Car {model} does not exist."

            return $"Pilot {pilotName} will drive a {pilotName} {carModel} car.";
        }


        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            // Adds a pilot with the given name, to the race with the given race name.

            // If the race does not exist,
            // throw new NullReferenceException $"Race { race name } does not exist.";

            // If the pilot does not exist,
            // or the pilot can not race,
            // or the pilot is already in the race,
            // throw new InvalidOperationException $"Can not add pilot {pilotFullName} to the race.";

            return $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            // Creates a formula one car with the given parameters and adds it to the FormulaOneCarRepository.
            // Valid types are: "Ferrari" and "Williams":

            // If a car with the given model exists,
            // throw new InvalidOperationException $"Formula one car {model} is already created.";

            // If the car type is invalid,
            // throw new InvalidOperationException $"Formula one car type {type} is not valid.";

            return $"Car {type}, model {model} is created.";
        }

        public string CreatePilot(string fullName)
        {
            // If a pilot with the given full name exists,
            // throw a InvalidOperationException($"Pilot {fullName} is already created.");

            // If the Pilot is added successfully to the repository,
            return $"Pilot {fullName} is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            // Creates a race with the given name, number of laps and adds it to the RaceRepository:
            // If a race with the given race name exists,
            // throw new InvalidOperationException$"Race {raceName} is already created.";

             return  $"Race {raceName} is created.";
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Pilot {FullName} has {NumberOfWins} wins.");
            // "Pilot {FullName} has {NumberOfWins} wins.
            //  Pilot { FullName} has { NumberOfWins}wins.
            return sb.ToString();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The NAME race has:");
            // "The { race name } race has:
            // Participants: { number of participants }
            // Number of laps: { number of laps }
            // Took place: Yes
            // The { race name }
            // race has:
            // Participants: { number of participants }
            // Number of laps: { number of laps }
            // Took place: Yes
            return sb.ToString();
        }

        public string StartRace(string raceName)
        {
            // If everything is valid, you should arrange for all pilots in the given race to start racing.
            // As a result, this method returns the three fastest pilots.
            // To execute the race you should sort all riders in descending order
            // by the result of the RaceScoreCalculator method in FormulaOneCar object.
            // In the end, if everything is valid set the race's TookPlace property to true, increase the winner's score, and
            // return the corresponding message.

            // If the race does not exist,
            // throw new NullReferenceException $"Race {raceName} does not exist.";

            // If the race has less than 3 pilots,
            // throw new InvalidOperationException $"Race {raceName} cannot start with less than three participants."

            // If the race has been already executed,
            // throw new InvalidOperationException $"Can not execute race { race name }.";

            var sb = new StringBuilder();

            // "Pilot { pilot full name } wins the { race name } race.
            // Pilot { pilot full name } is second in the { race name } race.
            // Pilot { pilot full name } is third in the { race name } race."
            return sb.ToString();
        }
    }
}