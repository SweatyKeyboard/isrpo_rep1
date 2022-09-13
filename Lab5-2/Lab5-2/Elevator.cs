class Elevator
{
    public int MaxFloor { get; set; }

    private Doors _doors;
    private Moving _moving;

    public Doors Doors => _doors;
    public Moving Moving => _moving;
    public int Floor { get; set; }

    public event System.Action OnMovingEnd;

    public void OpenDoors()
    {
        _doors = Doors.Opened;
    }

    public void CloseDoors()
    {
        _doors = Doors.Closed;
    }

    public void MoveToFloor(int targetFloor)
    {
        if (_doors == Doors.Opened ||
            Floor == targetFloor||
            targetFloor < 1 ||
            targetFloor > MaxFloor)
        {
            _moving = Moving.Stay;
            OnMovingEnd?.Invoke();
            return;
        }

        if (Floor < targetFloor)
        {
            _moving = Moving.Up;
            Floor++;
        }
        else
        {
            _moving = Moving.Down;
            Floor--;
        }
    }
}
