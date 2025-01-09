namespace WorkDemoElevator
{
    public class Request
    {
        public int Floor { get; set; }
        public string Message { get; set; }

        public Request(int floor, string message)
        {
            Floor = floor;
            Message = message;
        }
    }
}
