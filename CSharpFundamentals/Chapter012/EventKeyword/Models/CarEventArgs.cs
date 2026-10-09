namespace EventKeyword.Models;

internal class CarEventArgs : EventArgs {
    public readonly string Msg;

    public CarEventArgs(string message) {
        Msg = message;
    }
}