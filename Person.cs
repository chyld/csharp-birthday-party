namespace sweet
{
  record Person
  {
    public string? Name { get; init; }
    public ushort Age { get; init; }

    public override string ToString()
    {
      return $"{Name}/{Age}";
    }
  }
}
