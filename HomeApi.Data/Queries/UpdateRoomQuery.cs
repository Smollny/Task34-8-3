namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении комнаты
    /// </summary>
    public class UpdateRoomQuery
    {
        public string NewName { get; }
        public int NewArea { get;  }
        public bool NewGasConnected { get;  }
        public int NewVoltage { get; }

        public UpdateRoomQuery(string newName = null, int newArea = 0, bool newGasConnection=false, int newVoltage = 0)
        {
            NewName = newName;
            NewArea = newArea;
            NewGasConnected = newGasConnection;
            NewVoltage = newVoltage;
        }
    }
}