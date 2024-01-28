# CarManager

## Wprowadzenie
Aplikacja CarManager jest systemem zarządzania autami stworzonym w technologii .NET MVC. Pozwala na śledzenie i zarządzanie stanem floty pojazdów.

### Wymagania
- .NET Core 5.0
- Microsoft SQL Server

### Instalacja
1. Sklonuj repozytorium: `git clone https://github.com/sgrebocki/CarAPI`
2. Zainstaluj wymagane pakiety: `dotnet restore`
3. Uruchom aplikację: `dotnet run`

## Architektura

### Model
Modele danych używane w aplikacji 
- `Car`,
- `UserModel`
- `ErrorViewModel`
- `Login`
- `Register`

### View
Widoki dostępne w aplikacji
- `Login`
- `Register`
- `Index`
- `Create`
- `Edit`
- `GetById`
- `List`

### Controller
Kontrolery i ich akcje
- `AccountController` (Logowanie/Rejestracja)
- `CarController` (CRUD)

## Funkcjonalności

### Zarządzanie pojazdami
- Dodawanie nowych pojazdów
- Edycja istniejących pojazdów
- Usuwanie pojazdów
