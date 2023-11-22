using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section015_GetHashCodeAndEquals.Entities;

public class Client {

    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int Id { get; set; }

    public Client() {}

    public Client(string name, string email, int id) {
        Name = name;
        Email = email;
        Id = id;
    }

    public override bool Equals(object? obj) {

        if(obj is not Client) {
            return false;
        }

        Client? other = obj as Client;

        return Email.Equals(other?.Email);
    }

    public override int GetHashCode() {
        return Email.GetHashCode();
    }
}
