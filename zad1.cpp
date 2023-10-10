#include <iostream>
#include <string>

int main() {
    std::string username, password;

    // Zdefiniuj prawidłową nazwę użytkownika i hasło
    std::string correctUsername = "admin";
    std::string correctPassword = "haslo123";

    std::cout << "Witaj w systemie weryfikacji hasel!" << std::endl;

    // Pobierz dane od użytkownika
    std::cout << "Podaj nazwę użytkownika: ";
    std::cin >> username;
    std::cout << "Podaj hasło: ";
    std::cin >> password;

    // Sprawdź, czy podane dane są prawidłowe
    if (username == correctUsername && password == correctPassword) {
        std::cout << "Dostęp przyznany! Witaj, admin." << std::endl;
    } else {
        std::cout << "Dostęp odrzucony. Nieprawidłowa nazwa użytkownika lub hasło." << std::endl;
    }

    return 0;
}