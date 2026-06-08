namespace ShoeStore.Models;

public class ShoeCloset {
    private readonly List<Shoe> _shoes = [];

    public void AddShoe(Shoe shoe) {
        _shoes.Add(shoe);
    }

    public Shoe? RemoveShoeAt(int index) {
        if (index < 0 || index >= _shoes.Count) return null;

        Shoe shoe = _shoes[index];
        _shoes.RemoveAt(index);

        return shoe;
    }

    public void PrintShoes() {
        if (_shoes.Count == 0) {
            Console.WriteLine("The shoe closet is empty.");
            return;
        }

        Console.WriteLine("The shoe closet contains:");

        for (int i = 0; i < _shoes.Count; i++) {
            Console.Write($"Shoe #{i}: {_shoes[i]}");
        }
    }
}