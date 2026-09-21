class Map
{
 private Location?[][] locations =
    {
        new Location? [5] {null,            null,            new Escalator1(),      new Roof(),       null},
        new Location? [5] {new Foyer(),     new Escalator2(), new CorridorA(),      null,       null},
        new Location? [5] {new ToiletStall(), null,       new OutsideDryCleaner(), new CorridorB(), null},
        new Location? [5] {null,            null,         new DryCleaner(), new SecurityOffice(), new TaxiStation()}

    };

    public Location GetLocation(int row, int col)
    {
      return locations[row][col]!; 
    }

public bool PositionExists(int row, int col)
    {
        if(row < 0 || row >= locations.Length)
        {
            return false;
        }

        if(col < 0 || col >= locations[row].Length)
        {
            return false;
        }

        if (locations[row][col] == null)
        {
            return false;
        }

        return true;
    }

}