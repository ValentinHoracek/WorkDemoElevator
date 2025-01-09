namespace WorkDemoElevator
{
    public interface IElevator
    {
        public void CallFrom(int floor);

        public void MoveTo(int floor);

        public bool ValidateFloor(int floor);
    }
}
