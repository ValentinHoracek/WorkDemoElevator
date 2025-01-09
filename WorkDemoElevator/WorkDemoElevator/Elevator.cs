namespace WorkDemoElevator
{
    public class Elevator : IElevator
    {
        public static int TOP_FLOOR = 10;
        public static int BOTTOM_FLOOR = 1;

        // Seznam pozadavku pro vytah
        private Queue<Request> Requests;

        // Aktualni poloha vytahu
        private int CurrentFloor = BOTTOM_FLOOR;


        public Elevator()
        {
            Requests = new();
        }

        // Zavolani vytahu z nejakeho podlazi
        public void CallFrom(int floor)
        {
            Requests.Enqueue(new Request(floor, $"REQUEST FROM {floor}. FLOOR."));
            Going();
        }


        // Urceni kam ma vytah dojet
        public void MoveTo(int floor)
        {
            Requests.Enqueue(new Request(floor, $"GO TO {floor}. FLOOR."));
            Going();
        }

        // Pohyb vytahu
        private void Going()
        {
            if (Requests.Count != 0)
            {
                Request working = Requests.Dequeue();
                if (working.Floor == CurrentFloor)
                {
                    Console.WriteLine("Already on this floor.");
                }
                else
                {
                    Console.WriteLine(working.Message);
                    while (working.Floor > CurrentFloor)
                    {
                        MoveUp();
                    }
                    while (working.Floor < CurrentFloor)
                    {
                        MoveDown();
                    }
                    Console.WriteLine($"Arrived at {working.Floor}");
                }
            }
        }

        // Pohyb vytahu o patro nahoru
        private void MoveUp()
        {
            Console.WriteLine($"Moving up from {CurrentFloor} to {++CurrentFloor}");
            Task.Delay(5000).GetAwaiter().GetResult();
        }

        // Pohyb vytahu o patro dolu
        private void MoveDown()
        {
            Console.WriteLine($"Moving down from {CurrentFloor} to {--CurrentFloor}");
            Task.Delay(3000).GetAwaiter().GetResult();
        }

        // Validace vstupu uzivatele
        public bool ValidateFloor(int floor)
        {
            if (floor >= BOTTOM_FLOOR && floor <= TOP_FLOOR)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
