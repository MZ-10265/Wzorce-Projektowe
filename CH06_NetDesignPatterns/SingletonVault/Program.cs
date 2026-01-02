

var v1 = Vault.Instance;
var v2 = Vault.Instance;

Console.WriteLine($"Czy v1 i v2 to ta sama instancja? {ReferenceEquals(v1, v2)}");

// Pierwsze pobranie zwraca true i klucz
Console.WriteLine($"Pierwsze pobranie: {v1.TryGetKey(out var key1)} -> {key1}");

// Drugie pobranie zwraca false
Console.WriteLine($"Drugie pobranie:  {v2.TryGetKey(out var key2)} -> {key2}");
