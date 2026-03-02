using BCrypt.Net;

string password = "MyPassword123";

// Hash
string hash = BCrypt.Net.BCrypt.HashPassword(password);

// Verify
bool isValid = BCrypt.Net.BCrypt.Verify(password, hash);

Console.WriteLine($"Hash: {hash}");
Console.WriteLine($"Valid: {isValid}");