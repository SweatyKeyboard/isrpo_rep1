internal interface ICup
{
    string Type { get; set; }
    string Capacity { get; set; }

    void Refill();
    void Wash();
}
