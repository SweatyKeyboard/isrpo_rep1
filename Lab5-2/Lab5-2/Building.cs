class Building
{
    public int FloorsNumber { get; set; }
    private Elevator _elevator;
    public Elevator Elevator => _elevator;

    public Building(int floorsNumber)
    {
        FloorsNumber = floorsNumber;
        _elevator = new Elevator();
        _elevator.MaxFloor = floorsNumber;
        _elevator.Floor = 1;
    }
}
