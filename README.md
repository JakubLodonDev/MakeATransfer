# Cel repozytorium

Przygotowanie scenariuszy i przypadków testowych na podstawie aplikacji Make a Transfer. 

# Aplikacja webowa "Make a Transfer" 

Aplikacja służy do wykonywania przelewów. Aby wykonać przelew, musisz być zalogowany. 
W tym celu aplikacja umożliwia utworzenie użytkownika i mechanizmy logowania.
Aplikacja ma zapewnić, że zostaną wysłane tylko przelewy, które dane są poprawne.

<a href="https://makeatransfer.azurewebsites.net/">Link do aplikacji</a>

## Funkcjonalność wysłana przelewu 

Zakładka „Make a transfer” ma się zachowywać w następujący sposób:

a)	Zakładka jest widoczna i dostępna tylko dla zalogowanego użytkownika 

b)	Wszystkie pola na formularzu muszą zostać uzupełnione

c)	Numer konta wysyłającego nie może być taki sam jak numer konta odbiorcy

d)	Numery kont mają mieć dokładnie 26 znaków

e)	Kwota musi być większa od 0 


## Demo aplikacji Make a transfer:
Przykład prezentujący funkcjonalności rejestracji użytkownika, logowania i wysyłania przelewu.

![](docs/app_demo.gif)

## Scenariusze testowe

### Rejestracja nowego użytkownika

### Wykonywanie przelewów 
<a href="docs/test scenarios/make_transfer.xlsx" download="docs/test scenarios/make_transfer.xlsx">Pobierz scenariusz testowy wraz wykrytymi błędami - arkusz excel</a>

