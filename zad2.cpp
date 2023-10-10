#include <iostream>
#include <string>
#include <map>

int main() {
    std::map<std::string, std::string> users; // Przechowuje nazwy użytkowników i hasła
    std::string username, password;

    // Dodajmy kilku użytkowników wraz z ich hasłami
    users["admin"] = "haslo123";
    users["user1"] = "password1";
    users["user2"] = "password2";

    std::cout << "Witaj w systemie weryfikacji hasel!" << std::endl;

    bool zalogowany = false;
    
    while (!zalogowany) {
        // Pobierz dane od użytkownika
        std::cout << "Podaj nazwę użytkownika: ";
        std::cin >> username;
        std::cout << "Podaj hasło: ";
        std::cin >> password;

        // Sprawdź, czy podane dane są prawidłowe
        if (users.find(username) != users.end() && users[username] == password) {
            std::cout << "Dostęp przyznany! Witaj, " << username << "." << std::endl;
            zalogowany = true;
        } else {
            std::cout << "Dostęp odrzucony. Nieprawidłowa nazwa użytkownika lub hasło." << std::endl;
            char ponownaProba;
            std::cout << "Czy chcesz spróbować ponownie? (T/N): ";
            std::cin >> ponownaProba;
            if (ponownaProba != 'T' && ponownaProba != 't') {
                break;
            }
        }
    }

    return 0;
}