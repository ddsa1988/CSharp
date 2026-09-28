namespace GenericClassesAndStructs.Models;

internal struct PointStruct<T> where T : struct {
    private T? _xPos;
    private T? _yPos;

    public PointStruct(T xPos, T yPos) {
        _xPos = xPos;
        _yPos = yPos;
    }

    public T? XPos {
        get => _xPos;
        set => _xPos = value;
    }

    public T? YPos {
        get => _yPos;
        set => _yPos = value;
    }

    public void ResetPoint() {
        XPos = default(T);
        YPos = default(T);
    }

    public override string ToString() {
        return $"Point Struct {{ {nameof(XPos)}: {XPos}, {nameof(YPos)}: {YPos} }}";
    }
}