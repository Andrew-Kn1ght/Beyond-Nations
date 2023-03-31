using static Event;

public class ChunkGenerateEvent : Event {
    private int chunkX;
    private int chunkZ;

    public ChunkGenerateEvent(int chunkX, int chunkZ) : base(EventType.ChunkGenerate, "A chunk has been generated at (" + chunkX + ", " + chunkZ + ").") {
        this.chunkX = chunkX;
        this.chunkZ = chunkZ;
    }

    public int ChunkX {
        get { return chunkX; }
        set { chunkX = value; }
    }

    public int ChunkZ {
        get { return chunkZ; }
        set { chunkZ = value; }
    }
}