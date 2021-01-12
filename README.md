# Cel repozytorium

Przygotowanie scenariuszy i przypadków testowych na podstawie aplikacji Make a Transfer. 

# Aplikacja webowa "Make a Transfer" 

Aplikacja służy do wykonywania przelewów. Funkcjonalność dostępna jest dla zalogowanych użytkowników, dlatego udostępniono interfejs umożliwiający utworzenie konta użytkownika oraz mechanizm logowania do aplikacji. W celu zapewnienia poprawności wykonywanych przez użytkowników transakcji, aplikacja weryfikuje poprawność danych wprowadzanych w formularzu wykonania przelewu.

<a href="https://makeatransfer.azurewebsites.net/">Link do aplikacji</a>

## Założenia aplikacji „Make a Transfer 
<ol>
  <li>Rejestracja
    <ul>
      <li>Wszystkie pola są wymagane.</li>
      <li>Weryfikacja poprawności adresu email: brak znaków specjalnych przed emailem, prawidłowo skonstruowana domena, znak „@” w adresie, brak znaków diakrytycznych.</li>
      <li>Wymagane hasło skonstruowane zgodnie z zasadami budowy silnych haseł: minimum 6 znaków, jeden znak specjalny, jedna cyfra i jedna wielka literę.</li>
      <li>Potwierdzenie hasła.</li>
      <li>Weryfikacja konta.</li>
      <li>Błędy w uzupełnieniu formularza widoczne dla użytkownika – informacja zwrotna.</li>
   </ul>
  </li>
  <li>Logowanie
    <ul>
     <li>Wszystkie pola są wymagane.</li>
     <li>Dopuszczenia logowania do aplikacji tylko dla użytkowników ze zweryfikowanym kontem.</li>
     <li>Możliwość zapamiętania ostatniego logowania.</li>
    </ul>
  </li>
  <li>Wykonywanie przelewu.
    <ul>
      <li>Wszystkie pola są wymagane.</li>
      <li>Pole „Tytuł” ograniczone do 64 znaków.</li>
      <li>Pole „Numer konta” wymaga wprowadzenia 26 znaków numerycznych.</li>
      <li>Kwota przelewu musi być większa od 0. Przelewy powyżej 5000 wymagają dodatkowej autoryzacji hasłem użytkownika.</li>
      <li>Użytkownik zostanie poinformowany o niepoprawnym uzupełnieniu formularza poprzez wyświetlenie komunikatu walidacji pod kontrolką, w której został popełniony błąd.</li>
    </ul>
  </li>
<ol>


## Demo aplikacji Make a transfer:
Przykład prezentujący funkcjonalności rejestracji użytkownika, logowania i wysyłania przelewu.

![](docs/app_demo.gif)

## Scenariusze testowe

### Rejestracja nowego użytkownika

### Wykonywanie przelewów 
<a href="docs/test scenarios/make_transfer.xlsx" download="docs/test scenarios/make_transfer.xlsx">Pobierz scenariusz testowy wraz wykrytymi błędami - arkusz excel</a>

